using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public static List<Character> characters = new List<Character>{
            new Character(),
            new Character{ID=1, Name = "Sam"} 
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
           characters.Add(newCharacter);
           return characters;
        }
        public List<Character> GetAllCharacters()
        {
            return characters;
        }
        public Character GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.ID == id);
            if(character is not null)
                return character;

            throw new Exception("Character not found");
        }
    }
}