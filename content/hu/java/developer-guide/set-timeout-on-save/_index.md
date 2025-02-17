---
title: Időtúllépés beállítása mentéskor
type: docs
weight: 70
url: /hu/java/developer-guide/set-timeout-on-save/
---

## **Időtúllépés beállítása mentéskor**

Az Aspose.CAD for Java API lehetővé teszi, hogy időtúllépést állítson be a mentés során. Ez hasznos lehet olyan esetekben, amikor a mentési folyamat sok időt vesz igénybe, vagy sok memóriát fogyaszt. Ehhez az API biztosítja a [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) osztályt. Az [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) osztály egy tokent biztosít, amelyet hosszú műveletek megszakítására használnak.

## Példa kód

Az alábbi kódpélda bemutatja az [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) osztály használatát.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
