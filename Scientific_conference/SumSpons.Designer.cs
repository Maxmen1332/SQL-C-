namespace Scientific_conference
{
    partial class SumSpons
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
            this.scientific_conferenceDataSet1 = new Scientific_conference.Scientific_conferenceDataSet();
            this.scientific_conferenceDataSet11 = new Scientific_conference.Scientific_conferenceDataSet1();
            this.summoneyviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sum_money_viewTableAdapter = new Scientific_conference.Scientific_conferenceDataSet1TableAdapters.Sum_money_viewTableAdapter();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofsponsorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summoneyviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.summDataGridViewTextBoxColumn,
            this.nameofsponsorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.summoneyviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // scientific_conferenceDataSet1
            // 
            this.scientific_conferenceDataSet1.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scientific_conferenceDataSet11
            // 
            this.scientific_conferenceDataSet11.DataSetName = "Scientific_conferenceDataSet1";
            this.scientific_conferenceDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summoneyviewBindingSource
            // 
            this.summoneyviewBindingSource.DataMember = "Sum_money_view";
            this.summoneyviewBindingSource.DataSource = this.scientific_conferenceDataSet11;
            // 
            // sum_money_viewTableAdapter
            // 
            this.sum_money_viewTableAdapter.ClearBeforeFill = true;
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "Summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Summ";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            this.summDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameofsponsorDataGridViewTextBoxColumn
            // 
            this.nameofsponsorDataGridViewTextBoxColumn.DataPropertyName = "Name_of_sponsor";
            this.nameofsponsorDataGridViewTextBoxColumn.HeaderText = "Name_of_sponsor";
            this.nameofsponsorDataGridViewTextBoxColumn.Name = "nameofsponsorDataGridViewTextBoxColumn";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(11, 11);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 43);
            this.back.TabIndex = 4;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SumSpons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SumSpons";
            this.Text = "SumSpons";
            this.Load += new System.EventHandler(this.SumSpons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summoneyviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Scientific_conferenceDataSet scientific_conferenceDataSet1;
        private Scientific_conferenceDataSet1 scientific_conferenceDataSet11;
        private System.Windows.Forms.BindingSource summoneyviewBindingSource;
        private Scientific_conferenceDataSet1TableAdapters.Sum_money_viewTableAdapter sum_money_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofsponsorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
    }
}