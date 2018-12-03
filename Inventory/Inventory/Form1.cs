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


namespace Inventory
{
    public partial class InventoryManagement : Form
    {
        //developer Israel Pedrosa
        
        public InventoryManagement()
        {
            InitializeComponent();
        }
        //input connection string here
        public string constring = "Data Source=DESKTOP-2F6IAFQ;Initial Catalog=Vehicles;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            //adds records to the form
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //generates a new id. gets the highest id number and adds to it
                string newName = "";
                //change your db table here
                string q1 = "SELECT TOP 1 ID FROM VEHICLEDETAILS ORDER BY ID DESC";
                object uniqueID;
                SqlCommand cmd1 = new SqlCommand(q1, con);
                cmd1.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd1.Parameters["@name"].Value = newName;

                uniqueID = cmd1.ExecuteScalar();
                int uid = Convert.ToInt32(uniqueID);
                uid++;
                //change db table and column names here or make identical here
                string q = "insert into VEHICLEDETAILS(ID, Make, Model, LicensePlate) values" +
                    "('"+uid+"','"+make.Text.ToString()+"','"+model.Text.ToString()+"','"+licensePlate.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted into the DB successfully!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewInventory ve = new ViewInventory();
            this.Hide();
            ve.ShowDialog();
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (id.Text.ToString() == "" && licensePlate.Text.ToString() == "")
            {
                MessageBox.Show("Please input an ID or License Plate!", "Attention");
            }

            foreach (Control c in Controls)
            {
                if (id.Text.ToString() != "" || licensePlate.Text.ToString() != "")
                {
                    if (c is TextBox)
                    {
                        if (c.Name.ToString() == "licenseplate" || c.Name.ToString() != "id")
                        {
                            if (con.State == System.Data.ConnectionState.Open)
                            {
                                //change tablename here
                                string q = "DELETE FROM VEHICLEDETAILS WHERE " + c.Name.ToString() + " = '" + c.Text.ToString() + "' ";
                                SqlCommand cmd = new SqlCommand(q, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted " + c.Text.ToString() + " Successfully!");
                            }
                        }
                    }
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.ToString() != "" && c.Name.ToString() != "id")
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            string q = "UPDATE VEHICLEDETAILS SET " + c.Name.ToString() +
                            " = '" + c.Text.ToString() +
                            "' WHERE ID = " + id.Text.ToString();
                            //MessageBox.Show(q);
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted ID " + id.Text.ToString() + " Successfully!");


                        }
                    }
                }
            }
        }
    }
}
