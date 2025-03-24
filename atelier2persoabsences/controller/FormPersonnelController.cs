using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.dal;
using atelier2persoabsences.model;

namespace atelier2persoabsences.controller
{
    public class FormPersonnelController
    {
        private readonly PersonnelAccess personnelAccess;
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// Constructeur de controlleur pour la fenêtre Personnel
        /// </summary>
        public FormPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// Demande au dal de retourner la liste de services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Demande au dal de retourner le personnel appartenant à une liste de services
        /// </summary>
        /// <param name="listeServices"></param>
        /// <returns></returns>
        public List<Personnel> GetLePersonnel(List<Service> listeServices)
        {
            return personnelAccess.GetLePersonnel(listeServices);
        }

        /// <summary>
        /// Demande au dal d'ajouter une ligne dans Personnel
        /// </summary>
        /// <param name="perso"></param>
        public void AjouterPersonnel(Personnel perso)
        {
            personnelAccess.AjouterPersonnel(perso);
        }

        /// <summary>
        /// Demande au dal de mettre à jour une ligne dans Personnel
        /// </summary>
        /// <param name="perso"></param>
        public void ModifierPersonnel(Personnel perso)
        {
            personnelAccess.ModifierPersonnel(perso);
        }

        /// <summary>
        /// Demande au dal de supprimer une ligne dans Personnel
        /// </summary>
        /// <param name="perso"></param>
        public void SupprimerPersonnel(Personnel perso)
        {
            personnelAccess.SupprimerPersonnel(perso);
        }
    }
}
