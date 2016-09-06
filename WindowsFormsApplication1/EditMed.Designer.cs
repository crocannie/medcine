namespace WindowsFormsApplication1
{
    partial class EditMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMed));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.protivSelectedList = new System.Windows.Forms.ListBox();
            this.protivList = new System.Windows.Forms.ComboBox();
            this.pokazSelectedList = new System.Windows.Forms.ListBox();
            this.pokazList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Способы применения и дозировка";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 63);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(398, 62);
            this.textBox4.TabIndex = 33;
            // 
            // deleteSelected
            // 
            this.deleteSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteSelected.BackgroundImage")));
            this.deleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteSelected.Location = new System.Drawing.Point(379, 242);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(31, 31);
            this.deleteSelected.TabIndex = 43;
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Противопоказания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Показания";
            // 
            // protivSelectedList
            // 
            this.protivSelectedList.FormattingEnabled = true;
            this.protivSelectedList.Location = new System.Drawing.Point(211, 404);
            this.protivSelectedList.Name = "protivSelectedList";
            this.protivSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.protivSelectedList.Size = new System.Drawing.Size(199, 82);
            this.protivSelectedList.TabIndex = 40;
            this.protivSelectedList.SelectedIndexChanged += new System.EventHandler(this.protivSelectedList_SelectedIndexChanged);
            // 
            // protivList
            // 
            this.protivList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.protivList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.protivList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.protivList.DropDownWidth = 323;
            this.protivList.FormattingEnabled = true;
            this.protivList.Location = new System.Drawing.Point(211, 275);
            this.protivList.Name = "protivList";
            this.protivList.Size = new System.Drawing.Size(199, 138);
            this.protivList.TabIndex = 39;
            this.protivList.SelectedIndexChanged += new System.EventHandler(this.protivList_SelectedIndexChanged);
            // 
            // pokazSelectedList
            // 
            this.pokazSelectedList.FormattingEnabled = true;
            this.pokazSelectedList.Location = new System.Drawing.Point(12, 404);
            this.pokazSelectedList.Name = "pokazSelectedList";
            this.pokazSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pokazSelectedList.Size = new System.Drawing.Size(193, 82);
            this.pokazSelectedList.TabIndex = 37;
            this.pokazSelectedList.SelectedIndexChanged += new System.EventHandler(this.pokazSelectedList_SelectedIndexChanged);
            // 
            // pokazList
            // 
            this.pokazList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.pokazList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pokazList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.pokazList.DropDownWidth = 323;
            this.pokazList.FormattingEnabled = true;
            this.pokazList.Location = new System.Drawing.Point(12, 276);
            this.pokazList.Name = "pokazList";
            this.pokazList.Size = new System.Drawing.Size(193, 137);
            this.pokazList.TabIndex = 36;
            this.pokazList.SelectedIndexChanged += new System.EventHandler(this.pokazList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Описание";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 146);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(398, 89);
            this.textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Стоимость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Название лекарства";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 534);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование лекарства";
            this.Load += new System.EventHandler(this.EditMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox protivSelectedList;
        private System.Windows.Forms.ComboBox protivList;
        private System.Windows.Forms.ListBox pokazSelectedList;
        private System.Windows.Forms.ComboBox pokazList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}