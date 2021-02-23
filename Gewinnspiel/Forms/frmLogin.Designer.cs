namespace Gewinnspiel.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtBenutzer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.btnEye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(251, 179);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(239, 26);
            this.txtPasswort.TabIndex = 7;
            this.txtPasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswort_KeyDown);
            // 
            // txtBenutzer
            // 
            this.txtBenutzer.Location = new System.Drawing.Point(251, 130);
            this.txtBenutzer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBenutzer.Name = "txtBenutzer";
            this.txtBenutzer.Size = new System.Drawing.Size(278, 26);
            this.txtBenutzer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinloggen.Location = new System.Drawing.Point(205, 332);
            this.btnEinloggen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(220, 52);
            this.btnEinloggen.TabIndex = 8;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = true;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click);
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrieren.Location = new System.Drawing.Point(205, 418);
            this.btnRegistrieren.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(220, 64);
            this.btnRegistrieren.TabIndex = 9;
            this.btnRegistrieren.Text = "Registrieren";
            this.btnRegistrieren.UseVisualStyleBackColor = true;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click);
            // 
            // btnEye
            // 
            this.btnEye.Location = new System.Drawing.Point(496, 179);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(33, 26);
            this.btnEye.TabIndex = 28;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 562);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.btnEinloggen);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtBenutzer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Login Gewinnspiel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.TextBox txtBenutzer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.Button btnEye;
    }
}

