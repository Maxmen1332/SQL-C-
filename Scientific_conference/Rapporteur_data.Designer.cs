namespace Scientific_conference
{
    partial class Rapporteur_data
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
            this.rapporteur = new System.Windows.Forms.Button();
            this.scient_adviser = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rapporteur
            // 
            this.rapporteur.Location = new System.Drawing.Point(91, 27);
            this.rapporteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rapporteur.Name = "rapporteur";
            this.rapporteur.Size = new System.Drawing.Size(131, 43);
            this.rapporteur.TabIndex = 0;
            this.rapporteur.Text = "Докладчик";
            this.rapporteur.UseVisualStyleBackColor = true;
            this.rapporteur.Click += new System.EventHandler(this.rapporteur_Click);
            // 
            // scient_adviser
            // 
            this.scient_adviser.Location = new System.Drawing.Point(91, 83);
            this.scient_adviser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scient_adviser.Name = "scient_adviser";
            this.scient_adviser.Size = new System.Drawing.Size(131, 43);
            this.scient_adviser.TabIndex = 1;
            this.scient_adviser.Text = "Научный руководитель";
            this.scient_adviser.UseVisualStyleBackColor = true;
            this.scient_adviser.Click += new System.EventHandler(this.scient_adviser_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(91, 201);
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
            this.exit.Location = new System.Drawing.Point(91, 263);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(131, 43);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Кто где выступает";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rapporteur_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.scient_adviser);
            this.Controls.Add(this.rapporteur);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rapporteur_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные докладчика";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rapporteur;
        private System.Windows.Forms.Button scient_adviser;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
    }
}