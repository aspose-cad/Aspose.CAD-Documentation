---
title: Licences Mesurées
type: docs
weight: 60
url: /fr/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permet aux développeurs d'appliquer une clé mesurée. C'est un nouveau mécanisme de licence. Le nouveau mécanisme de licence sera utilisé en conjonction avec la méthode de licence existante. Les clients qui souhaitent être facturés en fonction de l'utilisation des fonctionnalités de l'API peuvent utiliser la licence mesurée. Pour plus de détails, veuillez vous référer à la section [FAQ sur les Licences Mesurées](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licences Mesurées**
Voici les étapes simples pour utiliser la classe Metered.

1. Créer une instance de la classe Metered.
1. Passer les clés publique et privée à la méthode setMeteredKey.
1. Effectuer le traitement (exécuter la tâche).
1. Appeler la méthode getConsumptionQuantity de la classe Metered.
1. Elle retournera le montant/quantité de requêtes API que vous avez consommées jusqu'à présent.

Voici un exemple de code démontrant comment définir la clé publique et la clé privée mesurées :

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
