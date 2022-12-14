using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Models;
using System.Windows.Forms;

namespace WindowsFormsApp1.Presenters
{
    public class MainPresenters
    {
        private readonly IMainView mainVeiw = null;
        private readonly IAddView addView;
        private readonly IUpdateVeiw updateVeiw;
        private readonly BindingSource source;
        private readonly List<Student> Student;
        public MainPresenters(IMainView mainVeiw, IAddView addView , IUpdateVeiw _updateVeiw)
        {
            updateVeiw = _updateVeiw;
            this.addView = addView;
            this.mainVeiw = mainVeiw;

            Student = new List<Student>{

                new Student(Guid.NewGuid() ,"mirtalib" , "Huseynzade",new DateTime(2003,9,1),12),
                new Student(Guid.NewGuid() ,"mirtalib2" , "Huseynzade2",new DateTime(2003,10,2),12),
            };


            source = new BindingSource();
            source.DataSource = Student;
            mainVeiw.SetStudentListBindingSource(source);

            mainVeiw.SearchEvent += MainVeiw_SearchEvent;
            mainVeiw.RemoveEvent += MainVeiw_RemoveEvent;
            mainVeiw.AddEvent += MainVeiw_AddEvent;
            mainVeiw.UpdateEvent += MainVeiw_UpdateEvent;
        }

        private void MainVeiw_UpdateEvent(object sender, EventArgs e)
        {
            var curret = source.Current;

            if (curret is null)
            {
                MessageBox.Show("Choose a Student");
                return;
            }

            var result = ((Form)updateVeiw).ShowDialog();


            Student Item = curret as Student;
            if (result == DialogResult.Cancel)
                return;

            Item.Name = updateVeiw.FirstName;
            Item.Surname = updateVeiw.LastName;
            Item.Score = (float)updateVeiw.Score;
            Item.BrithOfdDate = updateVeiw.DateOfBirth;
            source[source.IndexOf(curret)] = Item;

            MessageBox.Show("The student has been replaced");
        }

        private void MainVeiw_AddEvent(object sender, EventArgs e)
        {
            var result = ((Form)addView).ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            var student = new Student()
            {
                Name = addView.Name,
                Surname = addView.Surname,
                Score = (float)addView.Score,
                BrithOfdDate = addView.DateTime
            };
            source.Add(student);
        }

        private void MainVeiw_SearchEvent(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mainVeiw.SearchValue))
            {
                source.DataSource = Student.Where(x => x.Name
                        .ToLower()
                        .Contains(mainVeiw.SearchValue) 
                        ||
                        x.Surname
                        .ToLower()
                        .Contains(mainVeiw.SearchValue))
                    .ToList();
            }
            else
                source.DataSource = Student;
        }

        private void MainVeiw_RemoveEvent(object sender, EventArgs e)
        {
            var deleteItem = source.Current;
            if (deleteItem is null)
            {
                MessageBox.Show("Select Student");
                return;
            }
            source.Remove(deleteItem);
        }
    }
}
