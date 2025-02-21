---
title: 具有SAT/SAB结构的实体
type: docs
weight: 40
url: /zh/net/developer-guide/entities_with-sat-and-sab/
---

## **具有SAT/SAB结构的实体**

某些实体以ACIS SAT/SAB格式存储其结构数据。这些实体可以以2D线框模式部分导出。支持的实体包括：

*  3DSOLID对象：盒子、球体、金字塔、楔形、圆锥、圆柱、环、聚合物
*  SURFACE：平面、拉伸、旋转、扫描
*  REGION

以下是导出结果的示例（左侧为DWG文件，右侧为PDF结果）。

![导出的圆锥和球体](/_assets/guide/coneAndSpheres.png)

导出ACIS实体不需要任何特殊选项。为了优化图纸大小，特别是当图纸仅包含ACIS实体时，请考虑使用cadImage.UpdateSize()函数准确调整初始绘图尺寸。

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
