namespace AdoNetCore
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
            //AQUI PONEMOS LA VENTANA / FORMULARIO QUE VA A CARGAR
            Application.Run(new Form10UpdateEmpleadosOficios());
        }
    }
}