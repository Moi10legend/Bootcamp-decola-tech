using Projeto_curso_intermediário.Models;
using System.Globalization;


// // Coloca o encoding para UTF8 para exibir acentuação
// Console.OutputEncoding = System.Text.Encoding.UTF8;

// decimal precoInicial = 0;
// decimal precoPorHora = 0;

// Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
//                   "Digite o preço inicial:");
// precoInicial = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine("Agora digite o preço por hora:");
// precoPorHora = Convert.ToDecimal(Console.ReadLine());

// // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
// Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// string opcao = string.Empty;
// bool exibirMenu = true;

// // Realiza o loop do menu
// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar veículo");
//     Console.WriteLine("2 - Remover veículo");
//     Console.WriteLine("3 - Listar veículos");
//     Console.WriteLine("4 - Encerrar");

//     switch (Console.ReadLine())
//     {
//         case "1":
//             es.AdicionarVeiculo();
//             break;

//         case "2":
//             es.RemoverVeiculo();
//             break;

//         case "3":
//             es.ListarVeiculos();
//             break;

//         case "4":
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

//     Console.WriteLine("Pressione uma tecla para continuar");
//     Console.ReadLine();
// }

// Console.WriteLine("O programa se encerrou");














// Dictionary<string, string> estados = new Dictionary<string, string>();//Criando um dictionary

// estados.Add("PE", "Pernambuco"); //Adicionando elementos no Dictionary
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("SC", "Santa Catarina");

// Console.WriteLine(estados["SC"]);//Vendo o valor de uma chave

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
// }

// estados.Remove("RJ"); //Removendo um elemento do dictionary atráves da chave
// estados["SC"] = "Santa Catarina valor alterado"; //Alterandoum valor de um elemento

// string chave = "BA";
// Console.WriteLine($"Verificando se há o elemento: {chave}");

// if(estados.ContainsKey(chave)) //Verificando se uma chave ja foi adicionada
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else{
//     Console.WriteLine($"Valor não existente: {chave}");
// }











// Stack<int> pilha = new Stack<int>(); //Criando uma pilha

// pilha.Push(10); //Adicionando elementos na pilha
// pilha.Push(11); 
// pilha.Push(7);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}"); //Removendo o elemento do topo da pilha










// Queue<int> fila = new Queue<int>(); //Criando fila

// fila.Enqueue(10);//Adicionando elemento ao fim da fila
// fila.Enqueue(7);
// fila.Enqueue(11);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Eliminando o elemento: {fila.Dequeue()}");//Eliminando o primeiro elemento da fila










// try//Tratando uma excessão que pode ocorrer na linha 6, caso o arquivo não exista.
// {
// string[] linhas = File.ReadAllLines("Arquivos/Arquivoleitura.txt"); //Leitura do arquivo "Arquivoleitura"


// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// }catch(FileNotFoundException ex)//Pegar uma exceção, exceção especifica de não encontrar arquivo
// {
// Console.WriteLine($"Ocorreu uma exceção na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)//Pegar uma exceção de pasta não encontrada
// {
// Console.WriteLine($"Ocorreu uma exceção na leitura do diretório. Pasta não encontrada {ex.Message}");
// }
// catch(Exception ex)//Pegar uma exceção genérica
// {
// Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
// }
// finally//Serve para executar um bloco de código independente se houve uma exceção ou não
// {
// Console.WriteLine("Chegou até aqui");
// }









// string dataString = "28/12/2023 10:11";
// bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data );//Convertendo strig para data de forma segura
// //DateTime data = DateTime.Parse("28/12/2023 10:11");//Convertendo uma string para data
// //DateTime data = DateTime.Now;

// if (sucesso){
//     Console.WriteLine($"Conversão realizada com sucesso! Data: {data}");
// }
// else{
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);
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