---
title: Licenciamento
type: docs
weight: 50
url: /pt/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Uma vez que você esteja satisfeito com sua avaliação do Aspose.CAD para .NET, compre uma licença no site da Aspose: [Portal de Compra](https://purchase.aspose.com/buy). Familiarize-se com os diferentes tipos de licenças disponíveis. Se você tiver alguma dúvida, [entre em contato com a equipe de vendas da Aspose](https://about.aspose.com/contact) e eles ficarão felizes em ajudar você.

Cada licença da Aspose inclui uma assinatura de um ano para upgrades gratuitos para novas versões ou correções que saírem durante esse período. Oferecemos suporte técnico gratuito e ilimitado tanto para usuários licenciados quanto para usuários de avaliação.

A licença é um arquivo XML em texto puro que contém detalhes como o nome do produto, número de desenvolvedores licenciados, data de expiração da assinatura e assim por diante. O arquivo é assinado digitalmente, então não modifique o arquivo: até mesmo adicionar uma quebra de linha extra ao arquivo o invalida.

{{% /alert %}}

## **Quando Aplicar uma Licença**

Siga estas regras simples:

- A licença só precisa ser configurada uma vez por domínio de aplicação.
- Você precisa definir a licença antes de usar quaisquer outras classes do Aspose.CAD.
- Chamar SetLicense várias vezes não é prejudicial, mas desperdiça tempo do processador.
- Se você estiver desenvolvendo um aplicativo Windows Forms ou console, chame SetLicense no código de inicialização, antes de usar as classes do Aspose.CAD.
- Ao desenvolver uma aplicação ASP.NET, chame SetLicense a partir do arquivo Global.asax.cs (Global.asax.vb), no método protegido Application_Start. Ele é chamado uma vez quando a aplicação é iniciada.
- Não chame SetLicense dentro dos métodos Page_Load, pois isso significa que a licença será carregada toda vez que uma página da web for carregada.
- Se você estiver desenvolvendo uma biblioteca de classes, chame SetLicense a partir de um construtor estático da classe que usa o Aspose.CAD. O construtor estático é executado antes que uma instância da sua classe seja criada, garantindo que a licença do Aspose.CAD seja configurada corretamente.

## **Aplicar Licença usando Arquivo ou Objeto Stream**

Use o **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** método para licenciar o componente. A maneira mais fácil de definir uma licença é colocar o arquivo de licença na mesma pasta que o Aspose.CAD.dll e especificar o nome do arquivo, sem um caminho, conforme mostrado abaixo.

### **Carregando uma Licença de um Arquivo**

Este trecho de código inicializa uma licença armazenada em um arquivo ou em um recurso embutido.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Carregando uma Licença de um Objeto Stream**

Este trecho de código inicializa a licença a partir do stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
