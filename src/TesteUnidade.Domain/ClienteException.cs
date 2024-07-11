namespace TesteUnidade.Domain;

public class ClienteException : DomainException
{
    public const string NOME_INVALIDO = "Nome inválido, necessário possuir pelo menos 3 caracteres";

    public ClienteException(string? message) : base(message) { }

    public class ClienteNomeException : ClienteException
    {
        public ClienteNomeException() : base(NOME_INVALIDO) { }
    }
}
