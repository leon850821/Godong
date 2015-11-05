using System;
using System.Collections.Generic;
using System.Text; 
//using System.ComponentModel.DataAnnotations.Schema;

namespace GuDong.Model.GuDong
{
   public   class ModuleList
    {
       public Guid Id { get; set; }

       public string ModuleName { get; set; }

       public string Controller { get; set; }
       public string Action { get; set; }

       public string EditController { get; set; }

       public string EditAction { get; set; }

       public DateTime AddDate { get; set; }

      // [ForeignKey("MainModule")]
       public Guid MainModuleId { get; set; }


       public virtual MainModule MainModule { get; set; }
    }
}
