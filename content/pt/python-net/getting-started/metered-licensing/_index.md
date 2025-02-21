---
title: Licenciamento Medido
type: docs
weight: 40
url: /pt/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permite que os desenvolvedores apliquem a chave medida. É um novo mecanismo de licenciamento. O novo mecanismo de licenciamento será usado junto com o método de licenciamento existente. Aqueles clientes que desejam ser cobrados com base no uso dos recursos da API podem usar o licenciamento medido. Para mais detalhes, consulte a seção [Perguntas Frequentes sobre Licenciamento Medido](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenciamento Medido**
Aqui estão os passos simples para usar a classe Metered.

1. Crie uma instância da classe Metered.
1. Passe as chaves pública e privada para o método SetMeteredKey.
1. Faça o processamento (realize a tarefa).
1. Chame o método GetConsumptionQuantity da classe Metered.
1. Ele retornará a quantidade de solicitações da API que você consumiu até agora.

A seguir está o código de exemplo que demonstra como definir as chaves pública e privada medidas.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
