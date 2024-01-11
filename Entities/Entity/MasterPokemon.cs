using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class MasterPokemon : IEntity
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int PokemonId { get; set; }
    }
}
