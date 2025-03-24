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
        private bool modification;

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
            modification = false;

            // recupérer les services
            listeService = control.GetLesServices();
            bindingService.DataSource = listeService;
            comboService.DataSource = bindingService;

            // recupérer le personnel
            listePersonnel = control.GetLePersonnel(listeService);
            bindingPersonnel.DataSource = listePersonnel;
            dgvPersonnel.DataSource = bindingPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
        }
    }
}
