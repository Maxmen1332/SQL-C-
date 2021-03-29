namespace Scientific_conference
{
    partial class Conference_data
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
            this.organizer = new System.Windows.Forms.Button();
            this.conference = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // organizer
            // 
            this.organizer.Location = new System.Drawing.Point(91, 27);
            this.organizer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.organizer.Name = "organizer";
            this.organizer.Size = new System.Drawing.Size(131, 43);
            this.organizer.TabIndex = 0;
            this.organizer.Text = "Организатор";
            this.organizer.UseVisualStyleBackColor = true;
            this.organizer.Click += new System.EventHandler(this.organizer_Click);
            // 
            // conference
            // 
            this.conference.Location = new System.Drawing.Point(91, 83);
            this.conference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conference.Name = "conference";
            this.conference.Size = new System.Drawing.Size(131, 43);
            this.conference.TabIndex = 1;
            this.conference.Text = "Конференция";
            this.conference.UseVisualStyleBackColor = true;
            this.conference.Click += new System.EventHandler(this.conference_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(91, 139);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 43);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(91, 193);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(131, 43);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Conference_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 266);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.conference);
            this.Controls.Add(this.organizer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Conference_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные конференции";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button organizer;
        private System.Windows.Forms.Button conference;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
    }
}