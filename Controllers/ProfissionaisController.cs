using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Plataforma.Backend_.DTOs;
using Plataforma.Backend_.Models;

[ApiController]
[Route("api/[controller]")]
public class ProfissionaisController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IValidator<CriarProfissionalDto> _validator;
    private static readonly List<Profissional> _profissionais = new();

    public ProfissionaisController(IMapper mapper, IValidator<CriarProfissionalDto> validator)
    {
        _mapper = mapper;
        _validator = validator;
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarProfissionalDto profissionalDto)
    {
        var validation = await _validator.ValidateAsync(profissionalDto);
        if (!validation.IsValid)
        {
            return BadRequest(validation.Errors);
        }
        
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        _profissionais.Add(profissional);
        return Ok(profissional);
    }

    [HttpGet]
    public IActionResult ObterTodos() {
        return Ok(_profissionais);
    }
}