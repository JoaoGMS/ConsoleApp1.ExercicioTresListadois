using System;

namespace ConsoleApp1.ExercicioTresListadois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indice de massa corporal");
            double imc, altura, peso;
            Console.Write("Digite o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            imc = peso / Math.Pow(altura, 2);  //Descobrir oq é Math.Pow
            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc > 18.5 && imc <= 25)
                Console.WriteLine("Peso normal");
            else if (imc > 25 && imc < 30)
                Console.WriteLine("Acima do peso");
            else if (imc > 30)
                Console.WriteLine("Obeso");
        }
    }
}
