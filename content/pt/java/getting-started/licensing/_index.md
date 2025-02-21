---
title: Licenciamento
type: docs
weight: 50
url: /pt/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Você pode baixar uma versão de avaliação do **Aspose.CAD** para Java na [sua página de download](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). A versão de avaliação oferece absolutamente as mesmas capacidades que a versão licenciada do produto. Além disso, a versão de avaliação simplesmente se torna licenciada quando você compra uma licença e adiciona algumas linhas de código para aplicar a licença.

Uma vez que você esteja satisfeito com sua avaliação do **Aspose.CAD**, você pode [comprar uma licença](https://purchase.aspose.com/buy) no site da Aspose. Familiarize-se com os diferentes tipos de assinatura oferecidos. Se você tiver alguma dúvida, não hesite em contatar a equipe de vendas da Aspose.

Toda licença da Aspose inclui uma assinatura de um ano para upgrades gratuitos para quaisquer novas versões ou correções que forem lançadas durante esse tempo. O suporte técnico é gratuito e ilimitado, fornecido tanto para usuários licenciados quanto para usuários de avaliação.

{{% /alert %}}

Se você quiser testar o **Aspose.CAD** sem limitações da versão de avaliação, solicite uma licença temporária de 30 dias. Consulte [Como obter uma Licença Temporária?](https://purchase.aspose.com/temporary-license) para mais informações.

## **Definindo uma Licença**

A licença é um arquivo XML em texto simples que contém detalhes como o nome do produto, número de desenvolvedores licenciados, data de expiração da assinatura e assim por diante. O arquivo é digitalmente assinado, portanto, não modifique o arquivo; até mesmo a adição inadvertida de uma quebra de linha ao arquivo o invalidará.

Você precisa definir uma licença antes de realizar qualquer operação com arquivos AutoCAD. Você só precisa definir uma licença uma vez por aplicação ou processo.

A licença pode ser carregada de um stream ou arquivo nos seguintes locais:

1. Caminho explícito.
1. A pasta que contém o Aspose.CAD.jar.

Use o método License.setLicense() para licenciar o componente. Muitas vezes, a maneira mais fácil de definir uma licença é colocar o arquivo de licença na mesma pasta que o Aspose.CAD.jar e especificar apenas o nome do arquivo sem caminho, como mostrado no seguinte exemplo:

### **Exemplo 1**

Neste exemplo, **Aspose.CAD** tentará encontrar o arquivo de licença na pasta que contém os JARs da sua aplicação.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Exemplo 2**

Inicializa uma licença a partir de um stream.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Validar a Licença**

É possível validar se a licença foi definida corretamente ou não. A classe License tem o campo isLicensed que retornará verdadeiro se a licença tiver sido definida corretamente.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Licença está Definida!");

}

{{< /highlight >}}
