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

        /// <summary>
        /// Constructeur de la classe que garde l'instance de FormPersonnel qui l'a crée
        /// </summary>
        /// <param name="origine"></param>
        public FormAbsences(FormPersonnel origine, Personnel perso)
        {
            InitializeComponent();
            this.origine = origine;
            this.perso = perso;
            this.control = new FormAbsenceController();
            this.isExitClicked = true;
            this.Text = "Absences de " + perso.Prenom + " " + perso.Nom.ToUpper();
        }

        private void FormAbsences_Load(object sender, EventArgs e)
        {

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
    }
}
