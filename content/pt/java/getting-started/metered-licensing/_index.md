---
title: Licenciamento Medido
type: docs
weight: 60
url: /pt/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permite que os desenvolvedores apliquem uma chave medida. É um novo mecanismo de licenciamento. O novo mecanismo de licenciamento será utilizado juntamente com o método de licenciamento existente. Aqueles clientes que desejam ser cobrados com base no uso dos recursos da API podem usar o licenciamento medido. Para mais detalhes, consulte a seção [FAQ sobre Licenciamento Medido](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenciamento Medido**
Aqui estão os passos simples para usar a classe Metered.

1. Crie uma instância da classe Metered.
1. Passe as chaves pública e privada para o método setMeteredKey.
1. Realize o processamento (execute a tarefa).
1. chame o método getConsumptionQuantity da classe Metered.
1. Ele retornará a quantidade de solicitações da API que você consumiu até agora.

Abaixo está um código de exemplo que demonstra como configurar a chave pública e privada medida:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
