using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenters;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            IMainView mainVeiw = new MainView();
            IAddView addView = new AddView();
            IUpdateVeiw updateVeiw = new UpdateView();

            new MainPresenters(mainVeiw , addView , updateVeiw);
            
            Application.Run((Form)mainVeiw);
        }
    }
}
