---
title: Export mit 3D-Optionen
type: docs
weight: 40
url: /de/java/developer-guide/export-with-3d-options/
---

## **Export mit 3D-Optionen**

Es wurden einige Optionen eingeführt, um 3D-Modelle aus entsprechenden FBX-, OBJ- und STL-Formaten in PDF/Raster zu exportieren.

Hier sind Beispiele der 3D-Szene aus verschiedenen Blickwinkeln:

![Figuren](/_assets/guide/3d/fig1.png)

![Figuren aus anderen Blickwinkeln](/_assets/guide/3d/fig2.png)

Die Eigenschaft ObserverPoint ermöglicht es, die 3D-Szene entsprechend der festgelegten Winkel um die Achse zu rotieren. Dieses Beispiel zeigt den Code und das Exportergebnis unter Verwendung einiger beliebiger Rotationswinkel.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export mit Rotation](/_assets/guide/3d/fig3.png)

Durch Ändern des ObserverAngle zu ObserverPoint = new ObserverPoint(5, 60, 0) kann die Szene gedreht werden.

![Mit geänderter Rotation exportieren](/_assets/guide/3d/fig4.png)

Die andere RenderMode3D-Eigenschaft ermöglicht es, wie das Exportergebnis präsentiert werden soll, zu spezifizieren. Es gibt 3 Modi: "Solid" (Standard), "Wireframe" und "SolidWithEdges".

Das folgende Beispiel ermöglicht es, ein Drahtgittermodell für das kugelförmige Objekt zu erstellen.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe-Modus](/_assets/guide/3d/fig5.png)

Das folgende Beispiel zeigt den Unterschied zwischen den Modi "Solid" und "SolidWithEdges".

![Solid-Modus](/_assets/guide/3d/fig6.png)
![Solid mit Kantenmodus](/_assets/guide/3d/fig7.png)
