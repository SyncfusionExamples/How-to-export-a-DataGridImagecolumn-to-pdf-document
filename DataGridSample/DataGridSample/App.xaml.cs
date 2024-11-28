namespace DataGridSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRHxbf1x0ZFdMZV5bQX9PMyBoS35RckRiWXpeeHRWRmZaU0R+");

            MainPage = new AppShell();
        }
    }
}
