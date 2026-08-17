using System.ComponentModel.DataAnnotations;
using TechChallenge.Models;

namespace TechChallenge;

public class Professor
{
    public int Id { get; set; }
    [Required (ErrorMessage = "O campo Nome é obrigatório")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")][Display(Name = "Nome do Professor")] public string Nome { get; set; }
    [Required (ErrorMessage = "O campo Email é obrigatório")][EmailAddress (ErrorMessage = "Insira um enderço de Email válido")] public string Email { get; set; }
    [Required (ErrorMessage = "Insira uma Especialidade")][StringLength(50, ErrorMessage = "A especialidade deve ter entre no máximo 50 caracteres")] public string Especialidade { get; set; }
    [Required (ErrorMessage = "Informe a data de contratação")][Display(Name = "Data de Contratação")][DataType(DataType.Date)] public DateTime DataContratacao { get; set; }
    public bool Ativo { get; set; } = true;
    public ICollection<Projeto>? Projetos { get; set; } = new List<Projeto>();
}