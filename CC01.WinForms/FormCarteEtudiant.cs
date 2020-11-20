using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WindForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "DO you want to delete?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        etudiantBLO.DeleteCarteEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant);
                    }
                    loadData();
                }
            }
        }
    }



        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                string filename = null;
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {

                    string ext = Path.GetExtension(pictureBox1.ImageLocation);
                    filename = Guid.NewGuid().ToString() + ext;
                    FileInfo fileSource = new FileInfo(pictureBox1.ImageLocation);
                    string filePath = Path.Combine(ConfigurationManager.AppSettings["DbFolder"], "logo", filename);
                    FileInfo fileDest = new FileInfo(filePath);
                    if (!fileDest.Directory.Exists)
                        fileDest.Directory.Create();
                    fileSource.CopyTo(fileDest.FullName);
                }

                Etudiant newEtudiant = new Etudiant
                (
                    txtMatricule.Text.ToUpper(),
                    txtNom.Text,
                    txtPrenom.Text,
                    txtClasse.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtudiant?.Picture,
                    filename
                );
                EtudiantBLO productBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEtudiant == null)
                    productBLO.CreateCarteEtudiant(newEtudiant);
                else
                    etudiantBLO.EditEtudiant(oldEtudiant, newEtudiant);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEtudiant != null)
                    Close();

                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtClasse.Clear();
                txtNom.Focus();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }

        }

    }
}
}