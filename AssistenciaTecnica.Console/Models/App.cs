using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistenciaTecnica.Models
{
    public class App
    
    {
        private string _nome;
        private string _contato;
        public string Modelo;
        private decimal _valor;
        public string FormaDePgto;
        private List<App> listaSmartphone = new List<App>();

        public App(){}
        public App(string nome, string contato, string modelo, string formaDePgto)
        {
            Nome = nome;
            Contato = contato;
            Modelo = modelo;
            FormaDePgto = formaDePgto;
        }
        public decimal Valor { 
            get => _valor;
        
            set {
             _valor = value;
        }
        }
        public string Nome { 
            get => _nome;  
            set {
                try{
                    if(value == ""){
                        throw new ArgumentException("O nome não pode estar em branco. Digite o nome do cliente: ");
                    }
                    _nome = value;
                }
                catch(ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                    Nome = Console.ReadLine();
                }
            } 
        }
        public string Contato { 
            get => _contato;  
            set {
                try{
                    if(value == ""){
                        throw new ArgumentException("O contato não pode estar em branco! Digite o telefone de contato: ");
                    }
                    _contato = value;
                }
                catch(ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                    Contato = Console.ReadLine();
                }
            } 
        }
        public void AdicionarSmartphone(App celular)
        {
            listaSmartphone.Add(celular);
        }
        public void RemoverSmartphone()
        {
            Console.WriteLine("Digite o Nome ou Contato para remover o orçamento");
            string nomeOuContato = Console.ReadLine();

            int indexToRemove = listaSmartphone.FindIndex(x => x.Nome.ToLower() == nomeOuContato.ToLower() || x.Contato == nomeOuContato);

            if (indexToRemove != -1)
            {
                listaSmartphone.RemoveAt(indexToRemove);
                Console.WriteLine("Smartphone removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Smartphone não encontrado na lista.");
            }
        }

        public void ListarSmartphone()
        {
            if(listaSmartphone.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else{
                Console.WriteLine("Celulares Adicionados");
                int count = 1;

                foreach (App celular in listaSmartphone)
                {
                    Console.WriteLine($"{count}- Nome: {celular.Nome}. Contato: {celular.Contato}. Valor: {celular.Valor:C}. Forma de PGTO: {celular.FormaDePgto.ToUpper()}");
                    count++;
                }
            }
        }

        
        
    }
}