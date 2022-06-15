using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_20160140049
{
    public partial class Mahasiswa : Form
    {
        public Mahasiswa()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Mahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercise2PABDDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.exercise2PABDDataSet.Mahasiswa);
            this.CenterToScreen();

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
