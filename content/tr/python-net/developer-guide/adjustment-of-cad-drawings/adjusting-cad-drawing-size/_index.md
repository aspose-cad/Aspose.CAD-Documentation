---
title: CAD Çizim Boyutunu Ayarlama
type: docs
weight: 10
url: /tr/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for Python kütüphanesini kullanarak, geliştiriciler CAD çiziminin boyutunu desteklenen herhangi bir formata dönüştürme sırasında ayarlayabilirler. Bu konu, boyutun otomatik veya manuel olarak **ImageOptions** sınıfının **UnitType** enum'u kullanılarak nasıl ayarlanacağını açıklar.

{{% /alert %}}

## **CAD çizim boyutunu ayarlama**

Aspose.CAD for Python, CAD formatının dönüştürülmesi sırasında çizimin boyutunu ayarlamak için **UnitType** enumerasyonunu sağlar. Çizim boyutunu ayarlamanın iki yolu vardır.

1. Otomatik boyut ayarlaması.
1. **ImageOptions** sınıfının **UnitType** enumerasyonu kullanarak boyutu ayarlama.

Boyutu otomatik olarak ayarlamak için geliştiricilerin **CadRasterizationOptions** sınıfının Width ve Height özelliklerini sağlamalarına gerek yoktur. Aşağıda verilen kod örneği otomatik boyutlandırmanın bir örneğidir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

**UnitType** enumerasyonu, Width ve Height özellikleri ayarlanmadığında ölçeklemeyi ayarlama yeteneği verir. Aşağıda verilen kod örneği **UnitType** nasıl kullanılacağını gösterir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
