namespace soc_1_cs;
using System.Runtime.InteropServices;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Win32.AllocConsole();       //TODO: remove
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}

    public class Win32          //TODO:remove
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();
    }