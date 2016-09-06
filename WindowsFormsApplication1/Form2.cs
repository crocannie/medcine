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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem.ToString();
            if (type.Equals("Заболевания"))
            {
                Diseases disease = show_table_list.SelectedItem as Diseases;
                Diseases.deleteDisease(f1.prg.db, disease.id);
            }
            else if (type.Equals("Симптомы"))
            {
                Symptoms symptom = show_table_list.SelectedItem as Symptoms;
                Symptoms.deleteSymptom(f1.prg.db, symptom.id);
            }
            else if (type.Equals("Лекарства"))
            {
                Medications med = show_table_list.SelectedItem as Medications;
                Medications.deleteMed(f1.prg.db, med.id);
            }
            loadList(type);
            f1.reload();
        }

        public void loadList(string type)
        {
            if (type.Equals("Заболевания"))
            {
                show_table_list.DisplayMember = "title";
                show_table_list.ValueMember = "id";
                show_table_list.DataSource = Diseases.getAllDiseases(f1.prg.db);
                show_table_list.SelectedIndex = -1;
            }
            else if (type.Equals("Симптомы"))
            {
                show_table_list.DisplayMember = "title";
                show_table_list.ValueMember = "id";
                show_table_list.DataSource = Symptoms.getAllSymptoms(f1.prg.db);
                show_table_list.SelectedIndex = -1;
            }
            else if (type.Equals("Лекарства"))
            {
                show_table_list.DisplayMember = "title";
                show_table_list.ValueMember = "id";
                show_table_list.DataSource = Medications.getAllMedications(f1.prg.db);
                show_table_list.SelectedIndex = -1;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadList(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            string type = comboBox1.SelectedItem.ToString();

            if (type.Equals("Заболевания"))
            {
                AddDisiase add_disease_form = new AddDisiase(f1, this);
                add_disease_form.ShowDialog(f1);
                add_disease_form.Dispose();
            }
            else if (type.Equals("Симптомы"))
            {
                AddSymptom add_symptom_form = new AddSymptom(f1, this);
                add_symptom_form.ShowDialog(f1);
                add_symptom_form.Dispose();
            }
            else if (type.Equals("Лекарства"))
            {
                AddMed add_med_form = new AddMed(f1, this);
                add_med_form.ShowDialog(f1);
                add_med_form.Dispose();
            }
        }

        private void show_table_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            string type = comboBox1.SelectedItem.ToString();

            if (type.Equals("Заболевания"))
            {
                Diseases disease = show_table_list.SelectedItem as Diseases;
                EditDisease edit_disease_form = new EditDisease(f1, this, disease);
                edit_disease_form.ShowDialog(f1);
                edit_disease_form.Dispose();
            }
            else if (type.Equals("Симптомы"))
            {
                Symptoms symptom = show_table_list.SelectedItem as Symptoms;
                EditSymptom edit_symptom_form = new EditSymptom(f1, this, symptom);
                edit_symptom_form.ShowDialog(f1);
                edit_symptom_form.Dispose();
            }
            else if (type.Equals("Лекарства"))
            {
                Medications med = show_table_list.SelectedItem as Medications;
                EditMed edit_med_form = new EditMed(f1, this, med);
                edit_med_form.ShowDialog(f1);
                edit_med_form.Dispose();
            }
        }
    }
}
