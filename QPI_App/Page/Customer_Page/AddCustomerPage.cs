using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QPI_App.Page.Customer_Page
{
    public partial class AddCustomerPage : Form
    {
        public AddCustomerPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpImg_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(*.jpg)|*.jpg| PNG files (*.png)|*.png | All Files(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = ofd.FileName;

                    pictureBox1.ImageLocation = imageLocation;

                    Console.WriteLine(imageLocation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            String CompanyName = textBox1.Text;
            String Address = textBox2.Text;
            String Tel = textBox3.Text;
            String TelOffice = textBox4.Text;
            String Email = textBox5.Text;
            String LogoImage = pictureBox1.ImageLocation;

            //string command = "INSERT into CompanyInfo (CompanyName,Address,Tel,TelOffice,Email) VALUES (@CompanyName,@Address,@Tel,@TelOffice,@Email)";


            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=CLIENT1;Initial Catalog=Visitors;User ID=ss;Password=ss";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "INSERT into CompanyInfo (CompanyName,Address,Tel,TelOffice,Email,LogoImage) VALUES (@CompanyName,@Address,@Tel,@TelOffice,@Email,@LogoImage)";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }
    }
}
