---
title: Var olanların sağında yeni TEXT/MTEXT nesneleri ekleme 
type: docs
weight: 17
url: /tr/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Var olanların sağında yeni TEXT/MTEXT nesneleri ekleme**

**Sorun:** Var olanların sağında yeni TEXT/MTEXT nesneleri nasıl eklenir (CADNET-8172).

**İpuçları:** Bunu yapmak için, bir CadBaseEntity nesnesi oluşturun, bir CadMText veya CadText oluşturun ve yeni nesneye SoftOwner alanında çizimden cadImage.Layouts["Model"].BlockTableRecordHandle ekleyin ve bunu cadImage.BlockEntities[" *MODEL_SPACE"] bloğuna ekleyin ve yeni nesneyi çizim nesnelerine ekleyin.

**Örnek:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
