using System.ComponentModel.DataAnnotations;

namespace TechChallenge.Models;
public class Equipe
{
    public int Id { get; set; }
    [Required (ErrorMessage = "Insira um nome para a equipe")][StringLength(50, ErrorMessage = "O nome da equipe tem que ter no máximo 50 caracteres")][Display(Name = "Nome da Equipe")] public string Nome { get; set; }
    [StringLength(200, ErrorMessage = "A descrição só pode ter no máximo 200 caracteres")][Display(Name = "Descrição")] public string? Descricao { get; set; }
    [Display(Name = "Data da Criação")]public DateTime DataCriacao { get; set; } = DateTime.Now;
    public bool Ativa { get; set; } = true;
    public ICollection<AlunoEquipe> AlunosEquipes { get; set; } = new List<AlunoEquipe>();
    public ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}