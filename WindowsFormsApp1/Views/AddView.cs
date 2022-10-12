using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class AddView : Form, IAddView
    {
        public AddView()
        {
            InitializeComponent();
        }

        public string Name => txtBoxName.Text;
        public string Surname => txtBoxSurname.Text;
        public DateTime DateTime => throw new NotImplementedException();
        public int Score => throw new NotImplementedException();

        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
