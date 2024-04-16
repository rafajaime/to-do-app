namespace To_Do_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            ////
            ////// Codigo para evitar multiples instancias de la app
            const string nombreApp = "To-Do App";
            bool createdNew;

            Mutex mutex = new Mutex(true, nombreApp, out createdNew);

            if(!createdNew)
            {
                MessageBox.Show("La aplicación ya está abierta");
                return;
            }
            ////// Fin del codigo de instancias
            ////
            //


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
        }
    }
}