﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("-----------------------Seja bem vindo ao sistema de estacionamento!--------------------\n" +
                  "Digite o preço inicial: ");

Console.WriteLine();
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("------------------------------Agora introduza o preço por hora -------------------------------\n");
precoHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    //Console.Clear();
    Console.WriteLine("----------------------------     Digite a sua opção: -------------------------------------\n");
    Console.WriteLine("1 - Cadastrar veículo\n");
    Console.WriteLine("2 - Remover veículo\n");
    Console.WriteLine("3 - Listar veículos\n");
    Console.WriteLine("4 - Encerrar\n");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.listarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("                  Opção inválida");
            break;
    }

    Console.WriteLine("                  Pressione uma tecla para continuar\n");
    Console.ReadLine();
}

Console.WriteLine("                         O programa foi encerrado!");
