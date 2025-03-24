---
title: 使用 3D 选项导出
type: docs
weight: 40
url: /zh/java/developer-guide/export-with-3d-options/
---

## **使用 3D 选项导出**

引入了一些选项来从对应的 FBX、OBJ、STL 格式导出 3D 模型到 PDF/光栅。

以下是从不同视角观察的 3D 场景示例：

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

ObserverPoint 属性允许根据指定的角度绕轴旋转 3D 场景。此示例展示了使用某些任意旋转角度的代码和导出结果。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/cad/_assets/guide/3d/fig3.png)

将 ObserverAngle 更改为 ObserverPoint = new ObserverPoint(5, 60, 0) 可以旋转场景。

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

另一个 RenderMode3D 属性允许指定导出结果的呈现方式。有 3 种模式：实心（默认），线框和带边缘的实心。

以下示例允许为球状物体创建线框模型。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

以下示例显示了实心模式和带边缘的实心模式之间的区别。

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
