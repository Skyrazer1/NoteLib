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

        public void insertSong(string name, string length, int genreID, int artistID, int year, int albumID)
        {
            SqlCommand sqlcComm = new SqlCommand("P_Insert_Song", sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add("name",SqlDbType.VarChar).Value = name;
            sqlcComm.Parameters.Add("length",SqlDbType.VarChar).Value = length;
            sqlcComm.Parameters.Add("genre_id", SqlDbType.Int).Value = genreID;
            sqlcComm.Parameters.Add("artist_id", SqlDbType.Int).Value = artistID;
            sqlcComm.Parameters.Add("year", SqlDbType.Int).Value = year;
            sqlcComm.Parameters.Add("album_id", SqlDbType.Int).Value = albumID;
            sqlcComm.ExecuteNonQuery();
        }
        public void insertGeneric(string proc, string procPar, SqlDbType dbType, string parVal)
        {
            SqlCommand sqlcComm = new SqlCommand(proc, sqlConn);
            sqlcComm.CommandType = CommandType.StoredProcedure;
            sqlcComm.Parameters.Add(procPar, dbType).Value = parVal;
            sqlcComm.ExecuteNonQuery();
        }

    }
}
