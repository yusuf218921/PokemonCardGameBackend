using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class StrongType : IEntity
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int StrongTypeId { get; set; }
    }
}
