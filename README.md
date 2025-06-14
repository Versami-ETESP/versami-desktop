# 🖥️ VERSAMI DESKTOP

Esta aplicação é um dos componentes do Trabalho de Conclusão de Curso (TCC) técnico da **ETEC de São Paulo**, desenvolvida pelos alunos **Julia Belchior**, **Matheus Canesso**, **Thamiris Fernandes** e **Ygor Silva**.

## :warning: Atenção
Antes de iniciar a configuração da aplicação desktop, é **obrigatório executar todos os scripts de banco de dados** que estão disponíveis no repositório [`versami-documentacao`](https://github.com/Versami-ETESP/versami-documentacao)

## ☑️ Pré-requisitos

* Visual Studio instalado na máquina (versão compatível com Windows Forms e .NET Framework 4.7.2).
* Git instalado (opcional, mas recomendado).
* Banco de dados SQL Server com os scripts do projeto executados.

## :gear: Como configurar o projeto

### 1. Clonar o repositório

Se você **possui o Git instalado**, abra o terminal na pasta desejada e execute:

```bash
git clone https://github.com/Versami-ETESP/versami-desktop
```

Caso **não possua o Git**, acesse a página do repositório, clique no botão `Code` e depois em `Download ZIP`.

![image](https://github.com/user-attachments/assets/16fea5ed-b497-4368-bb49-43070a74cf43)

Depois de baixado, **extraia o arquivo ZIP** para uma pasta de sua escolha.

---
### 2. Abrir o projeto no Visual Studio

* Navegue até a pasta extraída
* Dê dois cliques no arquivo `versami-desktop.sln` para abrir o projeto no Visual Studio

![image](https://github.com/user-attachments/assets/3ef65e00-d97c-4324-a377-ed983ef1cb3f)

---

### 3. Configurar a conexão com o banco de dados

* No **Gerenciador de Soluções**, vá até: `versami-desktop > Util`
* Abra a classe `Conexao.cs`

 ![image](https://github.com/user-attachments/assets/7b578b6c-3f4a-4c01-9db9-4ede62b5f2e0)

 * **Na linha 21**, altere os valores de User ID e Password para as credenciais do seu SQL Server: 

```c#
String strConexao = "Password=<SEU_USUARIO>; Persist Security Info=True; User ID=<SUA_SENHA>; Initial Catalog=versami; Data Source=" + Environment.MachineName + "\\SqlExpress";
```
---

### :white_check_mark: Pronto!

Com tudo configurado, você pode executar a aplicação diretamente pelo Visual Studio, clicando em "Iniciar". Para entrar na aplicação você pode usar os seguintes logins de teste

| Login         | Senha    |
| :------------ | :------- |
| master-admin  | 12345678 |
| livros-admin  | 12345678 |
| moderador-admin | 12345678 |
| blog-admin    | 12345678 |

---

### 🚀 Executar via .EXE (opcional)

Se preferir executar a aplicação diretamente via `.exe`:

* No Visual Studio, vá até o menu `Compilação > Recompilar Solução`
* Após a compilação, abra a pasta do projeto e navegue até: `versami-desktop > bin > Debug > versami-desktop.exe`

![image](https://github.com/user-attachments/assets/90de1aee-11bb-40ca-83f8-d3fe92de5ac2)
