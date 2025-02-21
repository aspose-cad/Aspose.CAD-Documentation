---
title: CAD図面をPDFおよびラスター画像形式に変換する
type: docs
weight: 30
url: /ja/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Javaは、出力文書にAPIおよびバージョン番号に関する情報を直接書き込みます。たとえば、文書をPDFにレンダリングすると、Aspose.CAD for Javaはアプリケーションフィールドに値「Aspose.CAD」を、PDF Producerフィールドに値（例： 'Aspose.CAD v 17.9'）を設定します。

Aspose.CAD for Javaにこの情報を出力文書から変更または削除するよう指示することはできませんのでご注意ください。

{{% /alert %}} 
## **CAD図面をラスター画像形式に変換する**
Aspose.CAD for Javaは、[**DXF**](https://docs.fileformat.com/cad/dxf/)や[**DWG**](https://docs.fileformat.com/cad/dwg/)などのCAD描画形式を、[**PNG**](https://docs.fileformat.com/image/png/)、[**BMP**](https://docs.fileformat.com/image/bmp/)、[**TIFF**](https://docs.fileformat.com/image/tiff/)、[**JPEG**](https://docs.fileformat.com/image/jpeg/)および[**GIF**](https://docs.fileformat.com/image/gif/)などのサポートされているラスター画像形式に変換することができます。Aspose.CAD for Java APIは、この目的を達成するための効率的で使いやすい手段を提供しています。
サポートされるCAD描画形式をラスター画像形式に変換するための簡単な手順は以下のとおりです。

1. CADファイルを[**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)のインスタンスにロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)や[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)などの必須プロパティを設定します。
1. **ImageOptionsBase**のインスタンスを作成し、その[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)プロパティを前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
1. ファイルパス（またはMemoryStreamのオブジェクト）および前のステップで作成した[**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase)のインスタンスを引数にして**Image.save**を呼び出します。

以下は完全なソースコードです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



