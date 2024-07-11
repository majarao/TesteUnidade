using static TesteUnidade.Domain.ClienteException;

namespace TesteUnidade.Domain;

public class Cliente
{
    public Guid ClienteId { get; } = Guid.NewGuid();
    public string Nome { get; }
    public ETipoCliente TipoCliente { get; }
    public List<Emprestimo> Emprestimos { get; } = [];

    public decimal RecuperarTotalEmprestado() => Emprestimos.Sum(e => e.Valor);

    public Cliente(string nome, ETipoCliente tipoCliente)
    {
        if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            throw new ClienteNomeException();

        Nome = nome;
        TipoCliente = tipoCliente;
    }
}
