using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioGetSetPoo
{
    internal class Pessoa
    {
        private String nome;
        private String nascimento;
        private String cpf;
        private String telefone;

        //Método Construtor
        public Pessoa(String nome, String data_nasc, String cpf, String telefone)
        {
            this.nome = nome;
            this.nascimento = data_nasc;
            this.cpf = cpf;
            this.telefone = telefone;
        }


        //Métodos Getters
        public String GetNome()
        {
            return this.nome;
        }

        public String GetNascimento()
        {
            return this.nascimento;
        }

        public String GetCpf()
        {
            return this.cpf;
        }

        public String GetTelefone()
        {
            return this.telefone;
        }


        //Métodos Setters

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public void SetNascimento(String nascimento)
        {
            this.nascimento = nascimento;
        }

        public void SetCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public void SetTelefone(String telefone)
        {
            this.telefone = telefone;
        }


        //Método ToString

        public override String ToString()
        {
            return "Nome: " + this.nome + "\nData de Nascimento: " + this.nascimento + "\nCPF: " + this.cpf + "\nTelefone: " + this.telefone;
        }
    }
}
