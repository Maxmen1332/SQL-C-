namespace Scientific_conference
{
    partial class NewRap_Conf
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rapporteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.rapporteurTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter();
            this.conferenceTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ConferenceTableAdapter();
            this.IDRap = new System.Windows.Forms.ComboBox();
            this.IDconf = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.performance_detailsTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Performance_detailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rapporteurBindingSource;
            this.comboBox1.DisplayMember = "FIO_of_rapporteur";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(379, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // rapporteurBindingSource
            // 
            this.rapporteurBindingSource.DataMember = "Rapporteur";
            this.rapporteurBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.conferenceBindingSource;
            this.comboBox2.DisplayMember = "Address";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(379, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataMember = "Conference";
            this.conferenceBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.conferenceBindingSource;
            this.comboBox3.DisplayMember = "Day";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(379, 210);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.conferenceBindingSource;
            this.comboBox4.DisplayMember = "FIO_organizer";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(379, 255);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(233, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // rapporteurTableAdapter
            // 
            this.rapporteurTableAdapter.ClearBeforeFill = true;
            // 
            // conferenceTableAdapter
            // 
            this.conferenceTableAdapter.ClearBeforeFill = true;
            // 
            // IDRap
            // 
            this.IDRap.DataSource = this.rapporteurBindingSource;
            this.IDRap.DisplayMember = "ID_of_rapporteur";
            this.IDRap.FormattingEnabled = true;
            this.IDRap.Location = new System.Drawing.Point(728, 368);
            this.IDRap.Name = "IDRap";
            this.IDRap.Size = new System.Drawing.Size(70, 21);
            this.IDRap.TabIndex = 4;
            // 
            // IDconf
            // 
            this.IDconf.DataSource = this.conferenceBindingSource;
            this.IDconf.DisplayMember = "ID_of_conference";
            this.IDconf.FormattingEnabled = true;
            this.IDconf.Location = new System.Drawing.Point(728, 341);
            this.IDconf.Name = "IDconf";
            this.IDconf.Size = new System.Drawing.Size(70, 21);
            this.IDconf.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // performance_detailsTableAdapter1
            // 
            this.performance_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите Докладчика";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите комбинацию из 4";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "1) Адреса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "2) Места поведения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "3) Организатора";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.conferenceBindingSource;
            this.comboBox5.DisplayMember = "Scientific_sphere";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(379, 292);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(233, 21);
            this.comboBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "4) Научной сферы";
            // 
            // NewRap_Conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDconf);
            this.Controls.Add(this.IDRap);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "NewRap_Conf";
            this.Text = "Новая запись в афишу";
            this.Load += new System.EventHandler(this.NewRap_Conf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rapporteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource rapporteurBindingSource;
        private Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter rapporteurTableAdapter;
        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ConferenceTableAdapter conferenceTableAdapter;
        private System.Windows.Forms.ComboBox IDRap;
        private System.Windows.Forms.ComboBox IDconf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Scientific_conferenceDataSetTableAdapters.Performance_detailsTableAdapter performance_detailsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
    }
}