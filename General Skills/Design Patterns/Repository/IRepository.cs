using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Repository_Pattern
{
	// Best practise for repository pattern:
	// - implement CRUD operations
	// - One repository pro business object (e.g.BookRepository, PaperRepository...)
	// - Use interface to separate data access from business logi
	// - Use generic type
	internal interface IRepository<T>
	{
		void Create(T entity); // SQL: INSERT, HTTP/REST: POST

		T Read (Guid id); // SQL: SELECT, HTTP/REST: GET

		void Update (T entity); // SQL: UPDATE, HTTP/REST: PUT

		void Delete (T entity); // SQL: DELETE, HTTP/REST: DELETE
	}
}
