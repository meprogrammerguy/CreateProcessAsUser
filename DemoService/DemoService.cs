using murrayju.ProcessExtensions;
using System.ServiceProcess;

namespace demo
{
    public partial class DemoService : ServiceBase
    {
        public DemoService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string theApp = @"C:\cmdseries\BIN\cmdnetw.exe";
            string theArgs = @"c:\cmdseries\clients\cmdnet32.ini";
            string theDir = @"C:\cmdseries\BIN\";
            ProcessExtensions.StartProcessAsCurrentUser(theApp, theArgs, theDir);

            theApp = @"C:\cmdseries\BIN\uniface.exe";
            theArgs = @"cmdserie /a=cx /m=1 /netini=c:\cmdseries\clients\cmdnet32.ini /ini=""c:\cmdseries\Clients\cmd96.ini"" /caini=""c:\cmdseries\Clients\cmd96.ini"" /COMMDETAILLOG";
            theDir = @"c:\cmdseries\clients\";
            ProcessExtensions.StartProcessAsCurrentUser(theApp, theArgs, theDir);
        }

        protected override void OnStop()
        {
        }
    }
}
