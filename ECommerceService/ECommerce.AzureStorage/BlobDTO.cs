using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.AzureStorage
{
    public enum ContentType
    {
    }
    public class BlobDTO
    {
        public byte[] Content { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ContentType ContentType { get; set; }
        public override string ToString()
        {
            return $"{Name},{Url}";
        }
    }
}
