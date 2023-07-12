using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    class SqlOperation
    {
        

            static SqlConnection con = SQLConnection.ConnectionControl();
            static SqlDataAdapter da;
            static SqlDataReader dr;
            static SqlCommand cmd;
            static DataSet ds;

            //SqlConnection conn = new SqlConnection(SqlConnect.baglanti);


            public static void Added(string _StoredProcedure, Property generalProperties)
            {
                SQLConnection.ConnectionOpen(con);
                SqlCommand command = new SqlCommand(_StoredProcedure, con);
                command.CommandText = _StoredProcedure;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Ad", generalProperties.Ad);
                command.Parameters.AddWithValue("@Soyad", generalProperties.Soyad);
                command.Parameters.AddWithValue("@Telefon", generalProperties.Telefon);
                command.Parameters.AddWithValue("@TC", generalProperties.TC);
                command.Parameters.AddWithValue("@MailAdres", generalProperties.Email);
                command.Parameters.AddWithValue("@Adres", generalProperties.Adres);
                command.ExecuteNonQuery();
                SQLConnection.ConnectionClose(con);
            }
            public static void Updated(string _StoredProcedure, Property generalProperties)
            {
                SQLConnection.ConnectionOpen(con);
                SqlCommand command = new SqlCommand(_StoredProcedure, con);
                command.CommandText = _StoredProcedure;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", generalProperties.Id);
                command.Parameters.AddWithValue("@Ad", generalProperties.Ad);
                command.Parameters.AddWithValue("@Soyad", generalProperties.Soyad);
                command.Parameters.AddWithValue("@Telefon", generalProperties.Telefon);
                command.Parameters.AddWithValue("@TC", generalProperties.TC);
                command.Parameters.AddWithValue("@MailAdres", generalProperties.Email);
                command.Parameters.AddWithValue("@Adres", generalProperties.Adres);
                command.ExecuteNonQuery();
                SQLConnection.ConnectionClose(con);
            }

            public static void DeleteMember(string _StoredProcedure, int Id)
            {
                SQLConnection.ConnectionOpen(con);
                SqlCommand command = new SqlCommand(_StoredProcedure, con);
                command.CommandText = _StoredProcedure;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();
                SQLConnection.ConnectionClose(con);
            }
        
    }
}
