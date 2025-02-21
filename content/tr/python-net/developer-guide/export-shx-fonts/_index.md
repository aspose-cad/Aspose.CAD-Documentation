---
title: SHX yazı tiplerini dışa aktarma
type: docs
weight: 40
url: /tr/python-net/developer-guide/export-shx-fonts/
---

## **DXF/DWG çizimleri için SHX yazı tiplerini dışa aktar**

Bazı çizimler, yazı tipinin sembollerini şekil olarak depolayan özel SHX formatında yazı tipleri içerebilir. Bu format, çizimde kullanılan her yazı tipi için ek bir yükleme prosedürü gerektirir. Apose.CAD, SHX ile yazılmış metin içeren çizimleri dışa aktarabilir ve bunu yapmanın farklı seçenekleri vardır. Bunu yapmanın en basit yolu, **CadRasterizationOptions** nesnesinin **ShxFonts** özelliğini kullanmaktır.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
