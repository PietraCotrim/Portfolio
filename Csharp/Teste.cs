using static System.Console; // Permite usar WriteLine diretamente
using System; // Biblioteca padrão
using System.Linq; //Fornece a funcionalidade "Language Integrated Query que permite realizar consultar em diversas fontes, como o xml ou bd
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.VisualBasic; // LINQ

namespace exercicios
{
    class PrimeiroDia
    {
        static void Main(string[] args)
        {
            WriteLine("Olá, mundo!");

            WriteLine("Digite o seu nome:");
            string nome = ReadLine();
            WriteLine($"Seja bem vido(a) {nome}!!");

            WriteLine("Digite o seu nome:");
            string funcionario = ReadLine();
            WriteLine("Qual é o seu salario?");
            double salario = double.Parse(ReadLine());
            WriteLine($"O funcionario(a) {funcionario} tem um salario de {salario}");

            WriteLine("Somatorio");
            WriteLine("Digite os dois valores:");
            int v1 = int.Parse(ReadLine());
            int v2 = int.Parse(ReadLine());
            WriteLine($"Soma = {v1 + v2}");

            WriteLine("Media de notas");
            WriteLine("Digite a primeira nota:");
            double n1 = double.Parse(ReadLine());
            WriteLine("Digite a segunda nota:");
            double n2 = double.Parse(ReadLine());
            double media = (n1 + n2) / 2;
            WriteLine($"A media do aluno será:{media}");

            WriteLine("Digite um numero:");
            int n = int.Parse(ReadLine());
            int antecessor = n - 1;
            int sucessor = n + 1;
            WriteLine($"O antecessor de {n} é {antecessor}");
            WriteLine($"O sucessor de {n} é {sucessor}");

            WriteLine("Digite um numero:");
            double v = double.Parse(ReadLine());
            double d = v * 2;
            double t = v / 3;
            WriteLine($"O dobro de {v} é {d}");
            WriteLine($"A terça parte de {v} é {t}");

            WriteLine("Digite uma distancia em metros:");
            double M = float.Parse(ReadLine());
            double KM = M / 1000;
            double HM = M / 100;
            double DAM = M / 10;
            double DM = M * 10;
            double CM = M * 100;
            double MM = M * 1000;
            WriteLine($"A distancia de {M} metros corresponde a:");
            WriteLine($"{KM}Km");
            WriteLine($"{HM}Hm");
            WriteLine($"{DAM}Dam");
            WriteLine($"{DM}dm");
            WriteLine($"{CM}cm");
            WriteLine($"{MM}mm");

            WriteLine("Quantos reais você tem:");
            double R = double.Parse(ReadLine());
            double D = R / 3.45;
            WriteLine($"Você tem o equivalente a {D} dolares");

            WriteLine("Digite a altura da parede em metros:");
            double A = double.Parse(ReadLine());
            WriteLine("Digite a largura da parede em metros:");
            double L = double.Parse(ReadLine());
            double area = A * L;
            WriteLine($"A area da sua parede é de {area}M²");
            double tinta = area / 2;
            WriteLine($"Você irá precisar de {tinta} litros de tinta para pinta-la.");

        }
    }

}
