using System.ComponentModel.DataAnnotations;

namespace TechChallenge.Models;

public class Projeto
{
    public int Id { get; set; }
    [Required (ErrorMessage = "O campo Nome é obrigatório")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")] public string Nome { get; set; }
    [StringLength(500, ErrorMessage = "A descrição só pode ter no máximo 500 caracteres")][Display(Name = "Descrição")] public string? Descricao { get; set; }
    [Required (ErrorMessage = "Indique a data de início")][DataType(DataType.Date)][Display(Name = "Início do projeto")] public DateTime DataInicio { get; set; }
    [Required (ErrorMessage = "Informe a data de finalização")][DataType(DataType.Date)][Display(Name = "Finalização do projeto")] public DateTime? DataFim { get; set; }
    [Required (ErrorMessage = "Defina a pontuação")][Display(Name = "Pontuação")]public int Pontuacao { get; set; }
    public int ProfessorId { get; set; }
    public int CategoriaId { get; set; }
    public int EquipeId { get; set; }
    public Professor? Professor { get; set; }
    public Categoria? Categoria { get; set; }
    public Equipe? Equipe { get; set; }
}