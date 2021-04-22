using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class AppSetting
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Module { get; set; }
        public bool IsVisibleInCommonSettingPage { get; set; }
        public string Description { get; set; }
    }
}
