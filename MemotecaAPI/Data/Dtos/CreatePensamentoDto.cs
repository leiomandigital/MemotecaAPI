using System.ComponentModel.DataAnnotations;

namespace MemotecaAPI.Data.Dtos;

public class CreatePensamentoDto
{
    [Required(ErrorMessage = "Campo CONTEÚDO é obrigatório!")]
    public string Conteudo { get; set; }
    [Required(ErrorMessage = "Campo AUTORIA é obrigatório!")]
    public string Autoria { get; set; }
    [Required(ErrorMessage = "Campo MODELO é obrigatório!")]
    public string Modelo { get; set; }
    [Required(ErrorMessage = "Campo FAVORITO é obrigatório!")]
    public Boolean Favorito { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;
}
