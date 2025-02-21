---
title: Добавление изображения в качестве фона в DWG
type: docs
weight: 15
url: /ru/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Как добавить изображение в качестве фона в DWG**

**Проблема:** Как добавить изображение в качестве фона в DWG.

**Советы:** Для этого создайте объект CadRasterImageDef для фонового изображения, создайте объект CadRasterImage для вставки фона в чертеже, добавьте объект CadRasterImage в объекты чертежа, создайте объект CadBaseObject и добавьте его в cadImage.Objects, обработайте все через CadBlockTableObject.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
