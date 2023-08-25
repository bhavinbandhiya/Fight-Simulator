global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dtos;

namespace WebApi.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public static List<Character> characters = new List<Character>{
            new Character(),
            new Character{ID=1, Name = "Sam"} 
        };
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
           var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
           var character = _mapper.Map<Character>(newCharacter);
           character.ID = characters.Max(c => c.ID) + 1;
           characters.Add(character);
           serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
           return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return  serviceResponse;
        }
        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c => c.ID == id);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return  serviceResponse;
        }
    }
}