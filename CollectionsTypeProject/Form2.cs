using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsTypeProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateCust_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != null && tbLastName.Text != null && tbID.Text.Length == 6)
            {
                string szSQL = string.Format("INSERT INTO CUSTOMERS VALUES (@FIRSTNAME, @LASTNAME, @CUSTID)");

                DBProcess.DBManipulate(szSQL, int.Parse(tbID.Text), tbFirstName.Text, tbLastName.Text);
                this.Close();
            }
            else if (tbFirstName.Text == "" && tbLastName.Text == "")
            {
                MessageBox.Show("Please enter first and last name.");
            }
            else if (tbID.Text.GetType() != typeof(int) && tbID.Text.Length != 6 && tbID.Text == null)
            {
                MessageBox.Show("Please enter correct ID.");
            }
            else
            {
                MessageBox.Show("Something is wrong.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAutoID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoID.Checked == true)
            {
                btnIDGenerate.Enabled = true;
            }
            else if (cbAutoID.Checked == false)
            {
                btnIDGenerate.Enabled = false;
            }
        }

        private void btnIDGenerate_Click(object sender, EventArgs e)
        {
            if (cbAutoID.Checked == true)
            {
                string szSQL = string.Format("SELECT CUSTID, FIRSTNAME, LASTNAME FROM CUSTOMERS");
                SqlConnection conn = DBProcess.DBConnection();
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(szSQL, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                conn.Close();

                var random = new Random();
                int randID = random.Next(100000, 999999);
                List<int> CustIDs = new List<int>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    while (randID == dt.Rows[i].Field<int>(0))
                    {
                        randID = random.Next(100000, 999999);
                    }
                }

                tbID.Text = randID.ToString();
            }
        }
    }
}
