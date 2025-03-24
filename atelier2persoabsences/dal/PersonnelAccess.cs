using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
