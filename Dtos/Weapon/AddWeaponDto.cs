using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class AddWeaponDto
    {
        public string Name { get; set; } = String.Empty;
        public int Damage { get; set; }
        public int CharacterId { get; set; }
    }
}