---
title: CAD Çizim Boyutunu Ayarlama
type: docs
weight: 10
url: /tr/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for Java kullanarak, geliştiriciler CAD formatının dönüştürülmesi sırasında çizimin boyutunu ayarlayabilir. Bu konu, [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum'unun [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) sınıfındaki yaklaşımını otomatik ayarlama veya boyutu ayarlama konusunda açıklar.

{{% /alert %}}

## **CAD çizim boyutunu ayarlama**

Aspose.CAD for Java, CAD formatının dönüştürülmesi sırasında çizimin boyutunu ayarlamak için [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeration'ını sağlar. Çizim boyutunu ayarlamanın iki yolu vardır.

1. Otomatik boyut ayarlama
1. [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) sınıfının [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeration'ını kullanarak boyut ayarlama

Boyutun otomatik ayarlanması için, geliştiricilerin [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının Width ve Height özelliklerini sağlaması gerekmez. Aşağıda sağlanan kod parçacığı, otomatik boyutlandırma örneğidir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeration'ı, Width ve Height özellikleri ayarlanmadığında ölçeklemeyi ayarlama yeteneği sağlar. Aşağıda sağlanan kod parçacığı, [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType)'ın nasıl kullanılacağını gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
