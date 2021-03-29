namespace Scientific_conference
{
    partial class AddProj
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.rapporteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapporteurTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter();
            this.ProjSf = new System.Windows.Forms.TextBox();
            this.ProjTop = new System.Windows.Forms.TextBox();
            this.IDRap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.projectTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rapporteurBindingSource;
            this.comboBox1.DisplayMember = "FIO_of_rapporteur";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(379, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.rapporteurBindingSource;
            this.comboBox2.DisplayMember = "Organization";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(380, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.rapporteurBindingSource;
            this.comboBox3.DisplayMember = "Scientific_degree";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(380, 189);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(202, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapporteurBindingSource
            // 
            this.rapporteurBindingSource.DataMember = "Rapporteur";
            this.rapporteurBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // rapporteurTableAdapter
            // 
            this.rapporteurTableAdapter.ClearBeforeFill = true;
            // 
            // ProjSf
            // 
            this.ProjSf.Location = new System.Drawing.Point(379, 337);
            this.ProjSf.Name = "ProjSf";
            this.ProjSf.Size = new System.Drawing.Size(203, 20);
            this.ProjSf.TabIndex = 4;
            // 
            // ProjTop
            // 
            this.ProjTop.Location = new System.Drawing.Point(213, 311);
            this.ProjTop.Name = "ProjTop";
            this.ProjTop.Size = new System.Drawing.Size(369, 20);
            this.ProjTop.TabIndex = 6;
            // 
            // IDRap
            // 
            this.IDRap.DataSource = this.rapporteurBindingSource;
            this.IDRap.DisplayMember = "ID_of_rapporteur";
            this.IDRap.FormattingEnabled = true;
            this.IDRap.Location = new System.Drawing.Point(716, 34);
            this.IDRap.Name = "IDRap";
            this.IDRap.Size = new System.Drawing.Size(72, 21);
            this.IDRap.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите докладчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО Докладчика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Организация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Науч. Степень";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тема проекта";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Область";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // AddProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDRap);
            this.Controls.Add(this.ProjTop);
            this.Controls.Add(this.ProjSf);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "AddProj";
            this.Text = "AddProj";
            this.Load += new System.EventHandler(this.AddProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource rapporteurBindingSource;
        private Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter rapporteurTableAdapter;
        private System.Windows.Forms.TextBox ProjSf;
        private System.Windows.Forms.TextBox ProjTop;
        private System.Windows.Forms.ComboBox IDRap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter1;
    }
}