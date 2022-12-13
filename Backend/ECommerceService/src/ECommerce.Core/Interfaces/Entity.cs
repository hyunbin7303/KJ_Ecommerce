
using System;

namespace ECommerce.Core.Interfaces
{
    public abstract class Entity<T> where T : IEquatable<T>
    {
        public virtual T Id { get; set; }
    }
}
