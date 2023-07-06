using Xunit;
using reserva_salas_csharp;

namespace reserva_salas_csharp.test
{
    public class UsuarioTest
    {
        [Fact]
        public void Deve_Validar_Atributos()
        {
            // Arrange
            Models.Usuario usuario = UsuarioFaker.GenerateFakeUsuario();

            // Act
            Controllers.UsuarioValidations.ValidaAtributos(usuario.CPF, usuario.DataNascimento, usuario.UserName, usuario.Senha);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Deve_Retornar_Excecao_Validacao_Atributos()
        {
            // Arrange
            Models.Usuario usuario = UsuarioFaker.GenerateFakeUsuario();
            usuario.CPF = "cpf_invalido.com";

            // Act e Assert
            Assert.Throws<System.Exception>(() => 
                Controllers.UsuarioValidations
                .ValidaAtributos(usuario.CPF, usuario.DataNascimento, usuario.UserName, usuario.Senha))
                .Message.Equals("O campo CPF é inválido");
        }
    }
}