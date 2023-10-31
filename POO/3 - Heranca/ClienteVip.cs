/* 

A herança é um dos pilares da programação orientada a objetos (OOP) e é um mecanismo que permite que uma classe 
(conhecida como classe derivada ou subclasse) herde os membros (campos, métodos) de outra classe 
(classe base ou superclasse). A classe derivada herda os membros da classe base e pode adicionar ou substituir esses 
membros. A herança é usada para estabelecer uma relação "é um" entre as classes, onde a classe derivada é uma 
especialização da classe base.

1º Classe Base (Superclasse): A classe que fornece os membros que podem ser herdados por outras classes. Ela é a classe
"pai" na relação de herança.

2º Classe Derivada (Subclasse): A classe que herda membros da classe base. Ela é a classe "filha" na relação de herança.
A classe derivada pode adicionar novos membros ou substituir membros da classe base.

3º Membros Herdados: Os membros (campos, métodos, propriedades) da classe base que são acessíveis na classe derivada.

4º Override (Sobreposição): A capacidade de uma classe derivada substituir um método da classe base com sua própria 
implementação. Isso é feito usando a palavra-chave override.

5º Chamada a Métodos da Classe Base: A classe derivada pode chamar métodos da classe base usando a palavra-chave base.
 
 */

namespace POO.Heranca
{
    public class ClienteVip : Cliente
    {
        public ClienteVip(Guid id, string nome, string email, string celular) : base(id, nome, email)
        {
            Celular = celular;
        }

        public string Celular { get; set; }

        public bool EnviarSms()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }
    }
}
