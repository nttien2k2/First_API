namespace Demo
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
            Application.Run(new FrmMain());
            //Application.Run(new FrmSaoLuuPhucHoi());
            //Application.Run(new FrmRegister());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmNhanVien());
            //Application.Run(new FrmPhanQuyen());
            //Application.Run(new FrmPhongBan());



        }
    }
}