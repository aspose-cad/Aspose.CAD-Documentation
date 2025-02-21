---
title: Licenza a Consumo
type: docs
weight: 40
url: /it/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD consente agli sviluppatori di applicare una chiave a consumo. È un nuovo meccanismo di licenza. Il nuovo meccanismo di licenza sarà utilizzato insieme al metodo di licenza esistente. I clienti che desiderano essere fatturati in base all'uso delle funzionalità dell'API possono utilizzare la licenza a consumo. Per ulteriori dettagli, si prega di fare riferimento alla sezione [Domande frequenti sulla licenza a consumo](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenza a Consumo**
Ecco i semplici passaggi per utilizzare la classe Metered.

1. Crea un'istanza della classe Metered.
1. Passa le chiavi pubbliche e private al metodo SetMeteredKey.
1. Esegui il processo (completa il compito).
1. Chiama il metodo GetConsumptionQuantity della classe Metered.
1. Restituirà l'ammontare/quantità delle richieste API che hai consumato finora.

Di seguito è riportato un codice di esempio che dimostra come impostare la chiave pubblica e privata a consumo.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
