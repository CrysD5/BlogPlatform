using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        public BlogContext db;

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }




        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
