---
title: DXF'e Aktarma
type: docs
weight: 20
url: /tr/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **DXF'e nasıl aktarılır**

**Sorun:** DXF'e nasıl aktarılır.

**İpuçları:** Bunu yapmak için dosya kaydetme seçeneklerinde hem ikili hem de normal DxfOption'u kullanabilirsiniz.

**Not:** İlginç özelliklerden biri, desteklenen herhangi bir dosya formatını dxf olarak kaydetme yeteneğidir.
Gerçekten iyi bir özellik, ayrıca birkaç nüansı vardır:
DXF/DWG dosya formatlarından kaydetme - kaynak formatın sahip olduğu kesin varlıklarla dışa aktarma yapar.
Diğer formatlardan dışa aktarma - yalnızca çizgiler ve metin varlıkları kullanarak dışa aktarma yapar.
Ayrıca, ASCII ve ikili DXF dosya formatlarını destekliyoruz.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
