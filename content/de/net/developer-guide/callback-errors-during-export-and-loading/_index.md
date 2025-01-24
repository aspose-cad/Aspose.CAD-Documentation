---
title: Callback-Fehler während des Exports und Ladevorgangs
type: docs
weight: 40
url: /de/net/callback-errors-during-export-and-loading/
---

## **Überblick über Callback-Fehler während des Exports und Ladevorgangs**

Es ist möglich, dass wir während des Exports oder beim Laden der Zeichnung auf Fehler stoßen, die mit der Struktur der Datei zusammenhängen 
(z.B. sind jetzt Abschnitte in der Datei erforderlich, die zuvor nicht erforderlich waren). 
Einige davon sind kritisch, und in solchen Fällen wird eine Ausnahme ausgelöst, aber wir können auch einige von ihnen intern ignorieren und über Callback-Nachrichten darüber informieren.
Jedenfalls erfordern all diese Nachrichten Aufmerksamkeit, da sie beispielsweise fehlende Entitäten in den Exportergebnissen oder andere Effekte erklären können.


### **Fehler während des Exports**

Es gibt das Feld RenderResult in [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
das IsRenderComplete enthält, um zu erfahren, ob während des Exports Fehler aufgetreten sind, und Informationen darüber zu drucken:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Fehler während des Ladens**

Einige Probleme mit Zeichnungen können bereits beobachtet werden, bevor der Exportprozess beginnt. 
Die [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) Eigenschaft im
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) Objekt wird verwendet, um Nachrichten über diese zu speichern.
Die [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) Eigenschaft ist nützlich, um zu entscheiden, ob 
es erforderlich ist, bei Ladefehlern eine Ausnahme auszulösen oder nicht.

Hier ist ein Beispiel für die Verwendung der Errors-Eigenschaft:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
