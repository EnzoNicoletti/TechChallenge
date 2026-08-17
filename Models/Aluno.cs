using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class Aluno
{
    [Required (ErrorMessage = "O campo ID é obrigatório")]public int Id { get; set; } // Primary Key
    [Required (ErrorMessage = "O campo Nome é obrigatório")][StringLength(100, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")][Display(Name = "Nome do Aluno")]public string Nome { get; set; }
    [EmailAddress (ErrorMessage = "Insira um enderço de Email válido")]public string Email { get; set; }
    [Required (ErrorMessage = "Informe o Telefone do aluno")]public string Telefone { get; set; }
    [Required (ErrorMessage = "Insira a data de nascimento do aluno")] public DateTime DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public bool Ativo { get; set; }
}
