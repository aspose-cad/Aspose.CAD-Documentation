---
title: 导出 CAD
type: docs
weight: 40
url: /zh/java/developer-guide/exporting-cad/
---

## **导出 3D AutoCAD 图像到 PDF**
Aspose.CAD 允许您将 3D AutoCAD 图像导出为 PDF。请在 **ImageOptions.CadRasterizationOptions** 中使用 **TypeOfEntities.Entities3D** 来指定您想要导出 3D 实体。
下面的示例代码加载一个 AutoCAD 3D 文件并将其导出为 PDF。一旦文件被转换为 PDF，您可以使用您喜欢的 PDF 查看器打开它。

下面的代码示例显示了如何将 3D AutoCAD 图像导出为 PDF。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-Export3DAutoCADImagesToPDF-.java" >}}


## **导出 CAD 布局到 PDF**
Aspose.CAD for Java 允许您将 CAD 布局导出为 PDF。 **CadImage** 类的 **save** 方法可用于将布局导出为 PDF 格式。
下面的示例代码加载一个 CAD 文件并将其 "Model" 布局导出为 PDF。一旦文件被转换为 PDF，您可以使用您喜欢的 PDF 查看器打开它。

这是示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportCADLayoutsToPDF-.java" >}}
## **在导出中支持设置笔**
Aspose.CAD for Java 允许您在 CAD 的导出属性中添加笔选项。使用 rasterizationOptions，我们可以设置笔属性选项。

下面是实现指定需求的示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}
## **分解 CAD 插入对象**
Aspose.CAD for Java 允许您分解 CAD 对象并处理插入内部的单独实体。下面是实现指定需求的示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}
## **支持 ACAD 代理实体**
Aspose.CAD for Java 允许您读取和导出 ACAD_PROXY_ENTITY 实体。下面是实现指定需求的示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}
## **集成 IGES 格式**
Aspose.CAD for Java 允许您读取和导出 IGES 格式。下面是实现指定需求的示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-IGESDrawings-ExportIGEStoPDF-ExportIGEStoPDF.java" >}}
## **支持网格模型**
Aspose.CAD for Java 允许您实现并计算使用多边形表示的网格模型，如边缘、顶点和面。下面是实现指定需求的示例代码。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-MeshSupportForDWG-MeshSupportForDWG.java" >}}
## **设置自定义视角**
Aspose.CAD for Java 允许您为模型布局设置自定义视角。使用 **vectorRasterizationOptions**，您可以设置自定义视角。下面的代码示例显示了如何设置自定义视角。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-FreePointOfView-FreePointOfView.java" >}}
