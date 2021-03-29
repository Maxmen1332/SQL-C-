namespace Scientific_conference
{
    partial class NewPubDet
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
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.massmediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_conferenceDataSet1 = new Scientific_conference.Scientific_conferenceDataSet();
            this.mass_mediaTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Mass_mediaTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SerialNumber = new System.Windows.Forms.ComboBox();
            this.IDmasmed = new System.Windows.Forms.ComboBox();
            this.publication_detailsTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Publication_detailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massmediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.projectBindingSource;
            this.comboBox1.DisplayMember = "Topic_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(481, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.massmediaBindingSource;
            this.comboBox2.DisplayMember = "Designation";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(270, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // massmediaBindingSource
            // 
            this.massmediaBindingSource.DataMember = "Mass_media";
            this.massmediaBindingSource.DataSource = this.scientific_conferenceDataSet1;
            // 
            // scientific_conferenceDataSet1
            // 
            this.scientific_conferenceDataSet1.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mass_mediaTableAdapter
            // 
            this.mass_mediaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.massmediaBindingSource;
            this.comboBox3.DisplayMember = "Type";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(270, 248);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(239, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataSource = this.projectBindingSource;
            this.SerialNumber.DisplayMember = "Serial_number";
            this.SerialNumber.FormattingEnabled = true;
            this.SerialNumber.Location = new System.Drawing.Point(680, 51);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(71, 21);
            this.SerialNumber.TabIndex = 5;
            this.SerialNumber.SelectedIndexChanged += new System.EventHandler(this.SerialNumber_SelectedIndexChanged);
            // 
            // IDmasmed
            // 
            this.IDmasmed.DataSource = this.massmediaBindingSource;
            this.IDmasmed.DisplayMember = "ID_of_mass_media";
            this.IDmasmed.FormattingEnabled = true;
            this.IDmasmed.Location = new System.Drawing.Point(680, 93);
            this.IDmasmed.Name = "IDmasmed";
            this.IDmasmed.Size = new System.Drawing.Size(71, 21);
            this.IDmasmed.TabIndex = 6;
            this.IDmasmed.SelectedIndexChanged += new System.EventHandler(this.IDmasmed_SelectedIndexChanged);
            // 
            // publication_detailsTableAdapter1
            // 
            this.publication_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Где опубликовано";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип издания";
            // 
            // NewPubDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDmasmed);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NewPubDet";
            this.Text = "Новая запись в спонсирования";
            this.Load += new System.EventHandler(this.NewPubDet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massmediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Scientific_conferenceDataSet scientific_conferenceDataSet1;
        private System.Windows.Forms.BindingSource massmediaBindingSource;
        private Scientific_conferenceDataSetTableAdapters.Mass_mediaTableAdapter mass_mediaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox SerialNumber;
        private System.Windows.Forms.ComboBox IDmasmed;
        private Scientific_conferenceDataSetTableAdapters.Publication_detailsTableAdapter publication_detailsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}