
namespace CC01.WindForms
{
    partial class FormEcole
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNomEcole = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblContactEcole = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lblNomEcole
            // 
            this.lblNomEcole.AutoSize = true;
            this.lblNomEcole.BackColor = System.Drawing.Color.Transparent;
            this.lblNomEcole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEcole.Location = new System.Drawing.Point(12, 30);
            this.lblNomEcole.Name = "lblNomEcole";
            this.lblNomEcole.Size = new System.Drawing.Size(84, 16);
            this.lblNomEcole.TabIndex = 2;
            this.lblNomEcole.Text = "Nom Ecole";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 26);
            this.textBox2.TabIndex = 5;
            // 
            // lblContactEcole
            // 
            this.lblContactEcole.AutoSize = true;
            this.lblContactEcole.BackColor = System.Drawing.Color.Transparent;
            this.lblContactEcole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactEcole.Location = new System.Drawing.Point(12, 116);
            this.lblContactEcole.Name = "lblContactEcole";
            this.lblContactEcole.Size = new System.Drawing.Size(65, 16);
            this.lblContactEcole.TabIndex = 4;
            this.lblContactEcole.Text = "Contact";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 231);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 26);
            this.textBox3.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(12, 277);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(43, 16);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "Logo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 109);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Sexe});
            this.dataGridView1.Location = new System.Drawing.Point(206, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 290);
            this.dataGridView1.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(206, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(351, 26);
            this.textBox8.TabIndex = 20;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(217, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 16);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search";
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "NomEcole";
            this.Matricule.Name = "Matricule";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Contact";
            this.Nom.Name = "Nom";
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Email";
            this.Sexe.Name = "Sexe";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnImprimer.Location = new System.Drawing.Point(573, 249);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(138, 55);
            this.btnImprimer.TabIndex = 26;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprimer.Location = new System.Drawing.Point(573, 344);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(138, 55);
            this.btnSupprimer.TabIndex = 25;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModifier.Location = new System.Drawing.Point(573, 163);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(138, 55);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreer.Location = new System.Drawing.Point(573, 70);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(138, 55);
            this.btnCreer.TabIndex = 23;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // FormEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(723, 442);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblContactEcole);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomEcole);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormEcole";
            this.Text = "FormEcole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomEcole;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblContactEcole;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreer;
    }
}