namespace WindowsFormsApplication1
{
    partial class EditDisease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDisease));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.simptomsSelectedList = new System.Windows.Forms.ListBox();
            this.simptomsList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(343, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Симптомы";
            // 
            // simptomsSelectedList
            // 
            this.simptomsSelectedList.FormattingEnabled = true;
            this.simptomsSelectedList.Location = new System.Drawing.Point(13, 233);
            this.simptomsSelectedList.Name = "simptomsSelectedList";
            this.simptomsSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.simptomsSelectedList.Size = new System.Drawing.Size(361, 82);
            this.simptomsSelectedList.TabIndex = 28;
            this.simptomsSelectedList.SelectedIndexChanged += new System.EventHandler(this.simptomsSelectedList_SelectedIndexChanged);
            // 
            // simptomsList
            // 
            this.simptomsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.simptomsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.simptomsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.simptomsList.DropDownWidth = 323;
            this.simptomsList.FormattingEnabled = true;
            this.simptomsList.Location = new System.Drawing.Point(13, 105);
            this.simptomsList.Name = "simptomsList";
            this.simptomsList.Size = new System.Drawing.Size(361, 137);
            this.simptomsList.TabIndex = 27;
            this.simptomsList.SelectedIndexChanged += new System.EventHandler(this.simptomsList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(15, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название заболевания";
            // 
            // EditDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simptomsSelectedList);
            this.Controls.Add(this.simptomsList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDisease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заболевания";
            this.Load += new System.EventHandler(this.EditDisease_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox simptomsSelectedList;
        private System.Windows.Forms.ComboBox simptomsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}