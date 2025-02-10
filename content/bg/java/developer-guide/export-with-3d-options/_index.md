---
title: Експорт с 3D опции
type: docs
weight: 40
url: /bg/java/export-with-3d-options/
---

## **Експорт с 3D опции**

Няколко опции бяха въведени за експортиране на 3D модели в PDF/растр от съответните формати FBX, OBJ, STL.

Ето примери за 3D сцени от различни точки на гледане:

![Figures](/_assets/fig1.png)

![Figures from other points of view](/_assets/fig2.png)

Свойството ObserverPoint позволява да се завърти 3D сцената в съответствие с определените ъгли около оста. Този пример показва кода и резултата от експорта, използвайки произволни ъгли на завъртане.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/_assets/fig3.png)

Промяната на ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) позволява завъртане на сцената.

![Export with changed rotation](/_assets/fig4.png)

Другото свойство RenderMode3D позволява да се зададе как резултатът от експорта трябва да бъде представен. Има 3 режима: Solid (по подразбиране), Wireframe и SolidWithEdges.

Примерът по-долу позволява създаване на wireframe модел за сферичен обект.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/_assets/fig5.png)

Примерът по-долу показва разликата между режимите Solid и SolidWithEdges.

![Solid mode](/_assets/fig6.png)
![Solid with edge mode](/_assets/fig7.png)
