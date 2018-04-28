using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace NoteLib
{
    class DbHandle
    {
        private String strConnStr;
        private SqlConnection sqlConn;
        public DbHandle()
        {
            try
            {
                strConnStr =  ConfigurationManager.ConnectionStrings["NoteLib.Properties.Settings.Database1ConnectionString"].ConnectionString;
                sqlConn = new SqlConnection(strConnStr);
                sqlConn.Open();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        public void dbRefresh()
        {
            sqlConn.Close();
            sqlConn.Open();
        }
        public void dbDestroy()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }

        public DataTable sqlCustomQuery(string Querry)
        {
            DataTable dtResTable = new DataTable();
            SqlCommand sqlcComm = new SqlCommand(Querry, sqlConn);
            sqlcComm.CommandType = CommandType.Text;
            SqlDataAdapter sqladpAdap = new SqlDataAdapter(sqlcComm);
            sqladpAdap.Fill(dtResTable);
            return dtResTable;
        }
        
        public DataTable sqlProcedureQuery(string Querry)
        {
            DataTable dtResTable = new DataTable();
            SqlCommand sqlcComm = new SqlCommand(Querry, sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqladpAdap = new SqlDataAdapter(sqlcComm);
            sqladpAdap.Fill(dtResTable);
            return dtResTable;
        }
        public DataTable sqlProcedureQuery(string Querry, string parm, SqlDbType type, string val)
        {
            DataTable dtResTable = new DataTable();
            SqlCommand sqlcComm = new SqlCommand(Querry, sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add(parm, type).Value = val;
            SqlDataAdapter sqladpAdap = new SqlDataAdapter(sqlcComm);
            sqladpAdap.Fill(dtResTable);
            return dtResTable;
        }
        public void insertSong(string name, int length, int genreID, int artistID, int year, int albumID)
        {
            SqlCommand sqlcComm = new SqlCommand("P_Insert_Song", sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add("name",SqlDbType.VarChar).Value = name;
            sqlcComm.Parameters.Add("length",SqlDbType.Int).Value = length;
            sqlcComm.Parameters.Add("genre_id", SqlDbType.Int).Value = genreID;
            sqlcComm.Parameters.Add("artist_id", SqlDbType.Int).Value = artistID;
            sqlcComm.Parameters.Add("year", SqlDbType.Int).Value = year;
            sqlcComm.Parameters.Add("album_id", SqlDbType.Int).Value = albumID;
            sqlcComm.ExecuteNonQuery();
        }
        public void insertSong(string name, int length, int genreID, int artistID, int year)
        {
            SqlCommand sqlcComm = new SqlCommand("P_Insert_Song", sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add("name", SqlDbType.VarChar).Value = name;
            sqlcComm.Parameters.Add("length", SqlDbType.Int).Value = length;
            sqlcComm.Parameters.Add("genre_id", SqlDbType.Int).Value = genreID;
            sqlcComm.Parameters.Add("artist_id", SqlDbType.Int).Value = artistID;
            sqlcComm.Parameters.Add("year", SqlDbType.Int).Value = year;
            sqlcComm.Parameters.Add("album_id", SqlDbType.Int).Value = null;
            sqlcComm.ExecuteNonQuery();
        }

        public void insertGeneric(string proc, string procPar, SqlDbType dbType, string parVal)
        {
            SqlCommand sqlcComm = new SqlCommand(proc, sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add(procPar, dbType).Value = parVal;
            sqlcComm.ExecuteNonQuery();
        }

        public void insertGeneric(string proc, string procPar, SqlDbType dbType, string parVal, string procPar1, SqlDbType dbType1, string parVal1)
        {
            SqlCommand sqlcComm = new SqlCommand(proc, sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add(procPar, dbType).Value = parVal;
            sqlcComm.Parameters.Add(procPar1, dbType1).Value = parVal1;
            sqlcComm.ExecuteNonQuery();
        }

    }
}
