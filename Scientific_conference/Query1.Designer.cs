namespace Scientific_conference
{
    partial class Query1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter();
            this.scientific_conferenceDataSet1 = new Scientific_conference.Scientific_conferenceDataSet1();
            this.projectviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_viewTableAdapter = new Scientific_conference.Scientific_conferenceDataSet1TableAdapters.Project_viewTableAdapter();
            this.summoneyviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sum_money_viewTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSet1TableAdapters.Sum_money_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summoneyviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1043, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 315);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // scientific_conferenceDataSet1
            // 
            this.scientific_conferenceDataSet1.DataSetName = "Scientific_conferenceDataSet1";
            this.scientific_conferenceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectviewBindingSource
            // 
            this.projectviewBindingSource.DataMember = "Project_view";
            this.projectviewBindingSource.DataSource = this.scientific_conferenceDataSet1;
            // 
            // project_viewTableAdapter
            // 
            this.project_viewTableAdapter.ClearBeforeFill = true;
            // 
            // summoneyviewBindingSource
            // 
            this.summoneyviewBindingSource.DataMember = "Sum_money_view";
            this.summoneyviewBindingSource.DataSource = this.scientific_conferenceDataSet1;
            this.summoneyviewBindingSource.CurrentChanged += new System.EventHandler(this.summoneyviewBindingSource_CurrentChanged);
            // 
            // sum_money_viewTableAdapter1
            // 
            this.sum_money_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // Query1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Query1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query1";
            this.Load += new System.EventHandler(this.Query1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summoneyviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Scientific_conferenceDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private Scientific_conferenceDataSet1 scientific_conferenceDataSet1;
        private System.Windows.Forms.BindingSource projectviewBindingSource;
        private Scientific_conferenceDataSet1TableAdapters.Project_viewTableAdapter project_viewTableAdapter;
 
        private System.Windows.Forms.BindingSource summoneyviewBindingSource;
        private Scientific_conferenceDataSet1TableAdapters.Sum_money_viewTableAdapter sum_money_viewTableAdapter1;
    }
}