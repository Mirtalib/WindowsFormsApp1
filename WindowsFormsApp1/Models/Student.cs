using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Student
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BrithOfdDate { get; set; }
        public float Score { get; set; }


        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Student(Guid ıd, string name, string surname, DateTime brithOfdDate, float score)
            :this()
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            BrithOfdDate = brithOfdDate;
            Score = score;
        }


        public override string ToString()
        {
            return $"ID: {Id.ToString().Remove(8)}     Name:  {Name}     Date Of Brith:  {BrithOfdDate}     Score:  {Score}";
        }

    }
}
