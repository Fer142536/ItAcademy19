using Microsoft.AspNetCore.Mvc;
using DemoAloMundoRest.DTOs;

namespace DemoAloMundoRest.Controllers;


[ApiController]
[Route("[controller]")]

public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;
    
    // PONTO DE INJEÇÃO
        public AloMundoController(ILogger<AloMundoController> logger){

            _logger = logger;
        }

    // GET .../alomundo   
    [HttpGet]   
    public string Get()
    {
        _logger.LogInformation("GET /alomundo");
        return "Alo, Mundo!";
    } 
    //GET .../alomundo/fernanda

    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation("GET /alomundo/{nome}");
        return $"Alo, {nome}!";
    }

    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation("GET /alomundo/query?nome=valor");
        return $"Alo, {nome}!";
    }
    //POST .../alomundo
    [HttpPost]
    public string Post([FromBody] string nome)
    {
     _logger.LogInformation("POST /alomundo");
    return $"Alo, {nome}!";
    }

    //POST .../alomundo/pessoa
    [HttpPost("pessoa")]
    public string Post(Pessoa umaPessoa)
    {
     _logger.LogInformation("POST /alomundo/pessoa");
     _logger.LogInformation($"umaPessoa.nome = {umaPessoa.Nome}");
     _logger.LogInformation($"umaPessoa.idade = {umaPessoa.Idade}");
    return $"Alo, {umaPessoa.Nome}!";
    }


}