---
title: Belirtilen boyutta DWG/DXF çizimini ve düzenlerini dışa aktarma
type: docs
weight: 40
url: /tr/net/developer-guide/export-into-size/
---

## **Modeli ve tüm düzenleri A4 PDF boyutuna dışa aktar**

Aspose.CAD API'si, DWG/DXF dosyasının tüm sayfalarını belirtilen fiziksel PDF boyutuna dışa aktarmanıza olanak tanır.

Aşağıdaki örnek kod, istenen PDF boyutunu elde etmek için [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) nesnesinin boyutunu ayarlar. A4 kağıt sayfasının boyutu 210x297 milimetre veya 8.27x11.69 inçtir ve bu değerler kodda kullanılmıştır.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **CAD Düzenlerini farklı boyutlarda PDF'ye dışa aktar**

Bazen düzenin fiziksel boyutuna dışa aktarılması gereklidir. Aşağıdaki örnek, her sayfası düzen içeriğiyle birlikte olan çok sayfalı PDF'ye çizimin dışa aktarımını göstermektedir. Bu örnek [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) özelliğini kullanmaktadır.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
