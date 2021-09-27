using System;

namespace Menu_simples
{
    class Program
    {
        enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar }//Criando um novo tipo de dado com o enum
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            //Pegando a opção digitada pelo usuário transformando ela em int e atribuindo-a a variavel index

            Opcao opcaoSelecionada = (Opcao)index;
            //Atribuindo a variavel index tranformada no tipo Opcao a variavel opcaoSelecionada do tipo Opcao

            switch(opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você deseja criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você deseja deletar algo!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você deseja editar algo!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você deseja listar algo!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você deseja atualizar algo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
