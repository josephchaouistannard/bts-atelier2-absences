using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Classe pour accèder au table Motif de la base de données
    /// </summary>
    public class MotifAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de MotifAccess qui donne accès au singleton Access
        /// </summary>
        public MotifAccess()
        {
            this.access = Access.GetInstance();
        }

        /// <summary>
        /// Envoie requête SQL pour obtenir la liste des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            List<Object[]> result = new List<Object[]>();

            try
            {
                result = this.access.Manager.ReqSelect("select * from motif");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lesMotifs;
            }

            if (!(result is null))
            {
                foreach (Object[] obj in result)
                {
                    try
                    {
                        lesMotifs.Add(new Motif((int)obj[0], (string)obj[1]));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lesMotifs;
        }
    }
}
