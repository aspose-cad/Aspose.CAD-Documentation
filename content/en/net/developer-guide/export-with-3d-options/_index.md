---
title: Export with 3D options
type: docs
weight: 40
url: /net/developer-guide/export-with-3d-options/
---

## **Export with 3D options**

Few options were introduced to export 3D models to PDF/raster from corresponding FBX, OBJ, STL formats.

Here are the examples of the 3D scene from different viewpoints:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

ObserverPoint property allows to rotate the 3D scene according to specified angles around axis. This example shows the code and export result using some arbitrary rotation angles.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}


![Export with rotation](/_assets/guide/3d/fig3.png)

Changing the ObserverAngle to ObserverPoint = new ObserverPoint(5, 60, 0) allows to rotate the scene.

![Export with changed rotation](/_assets/guide/3d/fig4.png)

The other RenderMode3D property allows to specify how export result should be presented. There are 3 modes: Solid (the default), Wireframe, and SolidWithEdges.

The example below allows to create wireframe model for the spherical object.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

The example below shows the difference between Solid and SolidWithEdges modes.

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)