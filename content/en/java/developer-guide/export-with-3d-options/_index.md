---
title: Export with 3D options
type: docs
weight: 40
url: /java/export-with-3d-options/
---

## **Export with 3D options**

Few options were introduced to export 3D models to PDF/raster from corresponding FBX, OBJ, STL formats.

Here are the examples of the 3D scene from different viewpoints:

![Figures](fig1.png)

![Figures from other points of view](fig2.png)

ObserverPoint property allows to rotate the 3D scene according to specified angles around axis. This example shows the code and export result using some arbitrary rotation angles.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}


![Export with rotation](fig3.png)

Changing the ObserverAngle to ObserverPoint = new ObserverPoint(5, 60, 0) allows to rotate the scene.

![Export with changed rotation](fig4.png)

The other RenderMode3D property allows to specify how export result should be presented. There are 3 modes: Solid (the default), Wireframe, and SolidWithEdges.

The example below allows to create wireframe model for the spherical object.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](fig5.png)

The example below shows the difference between Solid and SolidWithEdges modes.

![Solid mode](fig6.png)
![Solid with edge mode](fig7.png)