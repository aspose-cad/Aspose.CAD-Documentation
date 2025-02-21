---
title: Licenciamento Medido
type: docs
weight: 60
url: /pt/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permite que desenvolvedores apliquem uma chave medida. Este é um novo mecanismo de licenciamento. O novo mecanismo de licenciamento será usado juntamente com o método de licenciamento existente. Aqueles clientes que desejam ser cobrados com base no uso dos recursos da API podem usar o licenciamento medido. Para mais detalhes, consulte a seção [Perguntas Frequentes sobre Licenciamento Medido](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenciamento Medido**
Aqui estão os passos simples para usar a classe Metered.

1. Crie uma instância da classe Metered.
1. Passe as chaves pública e privada para o método SetMeteredKey.
1. Faça o processamento (execute a tarefa).
1. Chame o método GetConsumptionQuantity da classe Metered.
1. Ele retornará a quantidade/quantidade de solicitações da API que você consumiu até agora.

A seguir está o código de amostra que demonstra como definir a chave pública e privada medida.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
