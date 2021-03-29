namespace Scientific_conference
{
    partial class Form2
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
            this.OrganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.organizerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Scientific_sphere = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conferenceTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.ConferenceTableAdapter();
            this.organizerTableAdapter1 = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.OrganizerTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.organizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.organizerConferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfomance_detailsTableAdapter = new Scientific_conference.Scientific_conferenceDataSetTableAdapters.Performance_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerConferenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.OrganBindingSource;
            this.comboBox1.DisplayMember = "FIO_organizer";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "ID_of_organizer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OrganBindingSource
            // 
            this.OrganBindingSource.DataMember = "Organizer";
            this.OrganBindingSource.DataSource = this.scientific_conferenceDataSet;
            this.OrganBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ФИО Организатора";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Address
            // 
            this.Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Address", true));
            this.Address.Location = new System.Drawing.Point(201, 128);
            this.Address.Margin = new System.Windows.Forms.Padding(2);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(341, 20);
            this.Address.TabIndex = 24;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Conference";
            this.bindingSource1.DataSource = this.scientific_conferenceDataSet;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Scientific_sphere
            // 
            this.Scientific_sphere.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Scientific_sphere", true));
            this.Scientific_sphere.Location = new System.Drawing.Point(201, 101);
            this.Scientific_sphere.Margin = new System.Windows.Forms.Padding(2);
            this.Scientific_sphere.Name = "Scientific_sphere";
            this.Scientific_sphere.Size = new System.Drawing.Size(341, 20);
            this.Scientific_sphere.TabIndex = 23;
            // 
            // Day
            // 
            this.Day.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Day", true));
            this.Day.Location = new System.Drawing.Point(201, 75);
            this.Day.Margin = new System.Windows.Forms.Padding(2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(341, 20);
            this.Day.TabIndex = 22;
            this.Day.TextChanged += new System.EventHandler(this.Day_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Тел. организатора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Научная область";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дата";
            // 
            // conferenceTableAdapter1
            // 
            this.conferenceTableAdapter1.ClearBeforeFill = true;
            // 
            // organizerTableAdapter1
            // 
            this.organizerTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Phone_number", true));
            this.comboBox2.DataSource = this.OrganBindingSource;
            this.comboBox2.DisplayMember = "Phone_number";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(201, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(341, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.ValueMember = "ID_of_organizer";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "FIO_organizer", true));
            this.comboBox3.DataSource = this.OrganBindingSource;
            this.comboBox3.DisplayMember = "ID_of_organizer";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(608, 335);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 21);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.ValueMember = "ID_of_organizer";
            
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // organizerConferenceBindingSource
            // 
            this.organizerConferenceBindingSource.DataMember = "Organizer_Conference";
            this.organizerConferenceBindingSource.DataSource = this.OrganBindingSource;
            // 
            // perfomance_detailsTableAdapter
            // 
            this.perfomance_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 368);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Scientific_sphere);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Ввод данных о новой конференции";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerConferenceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Scientific_sphere;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource organizerBindingSource1;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private Scientific_conferenceDataSetTableAdapters.ConferenceTableAdapter conferenceTableAdapter1;
        private Scientific_conferenceDataSetTableAdapters.OrganizerTableAdapter organizerTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource organizerBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource OrganBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource organizerConferenceBindingSource;
        private Scientific_conferenceDataSetTableAdapters.Performance_detailsTableAdapter perfomance_detailsTableAdapter;
    }
}