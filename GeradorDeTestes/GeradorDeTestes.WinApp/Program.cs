using GeradorDeTestes.WinApp._2___M�dulo_Disciplinas;
using GeradorDeTestes.WinApp._4___M�dulo_Testes;

namespace GeradorDeTestes.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipalForm());
        }
    }
}