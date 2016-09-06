using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Auth : Form
    {
        Form1 f1;
        public Auth(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\\med_pass";

            String pass_from_file = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                pass_from_file = sr.ReadToEnd();
            }

            string pass = textBox1.Text.Trim();
            string hashPass = f1.CalculateMD5Hash(pass);

            pass_from_file = pass_from_file.Trim();

            if (!hashPass.Equals(pass_from_file))
            {
                MessageBox.Show("Неверный пароль!");
                return;
            }
            f1.prg.auth = true;

            Form2 admin_form = new Form2(f1);
            admin_form.ShowDialog(f1);
            admin_form.Dispose();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Auth_Load(object sender, EventArgs e)
        {
           
        }
    }
}
