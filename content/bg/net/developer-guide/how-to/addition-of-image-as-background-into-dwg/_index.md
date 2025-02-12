---
title: Добавяне на изображение като фон в DWG
type: docs
weight: 15
url: /bg/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Как да добавите изображение като фон в DWG**

**Проблем:** Как да добавите изображение като фон в DWG.

**Съвети:** За да направите това, създайте обект CadRasterImageDef за фоновото изображение, създайте обект CadRasterImage за вмъкване на фон за чертежа, добавете обект CadRasterImage към обектите за черсане, създайте обект CadBaseObject CadBaseObject и го добавете към cadImage.Objects, обработете всичко чрез CadBlockTableObject.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
