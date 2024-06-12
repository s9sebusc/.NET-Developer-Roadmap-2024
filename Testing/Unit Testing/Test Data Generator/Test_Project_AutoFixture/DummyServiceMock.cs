using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_AutoFixture
{
	public class DummyServiceMock : IDummyService
	{
		public void DummyMethod()
		{
			throw new NotImplementedException();
		}
	}
}
