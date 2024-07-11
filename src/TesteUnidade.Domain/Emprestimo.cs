using static TesteUnidade.Domain.EmprestimoException;

namespace TesteUnidade.Domain;

public class Emprestimo
{
    public Guid EmprestimoId { get; } = Guid.NewGuid();
    public Guid ClienteId { get; }
    public Cliente Cliente { get; } = null!;
    public DateOnly Data { get; }
    public decimal Valor { get; }

    public Emprestimo(Guid clienteId, DateOnly data, decimal valor)
    {
        if (data < DateOnly.FromDateTime(DateTime.Now))
            throw new EmprestimoDataException();

        if (valor <= 0)
            throw new EmprestimoValorException();

        ClienteId = clienteId;
        Data = data;
        Valor = valor;
    }
}
