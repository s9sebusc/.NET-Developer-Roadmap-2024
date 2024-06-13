using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Repository_Pattern
{
	internal class BookService
	{
		private readonly IRepository<BookTO> _bookRepository;

		public BookService(IRepository<BookTO> bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public void CreateBook(BookTO newBook)
		{
			_bookRepository.Create(newBook);
		}
	}
}
