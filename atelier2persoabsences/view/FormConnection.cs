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
    public partial class FormConnection: Form
    {
        private FormConnectionController control;

        /// <summary>
        /// Fenêtre de connection qui s'ouvre au démarrage
        /// </summary>
        public FormConnection()
        {
            InitializeComponent();
            control = new FormConnectionController();
        }

        /// <summary>
        /// Méthode eventmentielle après click sur Se Connecter
        /// </summary>
        private void Connection()
        {
            if (!String.IsNullOrWhiteSpace(txtLogin.Text) &&
                !String.IsNullOrWhiteSpace(txtPwd.Text))
            {
                lblError.Text = "";
                Responsable responsable = new Responsable(txtLogin.Text, txtPwd.Text);
                if (control.ControleAuthentification(responsable))
                {
                    Form main = new FormPersonnel();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Authentification echouée";
                }
            }
            else
            {
                lblError.Text = "Il faut remplir tous les champs";
            }
        }

        /// <summary>
        /// Evenement clic sur bouton Se Connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            Connection();
        }
    }
}
