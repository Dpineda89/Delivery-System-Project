using DeliverySystem.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_System_Project
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Registros.Clientes;
            this.dataGridView1.Columns[0].Width = 200;
            this.dataGridView1.Columns[1].Width = 200;
            this.dataGridView1.Columns[5].Width = 200;
            this.dataGridView1.Columns[6].Width = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
