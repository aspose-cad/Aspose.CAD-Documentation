---
title: Méretezett Licencelés
type: docs
weight: 60
url: /hu/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Az Aspose.CAD lehetővé teszi a fejlesztők számára, hogy méretezett kulcsot alkalmazzanak. Ez egy új licencelési mechanizmus. Az új licencelési mechanizmust a meglévő licencelési módszerrel együtt fogják használni. Azok az ügyfelek, akik az API funkcióinak használatán alapuló számlázást szeretnének, használhatják a méretezett licencelést. További részletekért kérjük, hivatkozzon a [Méretezett Licencelés GYIK](https://purchase.aspose.com/faqs/licensing/metered) szakaszra.

{{% /alert %}} 
## **Méretezett Licencelés**
Itt vannak a egyszerű lépések a Metered osztály használatához.

1. Hozzon létre egy példányt a Metered osztályból.
1. Adja meg a nyilvános és privát kulcsokat a SetMeteredKey metódusnak.
1. Végezze el a feldolgozást (végezzen el feladatot).
1. Hívja meg a Metered osztály GetConsumptionQuantity metódusát.
1. Ez visszaadja az API kérések mennyiségét, amelyet eddig felhasznált.

Az alábbiakban egy példa kódot láthat, amely bemutatja, hogyan állíthatja be a méretezett nyilvános és privát kulcsot.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
