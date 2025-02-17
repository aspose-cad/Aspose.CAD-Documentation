---
title: Mérő Licencelés
type: docs
weight: 40
url: /hu/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Az Aspose.CAD lehetővé teszi a fejlesztők számára, hogy mérőkulcsot alkalmazzanak. Ez egy új licencelési mechanizmus. Az új licencelési mechanizmust a meglévő licencelési módszer mellett fogják használni. Azok az ügyfelek, akik a API funkciók használata alapján szeretnének számlázva lenni, használhatják a mérő licencelést. További részletekért kérjük, olvassa el a [Mérő Licencelés GYIK](https://purchase.aspose.com/faqs/licensing/metered) szakaszt.

{{% /alert %}} 
## **Mérő Licencelés**
Itt vannak a egyszerű lépések a Metered osztály használatához.

1. Hozzon létre egy Metered osztály példányt.
1. Adja át a nyilvános és privát kulcsokat a SetMeteredKey metódusnak.
1. Végezze el a feldolgozást (végezze el a feladatot).
1. Hívja meg a Metered osztály GetConsumptionQuantity metódusát.
1. Ez visszaadja a API kérések mennyiségét, amelyet eddig felhasznált.

A következő példa kód bemutatja, hogyan kell beállítani a mérő nyilvános és privát kulcsot.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
