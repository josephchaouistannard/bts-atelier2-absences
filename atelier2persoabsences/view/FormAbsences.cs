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
        /// <param name="origine">Instance de FormPersonnel qui à crée cet objet</param>
        /// <param name="perso">Personne concernée</param>
        public FormAbsences(FormPersonnel origine, Personnel perso)
        {
            InitializeComponent();
            this.origine = origine;
            this.perso = perso;
            control = new FormAbsenceController();
        }

        /// <summary>
        /// Chargement de FormAbsences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Réinitialiser l'affichage et les données
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
        /// Rendre accessible ou pas la partie haute de la fenêtre
        /// </summary>
        /// <param name="b">Vrai pour activer, faux pour désactiver</param>
        public void HautEnabled(bool b)
        {
            dgvAbsences.Enabled = b;
            btnAjouter.Enabled = b;
            btnModifier.Enabled = b;
            btnSupprimer.Enabled = b;
            btnRetourner.Enabled = b;
        }

        /// <summary>
        /// Rendre accessible ou pas la partie saisie
        /// </summary>
        /// <param name="b">Vrai pour activer, faux pour désactiver</param>
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
            absenceAvantModification = null;
        }

        /// <summary>
        /// Recupère les données Motif et Absence à jour
        /// </summary>
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
            absenceAvantModification = (Absence)absenceAModifier.Clone();
            dateDebut.Value = absenceAModifier.Datedebut;
            dateFin.Value = absenceAModifier.Datefin;
            comboMotif.SelectedItem = absenceAModifier.Motif;
        }

        /// <summary>
        /// Gère l'enregistrement d'ajout ou modification
        /// </summary>
        public void EnregisterAjoutModif()
        {
            int test = DateTime.Compare(dateDebut.Value, dateFin.Value);
            if (test > 0)
            {
                lblError.Text = "La date de fin est avant celle de début";
            }
            else
            {
                switch (btnAjoutModif.Text)
                {
                    case "Modifier":
                        // Preparation d'instance à modifier
                        Absence absenceAModifier = (Absence)listeAbsences[dgvAbsences.CurrentRow.Index].Clone();
                        absenceAModifier.Datedebut = dateDebut.Value;
                        absenceAModifier.Datefin = dateFin.Value;
                        absenceAModifier.Motif = (Motif)comboMotif.SelectedItem;

                        if (VerifierModification(absenceAModifier, absenceAvantModification))
                        {
                            DialogResult result = MessageBox.Show(
                            "Confirmer la modification ?",
                            "Confirmation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Absence absenceASupprimer = listeAbsences[dgvAbsences.CurrentRow.Index];
                                control.SupprimerAbsence(absenceASupprimer, perso);
                                control.AjouterAbsence(absenceAModifier, perso);
                                ResetDisplay();
                            }
                        }
                        break;
                    case "Ajouter":
                        Absence absenceAAjouter = new Absence(perso, dateDebut.Value, dateFin.Value ,(Motif)comboMotif.SelectedItem);
                        if (VerifierAjout(absenceAAjouter))
                        {
                            control.AjouterAbsence(absenceAAjouter, perso);
                            ResetDisplay();
                        }
                        break;
                }
                
            }
        }

        /// <summary>
        /// Verifier l'existance d'une absence en conflit avec celle à ajouter. Retourne vrai si il n'y pas de conflit.
        /// </summary>
        /// <param name="nouvelle">Nouvelle absence prêt à être ajoutée</param>
        /// <returns>Vrai si l'ajout peut procéder, faux si il est en conflit avec une absence existante</returns>
        public bool VerifierAjout(Absence nouvelle)
        {
            foreach (Absence existante in listeAbsences)
            {
                if (
                    (existante.Datedebut <= nouvelle.Datefin && existante.Datedebut >= nouvelle.Datedebut) ||
                    (existante.Datefin <= nouvelle.Datefin && existante.Datefin >= nouvelle.Datedebut) ||
                    (existante.Datedebut <= nouvelle.Datedebut && existante.Datefin >= nouvelle.Datefin) ||
                    (existante.Datedebut >= nouvelle.Datedebut && existante.Datefin <= nouvelle.Datefin))
                {
                    lblError.Text = "Déjà absence pendant cette période";
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifier l'existance d'une absence en conflit avec celle à ajouter, mise apart celle en cours de modification. Retourne vrai si il n'y a pas de conflit.
        /// </summary>
        /// <param name="nouvelle">Nouvelle absence prêt à être ajoutée</param>
        /// <param name="avantModification">Absence à modifier avant tout changement</param>
        /// <returns>Vrai si l'ajout peut procéder, faux si il est en conflit avec une absence existante</returns>
        public bool VerifierModification(Absence nouvelle, Absence avantModification)
        {
            foreach (Absence existante in listeAbsences)
            {
                if (!existante.Equals(avantModification))
                {
                    if (
                        (existante.Datedebut <= nouvelle.Datefin && existante.Datedebut >= nouvelle.Datedebut) ||
                        (existante.Datefin <= nouvelle.Datefin && existante.Datefin >= nouvelle.Datedebut) ||
                        (existante.Datedebut <= nouvelle.Datedebut && existante.Datefin >= nouvelle.Datefin) ||
                        (existante.Datedebut >= nouvelle.Datedebut && existante.Datefin <= nouvelle.Datefin))
                    {
                        lblError.Text = "Déjà absence pendant cette période";
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
