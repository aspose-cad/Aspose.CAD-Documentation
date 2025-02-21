---
title: Como Executar os Exemplos
type: docs
weight: 70
url: /pt/java/getting-started/how-to-run-the-examples/
---

## **Baixar do GitHub**

Todos os exemplos de Aspose.CAD para Java estão hospedados no [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Você pode clonar o repositório usando seu cliente GitHub favorito ou baixar o arquivo ZIP [aqui](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Extraia o conteúdo do arquivo ZIP para qualquer pasta em seu computador. Todos os exemplos estão localizados na pasta **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figura: Diretório de Exemplos Aspose.CAD**|

## **Importar exemplos para o IDE**

O projeto utiliza o sistema de construção Maven. Qualquer IDE moderna pode facilmente abrir ou importar o projeto e suas dependências. Abaixo mostramos como usar IDEs populares para compilar e executar os exemplos.

### **IntelliJ IDEA**

Clique no menu **File** e escolha **Open**. Navegue até a pasta do projeto e selecione o arquivo **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Figura: Selecionar Arquivo ou Diretório para Importar**|
Ele abrirá o projeto e baixará as dependências automaticamente. Na aba Project, navegue pelos exemplos na pasta **src/main/java**. Para executar um exemplo, basta clicar com o botão direito no arquivo e escolher "Run ..", o exemplo será executado e a saída será exibida na janela de saída do console embutido.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Figura: Executar Exemplo**|

### **Eclipse**

Clique no menu **File** e escolha **Import**. Selecione **Maven** - Existing Maven Projects.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Figura: Importar**|
Navegue até a pasta que você clonou ou baixou do GitHub e selecione o arquivo **pom.xml**. Ele abrirá o projeto e baixará as dependências automaticamente. Na aba Package Explorer, navegue pelos exemplos na pasta **src/main/java**. Para executar um exemplo, basta clicar com o botão direito no arquivo e escolher **Run As** - **Java Application**, o exemplo será executado e a saída será exibida na janela de saída do console embutido.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figura: Executar Exemplo**|

### **NetBeans**

Clique no menu **File** e escolha **Open Project**. Navegue até a pasta que você clonou ou baixou do GitHub. O ícone da pasta **Examples** mostrará que é um projeto Maven. Selecione Examples e abra-o.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Figura: Abrir Projeto**|
Ele abrirá o projeto e baixará as dependências automaticamente. Na aba Projects, navegue pelos exemplos nos **source packages**. Para executar um exemplo, basta clicar com o botão direito no arquivo e escolher **Run File**, o exemplo será executado e a saída será exibida na janela de saída do console embutido.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Figura: Executar Exemplo**|

## **Adicionar a Biblioteca Aspose.CAD ao Repositório Local do Maven**

Quando você importa o projeto **Aspose.CAD Examples** para o IDE, o Maven baixa automaticamente o arquivo JAR aspose.cad do [Repositório Maven da Aspose](https://releases.aspose.com/java/repo/). Caso você não tenha acesso à internet, pode adicionar manualmente o JAR ao seu repositório local.

### **mvn install**

Baixe o [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), extraia-o e copie o aspose.cad-version.jar para outro lugar, por exemplo, no disco C. Emita o seguinte comando:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Agora, o JAR **aspose.cad** está copiado para o seu repositório local do Maven.

### **pom.xml**

Após a instalação, declare as coordenadas **aspose.cad** no pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Concluído**

Construa-o, agora o JAR **aspose.cad** pode ser recuperado do seu repositório local do Maven.

## **Contribuir**

Se você deseja adicionar ou melhorar um exemplo, incentivamos você a contribuir para o projeto. Todos os exemplos e projetos de demonstração neste repositório são de código aberto e podem ser usados livremente em suas próprias aplicações.

Para contribuir, você pode bifurcar o repositório, editar o código-fonte e enviar um Pull Request. Nós revisaremos as mudanças e as incluiremos no repositório, se forem consideradas úteis.
