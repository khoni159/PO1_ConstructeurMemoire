namespace PO1_ConstructeurMemoire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox_joueurs = new ListBox();
            textBox_ajouterJoueurNom = new TextBox();
            button_ajouterJoueur = new Button();
            label_ajouterJoueurNom = new Label();
            comboBox_ajouterJoueurEquipe = new ComboBox();
            label_ajouterJoueurEquipe = new Label();
            listBox_equipes = new ListBox();
            groupBox_Equipe = new GroupBox();
            button_modifierEquipeNom = new Button();
            label_modifierEquipeNom = new Label();
            textBox_modifierEquipeNom = new TextBox();
            groupBox_joueur = new GroupBox();
            errorProvider_ajouterJoueur = new ErrorProvider(components);
            errorProvider_modifierEquipe = new ErrorProvider(components);
            groupBox_Equipe.SuspendLayout();
            groupBox_joueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_ajouterJoueur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_modifierEquipe).BeginInit();
            SuspendLayout();
            // 
            // listBox_joueurs
            // 
            listBox_joueurs.FormattingEnabled = true;
            listBox_joueurs.Location = new Point(16, 26);
            listBox_joueurs.Name = "listBox_joueurs";
            listBox_joueurs.Size = new Size(230, 104);
            listBox_joueurs.TabIndex = 1;
            // 
            // textBox_ajouterJoueurNom
            // 
            textBox_ajouterJoueurNom.Location = new Point(339, 26);
            textBox_ajouterJoueurNom.Name = "textBox_ajouterJoueurNom";
            textBox_ajouterJoueurNom.Size = new Size(151, 27);
            textBox_ajouterJoueurNom.TabIndex = 2;
            // 
            // button_ajouterJoueur
            // 
            button_ajouterJoueur.Location = new Point(339, 93);
            button_ajouterJoueur.Name = "button_ajouterJoueur";
            button_ajouterJoueur.Size = new Size(94, 29);
            button_ajouterJoueur.TabIndex = 3;
            button_ajouterJoueur.Text = "Ajouter";
            button_ajouterJoueur.UseVisualStyleBackColor = true;
            button_ajouterJoueur.Click += button_ajouterJoueur_Click;
            // 
            // label_ajouterJoueurNom
            // 
            label_ajouterJoueurNom.AutoSize = true;
            label_ajouterJoueurNom.Location = new Point(267, 29);
            label_ajouterJoueurNom.Name = "label_ajouterJoueurNom";
            label_ajouterJoueurNom.Size = new Size(49, 20);
            label_ajouterJoueurNom.TabIndex = 4;
            label_ajouterJoueurNom.Text = "Nom :";
            // 
            // comboBox_ajouterJoueurEquipe
            // 
            comboBox_ajouterJoueurEquipe.FormattingEnabled = true;
            comboBox_ajouterJoueurEquipe.Location = new Point(339, 59);
            comboBox_ajouterJoueurEquipe.Name = "comboBox_ajouterJoueurEquipe";
            comboBox_ajouterJoueurEquipe.Size = new Size(151, 28);
            comboBox_ajouterJoueurEquipe.TabIndex = 5;
            // 
            // label_ajouterJoueurEquipe
            // 
            label_ajouterJoueurEquipe.AutoSize = true;
            label_ajouterJoueurEquipe.Location = new Point(267, 62);
            label_ajouterJoueurEquipe.Name = "label_ajouterJoueurEquipe";
            label_ajouterJoueurEquipe.Size = new Size(66, 20);
            label_ajouterJoueurEquipe.TabIndex = 6;
            label_ajouterJoueurEquipe.Text = "Équipe : ";
            // 
            // listBox_equipe
            // 
            listBox_equipes.FormattingEnabled = true;
            listBox_equipes.Location = new Point(16, 26);
            listBox_equipes.Name = "listBox_equipe";
            listBox_equipes.Size = new Size(230, 104);
            listBox_equipes.TabIndex = 7;
            // 
            // groupBox_Equipe
            // 
            groupBox_Equipe.Controls.Add(button_modifierEquipeNom);
            groupBox_Equipe.Controls.Add(label_modifierEquipeNom);
            groupBox_Equipe.Controls.Add(listBox_equipes);
            groupBox_Equipe.Controls.Add(textBox_modifierEquipeNom);
            groupBox_Equipe.Location = new Point(25, 159);
            groupBox_Equipe.Name = "groupBox_Equipe";
            groupBox_Equipe.Size = new Size(595, 162);
            groupBox_Equipe.TabIndex = 8;
            groupBox_Equipe.TabStop = false;
            groupBox_Equipe.Text = "Équipes";
            // 
            // button_modifierEquipeNom
            // 
            button_modifierEquipeNom.Location = new Point(339, 59);
            button_modifierEquipeNom.Name = "button_modifierEquipeNom";
            button_modifierEquipeNom.Size = new Size(94, 29);
            button_modifierEquipeNom.TabIndex = 9;
            button_modifierEquipeNom.Text = "Modifier";
            button_modifierEquipeNom.UseVisualStyleBackColor = true;
            button_modifierEquipeNom.Click += button_modifierEquipeNom_Click;
            // 
            // label_modifierEquipeNom
            // 
            label_modifierEquipeNom.AutoSize = true;
            label_modifierEquipeNom.Location = new Point(279, 33);
            label_modifierEquipeNom.Name = "label_modifierEquipeNom";
            label_modifierEquipeNom.Size = new Size(49, 20);
            label_modifierEquipeNom.TabIndex = 10;
            label_modifierEquipeNom.Text = "Nom :";
            // 
            // textBox_modifierEquipeNom
            // 
            textBox_modifierEquipeNom.Location = new Point(339, 26);
            textBox_modifierEquipeNom.Name = "textBox_modifierEquipeNom";
            textBox_modifierEquipeNom.Size = new Size(151, 27);
            textBox_modifierEquipeNom.TabIndex = 9;
            // 
            // groupBox_joueur
            // 
            groupBox_joueur.Controls.Add(listBox_joueurs);
            groupBox_joueur.Controls.Add(label_ajouterJoueurEquipe);
            groupBox_joueur.Controls.Add(textBox_ajouterJoueurNom);
            groupBox_joueur.Controls.Add(comboBox_ajouterJoueurEquipe);
            groupBox_joueur.Controls.Add(button_ajouterJoueur);
            groupBox_joueur.Controls.Add(label_ajouterJoueurNom);
            groupBox_joueur.Location = new Point(25, 12);
            groupBox_joueur.Name = "groupBox_joueur";
            groupBox_joueur.Size = new Size(595, 141);
            groupBox_joueur.TabIndex = 11;
            groupBox_joueur.TabStop = false;
            groupBox_joueur.Text = "Joueurs";
            // 
            // errorProvider_ajouterJoueur
            // 
            errorProvider_ajouterJoueur.ContainerControl = this;
            // 
            // errorProvider_modifierEquipe
            // 
            errorProvider_modifierEquipe.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 353);
            Controls.Add(groupBox_joueur);
            Controls.Add(groupBox_Equipe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox_Equipe.ResumeLayout(false);
            groupBox_Equipe.PerformLayout();
            groupBox_joueur.ResumeLayout(false);
            groupBox_joueur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_ajouterJoueur).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_modifierEquipe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox_joueurs;
        private TextBox textBox_ajouterJoueurNom;
        private Button button_ajouterJoueur;
        private Label label_ajouterJoueurNom;
        private ComboBox comboBox_ajouterJoueurEquipe;
        private Label label_ajouterJoueurEquipe;
        private ListBox listBox_equipes;
        private GroupBox groupBox_Equipe;
        private Button button_modifierEquipeNom;
        private Label label_modifierEquipeNom;
        private TextBox textBox_modifierEquipeNom;
        private GroupBox groupBox_joueur;
        private ErrorProvider errorProvider_ajouterJoueur;
        private ErrorProvider errorProvider_modifierEquipe;
    }
}
