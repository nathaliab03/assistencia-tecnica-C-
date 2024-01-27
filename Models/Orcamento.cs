using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistenciaTecnica.Models
{
    public class Orcamento : App
    {
        public Orcamento(string nome, string contato, string modelo, string formaDePgto) : base(nome, contato, modelo, formaDePgto){}
        protected decimal aplicacaoDePelicula = 60;
        protected decimal trocaDeBateria = 500;
        protected decimal trocaDeTela = 900;
        protected decimal backUp = 100;
        protected decimal valorTotal;
        protected bool mostrarMenu = true;  
        protected List<string> servicosAdicionados = new List<string>();
        public void MenuOrcamento(){
            while(mostrarMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1- Adicionar itens \n2- Remover itens \n3- Finalizar");

                string adicionaOuRemove = Console.ReadLine();

                switch(adicionaOuRemove)
                {
                    case "1": 
                        AdicionarOuRemoverServico("adicionarServicoAoOrcamento"); 
                        break;
                    case "2":  
                        AdicionarOuRemoverServico("removerServicoDoOrcamento"); 
                        break;
                    case "3":
                        mostrarMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
            
            if(mostrarMenu == false){
                int count = 1;

                Console.WriteLine($"Orçamento Finalizado! Serviços Executados");
                foreach (var item in servicosAdicionados)
                {
                    Console.WriteLine($"{count}- {item}");
                    count++;
                }
                Console.WriteLine($"Valor Total: {valorTotal:C}");
                Valor = valorTotal;
            }
        }
        private void ServicosDisponiveis()
        {
                Console.WriteLine($"1- Aplicação de Pelicula {aplicacaoDePelicula:C}");
                Console.WriteLine($"2- Troca de Bateria {trocaDeBateria:C}");
                Console.WriteLine($"3- Troca de Tela {trocaDeTela:C}");
                Console.WriteLine($"4- Backup {backUp:C}");
                Console.WriteLine("5- Finalizar Orçamento");
        }
        private void AdicionarOuRemoverServico(string adicionarOuRemoverServico)
        {
            Console.WriteLine("Escolha o Serviço executado:");
            ServicosDisponiveis();

            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    Calcular(adicionarOuRemoverServico, $"Aplicação de Película - {aplicacaoDePelicula:C}", aplicacaoDePelicula);
                    break;
                case "2":
                    Calcular(adicionarOuRemoverServico, $"Troca de Bateria - {trocaDeBateria:C}", trocaDeBateria);
                    break;
                case "3":
                    Calcular(adicionarOuRemoverServico, $"Troca de Tela - {trocaDeTela:C}", trocaDeTela);
                    break;
                case "4":
                    Calcular(adicionarOuRemoverServico, $"BackUp  - {backUp:C}", backUp);
                    break;
                case "5":
                    Console.WriteLine($"Orçamento Finalizado! Valor Total: {valorTotal:C} ");
                    mostrarMenu = false;
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }       
        }
        private static void AdicionarMais()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();
        }
        protected void Calcular(string adicionarOuRemoverServico, string servicoSelecionadoString, decimal servicoSelecionadoVariavel)
        {

            if(adicionarOuRemoverServico == "adicionarServicoAoOrcamento")
            {
                servicosAdicionados.Add(servicoSelecionadoString);
                valorTotal += servicoSelecionadoVariavel;
                Console.WriteLine($"{servicoSelecionadoString} adicionado com sucesso. Subtotal: {valorTotal:C}");
                AdicionarMais();
            } 
            else if(servicosAdicionados.Contains(servicoSelecionadoString))
            {
                servicosAdicionados.Remove(servicoSelecionadoString);
                valorTotal -= servicoSelecionadoVariavel;
                Console.WriteLine($"{servicoSelecionadoString} removido com sucesso. Subtotal: {valorTotal:C}");
                AdicionarMais();
            }
            else{
                Console.WriteLine("Serviço não encontrado no orçamento!");
                AdicionarMais();
            }
        }
    }
}