using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Jocuri.SqlDataAccess
{
    public class DatabaseHelper
    {
        private static readonly string _connectionstring = DataAccess.GetConnectionPath();
        private static readonly string _utilizatoripath = DataAccess.GetUtilizatoriPath();
        private static readonly string _rezultatepath = DataAccess.GetRezultatePath();

        public static void Initialisation()
        {
            DeleteFromTable();
            InsertUsers();
            InsertResults();
        }

        private static void InsertResults()
        {

            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Rezultate (TipJoc,EmailUtilizator,PunctajJoc,Data) values (@tip, @email, @punctaj, @data)";
                using (StreamReader reader = new StreamReader(_rezultatepath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split(';');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            cmd.Parameters.AddWithValue("@tip", Convert.ToInt32(split[0]));
                            cmd.Parameters.AddWithValue("@email", split[1]);
                            cmd.Parameters.AddWithValue("@punctaj", Convert.ToInt32(split[2]));
                            DateTime date = DateTime.ParseExact(split[3].Trim(), "d.M.yyyy", null);
                            cmd.Parameters.AddWithValue("@data", date);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private static void InsertUsers()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Utilizatori values (@email, @nume, @parola)";
                using (StreamReader reader = new StreamReader(_utilizatoripath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split(';');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            cmd.Parameters.AddWithValue("@email", split[0]);
                            cmd.Parameters.AddWithValue("@nume", split[1]);
                            cmd.Parameters.AddWithValue("@parola", split[2].Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private static void DeleteFromTable()
        {
            bool existsRows = false;
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {

                            existsRows = true;


                        }
                    }
                }
                if (existsRows == true)
                {
                    SqlCommand delUtil = new SqlCommand("Delete from Utilizatori", con);
                    SqlCommand delRes = new SqlCommand("Delete from Rezultate", con);
                    SqlCommand reseedUtil = new SqlCommand("DBCC CHECKIDENT(Utilizatori, RESEED , 0)", con);
                    SqlCommand reseedRes = new SqlCommand("DBCC CHECKIDENT(Rezultate, RESEED , 0)", con);

                    delUtil.ExecuteNonQuery();
                    delRes.ExecuteNonQuery();
                    reseedRes.ExecuteNonQuery();
                }

            }
        }

        public static UserModel SearchUser(UserModel user)
        {
            UserModel user1 = new UserModel();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where EmailUtilizator = @email and Parola = @parola";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@parola", user.Password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            user1.Email = user.Email;
                            user1.Password = user.Password;
                            user1.Name = reader[1].ToString();
                        }
                    }
                }
            }
            return user1;
        }

        public static UserModel EmailExists(string email)
        {
            UserModel user = new UserModel() 
            { Email = email };
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where EmailUtilizator= @email";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows) { user.Password = reader[2].ToString(); user.Name = reader[1].ToString(); }
                   
                    }
                }

            }
            return user;
        }

        public static void InsertNewUser(UserModel user)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Utilizatori values (@email, @nume, @parola)";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@nume", user.Name);
                    cmd.Parameters.AddWithValue("@parola", user.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<RezultateModel> GetRezultateJoc(int tip)
        {
            List<RezultateModel> rezultate = new List<RezultateModel>();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Rezultate where TipJoc=@tip";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@tip", tip);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RezultateModel rezultat = new RezultateModel();
                            {
                                string date = reader[4].ToString().Split(' ')[0];
                                DateTime data = DateTime.ParseExact(date, "M/d/yyyy", null);

                                rezultat.Data = data;
                                rezultat.Rezultate = Convert.ToInt32(reader[3]);
                            }
                            rezultate.Add(rezultat);
                        }
                    }
                }
            }

            return rezultate;
        }

        public static void InsertNewRezultat(int tipjoc, UserModel user, int scor)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Rezultate (TipJoc,EmailUtilizator,PunctajJoc,Data) values (@tip, @email, @punctaj, @data)";
                using(SqlCommand cmd= new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@tip", tipjoc);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@punctaj", scor);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    cmd.ExecuteNonQuery();

                }
            }

        }

        public static List<RezultateModel> GetAllRezultate()
        {
            List<RezultateModel> rezultate = new List<RezultateModel>();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Rezultate";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                { 
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RezultateModel model = new RezultateModel();
                            {
                                model.Email = reader[2].ToString();
                                model.Rezultate = Convert.ToInt32(reader[3]);
                            }
                            rezultate.Add(model);
                        }
                    }
                }

                return rezultate;
            }
        }
    }
}
