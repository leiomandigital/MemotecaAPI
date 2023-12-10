using System.ComponentModel.DataAnnotations;

namespace MemotecaAPI.Data.Dtos;

public class ReadPensamentoDto
{
    public string Conteudo { get; set; }
    public string Autoria { get; set; }
    public string Modelo { get; set; }
    public Boolean Favorito { get; set; }
}
