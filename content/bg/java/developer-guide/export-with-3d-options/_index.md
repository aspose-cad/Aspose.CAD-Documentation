---
title: Експорт с 3D опции
type: docs
weight: 40
url: /bg/java/developer-guide/export-with-3d-options/
---

## **Експорт с 3D опции**

Няколко опции бяха въведени за експортиране на 3D модели в PDF/растр от съответните формати FBX, OBJ, STL.

Ето примери за 3D сцени от различни точки на гледане:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

Свойството ObserverPoint позволява да се завърти 3D сцената в съответствие с определените ъгли около оста. Този пример показва кода и резултата от експорта, използвайки произволни ъгли на завъртане.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/cad/_assets/guide/3d/fig3.png)

Промяната на ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) позволява завъртане на сцената.

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

Другото свойство RenderMode3D позволява да се зададе как резултатът от експорта трябва да бъде представен. Има 3 режима: Solid (по подразбиране), Wireframe и SolidWithEdges.

Примерът по-долу позволява създаване на wireframe модел за сферичен обект.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

Примерът по-долу показва разликата между режимите Solid и SolidWithEdges.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
