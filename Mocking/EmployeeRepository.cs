using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
	public class EmployeeRepository : IEmployeeRepository
	{
		List<Employee> Employees;

		public EmployeeRepository()
		{
			Employees = new List<Employee>();
		}

		public Employee CreateEmployee(string name, string type)
		{
			Employee e = new Employee(name, type, CountEmployees()+1);
			Employees.Add(e);
			return e;
		}
		

		public void SaveEmployee(Employee e)
		{
			
		}

		public Employee LoadEmployee(int id)
		{
			Employee e = Employees[id-1];
			return e;
		}

		public void Clear()
		{
			Employees.Clear();
		}

		public int CountEmployees()
		{
			return Employees.Count();
		}

		public List<Employee> FindAllEmployees()
		{
			return Employees;
		}

		public double AverageWeeklySalary(int hours = 42)
		{
			double num = 0d;
			foreach (Employee e in Employees)
			{
				num += e.CalculateWeeklySalary(hours, e.Wage);
			}
			num /= Employees.Count();
			return num;
		}

	}
}