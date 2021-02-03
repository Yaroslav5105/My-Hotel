using Hotel.Data.Models;
using Hotel.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.mocks
{
    public class MockCategory : IRoomCategory {
        public IEnumerable<category> Allcategories {
            get {
                return new List<category>
                {
                    new category { categoryName = "Вип номер" ,  desc = "почуствую комфорт и наслождение" } ,
                    new category { categoryName = "Стандарт" ,  desc = "есть всё чтоб отдохнуть с удобством" }
                };
            }
        }
    }
}
