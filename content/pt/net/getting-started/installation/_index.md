---
title: Instalação
type: docs
weight: 30
url: /pt/net/getting-started/installation/
---

## **Instalando Aspose.CAD para .NET através do NuGet**

NuGet é a maneira mais fácil de baixar e instalar APIs Aspose para .NET. Abra o Microsoft Visual Studio e o gerenciador de pacotes NuGet. Pesquise "aspose" para encontrar a API Aspose desejada. Clique em "Instalar", a API selecionada será baixada e referenciada em seu projeto.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **Referenciando Aspose.CAD de um Projeto .NET**

Siga estas etapas (presumindo que você use o Microsoft Visual Studio):

1. No **Explorador de Soluções**, expanda o nó do projeto ao qual você deseja adicionar uma referência.
1. Clique com o botão direito do mouse no nó **Referências** do projeto e selecione **Adicionar Referência** no menu de atalho.
1. Na caixa de diálogo **Adicionar Referência**, navegue até o local do arquivo DLL.
1. Selecione o arquivo DLL *Aspose.CAD* e clique no botão **OK**.
1. A referência *Aspose.CAD* aparecerá sob o nó **Referências** do seu projeto.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **Instalar ou Atualizar Aspose.CAD usando o Console do Gerenciador de Pacotes**

Você pode seguir os passos abaixo para referenciar a [API Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) usando o console do gerenciador de pacotes:

1. Abra sua solução/projeto no Visual Studio.
1. Selecione Ferramentas -> Gerenciador de Pacotes da Biblioteca -> Console do Gerenciador de Pacotes no menu para abrir o console do gerenciador de pacotes.

![todo:image_alt_text](/_assets/install/installation_3.png)

Digite o comando “**Install-Package Aspose.CAD**” e pressione enter para instalar a versão completa mais recente em sua aplicação. Alternativamente, você pode adicionar o sufixo "**-prerelease**" ao comando para especificar que a versão mais recente, incluindo correções, deve ser instalada também.

![todo:image_alt_text](/_assets/install/installation_4.png)

Você verá que a dica "Baixando Aspose.CAD..." aparece na parte inferior esquerda da janela, indicando que o download está em processo. 

![todo:image_alt_text](/_assets/install/installation_5.png)

Após o download, você verá as seguintes mensagens de confirmação. Se você não está familiarizado com o [EULA da Aspose](https://about.aspose.com/legal/eula), então é uma boa ideia ler a licença referenciada na URL.

![todo:image_alt_text](/_assets/install/installation_6.png)

Você agora deve encontrar que o Aspose.CAD foi adicionado e referenciado com sucesso em sua aplicação.

![todo:image_alt_text](/_assets/install/installation_7.png)

No console do gerenciador de pacotes, você também pode usar o comando “**Update-Package Aspose.CAD**” e pressionar enter para verificar se há atualizações para o pacote Aspose.CAD e instalá-las, se presente. Você também pode adicionar o sufixo "-prerelease" para atualizar à versão mais recente.

## **Considerações ao Executar em um Ambiente de Servidor Compartilhado**

Todos os componentes Aspose .NET são recomendados para serem executados com o conjunto de permissões Full Trust. Isso ocorre porque os componentes Aspose .NET às vezes precisam acessar configurações do registro e arquivos localizados em lugares diferentes do diretório virtual, por exemplo, para leitura de fontes, etc. Além disso, os componentes Aspose.NET são baseados nas classes principais do sistema .NET, algumas das quais também exigem permissões de Full Trust para serem executadas em alguns casos.

Provedores de Serviços de Internet que hospedam várias aplicações de diferentes empresas, em sua maioria, impõem o nível de segurança Medium Trust. No caso do .NET 2.0, tal nível de segurança pode estabelecer as seguintes restrições, que podem afetar a capacidade do Aspose.CAD de funcionar corretamente.

- **RegistryPermission** não está disponível. Isso significa que você não pode acessar o registro, que é necessário para enumerar fontes instaladas ao renderizar documentos.
- **FileIOPermission** é restringido. Isso significa que você só pode acessar arquivos na hierarquia do diretório virtual de sua aplicação. Isso potencialmente significa que fontes não podem ser lidas durante a exportação.

Por essas razões especificadas acima, é recomendado que o Aspose.CAD seja executado com permissões Full Trust. Você pode descobrir que alguns recursos da biblioteca funcionarão ao realizar diferentes tarefas em Medium trust, enquanto outros não funcionarão (renderização, por exemplo), o que pode ser devido a chamadas para o processamento de imagens GDI+.

## **Requisitos do Sistema**

### **Sistemas Operacionais**

Aspose.CAD para .NET suporta quaisquer sistemas operacionais de 32 bits ou 64 bits onde o .NET ou o framework Mono estão instalados, incluindo, mas não se limitando a:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) e sistemas operacionais de servidor (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS e outros)
- Mac OS X

### **Frameworks**

Aspose.CAD para .NET suporta:

- Versões do .NET Framework de 2.0 a 4.5, incluindo versões do Client Profile
- .NET Core
- Mono 2.6.7 ou posterior

### **Ambientes de Desenvolvimento**

Você pode usar o Aspose.CAD para .NET para desenvolver aplicações em qualquer ambiente de desenvolvimento que seja direcionado à plataforma .NET, mas os seguintes ambientes são explicitamente suportados:

- Microsoft Visual Studio 2010 ou Superior
- MonoDevelop 2.4 e posterior
