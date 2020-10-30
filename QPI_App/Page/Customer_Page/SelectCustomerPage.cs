using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QPI_App.Page.Customer_Page
{
    public partial class SelectCustomerPage : Form
    {
        public SelectCustomerPage()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectCus_Click(object sender, EventArgs e)
        {
            String nameCustomer = cbListCustomer.Text;

            SqlConnection conn = new SqlConnection("Data Source=;Initial Catalog=;Persist Security Info=True;User ss=;Password=ss");
            conn.Open();

            //SqlCommand command = new SqlCommand("Select id from [table1] where name=@zip", conn);
            //command.Parameters.AddWithValue("@zip", "india");
            //// int result = command.ExecuteNonQuery();
            //using (SqlDataReader reader = command.ExecuteReader())
            //{
            //    if (reader.Read())
            //    {
            //        Console.WriteLine(String.Format("{0}", reader["id"]));
            //    }
            //}

            conn.Close();

        }
    }
}
