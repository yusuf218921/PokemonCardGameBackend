using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Pokemon : IEntity
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int LevelId { get; set; }
        public int SpecialAbilityId { get; set; }
        public string PokemonName { get; set; } = null!;
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public int Exp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spd { get; set; }
        public int Hp { get; set; }
        public float catchRate { get; set; }
    }
}
