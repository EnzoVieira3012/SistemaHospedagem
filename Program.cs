using System;
using System.Collections.Generic;

namespace SistemaHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Hospedagem!");

            Console.WriteLine("\nInforme os dados da suíte:");
            string tipoSuite = string.Empty;
            do
            {
                Console.Write("Tipo da suíte: ");
                tipoSuite = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(tipoSuite))
                {
                    Console.WriteLine("O tipo da suíte não pode ser vazio. Tente novamente.");
                }
            } while (string.IsNullOrEmpty(tipoSuite));

            int capacidadeSuite = 0;
            do
            {
                Console.Write("Capacidade da suíte (quantidade máxima de hóspedes): ");
                string? capacidadeInput = Console.ReadLine();
                if (string.IsNullOrEmpty(capacidadeInput) || !int.TryParse(capacidadeInput, out capacidadeSuite) || capacidadeSuite <= 0)
                {
                    Console.WriteLine("Capacidade inválida. Insira um número maior que zero.");
                }
            } while (capacidadeSuite <= 0);

            decimal valorDiaria = 0;
            do
            {
                Console.Write("Valor da diária: ");
                string? valorDiariaInput = Console.ReadLine();
                if (string.IsNullOrEmpty(valorDiariaInput) || !decimal.TryParse(valorDiariaInput, out valorDiaria) || valorDiaria <= 0)
                {
                    Console.WriteLine("Valor inválido. Insira um número maior que zero.");
                }
            } while (valorDiaria <= 0);

            Suite suite = new Suite(tipoSuite, capacidadeSuite, valorDiaria);

            int diasReservados = 0;
            do
            {
                Console.Write("\nQuantos dias deseja reservar? ");
                string? diasReservadosInput = Console.ReadLine();
                if (string.IsNullOrEmpty(diasReservadosInput) || !int.TryParse(diasReservadosInput, out diasReservados) || diasReservados <= 0)
                {
                    Console.WriteLine("Número de dias inválido. Insira um número maior que zero.");
                }
            } while (diasReservados <= 0);

            Reserva reserva = new Reserva(diasReservados);
            reserva.CadastrarSuite(suite);

            int quantidadeHospedes = 0;
            do
            {
                Console.Write("\nQuantos hóspedes irão se hospedar? ");
                string? quantidadeHospedesInput = Console.ReadLine();
                if (string.IsNullOrEmpty(quantidadeHospedesInput) || !int.TryParse(quantidadeHospedesInput, out quantidadeHospedes) || quantidadeHospedes <= 0)
                {
                    Console.WriteLine("Quantidade inválida. Insira um número maior que zero.");
                }
            } while (quantidadeHospedes <= 0);

            List<Pessoa> hospedes = new List<Pessoa>();

            for (int i = 0; i < quantidadeHospedes; i++)
            {
                Console.WriteLine($"\nDigite os dados do hóspede {i + 1}:");

                string nomeHospede = string.Empty;
                do
                {
                    Console.Write("Nome: ");
                    nomeHospede = Console.ReadLine() ?? "";
                    if (string.IsNullOrEmpty(nomeHospede))
                    {
                        Console.WriteLine("O nome do hóspede não pode ser vazio. Tente novamente.");
                    }
                } while (string.IsNullOrEmpty(nomeHospede));

                int idadeHospede = 0;
                do
                {
                    Console.Write("Idade: ");
                    string? idadeInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(idadeInput) || !int.TryParse(idadeInput, out idadeHospede) || idadeHospede < 0)
                    {
                        Console.WriteLine("Idade inválida. Insira um número maior ou igual a zero.");
                    }
                } while (idadeHospede < 0);

                hospedes.Add(new Pessoa(nomeHospede, idadeHospede));
            }

            try
            {
                reserva.CadastrarHospedes(hospedes);

                Console.WriteLine("\nReserva cadastrada com sucesso!");
                Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Valor total da reserva: R$ {reserva.CalcularValorDiaria():F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar a reserva: {ex.Message}");
            }
        }
    }
}