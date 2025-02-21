---
title: Eksport z opcjami 3D
type: docs
weight: 40
url: /pl/java/developer-guide/export-with-3d-options/
---

## **Eksport z opcjami 3D**

Kilka opcji zostało wprowadzonych do eksportu modeli 3D do PDF/raster z odpowiednich formatów FBX, OBJ, STL.

Oto przykłady sceny 3D z różnych punktów widzenia:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

Właściwość ObserverPoint pozwala na obrót sceny 3D zgodnie z określonymi kątami wokół osi. Ten przykład pokazuje kod i wynik eksportu z użyciem dowolnych kątów obrotu.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Eksport z obrotem](/_assets/guide/3d/fig3.png)

Zmiana ObserverAngle na ObserverPoint = new ObserverPoint(5, 60, 0) pozwala na obrót sceny.

![Eksport z zmienionym obrotem](/_assets/guide/3d/fig4.png)

Inna właściwość RenderMode3D pozwala określić, w jaki sposób wynik eksportu powinien być przedstawiony. Istnieją 3 tryby: Solid (domyślny), Wireframe oraz SolidWithEdges.

Przykład poniżej pozwala na stworzenie modelu siatki dla obiektu sferycznego.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Tryb siatki](/_assets/guide/3d/fig5.png)

Przykład poniżej pokazuje różnicę między trybami Solid a SolidWithEdges.

![Tryb Solid](/_assets/guide/3d/fig6.png)
![Tryb Solid z krawędzią](/_assets/guide/3d/fig7.png)
