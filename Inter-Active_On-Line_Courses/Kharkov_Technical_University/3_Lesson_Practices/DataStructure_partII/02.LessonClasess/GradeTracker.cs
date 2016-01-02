using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public interface IGradeTracker
    {
          void AddGrade(float grade);
          GradeStatistics ComputeStatistics();
          void WriteGrades(TextWriter textWriter);

          string Name
          {
              get;
              set;
          }

           event NamedChangedDelegate NameChanged;
           void DoSomething();
    }



    public abstract class GradeTracker : IGradeTracker 
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter textWriter);

        public void DoSomething()
        {
            
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be empty or Null!");
                }
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }

                }

            }
        }

        public event NamedChangedDelegate NameChanged;
    }
}
