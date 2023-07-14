class Testes{

    public static void Main(){

        Console.WriteLine("ESCOLHA O TESTE QUE DESEJA EXECUTAR: ");
        Console.WriteLine("TESTE 01 - Exibir média do Aluno");
        Console.WriteLine("TESTE 02 - Exibir média do Aluno recebendo (x) quantidade de Notas");
        int option = Convert.ToInt32(Console.ReadLine());

        if(option == 1){
            Testes.executarTeste01();
        }else{
            Testes.executarTeste02();
        }

    }

    /*Teste 01: Exibir média do Aluno

    Problema: O Professor de uma escola precisa calcular a média anual dos seus
    alunos, para isso ele deseja um sistema que ele informe a nota do primeiro e do
    segundo semestre, e que esse sistema exibe qual é a média.*/
    public static void executarTeste01(){

        Console.WriteLine("Digite a nota do primeiro semestre: ");
        double notaPrimeiroSemestre = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota do segundo semestre: ");
        double notaSegundoSemestre = Convert.ToDouble(Console.ReadLine());

        double mediaAnual = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;

        Console.WriteLine("A média anual do aluno é: " + mediaAnual);

    }


    /*Teste 02: Exibir média do Aluno recebendo (x) quantidade de Notas

    Problema: Um aluno tem várias provas durante o ano e deseja um sistema que ele
    informe o Seu Nome e a nota que recebeu.

    Observação: Para cada nota informada deve ser exibido o nome do aluno, a
    quantidade de provas, o total de notas, e qual a média desse aluno.*/
    public static void executarTeste02(){

        Console.WriteLine("Digite o nome do aluno: ");
        string nomeAluno = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de notas: ");
        int quantidadeNotas = Convert.ToInt32(Console.ReadLine());

        double somaNotas = 0;

        for (int i = 1; i <= quantidadeNotas; i++)
        {
            Console.WriteLine("Digite a nota " + i + ": ");
            double nota = Convert.ToDouble(Console.ReadLine());
            somaNotas += nota;
        }

        double media = somaNotas / quantidadeNotas;

        Console.WriteLine("Nome do aluno: " + nomeAluno);
        Console.WriteLine("Quantidade de provas: " + quantidadeNotas);
        Console.WriteLine("Total de notas: " + somaNotas);
        Console.WriteLine("Média do aluno: " + media);

    }

}