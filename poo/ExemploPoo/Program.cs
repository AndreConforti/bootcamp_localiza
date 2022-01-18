using System;
using ExemploPoo.Helper;
using ExemploPoo.Interfaces;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionTextoStream(caminhoArquivo, listaStringContinuacao);
            helper.AdicionarTexto(caminhoArquivo, "\nTerceira linha de escrita.");
            
            // icalculadora calc = new calculadora(); // eu não posso implementar uma intarface calculadora, mas como eu tenho uma classe calculadora q implementa a interface, o programa autoriza. 
            // System.Console.WriteLine(calc.multiplicar(10, 20));

            // computador comp = new computador(); // instancia um objeto comp da classe computador
            // System.Console.WriteLine(comp.ToString());

            // corrente c = new corrente();
            // c.creditar(100);
            // c.exibirsaldo();

            // calculadora calc = new calculadora();  // Instancia um objeto calc da classe calculadora
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.somar(10, 10, 10));

            // aluno p1 = new aluno();
            // p1.Nome = "André";
            // p1.Idade = 43;
            // p1.documento = "123456";
            // p1.nota = 10;
            // p1.Apresentar();

            // professor prof = new professor();
            // prof.Nome = "Martins";
            // prof.Idade = 44;
            // prof.documento = "654321";
            // prof.salario = 2025.00;
            // prof.Apresentar();

            // // Valores válidos
            // retangulo r = new retangulo();
            // r.definirmedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.obterarea()}");

            // // Valores inválidos
            // retangulo r2 = new retangulo();
            // r.definirmedidas(0, 0);
            // System.Console.WriteLine($"Área: {r.obterarea()}");
                    
            // pessoa p1 = new pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Apresentar();
        }
    }
}
