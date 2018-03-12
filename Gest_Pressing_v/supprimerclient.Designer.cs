namespace GestionPressing
{
    partial class supprimerclient
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
            this.txtmle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btsupprimerclient = new System.Windows.Forms.Button();
            this.btannullersuppr = new System.Windows.Forms.Button();
            this.txtquartier = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmodifierclient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmle
            // 
            this.txtmle.Enabled = false;
            this.txtmle.Location = new System.Drawing.Point(192, 50);
            this.txtmle.Name = "txtmle";
            this.txtmle.Size = new System.Drawing.Size(133, 20);
            this.txtmle.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Matricule :";
            // 
            // btsupprimerclient
            // 
            this.btsupprimerclient.Location = new System.Drawing.Point(231, 295);
            this.btsupprimerclient.Name = "btsupprimerclient";
            this.btsupprimerclient.Size = new System.Drawing.Size(94, 29);
            this.btsupprimerclient.TabIndex = 34;
            this.btsupprimerclient.Text = "Supprimer";
            this.btsupprimerclient.UseVisualStyleBackColor = true;
            // 
            // btannullersuppr
            // 
            this.btannullersuppr.Location = new System.Drawing.Point(118, 295);
            this.btannullersuppr.Name = "btannullersuppr";
            this.btannullersuppr.Size = new System.Drawing.Size(87, 30);
            this.btannullersuppr.TabIndex = 33;
            this.btannullersuppr.Text = "Annuller";
            this.btannullersuppr.UseVisualStyleBackColor = true;
            this.btannullersuppr.Click += new System.EventHandler(this.btannullersuppr_Click);
            // 
            // txtquartier
            // 
            this.txtquartier.Enabled = false;
            this.txtquartier.Location = new System.Drawing.Point(191, 246);
            this.txtquartier.Name = "txtquartier";
            this.txtquartier.Size = new System.Drawing.Size(134, 20);
            this.txtquartier.TabIndex = 32;
            // 
            // txttel
            // 
            this.txttel.Enabled = false;
            this.txttel.Location = new System.Drawing.Point(191, 197);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(134, 20);
            this.txttel.TabIndex = 31;
            // 
            // txtprenom
            // 
            this.txtprenom.Enabled = false;
            this.txtprenom.Location = new System.Drawing.Point(191, 142);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(134, 20);
            this.txtprenom.TabIndex = 30;
            // 
            // txtnom
            // 
            this.txtnom.Enabled = false;
            this.txtnom.Location = new System.Drawing.Point(191, 88);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(134, 20);
            this.txtnom.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quartier :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telephone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nom :";
            // 
            // lblmodifierclient
            // 
            this.lblmodifierclient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmodifierclient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblmodifierclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodifierclient.Location = new System.Drawing.Point(0, 0);
            this.lblmodifierclient.Name = "lblmodifierclient";
            this.lblmodifierclient.Size = new System.Drawing.Size(437, 29);
            this.lblmodifierclient.TabIndex = 24;
            this.lblmodifierclient.Text = "Supprimer un client";
            this.lblmodifierclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supprimerclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 348);
            this.Controls.Add(this.txtmle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btsupprimerclient);
            this.Controls.Add(this.btannullersuppr);
            this.Controls.Add(this.txtquartier);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmodifierclient);
            this.Name = "supprimerclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btsupprimerclient;
        private System.Windows.Forms.Button btannullersuppr;
        private System.Windows.Forms.TextBox txtquartier;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmodifierclient;
    }
}