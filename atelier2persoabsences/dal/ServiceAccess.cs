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
    /// Classe pour accèder au table Service de la base de données
    /// </summary>
    public class ServiceAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de ServiceAccess qui donne accès au singleton Access
        /// </summary>
        public ServiceAccess()
        {
            this.access = Access.GetInstance();
        }

        /// <summary>
        /// Envoie demande SQL pour recuperer la liste des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            List<Object[]> result = new List<Object[]>();

            try
            {
                result = this.access.Manager.ReqSelect("select * from service");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lesServices;
            }

            if (!(result is null))
            {
                foreach (Object[] obj in result)
                {
                    lesServices.Add(new Service((int)obj[0], (string)obj[1]));
                }
            }

            return lesServices;
        }
    }
}
