using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Repository_Pattern
{
	internal class NewspaperRepository : IRepository<NewspaperTO>
	{
		public void Create(NewspaperTO entity) { /* TODO: implement */ }

		public void Delete(NewspaperTO entity) { /* TODO: implement */ }

		public NewspaperTO Read(Guid id) { /* TODO: implement */ return new NewspaperTO("Dummy name"); }
		
		public void Update(NewspaperTO entity) { /* TODO: implement */ }
	}
}
