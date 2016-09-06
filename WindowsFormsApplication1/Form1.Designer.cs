namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.simptomsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.illsList = new System.Windows.Forms.ComboBox();
            this.simptomsSelectedList = new System.Windows.Forms.ListBox();
            this.illsSelectedList = new System.Windows.Forms.ListBox();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.find_diseases_by_symptoms = new System.Windows.Forms.Button();
            this.diseases_by_symptoms_list = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.med_description = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.print_order = new System.Windows.Forms.Button();
            this.med_search_field = new System.Windows.Forms.TextBox();
            this.med_search_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.print_inst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseases_by_symptoms_list)).BeginInit();
            this.SuspendLayout();
            // 
            // simptomsList
            // 
            this.simptomsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.simptomsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.simptomsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.simptomsList.DropDownWidth = 323;
            this.simptomsList.FormattingEnabled = true;
            this.simptomsList.Location = new System.Drawing.Point(12, 69);
            this.simptomsList.Name = "simptomsList";
            this.simptomsList.Size = new System.Drawing.Size(173, 150);
            this.simptomsList.TabIndex = 1;
            this.simptomsList.SelectedIndexChanged += new System.EventHandler(this.simptomList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Симптомы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Противопоказания";
            // 
            // illsList
            // 
            this.illsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.illsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.illsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.illsList.DropDownWidth = 323;
            this.illsList.FormattingEnabled = true;
            this.illsList.Location = new System.Drawing.Point(12, 318);
            this.illsList.Name = "illsList";
            this.illsList.Size = new System.Drawing.Size(173, 151);
            this.illsList.TabIndex = 4;
            this.illsList.SelectedIndexChanged += new System.EventHandler(this.illsList_SelectedIndexChanged);
            // 
            // simptomsSelectedList
            // 
            this.simptomsSelectedList.FormattingEnabled = true;
            this.simptomsSelectedList.Location = new System.Drawing.Point(12, 210);
            this.simptomsSelectedList.Name = "simptomsSelectedList";
            this.simptomsSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.simptomsSelectedList.Size = new System.Drawing.Size(173, 82);
            this.simptomsSelectedList.TabIndex = 19;
            this.simptomsSelectedList.SelectedIndexChanged += new System.EventHandler(this.simptomsSelectedList_SelectedIndexChanged_1);
            // 
            // illsSelectedList
            // 
            this.illsSelectedList.FormattingEnabled = true;
            this.illsSelectedList.Location = new System.Drawing.Point(12, 459);
            this.illsSelectedList.Name = "illsSelectedList";
            this.illsSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.illsSelectedList.Size = new System.Drawing.Size(173, 82);
            this.illsSelectedList.TabIndex = 20;
            this.illsSelectedList.SelectedIndexChanged += new System.EventHandler(this.illsSelectedList_SelectedIndexChanged);
            // 
            // deleteSelected
            // 
            this.deleteSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteSelected.BackgroundImage")));
            this.deleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteSelected.Location = new System.Drawing.Point(49, 5);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(31, 31);
            this.deleteSelected.TabIndex = 21;
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(187, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Подобранные лекарства";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Поиск лекарственного средства";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(86, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(741, 223);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(610, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Подробное описание";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(901, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 31);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // find_diseases_by_symptoms
            // 
            this.find_diseases_by_symptoms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("find_diseases_by_symptoms.BackgroundImage")));
            this.find_diseases_by_symptoms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.find_diseases_by_symptoms.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_diseases_by_symptoms.Location = new System.Drawing.Point(12, 5);
            this.find_diseases_by_symptoms.Name = "find_diseases_by_symptoms";
            this.find_diseases_by_symptoms.Size = new System.Drawing.Size(31, 31);
            this.find_diseases_by_symptoms.TabIndex = 30;
            this.find_diseases_by_symptoms.UseVisualStyleBackColor = true;
            this.find_diseases_by_symptoms.Click += new System.EventHandler(this.find_diseases_by_symptoms_Click);
            // 
            // diseases_by_symptoms_list
            // 
            this.diseases_by_symptoms_list.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.diseases_by_symptoms_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diseases_by_symptoms_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diseases_by_symptoms_list.Location = new System.Drawing.Point(191, 69);
            this.diseases_by_symptoms_list.Name = "diseases_by_symptoms_list";
            this.diseases_by_symptoms_list.Size = new System.Drawing.Size(417, 223);
            this.diseases_by_symptoms_list.TabIndex = 31;
            this.diseases_by_symptoms_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diseases_by_symptoms_list_CellClick);
            this.diseases_by_symptoms_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diseases_by_symptoms_list_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(187, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Вероятные заболевания";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // med_description
            // 
            this.med_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.med_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.med_description.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.med_description.Location = new System.Drawing.Point(614, 69);
            this.med_description.Multiline = true;
            this.med_description.Name = "med_description";
            this.med_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.med_description.Size = new System.Drawing.Size(318, 223);
            this.med_description.TabIndex = 33;
            this.med_description.TextChanged += new System.EventHandler(this.med_description_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(944, 552);
            this.shapeContainer1.TabIndex = 34;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Silver;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gray;
            this.rectangleShape1.Location = new System.Drawing.Point(-11, -4);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(964, 44);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // print_order
            // 
            this.print_order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_order.BackgroundImage")));
            this.print_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_order.ForeColor = System.Drawing.SystemColors.Control;
            this.print_order.Location = new System.Drawing.Point(123, 6);
            this.print_order.Name = "print_order";
            this.print_order.Size = new System.Drawing.Size(31, 31);
            this.print_order.TabIndex = 35;
            this.print_order.UseVisualStyleBackColor = true;
            this.print_order.Click += new System.EventHandler(this.print_order_Click);
            // 
            // med_search_field
            // 
            this.med_search_field.Location = new System.Drawing.Point(614, 10);
            this.med_search_field.Name = "med_search_field";
            this.med_search_field.Size = new System.Drawing.Size(246, 20);
            this.med_search_field.TabIndex = 36;
            this.med_search_field.TextChanged += new System.EventHandler(this.med_search_field_TextChanged);
            this.med_search_field.KeyDown += new System.Windows.Forms.KeyEventHandler(this.med_search_field_KeyDown);
            // 
            // med_search_button
            // 
            this.med_search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.med_search_button.Location = new System.Drawing.Point(753, 88);
            this.med_search_button.Name = "med_search_button";
            this.med_search_button.Size = new System.Drawing.Size(157, 25);
            this.med_search_button.TabIndex = 37;
            this.med_search_button.Text = "Поиск по названию";
            this.med_search_button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.med_search_button.UseVisualStyleBackColor = true;
            this.med_search_button.Visible = false;
            this.med_search_button.Click += new System.EventHandler(this.med_search_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(431, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Поиск лекарства по названию";
            // 
            // print_inst
            // 
            this.print_inst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_inst.BackgroundImage")));
            this.print_inst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_inst.Location = new System.Drawing.Point(160, 6);
            this.print_inst.Name = "print_inst";
            this.print_inst.Size = new System.Drawing.Size(31, 31);
            this.print_inst.TabIndex = 39;
            this.print_inst.UseVisualStyleBackColor = true;
            this.print_inst.Click += new System.EventHandler(this.print_inst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 552);
            this.Controls.Add(this.print_inst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.med_search_button);
            this.Controls.Add(this.med_search_field);
            this.Controls.Add(this.print_order);
            this.Controls.Add(this.med_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diseases_by_symptoms_list);
            this.Controls.Add(this.find_diseases_by_symptoms);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.illsSelectedList);
            this.Controls.Add(this.simptomsSelectedList);
            this.Controls.Add(this.illsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simptomsList);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подбор лекарственных средств";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseases_by_symptoms_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox simptomsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox illsList;
        private System.Windows.Forms.ListBox simptomsSelectedList;
        private System.Windows.Forms.ListBox illsSelectedList;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button find_diseases_by_symptoms;
        public System.Windows.Forms.DataGridView diseases_by_symptoms_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox med_description;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button print_order;
        private System.Windows.Forms.TextBox med_search_field;
        private System.Windows.Forms.Button med_search_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button print_inst;
    }
}

