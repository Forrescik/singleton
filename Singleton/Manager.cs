using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public interface IManager
	{
		string Test();

	}
	class Manager : IManager
	{
		private static Manager _manage;

		public static Func<IManager> Manage = () => _manage ?? (_manage = new Manager());
		public string Test()
		{
			return "test";
		}
	}
}
