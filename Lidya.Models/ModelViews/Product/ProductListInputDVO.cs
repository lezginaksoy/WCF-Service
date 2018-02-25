using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Models.ModelViews
{
    public class ProductListInputDVO:InputBase
    {
        public int CurrentPage { get; set; }
        
        public int PageSize { get; set; }
		
		public decimal SupplierId { get; set; }
    }
}
