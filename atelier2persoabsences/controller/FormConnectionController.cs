using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.dal;
using atelier2persoabsences.model;

namespace atelier2persoabsences.controller
{
    /// <summary>
    /// Controlleur pour la fenêtre d'authenification
    /// </summary>
    public class FormConnectionController
    {
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Constructeur du controlleur qui crée une instance de ResponsableAccess
        /// </summary>
        public FormConnectionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Fonction pour demander au dal de controller les identifiants saisies
        /// </summary>
        /// <param name="responsable">Instance de Responsable à controller</param>
        /// <returns>Vrai si l'authentification réussi</returns>
        public bool ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }
    }
}
