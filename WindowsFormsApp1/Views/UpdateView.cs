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
    public partial class UpdateView : Form , IUpdateVeiw
    {
        public UpdateView()
        {
            InitializeComponent();
        }

        public string FirstName => txtBoxName.Text;

        public string LastName => txtBoxSurname.Text;

        public decimal Score => numericUpDownScore.Value;

        public DateTime DateOfBirth => monthCalendar1.SelectionStart;

        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void btnSave_Click(object sender, EventArgs e)
        {
            // DialogResult = DialogResult.OK;
            SaveEvent?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // CancelEvent?.Invoke(sender, e);
        }
    }
}
