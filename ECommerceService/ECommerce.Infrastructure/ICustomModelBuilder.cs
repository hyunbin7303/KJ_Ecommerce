using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure
{
    public interface ICustomModelBuilder
    {
        void BuildModel(ModelBuilder mb);
    }
}
