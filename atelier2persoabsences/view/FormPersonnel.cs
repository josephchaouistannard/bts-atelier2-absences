using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atelier2persoabsences.controller;
using atelier2persoabsences.model;

namespace atelier2persoabsences.view
{
    /// <summary>
    /// Fenêtre pour voir la liste de personnel, et la modifier
    /// </summary>
    public partial class FormPersonnel: Form
    {
        private FormPersonnelController control;
        private List<Personnel> listePersonnel;
        private List<Service> listeService;
        private BindingSource bindingPersonnel;
        private BindingSource bindingService;

        /// <summary>
        /// Constructeur pour instancier la fenêtre FormPersonnel
        /// </summary>
        public FormPersonnel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quand fenêtre est fermée, ferme totalement le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPersonnel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Rempli la page après chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPersonnel_Load(object sender, EventArgs e)
        {
            control = new FormPersonnelController();
            bindingPersonnel = new BindingSource();
            bindingService = new BindingSource();
            RefreshData();
            AjoutModifEnabled(false);

            dgvPersonnel.DataSource = bindingPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;

            comboService.DataSource = bindingService;
        }

        /// <summary>
        /// Recupère le personnel et les services pour les (re)afficher
        /// </summary>
        public void RefreshData()
        {
            // recupérer les services
            listeService = control.GetLesServices();
            bindingService.DataSource = listeService;
            bindingService.ResetBindings(false);

            // recupérer le personnel
            listePersonnel = control.GetLePersonnel(listeService);
            bindingPersonnel.DataSource = listePersonnel;
            bindingPersonnel.ResetBindings(false);
        }

        /// <summary>
        /// Rendre inaccessible la partie ajout ou modification
        /// </summary>
        public void AjoutModifEnabled(bool b)
        {
            groupAjoutModif.Enabled = b;
        }

        /// <summary>
        /// Vider les zones de saisie du groupbox AjoutModif
        /// </summary>
        public void ClearAjoutModif()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            lblError.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetDisplay()
        {
            groupAjoutModif.Enabled = false;
            groupAjoutModif.Text = "Ajouter";
            btnAjoutModif.Text = "Ajouter";
            HautEnabled(true);
            ClearAjoutModif();
            AjoutModifEnabled(false);
            RefreshData();
        }

        /// <summary>
        /// Rendre active ou non la partie haute de la fenêtre
        /// </summary>
        /// <param name="b"></param>
        public void HautEnabled(bool b)
        {
            dgvPersonnel.Enabled = b;
            btnAjouter.Enabled = b;
            btnModifier.Enabled = b;
            btnSupprimer.Enabled = b;
            btnAbsences.Enabled = b;
        }

        /// <summary>
        /// Evenement qui déclenche la méthode Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        /// <summary>
        /// Evenement qui déclenche la méthode Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        /// <summary>
        /// Evenement qui déclenche la méthode Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        /// <summary>
        /// Commencer un ajout
        /// </summary>
        public void Ajouter()
        {
            HautEnabled(false);
            AjoutModifEnabled(true);
        }

        /// <summary>
        /// Essayer de supprimer, avec confirmation
        /// </summary>
        public void Supprimer()
        {
            if (!(dgvPersonnel.SelectedRows is null))
            {
                Personnel persoASupprimer = listePersonnel[dgvPersonnel.CurrentRow.Index];
                DialogResult result = MessageBox.Show(
                    "Confirmer la suppression ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    control.SupprimerPersonnel(persoASupprimer);
                    ResetDisplay();
                }
            }
            else
            {
                MessageBox.Show("Selectionner une ligne avant");
            }
        }

        /// <summary>
        /// Commencer une modification
        /// </summary>
        public void Modifier()
        {
            HautEnabled(false);
            AjoutModifEnabled(true);
            groupAjoutModif.Text = "Modifier";
            btnAjoutModif.Text = "Modifier";
            Personnel persoAModifier = listePersonnel[dgvPersonnel.CurrentRow.Index];
            txtNom.Text = persoAModifier.Nom;
            txtPrenom.Text = persoAModifier.Prenom;
            txtMail.Text = persoAModifier.Mail;
            txtTel.Text = persoAModifier.Tel;
            comboService.SelectedItem = persoAModifier.Service;
        }

        /// <summary>
        /// Evenement click sur bouton Ajouter ou Modifier dans la zone de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutModif_Click(object sender, EventArgs e)
        {
            EnregisterAjoutModif();
        }

        /// <summary>
        /// Méthode qui gère l'enregistrement d'ajout ou modification
        /// </summary>
        public void EnregisterAjoutModif()
        {
            if (!String.IsNullOrWhiteSpace(txtNom.Text) &&
                !String.IsNullOrWhiteSpace(txtPrenom.Text) &&
                !String.IsNullOrWhiteSpace(txtMail.Text) &&
                !String.IsNullOrWhiteSpace(txtTel.Text) &&
                comboService.SelectedIndex != -1)
            {
                switch (btnAjoutModif.Text)
                {
                    case "Modifier":
                        Personnel persoAModifier = listePersonnel[dgvPersonnel.CurrentRow.Index];
                        persoAModifier.Nom = txtNom.Text;
                        persoAModifier.Prenom = txtPrenom.Text;
                        persoAModifier.Mail = txtMail.Text;
                        persoAModifier.Tel = txtTel.Text;
                        persoAModifier.Service = (Service)comboService.SelectedItem;
                        control.ModifierPersonnel(persoAModifier);
                        break;
                    case "Ajouter":
                        Personnel persoAAjouter = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, (Service)comboService.SelectedItem);
                        control.AjouterPersonnel(persoAAjouter);
                        break;
                }
                ResetDisplay();
            }
            else
            {
                lblError.Text = "Veuillez remplir tous les champs";
            }
        }

        /// <summary>
        /// Evenement qui annule la saisie et reinitialise l'affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ResetDisplay();
        }

        /// <summary>
        /// Evenement clic sur bouton Absences qui appelle fonction VoirAbsences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            VoirAbsences();
        }

        public void VoirAbsences()
        {
            if (!(dgvPersonnel.SelectedRows is null))
            {
                Form absences = new FormAbsences(this, listePersonnel[dgvPersonnel.CurrentRow.Index]);
                absences.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selectionner une ligne avant");
            }
        }
    }
}
