Console.WriteLine("Iniciando conexão BD");


using(var context= new TarefaContext())
{
    // Add adiciona em mémória 
    Console.WriteLine("Inserindo dados");
    context.Tarefas.Add(new Tarefa{
        Nome = "Estudar .NET",
        Descricao = "Ler Material",
        Completada= false

    });
    context.Tarefas.Add(new Tarefa{
        Nome = "Lavar Louça",
        Completada= true
    });
    // add  os novos dados para o banco
    context.SaveChanges();

    Console.WriteLine("Consultar Dados:");
    var todasTarefas = context.Tarefas.ToList();
    todasTarefas.ForEach(t => Console.WriteLine($"Id={t.Id} Nome={t.Nome} Descricao{t.Descricao}"));

// Mudou para true 
   Console.WriteLine("Aletar Dados");
   var umaTarefa = context.Tarefas.Find(1L);
   if (umaTarefa !=null)
   {
        umaTarefa.Completada = true;
    }
    context.SaveChanges();
    todasTarefas = context.Tarefas.ToList();
    todasTarefas.ForEach(t => Console.WriteLine($"Id={t.Id} Nome={t.Nome} Descricao{t.Descricao}"));


    Console.WriteLine("Removendo Dados");
    umaTarefa = context.Tarefas.Find(2L);
    if (umaTarefa !=null)
   {
        context.Tarefas.Remove(umaTarefa);
    }
    context.SaveChanges();
    todasTarefas = context.Tarefas.ToList();
    todasTarefas.ForEach(t => Console.WriteLine($"Id={t.Id} Nome={t.Nome} Descricao{t.Descricao}"));
}
Console.WriteLine("Fim");


