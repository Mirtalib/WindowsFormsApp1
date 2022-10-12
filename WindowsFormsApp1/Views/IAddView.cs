using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views
{
    public interface IAddView
    {

        string Name { get;}
        string Surname { get;}
        int Score { get;}
        DateTime DateTime { get;}


        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

    }
}
