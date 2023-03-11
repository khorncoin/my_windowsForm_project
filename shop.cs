using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Fshop : Form
    {
        public Fshop()
        {
            InitializeComponent();
        }
          DataTable x = new DataTable();
        int y;
        private void Fshop_Load(object sender, EventArgs e)
        {
            x.Columns.Add("Customer Name",typeof(string));
            x.Columns.Add("Book Name", typeof(string));
            x.Columns.Add("Price", typeof(int));
            x.Columns.Add("Quantity", typeof(int));
            x.Columns.Add("Date of sale", typeof(DateTime));
            dataGridView.DataSource = x;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Total_Click(object sender, EventArgs e)
        {   DateTime date = dateTimePicker.Value.Date;
            x.Rows.Add(NBox.Text, comboBox.Text, priBox.Text, qtyBox.Text, dateTimePicker.MinDate.ToString());
            dataGridView.DataSource = x;
         
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            DataGridViewRow n = dataGridView.Rows[y];
            n.Cells[0].Value = NBox.Text;
            n.Cells[1].Value = comboBox.Text;
            n.Cells[2].Value = priBox.Text;
            n.Cells[3].Value = qtyBox.Text;
            n.Cells[4].Value = dateTimePicker.Value;
            
        
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            y = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(y);
        }
    }
}
