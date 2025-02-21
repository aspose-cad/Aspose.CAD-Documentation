---
title: DXF İçinde DXF/DWG Çizim Ekleme
type: docs
weight: 39
url: /tr/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **DXF İçinde DXF/DWG Çizim Nasıl Eklenir**

**Sorun:** DXF/DWG çizimini DXF içine nasıl eklerim.

**İpuçları:** Bunu yapmak için önce gerekli değerlerle bir CadInsertObject oluşturmalısınız, ardından CadBlockDictionary içinde tüm blokları alın, yeni bir CadBlockEntity bloğu oluşturun ve bunu CadBlockDictionary'ye ekleyin, CadBlockDictionary'yi çizimin BlockEntities'ine ekleyin, çizimin varlıklarına dizi için bir CadInsertObject ekleyin.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
