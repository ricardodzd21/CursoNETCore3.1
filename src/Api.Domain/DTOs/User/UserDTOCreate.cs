using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
  public class UserDTOCreate
  {
    [Required(ErrorMessage = "Nome é Obrigadtório")]
    [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email é obrigatório para o Login")]
    [EmailAddress(ErrorMessage = "Formato de email inválido")]
    [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
    public string Email { get; set; }
  }
}


