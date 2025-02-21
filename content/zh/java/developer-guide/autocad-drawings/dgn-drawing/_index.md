---
title: DGN 图纸
type: docs
weight: 10
url: /zh/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **作为 DWG 一部分的 DGN 格式图纸**

Aspose.CAD for Java 允许开发人员导出包含嵌入 DGN 下图的 DWG 文件。以下是演示如何在导出 DWG 文件时访问 DWG 文件内的 DGN 下图的代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **DGN v7 的 3D 实体支持**

Aspose.CAD for Java API 引入了加载 DGN AutoCAD 文件的功能，并支持 DGN v7 的 3D 实体。[**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) 类实现了这个目的。每个 DGN 图像支持 9 个预定义视图。它的枚举从 1 到 9。如果在导出时未定义视图，对于多页输出格式（如 PDF），所有视图将被导出，每个视图在一个单独的页面上。DGN 文件格式支持 3D 实体，以及 2D。对于 DGN 格式（同时支持 2D 和 3D），不再使用 VectorRasterizationOptions.TypeOfEntities。

查看支持的 DGN 元素的示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
