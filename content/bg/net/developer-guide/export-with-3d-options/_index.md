---
title: Експорт с 3D опции
type: docs
weight: 40
url: /bg/net/developer-guide/export-with-3d-options/
---

## **Експорт с 3D опции**

Някои опции бяха въведени за експортиране на 3D модели в PDF/растер от съответните формати FBX, OBJ, STL.

Ето примери за 3D сцена от различни гледни точки:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

Свойството ObserverPoint позволява да се завърти 3D сцената според зададени ъгли около оста. Този пример показва кода и резултата от експорта с използване на произволни ъгли на завъртане.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

Промяната на ObserverAngle на ObserverPoint = new ObserverPoint(5, 60, 0) позволява да се завърти сцената.

![Export with changed rotation](/_assets/guide/3d/fig4.png)

Другото свойство RenderMode3D позволява да се зададе как резултатът от експорта трябва да бъде представен. Има 3 режима: Solid (по подразбиране), Wireframe и SolidWithEdges.

Примерът по-долу позволява да се създаде модел с контури за сферичен обект.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

Примерът по-долу показва разликата между Solid и SolidWithEdges режими.

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
