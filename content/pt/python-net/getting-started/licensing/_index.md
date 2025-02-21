---
title: Licenciamento
type: docs
weight: 40
url: /pt/python-net/getting-started/licensing/
---
## **Chamar setLicense**
Para aplicar uma licença:

Salve o arquivo de licença em uma pasta no seu disco. Por exemplo C:\Lic\Aspose.CAD.Python.lic.
Chame o método License.set_license(nome_do_arquivo) e passe o nome do arquivo como um argumento. Quando esta instrução for chamada, a licença será definida e a mensagem de avaliação não aparecerá mais no topo das imagens.
O seguinte trecho de código define a licença para Aspose.CAD para Python.

{{< highlight java >}}

// Defina a licença

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

Você precisa chamar o método set_license() apenas uma vez por processo ou aplicativo.

{{% /alert %}}

## **Defina o parâmetro do exportador de licença em applicationContext.xml**
{{% alert color="primary" %}}
Este método é aplicável para uso com JasperServer.
{{% /alert %}}
1. Baixe a licença para o seu computador e copie-a para a pasta \apache-tomcat\webapps\jasperserver\WEB-INF, onde indica o diretório de instalação do JasperServer.
2. Localize o arquivo \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml e adicione as seguintes linhas:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
