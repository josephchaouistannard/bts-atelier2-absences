using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Classe pour accèder au table Personnel de la base de données
    /// </summary>
    public class PersonnelAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de PersonnelAccess qui donne accès au singleton Access
        /// </summary>
        public PersonnelAccess()
        {
            this.access = Access.GetInstance();
        }

        /// <summary>
        /// Envoie requête SQL pour obtenir la liste de personnel apartenant à la liste des services
        /// </summary>
        /// <param name="lesServices"></param>
        /// <returns></returns>
        public List<Personnel> GetLePersonnel(List<Service> lesServices)
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            List<Object[]> result = new List<Object[]>();

            // construire la requête SQL avec la liste des services
            string query = "select * from personnel where idservice in (";
            for (int i = 0; i < lesServices.Count(); i++)
            {
                if (i == 0)
                {
                    query = query + lesServices[i].Idservice;
                }
                else
                {
                    query = query + ", " + lesServices[i].Idservice;
                }
            }
            query += ");";

            try
            {
                result = this.access.Manager.ReqSelect(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lePersonnel;
            }

            if (!(result is null))
            {
                foreach (Object[] obj in result)
                {
                    try
                    {
                        lePersonnel.Add(new Personnel((int)obj[0], (string)obj[1], (string)obj[2], (string)obj[3], (string)obj[4], (Service)lesServices[(int)obj[5] - 1]));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lePersonnel;
        }

        /// <summary>
        /// Envoie requête SQL pour ajouter une ligne dans Personnel
        /// </summary>
        /// <param name="perso"></param>
        public void AjouterPersonnel(Personnel perso)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", perso.Nom);
            parameters.Add("@prenom", perso.Prenom);
            parameters.Add("@tel", perso.Tel);
            parameters.Add("@mail", perso.Mail);
            parameters.Add("@idservice", perso.Service.Idservice);
            this.access.Manager.ReqUpdate("insert into personnel (nom, prenom, tel, mail, idservice) values (@nom, @prenom, @tel, @mail, @idservice)", parameters);
        }

        /// <summary>
        /// Envoie requête SQL pour mettre à jour une ligne dans Personnel
        /// </summary>
        /// <param name="perso"></param>
        public void ModifierPersonnel(Personnel perso)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", perso.Idpersonnel);
            parameters.Add("@nom", perso.Nom);
            parameters.Add("@prenom", perso.Prenom);
            parameters.Add("@tel", perso.Tel);
            parameters.Add("@mail", perso.Mail);
            parameters.Add("@idservice", perso.Service.Idservice);
            this.access.Manager.ReqUpdate("update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice where idpersonnel = @idpersonnel", parameters);
        }

        /// <summary>
        /// Envoie requête SQL pour supprimer une ligne dans Personnel
        /// </summary>
        /// <param name="perso"></param>
        public void SupprimerPersonnel(Personnel perso)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", perso.Idpersonnel);
            this.access.Manager.ReqUpdate("delete from personnel where idpersonnel = @idpersonnel", parameters);
        }
    }
}
