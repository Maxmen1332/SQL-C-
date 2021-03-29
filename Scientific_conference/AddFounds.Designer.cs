namespace Scientific_conference
{
    partial class AddFounds
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
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IDspons = new System.Windows.Forms.ComboBox();
            this.IDproj = new System.Windows.Forms.ComboBox();
            this.sponsorTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.SponsorTableAdapter();
            this.funding_detailsTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Funding_detailsTableAdapter();
            this.projectTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.projectBindingSource;
            this.comboBox1.DisplayMember = "Topic_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(362, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sponsorBindingSource;
            this.comboBox2.DisplayMember = "Name_of_sponsor";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(362, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // sponsorBindingSource
            // 
            this.sponsorBindingSource.DataMember = "Sponsor";
            this.sponsorBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.sponsorBindingSource;
            this.comboBox3.DisplayMember = "Monetary_funds";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(239, 214);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(362, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDspons
            // 
            this.IDspons.DataSource = this.sponsorBindingSource;
            this.IDspons.DisplayMember = "ID_of_sponsor";
            this.IDspons.FormattingEnabled = true;
            this.IDspons.Location = new System.Drawing.Point(677, 49);
            this.IDspons.Name = "IDspons";
            this.IDspons.Size = new System.Drawing.Size(96, 21);
            this.IDspons.TabIndex = 5;
            this.IDspons.SelectedIndexChanged += new System.EventHandler(this.IDspons_SelectedIndexChanged);
            // 
            // IDproj
            // 
            this.IDproj.DataSource = this.projectBindingSource;
            this.IDproj.DisplayMember = "Serial_number";
            this.IDproj.FormattingEnabled = true;
            this.IDproj.Location = new System.Drawing.Point(677, 76);
            this.IDproj.Name = "IDproj";
            this.IDproj.Size = new System.Drawing.Size(96, 21);
            this.IDproj.TabIndex = 6;
            this.IDproj.SelectedIndexChanged += new System.EventHandler(this.IDproj_SelectedIndexChanged);
            // 
            // sponsorTableAdapter
            // 
            this.sponsorTableAdapter.ClearBeforeFill = true;
            // 
            // funding_detailsTableAdapter1
            // 
            this.funding_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // AddFounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 630);
            this.Controls.Add(this.IDproj);
            this.Controls.Add(this.IDspons);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddFounds";
            this.Text = "Новая запись в спонсировании";
            this.Load += new System.EventHandler(this.AddFounds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox IDspons;
        private System.Windows.Forms.ComboBox IDproj;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource sponsorBindingSource;
        private Scientific_conferenceDataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
        private Scientific_conferenceDataSetTableAdapters.Funding_detailsTableAdapter funding_detailsTableAdapter1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
    }
}