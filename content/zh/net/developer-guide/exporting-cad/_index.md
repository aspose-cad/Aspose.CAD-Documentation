---
title: 导出 CAD
type: docs
weight: 40
url: /zh/net/developer-guide/exporting-cad/
---

## **将 3D AutoCAD 图像导出为 PDF**

Aspose.CAD 允许您将 3D AutoCAD 图像导出为 PDF。请使用 [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) 指定您希望导出 3D 实体。

以下示例代码加载一个 AutoCAD 3D 文件并将其导出为 [PDF](https://docs.fileformat.com/pdf/)。一旦文件转换为 PDF，您可以使用您喜欢的 PDF 查看器打开它。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **将 CAD 布局导出为 PDF**

Aspose.CAD for .NET 允许您将 CAD 布局导出为 PDF。 [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) 方法的 [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) 类可以用于将布局导出为 [PDF](https://docs.fileformat.com/pdf/) 格式。

以下示例代码加载一个 CAD 文件并将其“模型”布局导出为 PDF。一旦文件转换为 PDF，您可以使用您喜欢的 PDF 查看器打开它。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **支持在导出中设置笔**

Aspose.CAD for .NET 允许您在 CAD 的导出属性中添加笔选项。通过使用 [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)，我们可以设置笔属性选项。

下面是实现指定要求的示例代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **分解 CAD 插入对象**

Aspose.CAD for .NET 允许您分解 CAD 对象并处理插入内部的单独实体。下面是实现指定要求的示例代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **支持 ACAD 代理实体**

Aspose.CAD for .NET 允许您读取和导出 ACAD_PROXY_ENTITY 实体。下面是实现指定要求的示例代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **集成 IGES 格式**

Aspose.CAD for .NET 允许您读取和导出 IGES 格式。下面是实现指定要求的示例代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **支持网格模型**

Aspose.CAD for .NET 允许您实现并计算使用多边形表示的边缘、顶点和面等网格模型。下面是实现指定要求的示例代码。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **设置自定义视角**

Aspose.CAD for .NET 允许您为模型布局设置自定义视角。通过使用 [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)，您可以设置自定义视角。下面的代码示例展示了如何设置自定义视角。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
