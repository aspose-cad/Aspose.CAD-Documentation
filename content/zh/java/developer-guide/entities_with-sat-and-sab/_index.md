---
title: 带有 SAT/SAB 结构的实体
type: docs
weight: 40
url: /zh/java/developer-guide/entities_with-sat-and-sab/
---

## **带有 SAT/SAB 结构的实体**

某些实体将其结构数据存储在 ACIS SAT/SAB 格式中。这些实体可以在 2D 线框模式下部分导出。支持的实体包括：

* 3DSOLID 对象：盒子、球体、金字塔、楔形、圆锥、圆柱、圆环、多固体
* SURFACE：平面、拉伸、旋转、扫掠
* REGION

以下是导出结果的示例（左侧为 DWG 文件，右侧为 PDF 结果）。

![导出圆锥和球体](/cad/_assets/guide/coneAndSpheres.png)

导出 ACIS 实体不需要任何特殊选项。为优化绘图大小，尤其是在绘图仅包含 ACIS 实体时，请考虑使用 cadImage.updateSize() 函数准确调整初始绘图尺寸。

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
