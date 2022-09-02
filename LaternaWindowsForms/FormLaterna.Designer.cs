
namespace LaternaWindowsForms
{
    partial class FormLaterna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaterna));
            this.textProgressBateria = new System.Windows.Forms.TextBox();
            this.BtnTrocarBateria = new System.Windows.Forms.Button();
            this.BtnLigarDesligar = new System.Windows.Forms.Button();
            this.timerLaterna = new System.Windows.Forms.Timer(this.components);
            this.ImgLaterna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLaterna)).BeginInit();
            this.SuspendLayout();
            // 
            // textProgressBateria
            // 
            this.textProgressBateria.Enabled = false;
            this.textProgressBateria.Location = new System.Drawing.Point(326, 187);
            this.textProgressBateria.Name = "textProgressBateria";
            this.textProgressBateria.Size = new System.Drawing.Size(170, 20);
            this.textProgressBateria.TabIndex = 6;
            this.textProgressBateria.Text = "Porcetagem da Bateria:";
            // 
            // BtnTrocarBateria
            // 
            this.BtnTrocarBateria.BackColor = System.Drawing.Color.Gray;
            this.BtnTrocarBateria.Location = new System.Drawing.Point(193, 187);
            this.BtnTrocarBateria.Name = "BtnTrocarBateria";
            this.BtnTrocarBateria.Size = new System.Drawing.Size(127, 23);
            this.BtnTrocarBateria.TabIndex = 5;
            this.BtnTrocarBateria.Text = "Trocar Bateria";
            this.BtnTrocarBateria.UseVisualStyleBackColor = false;
            this.BtnTrocarBateria.Click += new System.EventHandler(this.BtnTrocarBateria_Click);
            // 
            // BtnLigarDesligar
            // 
            this.BtnLigarDesligar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnLigarDesligar.Location = new System.Drawing.Point(12, 187);
            this.BtnLigarDesligar.Name = "BtnLigarDesligar";
            this.BtnLigarDesligar.Size = new System.Drawing.Size(175, 23);
            this.BtnLigarDesligar.TabIndex = 4;
            this.BtnLigarDesligar.Text = "Ligar";
            this.BtnLigarDesligar.UseVisualStyleBackColor = false;
            this.BtnLigarDesligar.Click += new System.EventHandler(this.BtnLigarDesligar_Click);
            // 
            // timerLaterna
            // 
            this.timerLaterna.Enabled = true;
            this.timerLaterna.Interval = 1000;
            this.timerLaterna.Tick += new System.EventHandler(this.timerLaterna_Tick);
            // 
            // ImgLaterna
            // 
            this.ImgLaterna.Image = global::LaternaWindowsForms.Properties.Resources.lampadapagada;
            this.ImgLaterna.Location = new System.Drawing.Point(0, -1);
            this.ImgLaterna.Name = "ImgLaterna";
            this.ImgLaterna.Size = new System.Drawing.Size(663, 182);
            this.ImgLaterna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLaterna.TabIndex = 1;
            this.ImgLaterna.TabStop = false;
            // 
            // FormLaterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(659, 211);
            this.Controls.Add(this.textProgressBateria);
            this.Controls.Add(this.BtnTrocarBateria);
            this.Controls.Add(this.BtnLigarDesligar);
            this.Controls.Add(this.ImgLaterna);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLaterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laterna";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLaterna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgLaterna;
        private System.Windows.Forms.TextBox textProgressBateria;
        private System.Windows.Forms.Button BtnTrocarBateria;
        private System.Windows.Forms.Button BtnLigarDesligar;
        private System.Windows.Forms.Timer timerLaterna;
    }
}

