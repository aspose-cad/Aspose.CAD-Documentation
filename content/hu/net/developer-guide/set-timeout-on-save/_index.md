---
title: Időkorlát beállítása mentéskor
type: docs
weight: 70
url: /hu/net/developer-guide/set-timeout-on-save/
---

## **Időkorlát beállítása mentéskor**

Az Aspose.CAD a .NET API lehetővé teszi, hogy időkorlátot állítson be mentéskor. Ez hasznos lehet olyan esetekben, amikor a mentési folyamat sok időt vesz igénybe, vagy sok memóriát fogyaszt. Ehhez az API biztosítja a  [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) osztályt. Az [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) osztály egy tokent biztosít, amelyet hosszú műveletek megszakítására használnak.

## Példa Kód

Az alábbi kódrészlet bemutatja az [**InterruptionTokenSource**](https://reference.aspose.com/cad/net/aspose.cad/interruptiontokensource) osztály használatát.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-PutTimeoutOnSave-1.cs" >}}
