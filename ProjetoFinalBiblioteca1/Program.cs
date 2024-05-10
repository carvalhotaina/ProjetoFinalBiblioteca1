using ProjetoFinalBiblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//Nome:Ta�na Carvalho 3 fase

namespace ProjetoFinalBiblioteca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            // Criando listas de exemplares, leitores e funcion�rios
            List<Exemplar> exemplares = new List<Exemplar>();
            List<Leitor> leitores = new List<Leitor>();
            List<Funcionario> funcionarios = new List<Funcionario>();

            // Exibindo informa��es dos exemplares, leitores e funcion�rios (exemplo)
            Console.WriteLine("Exemplares:");
            foreach (Exemplar exemplar in exemplares)
            {
                Console.WriteLine(exemplar);
            }

            Console.WriteLine("\nLeitores:");
            foreach (Leitor leitor in leitores)
            {
                Console.WriteLine(leitor);
            }

            Console.WriteLine("\nFuncion�rios:");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}