namespace WindowsFormsApplication1
{
    partial class AddDisiase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDisiase));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.simptomsSelectedList = new System.Windows.Forms.ListBox();
            this.simptomsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название заболевания";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(15, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // simptomsSelectedList
            // 
            this.simptomsSelectedList.FormattingEnabled = true;
            this.simptomsSelectedList.Location = new System.Drawing.Point(15, 210);
            this.simptomsSelectedList.Name = "simptomsSelectedList";
            this.simptomsSelectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.simptomsSelectedList.Size = new System.Drawing.Size(361, 82);
            this.simptomsSelectedList.TabIndex = 21;
            this.simptomsSelectedList.SelectedIndexChanged += new System.EventHandler(this.simptomsSelectedList_SelectedIndexChanged_1);
            // 
            // simptomsList
            // 
            this.simptomsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.simptomsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.simptomsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.simptomsList.DropDownWidth = 323;
            this.simptomsList.FormattingEnabled = true;
            this.simptomsList.Location = new System.Drawing.Point(15, 81);
            this.simptomsList.Name = "simptomsList";
            this.simptomsList.Size = new System.Drawing.Size(361, 137);
            this.simptomsList.TabIndex = 20;
            this.simptomsList.SelectedIndexChanged += new System.EventHandler(this.simptomsList_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Симптомы";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(52, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddDisiase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simptomsSelectedList);
            this.Controls.Add(this.simptomsList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDisiase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заболевания";
            this.Load += new System.EventHandler(this.AddDisiase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox simptomsSelectedList;
        private System.Windows.Forms.ComboBox simptomsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}