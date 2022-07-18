using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class TypeHoliday
    {
        public int Id { get; set; }
        public string HoliName { get; set; }
        public int Balances { get; set; }
        public string Renewal { get; set; }
        public string DaysNotDeducted { get; set; }
        public int NoMoreThan { get; set; }
        public string Symbol { get; set; }

        /*public int BalanceId { get; set; }
        public Balance Balance { get; set; }*/
        public ICollection<Holidays> Holiday { get; set; }
        public class TypeHolidayProvider
        {
            public List<TypeHoliday> GetTypeHolidays()
            {
                List<TypeHoliday> typeHolidays = new List<TypeHoliday>();
                typeHolidays.Add(new TypeHoliday { Id = 0, Renewal = " لاتجديد" });
                typeHolidays.Add(new TypeHoliday { Id = 1, Renewal = "  سنويا" });
                typeHolidays.Add(new TypeHoliday { Id = 2, Renewal = "مفتوح " });
                //typeHolidays.Add(new TypeHoliday { Id = 3, Renewal = " اعفاء مرض كبار السن" });
                //typeHolidays.Add(new TypeHoliday { Id = 4, Renewal = " عدم قبول البصمة" });
                //typeHolidays.Add(new TypeHoliday { Id = 5, Renewal = " اذن خروج" });
               
                return typeHolidays;
            }
        }
    }
}
