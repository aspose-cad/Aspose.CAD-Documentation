---
title: CTB dosyalarının Desteği
type: docs
weight: 40
url: /tr/net/developer-guide/support-ctb/
---

## **CTB dosyalarının Desteği**

Bazen çizimler için renk, çizgi kalınlıkları ve diğer bazı seçenekler yalnızca çizimlerin kendisinden değil, aynı zamanda ayrı CTB dosyalarındaki plot stillerinden de kullanılabilir. 
Bu bilgiyi kullanmanın en basit yolu, ilgili CTB dosyalarını DWG/DXF formatındaki çizim dosyasının yanına koymaktır; bu dosyalardan gelen bilgiler otomatik olarak 
dışa aktarım sırasında uygulanacaktır.

Ayrıca, tüm CTB dosyalarını bir Akış biçiminde yüklemek de mümkündür, bu, 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) özelliği kullanılarak yapılabilir.
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) nesnesinin.

Bunu nasıl yapacağınıza dair bir örnek:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
