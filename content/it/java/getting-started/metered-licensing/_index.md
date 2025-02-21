---
title: License a consumo
type: docs
weight: 60
url: /it/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD consente agli sviluppatori di applicare una chiave a consumo. È un nuovo meccanismo di licenza. Il nuovo meccanismo di licenza sarà utilizzato insieme al metodo di licenza esistente. I clienti che desiderano essere fatturati in base all'utilizzo delle funzionalità dell'API possono utilizzare la licenza a consumo. Per ulteriori dettagli, si prega di fare riferimento alla sezione [FAQ sulla licenza a consumo](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenza a consumo**
Ecco i semplici passaggi per utilizzare la classe Metered.

1. Crea un'istanza della classe Metered.
1. Passa le chiavi pubbliche e private al metodo setMeteredKey.
1. Esegui il processo (esegui il compito).
1. chiama il metodo getConsumptionQuantity della classe Metered.
1. Restituirà l'ammontare/quantità delle richieste API che hai consumato finora.

Di seguito è riportato un esempio di codice che dimostra come impostare la chiave pubblica e privata a consumo:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
