using TesteUnidade.Domain;
using static TesteUnidade.Application.CalcularEmprestimoException;

namespace TesteUnidade.Application.Test;

public class CalcularEmprestimoClienteNormalTest
{
    [Fact(DisplayName = "Sucesso")]
    [Trait("Verificar Limite Emprestimo", "Cliente Normal")]
    public void LimiteEmprestimo_ClienteNormal_Sucesso()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.NORMAL);
        CalcularEmprestimoClienteNormal calcular = new(cliente);

        //Act Assert
        Assert.True(calcular.VerificarLimiteEmprestimo(100));
    }

    [Fact(DisplayName = "Falha")]
    [Trait("Verificar Limite Emprestimo", "Cliente Normal")]
    public void LimiteEmprestimo_ClienteNormal_Falha()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.NORMAL);
        CalcularEmprestimoClienteNormal calcular = new(cliente);

        //Act Assert
        Assert.False(calcular.VerificarLimiteEmprestimo(5000));
    }

    [Fact(DisplayName = "Sucesso")]
    [Trait("Fazer Novo Emprestimo", "Cliente Normal")]
    public void NovoEmprestimo_ClienteNormal_Sucesso()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.NORMAL);
        CalcularEmprestimoClienteNormal calcular = new(cliente);

        //Act Assert
        Assert.True(calcular.FazerNovoEmprestimo(100));
    }

    [Fact(DisplayName = "Falha")]
    [Trait("Fazer Novo Emprestimo", "Cliente Normal")]
    public void NovoEmprestimo_ClienteNormal_Falha()
    {
        //Arrange
        Cliente cliente = new("Thiago", ETipoCliente.NORMAL);
        CalcularEmprestimoClienteNormal calcular = new(cliente);

        //Act Assert
        Assert.Throws<FazerNovoEmprestimoException>(() => calcular.FazerNovoEmprestimo(5000));
    }
}
