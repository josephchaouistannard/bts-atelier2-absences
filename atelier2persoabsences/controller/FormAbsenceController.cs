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
    /// La partie controlleur qui fait l'intermédiaire entre la vue et les autres packages
    /// </summary>
    class NamespaceDoc
    {
    }

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
        /// <returns>Une liste d'objets de type Motif, representant les lignes de table Motif</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande au dal de retourner les absences d'une personne
        /// </summary>
        /// <param name="lesMotifs">Liste de Motifs</param>
        /// <param name="perso">Personne pour laquelle on veut voir les absences</param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(List<Motif> lesMotifs, Personnel perso)
        {
            return absenceAccess.GetLesAbsences(lesMotifs, perso);
        }

        /// <summary>
        /// Demande au dal d'ajouter une ligne dans Absence
        /// </summary>
        /// <param name="absence">Instance de Absence à ajouter</param>
        /// <param name="perso">Personne concernée</param>
        public void AjouterAbsence(Absence absence, Personnel perso)
        {
            absenceAccess.AjouterAbsence(absence, perso);
        }

        /// <summary>
        /// Demande au dal de supprimer une ligne dans Absence
        /// </summary>
        /// <param name="absence">Absence à supprimer</param>
        /// <param name="perso">Personne concernée</param>
        public void SupprimerAbsence(Absence absence, Personnel perso)
        {
            absenceAccess.SupprimerAbsence(absence, perso);
        }

        /// <summary>
        /// Demande au dal de modifier une ligne dans Absence
        /// </summary>
        /// <param name="absence">Absence modifiée à ajouter</param>
        /// <param name="perso">Personne concernée</param>
        /// <param name="absenceAvant">Absence avant modification à supprimer</param>
        public void ModifierAbsence(Absence absence, Personnel perso, Absence absenceAvant)
        {
            absenceAccess.SupprimerAbsence(absenceAvant, perso);
            absenceAccess.AjouterAbsence(absence, perso);
        }
    }
}
