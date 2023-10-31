using POO.Abstracao;
using POO.Encapsulamento;
using POO.Heranca;
using POO.Polimorfismo;

#region 1 - Abstracao
Console.WriteLine("Abstração-----------------------------------------");

var livro = new Livros(Guid.NewGuid(), "A Divina Comédia", "Dante Alighieri");
Console.WriteLine(livro.GetTitulo());

Console.WriteLine("--------------------------------------------------");

#endregion

#region 2 - Encapsulamento
Console.WriteLine("Encapsulamento------------------------------------");

var pessoa = new Pessoa("Willian");

Console.WriteLine($"Nome antigo: {pessoa.Nome}");
pessoa.MudarNome("Uzum");
Console.WriteLine($"Nome novo: {pessoa.RetornarNome()}");

Console.WriteLine("--------------------------------------------------");
#endregion

#region 3 - Heranca
Console.WriteLine("Heranca-------------------------------------------");

var cliente = new Cliente(Guid.NewGuid(), "Willian", "teste1@hotmail.com");
var clienteVip = new ClienteVip(Guid.NewGuid(), "Micaela", "teste2@hotmail.com", "123");

Console.WriteLine($"Nome cliente: {cliente.Nome}");
Console.WriteLine($"Email cliente: {cliente.Email}");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"Nome cliente vip: {clienteVip.Nome}");
Console.WriteLine($"Nome cliente vip: {clienteVip.Email}");

if (cliente.EnviarEmail())
    Console.WriteLine($"O e-mail de ativação foi direcionado ao endereço {cliente.Email}");
else 
    Console.WriteLine($"Usuario {cliente.Nome} foi bloqueado!");

Console.WriteLine("--------------------------------------------------");

if (clienteVip.EnviarEmail())
    Console.WriteLine($"O e-mail de ativação foi direcionado ao endereço {clienteVip.Email}");
else
    Console.WriteLine($"Usuario {clienteVip.Nome} foi bloqueado!");

Console.WriteLine("--------------------------------------------------");

if (clienteVip.EnviarEmail())
    Console.WriteLine($"O SMS de ativação foi direcionado ao número {clienteVip.Celular}");
else
    Console.WriteLine($"Usuario {clienteVip.Nome} foi bloqueado!");

Console.WriteLine("--------------------------------------------------");
#endregion

#region 4 - Polimorfismo
Console.WriteLine("Polimorfismo--------------------------------------");

var cachorro = new Cachorro();
var gato = new Gato();

cachorro.EmitirSom();
gato.EmitirSom();

Console.WriteLine("--------------------------------------------------");
#endregion