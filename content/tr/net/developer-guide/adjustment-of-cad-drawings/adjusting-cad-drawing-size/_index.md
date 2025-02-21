---
title: CAD Çizim Boyutunu Ayarlama
type: docs
weight: 10
url: /tr/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for .NET kütüphanesini kullanarak geliştiriciler, CAD çiziminin boyutunu desteklenen herhangi bir formata dönüştürme sırasında ayarlayabilirler. Bu konu, boyutun otomatik veya manuel olarak nasıl ayarlanacağını [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enum'ıyla [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) sınıfı kullanarak açıklar.

{{% /alert %}}

## **CAD çizim boyutunu ayarlama**

Aspose.CAD for .NET, CAD formatını dönüştürme sırasında çizimin boyutunu ayarlamak için [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumerasyonunu sağlar. Çizim boyutunu ayarlamak için iki yol vardır.

1. Otomatik boyut ayarı.
1. [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) sınıfının [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumerasyonunu kullanarak boyutu ayarlama.

Otomatik boyut ayarı için geliştiricilerin [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) sınıfının Width ve Height özelliklerini sağlamalarına gerek yoktur. Aşağıda verilen kod parçası otomatik boyutlandırmanın bir örneğidir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumerasyonu, Width ve Height özellikleri ayarlanmadığında ölçek ayarlama yeteneği sağlar. Aşağıda verilen kod parçası, [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) kullanmanın nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
