using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mocking
{
	enum Rights
	{
		None,
		Full
	}
	public class User
	{
		internal Rights Rights;
		public string Password;
		public string UserName;
		public int NumMessagesCreated;

		public User()
		{
		}
		public string ViewAllEmployees()
		{
			return "Here is the list";
		}

		public void EditEmployeeName(Employee e, string newname)
		{
			if(this.Rights == Rights.Full)
			{
				e.Name = newname;
			}else
			{
				throw new Exception("You do not have the rights to do that!");
			}
		}

		public void EditEmployeeWage(Employee e, int newwage)
		{
			e.Wage = newwage;
		}

	}
}