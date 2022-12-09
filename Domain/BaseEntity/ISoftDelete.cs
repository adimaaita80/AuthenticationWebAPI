using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BaseEntity
{
    public interface ISoftDelete
    {
        public bool IsSoftDeleted { get; set; }
    }
}
