namespace Scientific_conference
{
    partial class Rapporteur_data2
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
            this.rapporteur = new System.Windows.Forms.Button();
            this.scient_adviser = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.project_viewTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSet1TableAdapters.Project_viewTableAdapter();
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rapporteur
            // 
            this.rapporteur.Location = new System.Drawing.Point(91, 27);
            this.rapporteur.Margin = new System.Windows.Forms.Padding(2);
            this.rapporteur.Name = "rapporteur";
            this.rapporteur.Size = new System.Drawing.Size(131, 43);
            this.rapporteur.TabIndex = 1;
            this.rapporteur.Text = "Докладчик";
            this.rapporteur.UseVisualStyleBackColor = true;
            this.rapporteur.Click += new System.EventHandler(this.rapporteur_Click);
            // 
            // scient_adviser
            // 
            this.scient_adviser.Location = new System.Drawing.Point(91, 83);
            this.scient_adviser.Margin = new System.Windows.Forms.Padding(2);
            this.scient_adviser.Name = "scient_adviser";
            this.scient_adviser.Size = new System.Drawing.Size(131, 43);
            this.scient_adviser.TabIndex = 2;
            this.scient_adviser.Text = "Научный руководитель";
            this.scient_adviser.UseVisualStyleBackColor = true;
            this.scient_adviser.Click += new System.EventHandler(this.scient_adviser_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(91, 233);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(131, 43);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // project_viewTableAdapter1
            // 
            this.project_viewTableAdapter1.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(91, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cуммарные затраты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(91, 186);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 43);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_2);
            // 
            // Rapporteur_data2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 350);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.scient_adviser);
            this.Controls.Add(this.rapporteur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rapporteur_data2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные докладчика";
            this.Load += new System.EventHandler(this.Rapporteur_data2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rapporteur;
        private System.Windows.Forms.Button scient_adviser;
        private System.Windows.Forms.Button exit;
        private Scientific_conferenceDataSet1TableAdapters.Project_viewTableAdapter project_viewTableAdapter1;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
    }
}