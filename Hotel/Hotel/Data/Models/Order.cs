using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Ввидите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "длина имени не больше 25 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "длина Фамилию не больше 25 символов")]
        public string surname { get; set; }

        [Display(Name = "дата Вьезда")]
        [StringLength(35)]
        [Required(ErrorMessage = "длина Адрес не больше 35 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = " Номер телефона не больше 20 цифр")]
        public string phone { get; set; }

        [Display(Name = "email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "длина email не больше 30 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
