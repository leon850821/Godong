using GuDong.Enum.CodeRecord;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class CodeRecord
    {
        public Guid Id { get; set; }
        public CodeRecordStatus Status { get; set; }
        public string Code { get; set; }
        public System.DateTime AddDate { get; set; }
        public CodeRecordType Type { get; set; }
        public string ToNumber { get; set; }
    }
}
