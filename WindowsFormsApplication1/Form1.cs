using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Repositories;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Main prg = new Main();
        bool firstLoad = false;
        private List<long> simptomsSelectedArray = new List<long>();
        private List<long> diseasesSelectedArray = new List<long>();
        private List<long> findedDiseases = new List<long>();
        private int bed_meds_idx = 0;
        private List<long> bedMeds = new List<long>();
        private string sort_meds_type = "ASC";

        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.print_inst, "Распечатать описание препарата");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.print_order, "Распечатать вероятные заболевания");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.button2, "Распечатать рецепт");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.find_diseases_by_symptoms, "Поиск");

            System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
            ToolTip5.SetToolTip(this.deleteSelected, "Удалить лишние элементы");

            System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
            ToolTip6.SetToolTip(this.button3, "Администратор");
        }

        private void simptomList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = simptomsList.GetItemText(simptomsList.SelectedItem);
            if (!simptomsSelectedList.Items.Contains(selectedItem))
            {
                if (firstLoad)
                {
                    Symptoms symptom = simptomsList.SelectedItem as Symptoms;
                    if (symptom != null)
                    {
                        simptomsSelectedList.Items.Insert(0, symptom.title);
                        simptomsSelectedArray.Insert(0, symptom.id);
                    }
                }
            }
        }



        private void simptomsSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simptomsList.Text = "";
            simptomsList.SelectedText = "";
        }

        private void illsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = illsList.GetItemText(illsList.SelectedItem);

            if (!illsSelectedList.Items.Contains(selectedItem))
            {
                if (firstLoad)
                {
                    Diseases disease = illsList.SelectedItem as Diseases;
                    if (disease != null)
                    {
                        illsSelectedList.Items.Insert(0, disease.title);
                        diseasesSelectedArray.Insert(0, disease.id);
                    }
                }
            }
        }

        private void simptomsSelectedList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            simptomsList.Text = "";
            simptomsList.SelectedText = "";
        }

        private void illsSelectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            illsList.Text = "";
            illsList.SelectedText = "";
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            for (int i = simptomsSelectedList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = simptomsSelectedList.SelectedIndices[i];
                simptomsSelectedList.Items.RemoveAt(idx);
                simptomsSelectedArray.RemoveAt(idx);
            }
            for (int i = illsSelectedList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = illsSelectedList.SelectedIndices[i];
                illsSelectedList.Items.RemoveAt(idx);
                diseasesSelectedArray.RemoveAt(idx);
            }
            //11 дека среда 1000
            //+79053647108+
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simptomsList.DisplayMember = "title";
            simptomsList.ValueMember = "id";
            simptomsList.DataSource = Symptoms.getAllSymptoms(prg.db);
            simptomsList.SelectedIndex = -1;


            illsList.DisplayMember = "title";
            illsList.ValueMember = "id";
            illsList.DataSource = Diseases.getAllDiseases(prg.db);
            illsList.SelectedIndex = -1;
            firstLoad = true;
        }


        public void reload()
        {
            
            bed_meds_idx = 0;
            sort_meds_type = "ASC";

            simptomsList.DisplayMember = "title";
            simptomsList.ValueMember = "id";
            simptomsList.DataSource = Symptoms.getAllSymptoms(prg.db);
            simptomsList.SelectedIndex = -1;


            illsList.DisplayMember = "title";
            illsList.ValueMember = "id";
            illsList.DataSource = Diseases.getAllDiseases(prg.db);
            illsList.SelectedIndex = -1;
            firstLoad = true;

            if (diseases_by_symptoms_list.DataSource != null)
            {
                diseases_by_symptoms_list.DataSource = null;
            }
            else
            {
                diseases_by_symptoms_list.Rows.Clear();
            }

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }

            med_description.Text = "";
            med_search_field.Text = "";

            simptomsSelectedList.Items.Clear();
            illsSelectedList.Items.Clear();
            simptomsSelectedArray.Clear();
            diseasesSelectedArray.Clear();
            findedDiseases.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (prg.auth)
            {
                Form2 admin_form = new Form2(this);
                admin_form.ShowDialog(this);
                admin_form.Dispose();
            }
            else
            {
                Auth auth_form = new Auth(this);
                auth_form.ShowDialog(this);
                auth_form.Dispose();
            }
            
        }

        private void find_diseases_by_symptoms_Click(object sender, EventArgs e)
        {
            string symptoms = "";
            foreach (long id in simptomsSelectedArray)
            {
                symptoms += Convert.ToString(id) + ",";
            }
            if (symptoms.Length >= 2)
                symptoms = symptoms.Substring(0, symptoms.Length - 1);


            DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Symptoms");
            findedDiseases = new List<long>();
            foreach (Diseases dis in Diseases.getDiseasesBySymptoms(prg.db, symptoms))
            {
                string symptoms_for_disease = "";
                foreach (Symptoms sym in Symptoms.symptomsByDisease(prg.db, Convert.ToString(dis.id)))
                {
                    symptoms_for_disease += sym.title + Environment.NewLine;
                }
                findedDiseases.Add(dis.id);
                symptoms_for_disease = symptoms_for_disease.Trim();
                dt.Rows.Add(dis.id, dis.title, symptoms_for_disease);
            }
            diseases_by_symptoms_list.DataSource = dt.DefaultView;
            diseases_by_symptoms_list.Visible = true;
            diseases_by_symptoms_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            diseases_by_symptoms_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            diseases_by_symptoms_list.Columns["ID"].Visible = false;
            diseases_by_symptoms_list.Columns["Symptoms"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            diseases_by_symptoms_list.AllowUserToAddRows = false;
            diseases_by_symptoms_list.AllowUserToDeleteRows = false;
            diseases_by_symptoms_list.AllowUserToOrderColumns = false;
            diseases_by_symptoms_list.AllowUserToResizeColumns = false;
            diseases_by_symptoms_list.ReadOnly = true;
            diseases_by_symptoms_list.RowHeadersVisible = false;

            diseases_by_symptoms_list.Columns["Title"].HeaderText = "Заболевание";
            diseases_by_symptoms_list.Columns["Symptoms"].HeaderText = "Симптомы";
        }

        private void diseases_by_symptoms_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            diseases_by_symptoms_list.CurrentRow.Selected = true;
            string idDisease = diseases_by_symptoms_list.CurrentRow.Cells[0].Value.ToString();
            fill_diseases_by_symptoms_list(idDisease);
        }

        private void sort_meds(string type)
        {
            DataView dv1 = (DataView)(dataGridView1.DataSource);
            DataTable dt = dv1.ToTable();
            DataTable dt2 = dt.Clone();
            dt2.Columns["Price"].DataType = Type.GetType("System.Int32");
            foreach (DataRow dr in dt.Rows)
            {
                dt2.ImportRow(dr);
            }
            dt2.AcceptChanges();
            DataView dv = dt2.DefaultView;
            dv.Sort = "Price " + type;
            dataGridView1.DataSource = dv;
        }

        private void coloring_meds()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1["Checkbox", i].Value = false;
                dataGridView1.Columns["C1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["C2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1["C1", i].Style = new DataGridViewCellStyle
                {
                    ForeColor = Color.White,
                    Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily.ToString(), 20F, FontStyle.Bold)
                };
                dataGridView1["C2", i].Style = new DataGridViewCellStyle
                {
                    ForeColor = Color.White,
                    Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily.ToString(), 20F, FontStyle.Bold)
                };
                //if (i >= bed_meds_idx)
                if (bedMeds.Contains(Int64.Parse(dataGridView1["ID", i].Value.ToString())))
                    dataGridView1["C1", i].Style = new DataGridViewCellStyle
                    {
                        ForeColor = Color.Orange,
                        Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily.ToString(), 20F, FontStyle.Bold)
                    };

                if (Medications.countDiseasesByMed(prg.db, get_founded_diseases(), dataGridView1["ID", i].Value.ToString()) > 1)
                {
                    dataGridView1["C2", i].Style = new DataGridViewCellStyle
                    {
                        ForeColor = Color.Green,
                        Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily.ToString(), 20F, FontStyle.Bold)
                    };
                }
            }
            
        }

        private string get_founded_diseases()
        {
            string diseases = "";
            foreach (long id in findedDiseases)
            {
                diseases += Convert.ToString(id) + ",";
            }
            if (diseases.Length >= 2)
                diseases = diseases.Substring(0, diseases.Length - 1);
            return diseases;
        }

        private void fill_diseases_by_symptoms_list(string idDisease)
        {
            string contraindications = "";
            foreach (long id in diseasesSelectedArray)
            {
                contraindications += Convert.ToString(id) + ",";
            }
            if (contraindications.Length >= 2)
                contraindications = contraindications.Substring(0, contraindications.Length - 1);

            // список лекарств целиком
            IEnumerable<Medications> allMeds = Medications.getMedicationsByDiseases(prg.db, idDisease);
            IEnumerable<Medications> medsWithoutContraindications = Medications.getGoodMedicationsByContraindications(prg.db, contraindications);

            List<Medications> goodMeds = new List<Medications>();
            List<Medications> badMeds = new List<Medications>();

            foreach (Medications a in allMeds)
            {
                bool check = false;
                foreach (Medications b in medsWithoutContraindications)
                {
                    if (a.id == b.id)
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    badMeds.Add(a);
                }
                else
                {
                    goodMeds.Add(a);
                }
            }
            // цикл по найденным лекарствам
            // повыбирай симптомы на форме, посмотри, правильно ли находит
            // пока что нет пересечения с противопоказаниями, выводит все, думаю на завтра хватит
            DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(new DataColumn("Checkbox", typeof(bool)));
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Contraindications");
            dt.Columns.Add("Other_Diseases");
            dt.Columns.Add("Price");
            dt.Columns.Add("C1");
            dt.Columns.Add("C2");
            bed_meds_idx = 0;
            foreach (Medications med in goodMeds)
            {
                string contr_disease = "";
                foreach (Diseases dis in Diseases.contrDiseasesByMed(prg.db, Convert.ToString(med.id)))
                {
                    contr_disease += dis.title + Environment.NewLine;
                }

                string other_diseases = "";
                foreach (long id_disease in findedDiseases)
                {
                    if (Medications.countDiseasesByMed(prg.db, id_disease.ToString(), Convert.ToString(med.id)) >= 1)
                    {
                        if (!idDisease.Equals(id_disease.ToString()))
                        {
                            other_diseases += Diseases.getTitleById(prg.db, id_disease.ToString()) + ", ";
                        }
                    }
                }
                other_diseases = other_diseases.Trim();
                if (other_diseases.Length >= 2)
                    other_diseases = other_diseases.Substring(0, other_diseases.Length - 1);
                contr_disease = contr_disease.Trim();

                int price = 0;
                bool result = Int32.TryParse(med.price.ToString(), out price);
  
                dt.Rows.Add(false, med.id, med.title, contr_disease, other_diseases, price, "•", "•");
                bed_meds_idx++;
            }

            bedMeds = new List<long>();
            foreach (Medications med in badMeds)
            {
                bedMeds.Add(med.id);
                string contr_disease = "";
                foreach (Diseases dis in Diseases.contrDiseasesByMed(prg.db, Convert.ToString(med.id)))
                {
                    contr_disease += dis.title + Environment.NewLine;
                }
                string other_diseases = "";
                foreach (long id_disease in findedDiseases)
                {
                    if (Medications.countDiseasesByMed(prg.db, id_disease.ToString(), Convert.ToString(med.id)) >= 1)
                    {
                        if (!idDisease.Equals(id_disease.ToString()))
                        {
                            other_diseases += Diseases.getTitleById(prg.db, id_disease.ToString()) + ", ";
                        }
                    }
                }
                other_diseases = other_diseases.Trim();
                if (other_diseases.Length >= 2)
                    other_diseases = other_diseases.Substring(0, other_diseases.Length - 1);
                contr_disease = contr_disease.Trim();
                int price = 0;
                bool result = Int32.TryParse(med.price.ToString(), out price);

                dt.Rows.Add(false, med.id, med.title, contr_disease, other_diseases, price, "•", "•");
            }

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Contraindications"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Contraindications"].HeaderText = "Противопоказания";
            dataGridView1.Columns["Contraindications"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["Other_Diseases"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Other_Diseases"].HeaderText = "В том числе для лечения";
            dataGridView1.Columns["Other_Diseases"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["Checkbox"].Width = 25;
            dataGridView1.Columns["Checkbox"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Checkbox"].HeaderText = "";

            dataGridView1.Columns["Price"].HeaderText = "Руб";
            dataGridView1.Columns["Price"].Width = 35;




            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ReadOnly = true;




            dataGridView1.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Title"].HeaderText = "Лекарство";
            

            dataGridView1.Columns["C1"].HeaderText = "!";
            dataGridView1.Columns["C2"].HeaderText = "✓";

            dataGridView1.Columns["C1"].Width = 25;
            dataGridView1.Columns["C2"].Width = 25;


            dataGridView1.AllowUserToAddRows = false;

          
            sort_meds(sort_meds_type);
            coloring_meds();
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridView1.CurrentRow.Index;

            int idx_row = idx;
            int idx_col = dataGridView1.CurrentCell.ColumnIndex;



            if (idx_col == 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (idx_row == i)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1["checkbox", i];
                        chk.Value = !(Boolean)chk.Value;
                    }
                }
            }




            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (idx == i)
                {
                    dataGridView1["Title", i].Selected = true;
                    dataGridView1["Contraindications", i].Selected = true;
                    dataGridView1["Other_Diseases", i].Selected = true;
                    dataGridView1["Price", i].Selected = true;
                }
                else
                {
                    dataGridView1["Title", i].Selected = false;
                    dataGridView1["Contraindications", i].Selected = false;
                    dataGridView1["Other_Diseases", i].Selected = false;
                    dataGridView1["Price", i].Selected = false;
                }
            }

            string id = dataGridView1["ID", idx].Value.ToString();
            med_description.Text = get_med_description(id, idx);
        }

        public string get_med_description_for_print_recipe(string id, int idx)
        {
            string contr = dataGridView1["Contraindications", idx].Value.ToString();
            if (contr.Length == 0)
            {
                contr = '\u2022' + " Противопоказания: " + Environment.NewLine;
            }
            else
            {
                contr = '\u2022' + " Противопоказания: " + Environment.NewLine + contr;
            }
            contr += Environment.NewLine;

            string diseases = "";
            foreach (Diseases dis in Diseases.diseasesByMed(prg.db, Convert.ToString(id)))
            {
                diseases += Convert.ToString(dis.title) + Environment.NewLine;
            }
            diseases = diseases.Trim();

            if (diseases.Length == 0)
            {
                diseases = '\u2022' + " Показания: ";
            }
            else
            {
                diseases = '\u2022' + " Показания: " + Environment.NewLine + diseases;
            }
            diseases += Environment.NewLine;
            string price = '\u2022' + " Цена: " + Medications.priceByMedId(prg.db, id) + " руб." + Environment.NewLine;
            string dose = '\u2022' + " Способ применения: " + Medications.doseByMeId(prg.db, id) + Environment.NewLine;

            return dataGridView1["Title", idx].Value.ToString() + Environment.NewLine + Environment.NewLine + contr + diseases + price + dose;
       
        }

        //Подробное описание ЛС
        public string get_med_description(string id, int idx)
        {
            string contr = dataGridView1["Contraindications", idx].Value.ToString();
            if (contr.Length == 0)
            {
                contr = '\u2022' + " Противопоказания: " + Environment.NewLine;
            }
            else
            {
                contr = '\u2022' + " Противопоказания: " +  Environment.NewLine + contr;
            }
            contr += Environment.NewLine;

            string diseases = "";
            foreach (Diseases dis in Diseases.diseasesByMed(prg.db, Convert.ToString(id)))
            {
                diseases += Convert.ToString(dis.title) + Environment.NewLine;
            }
            diseases = diseases.Trim();

            if (diseases.Length == 0)
            {
                diseases = '\u2022' + " Показания: ";
            }
            else
            {
                diseases = '\u2022' + " Показания: " + Environment.NewLine + diseases;
            }
            diseases += Environment.NewLine;
            string price = '\u2022' + " Цена: " + Medications.priceByMedId(prg.db, id) + " руб." + Environment.NewLine;
            string dose = '\u2022' + " Способ применения: " + Medications.doseByMeId(prg.db, id) + Environment.NewLine;
            string desc = Medications.descriptionByMedId(prg.db, id);
            return dataGridView1["Title", idx].Value.ToString() + Environment.NewLine + Environment.NewLine + contr + diseases + price + dose + desc;
        }

        private void med_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void diseases_by_symptoms_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Печать рецепта по нажатию на кнопку
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 recipe = new Form4(this);
            recipe.ShowDialog(this);
            recipe.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        //Печать отчета #2
        private void print_order_Click(object sender, EventArgs e)
        {
            string res = "";
            res += "<html><head><title>Отчет</title><meta charset=\"UTF-8\"></head><body>";
            res += "<style>";
            res += "* {margin: 0; padding: 0;} td, tr, table {border-collapse: collapse; padding: 0; margin: 0;}";
            res += "td {border: 1px solid #ccc; border-collapse: collapse; padding: 3px;}";
            res += "table {width: 100%; max-width: 800px;}";
            res += "</style>";
            res += "<table cellspacing=\"0\" cellpadding=\"0\">";
            for (int i = 0; i < diseases_by_symptoms_list.RowCount; i++)
            {
                string dis_title = diseases_by_symptoms_list["Title", i].Value.ToString();
                string dis_id = diseases_by_symptoms_list["ID", i].Value.ToString();

                res += "<tr><td colspan=\"4\" style=\"font-size: 18px;\"><b>" + dis_title + "</b></td></tr>";

                string contraindications = "";
                foreach (long id in diseasesSelectedArray)
                {
                    contraindications += Convert.ToString(id) + ",";
                }
                if (contraindications.Length >= 2)
                    contraindications = contraindications.Substring(0, contraindications.Length - 1);

                IEnumerable<Medications> allMeds = Medications.getMedicationsByDiseases(prg.db, dis_id);
                IEnumerable<Medications> medsWithoutContraindications = Medications.getGoodMedicationsByContraindications(prg.db, contraindications);

                List<Medications> goodMeds = new List<Medications>();
                List<Medications> badMeds = new List<Medications>();

                foreach (Medications a in allMeds)
                {
                    bool check = false;
                    foreach (Medications b in medsWithoutContraindications)
                    {
                        if (a.id == b.id)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        badMeds.Add(a);
                    }
                    else
                    {
                        goodMeds.Add(a);
                    }
                }
                
                int row_idx = 0;
                res += "<tr><td><b>Лекарство</b></td><td><b>Противопоказания</b></td>";
                res += "<td><b>В том числе для лечения</b></td><td><b>Стоимость</b></td></tr>";
                foreach (Medications med in goodMeds)
                {
                    string contr_disease = "";
                    foreach (Diseases dis in Diseases.contrDiseasesByMed(prg.db, Convert.ToString(med.id)))
                    {
                        contr_disease += dis.title + Environment.NewLine;
                    }

                    string other_diseases = "";
                    foreach (long id_disease in findedDiseases)
                    {
                        if (Medications.countDiseasesByMed(prg.db, id_disease.ToString(), Convert.ToString(med.id)) >= 1)
                        {
                            if (!dis_id.Equals(id_disease.ToString()))
                            {
                                other_diseases += Diseases.getTitleById(prg.db, id_disease.ToString()) + ", ";
                            }
                        }
                    }
                    other_diseases = other_diseases.Trim();
                    if (other_diseases.Length >= 2)
                        other_diseases = other_diseases.Substring(0, other_diseases.Length - 1);
                    contr_disease = contr_disease.Trim();

                    res += "<tr><td>" + med.title + "</td><td>" + contr_disease + "</td>";
                    res += "<td>" + other_diseases + "</td><td>" + med.price + "</td></tr>";
                    row_idx++;
                }

                foreach (Medications med in badMeds)
                {
                    string contr_disease = "";
                    foreach (Diseases dis in Diseases.contrDiseasesByMed(prg.db, Convert.ToString(med.id)))
                    {
                        contr_disease += dis.title + Environment.NewLine;
                    }
                    string other_diseases = "";
                    foreach (long id_disease in findedDiseases)
                    {
                        if (Medications.countDiseasesByMed(prg.db, id_disease.ToString(), Convert.ToString(med.id)) >= 1)
                        {
                            if (!dis_id.Equals(id_disease.ToString()))
                            {
                                other_diseases += Diseases.getTitleById(prg.db, id_disease.ToString()) + ", ";
                            }
                        }
                    }
                    other_diseases = other_diseases.Trim();
                    if (other_diseases.Length >= 2)
                        other_diseases = other_diseases.Substring(0, other_diseases.Length - 1);
                    contr_disease = contr_disease.Trim();
                    res += "<tr><td>" + med.title + "</td><td>" + contr_disease + "</td>";
                    res += "<td>" + other_diseases + "</td><td>" + med.price + "</td></tr>";
                }
            }
            res += "</body></html></table>";

            string filename = @"C:\\отчет.html";

            System.IO.FileStream fs = System.IO.File.Create(filename);
            fs.Close();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                file.WriteLine(res);
                file.Close();
            }
            System.Diagnostics.Process.Start(filename);
        }

        //Поиск ЛС по нажатию на кнопку
        private void med_search_button_Click(object sender, EventArgs e)
        {
            med_search();
        }

        //Поиск ЛС по названию
        private void med_search()
        {
            string title = med_search_field.Text.Trim();

            if (title.Length == 0)
            {
                dataGridView1.DataSource = null;
                return;
            }
            IEnumerable<Medications> meds = Medications.getByTitle(prg.db, title);
           
            DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(new DataColumn("Checkbox", typeof(bool)));
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Contraindications");
            dt.Columns.Add("Other_Diseases");
            dt.Columns.Add("Price");
            dt.Columns.Add("C1");
            dt.Columns.Add("C2");
            int row_idx = 0;
            foreach (Medications med in meds)
            {
                string contr_disease = "";
                foreach (Diseases dis in Diseases.contrDiseasesByMed(prg.db, Convert.ToString(med.id)))
                {
                    contr_disease += dis.title + Environment.NewLine;
                }

                string other_diseases = "";
                foreach (Diseases disease in Diseases.getAllDiseases(prg.db))
                {
                    if (Medications.countDiseasesByMed(prg.db, disease.id.ToString(), Convert.ToString(med.id)) >= 1)
                    {
                        other_diseases += Diseases.getTitleById(prg.db, disease.id.ToString()) + ", ";
                    }
                }
                other_diseases = other_diseases.Trim();
                if (other_diseases.Length >= 2)
                    other_diseases = other_diseases.Substring(0, other_diseases.Length - 1);
                contr_disease = contr_disease.Trim();
                dt.Rows.Add(false, med.id, med.title, contr_disease, other_diseases, med.price, "•", "•");
                row_idx++;
            }

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Contraindications"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Contraindications"].HeaderText = "Противопоказания";
            dataGridView1.Columns["Contraindications"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Other_Diseases"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Other_Diseases"].HeaderText = "Показания";
            dataGridView1.Columns["Other_Diseases"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Checkbox"].Width = 25;
            dataGridView1.Columns["Checkbox"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Checkbox"].HeaderText = "";
            dataGridView1.Columns["Price"].HeaderText = "Руб";
            dataGridView1.Columns["Price"].Width = 35;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Title"].HeaderText = "Лекарство";
            dataGridView1.Columns["C1"].HeaderText = "!";
            dataGridView1.Columns["C2"].HeaderText = "✓";
            dataGridView1.Columns["C1"].Width = 25;
            dataGridView1.Columns["C2"].Width = 25;
            dataGridView1.AllowUserToAddRows = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1["C1", i].Style = new DataGridViewCellStyle
                {
                    ForeColor = Color.White,
                    Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily.ToString(), 20F, FontStyle.Bold)
                };
                dataGridView1["C2", i].Style = new DataGridViewCellStyle
                {
                    ForeColor = Color.White,
                    Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily.ToString(), 20F, FontStyle.Bold)
                };
            }

            for (int i = 0; i < diseases_by_symptoms_list.RowCount; i++)
            {
                diseases_by_symptoms_list["Title", i].Selected = false;
                diseases_by_symptoms_list["Symptoms", i].Selected = false;
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        //Поиск ЛС по нажатию Enter
        private void med_search_field_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                med_search();
            }
        }

        private void med_search_field_TextChanged(object sender, KeyEventArgs e) {
        }


        //---------------------------------
        public static long GetTimestamp()
        {

            return DateTime.UtcNow.Ticks;

        }

        //Инструкция
        private void print_inst_Click(object sender, EventArgs e)
        {
            string filename = @"C:\\описание\\" + "_" + GetTimestamp();
            FileStream fs = System.IO.File.Create(filename);
            fs.Close();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                file.WriteLine("Описание препарата");
  
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if ((Boolean) dataGridView1["Checkbox", i].Value == true)
                    {
                        file.WriteLine("------------------");
                        file.WriteLine(Environment.NewLine);
                        string id = dataGridView1["ID", i].Value.ToString();
                        file.WriteLine(get_med_description(id, i));
                    }
                }

                file.Close();
            }
            Process.Start("notepad.exe", filename);
        }

        private void med_search_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sort_meds_type.Equals("ASC"))
            {
                sort_meds_type = "DESC";
            }
            else
            {
                sort_meds_type = "ASC";
            }
            sort_meds(sort_meds_type);
            coloring_meds();
        }

       
        

    }
}
