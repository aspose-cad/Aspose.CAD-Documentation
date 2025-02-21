---
title: Como Executar os Exemplos
type: docs
weight: 70
url: /pt/net/showcases/how-to-run-the-examples/
---

## **Requisitos de Software**

Por favor, certifique-se de atender aos seguintes requisitos antes de baixar e executar os exemplos.

1. Visual Studio 2010 ou superior
1. Gerenciador de Pacotes NuGet instalado no Visual Studio. Certifique-se de que a versão mais recente da API NuGet esteja instalada no Visual Studio. Para detalhes sobre como instalar o gerenciador de pacotes NuGet, consulte https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Vá para Ferramentas->Opções->Gerenciador de Pacotes NuGet->Fontes de Pacotes e certifique-se de que a opção **nuget.org** esteja marcada
1. O projeto de exemplo utiliza o recurso de Restauração Automática de Pacotes do NuGet, portanto, você deve ter uma conexão ativa à internet. Se você não tiver uma conexão ativa à internet na máquina onde os exemplos serão executados, consulte [Instalação](/pt/cad/net/installation/) para adicionar referência ao Aspose.CAD.dll no projeto de exemplo.

## **Baixar do GitHub**

Todos os exemplos do Aspose.CAD para .NET estão hospedados no [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Você pode clonar o repositório usando seu cliente GitHub favorito ou baixar o arquivo ZIP [aqui](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Extraia o conteúdo do arquivo ZIP para qualquer pasta em seu computador. Todos os exemplos estão localizados na pasta **Examples**.
- Há um arquivo de solução do Visual Studio para C#.
- Os projetos foram criados no Visual Studio 2013, mas os arquivos de solução são compatíveis com o Visual Studio 2010 SP1 e superior.
- Abra o arquivo de solução no Visual Studio e construa o projeto.
- Na primeira execução, as dependências serão baixadas automaticamente via NuGet.
- A pasta **Data** na pasta raiz de **Examples** contém arquivos de entrada que os exemplos em CSharp utilizam. É obrigatório que você baixe a pasta **Data** juntamente com o projeto de exemplos.
- Abra o arquivo RunExamples.cs, todos os exemplos são chamados a partir daqui.
- Descomente os exemplos que você deseja executar dentro do projeto.

Sinta-se à vontade para entrar em contato através dos nossos Fóruns se você tiver algum problema para configurar ou executar os exemplos.

## **Contribuir**

Se você deseja adicionar ou melhorar um exemplo, encorajamos você a contribuir para o projeto. Todos os exemplos e projetos de vitrine neste repositório são de código aberto e podem ser usados livremente em suas próprias aplicações.

Para contribuir, você pode fazer um fork do repositório, editar o código-fonte e criar um pull request. Nós revisaremos as alterações e as incluiremos no repositório se forem consideradas úteis.
