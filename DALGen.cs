using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace bmim2214_lab2
{
    public abstract class DALGen
    {     
        protected static bool isConnected;        
        protected static SqlConnection sqlConnection;
        protected string strSqlConn; 
        protected void CreateConnection(ref string errMess)
        {         
            if (isConnected != true)
            {
                try
                {                
                    sqlConnection = new SqlConnection(strSqlConn);                  
                    sqlConnection.Open();                  
                    errMess = "OK";
                }
                catch (SqlException ex)
                {                  
                    errMess = ex.Message;
                }
                finally               
                {                   
                    if (sqlConnection != null)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }
        private void OpenConnection(ref string errMess)
        {           
            if (isConnected == false)
            {
                try
                {
                    sqlConnection.Open();
                    isConnected = true;
                    errMess = "OK";
                }
                catch (SqlException ex)
                {
                    errMess = ex.Message;
                }
            }
        }        
        private void CloseConnection()
        {           
            if (isConnected == true)
            {
                sqlConnection.Close();
                isConnected = false;
            }
        }
     
        protected DataSet ExecuteDS(string query, ref string errMess)
        {          
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection(ref errMess);
              
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);             
                dataAdapter.Fill(dataSet);

                errMess = "OK";
            }
            catch (SqlException e)
            {
                errMess = e.Message;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    CloseConnection();
                }
            }
            return dataSet;
        }

        protected DataSet ExecuteDSP(string query, List<SqlParameter> parameters, ref string errMess)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection(ref errMess);

                SqlCommand command = new SqlCommand(query, sqlConnection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataSet);

                errMess = "OK";
            }
            catch (SqlException e)
            {
                errMess = e.Message;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    CloseConnection();
                }
            }
            return dataSet;
        }

        protected void ExecuteNonQuery(SqlCommand command, ref string errMess)
        {
            try
            {
                OpenConnection(ref errMess);
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                errMess = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected object ExecuteScalarUsingParametrizedQuery(SqlCommand command, ref string errMess)
        {
            object value;
            try
            {
                OpenConnection(ref errMess);
                command.Connection = sqlConnection;
                value = command.ExecuteScalar();
                errMess = "OK";
            }
            catch (SqlException e)
            {
                value = null;
                errMess = e.Message;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }

    }


}