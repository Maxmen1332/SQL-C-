namespace Scientific_conference
{
    partial class InsRap
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Deg = new System.Windows.Forms.TextBox();
            this.Org = new System.Windows.Forms.TextBox();
            this.FIO_Rap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scientific_conferenceDataSet1 = new Scientific_conference.Scientific_conferenceDataSet();
            this.scientific_adviserTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Scientific_adviserTableAdapter();
            this.rapporteurTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter();
            this.FIO_Adv = new System.Windows.Forms.ComboBox();
            this.scientificadviserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Adv_degr = new System.Windows.Forms.ComboBox();
            this.ID_Adv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientificadviserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deg
            // 
            this.Deg.Location = new System.Drawing.Point(311, 169);
            this.Deg.Margin = new System.Windows.Forms.Padding(2);
            this.Deg.Name = "Deg";
            this.Deg.Size = new System.Drawing.Size(320, 20);
            this.Deg.TabIndex = 20;
            this.Deg.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Org
            // 
            this.Org.Location = new System.Drawing.Point(311, 144);
            this.Org.Margin = new System.Windows.Forms.Padding(2);
            this.Org.Name = "Org";
            this.Org.Size = new System.Drawing.Size(320, 20);
            this.Org.TabIndex = 19;
            this.Org.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FIO_Rap
            // 
            this.FIO_Rap.Location = new System.Drawing.Point(311, 120);
            this.FIO_Rap.Margin = new System.Windows.Forms.Padding(2);
            this.FIO_Rap.Name = "FIO_Rap";
            this.FIO_Rap.Size = new System.Drawing.Size(320, 20);
            this.FIO_Rap.TabIndex = 18;
            this.FIO_Rap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ФИО научного руководителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Научная степень";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ФИО докладчика";
            // 
            // scientific_conferenceDataSet1
            // 
            this.scientific_conferenceDataSet1.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scientific_adviserTableAdapter1
            // 
            this.scientific_adviserTableAdapter1.ClearBeforeFill = true;
            // 
            // rapporteurTableAdapter1
            // 
            this.rapporteurTableAdapter1.ClearBeforeFill = true;
            // 
            // FIO_Adv
            // 
            this.FIO_Adv.DataSource = this.scientificadviserBindingSource;
            this.FIO_Adv.DisplayMember = "FIO_of_scientific_adviser";
            this.FIO_Adv.FormattingEnabled = true;
            this.FIO_Adv.Location = new System.Drawing.Point(311, 194);
            this.FIO_Adv.Name = "FIO_Adv";
            this.FIO_Adv.Size = new System.Drawing.Size(320, 21);
            this.FIO_Adv.TabIndex = 24;
            // 
            // scientificadviserBindingSource
            // 
            this.scientificadviserBindingSource.DataMember = "Scientific_adviser";
            this.scientificadviserBindingSource.DataSource = this.scientific_conferenceDataSet1;
            // 
            // Adv_degr
            // 
            this.Adv_degr.DataSource = this.scientificadviserBindingSource;
            this.Adv_degr.DisplayMember = "Scientific_degree";
            this.Adv_degr.FormattingEnabled = true;
            this.Adv_degr.Location = new System.Drawing.Point(311, 221);
            this.Adv_degr.Name = "Adv_degr";
            this.Adv_degr.Size = new System.Drawing.Size(320, 21);
            this.Adv_degr.TabIndex = 25;
            // 
            // ID_Adv
            // 
            this.ID_Adv.DataSource = this.scientificadviserBindingSource;
            this.ID_Adv.DisplayMember = "ID_of_scientific_adviser";
            this.ID_Adv.FormattingEnabled = true;
            this.ID_Adv.Location = new System.Drawing.Point(589, 41);
            this.ID_Adv.Name = "ID_Adv";
            this.ID_Adv.Size = new System.Drawing.Size(175, 21);
            this.ID_Adv.TabIndex = 26;
            this.ID_Adv.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Научная степень";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InsRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Adv);
            this.Controls.Add(this.Adv_degr);
            this.Controls.Add(this.FIO_Adv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Deg);
            this.Controls.Add(this.Org);
            this.Controls.Add(this.FIO_Rap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "InsRap";
            this.Text = "Ввод докладчика";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientificadviserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Deg;
        private System.Windows.Forms.TextBox Org;
        private System.Windows.Forms.TextBox FIO_Rap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Scientific_conferenceDataSet scientific_conferenceDataSet1;
        private Scientific_conferenceDataSetTableAdapters.Scientific_adviserTableAdapter scientific_adviserTableAdapter1;
        private Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter rapporteurTableAdapter1;
        private System.Windows.Forms.ComboBox FIO_Adv;
        private System.Windows.Forms.BindingSource scientificadviserBindingSource;
        private System.Windows.Forms.ComboBox Adv_degr;
        private System.Windows.Forms.ComboBox ID_Adv;
        private System.Windows.Forms.Label label1;
    }
}