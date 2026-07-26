using TesteDeIdades;

List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa { Nome= "Ana", Idade = 25},
    new Pessoa { Nome = "Carlos", Idade = 17},
    new Pessoa { Nome = "Beatriz", Idade = 42},
    new Pessoa { Nome = "Daniel", Idade = 15},
    new Pessoa { Nome = "Eduardo", Idade = 30}

};
//validação inicial 
if (pessoas == null || pessoas.Count == 0)
{
    System.Console.WriteLine("A lista está vazia/nula");
    return;
}
//VARIÁVEIS
int maiorIdade = 0;
string nomeDoMaisVelho = string.Empty;

// Adicionando a constante MaxValue pois dessa forma a menor idade consegue substituir a variável
int menorIdade = int.MaxValue;
string nomeMaisNovo = string.Empty;
int somaIdades = 0;

//LAÇO
foreach (Pessoa i in pessoas)
{
    // condição para avaliar o mais velho
    if (i.Idade > maiorIdade)
    {
        maiorIdade = i.Idade;
        nomeDoMaisVelho = i.Nome;
    }

    //condição para avaliar o mais novo
    if (i.Idade < menorIdade)
    {
        menorIdade = i.Idade;
        nomeMaisNovo = i.Nome;
    }

    somaIdades += i.Idade;

}

double mediaIdades = (double)somaIdades / pessoas.Count;
ExibirDados(nomeDoMaisVelho, maiorIdade, nomeMaisNovo, menorIdade, mediaIdades);

void ExibirDados(string nomeDoMaisVelho, int maiorIdade, string nomeMaisNovo, int idadeNovo, double media)
{
    System.Console.WriteLine($"O nome do mais velho é: {nomeDoMaisVelho} ele possui {maiorIdade} anos");
    System.Console.WriteLine($"O nome do mais novo é: {nomeMaisNovo} ele possui {idadeNovo} anos");
    System.Console.WriteLine($"A média da idade desse grupo de pessoas é de {media} anos.");

}