デフォルトでは、APIは「モデル」レイアウトのみをレンダリングします。ただし、CAD図面を画像形式に変換する際に、希望するレイアウトを指定することもできます。
## **CAD変換のカスタマイズ**
CADから[PDF](https://docs.fileformat.com/pdf/)およびCADからラスター画像への変換手順は、高度に構成可能です。これは、[**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスが、アプリケーションのニーズに応じてレンダリングプロセスをオーバーライドできる多くのオプション機能を提供するように実装されているからです。
### **CadRasterizationOptionsクラス**
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスは、[**DWG**](https://docs.fileformat.com/cad/dwg/)や[DXF](https://docs.fileformat.com/cad/dxf/)などのすべてのサポートされているCAD形式に共通であるため、この文書で共有されている情報は、上記のCAD形式の両方に有効です。

最も便利な**CadRasterizationOptions**クラスのプロパティは次のとおりです。

|**プロパティ**|**デフォルト値**|**必須**|**説明**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|はい|ページの幅を指定します。|
|**PageHeight**|**0**|はい|ページの高さを指定します。|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|いいえ|描画が自動的にスケーリングされるべきかどうかを指定します。デフォルト値は、キャンバスサイズに合うように画像を自動的に縮小します。**GrowToFit**モードに切り替えるか、**None**設定を使用して自動スケーリングを無効にします。|
|**BackgroundColor**|**Color.White**|いいえ|出力画像の背景色を指定します。|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|いいえ|エンティティの色付けモードを指定します。エンティティをそのネイティブカラーで描画するために**UseObjectColor**オプションを指定するか、ネイティブカラーをオーバーライドするために**UseDrawColor**オプションを指定します。|
|**DrawColor**|**Color.Black**|いいえ|オーバーライドされたエンティティの色を指定します（**DrawType**が**UseDrawColor**プロパティ値に設定されている場合のみ）。|
|**AutomaticLayoutsScaling**|False|いいえ|モデルレイアウトに一致させるために自動レイアウトのスケーリングを実行する必要があるかどうかを指定します。|
### **キャンバスのサイズとモードの設定**
CADからPDFまたはCADからラスター画像形式へのエクスポートは、容易なタスクではありません。生成されたPDFまたは画像にはキャンバスサイズを定義する必要があるため、描画を適切にレンダリングするためにPDFページの出力寸法を指定する必要があります。**CadRasterizationOptions.PageWidth**および**CadRasterizationOptions.PageHeight**プロパティを明示的に設定するか、**ImageSaveException**が発生します。

さらに、寸法スケールオプションを指定できます。スケーリングオプションは、**CadRasterizationOptions.ScaleMethod**プロパティによって設定されます。このオプションを使用して、**CadRasterizationOptions.PageWidth**および**CadRasterizationOptions.PageHeight**の値に基づいて画像の寸法を自動的に調整します。デフォルトで、**CadRasterizationOptions.ScaleMethod**は**ScaleType.ShrinkToFit**モードに設定されています。このプロパティは、以下の動作を定義します：

- CAD図面の寸法が生成されるキャンバスサイズよりも大きい場合、描画の寸法はアスペクト比を保持しながら生成されたキャンバスに収まるように縮小されます。
- CAD図面の寸法が生成されるキャンバスサイズよりも小さい場合、**CadRasterizationOptions.ScaleMethod**プロパティを**ScaleType.GrowToFit**に設定し、アスペクト比を保持しながら描画のサイズをPDFキャンバスに収まるように拡大します。
- または、**ScaleType.None**オプションで自動スケーリングを無効にします。

以下のコードサンプルは、自動スケーリングオプションの使用を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **背景色と描画色の設定**
デフォルトでは、生成されたキャンバスのカラーパレットは、一般的な文書スキームに設定されています。これは、CAD図面内のすべてのエンティティが、白い背景に黒いペンで描画されることを意味します。これらの設定は、**CadRasterizationOptions.BackgroundColor**と**CadRasterizationOptions.DrawColor**プロパティで変更できます。**CadRasterizationOptions.DrawColor**プロパティを変更するには、描画に使用する色を利用するために**CadRasterizationOptions.DrawType**プロパティも設定することが必要です。**CadRasterizationOptions.DrawType**プロパティは、CADエンティティがその色を保持するか、カスタム色に変換されるかを制御します。エンティティの色を保持するためには、**CadRasterizationOptions.DrawType**を**CadDrawTypeMode.UseObjectColor**として指定し、そうでない場合は、**CadDrawTypeMode.UseDrawColor**の値を指定します。

以下のコードサンプルは、異なる色プロパティの使用方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **自動レイアウトスケーリングの設定**
ほとんどのCAD図面には、単一ファイル内に複数のレイアウトが保存されており、それぞれのレイアウトは異なる寸法を持つ可能性があります。このようなCAD図面をPDFにレンダリングする際、PDFの各ページはレイアウトサイズに応じて異なるスケーリングを持つ可能性があります。レンダリングを均一にするために、Aspose.CAD APIは**CadRasterizationOptions.AutomaticLayoutsScaling**プロパティを公開しています。そのデフォルト値は**false**ですが、trueにすると、APIは各レイアウトに対応するスケールを検索し、ページサイズに応じた自動リサイズ操作を実行して描画します。

以下は、**CadRasterizationOptions.AutomaticLayoutsScaling**プロパティが**CadRasterizationOptions.ScaleMethod**プロパティと協力してどのように機能するかです。

1. **ScaleMethod**が**ScaleType.ShrinkToFit**または**ScaleType.GrowToFit**に設定され、**AutomaticLayoutsScaling**がfalseに設定されている場合、すべてのレイアウト（モデルを含む）は最初のオプションに従って処理されます。
1. **ScaleMethod**が**ScaleType.ShrinkToFit**または**ScaleType.GrowToFit**に設定され、**AutomaticLayoutsScaling**がtrueに設定されている場合、すべてのレイアウト（モデルを除く）はそのサイズに基づいて処理され、モデルは最初のオプションに従って処理されます。
1. **ScaleMethod**が**ScaleType.None**に設定され、**AutomaticLayoutsScaling**がtrueまたはfalseに設定されている場合、スケーリングは行われません。

以下のコードサンプルは、CADからPDFへの変換のために自動レイアウトスケーリングを設定する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **CADレイアウトをラスター画像形式に変換する**
Aspose.CAD for Java APIは、DXFやDWGなどのサポートされている形式のCADレイアウトを、PNG、BMP、TIFF、JPEG、GIFなどのラスター画像に変換することができます。APIは、CAD図面の特定のレイアウトを異なるPSDレイヤーにレンダリングするサポートも提供します。
Aspose.CAD for Java APIは、要求されるCADレイアウトのリストを指定し、それらをラスター画像形式にレンダリングするための効率的で使いやすい手段を提供しています。以下は、5つの簡単な手順で同様のことを達成する方法です。

1. **Load**ファクトリメソッドを使用してCADファイルを**Image**のインスタンスにロードします。
1. **CadRasterizationOptions**のインスタンスを作成し、**PageWidth**や**PageHeight**などの必須プロパティを設定します。
1. CadRasterizationOptions.Layoutsプロパティを使用して、希望するレイアウト名を指定します。
1. **ImageOptionsBase**のインスタンスを作成し、その**VectorRasterizationOptions**プロパティを前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
1. ファイルパス（またはMemoryStreamのオブジェクト）および前のステップで作成した**ImageOptionsBase**のインスタンスを引数にして**Image.Save**を呼び出します。

以下は完全なソースコードです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

**CadRasterizationOptions.Layouts**プロパティは文字列配列型であるため、一度に複数のレイアウトを画像形式への変換のために指定できます。**CadRasterizationOptions.Layouts**プロパティに複数のレイアウトを指定する場合、生成されるTIFF画像には複数のページが含まれ、GIF画像には複数のフレームが含まれ、PSD形式には複数のレイヤーが含まれ、それぞれのページ/フレーム/レイヤーは個別のAutoCADレイアウトを表します。PNG、BMP、JPEGなどの他の画像形式を結果に保存する場合、APIはデフォルトのレイアウト「モデル」だけをレンダリングします。

{{% /alert %}} 
## **CADレンダリングプロセスの追跡を有効にする**
Aspose.CADは、CADレンダリングプロセスの追跡を支援するための一連のクラスとサポートする列挙型フィールドを導入しました。こうした変更のもと、CADからPDFへの変換は、追跡を有効にしながら以下のように実現できるようになりました。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



CADレンダリングプロセスの追跡は、以下のような問題を検出できます。

1. ヘッダー情報の欠如または破損。
1. レイアウト情報の欠如。
1. ブロックエンティティの欠如。
1. 寸法スタイルの欠如。
1. スタイルの欠如。
## **CAD図面を変換する際のフォントの置き換え**
特定のCAD図面が、CADからPDFまたはCADからラスター画像への変換が行われているマシン上にない特定のフォントを使用する可能性があります。そのような状況では、Aspose.CAD APIは適切な例外を発生させ、必要なフォントが正しく結果のPDFや画像にコンテンツをレンダリングするために必要であるため、変換プロセスを停止します。
Aspose.CAD APIは、必要なフォントを使用可能なフォントに置き換えるためのメカニズムを簡単に使用できる方法を提供しています。**CadImage.Styles**プロパティは、CAD図面内の各スタイルの**CadStyleTableObject**を含む**CadStylesDictionary**のインスタンスを返します。**CadStyleTableObject.PrimaryFontName**を使用して、利用可能なフォント名を指定できます。

以下のコードスニペットは、Aspose.CAD for Java APIを使用してCAD図面内のすべてのスタイルのフォントを変更する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




特定のスタイルのフォントをスタイル名を介してアクセスすることで変更することも可能です。以下のコードスニペットはこのアプローチの使用を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **CADレイヤーをラスター画像形式に変換する**
Aspose.CAD for Java APIは、必要なCADレイヤーの名前を指定し、それをラスター画像形式にレンダリングするための効率的で使いやすい手段を提供しています。以下は、5つの簡単な手順で同様のことを達成する方法です。

1. **Load**ファクトリメソッドを使用してCADファイルを**Image**のインスタンスにロードします。
1. **CadRasterizationOptions**のインスタンスを作成し、**PageWidth**や**PageHeight**などの必須プロパティを設定します。
1. **CadRasterizationOptions.Layers.add**メソッドを使用して、希望するレイヤー名を追加します。
1. **ImageOptionsBase**のインスタンスを作成し、その**VectorRasterizationOptions**プロパティを前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
1. ファイルパス（またはMemoryStreamのオブジェクト）および前のステップで作成した**ImageOptionsBase**のインスタンスを引数にして**Image.save**メソッドを呼び出します。

以下は完全なソースコードです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **すべてのCADレイヤーを個別の画像に変換する**
**CadImage.Layers**を使用してCAD図面からすべてのレイヤーを取得し、各レイヤーを別々の画像としてレンダリングできます。以下に示します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **DWF CADレイヤーをラスター画像形式に変換する**
Aspose.CAD for Java APIは、必要なCADレイヤーの名前を指定し、それをラスター画像形式にレンダリングするための効率的で使いやすい手段を提供しています。以下は、5つの簡単な手順で同様のことを達成する方法です。

1. DWF CADファイルを**Image**のインスタンスに**Load**ファクトリメソッドを使用してロードします。
1. **CadRasterizationOptions**のインスタンスを作成し、**PageWidth**や**PageHeight**などの必須プロパティを設定します。
1. **CadRasterizationOptions.Layers.Add**メソッドを使用して、希望するレイヤー名を追加します。
1. **ImageOptionsBase**のインスタンスを作成し、その**VectorRasterizationOptions**プロパティを前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
1. ファイルパス（またはMemoryStreamのオブジェクト）および前のステップで作成した**ImageOptionsBase**のインスタンスを引数にして**Image.Save**メソッドを呼び出します。

以下は完全なソースコードです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
