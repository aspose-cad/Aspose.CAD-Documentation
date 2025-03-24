---
title: SAT/SAB構造を持つエンティティ
type: docs
weight: 40
url: /ja/net/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB構造を持つエンティティ**

特定のエンティティは、その構造データをACIS SAT/SAB形式で保存します。これらのエンティティは、2Dワイヤーフレームモードで部分的にエクスポートできます。サポートされているエンティティには以下が含まれます：

*	3DSOLIDオブジェクト：ボックス、球、ピラミッド、くさび、円錐、シリンダー、トーラス、ポリソリッド
*	SURFACE：平面、押出し、回転、スイープ
*	REGION

以下はエクスポート結果の例です（左側にDWGファイル、右側にPDF結果）。

![Export of cone and spheres](/cad/_assets/guide/coneAndSpheres.png)

ACISエンティティをエクスポートするには、特別なオプションは必要ありません。特に描画がACISエンティティのみを含む場合、初期描画寸法を正確に調整するためにcadImage.UpdateSize()関数の使用を検討してください。

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
