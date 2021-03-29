namespace Scientific_conference
{
    partial class Project_data
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
            this.project = new System.Windows.Forms.Button();
            this.sponsor = new System.Windows.Forms.Button();
            this.mass_media = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // project
            // 
            this.project.Location = new System.Drawing.Point(100, 16);
            this.project.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(115, 36);
            this.project.TabIndex = 0;
            this.project.Text = "Проект";
            this.project.UseVisualStyleBackColor = true;
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // sponsor
            // 
            this.sponsor.Location = new System.Drawing.Point(100, 63);
            this.sponsor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sponsor.Name = "sponsor";
            this.sponsor.Size = new System.Drawing.Size(115, 36);
            this.sponsor.TabIndex = 1;
            this.sponsor.Text = "Спонсор";
            this.sponsor.UseVisualStyleBackColor = true;
            this.sponsor.Click += new System.EventHandler(this.sponsor_Click);
            // 
            // mass_media
            // 
            this.mass_media.Location = new System.Drawing.Point(100, 110);
            this.mass_media.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mass_media.Name = "mass_media";
            this.mass_media.Size = new System.Drawing.Size(115, 36);
            this.mass_media.TabIndex = 2;
            this.mass_media.Text = "СМИ";
            this.mass_media.UseVisualStyleBackColor = true;
            this.mass_media.Click += new System.EventHandler(this.mass_media_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(100, 259);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 36);
            this.back.TabIndex = 3;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 210);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Публикации в СМИ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Данные о финансировании";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Project_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 523);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.mass_media);
            this.Controls.Add(this.sponsor);
            this.Controls.Add(this.project);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Project_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные проекта";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button project;
        private System.Windows.Forms.Button sponsor;
        private System.Windows.Forms.Button mass_media;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}