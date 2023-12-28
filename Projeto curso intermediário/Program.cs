using Projeto_curso_intermediário.Models;
using System.Globalization;


string dataString = "28/12/2023 10:11";
bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data );//Convertendo strig para data de forma segura
//DateTime data = DateTime.Parse("28/12/2023 10:11");//Convertendo uma string para data
//DateTime data = DateTime.Now;

if (sucesso){
    Console.WriteLine($"Conversão realizada com sucesso! Data: {data}");
}
else{
    Console.WriteLine($"{dataString} não é uma data válida");
}

Console.WriteLine(data);
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));












// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//colocando uma nova cultura para podermos definir o tipo da moeda de forma geral no código

// decimal dinheiro = 1578500M;
// double porcentagem = .3421;


// Console.WriteLine(porcentagem.ToString("P2"));
// Console.WriteLine(dinheiro.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//Formatando valor monetário 















// Pessoa p1 = new Pessoa("Júlia", "Vitória");
// Pessoa p2 = new Pessoa("Moisés", "Freire");


// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "WiseUp";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();