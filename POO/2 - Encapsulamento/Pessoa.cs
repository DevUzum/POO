/* 
O encapsulamento é um dos quatro pilares da OOP (Programação Orientada a Objetos) e é um princípio que envolve a 
proteção dos detalhes internos de um objeto, permitindo o acesso controlado a esses detalhes por meio de uma interface 
pública. O encapsulamento é uma maneira de garantir que os dados e métodos de uma classe sejam acessados e modificados 
de maneira segura e controlada.
 
1º Membros Privados: O encapsulamento envolve a definição de membros privados em uma classe, como campos de dados e 
métodos privados. Esses membros não podem ser acessados diretamente de fora da classe. 

2º Membros Públicos: Para permitir o acesso controlado aos detalhes internos, a classe fornece membros públicos, como 
propriedades (getters e setters) e métodos públicos. Esses membros são a interface pública da classe, através da qual 
os usuários interagem com os objetos dessa classe.

3º Controle de Acesso: O encapsulamento também envolve a definição de níveis de acesso aos membros da classe, como 
público, privado ou protegido. Isso controla quem pode acessar e modificar os membros da classe.

4º Proteção de Dados: O encapsulamento ajuda a proteger os dados da classe, garantindo que os valores de campos de 
dados não possam ser modificados de maneira inadequada. Em vez disso, os dados são acessados e modificados por meio 
de métodos que podem aplicar lógica de validação ou restrição.

5º Modificadores de Acesso: Em linguagens como C#, você pode usar modificadores de acesso, como private, public, 
protected, internal, etc., para controlar a visibilidade e acessibilidade dos membros de uma classe. 
*/

namespace POO.Encapsulamento
{
    public class Pessoa
    {
        public Pessoa(string nomeInicial)
        {
            Nome = nomeInicial;
        }

        //1º e 2º - Com este códgo já está ocorrendo o encapsulamento, sendo assim o atributo só pode ser acessado por
        //uma interface publica. 
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        //4º Este é outro exemplo de como encapsular, não deixando que qualquer um chame a propriedade e defina um novo
        //valor.
        public void MudarNome(string nomeNovo)
        {
            Nome = nomeNovo;
        }

        public string RetornarNome()
        {
            return Nome;
        }
    }
}
