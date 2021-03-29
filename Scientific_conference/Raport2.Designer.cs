namespace Scientific_conference
{
    partial class Raport2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conferenceTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ConferenceTableAdapter();
            this.organizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizerTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.OrganizerTableAdapter();
            this.massmediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mass_mediaTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Mass_mediaTableAdapter();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            this.rapporteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapporteurTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter();
            this.scientificadviserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_adviserTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Scientific_adviserTableAdapter();
            this.sponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.SponsorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massmediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientificadviserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(517, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataMember = "Conference";
            this.conferenceBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // conferenceTableAdapter
            // 
            this.conferenceTableAdapter.ClearBeforeFill = true;
            // 
            // organizerBindingSource
            // 
            this.organizerBindingSource.DataMember = "Organizer";
            this.organizerBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // organizerTableAdapter
            // 
            this.organizerTableAdapter.ClearBeforeFill = true;
            // 
            // massmediaBindingSource
            // 
            this.massmediaBindingSource.DataMember = "Mass_media";
            this.massmediaBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // mass_mediaTableAdapter
            // 
            this.mass_mediaTableAdapter.ClearBeforeFill = true;
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
            // rapporteurBindingSource
            // 
            this.rapporteurBindingSource.DataMember = "Rapporteur";
            this.rapporteurBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // rapporteurTableAdapter
            // 
            this.rapporteurTableAdapter.ClearBeforeFill = true;
            // 
            // scientificadviserBindingSource
            // 
            this.scientificadviserBindingSource.DataMember = "Scientific_adviser";
            this.scientificadviserBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // scientific_adviserTableAdapter
            // 
            this.scientific_adviserTableAdapter.ClearBeforeFill = true;
            // 
            // sponsorBindingSource
            // 
            this.sponsorBindingSource.DataMember = "Sponsor";
            this.sponsorBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // sponsorTableAdapter
            // 
            this.sponsorTableAdapter.ClearBeforeFill = true;
            // 
            // Raport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Raport2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Raport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massmediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapporteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientificadviserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ConferenceTableAdapter conferenceTableAdapter;
        private System.Windows.Forms.BindingSource organizerBindingSource;
        private Scientific_conferenceDataSetTableAdapters.OrganizerTableAdapter organizerTableAdapter;
        private System.Windows.Forms.BindingSource massmediaBindingSource;
        private Scientific_conferenceDataSetTableAdapters.Mass_mediaTableAdapter mass_mediaTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.BindingSource rapporteurBindingSource;
        private Scientific_conferenceDataSetTableAdapters.RapporteurTableAdapter rapporteurTableAdapter;
        private System.Windows.Forms.BindingSource scientificadviserBindingSource;
        private Scientific_conferenceDataSetTableAdapters.Scientific_adviserTableAdapter scientific_adviserTableAdapter;
        private System.Windows.Forms.BindingSource sponsorBindingSource;
        private Scientific_conferenceDataSetTableAdapters.SponsorTableAdapter sponsorTableAdapter;
    }
}