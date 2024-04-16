namespace DesafioTddDio;

public class Calculadora
{
    private List<string> _historicoOperacoes;

    public Calculadora()
    {
        _historicoOperacoes = new List<string>();
    }

    public int Somar(int num1, int num2)
    {
        int res = num1 + num2;

        _historicoOperacoes.Insert(0, $"{num1} + {num2} = {res}");
        return res;
    }

    public int Subtrair(int num1, int num2)
    {
        int res = num1 - num2;

        _historicoOperacoes.Insert(0, $"{num1} - {num2} = {res}");
        return res;
    }

    public int Multiplicar(int num1, int num2)
    {
        int res = num1 * num2;

        _historicoOperacoes.Insert(0, $"{num1} * {num2} = {res}");
        return res;
    }

    public int Dividir(int num1, int num2)
    {
        int res = num1 / num2;
        return res;
    }

    public List<string> HistoricoOperacoes()
    {
        _historicoOperacoes.RemoveRange(3, _historicoOperacoes.Count - 3);
        return _historicoOperacoes.ToList();
    }
}