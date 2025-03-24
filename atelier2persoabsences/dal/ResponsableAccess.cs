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
    /// Classe pour accèder au table Responsable de la base de données
    /// </summary>
    public class ResponsableAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de ResponsableAccess qui donne accès au singleton Access
        /// </summary>
        public ResponsableAccess()
        {
            this.access = Access.GetInstance();
        }

        /// <summary>
        /// Verifie les identifiants saisie et retourne vrai si la ligne est trouvé dans la table responsable
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>
        public bool ControleAuthentification(Responsable responsable)
        {
            List<Object[]> result = new List<Object[]>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", responsable.Login);
            parameters.Add("@pwd", HashWithSha256(responsable.Pwd));
            try
            {
                result = this.access.Manager.ReqSelect("select * from responsable where login = @login and pwd = @pwd", parameters);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (result.Count == 0 || result is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Fonction qui transforme une chaine avec Sha256
        /// </summary>
        /// <param name="pwdPlain"></param>
        /// <returns></returns>
        private string HashWithSha256(string pwdPlain)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] pwdBytes = Encoding.UTF8.GetBytes(pwdPlain);
                byte[] hashBytes = sha256Hash.ComputeHash(pwdBytes);

                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashStringBuilder.Append(b.ToString("x2"));
                }
                string pwdCrypte = hashStringBuilder.ToString();

                return pwdCrypte;
            }
        }


    }
}
