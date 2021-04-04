using System;
namespace MetodosConstrutores_EX.Classes
{
    public class Pessoa
    {
         public string primeiroNome;
        public string sobreNome;
        public Pessoa(){

        }
        public Pessoa(string n, string s){
            
            this.primeiroNome = n;
            this.sobreNome = s;

            Console.WriteLine($"Bem-vindo(a) {n} {s}");
        }
    }
}