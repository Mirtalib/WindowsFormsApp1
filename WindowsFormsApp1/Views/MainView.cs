using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler RemoveEvent;
        public event EventHandler UpdateEvent;
        public string SearchValue => txtSearch.Text;


        public void SetStudentListBindingSource(BindingSource source) => lBox_Students.DataSource = source;
        private void btnSearch_Click(object sender, EventArgs e) =>SearchEvent?.Invoke(sender, e);
        private void btnREmove_Click(object sender, EventArgs e) =>RemoveEvent?.Invoke(sender, e);
        private void btnUpdate_Click(object sender, EventArgs e) => UpdateEvent.Invoke(sender, e);
        private void btnAdd_Click(object sender, EventArgs e) => AddEvent?.Invoke(sender, e);
    }
}
