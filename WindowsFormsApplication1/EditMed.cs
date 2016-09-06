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
    public partial class EditMed : Form
    {
        Form1 f1;
        Form2 f2;
        bool firstLoad = false;
        Medications med;
        private List<long> pokaz = new List<long>(); // показания
        private List<long> protiv = new List<long>(); // противопоказания
        public EditMed(Form1 f1, Form2 f2, Medications med)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.med = med;
            InitializeComponent();
        }

        private void EditMed_Load(object sender, EventArgs e)
        {
            textBox1.Text = med.title;
            textBox2.Text = med.price.ToString();
            textBox4.Text = Medications.doseByMeId(f1.prg.db, med.id.ToString());
            textBox3.Text = med.description;

            pokazList.DisplayMember = "title";
            pokazList.ValueMember = "id";
            pokazList.DataSource = Diseases.getAllDiseases(f1.prg.db);
            pokazList.SelectedIndex = -1;


            protivList.DisplayMember = "title";
            protivList.ValueMember = "id";
            protivList.DataSource = Diseases.getAllDiseases(f1.prg.db);
            protivList.SelectedIndex = -1;
            firstLoad = true;

            foreach (Diseases dis in Diseases.contrDiseasesByMed(f1.prg.db, Convert.ToString(med.id)))
            {
                protiv.Insert(0, dis.id);
                protivSelectedList.Items.Insert(0, dis.title);
            }


            foreach (Diseases dis in Diseases.diseasesByMed(f1.prg.db, Convert.ToString(med.id)))
            {
                pokaz.Insert(0, dis.id);
                pokazSelectedList.Items.Insert(0, dis.title);
            }
        }

        private void pokazList_SelectedIndexChanged(object sender, EventArgs e)
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

        private void protivList_SelectedIndexChanged(object sender, EventArgs e)
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

        private void pokazSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokazList.Text = "";
            pokazList.SelectedText = "";
        }

        private void protivSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            protivList.Text = "";
            protivList.SelectedText = "";
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
            Medications.deleteMed(f1.prg.db, med.id);
            long med_id = Medications.addMed(f1.prg.db, title, price, dose, description, pokaz, protiv);
            med.setID(med_id);

            f2.loadList("Лекарства");
            f1.reload();
            MessageBox.Show("Запись обновлена");
        }

        private void deleteSelected_Click(object sender, EventArgs e)
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
    }
}
