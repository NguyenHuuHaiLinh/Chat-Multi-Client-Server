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


namespace Client
{
    public partial class FormClient : Form
    {
        IPEndPoint IP;
        Socket client;
        public FormClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public static string texttt;
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            addMess(txtMess.Text);
        }
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("ko the ket noi");
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        private void Close()
        {
            client.Close();
        }
        private void Send()
        {
            
            if(txtMess.Text != string.Empty)
                client.Send(Serialize(texttt+": " + txtMess.Text)); // ten ng gui
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);
                    string messsage = (string)Deserialize(data);
                    AddMessage(messsage);
                }
            }
            catch
            {
                Close();
            }
            
        }


        private void addMess(string s)
        { 
            lsvMess.Items.Add(new ListViewItem() { Text =  "Đã gửi: " + s });
            txtMess.Clear();
        }

        private void AddMessage(string s)
        {
            lsvMess.Items.Add(new ListViewItem() { Text =  s });
            txtMess.Clear();
        }


        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream,obj);
            return stream.ToArray();
            
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);    
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            
            Connect();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            txtMess.Text += listBox1.SelectedItem.ToString();
        }

        
        

        private void btnSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
                addMess(txtMess.Text);
            }


        }
    }
}
