﻿using System;
using System.Globalization;
using exercicio_conta_bancaria;



// INSTANCIA

ContaBancaria conta;


Console.WriteLine("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.Write(" Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S')
{
    Console.WriteLine("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new ContaBancaria(numero, titular, depositoInicial);
}else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da Conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.WriteLine("Entre um valor para depósito: ");

double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine("Dados da conta atualizados: " );
Console.WriteLine(conta);


Console.WriteLine();
Console.WriteLine("Entre um valor para saque: ");

 quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);