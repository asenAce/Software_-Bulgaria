using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToExcel
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Email { get; set; }
        public string Gender { get; set; }
        public string StudentType { get; set; }
        public int ExamResult { get; set; }
        public int HomeworkSent { get; set; }
        public int HomeworkEvaluetion { get; set; }
        public double TeamWork { get; set; }
        public int Attendances { get; set; }
        public double Bonus { get; set; }

        public double result;

        public Student(int iD,string firstName,string lastName,string email,string gender,string studentType,
            int examResult, int homeworkSent, int homeworkEvaluetion,double teamWork,int attendances,double bonus)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ExamResult = examResult;
            this.HomeworkSent = homeworkSent;
            this.Gender = gender;
            this.StudentType = studentType;
            this.Email = email;
            this.HomeworkEvaluetion = homeworkEvaluetion;
            this.TeamWork = teamWork;
            this.Attendances = attendances;
            this.Bonus = bonus;
        }

        public void CalculateResult()
        {
            this.result = (ExamResult + HomeworkSent + HomeworkEvaluetion + TeamWork + Attendances + Bonus) / 5;
        }

    }
}
