using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Cache
{
    // Should I change it to partial class?
    //check this link later for caching implementation : https://github.com/nopSolutions/nopCommerce/blob/develop/src/Libraries/Nop.Core/Caching/CacheKey.cs
    public class CacheKey
    {
        public string Key { get; protected set; }
        public List<string> Prefixes { get; protected set; } = new List<string>();
        public CacheKey(string key, params string[] prefixes)
        {
           
        }
    }
}
