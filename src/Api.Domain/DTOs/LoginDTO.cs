using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs
{
  public class LoginDTO
  {
    [Required(ErrorMessage = "Email é obrigatório para o Login")]
    [EmailAddress(ErrorMessage = "Formato de email inválido")]
    [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
    public string Email { get; set; }
  }
}
