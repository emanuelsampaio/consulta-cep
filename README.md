<img src="https://raw.githubusercontent.com/emanuelsampaio/consulta-cep/main/Api/wwwroot/swagger/cep/img/logo.png" alt="API CONSULTA CEP" />

# API CONSULTA CEP

Projeto desenvolvido com o intuito de disponibilizar via rest, a consulta de CEP nos principais serviços gratuitos.


## Tecnologias 🚀

- .NET 8
- Swagger
- Visual Studio 2022


## Estrutura 📚

A solução **consulta-cep** possui dois projetos, conforme a seguir:

- **Api** : Projeto API Web do ASP.NET Core contendo todos os endpoints para consulta de CEP. Possui o projeto *Dominio* como dependência, além dos pacotes *Newtonsoft.Json 13.0.3* (para desserialização JSON) e *Swashbuckle.AspNetCore 6.4.0* (para documentação da API via Swagger);
- **Dominio** : Projeto de Biblioteca de Classes C# contendo todas as entidades de negócio utilizadas pela aplicação. Este projeto não possui dependências.

<img src="https://raw.githubusercontent.com/emanuelsampaio/consulta-cep/main/Screenshots/1.png" alt="Estutura" />


## Funcionalidades 🔥

Consultas de CEP nos seguintes serviços:

- Brasil Aberto;
- Via CEP;
- Open CEP;
- Brasil API;
- Api CEP;
- República Virtual.

<img src="https://raw.githubusercontent.com/emanuelsampaio/consulta-cep/main/Screenshots/2.png" alt="Swagger" />


## Instalação 🔨

- `git clone https://github.com/emanuelsampaio/consulta-cep`


---

##### Desenvolvimento: <http://www.emanuelsampaio.com.br>