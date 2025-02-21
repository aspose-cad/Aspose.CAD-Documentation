---
title: 导出DGN AutoCAD
type: docs
weight: 50
url: /zh/net/developer-guide/exporting-dgn-autocad/
---

## **将DGN AutoCAD格式导出为PDF**

Aspose.CAD for .NET API引入了加载DGN AutoCAD文件并将其转换为PDF格式的功能。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)类用于此目的。

您需要将现有DGN文件加载为[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)。创建[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)类的实例并设置不同的属性。创建[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)类的实例，并传递[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)实例。现在调用[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)类实例的[**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)方法。

### 示例代码

以下是将[DGN](https://docs.fileformat.com/cad/dgn/)转换/导出为[PDF](https://docs.fileformat.com/pdf/)格式的代码演示。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **将DGN AutoCAD格式导出为光栅图像格式**

Aspose.CAD for .NET API引入了加载DGN AutoCAD文件并将其转换为光栅图像的功能。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)类用于此目的。

您需要将现有DGN文件加载为[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)。创建[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)类的实例并设置不同的属性。创建[**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions)类的实例，并传递[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)实例。现在调用[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)类实例的[**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)方法。

### 示例代码

以下是将[DGN](https://docs.fileformat.com/cad/dgn/)转换/导出为[JPEG](https://docs.fileformat.com/image/jpeg/)图像的代码演示。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **DGN v7的3D实体支持**

Aspose.CAD for .NET API引入了加载[DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD文件并支持DGN v7的3D实体的功能。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)类用于此目的。每个[DGN](https://docs.fileformat.com/cad/dgn/)图像支持9个预定义视图。它的编号从1到9。如果导出时未定义视图，对于多页面输出格式（如PDF），将导出所有视图，每个视图在单独的页面上。DGN文件格式支持3D实体，以及2D。为此，使用[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)，不再使用TypeOfEntities用于DGN格式（同时支持2D和3D）。

### 示例代码

以下是查看支持的DGN元素的示例代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
