---
title: 3D 옵션으로 내보내기
type: docs
weight: 40
url: /ko/net/developer-guide/export-with-3d-options/
---

## **3D 옵션으로 내보내기**

해당 FBX, OBJ, STL 형식에서 PDF/래스터로 3D 모델을 내보내기 위한 몇 가지 옵션이 도입되었습니다.

다양한 관점에서 본 3D 장면의 예는 다음과 같습니다:

![Figures](/cad/_assets/guide/3d/fig1.png)

![다른 시점에서 본 그림](/cad/_assets/guide/3d/fig2.png)

ObserverPoint 속성은 지정된 각도에 따라 3D 장면을 회전할 수 있게 합니다. 이 예제는 임의의 회전 각도를 사용하여 코드와 내보내기 결과를 보여줍니다.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![회전과 함께 내보내기](/cad/_assets/guide/3d/fig3.png)

ObserverAngle을 ObserverPoint = new ObserverPoint(5, 60, 0)으로 변경하면 장면을 회전할 수 있습니다.

![변경된 회전으로 내보내기](/cad/_assets/guide/3d/fig4.png)

다른 RenderMode3D 속성은 내보내기 결과가 어떻게 표시되어야 하는지를 지정할 수 있게 합니다. Solid(기본값), Wireframe, SolidWithEdges의 3가지 모드가 있습니다.

아래 예제는 구형 객체에 대한 와이어프레임 모델을 생성할 수 있게 합니다.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![와이어프레임 모드](/cad/_assets/guide/3d/fig5.png)

아래 예제는 Solid와 SolidWithEdges 모드 간의 차이를 보여줍니다.

![Solid 모드](/cad/_assets/guide/3d/fig6.png)
![Edge가 있는 Solid 모드](/cad/_assets/guide/3d/fig7.png)
