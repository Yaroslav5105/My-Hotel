
using Hotel.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            
            
            if (!content.Room.Any())
            {
                content.AddRange(
                    new room
                    {
                        name = "STANDARD KING 1",
                        shortDesc = "Вместимость до 3 мест",
                        LongDEsc = "Standard King – однокомнатный номер, интерьер выполнен в современном стиле, площадь — 24 м2, в номере кровать King size. Атмосфера номера прекрасно подходит для отдыха и работы.",
                        img = "/img/1.jpg",
                        price = 1500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Стандарт"]
                    },
                    new room
                    {
                        name = "STANDARD TWIN ",
                        shortDesc = "Вместимость до 3 мест",
                        LongDEsc = "Standard Twin — однокомнатный номер выполнен в современном стиле, площадь — 26 м2, номер с двумя раздельными кроватями Twin. Идеально подходит для проживания коллег по работе и семей со взрослыми детьми.",
                        img = "/img/2.jpg",
                        price = 1600,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Стандарт"]                 },
                     new room
                     {
                         name = "JUNIOR SUITE ",
                         shortDesc = "Вместимость до 3 мест",
                         LongDEsc = "Junior Suite — однокомнатный номер с площадью 42 м2. Номер выполнен в современном европейском стиле, состоит из уютной спальни и просторной ванной комнаты. В номере кровать King size. Диван в гостиной может трансформироваться в дополнительное спальное место. Выразительный, четко зонированый интерьер и комфортабельная мебель, лучший вариант для гостей, пребывающих в долгосрочной командировке и небольших семей.",
                         img = "/img/3.jpg",
                         price = 1800,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Стандарт"]
                     },
                     new room
                     {
                         name = "SUITE ",
                         shortDesc = "Вместимость до 4 мест",
                         LongDEsc = "Это просторный двухкомнатный номер площадью 54 м2/. Дизайн номера выполнен в современном стиле. Диван в гостиной трансформируется в дополнительное спальное место. Интерьер номера выполнен в пастельных тонах.",
                         img = "/img/4.jpg",
                         price = 2500,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Вип номер"]
                     },
                     new room
                     {
                         name = "EXECUTIVE SUITE ",
                         shortDesc = "Вместимость до 4 мест",
                         LongDEsc = "Дизайн номера категории «Executive Suite» выполнен в современном стиле, номер повышенной комфортности. Площадь — 65 м2, состоит из спальни и гостиной. Диван в гостиной трансформируется в дополнительное спальное место. Интерьер номера не оставит равнодушными самых активных посетителей гостиниц. У нас Вы почувствуете себя лучше, чем дома.",
                         img = "/img/33.jpg",
                         price = 2700,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Вип номер"]
                     },
                     new room
                     {
                         name = "APARTMENT ",
                         shortDesc = "Вместимость до 4 мест",
                         LongDEsc = " Apartment — площадь номера — 100 м2, состоит из спальни и гостиной. Гармоничное, архитектурное решение придает каждому помещению свой характер и эксклюзивность. Диван гостиной может трансформироваться в дополнительное спальное место. Максимально комфортные апартаменты подойдут не только для проживания, но и проведения различного рода встреч, переговоров, свадебных и других небольших знаменательных дат и событий.",
                         img = "/img/6.jpg",
                         price = 4700,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Вип номер"]
                     }
                    );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, category> category;
        public static Dictionary<string, category> Categories{
           get {
               if(category == null)
                {
                    var list = new category[]
                    {
                         new category { categoryName = "Вип номер" ,  desc = "почуствую комфорт и наслождение" } ,
                         new category { categoryName = "Стандарт" ,  desc = "есть всё чтоб отдохнуть с удобством" }

                    };
                    category = new Dictionary<string, category>();
                    foreach (category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
           }
        }

    }
}
