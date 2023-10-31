/* 
 
A abstração é um conceito fundamental na OOP e desempenha um papel crucial na modelagem e na construção de sistemas de 
software. Vou explicar em detalhes o que significa a abstração na OOP:

1º Definição: Abstração é o processo de simplificar complexidade, reduzindo o foco nos detalhes irrelevantes e 
destacando apenas os aspectos mais significativos. Na programação orientada a objetos, a abstração envolve a criação de
classes, objetos e interfaces que representam conceitos do mundo real de forma simplificada e relevante para o
sistema que está sendo desenvolvido.

2º Modelagem: A abstração permite que você modele objetos, entidades ou conceitos do mundo real em seu código. Você 
identifica as características essenciais e comportamentos relevantes dessas entidades e as encapsula em classes e 
objetos. Por exemplo, se estiver desenvolvendo um sistema de gerenciamento de biblioteca, você pode abstrair um livro 
como uma classe com propriedades como título, autor e ano de publicação. 

3º Ocultação de Detalhes: A abstração também envolve a ocultação de detalhes internos de um objeto. Isso significa 
que os usuários de um objeto não precisam conhecer ou se preocupar com a complexidade interna desse objeto. Eles 
interagem com o objeto apenas por meio de uma interface abstrata, chamando métodos e acessando propriedades, sem 
precisar saber como essas operações são implementadas. 

4º Níveis de Abstração: Em um sistema de software, você pode ter vários níveis de abstração, desde níveis muito altos, 
que representam conceitos de alto nível, até níveis mais baixos, que lidam com detalhes de implementação. A 
capacidade de trabalhar em diferentes níveis de abstração é uma das vantagens da OOP, pois permite dividir problemas 
complexos em partes menores e mais gerenciáveis. 

5º Reutilização de Código: A abstração também promove a reutilização de código. Uma vez que você cria classes abstratas
que encapsulam comportamentos e propriedades comuns, você pode estendê-las e criar subclasses específicasque herdam 
essas características e podem adicionar ou modificar comportamentos conforme necessário. 
*/


namespace POO.Abstracao
{
    public class Livros
    {
        //1º Livros Tem: Título, Número de Capas, Autor, Editora, Ano de Publicação, Etc.

        //2º Usuabilidade: Neste caso apenas quero uma classe simples para persistir as informações na base e filtrar
        //(sendo assim, para o contexto atual não é necessário obter todos os dados de livros se não forem usados).

        public Livros(Guid id, string titulo, string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        //3º Perceba que aqui ficará a implementação, contudo os usuários externos da classe não precisam conhecer esta
        //parte, somente precisam interagir com os métodos publicos: GetTitulo.
        public string GetTitulo()
        {
            return Titulo;
        }
    }
}
