---
title: Impostare il timeout durante il salvataggio
type: docs
weight: 70
url: /it/java/developer-guide/set-timeout-on-save/
---

## **Impostare il timeout durante il salvataggio**

Aspose.CAD per l'API Java consente di impostare un timeout durante il salvataggio. Questo potrebbe essere utile nei casi in cui il processo di salvataggio richiede molto tempo o consuma molta memoria. Per questo, l'API fornisce la [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) classe. La [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) classe fornisce un token che viene utilizzato per interrompere operazioni prolungate.

## Codice di esempio

Il seguente frammento di codice dimostra l'uso della [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) classe.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
