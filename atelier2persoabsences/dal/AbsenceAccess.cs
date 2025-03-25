using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Data Access Layer qui communique avec BddManager 
    /// </summary>
    class NamespaceDoc
    {
    }

    /// <summary>
    /// Classe pour accèder au table Absence de la base de données
    /// </summary>
    public class AbsenceAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de AbsenceAccess qui donne accès au singleton Access
        /// </summary>
        public AbsenceAccess()
        {
            this.access = Access.GetInstance();
        }

        /// <summary>
        /// Envoie requête SQL pour recupérer la liste d'absences pour une personne
        /// </summary>
        /// <param name="lesMotifs">liste des motifs</param>
        /// <param name="perso">Personne concernée</param>
        /// <returns>La liste de toutes absences de la personne, de la plus récente à la plus ancienne</returns>
        public List<Absence> GetLesAbsences(List<Motif> lesMotifs, Personnel perso)
        {
            List<Absence> lesAbsences = new List<Absence>();
            List<Object[]> result;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", perso.Idpersonnel);

            try
            {
                result = this.access.Manager.ReqSelect("SELECT * FROM absence WHERE idpersonnel = @idpersonnel order by datedebut desc", parameters);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lesAbsences;
            }

            if (!(result is null))
            {
                foreach (Object[] obj in result)
                {
                    try
                    {
                        lesAbsences.Add(new Absence(perso, (DateTime)obj[1], (DateTime)obj[2], lesMotifs[(int)obj[3] - 1]));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lesAbsences;
        }

        /// <summary>
        /// Envoie requête SQL pour demander l'ajout d'une ligne dans Absence
        /// </summary>
        /// <param name="absence">Absence à ajouter</param>
        /// <param name="perso">Personne concernée</param>
        public void AjouterAbsence(Absence absence, Personnel perso)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", perso.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idmotif", absence.Motif.Idmotif);
            this.access.Manager.ReqUpdate("insert into absence (idpersonnel, datedebut, datefin, idmotif) values (@idpersonnel, @datedebut, @datefin, @idmotif)", parameters);
        }

        /// <summary>
        /// Envoie requête SQL pour demander la suppression d'une ligne dans Absence
        /// </summary>
        /// <param name="absence">Absence à supprimer</param>
        /// <param name="perso">Personne concernée</param>
        public void SupprimerAbsence(Absence absence, Personnel perso)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", perso.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            this.access.Manager.ReqUpdate("delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut", parameters);
        }

        /// <summary>
        /// Envoie requete SQL pour modifier une ligne dans Absence, identifiée par son date de début avant modification
        /// </summary>
        /// <param name="absence">Absence modifier à enregistrer</param>
        /// <param name="perso">Personne concernée</param>
        /// <param name="debutavant">La date de début avant modification</param>
        public void ModifierAbsence(Absence absence, Personnel perso, DateTime debutavant)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", perso.Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idmotif", absence.Motif.Idmotif);
            parameters.Add("@debutavant", debutavant);
            this.access.Manager.ReqUpdate("update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif where idpersonnel = @idpersonnel and datedebut = @debutavant", parameters);
        }
    }
}
