---
title: Mérlegelt Licencelés
type: docs
weight: 60
url: /hu/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Az Aspose.CAD lehetővé teszi a fejlesztők számára, hogy mérlegelt kulcsot alkalmazzanak. Ez egy új licencelési mechanizmus. Az új licencelési mechanizmust a meglévő licencelési móddal együtt fogják használni. Azok az ügyfelek, akik a API funkciók használata alapján szeretnének számlázni, igénybe vehetik a mérlegelt licencelést. További részletekért kérjük, hogy tekintse meg a [Mérlegelt Licencelés GYIK](https://purchase.aspose.com/faqs/licensing/metered) részt.

{{% /alert %}} 
## **Mérlegelt Licencelés**
Itt vannak a egyszerű lépések a Metered osztály használatához.

1. Hozzon létre egy Metered osztály példányt.
1. Adja át a közpublic és a privát kulcsokat a setMeteredKey metódusnak.
1. Végezze el a feldolgozást (feladat végrehajtása).
1. Hívja meg a Metered osztály getConsumptionQuantity metódusát.
1. Ez vissza fogja adni az eddig felhasznált API kérések számát/mennyiségét.

Az alábbiakban bemutatunk egy példa kódot, amely megmutatja, hogyan lehet beállítani a mérlegelt közpublic és privát kulcsot:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
