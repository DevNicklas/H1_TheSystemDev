using H1_TheSystemDev.Controller;

namespace H1_TheSystemDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainCtrl = new MainController();
            mainCtrl.Start();
        }
    }
}