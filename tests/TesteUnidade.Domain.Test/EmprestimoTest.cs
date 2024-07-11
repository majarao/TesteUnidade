using static TesteUnidade.Domain.EmprestimoException;

namespace TesteUnidade.Domain.Test;

public class EmprestimoTest
{
    [Fact(DisplayName = "Sucesso")]
    [Trait("Emprestimo", "Novo Emprestimo")]
    public void Emprestimo_NovoEmprestimo_Sucesso()
    {
        //Arrange Act
        Emprestimo emprestimo = new(Guid.NewGuid(), DateOnly.FromDateTime(DateTime.Now), 100);

        //Assert
        Assert.True(emprestimo is not null);
    }

    [Fact(DisplayName = "Falha Data")]
    [Trait("Emprestimo", "Novo Emprestimo")]
    public void Emprestimo_NovoEmprestimo_FalhaData()
    {

        //Arrange Act Assert
        Assert.Throws<EmprestimoDataException>(() =>
        {
            Emprestimo emprestimo = new(Guid.NewGuid(), DateOnly.FromDateTime(new DateTime(2024, 1, 1)), 100);
        });
    }

    [Fact(DisplayName = "Falha Valor")]
    [Trait("Emprestimo", "Novo Emprestimo")]
    public void Emprestimo_NovoEmprestimo_FalhaValor()
    {

        //Arrange Act Assert
        Assert.Throws<EmprestimoValorException>(() =>
        {
            Emprestimo emprestimo = new(Guid.NewGuid(), DateOnly.FromDateTime(DateTime.Now), 0);
        });

        Assert.Throws<EmprestimoValorException>(() =>
        {
            Emprestimo emprestimo = new(Guid.NewGuid(), DateOnly.FromDateTime(DateTime.Now), -1);
        });
    }
}
