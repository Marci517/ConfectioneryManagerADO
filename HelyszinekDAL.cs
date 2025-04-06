using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Xml.Linq;


namespace bmim2214_lab2
{
    public struct Helyszin
    {
        int HID;
        string Megye;


        public int HelyszinId
        {
            get { return HID; }
            set { HID = value; }
        }

        public string HelyszinNev
        {
            get { return Megye; }
            set { Megye = value; }
        }

        public Helyszin(int HID, string Megye)
        {
            this.HID = HID;
            this.Megye = Megye;
        }

    }


    public class HelyszinekDAL : DALGen
    {
        public List<Helyszin> GetHelyszinListDataSet(ref string error)
        {
            string query = "SELECT * FROM Helyszinek";
            DataSet ds_tabla = new DataSet();
            ds_tabla = ExecuteDS(query, ref error);

            List<Helyszin> helyszinList = new List<Helyszin>();

            if (error == "OK")
            {
                Helyszin item = new Helyszin();
                foreach (DataRow r in ds_tabla.Tables[0].Rows)
                {
                    try
                    {
                        item.HelyszinId = Convert.ToInt32(r["HID"]);
                        item.HelyszinNev = r["Megye"].ToString();
                        
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }

                    helyszinList.Add(item);
                }
            }
            return helyszinList;
        }
    }

}
