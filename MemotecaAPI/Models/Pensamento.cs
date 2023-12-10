using System.ComponentModel.DataAnnotations;

namespace MemotecaAPI.Models;

public class Pensamento
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Campo conteúdo é obrigatório!")]
    public string Conteudo { get; set; }
    [Required(ErrorMessage = "Campo autoria é obrigatório!")]
    public string Autoria { get; set; }
    [Required]
    public string Modelo { get; set; }
    [Required]
    public Boolean Favorito { get; set; }
    public DateTime Data { get; set; }

}
