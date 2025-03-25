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
    /// Controlleur pour FormAbsences
    /// </summary>
    public class FormAbsenceController
    {
        private readonly MotifAccess motifAccess;
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Constructeur de controlleur pour la fenêtre Absences
        /// </summary>
        public FormAbsenceController()
        {
            motifAccess = new MotifAccess();
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Demande au dal de retourner les motifs d'absence
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande au dal de retourner les absences d'une personne
        /// </summary>
        /// <param name="lesMotifs"></param>
        /// <param name="perso"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(List<Motif> lesMotifs, Personnel perso)
        {
            return absenceAccess.GetLesAbsences(lesMotifs, perso);
        }

        /// <summary>
        /// Demande au dal d'ajouter une ligne dans Absence
        /// </summary>
        /// <param name="absence"></param>
        public void AjouterAbsence(Absence absence, Personnel perso)
        {
            absenceAccess.AjouterAbsence(absence, perso);
        }

        /// <summary>
        /// Demande au dal de supprimer une ligne dans Absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="perso"></param>
        public void SupprimerAbsence(Absence absence, Personnel perso)
        {
            absenceAccess.SupprimerAbsence(absence, perso);
        }

        /// <summary>
        /// Demande au dal de modifier une ligne dans Absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="perso"></param>
        /// <param name="absenceAvant"></param>
        public void ModifierAbsence(Absence absence, Personnel perso, Absence absenceAvant)
        {
            absenceAccess.SupprimerAbsence(absenceAvant, perso);
            absenceAccess.AjouterAbsence(absence, perso);
        }
    }
}
