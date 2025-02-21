---
title: Metin ile Çalışma
type: docs
weight: 40
url: /tr/python-net/developer-guide/drawing-api/work-with-text/
---

## **Metin ile Çalışma**

Neredeyse tüm çizimler metin nesneleri içerir ve bu örnekler onlarla nasıl işlem yapacağınızı gösterir. 
DWG/DXF için metin saklayabilen farklı türde varlıklar vardır, bunlar **CadText**, **CadMText**, CadAttDef, CadAttrib olarak adlandırılır. İki son tür genellikle 
**CadInsertObject** ile ilişkilidir ve içinde veya ilgili blok içinde saklanır.

Metin ile ilgili işlemleri tanımlayan bazı örnekler burada bulunmaktadır.

### **Metni Arama**

Bu örnek, DWG/DXF dosyasında metin değerlerini bulmanın nasıl yapılacağını gösterir ve metin değerlerini değiştirmek için de kullanılabilir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
