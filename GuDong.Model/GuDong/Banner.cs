using GuDong.Enum.Banner;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class Banner
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public BannerType Type { get; set; }
        public string LinkUrl { get; set; }
        public string Image { get; set; }
        public int Sort { get; set; }
        public System.DateTime AddTime { get; set; }
    }
}
