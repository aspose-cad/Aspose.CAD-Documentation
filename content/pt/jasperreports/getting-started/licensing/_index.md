---
title: Licenciamento
type: docs
weight: 40
url: /pt/jasperreports/getting-started/licensing/
---
## **Chamar setLicense**
Para aplicar uma licença:

Salve o arquivo de licença em uma pasta no seu disco. Por exemplo C:\Lic\Aspose.CAD.JasperReport.lic.
Chame o método License.setLicense(filename) e passe o nome do arquivo como argumento. Quando essa instrução for chamada, a licença é definida e a mensagem de avaliação não aparecerá mais no topo das imagens.
O seguinte snippet de código define a licença para Aspose.CAD para JasperReports.

{{< highlight java >}}

// Definir licença

License lic = new License();

lic.setLicense("C:\Lic\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Você precisa chamar o método setLicense() apenas uma vez por processo ou aplicação.

{{% /alert %}}

## **Definir o parâmetro de licença Exporter em applicationContext.xml**
{{% alert color="primary" %}}
Este método é aplicável para uso com JasperServer.
{{% /alert %}}
1. Baixe a licença para o seu computador e copie-a para a pasta \apache-tomcat\webapps\jasperserver\WEB-INF, onde está o diretório de instalação do JasperServer.
2. Localize o arquivo \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml e adicione as seguintes linhas:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
