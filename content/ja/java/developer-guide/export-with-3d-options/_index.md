---
title: 3Dオプションでのエクスポート
type: docs
weight: 40
url: /ja/java/developer-guide/export-with-3d-options/
---

## **3Dオプションでのエクスポート**

関連するFBX、OBJ、STL形式からPDF/rasterへの3Dモデルをエクスポートするためにいくつかのオプションが導入されました。

異なる視点からの3Dシーンの例は以下の通りです：

![Figures](/_assets/guide/3d/fig1.png)

![他の視点からの図](/_assets/guide/3d/fig2.png)

ObserverPointプロパティは、指定された角度に従って3Dシーンを回転させることを可能にします。この例では、任意の回転角を使用したコードとエクスポート結果を示します。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![回転を伴うエクスポート](/_assets/guide/3d/fig3.png)

ObserverAngleをObserverPoint = new ObserverPoint(5, 60, 0)に変更することで、シーンを回転させることができます。

![回転を変更したエクスポート](/_assets/guide/3d/fig4.png)

他のRenderMode3Dプロパティは、エクスポート結果がどのように提示されるべきかを指定することを可能にします。モードは3つあります：ソリッド（デフォルト）、ワイヤーフレーム、ソリッドwith Edgesです。

以下の例では、球体オブジェクトのワイヤーフレームモデルを作成します。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![ワイヤーフレームモード](/_assets/guide/3d/fig5.png)

以下の例は、ソリッドモードとソリッドwith Edgesモードの違いを示しています。

![ソリッドモード](/_assets/guide/3d/fig6.png)
![エッジ付きソリッドモード](/_assets/guide/3d/fig7.png)
