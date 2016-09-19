using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDll.Entities
{
    public class Order : AbstractEntity
    {
        public List<Movie> Movies { get; set; }
        public Customer Customer { get; set; }

    }
}
