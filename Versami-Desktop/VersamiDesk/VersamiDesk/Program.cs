using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersamiDesk
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {

            using (var context = new ApplicationDbContext())
            {
                // Conta o número total de publicações na tabela 'Publicacao'
                int count = context.Publicacao.Count();  // 'Publicacao' é um DbSet<Publicacao>

                // Exibe o número de publicações
                Console.WriteLine($"Número de publicações: {count}");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
