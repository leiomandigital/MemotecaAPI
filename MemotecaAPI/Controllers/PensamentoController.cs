using AutoMapper;
using MemotecaAPI.Data;
using MemotecaAPI.Data.Dtos;
using MemotecaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemotecaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PensamentoController : ControllerBase
{
    private PensamentoContext _context;
    private IMapper _mapper;

    public PensamentoController(PensamentoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarPensamento([FromBody] CreatePensamentoDto pensamentoDto)
    {
        Pensamento pensamento = _mapper.Map<Pensamento>(pensamentoDto);
        _context.Pensamentos.Add(pensamento);
        _context.SaveChanges();
        return CreatedAtAction(nameof(PensamentoPorId), new { id = pensamento.Id }, pensamento);
    }

    [HttpGet]
    public IEnumerable<ReadPensamentoDto> ListarPensamento()
    {
        return _mapper.Map<List<ReadPensamentoDto>>(_context.Pensamentos);
    }

    [HttpGet("{id}")]
    public IActionResult PensamentoPorId(int id)
    {
       var pensamento = _context.Pensamentos.FirstOrDefault(pensamento => pensamento.Id == id);
        if (pensamento == null) return NotFound("Pensamento não encontrado!");
        var pensamentoDto = _mapper.Map<ReadPensamentoDto>(pensamento);
        return Ok(pensamentoDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaPensamento(int id, [FromBody] UpdatePensamentoDto pensamentoDto)
    {
        var pensamento = _context.Pensamentos.FirstOrDefault(pensamento => pensamento.Id == id);
        if (pensamento == null) return NotFound("Pensamento não encontrado!");
        _mapper.Map(pensamentoDto, pensamento);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaPensamento(int id)
    {
        var pensamento = _context.Pensamentos.FirstOrDefault(pensamento => pensamento.Id == id);
        if (pensamento == null) return NotFound("Pensamento não encontrado!");
        _context.Remove(pensamento);
        _context.SaveChanges();
        return NoContent();
    }
}
