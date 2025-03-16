using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Damage { get; set; }
        public Character? Character { get; set; } = null!;
        public int CharacterId { get; set; }
    }
}