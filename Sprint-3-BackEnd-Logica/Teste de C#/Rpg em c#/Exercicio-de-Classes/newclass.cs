namespace Exercicio_de_Classes
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string ia = "Jarvis";

        public string Ataque1(){
            return "Rajada de fogo";
        }
        public string Ataque2(){
            return "Sopro congelante";
        }
        public string Defesa(){
            return "Escudos de Luz, o adversário não acertou  o ataque";
        }
        public string dmgatq1 (){
            return "10 de dano";
        }

        public string dmgatq2 (){
            return "você foi congelado até o próximo turno, e sofreu 5 de dano";
        }

        public string evasive (){
            return "conseguiu escapar do ataque de seu adversário";
        }

        public int vida(){
            return 100;
        }
    }
}