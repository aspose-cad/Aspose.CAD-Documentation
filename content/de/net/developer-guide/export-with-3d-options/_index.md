---
title: Export mit 3D-Optionen
type: docs
weight: 40
url: /de/net/export-with-3d-options/
---

## **Export mit 3D-Optionen**

Einige Optionen wurden eingeführt, um 3D-Modelle von den entsprechenden FBX-, OBJ-, STL-Formaten nach PDF/Raster zu exportieren.

Hier sind die Beispiele der 3D-Szene aus verschiedenen Blickwinkeln:

![Figures](fig1.png)

![Figures aus anderen Blickwinkeln](fig2.png)

Die ObserverPoint-Eigenschaft ermöglicht es, die 3D-Szene gemäß den angegebenen Winkeln um die Achse zu drehen. Dieses Beispiel zeigt den Code und das Exportergebnis unter Verwendung einiger willkürlich gewählter Rotationswinkel.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export mit Rotation](fig3.png)

Durch Ändern des ObserverAngle zu ObserverPoint = new ObserverPoint(5, 60, 0) kann die Szene gedreht werden.

![Export mit geänderter Rotation](fig4.png)

Die andere RenderMode3D-Eigenschaft ermöglicht es, anzugeben, wie das Exportergebnis präsentiert werden soll. Es gibt 3 Modi: Solid (der Standard), Wireframe und SolidWithEdges.

Das folgende Beispiel ermöglicht es, ein Wireframe-Modell für das sphärische Objekt zu erstellen.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe-Modus](fig5.png)

Das folgende Beispiel zeigt den Unterschied zwischen den Modi Solid und SolidWithEdges.

![Solid-Modus](fig6.png)
![Solid mit Kanten-Modus](fig7.png)