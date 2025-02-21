---
title: Licenza Misurata
type: docs
weight: 60
url: /it/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD consente agli sviluppatori di applicare una chiave misurata. È un nuovo meccanismo di licenza. Il nuovo meccanismo di licenza sarà utilizzato insieme al metodo di licenza esistente. I clienti che desiderano essere fatturati in base all'uso delle funzionalità dell'API possono utilizzare la licenza misurata. Per ulteriori dettagli, si prega di fare riferimento alla sezione [FAQ sulla Licenza Misurata](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenza Misurata**
Ecco i semplici passaggi per utilizzare la classe Metered.

1. Crea un'istanza della classe Metered.
1. Passa le chiavi pubbliche e private al metodo SetMeteredKey.
1. Effettua l'elaborazione (esegui il compito).
1. Chiama il metodo GetConsumptionQuantity della classe Metered.
1. Restituirà l'ammontare/quantità delle richieste API che hai consumato finora.

Di seguito è riportato un esempio di codice che dimostra come impostare la chiave pubblica e privata misurata.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
