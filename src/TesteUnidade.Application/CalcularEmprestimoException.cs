namespace TesteUnidade.Application;

public class CalcularEmprestimoException : Exception
{
    const string LIMITE_EXCEDIDO = "O cliente não possui mais valor de crédito para um novo empréstimo";

    public CalcularEmprestimoException(string? message) : base(message) { }

    public class FazerNovoEmprestimoException : CalcularEmprestimoException
    {
        public FazerNovoEmprestimoException() : base(LIMITE_EXCEDIDO) { }
    }
}
