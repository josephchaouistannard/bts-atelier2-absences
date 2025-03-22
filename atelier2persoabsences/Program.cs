using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using atelier2persoabsences.view;

namespace atelier2persoabsences
{
    /// <summary>
    /// Application de gestion des absences de personnel
    /// </summary>
    internal class NamespaceDoc
    {
    }

    /// <summary>
    /// Classe principale de l'application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConnection());
        }
    }
}
