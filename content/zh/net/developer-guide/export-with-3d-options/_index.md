---
title: 带有 3D 选项的导出
type: docs
weight: 40
url: /zh/net/developer-guide/export-with-3d-options/
---

## **带有 3D 选项的导出**

引入了一些选项，以将 3D 模型从相应的 FBX、OBJ、STL 格式导出为 PDF/栅格。

以下是从不同视角看到的 3D 场景示例：

![Figures](/cad/_assets/guide/3d/fig1.png)

![其他视角的图形](/cad/_assets/guide/3d/fig2.png)

ObserverPoint 属性允许根据指定的角度围绕轴旋转 3D 场景。这个示例展示了使用一些任意旋转角度的代码和导出结果。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![带有旋转的导出](/cad/_assets/guide/3d/fig3.png)

将 ObserverAngle 更改为 ObserverPoint = new ObserverPoint(5, 60, 0) 允许旋转场景。

![带有变更旋转的导出](/cad/_assets/guide/3d/fig4.png)

另一个 RenderMode3D 属性允许指定导出结果应如何呈现。有 3 种模式：实心（默认）、线框和带边缘的实心。

下面的示例允许为球形对象创建线框模型。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![线框模式](/cad/_assets/guide/3d/fig5.png)

下面的示例显示了实心模式和带边缘的实心模式之间的差异。

![实心模式](/cad/_assets/guide/3d/fig6.png)
![带边缘的实心模式](/cad/_assets/guide/3d/fig7.png)
