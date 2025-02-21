---
title: DWF 绘图
type: docs
weight: 20
url: /zh/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **将 DWF 绘图导出为 PDF**

Aspose.CAD 提供了加载 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 绘图实体并将其呈现为整个图纸至 [PDF](https://docs.fileformat.com/pdf/) 格式的功能。[DWF](https://docs.fileformat.com/cad/dwf/) 到 [PDF](https://docs.fileformat.com/pdf/) 转换方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 [DWF](https://docs.fileformat.com/cad/dwf/) 绘图文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 创建 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) 的对象作为第二个参数传递。

### 示例代码

以下代码示例演示了如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **从 DWF 绘图中提取图层**

Aspose.CAD 提供了加载 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 绘图实体并将其呈现为整个图纸至 [JPEG](https://docs.fileformat.com/image/jpeg/) 格式的功能。

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 [DWF](https://docs.fileformat.com/cad/dwf/) 绘图文件。
1. 创建 [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 类的对象。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象。
1. 使用 [JPEG](https://docs.fileformat.com/image/jpeg/) 对象提取图层名称。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 的对象作为第二个参数传递。

### 示例代码

以下代码示例演示了如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF 中图层的支持**

Aspose.CAD 提供了加载 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 绘图实体并将其呈现为整个图纸至 [JPEG](https://docs.fileformat.com/image/jpeg/) 格式的功能。

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 [DWF](https://docs.fileformat.com/cad/dwf/) 绘图文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象。
1. 添加所需的图层。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) 的对象作为第二个参数传递。

### 示例代码

以下代码示例演示了如何使用默认设置转换文件。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **将 DWF 绘图导出为 BMP**

Aspose.CAD 提供了加载 AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) 绘图实体并将其呈现为整个图纸至 [BMP](https://docs.fileformat.com/image/bmp/) 格式的功能。[DWF](https://docs.fileformat.com/cad/dwf/) 到 [BMP](https://docs.fileformat.com/image/bmp/) 转换方法如下：

1. 使用 [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) 工厂方法加载 [DWF](https://docs.fileformat.com/cad/dwf/) 绘图文件。
1. 创建 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 类的对象，并设置 [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) 和 [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) 属性。
1. 创建 [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) 类的对象，并设置 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) 属性。
1. 调用 [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)，并将 [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) 的对象作为第二个参数传递。

### 示例代码

以下代码示例演示了如何使用默认设置将 [DWF](https://docs.fileformat.com/cad/dwf/) 文件转换为 [BMP](https://docs.fileformat.com/image/bmp/)。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
