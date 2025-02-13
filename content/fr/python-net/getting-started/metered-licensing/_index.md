---
title: Licences Mesurées
type: docs
weight: 40
url: /fr/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permet aux développeurs d'appliquer une clé mesurée. Il s'agit d'un nouveau mécanisme de licence. Le nouveau mécanisme de licence sera utilisé en parallèle avec la méthode de licence existante. Les clients qui souhaitent être facturés en fonction de l'utilisation des fonctionnalités de l'API peuvent utiliser la licence mesurée. Pour plus de détails, veuillez vous référer à la section [FAQ sur les Licences Mesurées](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licences Mesurées**
Voici les étapes simples pour utiliser la classe Metered.

1. Créez une instance de la classe Metered.
1. Passez les clés publiques et privées à la méthode SetMeteredKey.
1. Procédez au traitement (effectuez la tâche).
1. Appelez la méthode GetConsumptionQuantity de la classe Metered.
1. Elle renverra le montant/quantité de requêtes API que vous avez consommées jusqu'à présent.

Voici le code d'exemple démontrant comment définir les clés mesurées publique et privée.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
