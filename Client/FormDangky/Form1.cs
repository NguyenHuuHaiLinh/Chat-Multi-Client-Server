using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FormDangky
{
    public partial class Dangky : Form
    {
        string connectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=C:\Users\asus\Desktop\Multi Chat Client-Server\Client\FormDangNhap\Account.mdb;" +
                @"User Id=;Password=;";
        public Dangky()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNhaplai.Text != txtPassword.Text)
            {
                MessageBox.Show("mật khẩu không trùng khớp");
                txtPassword.Text = "";
                txtNhaplai.Text = "";
                txtPassword.Focus();
            }
            else
            {
                string queryString = "INSERT INTO Account VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtTen.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "')";
                using (OleDbConnection connection = new OleDbConnection(connectionString))   //tạo lớp kết nối vào .mbd
                using (OleDbCommand command = new OleDbCommand(queryString, connection))    //tạo lớp lệnh sql sử dụng lớp kết nối trên
                {
                    try
                    {

                        connection.Open();  //bắt đầu kết nối
                        OleDbDataReader reader = command.ExecuteReader();  //thực thi sql và trả về kết quả
                        MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        reader.Close();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void Clear()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtTen.Clear();
            txtUsername.Clear();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
