using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFClass
{
    public class Patent
    {
        public string Code { get; set; } = "000-0000000-000";
        public string Title { get; set; } = "Патент";
        public DateTime date { get; set; } = DateTime.Now;
        public string Description { get; set; } = "";
        public string Author { get; set; } = "Иванов Иван";
    }
}
