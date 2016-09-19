using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDll.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }

    }
}
