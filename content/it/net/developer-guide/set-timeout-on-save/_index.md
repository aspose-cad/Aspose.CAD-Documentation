---
title: Imposta timeout al salvataggio
type: docs
weight: 70
url: /it/net/developer-guide/set-timeout-on-save/
---

## **Imposta timeout al salvataggio**

Aspose.CAD per l'API .NET consente di impostare un timeout al salvataggio. Questo potrebbe essere utile nei casi in cui il processo di salvataggio richiede molto tempo o consuma molta memoria. Per questo, l'API fornisce la classe  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource). La classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) fornisce un token che viene utilizzato per interrompere le operazioni lunghe.

## Codice di esempio

Il seguente frammento di codice dimostra l'uso della classe [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
