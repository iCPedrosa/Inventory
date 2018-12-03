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
using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
        }

        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the new form and hides the current form
            InventoryManagement im = new InventoryManagement();
            this.Hide();
            im.ShowDialog();
            
        }
        //input connection string here
        public string constring = "Data Source=DESKTOP-2F6IAFQ;Initial Catalog=Vehicles;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            //displays the db in datagridview
            using(SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                                    //change your table name here
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM VEHICLEDETAILS", sqlcon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dataGridView1.DataSource = dtb1;
                export.Visible = true;
            }

        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exports excel file to selected location
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel File (xlsx)|*.xlsx";
            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 20;
                ExcelApp.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
