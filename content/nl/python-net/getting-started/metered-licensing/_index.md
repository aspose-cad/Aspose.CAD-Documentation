---
title: Metered Licenties
type: docs
weight: 40
url: /nl/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD stelt ontwikkelaars in staat om een metered sleutel toe te passen. Dit is een nieuw licentiemechanisme. Het nieuwe licentiemechanisme zal worden gebruikt naast de bestaande licentiemethode. Klanten die op basis van het gebruik van de API-functies willen worden gefactureerd, kunnen gebruikmaken van de metered licenties. Voor meer details, zie de sectie [Metered Licenties FAQ](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Metered Licenties**
Hier zijn de eenvoudige stappen om de Metered-klasse te gebruiken.

1. Maak een instantie van de Metered-klasse.
1. Geef de openbare en privé sleutels door aan de SetMeteredKey-methode.
1. Voer de verwerking uit (voeg een taak uit).
1. Roep de methode GetConsumptionQuantity van de Metered-klasse aan.
1. Het zal de hoeveelheid/kwantiteit van API-aanvragen retourneren die je tot nu toe hebt verbruikt.

Hieronder staat de voorbeeldcode die laat zien hoe je de metered openbare en privé sleutel kunt instellen.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
