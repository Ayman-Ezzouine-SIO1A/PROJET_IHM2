using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_IHM2
{
    public partial class C_CADRE : Form
    {
        private C_BASE labase;
        public C_CADRE()
        {
            InitializeComponent();
            labase = new C_BASE();
            labase.Charge_toi();
            listBox_monstre.DataSource = labase.les_monstres;
            listBox_monstre.DisplayMember = "Type";
        }

        private void listBox_monstre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_MONSTRE Monstre_Select = listBox_monstre.SelectedItem as C_MONSTRE;
            textBox_ID.Text = Monstre_Select.ID.ToString();
            textBox_Couleur.Text = Monstre_Select.Couleur.ToString();
            textBox_ID_Groupe.Text = Monstre_Select.ID_Groupe.ToString();
            textBox_Nom.Text = Monstre_Select.nom;
            textBox_Type.Text = Monstre_Select.Type;
            textBox_X.Text = Monstre_Select.Position.X.ToString();
            textBox_Y.Text = Monstre_Select.Position.Y.ToString();


        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if (button_save.Enabled == true)
            {
                DialogResult sauvegarder_controle = MessageBox.Show("Voulez-vous quitter sans sauvegarder ?", "Quitter", MessageBoxButtons.YesNo);
                if (sauvegarder_controle == DialogResult.Yes)
                {

                    Close();
                }
            }
            else
            {
                Close();
            }
            
          
        }

        private void button2_Click(object sender, EventArgs e)//Ajouter
        {
            
            C_MONSTRE Nouveau_Monstre= new C_MONSTRE();
           
            Nouveau_Monstre.nom = textBox_Nom2.Text;
            Nouveau_Monstre.Type = textBox_Type2.Text;
            if (textBox_ID.Text.All(char.IsDigit) == true)
            {
                Nouveau_Monstre.ID = Convert.ToInt32(labase.les_monstres.Count + 1);
            }
            Nouveau_Monstre.ID_Groupe = Convert.ToInt32(textBox_ID_Groupe2.Text);
            Nouveau_Monstre.Couleur = Convert.ToInt32(textBox_Couleur2.Text);
            Nouveau_Monstre.Position.X = Convert.ToInt32(textBox_X2.Text);
            Nouveau_Monstre.Position.Y = Convert.ToInt32(textBox_Y2.Text);
            labase.les_monstres.Add(Nouveau_Monstre);
            button_save.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)//sauvegarder
        {
           
            labase.Sauvegarde_toi();
            button_save.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)//Supprimer
        {
            C_MONSTRE Monstre_Select = listBox_monstre.SelectedItem as C_MONSTRE;
            labase.les_monstres.Remove(Monstre_Select);
        }

        private void button3_Click(object sender, EventArgs e)//Modifier
        {
            C_MONSTRE Monstre_Select = listBox_monstre.SelectedItem as C_MONSTRE;
           
            Monstre_Select.Type = textBox_Type.Text;
            
            Monstre_Select.ID_Groupe = Convert.ToInt32(textBox_ID_Groupe.Text);
            Monstre_Select.Couleur = Convert.ToInt32(textBox_Couleur.Text);
            Monstre_Select.Position.X= Convert.ToInt32(textBox_X.Text);
            Monstre_Select.Position.Y = Convert.ToInt32(textBox_Y.Text);
            button_save.Enabled = true;
            Acces_Ecriture.Checked = false;
        }

        private void Acces_Ecriture_CheckedChanged(object sender, EventArgs e)
        {
            if (Acces_Ecriture.Checked == true)
            {
                textBox_Couleur.Enabled = true;
                textBox_ID.Enabled = true;
                textBox_ID_Groupe.Enabled = true;
                textBox_Nom.Enabled = true;
                textBox_Type.Enabled = true;
                textBox_X.Enabled = true;
                textBox_Y.Enabled = true;
            }
            else
            {
                textBox_Couleur.Enabled = false;
                textBox_ID.Enabled = false;
                textBox_ID_Groupe.Enabled = false;
                textBox_Nom.Enabled = false;
                textBox_Type.Enabled = false;
                textBox_X.Enabled = false;
                textBox_Y.Enabled = false;
            }
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
