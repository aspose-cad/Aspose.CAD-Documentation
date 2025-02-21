---
title: 导出 DGN AutoCAD
type: docs
weight: 50
url: /zh/python-net/developer-guide/exporting-dgn-autocad/
---

## **将 DGN AutoCAD 格式导出为 PDF**

Aspose.CAD for Python API 引入了加载 DGN AutoCAD 文件并将其转换为 PDF 格式的功能。**CadImage** 类用于此目的。

您需要将现有的 DGN 文件加载为 **CadImage**。创建 **CadRasterizationOptions** 类的实例并设置不同的属性。创建 **PdfOptions** 类的实例并传递 **CadRasterizationOptions** 实例。现在调用 **CadImage** 类实例的 **save** 方法。

### 示例代码

以下是将 [DGN](https://docs.fileformat.com/cad/dgn/) 转换/导出为 [PDF](https://docs.fileformat.com/pdf/) 格式的代码演示。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **将 DGN AutoCAD 格式导出为光栅图像格式**

Aspose.CAD for Python API 引入了加载 DGN AutoCAD 文件并将其转换为光栅图像的功能。**CadImage** 类用于此目的。

您需要将现有的 DGN 文件加载为 **CadImage**。创建 **CadRasterizationOptions** 类的实例并设置不同的属性。创建 **JpegOptions** 类的实例并传递 **CadRasterizationOptions** 实例。现在调用 **CadImage** 类实例的 **save** 方法。

### 示例代码

以下是将 [DGN](https://docs.fileformat.com/cad/dgn/) 转换/导出为 [JPEG](https://docs.fileformat.com/image/jpeg/) 图像的代码演示。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **DGN v7 的 3D 实体支持**

Aspose.CAD for Python API 引入了加载 [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD 文件并支持 DGN v7 的 3D 实体的功能。**CadImage** 类用于此目的。每个 [DGN](https://docs.fileformat.com/cad/dgn/) 图像支持 9 个预定义视图。它从 1 编号到 9。如果在导出时未定义视图，对于多页面输出格式（如 PDF），所有视图将被导出，每个视图在单独的页面上。DGN 文件格式支持 3D 实体以及 2D。为此，使用 **VectorRasterizationOptions**，TypeOfEntities 在 DGN 格式中不再使用（同时支持 2D 和 3D）。

### 示例代码

以下是查看支持的 DGN 元素的示例代码。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
