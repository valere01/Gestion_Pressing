namespace GestionPressing
{
    partial class ajouterclient
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
            this.lblajouterclient = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblquartier = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtquartier = new System.Windows.Forms.TextBox();
            this.btannullerajout = new System.Windows.Forms.Button();
            this.btenregistrerclient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblajouterclient
            // 
            this.lblajouterclient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblajouterclient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblajouterclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajouterclient.Location = new System.Drawing.Point(0, 0);
            this.lblajouterclient.Name = "lblajouterclient";
            this.lblajouterclient.Size = new System.Drawing.Size(327, 38);
            this.lblajouterclient.TabIndex = 0;
            this.lblajouterclient.Text = "Ajouter un client";
            this.lblajouterclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(16, 35);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(35, 13);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nom :";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(16, 68);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(49, 13);
            this.lblprenom.TabIndex = 2;
            this.lblprenom.Text = "Prenom :";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(16, 111);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(64, 13);
            this.lbltel.TabIndex = 3;
            this.lbltel.Text = "Telephone :";
            // 
            // lblquartier
            // 
            this.lblquartier.AutoSize = true;
            this.lblquartier.Location = new System.Drawing.Point(16, 148);
            this.lblquartier.Name = "lblquartier";
            this.lblquartier.Size = new System.Drawing.Size(50, 13);
            this.lblquartier.TabIndex = 4;
            this.lblquartier.Text = "Quartier :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(96, 28);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(134, 20);
            this.txtnom.TabIndex = 5;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(96, 61);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(134, 20);
            this.txtprenom.TabIndex = 6;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(96, 104);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(134, 20);
            this.txttel.TabIndex = 7;
            // 
            // txtquartier
            // 
            this.txtquartier.Location = new System.Drawing.Point(96, 145);
            this.txtquartier.Name = "txtquartier";
            this.txtquartier.Size = new System.Drawing.Size(134, 20);
            this.txtquartier.TabIndex = 8;
            // 
            // btannullerajout
            // 
            this.btannullerajout.Location = new System.Drawing.Point(56, 262);
            this.btannullerajout.Name = "btannullerajout";
            this.btannullerajout.Size = new System.Drawing.Size(87, 30);
            this.btannullerajout.TabIndex = 9;
            this.btannullerajout.Text = "Annuller";
            this.btannullerajout.UseVisualStyleBackColor = true;
            this.btannullerajout.Click += new System.EventHandler(this.btannullerajout_Click);
            // 
            // btenregistrerclient
            // 
            this.btenregistrerclient.Location = new System.Drawing.Point(173, 263);
            this.btenregistrerclient.Name = "btenregistrerclient";
            this.btenregistrerclient.Size = new System.Drawing.Size(94, 29);
            this.btenregistrerclient.TabIndex = 10;
            this.btenregistrerclient.Text = "Enregistrer";
            this.btenregistrerclient.UseVisualStyleBackColor = true;
            this.btenregistrerclient.Click += new System.EventHandler(this.btenregistrerclient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Controls.Add(this.txtprenom);
            this.groupBox1.Controls.Add(this.lblprenom);
            this.groupBox1.Controls.Add(this.lbltel);
            this.groupBox1.Controls.Add(this.lblquartier);
            this.groupBox1.Controls.Add(this.txtquartier);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Location = new System.Drawing.Point(37, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // ajouterclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btenregistrerclient);
            this.Controls.Add(this.btannullerajout);
            this.Controls.Add(this.lblajouterclient);
            this.Name = "ajouterclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblajouterclient;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblquartier;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtquartier;
        private System.Windows.Forms.Button btannullerajout;
        private System.Windows.Forms.Button btenregistrerclient;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}