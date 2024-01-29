using AssistenciaTecnica.Models;
namespace AssistenciaTecnica.Testes;

public class UnitTest1
{
    private Orcamento _orcamento;
    public UnitTest1()
    {
        _orcamento = new Orcamento("Alexia", "11946467382", "ProMax", "PIX");
    }
    [Fact]
    public void DeveRetornarNomeAlexia()
    {
        string resultado = _orcamento.Nome;

        Assert.Equal("Alexia", resultado);
    }
}