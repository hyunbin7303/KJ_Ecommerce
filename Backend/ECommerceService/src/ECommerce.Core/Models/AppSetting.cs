using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class AppSetting : Entity<string>
    {
        public string Value { get; set; }
        public string Module { get; set; }
        public bool IsVisibleInCommonSettingPage { get; set; }
        public string Description { get; set; }
    }
}
