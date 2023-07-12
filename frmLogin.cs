using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmLogin : Form
    {
        static SqlConnection con = SQLConnection.ConnectionControl();
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static SqlCommand cmd;
        static DataSet ds;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (tbxKullaniciAdi.Text == "")
            {
                MessageBox.Show("Kullanıcıadı boş geçilemez!");
            }
            else if(tbxSifre.Text =="")
            {
                MessageBox.Show("Şifre boş geçilemez!");
            }
            else
            {
                string sha = Sha512Enctriyption.SHA512Enctriyption(tbxSifre.Text.ToString());
                string sqlsorgu = $"Select * from Yoneticiler where KullaniciAdi ='{ tbxKullaniciAdi.Text}' and Sifre = '{sha}'";
                cmd = new SqlCommand(sqlsorgu, con);
                SQLConnection.ConnectionOpen(con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı");
                }
                else
                {
                    MessageBox.Show("Giriş yapılamadı Kullanıcı Adı veya Şifre hatalı...");
                    tbxKullaniciAdi.Clear();
                    tbxSifre.Clear();
                    tbxKullaniciAdi.Focus();
                }
            }
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
