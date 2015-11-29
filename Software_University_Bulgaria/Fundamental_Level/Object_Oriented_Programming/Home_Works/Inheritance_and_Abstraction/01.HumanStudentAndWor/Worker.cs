
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWor
{
    class Worker : Human
    {

        private const int WEEKLYWORKDAYS = 5;
        public decimal weekSalary;
        public double workHoursPerDay;

        public Worker(string firstName, string lastName, double workHoursPerDay,decimal salaryPerWeek)
            : base(firstName,lastName)
        {
            this.weekSalary = salaryPerWeek;
            this.workHoursPerDay = workHoursPerDay;

        }

        public decimal WeekSalary  
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0 )
        	    {
		        throw new ArgumentOutOfRangeException("Incorrect!");
	            }
                
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay 
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0 || value > 24)
	            {
		            throw new ArgumentOutOfRangeException("Incorrect! ");
	            }
                
                this.workHoursPerDay = value;
            }
        }


        public decimal MoneyPerHour()
        {
            if (this.workHoursPerDay == 0)
	        {
		        return 0;
	        }

            double workHoursPerWeek = WEEKLYWORKDAYS * this.WorkHoursPerDay; 
            decimal hourSalary = this.WeekSalary / (decimal) workHoursPerWeek;

            return hourSalary;
        }

        public override string ToString()
        {

            string result = base.ToString();
            result = result + string.Format(
                "\nWeek salary: {0}\nWorked hours per day: {1}\nHourly Salary: {2}\n",
                this.weekSalary,
                this.workHoursPerDay,
                this.MoneyPerHour());

            return result;
        }

    }
}
