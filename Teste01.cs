class Teste01{

   /* Teste 01: Exibir média do Aluno
    Problema: O Professor de uma escola precisa calcular a média anual dos seus
    alunos, para isso ele deseja um sistema que ele informe a nota do primeiro e do
    segundo semestre, e que esse sistema exibe qual é a média.*/

    static void Main(){

        Console.WriteLine("Digite a nota do primeiro semestre: ");
        double notaPrimeiroSemestre = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota do segundo semestre: ");
        double notaSegundoSemestre = Convert.ToDouble(Console.ReadLine());

        double mediaAnual = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;

        Console.WriteLine("A média anual do aluno é: " + mediaAnual);

    }

}
