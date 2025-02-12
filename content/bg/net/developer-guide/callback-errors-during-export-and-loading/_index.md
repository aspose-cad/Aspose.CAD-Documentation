---
title: Грешки при обратен извикване по време на експортиране и зареждане
type: docs
weight: 40
url: /bg/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Преглед на грешките при обратен извикване по време на експортиране и зареждане**

Възможно е по време на експортиране или зареждане на чертежа да се сблъскаме с грешки, свързани със структурата на файла 
(например, секции в файла са необходими сега, но не и преди). 
Някои от тях са критични и в такива случаи се хвърля изключение, но можем да игнорираме и някои от тях вътрешно и да уведомим за това с помощта на съобщения за обратен извикване.
Както и да е, всички тези съобщения изискват внимание, тъй като те могат да обяснят например отсъстващи единици в резултатите от експортиране или други ефекти.


### **Грешки по време на експортиране**

Съществува поле RenderResult в [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
което включва IsRenderComplete, за да се провери дали е имало грешки по време на експортиране и да се отпечата информация за тях:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Грешки по време на зареждане**

Някои проблеми с чертежите могат да бъдат наблюдавани по-рано, преди да започне процесът на експортиране. 
Свойството [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) в
обекта [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) се използва за съхранение на съобщения за тях.
Свойството [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) е полезно, за да се реши дали 
е необходимо да се хвърля изключение при грешки при зареждане или не.

Ето пример за използването на свойството Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
