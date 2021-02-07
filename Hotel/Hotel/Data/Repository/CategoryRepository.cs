using Hotel.Data.Models;
using Hotel.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Repository
{
    public class CategoryRepository : IRoomCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<category> Allcategories => appDBContent.Category;
    }
}
