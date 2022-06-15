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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            String user, user_password;
            user = txUsername.Text;
            user_password = txPass.Text;


            try
            {
                String query = "SELECT * FROM Login WHERE username = '" + txUsername.Text + "' AND password = '" + txPass.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0 && checkBox1.Checked == true)
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else if (txUsername.Text == "" || txPass.Text == "")
                {
                    MessageBox.Show("Username dan Password belum diisi !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtable.Rows.Count > 0 && checkBox1.Checked == false)
                {
                    MessageBox.Show("Harap setuju Term and Condition", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Username dan Password yang anda masukkan salah !!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txUsername.Clear();
                    txPass.Clear();

                    txUsername.Focus();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.Show();
            this.Hide();
        }
    } 
}
