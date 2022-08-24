using System;

namespace PExercicioGetSetPoo
{
    internal class Program
    {
        /*Programa que vai instanciar 3 objetos que venham de uma classe chamada Pessoa, onde essa classe contém 4 atributos:
        Nome
        Data de Nasc
        CPF
        Telefone

        Construtores, getters, setters, ToString;

        Usuário informa os atributos para o método construtor;

        */

        static void Main(string[] args)
        {
            string nome, data_nasc, cpf, telefone;
            int qtd_pessoas = 3;            
            Pessoa[] vet = new Pessoa[qtd_pessoas];

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Pessoa " + (i+1) + ": Informe o nome: ");
                nome = Console.ReadLine();
                Console.Write("Pessoa " + (i + 1) + ": Informe a data de nascimento: ");
                data_nasc = Console.ReadLine();
                Console.Write("Pessoa " + (i + 1) + ": informe o CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Pessoa " + (i + 1) + ": Informe o Telefone: ");
                telefone = Console.ReadLine();
                
                vet[i] = new Pessoa(nome, data_nasc, cpf, telefone);
                
                Console.WriteLine(vet[i].ToString()+"\n");                
            }

            /* Código não possui tratamento de inserção de dados, apenas possui os requisitos solicitados do
             exercício para praticar introdução a POO.*/

        }
    }
}
