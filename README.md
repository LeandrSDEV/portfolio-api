# 📌 Portfolio.Api

API desenvolvida em **ASP.NET Core** utilizando princípios de **Clean Architecture**.  
Ela fornece os dados consumidos pelo frontend do portfólio (Portfolio.Blazor), incluindo:

- Perfil profissional  
- Projetos  
- Habilidades  
- Contatos  

---

## 🚀 Tecnologias Utilizadas

- C# / .NET 8
- ASP.NET Core Web API
- Clean Architecture
- Entity Framework Core
- Swagger / OpenAPI
- Injeção de Dependência
- FluentValidation (Futuro)
- AutoMapper (Futuro)

---

## 📂 Estrutura da Solução (Clean Architecture)

- Portfolio.Api → camada de apresentação (controllers, endpoints)
- Portfolio.Application → regras de negócio (casos de uso, DTOs, handlers)
- Portfolio.Domain → entidades e interfaces
- Portfolio.Infrastructure → persistência, repositórios, serviços externos


---

## 🚀 Deploy

- A API será futuramente hospedada no Render.

---

## 📌 Status do Projeto

- Em desenvolvimento — endpoints básicos funcionando

- 🔜 Próximos passos:

Adicionar repositórios reais

Implementar banco de dados

Criar admin para cadastrar projetos

