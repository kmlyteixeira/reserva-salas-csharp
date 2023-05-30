using Controllers;
using Models;

public static class Program
{
    public static void Main()
    {

        Console.WriteLine("Id");
        string id = Console.ReadLine();
         Controllers.Funcionario.mostrarAllFunc();
        
        
        /*Console.WriteLine("Nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Sobrenome");
        string sobrenome = Console.ReadLine();
        Console.WriteLine("CPF");
        string cpf = Console.ReadLine();
        Console.WriteLine("Data Nascimento");
        string dataNasc = Console.ReadLine();


        Controllers.Funcionario.alterarFuncionario(int.Parse(id),nome,sobrenome,cpf,dataNasc); 
        

       
        Console.WriteLine("Cadastrar funcionario");
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Sobrenome: ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine("CPF: ");
         string CPF = Console.ReadLine();
        Console.WriteLine("Data Nascimento: ");
         string Data_nasc = Console.ReadLine();
        Controllers.Funcionario.cadastraFuncionario(new Models.Funcionario(nome, sobrenome,CPF,Data_nasc));*/
        
    }
}