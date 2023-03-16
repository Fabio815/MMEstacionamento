# MMEstacionamento
Projeto de estacionamento

Esse projeto tem o intuito de cadastrar carros e motos em um estacionamento. Com base na sua data de entrada calculamos o quanto o cliente irá pagar.
Estou usando o SqlServer como banco de dados, fazendo um banco de dados não relacional (NoSql), porque é mais fácil de se lidar com ele. No próprio Visual Studio eu posso
criar um banco de dados.

O que cada classe faz:
  SqlServerClass -> Essa classe vai abrir a conexão com o banco de dados, e nela que vamos armazenar os métodos de SqlCommand(esse método vai executar comandos 
alteração no banco), SqlQuery(comando que vai executar busca no banco) e Close para fechar a conexão com o banco.
  
  FicharioDB -> Chamando o classe do SqlServerClass vou abrir uma conexão com banco. Nessa classe vamos ter os atributos de: mensagem(vai guardar a mengem da execessão),
  status(se as ações deu certo ao não), tabela(é a tabela que quero mexer) e db(conexão com o banco). Também vou ter o CRUD.
  
  Veiculo -> Nessa Classe terá o Desseralize, Serializa, atributos do veículo e a chamada do CRUD da FicharioDB, com isso nos podemos manipular os atributos do veículo.
