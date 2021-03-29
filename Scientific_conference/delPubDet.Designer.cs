namespace Scientific_conference
{
    partial class delPubDet
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
            this.IDmasm = new System.Windows.Forms.ComboBox();
            this.massmediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.IDProj = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.projectTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            this.mass_mediaTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Mass_mediaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.publication_detailsTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Publication_detailsTableAdapter();
            this.fundingdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funding_detailsTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Funding_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.massmediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundingdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IDmasm
            // 
            this.IDmasm.DataSource = this.massmediaBindingSource;
            this.IDmasm.DisplayMember = "ID_of_mass_media";
            this.IDmasm.FormattingEnabled = true;
            this.IDmasm.Location = new System.Drawing.Point(509, 12);
            this.IDmasm.Name = "IDmasm";
            this.IDmasm.Size = new System.Drawing.Size(34, 21);
            this.IDmasm.TabIndex = 0;
            this.IDmasm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // massmediaBindingSource
            // 
            this.massmediaBindingSource.DataMember = "Mass_media";
            this.massmediaBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IDProj
            // 
            this.IDProj.DataSource = this.projectBindingSource;
            this.IDProj.DisplayMember = "Serial_number";
            this.IDProj.FormattingEnabled = true;
            this.IDProj.Location = new System.Drawing.Point(509, 39);
            this.IDProj.Name = "IDProj";
            this.IDProj.Size = new System.Drawing.Size(34, 21);
            this.IDProj.TabIndex = 1;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.projectBindingSource;
            this.comboBox3.DisplayMember = "Topic_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(96, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(391, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.massmediaBindingSource;
            this.comboBox4.DisplayMember = "Designation";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(96, 123);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(391, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // mass_mediaTableAdapter
            // 
            this.mass_mediaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // publication_detailsTableAdapter1
            // 
            this.publication_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // fundingdetailsBindingSource
            // 
            this.fundingdetailsBindingSource.DataMember = "Funding_details";
            this.fundingdetailsBindingSource.DataSource = this.scientific_conferenceDataSet;
            // 
            // funding_detailsTableAdapter
            // 
            this.funding_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // delPubDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 155);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.IDProj);
            this.Controls.Add(this.IDmasm);
            this.Name = "delPubDet";
            this.Text = "Удалить строчку";
            this.Load += new System.EventHandler(this.delPubDet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massmediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundingdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox IDmasm;
        private System.Windows.Forms.ComboBox IDProj;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.BindingSource massmediaBindingSource;
        private Scientific_conferenceDataSetTableAdapters.Mass_mediaTableAdapter mass_mediaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Scientific_conferenceDataSetTableAdapters.Publication_detailsTableAdapter publication_detailsTableAdapter1;
        private System.Windows.Forms.BindingSource fundingdetailsBindingSource;
        private Scientific_conferenceDataSetTableAdapters.Funding_detailsTableAdapter funding_detailsTableAdapter;
    }
}