using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Repositories;

namespace WindowsFormsApplication1
{
    public partial class AddSymptom : Form
    {
        Form1 f1;
        Form2 f2;
        public AddSymptom(Form1 f1, Form2 f2)
        {
            this.f1 = f1;
            this.f2 = f2;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Symptoms.addSymptom(f1.prg.db, textBox1.Text);
            textBox1.Text = "";
            f2.loadList("Симптомы");
            f1.reload();
        }
    }
}
