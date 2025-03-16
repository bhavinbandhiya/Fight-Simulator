using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi.Dtos.Character
{
    public class GetCharacterDto
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Frodo";
        public int Hitpoints { get;set;} = 100;
        public int Strength { get;set;} = 10;
        public int Defense { get;set;} = 10;
        public int Intelligence { get;set;} = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto? Weapon { get; set; }
    }
}