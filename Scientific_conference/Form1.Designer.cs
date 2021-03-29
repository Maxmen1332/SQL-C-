namespace Scientific_conference
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scientific_conferenceDataSet = new Scientific_conference.Scientific_conferenceDataSet();
            this.User = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckPassword = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.scientific_conferenceDataSet;
            this.bindingSource1.Position = 0;
            // 
            // scientific_conferenceDataSet
            // 
            this.scientific_conferenceDataSet.DataSetName = "Scientific_conferenceDataSet";
            this.scientific_conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // User
            // 
            this.User.FormattingEnabled = true;
            this.User.Items.AddRange(new object[] {
            "Организатор",
            "Докладчик"});
            this.User.Location = new System.Drawing.Point(139, 30);
            this.User.Margin = new System.Windows.Forms.Padding(2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(179, 21);
            this.User.TabIndex = 0;
            this.User.Text = "Организатор";
            this.User.SelectedIndexChanged += new System.EventHandler(this.User_SelectedIndexChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(138, 73);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(179, 20);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип пользователя";
            // 
            // CheckPassword
            // 
            this.CheckPassword.Location = new System.Drawing.Point(225, 106);
            this.CheckPassword.Margin = new System.Windows.Forms.Padding(2);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(92, 32);
            this.CheckPassword.TabIndex = 4;
            this.CheckPassword.Text = "ОК";
            this.CheckPassword.UseVisualStyleBackColor = true;
            this.CheckPassword.Click += new System.EventHandler(this.CheckPassword_Click);
            // 
            // Leave
            // 
            this.Leave.Location = new System.Drawing.Point(109, 106);
            this.Leave.Margin = new System.Windows.Forms.Padding(2);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(81, 32);
            this.Leave.TabIndex = 5;
            this.Leave.Text = "Выйти";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 155);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.CheckPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scientific_conferenceDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Scientific_conferenceDataSet scientific_conferenceDataSet;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckPassword;
        private System.Windows.Forms.Button Leave;
    }
}

