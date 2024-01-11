using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Level : IEntity
    {
        public int Id { get; set; }
        public int PokemonLevel { get; set; }
        public int maxExp { get; set; }
    }
}
