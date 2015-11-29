using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.CompanyHierarchy.Classes
{
    class Developer
    {
        private int p1;
        private string p2;
        private string p3;
        private Departments departments;
        private int p4;
        private Projects.Project project;

        public Developer(int p1, string p2, string p3, Departments departments, int p4, Projects.Project project)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.departments = departments;
            this.p4 = p4;
            this.project = project;
        }
    }
}
