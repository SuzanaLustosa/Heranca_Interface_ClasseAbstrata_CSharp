using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region código comentado
//Funcionario pedro  = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registar(pedro);
//gerenciador.Registar(roberta);

//Console.WriteLine($"Total de bonificações: R${gerenciador.TotalDeBonificao}");
//Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"O novo salário do Pedro é R${pedro.Salario}");
//Console.WriteLine($"O novo salário da Roberta é R${roberta.Salario}");
#endregion

// CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456789");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987654321");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("789456123");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("321654987");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registar(camila);
    gerenciador.Registar(igor);
    gerenciador.Registar(paula);
    gerenciador.Registar(ulisses);

    Console.WriteLine($"Total de bonificação R${gerenciador.TotalDeBonificao}");
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("321456987");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("852147963");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "321");
    sistema.Logar(ursula, "321");

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";
    sistema.Logar(caio, "999");
}