namespace Proyecto_JC_Distribuidres_2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblMnesual = new System.Windows.Forms.Label();
            this.lblTotalD = new System.Windows.Forms.Label();
            this.lblTotalM = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO DE VENTAS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(25, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVentas.Location = new System.Drawing.Point(22, 69);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(171, 16);
            this.lblVentas.TabIndex = 3;
            this.lblVentas.Text = "Cantidad de Ventas al día";
            // 
            // lblMnesual
            // 
            this.lblMnesual.AutoSize = true;
            this.lblMnesual.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnesual.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMnesual.Location = new System.Drawing.Point(22, 118);
            this.lblMnesual.Name = "lblMnesual";
            this.lblMnesual.Size = new System.Drawing.Size(204, 16);
            this.lblMnesual.TabIndex = 4;
            this.lblMnesual.Text = "Cantidad de Ventas Mensuales";
            // 
            // lblTotalD
            // 
            this.lblTotalD.AutoSize = true;
            this.lblTotalD.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalD.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalD.Location = new System.Drawing.Point(22, 169);
            this.lblTotalD.Name = "lblTotalD";
            this.lblTotalD.Size = new System.Drawing.Size(154, 16);
            this.lblTotalD.TabIndex = 5;
            this.lblTotalD.Text = "Total de Ventas Diarias";
            // 
            // lblTotalM
            // 
            this.lblTotalM.AutoSize = true;
            this.lblTotalM.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalM.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalM.Location = new System.Drawing.Point(22, 215);
            this.lblTotalM.Name = "lblTotalM";
            this.lblTotalM.Size = new System.Drawing.Size(178, 16);
            this.lblTotalM.TabIndex = 6;
            this.lblTotalM.Text = "Total de Ventas Mensuales";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(179, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTotalM);
            this.Controls.Add(this.lblTotalD);
            this.Controls.Add(this.lblMnesual);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblMnesual;
        private System.Windows.Forms.Label lblTotalD;
        private System.Windows.Forms.Label lblTotalM;
        private System.Windows.Forms.Button button2;
    }
}