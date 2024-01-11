using Core.Entities.Concrete;
using Core.Entities.Concrete.Entity;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore.Context
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Pokemon>? Pokemons { get; set; } 
        public DbSet<MasterPokemon>? MasterPokemons { get; set; }
        public DbSet<PokemonMaster>? PokemonMasters { get; set; }
        public DbSet<PokemonType>? PokemonTypes { get; set; }
        public DbSet<Level>? Levels { get; set; }
        public DbSet<StrongType>? StrongTypes { get; set; }
        public DbSet<WeakType>? WeakTypes { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }
        public DbSet<OperationClaim>? OperationClaims { get; set; }
        public DbSet<SpecialAbility>? SpecialAbilities { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }



    }
}
