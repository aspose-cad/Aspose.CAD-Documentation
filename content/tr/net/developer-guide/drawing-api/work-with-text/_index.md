---
title: Metin ile Çalışma
type: docs
weight: 40
url: /tr/net/developer-guide/drawing-api/work-with-text/
---

## **Metin ile Çalışma**

Neredeyse tüm çizimler metin nesneleri içerir ve bu örnekler onlarla nasıl operasyon yapılacağını gösterir. 
DWG/DXF için metin depolayabilen farklı tipte varlıklar vardır, bunlar [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. İki son tür tipik olarak 
[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/) ile ilgilidir 
ve içinde veya ilgili blokta depolanır.

İşte metin ile yapılan işlemleri tanımlayan bazı örnekler.

### **Metni Arama**

Bu örnek DWG/DXF dosyasında metin değerlerini bulmayı gösterir ve ayrıca metin değerlerini değiştirmek için de kullanılabilir.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Metin Ara.cs">}}

### **Yeni Metin ve MText öğeleri Ekleme**

Yeni Metin/Mtext nesnelerini çizime nasıl ekleyeceğinize dair örnek burada. Yeni varlıkların eklenmesi çizimin boyutunu değiştirebilir, bu nedenle bu işlemlerden sonra 
UpdateSize() çağrısı yapmanız önerilir.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Metin_mtext Ekleme.cs">}}
