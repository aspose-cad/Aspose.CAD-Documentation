---
title: License Metrique
type: docs
weight: 60
url: /fr/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permet aux développeurs d'appliquer une clé métrique. C'est un nouveau mécanisme de licence. Le nouveau mécanisme de licence sera utilisé en conjonction avec la méthode de licence existante. Les clients qui souhaitent être facturés en fonction de l'utilisation des fonctionnalités de l'API peuvent utiliser la licence métrique. Pour plus de détails, veuillez consulter la section [FAQ sur la licence métrique](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licence Métrique**
Voici les étapes simples pour utiliser la classe Metered.

1. Créez une instance de la classe Metered.
1. Passez les clés publiques et privées à la méthode SetMeteredKey.
1. Effectuez le traitement (réalisez la tâche).
1. Appelez la méthode GetConsumptionQuantity de la classe Metered.
1. Elle retournera le montant/quantité des requêtes API que vous avez consommées jusqu'à présent.

Voici un exemple de code démontrant comment définir la clé publique et la clé privée métriques.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
