using System;

namespace Classes_e_MetodosSelados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * CLASSES E MÉTODOS SELADOS:
            
            - Palavra chave: sealed (Quando for usada é para definir que a classe será selada).
            - Classe Selada: Evita que a classe seja herdada
            Obs. Ainda é possível extender a funcionalidade de uma classe selada usando "extension methods".

            Exemplo: namespace Course {
                        sealed class SavingsAccount {...

            * MÉTODO:
            
            - Evita que um método sobreposto possa ser sobreposto novamente.
            Obs. Só pode ser aplicado a métodos sobrepostos.

            * PRA QUÊ SELAR UMA CLASSE OU MÉTODO?
            
            - SEGUNRANÇA: Dependendo das regras do negócio, às vezes é desejável garantir que uma classe não seja herdada, ou que um método não seja sobreposto.
            Obs. Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma porta de entrada para inconsistências.
            
            - PERFORMANCE: Atributos de tipo de uma classe selada são analisados de forma mais rápida em tempo de execução.
            Exemplo: Clássico: string.
            */
        }
    }
}
