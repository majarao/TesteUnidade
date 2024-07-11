using static TesteUnidade.Domain.ClienteException;

namespace TesteUnidade.Domain.Test;

public class ClienteTest
{
    [Fact(DisplayName = "Sucesso")]
    [Trait("Cliente", "Novo Cliente")]
    public void Cliente_NovoCliente_Sucesso()
    {
        //Arrange Act
        Cliente cliente = new("Thiago", ETipoCliente.NORMAL);

        //Assert
        Assert.True(cliente is not null);
    }

    [Fact(DisplayName = "Falha Nome")]
    [Trait("Cliente", "Novo Cliente")]
    public void Cliente_NovoCliente_FalhaNome()
    {

        //Arrange Act Assert
        Assert.Throws<ClienteNomeException>(() => { Cliente cliente = new("a", ETipoCliente.NORMAL); });
    }
}
