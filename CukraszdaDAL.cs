using bmim2214_lab2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;

namespace bmim2214_lab2
{   
    public struct Cukraszda
    {
        int CID;
        string Nev;
        int Dolgozok_szama;
        Helyszin cukraszdaHelyszin;

        public int CukraszdaId
        {
            get { return CID; }
            set { CID = value; }
        }

        public string CukraszdaNev
        {
            get { return Nev; }
            set { Nev = value; }
        }

        public int CukraszdaDolgozok_szama
        {
            get { return Dolgozok_szama; }
            set { Dolgozok_szama = value; }
        }

        public Helyszin CukraszdaHelyszin
        {
            get { return cukraszdaHelyszin; }
            set { cukraszdaHelyszin = value; }
        }

    }

    public class CukraszdakDAL : DALGen
    {
        public CukraszdakDAL(int value, ref string error, string username = "", string password = "")
        {
            if (value == 1)
            {
                strSqlConn = "Data Source=(local);Initial Catalog=bmim2214_sajat2;uid=Vendeg;pwd=vendeg";
            }
            else
            {
                if (value == 2)
                {
                    strSqlConn = "Data Source=(local);Initial Catalog=bmim2214_sajat2;uid=Fonok;pwd=fonok";
                }
                else
                { 
                    if (value == 3)
                    {
                        string sql = "Data Source=(local);Initial Catalog=bmim2214_sajat2;uid=" + username + ";pwd=" + password;
                        strSqlConn = sql;
                    }
                    else
                    {
                      strSqlConn = "Data Source=MARCI;Initial Catalog=bmim2214_sajat2;Integrated Security=SSPI";
                    }
                }
            }
            base.CreateConnection(ref error);
        }
        
        public List<Cukraszda> GetCukraszdaListDataSet(int HID, string cname, ref string error)
        {
            string query = "SELECT CID, Megye, Cukraszdak.HID, Nev, Dolgozok_szama " +
            "FROM Helyszinek, Cukraszdak " +
            "WHERE Helyszinek.HID = Cukraszdak.HID";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (HID >= 0)
            {
                query += " AND Cukraszdak.HID = @HID";
                parameters.Add(new SqlParameter("@HID", HID));
            }

            if (cname != null)
            {
                query += " AND Nev LIKE @cname";
                parameters.Add(new SqlParameter("@cname", cname + "%"));
            }

            DataSet ds_tabla = new DataSet();
            ds_tabla = ExecuteDSP(query, parameters, ref error);

            List<Cukraszda> cukraszdaList = new List<Cukraszda>();

            if (error == "OK")
            {
                Cukraszda item = new Cukraszda();
                foreach (DataRow r in ds_tabla.Tables[0].Rows)
                {
                    try
                    {
                        item.CukraszdaId = Convert.ToInt32(r["CID"]);
                        item.CukraszdaNev = r["Nev"].ToString();
                        item.CukraszdaDolgozok_szama = Convert.ToInt32(r["Dolgozok_szama"]);
                        item.CukraszdaHelyszin = new Helyszin(Convert.ToInt32(r["HID"]), r["Megye"].ToString());
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }

                    cukraszdaList.Add(item);
                }
            }
            return cukraszdaList;
        }

        public void DeleteCukraszda(int CID, ref string error)
        {
            string query = "DELETE FROM Cukraszdak WHERE @CID = CID;";
            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text
            };

            command.Parameters.AddWithValue("@CID", CID);
            ExecuteNonQuery(command, ref error);
        }

        public int GetDolgozokSzamaParametrized(int CID, ref string error)
        {
            string query = "SELECT Dolgozok_Szama FROM Cukraszdak WHERE CID = @CID";
            
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@CID";
            parameter.SqlDbType = SqlDbType.Int;
           
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = CID;

            
            command.Parameters.Add(parameter);

            int dolgozoksz = Convert.ToInt32(base.ExecuteScalarUsingParametrizedQuery(command, ref error));
            return dolgozoksz;
        }

        public void UpdateCukraszdaDolgozokSzama(int CID, int dolgozok, ref string error)
        {
            string query = "UPDATE Cukraszdak SET Dolgozok_Szama = @dolgozok WHERE CID = @CID";
            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text
            };
            command.Parameters.AddWithValue("@dolgozok", dolgozok);
            command.Parameters.AddWithValue("@CID", CID);
            ExecuteNonQuery(command, ref error);
        }

        public void CreateUser(string Username, string Password, ref string error)
        {
            
            SqlCommand command = new SqlCommand
            {
                CommandText = "Registration",
                CommandType = CommandType.StoredProcedure
            };
            SqlParameter parameteru = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            parameteru.Direction = ParameterDirection.Input;       
            parameteru.Value = Username;
            command.Parameters.Add(parameteru);

            SqlParameter parameterp = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            parameterp.Direction = ParameterDirection.Input;
            parameterp.Value = Password;
            command.Parameters.Add(parameterp);

            ExecuteNonQuery(command, ref error);
        }

    }
    
}
