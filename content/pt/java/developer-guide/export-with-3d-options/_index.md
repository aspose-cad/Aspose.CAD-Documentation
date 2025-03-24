---
title: Exportar com opções 3D
type: docs
weight: 40
url: /pt/java/developer-guide/export-with-3d-options/
---

## **Exportar com opções 3D**

Algumas opções foram introduzidas para exportar modelos 3D para PDF/raster a partir dos formatos FBX, OBJ, STL correspondentes.

Aqui estão os exemplos da cena 3D de diferentes pontos de vista:

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures from other points of view](/cad/_assets/guide/3d/fig2.png)

A propriedade ObserverPoint permite rotacionar a cena 3D de acordo com os ângulos especificados em torno do eixo. Este exemplo mostra o código e o resultado da exportação usando alguns ângulos de rotação arbitrários.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Export with rotation](/cad/_assets/guide/3d/fig3.png)

Alterar o ObserverAngle para ObserverPoint = new ObserverPoint(5, 60, 0) permite rotacionar a cena.

![Export with changed rotation](/cad/_assets/guide/3d/fig4.png)

A outra propriedade RenderMode3D permite especificar como o resultado da exportação deve ser apresentado. Existem 3 modos: Sólido (o padrão), Malha e SólidoComArestas.

O exemplo abaixo permite criar um modelo de malha para o objeto esférico.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Wireframe mode](/cad/_assets/guide/3d/fig5.png)

O exemplo abaixo mostra a diferença entre os modos Sólido e SólidoComArestas.

![Solid mode](/cad/_assets/guide/3d/fig6.png)
![Solid with edge mode](/cad/_assets/guide/3d/fig7.png)
