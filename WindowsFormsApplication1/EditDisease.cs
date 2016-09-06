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
    public partial class EditDisease : Form
    {
        Form1 f1;
        Form2 f2;
        bool firstLoad = false;
        private List<long> simptomsSelectedArray = new List<long>();
        Diseases disease;
        public EditDisease(Form1 f1, Form2 f2, Diseases disease)
        {
            this.f1 = f1;
            this.f2 = f2;
            this.disease = disease;
            InitializeComponent();
        }

        private void EditDisease_Load(object sender, EventArgs e)
        {
            textBox1.Text = disease.title;

            simptomsList.DisplayMember = "title";
            simptomsList.ValueMember = "id";
            simptomsList.DataSource = Symptoms.getAllSymptoms(f1.prg.db);
            simptomsList.SelectedIndex = -1;

            foreach (Symptoms symptom in Symptoms.symptomsByDisease(f1.prg.db, disease.id.ToString()))
            {
                simptomsSelectedArray.Insert(0, symptom.id);
                simptomsSelectedList.Items.Insert(0, symptom.title);
            }

            firstLoad = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simptomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = simptomsList.GetItemText(simptomsList.SelectedItem);
            if (!simptomsSelectedList.Items.Contains(selectedItem))
            {
                if (firstLoad)
                {
                    Symptoms symptom = simptomsList.SelectedItem as Symptoms;
                    simptomsSelectedList.Items.Insert(0, symptom.title);
                    simptomsSelectedArray.Insert(0, symptom.id);
                }
            }
        }

        private void simptomsSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simptomsList.Text = "";
            simptomsList.SelectedText = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diseases.editDisease(f1.prg.db, disease.id, textBox1.Text, simptomsSelectedArray);
            f2.loadList("Заболевания");
            f1.reload();
            MessageBox.Show("Запись обновлена");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = simptomsSelectedList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = simptomsSelectedList.SelectedIndices[i];
                simptomsSelectedList.Items.RemoveAt(idx);
                simptomsSelectedArray.RemoveAt(idx);
            }
        }
    }
}
