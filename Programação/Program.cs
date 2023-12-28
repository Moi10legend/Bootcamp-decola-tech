using System.Data.Common;
using System.Net.Mail;
using Programacao.Models;
using Bootcamp_decola_tech.Models;















// //Criando listas
// List<string> listaEstados = new List<string>();

// listaEstados.Add("Pernambuco");
// listaEstados.Add("Rio de Janeiro");
// listaEstados.Add("Santa Catarina");

// //Removendo um intem de uma lista
// listaEstados.Remove("Rio de Janeiro");

// //Percorrendo a lista com o FOR
// for(int i = 0; i < listaEstados.Count; i++){
// Console.WriteLine($"O estado de posição Nº {i} é {listaEstados[i]} ");
// }

// //Percorrendo a lista com FOREACH

// foreach(string i in listaEstados){
//         Console.WriteLine(i);
// }









// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 7;
// arrayInteiros[1] = 10;
// arrayInteiros[2] = 11;
// arrayInteiros[3] = 27;

// //Copiando elementos de um array para outro
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros,arrayInteirosDobrado, arrayInteiros.Length);

// //Redimensionando o tamanho do array
// Array.Resize(ref arrayInteiros, 8);

// //teste
// arrayInteiros[4] = Convert.ToInt32(Console.ReadLine());

// //Percorrendo o array com o FOR
// for(int i = 0; i < arrayInteiros.Length; i++){
//         Console.WriteLine($"Posição Nº {i} = {arrayInteiros[i]}");

// }

// //Percorrendo o array com o FOREACH

// foreach(int valor in arrayInteiros){
//         Console.WriteLine(valor);
// }




//MENU INTERATIVO


//  string opcao;

//  while(true){

//          Console.WriteLine("Digite 1 para cadastro de cliente");
//          Console.WriteLine("Digite 2 para busca de cliente");
//          Console.WriteLine("Digite 3 para sorriso");
//          Console.WriteLine("Digite 4 para encerrar o programa");
//          opcao = Console.ReadLine();

//   switch(opcao) {
//          case "1":
//                  Console.WriteLine("cadastro de cliente");
//                  break;

//          case "2":
//                  Console.WriteLine("Busca de cliente");
//                  break;
//          case "3":
//                  Console.WriteLine(":)");
//                  break;
//          case "4":
//                  Environment.Exit(0);
//                  break;

//          default:
//          Console.WriteLine("Opção inválida");
//          break;


//  }
//  }










//LAÇOS DE REPETIÇÃO

//int soma = 0, numero = 0;

// do{
//         Console.WriteLine($"Escreva um número (0 para parar): ");
//        numero = Convert.ToInt32(Console.ReadLine());
//        soma += numero;

//        if(numero == 0){
//         Console.WriteLine("O somatório deu " + soma);
//         Console.Clear();
//         break;
//        }
// }while(true);












// int num = 10;
// int i = 1;
// while(i <= 10){
//         Console.WriteLine($"{num} * {i} = {num*i} ");
//         i++;
// }













// int num = 3;

// for(int i = 1; i <= 10; i++ ){
//         Console.WriteLine($"{num} * {i} = {num*i}");
// }

























//  Calculadora calc = new Calculadora();

//  calc.Dividir(2, 1);



























        //string letra = Console.ReadLine();

        // switch (letra){
        //     case "a":
        //     case "e":
        //     case "i":
        //     case "o":
        //     case "u":
        //     Console.WriteLine("É uma vogal");
        //         break;

        //     default:
        //     Console.WriteLine("Não é uma vogal");
        //         break;

        // }


















//  Person person1 = new Person();

//  person1.Name = "Moisés";
//  person1.Age = 17;
//  person1.ToPresent();

//  string name1 = "Júlia Vitória";
//  int age1 = 16;
//  double height = 1.60;
//  decimal moneyAtCount = 70.00M; //Declaração de variavel decimal
//  bool perfect = true; //Declaração de variável booleana

// DateTime actuallyDate = DateTime.Now;
// DateTime dataAtualMais5Dias = DateTime.Now.AddDays(5);

// int number = Convert.ToInt32("5");// Conversão do valor da informação com Convert
// int number2 = int.Parse("5"); // Conversão do valor da informação com Parse
// int number3 = 5;
// string a = number3.ToString();// Conversão de uma variável inteira para tipo string
// string number4 = "4c";



// int number5 = 6;
// int.TryParse(number4, out number5);




// Console.WriteLine($"Hello, my names is {name1}, i'm {age1} years old, i'm {height.ToString("0.00")} tall, and i have {moneyAtCount
// } dollars");
// Console.WriteLine(dataAtualMais5Dias); //Data atual mais 5 dias
// Console.WriteLine(dataAtualMais5Dias.ToString("dd/MM/yyyy")); //Data sem horário

