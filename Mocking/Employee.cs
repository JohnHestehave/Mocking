using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
	public class Employee
	{
		public int Id;
		public string Name;
		public string Type;
		public int Wage;

		public MailBox MailBox = new MailBox();

		public Employee()
		{

		}
		public Employee(string Name, string Type, int Id)
		{
			this.Id = Id;
			this.Name = Name;
			this.Type = Type;
		}

		public int CalculateWeeklySalary(int hours, int wage)
		{
			return hours * wage;
		}
	}
}
