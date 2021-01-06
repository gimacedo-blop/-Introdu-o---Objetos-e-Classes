using System;

namespace Passagens_Aereas_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPassagens Aéreas\n");

            //VARIAVEIS
            bool loginValido;
            string[] nomes   = new string[5];
            string[] origem  = new string[5];
            string[] destino = new string[5];
            string[] data    = new string[5];
            string resposta;
            int escolha;
            int cont = 0;


            //INICÍO: Validação login com função
            do
            {

            Console.Write("\nDigite a Senha: ");
            string senha = Console.ReadLine();
            loginValido = Login(senha);

            } while (!loginValido);
            //FIM: Validação login
            
            Console.Clear();
            
            //INICÍO MENU            
            do
            {
                // Console.Clear(); RETIRADO POIS DÁ ERRO NA LISTAGEM, COLOQUEI FORA DO LAÇO
                System.Console.WriteLine("\nMenu Inicial\n");
                System.Console.WriteLine("\nSelecione uma opção abaixo:\n");
                System.Console.WriteLine("[1] - Cadastrar Passagem");
                System.Console.WriteLine("[2] - Listar Passagens");
                System.Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        //cadastro
                        do
                        {
                            if(cont<5){
                                System.Console.WriteLine($"Digite o nome do {cont+1} Passageiro:");
                            nomes[cont] = Console.ReadLine();

                            System.Console.WriteLine($"Digite a origem do {cont+1} Passageiro:");
                            origem[cont] = Console.ReadLine();

                            System.Console.WriteLine($"Digite o destino do {cont+1} Passageiro:");
                            destino[cont] = Console.ReadLine();
                            
                            System.Console.WriteLine($"Digite a data da {cont+1} Passagem:");
                            data[cont] = Console.ReadLine();
                            
                            cont++;

                            }else{
                                System.Console.WriteLine("Capacidade de passagens excedido!");
                                break;
                            }

                            System.Console.WriteLine("Gostaria de cadastrar uma nova viagem? S/N");
                            resposta = Console.ReadLine();
                            

                        } while (resposta == "S");
                        break;
                    case 2:
                        //listar
                        for (var i = 0; i < nomes.Length; i++)
                        {
                            System.Console.WriteLine($"Passageiro {nomes[i]}");
                        }

                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida!");
                        break;
                }
                

            } while (escolha !=0);//SAIR DO MENU
            //FIM MENU
            System.Console.WriteLine("VOLTE SEMPRE!");





            //Função --LOGIN--
            bool Login(string senha){
                
                if(senha == "123456"){
                    return true;
                }else{
                    System.Console.WriteLine("\nDigite uma senha válida\n");
                    return false;
                }
            }//FIM FUNÇÃO LOGIN
        }
    }
}
