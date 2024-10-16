using ExemplosFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("RN");
listaString.Add("PB");
listaString.Add("SP");


for(int cont = 0; cont < listaString.Count; cont++){

    Console.WriteLine($"Posição N° {cont} - {listaString[cont]}");
}

int contEstado = 0;
foreach(string estado in listaString){

    Console.WriteLine($"Posição N° {contEstado} - {estado}");
    contEstado++;

}



















// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// for(int cont = 0; cont < arrayInteiros.Length; cont++){

//     Console.WriteLine($"Posição numero {cont} - {arrayInteiros[cont]}");
// }














// int novocontador = 0;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição numero {novocontador} - {valor}");
//     novocontador++;
// }















// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Bruno";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();












// string? opcao;

// while (true){
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao){

//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }























// int soma = 0, num = 0;
// do{
//     Console.WriteLine("Digite um numero (0 para parar)");
//     num = Convert.ToInt32(Console.ReadLine());

//     soma += num;
// }while (num != 0);

// Console.WriteLine($"Total de soma dos numeros digitaos é: {soma}");





































// int num = 5;
// int cont = 0;
// while (cont <= 10){
//     Console.WriteLine($"{num} x {cont} = {num * cont}");
//     cont++;
// }































// int num = 5;



// for(int cont = 0; cont <= 10; cont++){
//     Console.WriteLine($"{num} x {cont} = {num * cont}");
// }






























// Calculadora calc = new Calculadora();

// calc.Somar(9, 10);
// calc.Subtrair(100, 40);
// calc.Multiplicar(15, 45);
// calc.Dividir(10, 10);
//calc.Potencia(3, 3);

// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando o 10");
// numero++;

// Console.WriteLine(numero);

// calc.RaizQuadrada(4);































// bool choveu = true;
// bool estaTarde= true;

// if(!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");

// } else {
//     Console.WriteLine("Vou pedalar um outro dia");
// }































// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();

// switch (letra){

//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

































// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {(possivelVenda ? "Sim" : "Não")}");

// if (quantidadeCompra == 0){

//     Console.WriteLine("Venda invalida");
    
// } else if (possivelVenda){

//     Console.WriteLine("Venda realizada");

// } else {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }