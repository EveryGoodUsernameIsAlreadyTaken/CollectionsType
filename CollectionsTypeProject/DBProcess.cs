using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace CollectionsTypeProject
{
    class DBProcess
    {
        public static SqlConnection DBConnection()
        {
            var filestream = new System.IO.FileStream("DBInfo.txt",
                                             System.IO.FileMode.Open,
                                             System.IO.FileAccess.Read,
                                             System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);

            string lineOfText = null;
            string szConStr = null;
            while ((lineOfText = file.ReadLine()) != null)
            {
                string szTag = "ConString:";
                if (lineOfText.Contains(szTag))
                {
                    szConStr = lineOfText.Substring(szTag.Length, lineOfText.Length - szTag.Length);
                }
            }
            SqlConnection conn = new SqlConnection(szConStr);

            return conn;
        }

        public static void FillDataGridViewUseAdapter(DataGridView dgvCurrent, string szSQL)
        {
            SqlConnection conn = DBConnection();
            SqlDataAdapter sda = new SqlDataAdapter(szSQL, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvCurrent.DataSource = dt;
        }

        public static void DBManipulate(string szSQL, int tbID, string tbFirst = null, string tbLast = null)
        {
            SqlConnection conn = null;

            try
            {
                conn = DBConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(szSQL, conn);
                if(tbFirst != null && tbLast != null)
                {
                    da.InsertCommand.Parameters.Add("@FIRSTNAME", SqlDbType.NVarChar).Value = tbFirst;
                    da.InsertCommand.Parameters.Add("@LASTNAME", SqlDbType.NVarChar).Value = tbLast;
                }
                da.InsertCommand.Parameters.Add("@CUSTID", SqlDbType.Int).Value = tbID;

                conn.Open();
                da.InsertCommand.ExecuteNonQuery();
            }
            catch (IOException ex)
            {
                MessageBox.Show("A problem occured with the file.\n" + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A problem occured with the database.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem occured.\n" + ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}
