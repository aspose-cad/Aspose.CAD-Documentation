---
title: Ошибки обратного вызова при экспорте и загрузке
type: docs
weight: 40
url: /ru/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Обзор ошибок обратного вызова при экспорте и загрузке**

Возможно, что во время экспорта или загрузки чертежа мы можем столкнуться с ошибками, связанными со структурой файла 
(например, разделы в файле теперь обязательны, а ранее не были). 
Некоторые из них критичны, и в таких случаях возникает исключение, но мы также можем игнорировать некоторые из них внутренне и уведомлять об этом с помощью сообщений обратного вызова.
В любом случае все эти сообщения требуют внимания, поскольку они могут объяснить, например, отсутствие сущностей в результатах экспорта или другие эффекты.

### **Ошибки при экспорте**

В [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) 
существует поле RenderResult, которое включает IsRenderComplete, чтобы узнать, были ли ошибки во время экспорта, и напечатать информацию о них:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Ошибки при загрузке**

Некоторые проблемы с чертежами могут быть замечены раньше, чем начнется процесс экспорта. 
Свойство [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) 
в объекте [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) используется для хранения сообщений о них.
Свойство [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) полезно для принятия решения о том, 
необходимо ли создавать исключение при ошибках загрузки или нет.

Вот пример использования свойства Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
