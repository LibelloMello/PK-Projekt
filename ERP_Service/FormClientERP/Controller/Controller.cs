using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormClientERP.WebServiceReference;

namespace FormClientERP
{
    class Controller
    {
        WebServiceERP ws = new WebServiceERP();

        //A
        public string[][] AllEmployees()
        {
            return ws.GetAllEmployees();
        }
        public string[][] Relatives()
        {
            return ws.GetAllEmployeesRelatives();
        }
        public string[][] Sick2004()
        {
            return ws.GetAllSickEmployees2004();
        }
        public string [][] MostAbscence()
        {
            return ws.GetEmployeeWithMostAbsence();
        }
        public string[][] EmployeeKeys()
        {
            return ws.GetEmployeeKeys();
        }
        public string[][] EmployeeConstraints()
        {
            return ws.GetEmployeeConstraints();
        }
        public string[][] EmployeeIndexes()
        {
            return ws.GetEmployeeIndexes();
        }

        //B
        public string[][] Keys()
        {
            return ws.GetCronusKeys();
        }
        public string[][] Indexes()
        {
            return ws.GetCronusIndexes();
        }
        public string[][] TableConstraints()
        {
            return ws.GetCronusTableConstraints();
        }
        public string[][] Tables1()
        {
            return ws.GetCronusTables();
        }
        public string[][] Tables2()
        {
            return ws.GetCronusTables1();
        }
        public string[][] EmployeeColumns1()
        {
            return ws.GetCronusEmployeeColumns();
        }
        public string[][] EmployeeColumns2()
        {
            return ws.GetCronusEmployeeColumns1();
        }

        //Add, Update and Remove
        public void AddEmployee(string id, string name)
        {
            ws.AddEmployee(id, name);
        }
        public void DeleteEmployee(string id)
        {
            ws.DeleteEmployee(id);
        }
        public void UpdateEmployee(string id, string name)
        {
            ws.UpdateEmployee(id, name);
        }
    }
}
