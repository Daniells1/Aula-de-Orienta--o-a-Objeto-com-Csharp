using System;
namespace ExemploPOO.Models


{
    class Program
    {
        static void Main(string[] args)
        {
           Professor p1 = new Professor();

            p1.Nome ="Edvaldo";
            p1.Idade = 20;
            p1.Salario = 1000;

            p1.Apresentar();

            //valores válidos
            // Retangulo r=new Retangulo();
            // r.DefinirMedidas(0,30);
             
            // Console.WriteLine($"Área: {r.ObterArea()} ");

            // Pessoa p1 = new Pessoa();
            // p1.Nome ="Edvaldo";
            // p1.Idade = 20;

            // p1.Apresentar();




        }
    }
}