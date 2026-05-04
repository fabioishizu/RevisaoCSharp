using System.Numerics;
using System.Reflection;
using TiposBasicoDeDadosCSharp;
using TiposBasicoDeDadosCSharp.Aulas;

var aulasScript = new List<Aula>();

Assembly.GetAssembly(typeof(Aula)).GetTypes()
    .Where(aula => aula.Namespace == "TiposBasicoDeDadosCSharp.Aulas")
    .ToList()
    .ForEach(item => 
    {
        try
        {
            var aula = (Aula)Activator.CreateInstance(item);
            aulasScript.Add(aula);
            Console.WriteLine($"{aulasScript.IndexOf(aula)} - {aula.titulo}");
        }
        catch
        {
        }
    }
);
Console.WriteLine("Digite o index da aula para executar:");
var input = Console.ReadLine();
Console.Clear();
aulasScript[int.Parse(input)].Executar();

