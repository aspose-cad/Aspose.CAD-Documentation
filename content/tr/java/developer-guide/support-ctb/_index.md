---
title: CTB dosyalarının desteği
type: docs
weight: 40
url: /tr/java/developer-guide/support-ctb/
---

## **CTB dosyalarının desteği**

Bazen çizimler için renk, hat kalınlıkları ve diğer bazı seçenekler yalnızca çizimlerden değil, aynı zamanda ayrı CTB dosyalarındaki plot stillerinden de alınabilir.
Bu bilgiyi kullanmanın en basit yolu, ilgili CTB dosyalarını DWG/DXF formatındaki çizim dosyasıyla yan yana koymaktır ve onlardan gelen bilgiler
otomatik olarak dışa aktarım sırasında uygulanacaktır.

Ayrıca tüm CTB dosyalarını bir Akış biçiminde yüklemek de mümkündür 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) özelliğini kullanarak 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesi ile.

Bunu nasıl yapacağınıza dair bir örnek:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
