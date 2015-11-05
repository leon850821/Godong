using System; 
using System.Web;

namespace GuDong.Web.Models.ModuleList
{
    public class ModuleAddModel
    {
        public Guid Id { get; set; }

        public string ModuleName { get; set; }

        public string Controller { get; set; }
        public string Action { get; set; }

        public string EditController { get; set; }

        public string EditAction { get; set; }

        public Guid MainModuleId { get; set; }

        public DateTime AddDate { get; set; }
    }
}