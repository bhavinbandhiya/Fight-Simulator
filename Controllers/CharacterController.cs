using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
 
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

         [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost("Add")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter){
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut("Update")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacter(UpdateCharacterDto updateCharacter){
            
            var response = await _characterService.UpdateCharacter(updateCharacter);
            if(response.Data is null)
                return NotFound(response);

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> DeleteCharacter(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if(response.Data is null)
                return NotFound(response);

            return Ok();
        }
    }
}