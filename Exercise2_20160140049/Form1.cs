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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("data source=LAPTOP-8MKEQ456; database=Exercise2PABD; Integrated Security=True; User ID=sa;Password=mentepermaib20");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loginPanel.BringToFront();
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
            btnToLogin.BackColor = select_color;
            loginPanel.BackColor = select_color;
            btnToRegister.BackColor = Color.Black;
            regisPanel.BackColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
        }
        Color select_color = Color.FromArgb(46, 49, 49);
        private void btnToRegister_Click(object sender, EventArgs e)
        {
            regisPanel.BringToFront();
            btnToRegister.BackColor = select_color;
            regisPanel.BackColor = select_color;
            btnToLogin.BackColor = Color.Black;
            loginPanel.BackColor = Color.Black;
           

        }

        private void regisBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            String user, user_password;
            user = txLoginUsername.Text;
            user_password = txLoginPass.Text;


            try
            {
                String query = "SELECT * FROM Login WHERE username = '" + txLoginUsername.Text + "' AND password = '" + txLoginPass.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0 && checkBox1.Checked == true)
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else if (txLoginUsername.Text == "" || txLoginPass.Text == "")
                {
                    MessageBox.Show("Username dan Password belum diisi !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtable.Rows.Count > 0 && checkBox1.Checked == false)
                {
                    MessageBox.Show("Harap setuju Term and Condition", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Username dan Password yang anda masukkan salah !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txLoginUsername.Clear();
                    txLoginPass.Clear();

                    txLoginUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    } 
}
