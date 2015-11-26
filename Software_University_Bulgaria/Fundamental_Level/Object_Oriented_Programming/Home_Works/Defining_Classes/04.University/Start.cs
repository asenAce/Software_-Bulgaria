using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.University
{
    class Start
    {
        static void Main(string[] args)
        {
            Trainer mrSmith = new JuniorTrainer("Jhone","Smith",20);
            Trainer mrTonny = new JuniorTrainer("Tonny", "Tonny", 25);

            Trainer mrDonBrasco = new SeniorTrainer("Lucka","Brasco",47);
            Trainer mrDonCorleone = new SeniorTrainer("Don","Corleone",55);
            Trainer mrAlCapone = new SeniorTrainer("Capo di tuti Capi", "Capone", 50);

            Student Jhonny = new GraduateStudent("Jhonny","mcCuby",80500509,(float)5.78, 34);
            Student Tonny = new GraduateStudent("Tonny", "Pit", 80500600,(float)5.33,30);
            Student Androw = new GraduateStudent("Androw", "McPigen", 80500700, (float)6.00, 36);

            Student Jaque = new DropoutStudent("Jaque", "McDonnovan", 80500900,(float)6.00,"a gay");
            Student Phill = new DropoutStudent("Phill", "Rosse", 80500300,(float)3.34,"a repist");
            Student Delinger = new DropoutStudent("Delinger", "Diligent", 80500200,(float)3.55,"a ugly bastard / stupid bastard");

            CurrentStudent Tomm = new OnLineStudent("Tomm", "Cruise", 80500100,(float)3.66,30);
            CurrentStudent Stive = new OnSiteStudent("Stive", "Hudson", 80500222,(float)3.22);

            List<Person> persons = new List<Person>()
            {
                mrSmith,mrTonny,mrDonBrasco,mrDonCorleone,mrAlCapone,Jhonny,Tonny,Androw,Jaque,Phill,Delinger,Tomm,Stive
            };

            Stive.CurrentCourses.Add("Java");
            persons.Where(p => p is CurrentStudent).OrderBy(p => ((Student)p).AverageGrade).ToList()
                .ForEach(p =>Console.WriteLine(p.ToString()));

        }
    }
}
