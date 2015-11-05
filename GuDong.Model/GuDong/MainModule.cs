using System;
using System.Collections.Generic; 

namespace GuDong.Model.GuDong
{
  public    class MainModule
    {
        public Guid Id { get; set; }
        public string ModuleName { get; set; }
        public string Controller { get; set; } 
        public string EditController { get; set; }
        public DateTime AddDate { get; set; }
        public virtual ICollection<ModuleList> ModuleList { get; set; }
       
    }
}
