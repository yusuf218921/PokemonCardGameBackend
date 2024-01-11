using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract.Dal;
using DataAccess.Concrete.EfCore.Context;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore.EfDal
{
    public class EfPokemonDal : EfEntityRepositoryBase<Pokemon, RepositoryContext>, PokemonDal
    {
        public EfPokemonDal(RepositoryContext context) : base(context)
        {
        }
    }
}
