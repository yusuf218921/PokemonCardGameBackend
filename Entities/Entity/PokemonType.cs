using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class PokemonType : IEntity
    {
        public int Id { get; set; }
        public String Type { get; set; } = null!;
    }
}
