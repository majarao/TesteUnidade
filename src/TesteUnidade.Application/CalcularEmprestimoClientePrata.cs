using TesteUnidade.Domain;
using static TesteUnidade.Application.CalcularEmprestimoException;

namespace TesteUnidade.Application;

public class CalcularEmprestimoClientePrata(Cliente cliente) : ICalcularEmprestimo
{
    public Cliente Cliente => cliente;

    public decimal RecuperarLimiteEmprestimo() => 1000;

    public bool VerificarLimiteEmprestimo(decimal valor) => Cliente.RecuperarTotalEmprestado() + valor <= RecuperarLimiteEmprestimo();

    public bool FazerNovoEmprestimo(decimal valor)
    {
        if (!VerificarLimiteEmprestimo(valor))
            throw new FazerNovoEmprestimoException();

        Cliente.Emprestimos.Add(new(Cliente.ClienteId, DateOnly.FromDateTime(DateTime.Now), valor));
        return true;
    }
}
