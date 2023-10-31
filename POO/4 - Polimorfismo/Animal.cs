/*
 
Polimorfismo é um dos princípios fundamentais da Programação Orientada a Objetos (OOP). O termo "polimorfismo" se 
refere à capacidade de objetos de diferentes classes responderem de maneira diferente a chamadas de método com o mesmo 
nome. Existem dois tipos principais de polimorfismo: polimorfismo de tempo de compilação (estático) e polimorfismo de 
tempo de execução (dinâmico).
 
1º Polimorfismo de Tempo de Compilação (Estático): O polimorfismo de tempo de compilação ocorre quando a decisão sobre 
qual método chamar é tomada em tempo de compilação. Isso é baseado no tipo declarado das variáveis envolvidas. Um 
exemplo disso é a sobrecarga de métodos, onde várias versões do método têm o mesmo nome, mas diferem em seus parâmetros.

2º Polimorfismo de Tempo de Execução (Dinâmico): O polimorfismo de tempo de execução ocorre quando a decisão sobre qual
método chamar é tomada em tempo de execução, com base no tipo real do objeto. Isso envolve herança e a sobreposição 
(override) de métodos nas classes derivadas.

 */

namespace POO.Polimorfismo
{
    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Um som genérico.");
        }
    }
}
