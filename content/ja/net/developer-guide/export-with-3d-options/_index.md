---
title: 3Dオプションでのエクスポート
type: docs
weight: 40
url: /ja/net/developer-guide/export-with-3d-options/
---

## **3Dオプションでのエクスポート**

FBX、OBJ、STLフォーマットからPDF/rasterに3Dモデルをエクスポートするためのいくつかのオプションが導入されました。

こちらは、異なる視点からの3Dシーンの例です。

![Figures](/_assets/guide/3d/fig1.png)

![他の視点からの図](/_assets/guide/3d/fig2.png)

ObserverPointプロパティは、指定された角度に従って3Dシーンを回転させることを可能にします。この例では、任意の回転角を使用したコードとエクスポート結果を示しています。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![回転を伴うエクスポート](/_assets/guide/3d/fig3.png)

ObserverAngleをObserverPoint = new ObserverPoint(5, 60, 0)に変更すると、シーンを回転させることができます。

![回転を変更したエクスポート](/_assets/guide/3d/fig4.png)

他のRenderMode3Dプロパティは、エクスポート結果がどのように表示されるべきかを指定することを可能にします。モードは3つあり、Solid（デフォルト）、Wireframe、そしてSolidWithEdgesがあります。

以下の例では、球体オブジェクトのワイヤーフレームモデルを作成できます。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![ワイヤーフレームモード](/_assets/guide/3d/fig5.png)

以下の例では、SolidモードとSolidWithEdgesモードの違いを示しています。

![ソリッドモード](/_assets/guide/3d/fig6.png)
![エッジ付きソリッドモード](/_assets/guide/3d/fig7.png)
