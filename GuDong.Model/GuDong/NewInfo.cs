using GuDong.Enum.NewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Model.GuDong
{
   public class NewInfo
    {
       public Guid Id { get; set; }
       public string Title { get; set; }
       public string Content { get; set; }
       public int ClickNumber { get; set; }
       public DateTime AddDate { get; set; }
       public bool? IsShow { get; set; }
       public bool? IsTop { get; set; }
       public NewType Type { get; set; }
       public string Image { get; set; }
    }
}
