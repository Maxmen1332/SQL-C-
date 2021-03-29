namespace Scientific_conference
{
    partial class Org
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
            this.conference_data = new System.Windows.Forms.Button();
            this.rapporteur_data = new System.Windows.Forms.Button();
            this.Project_data = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conference_data
            // 
            this.conference_data.Location = new System.Drawing.Point(140, 178);
            this.conference_data.Margin = new System.Windows.Forms.Padding(2);
            this.conference_data.Name = "conference_data";
            this.conference_data.Size = new System.Drawing.Size(138, 43);
            this.conference_data.TabIndex = 0;
            this.conference_data.Text = "Данные конференции";
            this.conference_data.UseVisualStyleBackColor = true;
            this.conference_data.Click += new System.EventHandler(this.conference_data_Click);
            // 
            // rapporteur_data
            // 
            this.rapporteur_data.Location = new System.Drawing.Point(140, 125);
            this.rapporteur_data.Margin = new System.Windows.Forms.Padding(2);
            this.rapporteur_data.Name = "rapporteur_data";
            this.rapporteur_data.Size = new System.Drawing.Size(138, 49);
            this.rapporteur_data.TabIndex = 1;
            this.rapporteur_data.Text = "Данные докладчика";
            this.rapporteur_data.UseVisualStyleBackColor = true;
            this.rapporteur_data.Click += new System.EventHandler(this.rapporteur_data_Click);
            // 
            // Project_data
            // 
            this.Project_data.Location = new System.Drawing.Point(140, 77);
            this.Project_data.Margin = new System.Windows.Forms.Padding(2);
            this.Project_data.Name = "Project_data";
            this.Project_data.Size = new System.Drawing.Size(138, 44);
            this.Project_data.TabIndex = 2;
            this.Project_data.Text = "Данные проекта";
            this.Project_data.UseVisualStyleBackColor = true;
            this.Project_data.Click += new System.EventHandler(this.Project_data_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(140, 236);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(138, 36);
            this.back.TabIndex = 3;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(140, 287);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 36);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Формы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отчёты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Project_data);
            this.Controls.Add(this.rapporteur_data);
            this.Controls.Add(this.conference_data);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Org";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню организатора  АИС Научная конференция";
            this.Load += new System.EventHandler(this.Org_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conference_data;
        private System.Windows.Forms.Button rapporteur_data;
        private System.Windows.Forms.Button Project_data;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}