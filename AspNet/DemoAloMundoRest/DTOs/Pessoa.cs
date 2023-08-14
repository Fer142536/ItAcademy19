using System.ComponentModel.DataAnnotations;
namespace DemoAloMundoRest.DTOs;

public class Pessoa{

    public string Nome {get;set;} = null!;
    [Required(ErrorMessage = "Idade é obrigatória")]
    [Range(0,100,ErrorMessage = "Idade deve ser entre 0 e 100")]
    public int? Idade {get;set;}

}