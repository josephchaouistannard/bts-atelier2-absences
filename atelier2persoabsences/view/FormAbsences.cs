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
using Mysqlx.Crud;

namespace atelier2persoabsences.view
{
    /// <summary>
    /// Classe du FormAbsences
    /// </summary>
    public partial class FormAbsences: Form
    {
        private readonly FormPersonnel origine;
        private readonly Personnel perso;
        private readonly FormAbsenceController control;
        private bool isExitClicked;
        private List<Motif> listeMotifs;
        private List<Absence> listeAbsences;
        private BindingSource bindingMotif;
        private BindingSource bindingAbsence;
        private Absence absenceAvantModification;

        /// <summary>
        /// Constructeur de la classe que garde l'instance de FormPersonnel qui l'a crée
        /// </summary>
        /// <param name="origine"></param>
        public FormAbsences(FormPersonnel origine, Personnel perso)
        {
            InitializeComponent();
            this.origine = origine;
            this.perso = perso;
            control = new FormAbsenceController();
        }

        private void FormAbsences_Load(object sender, EventArgs e)
        {            
            isExitClicked = true;
            this.Text = "Absences de " + perso.Prenom + " " + perso.Nom.ToUpper();
            bindingMotif = new BindingSource();
            bindingAbsence = new BindingSource();
            RefreshData();
            AjoutModifEnabled(false);

            dgvAbsences.DataSource = bindingAbsence;
            dgvAbsences.Columns[0].Visible = false;

            comboMotif.DataSource = bindingMotif;
        }

        /// <summary>
        /// Evenement clic sur bouton pour retourner à la fenêtre Personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetourner_Click(object sender, EventArgs e)
        {
            isExitClicked = false;
            Fermer();
        }

        /// <summary>
        /// Demande l'affichage de Personnel et ferme cette fenêtre
        /// </summary>
        public void Fermer()
        {
            origine.Show();
            this.Close();
        }

        /// <summary>
        /// Quand fenêtre est fermée, ferme totalement le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbsences_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExitClicked)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Evenement clic sur bouton Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        /// <summary>
        /// Evenement clic sur bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        /// <summary>
        /// Evenement clic sur bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        /// <summary>
        /// Evenement clic sur bouton Ajouter ou Modifier dans la zone de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutModif_Click(object sender, EventArgs e)
        {
            EnregisterAjoutModif();
        }

        /// <summary>
        /// Evenement clic sur le bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ResetDisplay();
        }

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

        public void HautEnabled(bool b)
        {
            dgvAbsences.Enabled = b;
            btnAjouter.Enabled = b;
            btnModifier.Enabled = b;
            btnSupprimer.Enabled = b;
            btnRetourner.Enabled = b;
        }

        public void AjoutModifEnabled(bool b)
        {
            groupAjoutModif.Enabled = b;
        }

        /// <summary>
        /// Vider les zones de saisie du groupbox AjoutModif
        /// </summary>
        public void ClearAjoutModif()
        {
            dateDebut.Value = DateTime.Now;
            dateFin.Value = DateTime.Now;
            lblError.Text = "";
        }

        public void RefreshData()
        {
            // recupérer les motifs
            listeMotifs = control.GetLesMotifs();
            bindingMotif.DataSource = listeMotifs;
            bindingMotif.ResetBindings(false);

            // recupérer les absences
            listeAbsences = control.GetLesAbsences(listeMotifs, perso);
            bindingAbsence.DataSource = listeAbsences;
            bindingAbsence.ResetBindings(false);
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
            if (!(dgvAbsences.SelectedRows is null))
            {
                Absence absenceASupprimer = listeAbsences[dgvAbsences.CurrentRow.Index];
                DialogResult result = MessageBox.Show(
                    "Confirmer la suppression ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    control.SupprimerAbsence(absenceASupprimer, perso);
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
            Absence absenceAModifier = listeAbsences[dgvAbsences.CurrentRow.Index];
            absenceAvantModification = absenceAModifier;
            dateDebut.Value = absenceAModifier.Datedebut;
            dateFin.Value = absenceAModifier.Datefin;
            comboMotif.SelectedItem = absenceAModifier.Motif;
        }

        /// <summary>
        /// Méthode qui gère l'enregistrement d'ajout ou modification. La modification est en fait la suppression de l'ancienne ligne et l'ajout d'une nouvelle.
        /// </summary>
        public void EnregisterAjoutModif()
        {
            int test = DateTime.Compare(dateDebut.Value, dateFin.Value);
            if (test > 0)
            {
                lblError.Text = "La date de fin doit être le plus tard";
            }
            else if (test == 0)
            {
                lblError.Text = "Les deux dates sont identiques";
            }
            else
            {
                switch (btnAjoutModif.Text)
                {
                    case "Modifier":
                        DialogResult result = MessageBox.Show(
                        "Confirmer la modification ?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            control.SupprimerAbsence(absenceAvantModification, perso);
                            Absence absenceAModifier = listeAbsences[dgvAbsences.CurrentRow.Index];
                            absenceAModifier.Datedebut = dateDebut.Value;
                            absenceAModifier.Datefin = dateFin.Value;
                            absenceAModifier.Motif = (Motif)comboMotif.SelectedItem;
                            control.AjouterAbsence(absenceAModifier, perso);
                            ResetDisplay();
                        }
                        break;
                    case "Ajouter":
                        Absence AbsenceAAjouter = new Absence(perso, dateDebut.Value, dateFin.Value ,(Motif)comboMotif.SelectedItem);
                        control.AjouterAbsence(AbsenceAAjouter, perso);
                        break;
                }
                ResetDisplay();
            }
        }
    }
}
