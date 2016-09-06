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
    public partial class AddDisiase : Form
    {
        Form1 f1;
        Form2 f2;
        bool firstLoad = false;
        private List<long> simptomsSelectedArray = new List<long>();
        public AddDisiase(Form1 f1, Form2 f2)
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
            Diseases.addDisease(f1.prg.db, textBox1.Text, simptomsSelectedArray);
            textBox1.Text = "";
            f2.loadList("Заболевания");
            f1.reload();
        }

        private void AddDisiase_Load(object sender, EventArgs e)
        {
            simptomsList.DisplayMember = "title";
            simptomsList.ValueMember = "id";
            simptomsList.DataSource = Symptoms.getAllSymptoms(f1.prg.db);
            simptomsList.SelectedIndex = -1;
            firstLoad = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void simptomsList_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void simptomsSelectedList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            simptomsList.Text = "";
            simptomsList.SelectedText = "";
        }
    }
}
