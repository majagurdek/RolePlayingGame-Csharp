using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7.Rozne_male
{
    internal class LogReg
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jgurdek\source\repos\Lab7\Lab7\Database1.mdf;Integrated Security=True");
        public static User currUser;


        public void rejestracja(string username, string password)
        {
            Enkrypcja enkrypcja = new Enkrypcja();
            if (username != null && password != null)
            {
                connection.Open();
                string query = "SELECT * FROM [User] WHERE username = @username";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Nazwa użytkownika jest już zajęta, wybierz inną");
                        return;
                    }
                    reader.Close();
                 
                    connection.Close();
                    
                } 

                password = enkrypcja.Encrypt(password);

                string q = "INSERT INTO [User] VALUES (@Username, @Password)";
                connection.Open();
                using (var command = new SqlCommand(q, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    var reader = command.ExecuteReader();


                    reader.Close();
                    connection.Close();
                    MessageBox.Show("Twoje konto zostało utworzone. Zostaniesz przekierowany do panelu logowania, by móc się zalogować.");
                    
                }

            }
        }

        public void logowanie(string username, string password)
        {
            connection.Open();
            if (username == null || password == null)
            {
                MessageBox.Show("Nie wszystkie dane zostały wypełnione");
            }

            string query = "SELECT Password, Id FROM [User] WHERE Username = @username";
            string mypass = "";
            int myid = 1;

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                var reader = command.ExecuteReader();
               
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mypass = reader.GetString(0);
                        myid = reader.GetInt32(1);
                    }

                    Enkrypcja encrypt = new Enkrypcja();
                    string p = encrypt.Encrypt(password);
                    if (p == mypass)
                    {
                        MessageBox.Show("Zostałeś zalogowany/a");
                        currUser = new User(myid, username, mypass);
                        string[] currentuser = { username, mypass, myid.ToString() };

                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono niepoprawne dane");
                    }

                }
                reader.Close();
                connection.Close();



            }

        }
    }
}
