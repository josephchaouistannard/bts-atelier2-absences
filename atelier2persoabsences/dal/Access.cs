using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atelier2persoabsences.bddmanager;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Singleton : pour accèder au BddManager
    /// </summary>
    public class Access
    {
        // chaine de connexion à la bdd
        private static readonly string connectionString = "server=localhost; port=3306; user id=mediatek; password='password'; database=mediatek86; SslMode=Required;";
        // instance unique de la classe
        private static Access instance = null;
        
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Constructeur privé qui récupère instance existant ou en crée une
        /// </summary>
        private Access()
        {
            try
            {
                this.Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Méthode pour accèder au singleton Access
        /// </summary>
        /// <returns>Instance unique de Access</returns>
        public static Access GetInstance()
        {
            if (Access.instance == null)
            {
                Access.instance = new Access();
            }
            return Access.instance;
        }
    }
}