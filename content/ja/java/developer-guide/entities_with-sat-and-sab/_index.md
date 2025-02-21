---
title: SAT/SAB構造を持つエンティティ
type: docs
weight: 40
url: /ja/java/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB構造を持つエンティティ**

特定のエンティティは、その構造データをACIS SAT/SAB形式で保存します。これらのエンティティは、2Dワイヤーフレームモードで部分的にエクスポートできます。サポートされているエンティティは以下の通りです：

*	3DSOLIDオブジェクト：ボックス、球、ピラミッド、ウェッジ、円錐、シリンダー、トーラス、ポリソリッド
*	SURFACE：平面、押出、回転、スイープ
*	REGION

以下はエクスポート結果の例です（左側がDWGファイル、右側がPDF結果）。

![円錐と球のエクスポート](/_assets/guide/coneAndSpheres.png)

ACISエンティティのエクスポートには、特別なオプションは必要ありません。特にACISエンティティのみを含む図面のサイズを最適化するためには、cadImage.updateSize()関数を使用して初期図面の寸法を正確に調整することを検討してください。

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
