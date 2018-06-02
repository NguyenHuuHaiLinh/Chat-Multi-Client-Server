using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Client;
using Server;
using FormDangky;

namespace FormDangNhap_2
{
    public partial class Form1 : Form
    {
        string connectionString =
               @"Provider=Microsoft.Jet.OLEDB.4.0;" +
               @"Data Source=C:\Users\asus\Desktop\Multi Chat Client-Server\Client\FormDangNhap\Account.mdb;" +
               @"User Id=;Password=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM Account where username ='" + txtUsername.Text + "' and password ='" + txtPassword.Text + "'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))   //tạo lớp kết nối vào .mbd
            using (OleDbCommand command = new OleDbCommand(queryString, connection))    //tạo lớp lệnh sql sử dụng lớp kết nối trên
            {
                try
                {
                    connection.Open();  //bắt đầu kết nối
                    OleDbDataReader reader = command.ExecuteReader();  //thực thi sql và trả về kết quả

                    if (reader.Read() == true)  //đọc kết quả
                    {

                        FormClient client = new FormClient();
                        client.Text = txtUsername.Text;
                        client.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("thong tin dang nhap sai");
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        txtUsername.Focus();
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Dangky dk = new Dangky();
            dk.Show();
        }
    }
}
