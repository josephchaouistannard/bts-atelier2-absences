using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    /// <summary>
    /// Classe representant une ligne de la table Responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Correspond au champ login de la table Responsable
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Correspond au champ pwd de la table Responsable
        /// </summary>
        public string Pwd { get; }

        /// <summary>
        /// Constructeur de classe Responsable
        /// </summary>
        /// <param name="login">Login du responsable</param>
        /// <param name="pwd">Pwd du responsable</param>
        public Responsable(string login, string pwd)
        {
            Login = login;
            Pwd = pwd;
        }
    }
}
