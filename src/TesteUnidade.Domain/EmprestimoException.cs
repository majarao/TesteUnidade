namespace TesteUnidade.Domain;

public class EmprestimoException : DomainException
{
    public const string DATA_INVALIDA = "Data precisa ser posterior a hoje";
    public const string VALOR_INVALIDO = "Valor precisa ser positivo";

    public EmprestimoException(string? message) : base(message) { }

    public class EmprestimoDataException : EmprestimoException
    {
        public EmprestimoDataException() : base(DATA_INVALIDA) { }
    }

    public class EmprestimoValorException : EmprestimoException
    {
        public EmprestimoValorException() : base(VALOR_INVALIDO) { }
    }
}
