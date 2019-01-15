using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollectionsTypeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public DataTable GetData()
        {
            string szSQL = string.Format("SELECT CUSTID, FIRSTNAME, LASTNAME FROM CUSTOMERS");
            SqlConnection conn = DBProcess.DBConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(szSQL, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();

            dgvCustomers.Rows.Clear();
            return dt;
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData();

            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer newCust = new Customer()
                {
                    ID = (int)dt.Rows[i].ItemArray[0],
                    fName = (string)dt.Rows[i].ItemArray[1],
                    lName = (string)dt.Rows[i].ItemArray[2]
                };
                customers.Add(newCust);
            }

            for (int i = 0; i < customers.Count; i++)
            {
                Customer cust = customers[i];
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[i].Cells[0].Value = cust.ID;
                dgvCustomers.Rows[i].Cells[1].Value = cust.fName;
                dgvCustomers.Rows[i].Cells[2].Value = cust.lName;
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData();

            Stack<Customer> temp = new Stack<Customer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer newCust = new Customer()
                {
                    ID = (int)dt.Rows[i].ItemArray[0],
                    fName = (string)dt.Rows[i].ItemArray[1],
                    lName = (string)dt.Rows[i].ItemArray[2]
                };
                temp.Push(newCust);
            }

            // The first Stack was made to contain the customers. This stack was made to reverse the Stack and correct it.
            Stack<Customer> customers = new Stack<Customer>(temp);

            int j = 0;
            foreach(Customer cust in customers)
            {
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[j].Cells[0].Value = cust.ID;
                dgvCustomers.Rows[j].Cells[1].Value = cust.fName;
                dgvCustomers.Rows[j].Cells[2].Value = cust.lName;
                j++;
            }
        }

        private void btnQueue_Click(object secnder, EventArgs e)
        {
            DataTable dt = GetData();

            Queue<Customer> customers = new Queue<Customer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer newCust = new Customer()
                {
                    ID = (int)dt.Rows[i].ItemArray[0],
                    fName = (string)dt.Rows[i].ItemArray[1],
                    lName = (string)dt.Rows[i].ItemArray[2]
                };
                customers.Enqueue(newCust);
            }

            int j = 0;
            while(customers.Count > 0)
            {
                Customer cust = customers.Dequeue();
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[j].Cells[0].Value = cust.ID;
                dgvCustomers.Rows[j].Cells[1].Value = cust.fName;
                dgvCustomers.Rows[j].Cells[2].Value = cust.lName;
                j++;
            }
        }

        private void btnDict_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData();

            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer newCust = new Customer()
                {
                    ID = (int)dt.Rows[i].ItemArray[0],
                    fName = (string)dt.Rows[i].ItemArray[1],
                    lName = (string)dt.Rows[i].ItemArray[2]
                };
                customers.Add(i, newCust);
            }

            int j = 0;
            foreach(KeyValuePair<int, Customer> cust in customers)
            {
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[j].Cells[0].Value = cust.Value.ID;
                dgvCustomers.Rows[j].Cells[1].Value = cust.Value.fName;
                dgvCustomers.Rows[j].Cells[2].Value = cust.Value.lName;
                j++;
            }
        }

        private void btnHashT_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData();

            Hashtable customers = new Hashtable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer newCust = new Customer()
                {
                    ID = (int)dt.Rows[i].ItemArray[0],
                    fName = (string)dt.Rows[i].ItemArray[1],
                    lName = (string)dt.Rows[i].ItemArray[2]
                };
                customers.Add(i, newCust);
            }

            int j = 0;

            // Three lines down: used to flip the Hashtable entries in reverse
            var dict = customers.Cast<DictionaryEntry>().ToDictionary(kvp => (int)kvp.Key, kvp => (Customer)kvp.Value);
            var sorted = new SortedDictionary<int, Customer>(dict);
            ICollection values = sorted.Values;

            foreach(Customer cust in values)
            {
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[j].Cells[0].Value = cust.ID;
                dgvCustomers.Rows[j].Cells[1].Value = cust.fName;
                dgvCustomers.Rows[j].Cells[2].Value = cust.lName;
                j++;
            }
        }

        private void btnLinkedL_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData();

            LinkedList<Customer> customers = new LinkedList<Customer>();
            Customer Aftcust = new Customer();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer newCust = new Customer()
                {
                    ID = (int)dt.Rows[i].ItemArray[0],
                    fName = (string)dt.Rows[i].ItemArray[1],
                    lName = (string)dt.Rows[i].ItemArray[2]
                };

                if (i == 0)
                    customers.AddFirst(newCust);
                else if (i+1 == dt.Rows.Count)
                    customers.AddLast(newCust);
                else
                    customers.AddAfter(customers.Last, newCust);
            }

            int j = 0;
            foreach (Customer cust in customers)
            {
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[j].Cells[0].Value = cust.ID;
                dgvCustomers.Rows[j].Cells[1].Value = cust.fName;
                dgvCustomers.Rows[j].Cells[2].Value = cust.lName;
                j++;
            }
        }
    }

    public class Customer
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int ID { get; set; }
    }
}
