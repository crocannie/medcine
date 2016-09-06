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
    public partial class AddMed : Form
    {
        Form1 f1;
        Form2 f2;
        bool firstLoad = false;
        private List<long> pokaz = new List<long>(); // показания
        private List<long> protiv = new List<long>(); // противопоказания
        public AddMed(Form1 f1, Form2 f2)
        {
            this.f1 = f1;
            this.f2 = f2;
            InitializeComponent();
        }

        private void AddMed_Load(object sender, EventArgs e)
        {
            pokazList.DisplayMember = "title";
            pokazList.ValueMember = "id";
            pokazList.DataSource = Diseases.getAllDiseases(f1.prg.db);
            pokazList.SelectedIndex = -1;


            protivList.DisplayMember = "title";
            protivList.ValueMember = "id";
            protivList.DataSource = Diseases.getAllDiseases(f1.prg.db);
            protivList.SelectedIndex = -1;
            firstLoad = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if (title.Trim().Length == 0)
            {
                MessageBox.Show("Введите название!");
                return;
            }
            int price;
            bool priceCheck = Int32.TryParse(textBox2.Text, out price);
            if (!priceCheck)
            {
                MessageBox.Show("Стоимость должна быть целым числом!");
                return;
            }
            string dose = textBox4.Text;
            string description = textBox3.Text;
            /*if (description.Trim().Length == 0)
            {
                MessageBox.Show("Введите описание!");
                return;
            }*/
           
            Medications.addMed(f1.prg.db, title, price, dose, description, pokaz, protiv);
            //textBox1.Text = "";
            
            f2.loadList("Лекарства");
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            pokaz.Clear();
            protiv.Clear();


            pokazSelectedList.Items.Clear();
            protivSelectedList.Items.Clear();
            f1.reload();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void simptomsList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = pokazList.GetItemText(pokazList.SelectedItem);
            if (!pokazSelectedList.Items.Contains(selectedItem))
            {
                if (firstLoad)
                {
                    Diseases symptom = pokazList.SelectedItem as Diseases;
                    pokazSelectedList.Items.Insert(0, symptom.title);
                    pokaz.Insert(0, symptom.id);
                }
            }
        }

        private void simptomsSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokazList.Text = "";
            pokazList.SelectedText = "";
        }

        private void illsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = protivList.GetItemText(protivList.SelectedItem);

            if (!protivSelectedList.Items.Contains(selectedItem))
            {
                if (firstLoad)
                {
                    Diseases disease = protivList.SelectedItem as Diseases;
                    if (disease != null)
                    {
                        protivSelectedList.Items.Insert(0, disease.title);
                        protiv.Insert(0, disease.id);
                    }
                }
            }
        }
        private void illsSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            protivList.Text = "";
            protivList.SelectedText = "";
        }

        private void deleteSelected_Click_1(object sender, EventArgs e)
        {
            for (int i = pokazSelectedList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = pokazSelectedList.SelectedIndices[i];
                pokazSelectedList.Items.RemoveAt(idx);
                pokaz.RemoveAt(idx);
            }
            for (int i = protivSelectedList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = protivSelectedList.SelectedIndices[i];
                protivSelectedList.Items.RemoveAt(idx);
                protiv.RemoveAt(idx);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void protivSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}
