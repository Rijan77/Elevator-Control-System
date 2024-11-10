using sec_a_desktop_app_started.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_a_desktop_app_started.Controller
{
	internal class ConnectionString : IConnectionString
	{
		public string getConn()
		{
			string connString = @"Server = VA-OZVSMQR3C0GP\MANISH_RESEARCH; Database = testing; Trusted_Connection = True";
			return connString;
		}
	}
}
