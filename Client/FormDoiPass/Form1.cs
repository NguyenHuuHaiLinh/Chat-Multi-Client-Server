using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FormDoiPass
{
    public partial class DoiPass : Form
    {
        string connectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=C:\Users\asus\Desktop\Multi Chat Client-Server\Client\FormDangNhap\Account.mdb;" +
                @"User Id=;Password=;";
        public DoiPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryString111 = "SELECT * FROM Account where username ='" + txtUsername.Text + "' and password ='" + txtPassword.Text + "'"; 
            using (OleDbConnection connection111 = new OleDbConnection(connectionString))   //tạo lớp kết nối vào .mbd
            using (OleDbCommand command111 = new OleDbCommand(queryString111, connection111))    //tạo lớp lệnh sql sử dụng lớp kết nối trên
            {
                try
                {
                    connection111.Open();  //bắt đầu kết nối
                    OleDbDataReader reader111 = command111.ExecuteReader();  //thực thi sql và trả về kết quả
                    if (reader111.Read() == true)  //đọc kết quả
                    {
                        if (txtChange.Text == string.Empty)
                        {
                            MessageBox.Show("Vui lòng điền mật khẩu mới");
                        }
                        string queryString = "UPDATE [Account] SET [password] = '" + txtChange.Text + "' WHERE [username] ='" + txtUsername.Text + "'" ;
                        using (OleDbConnection connection = new OleDbConnection(connectionString))   //tạo lớp kết nối vào .mbd
                        using (OleDbCommand command = new OleDbCommand(queryString, connection))    //tạo lớp lệnh sql sử dụng lớp kết nối trên
                        {
                            try
                            {
                                connection.Open();
                                OleDbDataReader reader = command.ExecuteReader();
                                MessageBox.Show("Đổi mật khẩu thành công");
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                txtChange.Text = "";
                                reader.Close();
                                this.Close();
                            }
                            catch (Exception exx)
                            {
                                MessageBox.Show(exx.Message);
                            }                     
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("thong tin dang nhap sai");
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        txtChange.Text = "";
                        txtUsername.Focus();
                    }
                    reader111.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
