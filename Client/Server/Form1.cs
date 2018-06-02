using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            addMess(txtMess.Text);
            txtMess.Clear();

        }
        void Connect()
        {
            clientList = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
           
        }
        private void Close()
        {
            server.Close();
        }
        private void Send(Socket client)
        {
            if (client != null && txtMess.Text != string.Empty)
                client.Send(Serialize("Server >>>: " + txtMess.Text));
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);
                    string messsage = (string)Deserialize(data);
                    
                    foreach (Socket item in clientList)
                    {
                        if(item != null && item != client)
                            item.Send(Serialize(messsage));
                    }
                    AddMessage(messsage);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }

        }
        void addMess(string s)
        {
            lsvMess.Items.Add(new ListViewItem() { Text = "Đã gửi:" + s });
        }
        void AddMessage(string s)
        {
            lsvMess.Items.Add(new ListViewItem() { Text = s });
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();

        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);

        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }
    }
}
