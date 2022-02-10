using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example10_Indexer
{
    class Company
    {

        public string CompanyName { get; private set; }

        private System.Collections.ArrayList theEmployees { get; set; }

        private int counter;


        public Company( string name )
        {
            this.theEmployees = null;               
            this.counter = 0;
            CompanyName = name;
        }


        // Indexer
        public Employee this[string name]
        {
            get
            {
                Employee empFound = null;

                foreach(Employee emp in theEmployees)
                {
                    if( emp.EmployeeName == name)
                    {
                        empFound = emp;
                        break;
                    }
                }

                return empFound;
            }
        }
        
        // Indexer
        public Employee this[int id]
        {
            get
            {
                Employee empFound = null;

                foreach(Employee emp in theEmployees)
                {
                    if(emp.EmployeeID == id)
                    {
                        empFound = emp;
                        break;
                    }
                }

                return empFound;
            }
        }

        

        public void AddEmployee(string nameOfNewEmployee)
        {
            Employee emp = new Employee();
            emp.EmployeeID = ++this.counter;
            emp.EmployeeName = nameOfNewEmployee;

            // 2. check collection is still NULL
            if(theEmployees == null)
            {
                // 3. instantiate the collection
                theEmployees = new System.Collections.ArrayList();
            }

            // 4. add the newly created employee object to the collection.
            theEmployees.Add(emp);
        }


        public void DisplayEmployees()
        {
            foreach( Employee emp in theEmployees)
            {
                Console.WriteLine("{0} {1}", emp.EmployeeID, emp.EmployeeName);
            }
        }
    }
}
