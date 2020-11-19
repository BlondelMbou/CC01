
namespace CC01.WindForms
{
    partial class FormParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParent));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblinfosEcole = new System.Windows.Forms.Label();
            this.LblInfosDeLetudiant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblinfosEcole
            // 
            this.lblinfosEcole.AutoSize = true;
            this.lblinfosEcole.BackColor = System.Drawing.Color.Transparent;
            this.lblinfosEcole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfosEcole.Location = new System.Drawing.Point(41, 206);
            this.lblinfosEcole.Name = "lblinfosEcole";
            this.lblinfosEcole.Size = new System.Drawing.Size(123, 16);
            this.lblinfosEcole.TabIndex = 10;
            this.lblinfosEcole.Text = "Infos De L\'ecole";
            // 
            // LblInfosDeLetudiant
            // 
            this.LblInfosDeLetudiant.AutoSize = true;
            this.LblInfosDeLetudiant.BackColor = System.Drawing.Color.Transparent;
            this.LblInfosDeLetudiant.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfosDeLetudiant.Location = new System.Drawing.Point(41, 140);
            this.LblInfosDeLetudiant.Name = "LblInfosDeLetudiant";
            this.LblInfosDeLetudiant.Size = new System.Drawing.Size(145, 16);
            this.LblInfosDeLetudiant.TabIndex = 8;
            this.LblInfosDeLetudiant.Text = "Infos De L\'etudiant";
            this.LblInfosDeLetudiant.Click += new System.EventHandler(this.LblInfosDeLetudiant_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(502, 440);
            this.Controls.Add(this.lblinfosEcole);
            this.Controls.Add(this.LblInfosDeLetudiant);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormParent";
            this.Text = " email_Ecole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblinfosEcole;
        private System.Windows.Forms.Label LblInfosDeLetudiant;
    }
}