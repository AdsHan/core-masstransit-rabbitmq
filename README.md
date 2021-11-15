# core-masstransit-rabbitmq
Demonstração da utilização do MassTransit em conjunto com o RabbitMQ. Foi criado um `Publisher` para gerar as mensagens e um `Worker` para o consumo. Foram geradas mensagens do tipo `command` (**Send**) e `event` (**Publish**) para validação de como o MassTransit trabalha no roteamento entre as Exchanges e Queues.

# Este projeto contém:
- MassTransit;
- RabbitMQ;

# Como executar:
Clonar / baixar o repositório em seu workplace.
Baixar o .Net Core SDK e o Visual Studio / Code mais recentes.
A infraestrutura da aplicação será criada através do docker compose /docker/docker_infrastructure.yml.


# Sobre
Este projeto foi desenvolvido por Anderson Hansen sob [MIT license](LICENSE).