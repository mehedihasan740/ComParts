using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComParts
{
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "E-mail")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "E-mail";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3_KeyPress(sender, new KeyPressEventArgs('\0'));
            if (textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.UseSystemPasswordChar = false;
                textBox3.Text = "Password";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            if (textBox3.Text != "Password")
            {
                switch (status)
                {
                    case true:
                        textBox3.UseSystemPasswordChar = false;
                        break;
                    default:
                        textBox3.UseSystemPasswordChar = true;
                        break;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fulfill the requirements!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "INSERT INTO Com_Login VALUES(@name, @pass);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
                Form6 f6 = new Form6(textBox1.Text);
                f6.ShowDialog();
                this.Close();
            }
        }
    }
}
