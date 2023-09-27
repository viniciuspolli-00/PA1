using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota1, nota2, nota3, nota4, media, percFreq;

            Console.Write("Informe a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a quarta nota: ");
            nota4 = float.Parse(Console.ReadLine());

            Console.Write("Informe o % de Frequencia: ");
            percFreq = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;


            //0.00 a 4.99 e % = 40 - reprovado
            //5.00 a 6.99 e %frequencia <= 40 - recuperação
            //7.00 a 10.00 e %Frequencia <=60 -aprovado

            if (media < 5 && percFreq <= 40)
            {
                Console.WriteLine("aluno Reprovado");
            } else if (media < 7 && percFreq <= 60)
            {
                Console.WriteLine("alunos em recupecão");
            } else if (media <= 10 && percFreq > 60)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Sera analisado pela secretaria academica");
            }
        