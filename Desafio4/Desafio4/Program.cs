using System;
using System.Collections.Generic;
using Desafio4.Models;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();
            List<Alunos> alunos = new List<Alunos>();
            Console.WriteLine("Bem Vindo Ao Console Mil Grau das Notinhas\n");

            #region Aluno1
            Console.WriteLine("Começa digitando o nome do primeiro Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Convert.ToDouble(Console.ReadLine());

            alunos.Add(aluno);
            aluno = new Alunos();
            #endregion

            #region Aluno2
            Console.WriteLine("\nComeça digitando o nome do segundo Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Convert.ToDouble(Console.ReadLine());

            alunos.Add(aluno);
            aluno = new Alunos();
            #endregion

            #region Aluno3
            Console.WriteLine("\nComeça digitando o nome do terceiro Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Convert.ToDouble(Console.ReadLine());

            alunos.Add(aluno);
            #endregion

            Console.WriteLine("\nExibindo Alunos Com Lista");
            foreach (var aluninho in alunos)
            {
                
                Console.WriteLine($"\nNome:{aluninho.Nome}");
                Console.WriteLine($"\nNome:{aluninho.Idade}");
                Console.WriteLine($"\nNome:{aluninho.Nota}");
                Console.ReadKey();
            }

            var alunosArray = alunos.ToArray();

            Console.WriteLine("\nExibindo Alunos Com Array");
            foreach (var alunoArray in alunosArray)
            {
                
                Console.WriteLine($"\nNome:{alunoArray.Nome}");
                Console.WriteLine($"\nNome:{alunoArray.Idade}");
                Console.WriteLine($"\nNome:{alunoArray.Nota}");
                Console.ReadKey();
            }
            Console.ReadKey();

        }
    }
}
