using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public int Damage { get; set; }

        public List<Character>? Characters { get; set; } 
    }
}