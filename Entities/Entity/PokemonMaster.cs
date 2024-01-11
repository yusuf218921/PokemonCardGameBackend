using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class PokemonMaster : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public String FirstName { get; set; } = null!;
        public String LastName { get; set; } = null!;
        public int Rank { get; set; }
        public int Gold { get; set; }

    }
}
