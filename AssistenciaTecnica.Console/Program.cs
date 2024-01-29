using AssistenciaTecnica.Models;
App aplicativo = new App();
bool showMenu = true;

Console.WriteLine("Seja bem-vindo(a) à Assistência IPhone. Selecione uma das opções para continuarmos");

while (showMenu)
{
        Console.WriteLine("1- Cadastrar Orçamento.");
        Console.WriteLine("2- Listar Orçamentos");
        Console.WriteLine("3- Remover Orçamento");
        Console.WriteLine("4- Finalizar");

        switch(Console.ReadLine())
        {
                case "1":
                        Console.WriteLine("Nome do Cliente");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Telefone do Contato");
                        string contato = Console.ReadLine();
                        Console.WriteLine("Modelo do Iphone");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Forma de Pagamento");
                        string formaDePagamento = Console.ReadLine();

                        Orcamento dispositivo = new Orcamento(nome, contato, modelo, formaDePagamento);
                        aplicativo.AdicionarSmartphone(dispositivo);
                        dispositivo.MenuOrcamento();
                break;
                case "2":
                        aplicativo.ListarSmartphone();
                        break;
                case "3":
                        aplicativo.RemoverSmartphone();
                        break;
                case "4":
                        showMenu = false;
                        break;
                
        }

        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadLine();
        Console.Clear();
}
Console.WriteLine("Programa Encerrado!");