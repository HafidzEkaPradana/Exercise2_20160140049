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


namespace Exercise2_20160140049
{
    public partial class Menu : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercise2PABDDataSet.NilaiKuliah' table. You can move, or remove it, as needed.
            this.nilaiKuliahTableAdapter.Fill(this.exercise2PABDDataSet.NilaiKuliah);
            this.CenterToScreen();
            txCode.Enabled = false;
            txMatakuliah.Enabled = false;
            cbNilai.Enabled = false;
            cbSKS.Enabled = false;
            cbNilai.Items.Add("A");
            cbNilai.Items.Add("AB");
            cbNilai.Items.Add("B");
            cbNilai.Items.Add("BC");
            cbNilai.Items.Add("C");
            cbNilai.Items.Add("D");
            cbNilai.Items.Add("E");
            cbNilai.Items.Add("TL");

            cbSKS.Items.Add("1");
            cbSKS.Items.Add("2");
            cbSKS.Items.Add("3");
            btnSimpan.Enabled = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = true;

            txMatakuliah.Enabled = true;
            cbNilai.Enabled = true;
            cbSKS.Enabled = true;

            txMatakuliah.Text = "";
            cbNilai.Text = "";
            cbSKS.Text = "";

            int ctr, len;
            string codeval;
            dt = exercise2PABDDataSet.Tables["NilaiKuliah"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["code"].ToString();
            codeval = code.Substring(1, 2);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                txCode.Text = "80" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 9))
            {
                ctr = ctr + 1;
                txCode.Text = "8" + ctr;

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string code;
            code = txCode.Text;
            dr = exercise2PABDDataSet.Tables["NilaiKuliah"].Rows.Find(code);
            dr.Delete();
            nilaiKuliahTableAdapter.Update(exercise2PABDDataSet);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            dt = exercise2PABDDataSet.Tables["NilaiKuliah"];
            dr = dt.NewRow();
            dr[0] = txCode.Text;
            dr[1] = txMatakuliah.Text;
            dr[2] = cbNilai.SelectedItem;
            dr[3] = cbSKS.SelectedItem;
            dt.Rows.Add(dr);
            nilaiKuliahTableAdapter.Update(exercise2PABDDataSet);
            txCode.Text = System.Convert.ToString(dr[0]);
            txCode.Enabled = false;
            txMatakuliah.Enabled = false;
            cbNilai.Enabled = false;
            cbSKS.Enabled = false;
            this.nilaiKuliahTableAdapter.Fill(this.exercise2PABDDataSet.NilaiKuliah);
            btnTambah.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnLihatMahasiswa_Click(object sender, EventArgs e)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Show();
            this.Hide();
        }
    }
    
}
