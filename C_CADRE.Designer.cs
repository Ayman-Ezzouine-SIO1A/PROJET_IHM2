namespace PROJET_IHM2
{
    partial class C_CADRE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox_monstre = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.Button_Modif = new System.Windows.Forms.Button();
            this.button_suppr = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Couleur = new System.Windows.Forms.TextBox();
            this.textBox_ID_Groupe = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.Acces_Ecriture = new System.Windows.Forms.CheckBox();
            this.textBox_ID_Groupe2 = new System.Windows.Forms.TextBox();
            this.textBox_Couleur2 = new System.Windows.Forms.TextBox();
            this.textBox_Nom2 = new System.Windows.Forms.TextBox();
            this.textBox_Type2 = new System.Windows.Forms.TextBox();
            this.textBox_ID2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Création = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_X2 = new System.Windows.Forms.TextBox();
            this.textBox_Y2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Création.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_monstre
            // 
            this.listBox_monstre.FormattingEnabled = true;
            this.listBox_monstre.ItemHeight = 16;
            this.listBox_monstre.Location = new System.Drawing.Point(12, 87);
            this.listBox_monstre.Name = "listBox_monstre";
            this.listBox_monstre.Size = new System.Drawing.Size(234, 324);
            this.listBox_monstre.TabIndex = 1;
            this.listBox_monstre.SelectedIndexChanged += new System.EventHandler(this.listBox_monstre_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(6, 329);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(106, 32);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_Modif
            // 
            this.Button_Modif.ForeColor = System.Drawing.Color.Black;
            this.Button_Modif.Location = new System.Drawing.Point(355, 217);
            this.Button_Modif.Name = "Button_Modif";
            this.Button_Modif.Size = new System.Drawing.Size(106, 32);
            this.Button_Modif.TabIndex = 4;
            this.Button_Modif.Text = "Modifier";
            this.Button_Modif.UseVisualStyleBackColor = true;
            this.Button_Modif.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_suppr
            // 
            this.button_suppr.ForeColor = System.Drawing.Color.Black;
            this.button_suppr.Location = new System.Drawing.Point(355, 271);
            this.button_suppr.Name = "button_suppr";
            this.button_suppr.Size = new System.Drawing.Size(106, 32);
            this.button_suppr.TabIndex = 5;
            this.button_suppr.Text = "Supprimer";
            this.button_suppr.UseVisualStyleBackColor = true;
            this.button_suppr.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.Location = new System.Drawing.Point(355, 334);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(106, 32);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Sauvegarder";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(541, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(541, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(544, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(529, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Couleur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(509, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID_Groupe";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(592, 175);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(112, 22);
            this.textBox_ID.TabIndex = 19;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Enabled = false;
            this.textBox_Type.Location = new System.Drawing.Point(592, 222);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(112, 22);
            this.textBox_Type.TabIndex = 20;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Enabled = false;
            this.textBox_Nom.Location = new System.Drawing.Point(592, 271);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(112, 22);
            this.textBox_Nom.TabIndex = 21;
            // 
            // textBox_Couleur
            // 
            this.textBox_Couleur.Enabled = false;
            this.textBox_Couleur.Location = new System.Drawing.Point(592, 309);
            this.textBox_Couleur.Name = "textBox_Couleur";
            this.textBox_Couleur.Size = new System.Drawing.Size(112, 22);
            this.textBox_Couleur.TabIndex = 22;
            // 
            // textBox_ID_Groupe
            // 
            this.textBox_ID_Groupe.Enabled = false;
            this.textBox_ID_Groupe.Location = new System.Drawing.Point(592, 344);
            this.textBox_ID_Groupe.Name = "textBox_ID_Groupe";
            this.textBox_ID_Groupe.Size = new System.Drawing.Size(112, 22);
            this.textBox_ID_Groupe.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1399, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.ouvrirToolStripMenuItem.Text = "Modifier";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_X);
            this.groupBox1.Controls.Add(this.Acces_Ecriture);
            this.groupBox1.Location = new System.Drawing.Point(316, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 382);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecture";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(225, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(225, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "X";
            // 
            // textBox_X
            // 
            this.textBox_X.Enabled = false;
            this.textBox_X.Location = new System.Drawing.Point(276, 294);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(112, 22);
            this.textBox_X.TabIndex = 38;
            // 
            // Acces_Ecriture
            // 
            this.Acces_Ecriture.AutoSize = true;
            this.Acces_Ecriture.Location = new System.Drawing.Point(57, 296);
            this.Acces_Ecriture.Name = "Acces_Ecriture";
            this.Acces_Ecriture.Size = new System.Drawing.Size(121, 21);
            this.Acces_Ecriture.TabIndex = 27;
            this.Acces_Ecriture.Text = "Accès Ecriture";
            this.Acces_Ecriture.UseVisualStyleBackColor = true;
            this.Acces_Ecriture.CheckedChanged += new System.EventHandler(this.Acces_Ecriture_CheckedChanged);
            // 
            // textBox_ID_Groupe2
            // 
            this.textBox_ID_Groupe2.Location = new System.Drawing.Point(1036, 311);
            this.textBox_ID_Groupe2.Name = "textBox_ID_Groupe2";
            this.textBox_ID_Groupe2.Size = new System.Drawing.Size(112, 22);
            this.textBox_ID_Groupe2.TabIndex = 36;
            // 
            // textBox_Couleur2
            // 
            this.textBox_Couleur2.Location = new System.Drawing.Point(1036, 276);
            this.textBox_Couleur2.Name = "textBox_Couleur2";
            this.textBox_Couleur2.Size = new System.Drawing.Size(112, 22);
            this.textBox_Couleur2.TabIndex = 35;
            // 
            // textBox_Nom2
            // 
            this.textBox_Nom2.Location = new System.Drawing.Point(1036, 238);
            this.textBox_Nom2.Name = "textBox_Nom2";
            this.textBox_Nom2.Size = new System.Drawing.Size(112, 22);
            this.textBox_Nom2.TabIndex = 34;
            // 
            // textBox_Type2
            // 
            this.textBox_Type2.Location = new System.Drawing.Point(1036, 189);
            this.textBox_Type2.Name = "textBox_Type2";
            this.textBox_Type2.Size = new System.Drawing.Size(112, 22);
            this.textBox_Type2.TabIndex = 33;
            // 
            // textBox_ID2
            // 
            this.textBox_ID2.Enabled = false;
            this.textBox_ID2.Location = new System.Drawing.Point(1036, 142);
            this.textBox_ID2.Name = "textBox_ID2";
            this.textBox_ID2.Size = new System.Drawing.Size(112, 22);
            this.textBox_ID2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(953, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID_Groupe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(973, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Couleur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(988, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(985, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(985, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID";
            // 
            // Création
            // 
            this.Création.Controls.Add(this.label14);
            this.Création.Controls.Add(this.label13);
            this.Création.Controls.Add(this.textBox_Y2);
            this.Création.Controls.Add(this.textBox_X2);
            this.Création.Controls.Add(this.button_add);
            this.Création.Location = new System.Drawing.Point(880, 83);
            this.Création.Name = "Création";
            this.Création.Size = new System.Drawing.Size(341, 365);
            this.Création.TabIndex = 37;
            this.Création.TabStop = false;
            this.Création.Text = "Création";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Enabled = false;
            this.textBox_Y.Location = new System.Drawing.Point(592, 417);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(112, 22);
            this.textBox_Y.TabIndex = 40;
            // 
            // textBox_X2
            // 
            this.textBox_X2.Location = new System.Drawing.Point(156, 266);
            this.textBox_X2.Name = "textBox_X2";
            this.textBox_X2.Size = new System.Drawing.Size(112, 22);
            this.textBox_X2.TabIndex = 39;
            // 
            // textBox_Y2
            // 
            this.textBox_Y2.Location = new System.Drawing.Point(156, 306);
            this.textBox_Y2.Name = "textBox_Y2";
            this.textBox_Y2.Size = new System.Drawing.Size(112, 22);
            this.textBox_Y2.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(128, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(128, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Y";
            // 
            // C_CADRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 487);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_ID_Groupe2);
            this.Controls.Add(this.textBox_Couleur2);
            this.Controls.Add(this.textBox_Nom2);
            this.Controls.Add(this.textBox_Type2);
            this.Controls.Add(this.textBox_ID2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_ID_Groupe);
            this.Controls.Add(this.textBox_Couleur);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_suppr);
            this.Controls.Add(this.Button_Modif);
            this.Controls.Add(this.listBox_monstre);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Création);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "C_CADRE";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Création.ResumeLayout(false);
            this.Création.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_monstre;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button Button_Modif;
        private System.Windows.Forms.Button button_suppr;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Couleur;
        private System.Windows.Forms.TextBox textBox_ID_Groupe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Acces_Ecriture;
        private System.Windows.Forms.TextBox textBox_ID_Groupe2;
        private System.Windows.Forms.TextBox textBox_Couleur2;
        private System.Windows.Forms.TextBox textBox_Nom2;
        private System.Windows.Forms.TextBox textBox_Type2;
        private System.Windows.Forms.TextBox textBox_ID2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Création;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_X;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Y2;
        private System.Windows.Forms.TextBox textBox_X2;
    }
}

