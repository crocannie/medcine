namespace WindowsFormsApplication1
{
    partial class AddMed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMed));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pokazSelectedList = new System.Windows.Forms.ListBox();
            this.pokazList = new System.Windows.Forms.ComboBox();
            this.protivSelectedList = new System.Windows.Forms.ListBox();
            this.protivList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название лекарства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 147);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(398, 89);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pokazSelectedList
            // 
            this.pokazSelectedList.FormattingEnabled = true;
            this.pokazSelectedList.Location = new System.Drawing.Point(12, 389);
            this.pokazSelectedList.Name = "pokazSelectedList";
            this.pokazSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pokazSelectedList.Size = new System.Drawing.Size(193, 82);
            this.pokazSelectedList.TabIndex = 6;
            this.pokazSelectedList.SelectedIndexChanged += new System.EventHandler(this.simptomsSelectedList_SelectedIndexChanged);
            // 
            // pokazList
            // 
            this.pokazList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.pokazList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pokazList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.pokazList.DropDownWidth = 323;
            this.pokazList.FormattingEnabled = true;
            this.pokazList.Location = new System.Drawing.Point(12, 262);
            this.pokazList.Name = "pokazList";
            this.pokazList.Size = new System.Drawing.Size(193, 137);
            this.pokazList.TabIndex = 5;
            this.pokazList.SelectedIndexChanged += new System.EventHandler(this.simptomsList_SelectedIndexChanged);
            // 
            // protivSelectedList
            // 
            this.protivSelectedList.FormattingEnabled = true;
            this.protivSelectedList.Location = new System.Drawing.Point(211, 389);
            this.protivSelectedList.Name = "protivSelectedList";
            this.protivSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.protivSelectedList.Size = new System.Drawing.Size(199, 82);
            this.protivSelectedList.TabIndex = 8;
            this.protivSelectedList.SelectedIndexChanged += new System.EventHandler(this.protivSelectedList_SelectedIndexChanged);
            // 
            // protivList
            // 
            this.protivList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.protivList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.protivList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.protivList.DropDownWidth = 323;
            this.protivList.FormattingEnabled = true;
            this.protivList.Location = new System.Drawing.Point(211, 261);
            this.protivList.Name = "protivList";
            this.protivList.Size = new System.Drawing.Size(199, 138);
            this.protivList.TabIndex = 7;
            this.protivList.SelectedIndexChanged += new System.EventHandler(this.illsList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Показания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Противопоказания";
            // 
            // deleteSelected
            // 
            this.deleteSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteSelected.BackgroundImage")));
            this.deleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteSelected.Location = new System.Drawing.Point(49, 477);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(31, 31);
            this.deleteSelected.TabIndex = 26;
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 64);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(398, 62);
            this.textBox4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Способы применения и дозировка";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.protivSelectedList);
            this.Controls.Add(this.protivList);
            this.Controls.Add(this.pokazSelectedList);
            this.Controls.Add(this.pokazList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление лекарства";
            this.Load += new System.EventHandler(this.AddMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox pokazSelectedList;
        private System.Windows.Forms.ComboBox pokazList;
        private System.Windows.Forms.ListBox protivSelectedList;
        private System.Windows.Forms.ComboBox protivList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
    }
}