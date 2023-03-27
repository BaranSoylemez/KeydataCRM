using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public int QuoteID { get; set; }
        public virtual Quote Quote { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public bool ProjectStatus { get; set; }
    }
}
