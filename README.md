# Sistema de Hospedagem 🏨

Sistema simples para gerenciar reservas de hospedagem em um hotel. Permite cadastrar hóspedes, associá-los a uma suíte e calcular o valor total da diária, com desconto para estadias longas.

## Funcionalidades

- Cadastro de hóspedes.
- Cadastro de suítes.
- Relacionamento entre hóspedes e suíte.
- Cálculo do valor total da reserva.
- Aplicação de desconto de 10% para reservas com mais de 10 dias.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET
- **IDE:** Visual Studio Code

## Como Executar

1. Certifique-se de que o .NET SDK está instalado em sua máquina.
2. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/SistemaHospedagem.git
Navegue até o diretório do projeto:
bash
Copy
cd SistemaHospedagem
Execute o projeto:
bash
Copy
dotnet run
Estrutura do Projeto
Pessoa: Representa um hóspede com nome e idade.
Suíte: Representa uma suíte com tipo, capacidade e valor da diária.
Reserva: Faz o relacionamento entre os hóspedes e a suíte, controla a quantidade de dias reservados e calcula o valor total.
Melhorias Futuras
Validação de dados mais robusta.
Persistência de dados em banco de dados.
Interface gráfica para facilitar o uso.
Logs para registrar as ações realizadas.
Autor
Desenvolvido por Enzo Vieira
[GitHub](https://github.com/EnzoVieira3012) | [LinkedIn](https://www.linkedin.com/in/enzovieiratrabalho/)
