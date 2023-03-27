using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }
        public string QuoteDate { get; set; }
        public string QuoteDesc { get; set; }
        public double QuotePrice { get; set; }
        public string QuoteCurrency { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
