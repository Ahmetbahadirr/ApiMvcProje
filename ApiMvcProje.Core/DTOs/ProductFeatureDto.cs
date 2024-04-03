using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMvcProje.Core.DTOs
{
    public class ProductFeatureDto
    {
        public int id { get; set; }
        public string color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }
    }
}
