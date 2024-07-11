using TesteUnidade.Domain;

namespace TesteUnidade.Application;

public interface ICalcularEmprestimo
{
    public Cliente Cliente { get; }
    public decimal RecuperarLimiteEmprestimo();
    public bool VerificarLimiteEmprestimo(decimal valor);
    public bool FazerNovoEmprestimo(decimal valor);
}
