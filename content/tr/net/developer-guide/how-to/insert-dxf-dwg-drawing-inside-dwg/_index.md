---
title: DWG İçinde DXF/DWG Çizimi Ekleme
type: docs
weight: 38
url: /tr/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **DWG İçinde DXF/DWG Çizimi Nasıl Eklenir**

**Sorun:** DWG içinde DXF/DWG çizimi nasıl eklenir.

**İpuçları:** Bunu yapmak için öncelikle gerekli değerlere sahip bir CadInsertObject oluşturun, ardından CadBlockDictionary içindeki tüm blokları alın, yeni bir CadBlockEntity bloğu oluşturun ve bunu CadBlockDictionary'ye ekleyin, bir CadBlockDictionary'yi çizimin BlockEntities'ine ekleyin, bir CadInsertObject'i dizi için çizim varlığına ekleyin, referansla bir CadBlockTableObject oluşturun, ardından bir bloğu çizime ekleyin.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
