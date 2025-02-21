---
title: Erros de callback durante a exportação e carregamento
type: docs
weight: 40
url: /pt/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Revisão dos erros de callback durante a exportação e carregamento**

É possível que durante a exportação ou carregamento do desenho possamos enfrentar erros relacionados à estrutura do arquivo 
(por exemplo, seções no arquivo agora são necessárias, mas não eram anteriormente). 
Alguns deles são críticos e, nesses casos, a exceção é lançada, mas também podemos ignorar alguns deles internamente e notificar sobre isso usando mensagens de callback.
De qualquer forma, todas essas mensagens requerem atenção porque podem explicar, por exemplo, entidades faltando nos resultados da exportação ou outros efeitos.

### **Erros durante a exportação**

Há um campo RenderResult em [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
que inclui IsRenderComplete para verificar se houve erros durante a exportação e imprimir informações sobre eles:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Erros durante o carregamento**

Alguns problemas com desenhos podem ser observados antes mesmo do início do processo de exportação. 
A propriedade [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) no 
objeto [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) é usada para armazenar mensagens sobre esses problemas.
A propriedade [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) é útil para decidir se 
é necessário lançar exceção em caso de erros de carregamento ou não. 

Aqui está um exemplo de uso da propriedade Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
