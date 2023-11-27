using XIIRPL2_22_Ticketing.masterForm;

namespace XIIRPL2_22_Ticketing
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
            //Application.Run(new Form1());
            //FrmLogin login = new FrmLogin();
            //login.Show(); 
            FrmMasterBandara bandara = new FrmMasterBandara();
            bandara.Show();
            //FrmMasterKodePromo kodePromo = new FrmMasterKodePromo();
            //kodePromo.Show();
            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();
            //FrmMasterJadwalPenerbangan jadwalPenerbangan = new FrmMasterJadwalPenerbangan();
            //jadwalPenerbangan.Show();
            Application.Run();
        }
    }
}