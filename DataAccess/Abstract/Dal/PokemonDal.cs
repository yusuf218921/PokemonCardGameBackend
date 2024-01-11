using Core.DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Dal
{
    public interface PokemonDal : IEntityRepository<Pokemon>
    {
    }
}
