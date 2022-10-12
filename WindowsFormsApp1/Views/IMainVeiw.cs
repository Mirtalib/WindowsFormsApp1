using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public interface IMainView
    {
        string SearchValue { get;}
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler RemoveEvent;
        event EventHandler UpdateEvent;

        void SetStudentListBindingSource(BindingSource source);

    }
}
