using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class AppMenu : Entity<string>
    {
        public string UsedBy { get; set; }
        public string ParentId { get; set; }
        public string MenuName { get; set; }
        public string MenuType { get; set; }
        public string Visibility { get; set; }
        public string Availability { get; set; }
        public DateTimeOffset? LatestUpdatedDate { get; set; }
        public string Description { get; set; }
    }
}
