using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Repository_Pattern
{
	internal class NewsPaper: IRepository<BookTO>
	{
		public void Create(BookTO entity)
		{
			return;
		}

		public void Delete(BookTO entity)
		{
			return;
		}

		public BookTO Read(Guid id)
		{
			return new BookTO("Dummy book");
		}

		public void Update(BookTO entity)
		{
			return;
		}
	}
}
