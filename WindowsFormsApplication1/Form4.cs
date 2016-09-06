using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        Form1 f1;

        public Form4(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        public static long GetTimestamp()
        {

            return DateTime.UtcNow.Ticks;

        }

        //
        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\\рецепты\\" + textBox1.Text + "_" + GetTimestamp();

            FileStream fs = System.IO.File.Create(filename);
            fs.Close();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                file.WriteLine("ФИО: " + textBox1.Text);
                file.WriteLine("Возраст: " + textBox2.Text);
                if (f1.diseases_by_symptoms_list.CurrentRow != null)
                {
                    file.WriteLine("Диагноз: " + f1.diseases_by_symptoms_list.CurrentRow.Cells[1].Value.ToString());
                }

                for (int i = 0; i < f1.dataGridView1.RowCount; i++)
                {
                    if ((Boolean)f1.dataGridView1["Checkbox", i].Value == true)
                    {
                        file.WriteLine("----------------------------");
                        string id = f1.dataGridView1["ID", i].Value.ToString();
                        file.WriteLine(f1.get_med_description_for_print_recipe(id, i));
                        
                    }
                }

                file.Close();
            }
            Process.Start("notepad.exe", filename);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
