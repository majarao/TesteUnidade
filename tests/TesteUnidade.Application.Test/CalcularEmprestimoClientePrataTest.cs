using TesteUnidade.Domain;
using static TesteUnidade.Application.CalcularEmprestimoException;

namespace TesteUnidade.Application.Test;

public class CalcularEmprestimoClientePrataTest
{
    [Fact(DisplayName = "Sucesso")]
    [Trait("Verificar Limite Emprestimo", "Cliente Prata")]
    public void LimiteEmprestimo_ClientePrata_Sucesso()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.PRATA);
        CalcularEmprestimoClientePrata calcular = new(cliente);

        //Act Assert
        Assert.True(calcular.VerificarLimiteEmprestimo(100));
    }

    [Fact(DisplayName = "Falha")]
    [Trait("Verificar Limite Emprestimo", "Cliente Prata")]
    public void LimiteEmprestimo_ClientePrata_Falha()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.PRATA);
        CalcularEmprestimoClientePrata calcular = new(cliente);

        //Act Assert
        Assert.False(calcular.VerificarLimiteEmprestimo(5000));
    }

    [Fact(DisplayName = "Sucesso")]
    [Trait("Fazer Novo Emprestimo", "Cliente Prata")]
    public void NovoEmprestimo_ClientePrata_Sucesso()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.PRATA);
        CalcularEmprestimoClientePrata calcular = new(cliente);

        //Act Assert
        Assert.True(calcular.FazerNovoEmprestimo(100));
    }

    [Fact(DisplayName = "Falha")]
    [Trait("Fazer Novo Emprestimo", "Cliente Prata")]
    public void NovoEmprestimo_ClientePrata_Falha()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.PRATA);
        CalcularEmprestimoClientePrata calcular = new(cliente);

        //Act Assert
        Assert.Throws<FazerNovoEmprestimoException>(() => calcular.FazerNovoEmprestimo(5000));
    }
}
