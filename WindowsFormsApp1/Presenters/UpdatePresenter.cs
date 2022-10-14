using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenters
{
    public class UpdatePresenter
    {

        private readonly IUpdateVeiw updateVeiw;

        public UpdatePresenter(IUpdateVeiw _updateVeiw)
        {
            updateVeiw = _updateVeiw;

            updateVeiw.SaveEvent += UpdateVeiw_SaveEvent;
            updateVeiw.CancelEvent += UpdateVeiw_CancelEvent;
        }

        private void UpdateVeiw_CancelEvent(object sender, EventArgs e)=>
            ((Form)updateVeiw).DialogResult = DialogResult.Cancel;

        private void UpdateVeiw_SaveEvent(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(updateVeiw.FirstName) || updateVeiw.FirstName.Length < 3)
            {
                MessageBox.Show("FirstName Wrong");
                return;
            }
            if (string.IsNullOrWhiteSpace(updateVeiw.LastName) || updateVeiw.LastName.Length < 3)
            {
                MessageBox.Show("LastName Wrong");
                return;
            }
            ((Form)updateVeiw).DialogResult = DialogResult.OK;
        }
    }
}
