﻿namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }
        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            // Console.WriteLine("Criando funcionário");
        }

        public abstract void AumentarSalario();
    }
}
