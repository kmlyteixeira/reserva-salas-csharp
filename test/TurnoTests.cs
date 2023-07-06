using Xunit;

namespace reserva_salas_csharp.test
{
    public class TurnoTest
    {
        [Fact]
        public void Deve_Cadastrar_Turno()
        {
            // Arrange
            Models.Turno turno = TurnoFaker.GenerateFakeTurno();

            // Act
            Controllers.Turno.CadastrarTurno(turno.descricao);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Deve_Retornar_Erro_Turno_Sem_Descricao()
        {
            // Arrange
            Models.Turno turno = TurnoFaker.GenerateFakeTurno();
            turno.descricao = null;

            // Act e Assert
            Assert.Throws<System.Exception>(() => 
                Controllers.Turno.CadastrarTurno(turno.descricao))
                .Message.Equals("O campo descrição é obrigatório");
        }
    }
}