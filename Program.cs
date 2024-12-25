using System;
using System.Collections.Generic;


namespace Veiculos_Registrados
{
    public interface Veiculos 
    {
        public string Dono { get; set; }
        public string Carro { get; set; }

        void Imostra_informação();
    }

    class Registro: Veiculos
    {
        public string Dono { get; set; }
        public string Carro { get; set; }

        private List<string> Registros_de_Clientes = new List<string>();

        private List<string> Registros_de_Carros = new List<string>();

        public void registros_de_clientes()
        {
            Console.Write("digite o nome de um carro :");
            Dono = Console.ReadLine();

            Registros_de_Clientes.Add(Dono);

            Console.Write("digite o Nome do Carro comprado : ");
            Carro = Console.ReadLine();

            Registros_de_Carros.Add(Carro);
        }

        public void Imostra_informação()
        {
            
            if (Registros_de_Clientes.Count == 0)
            {
                Console.WriteLine("Não á nada, nenhum cliente registrado");
                return;
            }

            for (int i = 0; i < Registros_de_Clientes.Count; i++) 
            {
                Console.Write($"Nome :{Registros_de_Clientes[i]}   Carro registrdo(a) no nome:{ Registros_de_Carros[i]}");
            }
        }    
        public void Limpar_Dados() 
        {
            Registros_de_Carros.Clear();
            Registros_de_Clientes.Clear();
            Console.WriteLine("Dados Limpos!");
        }

        public void Novos_dados()
        {
            registros_de_clientes();
            Console.WriteLine("Clientes adicionados com sucessor");
        }
    }

    class Historico_de_Clientes
    {

        static void Main() 
        {
            Registro registro = new Registro();
            while (true) 
            {

                Console.Write("\n1 - ver Clientes e seus contratos");
                Console.Write("\n2 - apagar listas de clientes");
                Console.Write("\n3 - escrever novos Clientes");
                Console.Write("\n4 - Sair");
                Console.Write("\ndigite : ");
                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1: registro.Imostra_informação(); break;
                    case 2: registro.Limpar_Dados(); break;
                    case 3: registro.Novos_dados(); break;
                    case 4: return;
                    default: Console.WriteLine("\ndigite novamente pois errou\n"); break;


                }
            }



        }

    }
    
    
}