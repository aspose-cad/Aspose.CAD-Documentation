---
title: DWG DXFをPDFに変換するC# | Auto CADファイルをPDF JPEG PNGに変換するC# .NET
type: docs
weight: 30
url: /ja/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWGからPDF C#, DXFからPDF C#, DWF DWTからPDF C#, AutoCADを変換, DWGを変換, DWFを変換, DWTを変換, DXFを変換, AutoCADをPDFに変換, DWGをPDFに変換, DWGをPNGに変換, DWGをTIFFに変換, DWGをJPGに変換"
description: C# .NETのAutoCADからPDFコンバーターを使用してDWGまたはDXFをC#でPDFに変換します。C# .NETを使用してDWG、DWF、DWT、およびDXFをPDF、JPEG、PNG、BMP、GIF、およびTIFFに変換できます。
---

## **C#でDWGまたはDXFをPNG JPEG BMP GIF またはTIFFに変換する**

Aspose.CAD for .NETは、AutoCAD図面フォーマット（[DXF](https://docs.fileformat.com/cad/dxf/)および[DWG](https://docs.fileformat.com/cad/dwg/)）を[PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/)および[GIF](https://docs.fileformat.com/image/gif/)に変換できます。この目的を達成するために、効率的で使いやすいAPIが公開されています。

サポートされている任意のAutoCAD図面フォーマットをラスタ画像フォーマットに変換するには、以下の簡単な手順を参照してください。

1. AutoCAD DWGまたはDXFファイルを[**Image**](https://reference.aspose.com/cad/net/aspose.cad/image)クラスに読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)のインスタンスを作成します。
1. [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)および[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)を使用して画像のサイズを設定/変更します。
1. [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)のインスタンスを作成します。
1. 前のステップで作成された[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)を[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)プロパティに設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save)を使用してAutoCAD図面をPDFとして保存し、ファイルパス（またはMemoryStreamのオブジェクト）と前のステップで作成された[**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)のインスタンスを渡します。

これが完全なソースコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

デフォルトでは、APIは「Model」レイアウトのみをレンダリングします。ただし、CAD図面を画像フォーマットに変換する際に、選択したレイアウトも指定できます。

## **CAD変換のカスタマイズ**

CADから[PDF](https://docs.fileformat.com/pdf/)およびCADからラスタ画像への変換手順は非常に構成可能です。なぜなら、[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスは、設定に応じてアプリケーションのニーズに応じてレンダリングプロセスをオーバーライドする多くのオプション機能を提供するように実装されているからです。

### **CadRasterizationOptionsクラス**

**CadRasterizationOptions**クラスは、DWGやDXFなどのすべてのサポートされているCADフォーマットに共通であるため、この記事で共有されている情報は前述のCADフォーマットの両方に対して有効です。

最も便利な**CadRasterizationOptions**クラスのプロパティは次のとおりです。

|**プロパティ**|**デフォルト値**|**必須**|**説明**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|はい|ページの幅を指定します。|
|**PageHeight**|**0**|はい|ページの高さを指定します。|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|いいえ|図面が自動的にスケーリングされるべきかどうかを指定します。デフォルト値は、画像をキャンバスサイズに合わせて自動的に縮小します。**GrowToFit**モードに切り替えるか、**None**設定を使用して自動スケーリングを無効にします。|
|**BackgroundColor**|**Color.White**|いいえ|出力画像の背景色を指定します。|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|いいえ|エンティティの着色モードを指定します。エンティティをそのネイティブカラーで描画するには**UseObjectColor**オプションを指定し、ネイティブカラーをオーバーライドするには**UseDrawColor**オプションを指定します。|
|**DrawColor**|**Color.Black**|いいえ|オーバーライドされたエンティティの色を指定します（**DrawType**が**UseDrawColor**プロパティ値に設定されている場合のみ）。|
|**AutomaticLayoutsScaling**|偽|いいえ|自動レイアウトスケーリングを実行する必要があるかどうかを指定します。|

### **キャンバスサイズとモードの設定**

CADからPDFまたはCADからラスタ画像フォーマットへのエクスポートは簡単な作業ではありません。生成されるPDFまたは画像には、図面を適切にレンダリングするためにキャンバスサイズを定義する必要があるため、PDFページの出力寸法を指定する必要があります。**CadRasterizationOptions.PageWidth**と**CadRasterizationOptions.PageHeight**プロパティを明示的に設定するか、そうでない場合は**ImageSaveException**を取得する可能性があります。

さらに、寸法スケールオプションを指定できます。スケーリングオプションは**CadRasterizationOptions.ScaleMethod**プロパティによって設定されます。このオプションを使用して、画像の寸法を**CadRasterizationOptions.PageWidth**および**CadRasterizationOptions.PageHeight**の値に自動的に調整できます。デフォルトでは**CadRasterizationOptions.ScaleMethod**は**ScaleType.ShrinkToFit**モードに設定されています。このプロパティは次の動作を定義します。

- CAD図面の寸法が結果キャンバスサイズより大きい場合、図面の寸法はアスペクト比を保持しながら、結果キャンバスに収まるように減少されます。
- CAD図面の寸法が結果キャンバスサイズより小さい場合、**CadRasterizationOptions.ScaleMethod**プロパティを**ScaleType.GrowToFit**に設定して、図面サイズをPDFキャンバスに収まるように増加させますが、アスペクト比は保持します。
- または**ScaleType.None**オプションで自動スケーリングを無効にします。

以下のコードサンプルでは、自動スケーリングオプションの使用を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **背景および描画色の設定**

デフォルトでは、生成されるキャンバスのカラーパレットは一般的なドキュメントスキームに設定されています。つまり、CAD図面内のすべてのエンティティは、無地の白い背景に黒いペンで描画されます。これらの設定は、**CadRasterizationOptions.BackgroundColor**および**CadRasterizationOptions.DrawColor**プロパティで変更できます。**CadRasterizationOptions.DrawColor**プロパティを変更するには、描画色を使用するようにするために**CadRasterizationOptions.DrawType**プロパティを設定する必要があります。**CadRasterizationOptions.DrawType**プロパティは、CADエンティティが色を保持するか、カスタム色に変換されるかを制御します。エンティティの色を保持するには、**CadRasterizationOptions.DrawType**を**CadDrawTypeMode.UseObjectColor**として指定します。それ以外の場合は、**CadDrawTypeMode.UseDrawColor**値を指定します。

以下のコードサンプルでは、異なる色プロパティの使用方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **自動レイアウトスケーリングの設定**

ほとんどのCAD図面には、1つのファイルに複数のレイアウトが保存されており、それぞれのレイアウトの寸法が異なる場合があります。そのため、そのようなCAD図面をPDFにレンダリングする際、PDFの各ページはレイアウトサイズに応じて異なるスケーリングを持つ可能性があります。レンダリングを均一にするために、Aspose.CAD APIは**CadRasterizationOptions.AutomaticLayoutsScaling**プロパティを公開しています。デフォルト値は**false**ですが、trueの場合、APIは各レイアウトに対応するスケールを検索し、ページサイズに応じて自動的に再サイズ操作を実行して描画します。

以下が**CadRasterizationOptions.AutomaticLayoutsScaling**プロパティが**CadRasterizationOptions.ScaleMethod**プロパティと組み合わせてどのように機能するかです。

1. **ScaleMethod**が**ScaleType.ShrinkToFit**または**ScaleType.GrowToFit**に設定され、**AutomaticLayoutsScaling**がfalseに設定されている場合、すべてのレイアウト（モデルを含む）は最初のオプションに従って処理されます。
1. **ScaleMethod**が**ScaleType.ShrinkToFit**または**ScaleType.GrowToFit**に設定され、**AutomaticLayoutsScaling**がtrueに設定されている場合、すべてのレイアウト（モデルを除く）はそれぞれのサイズに応じて処理され、一方でモデルは最初のオプションに従って処理されます。
1. **ScaleMethod**が**ScaleType.None**に設定され、**AutomaticLayoutsScaling**がtrueまたはfalseに設定されている場合は、スケーリングは行われません。

以下のコードサンプルでは、CADからPDFへの変換のために自動レイアウトスケーリングを設定する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **C#でAutoCAD DXFまたはDWGレイアウトをPNGまたは他の画像フォーマットに変換する**

Aspose.CAD for .NET APIは、DXFやDWGなどのサポートされているフォーマットのCADレイアウトをPNG BMP TIFF JPEGおよびGIFに変換できます。このAPIは、CAD図面の特定のレイアウトを異なるPSDレイヤーにレンダリングするサポートも提供します。

以下の簡単な手順で同様のことを達成できます。

- **Image**クラスを使用してAutoCAD DWGまたはDXFファイルを読み込みます。
- 画像の幅と高さを設定/変更します。
- CadRasterizationOptions.Layoutsプロパティを使用して、希望するレイアウト名を設定します。
- **ImageOptionsBase**のインスタンスを作成し、その**VectorRasterizationOptions**プロパティを前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
- CADレイアウトをTIFFまたは画像として保存します。

これが完全なソースコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

プロパティ**CadRasterizationOptions.Layouts**は文字列配列の型であるため、画像フォーマットに変換可能な複数のレイアウトを同時に指定できます。**CadRasterizationOptions.Layouts**プロパティに複数のレイアウトを指定する際、結果として得られるTIFF画像には複数のページがあり、GIF画像には複数のフレームがあり、[PSD](https://docs.fileformat.com/image/psd/)フォーマットには複数のレイヤーがあります。各ページ/フレーム/レイヤーは、個々のAutoCADレイアウトを表します。PNG、BMP、JPEGなどの他の画像フォーマットを選択して結果を保存する場合、APIはデフォルトレイアウト、つまり「モデル」だけをレンダリングします。

{{% /alert %}}

## **CADレンダリングプロセスの追跡を有効にする**

Aspose.CADは、CADレンダリングプロセスの追跡を支援するために、一連のクラスとサポートする列挙フィールドを導入しました。これらの変更により、CADからPDFへの変換を行う際に追跡を有効にすることができます。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

CADレンダリングプロセスの追跡では、以下の問題を検出できます。

1. ヘッダー情報が欠落または破損しています。
1. レイアウト情報が欠落しています。
1. ブロックエンティティが欠落しています。
1. 寸法スタイルが欠落しています。
1. スタイルが欠落しています。

## **CAD図面を変換する際のフォントの置き換え**

特定のCAD図面が、CADからPDFまたはCADからラスタ画像への変換が行われているマシンで利用できない特定のフォントを使用している場合があります。そのような状況では、Aspose.CAD APIは適切な例外をトリガーして欠落しているフォントを強調し、変換プロセスを停止します。APIは、これらのフォントを使用して、生成されるPDFや画像に正しく内容をレンダリングする必要があります。

Aspose.CAD APIは、必要なフォントを利用可能なフォントに置き換えるメカニズムを簡単に使用できる方法を提供しています。**CadImage.Styles**プロパティは、CAD図面の各スタイルの**CadStyleTableObject**を含む**CadStylesDictionary**のインスタンスを返します。**CadStyleTableObject.PrimaryFontName**を使用して利用可能なフォント名を指定できます。

以下のコードスニペットは、Aspose.CAD for .NET APIを使用してCAD図面内のすべてのスタイルのフォントを変更する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

特定のスタイル名を介してアクセスすることにより、特定のスタイルのフォントを変更することも可能です。以下のコードスニペットは、このアプローチの使用方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **CADレイヤーをラスタ画像フォーマットに変換する**

Aspose.CAD for .NET APIは、必要なCADレイヤーの名前を指定し、ラスタ画像フォーマットにレンダリングするための効率的で使いやすい手段を公開しています。以下の5つの簡単な手順で同様のことを達成できます。

1. ファクトリメソッド**Load**を使用してCADファイルを**Image**のインスタンスに読み込みます。
1. **CadRasterizationOptions**のインスタンスを作成し、**PageWidth**および**PageHeight**などの必須プロパティを設定します。
1. **CadRasterizationOptions.Layers.Add**メソッドを使用して、希望するレイヤー名を追加します。
1. **ImageOptionsBase**のインスタンスを作成し、その**VectorRasterizationOptions**プロパティを、前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
1. **Image.Save**メソッドを呼び出し、ファイルパス（またはMemoryStreamのオブジェクト）と前のステップで作成した**ImageOptionsBase**のインスタンスを渡します。

これが完全なソースコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **すべてのCADレイヤーを別々の画像に変換する**

**CadImage.Layers**を使用してCAD図面からすべてのレイヤーを取得し、以下のように各レイヤーを別の画像としてレンダリングできます。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **DWF CADレイヤーをラスタ画像フォーマットに変換する**

Aspose.CAD for .NET APIは、必要なCADレイヤーの名前を指定し、ラスタ画像フォーマットにレンダリングするための効率的で使いやすい手段を公開しています。以下の5つの簡単な手順で同様のことを達成できます。

1. ファクトリメソッド**Load**を使用してDWF CADファイルを**Image**のインスタンスに読み込みます。
1. **CadRasterizationOptions**のインスタンスを作成し、**PageWidth**および**PageHeight**などの必須プロパティを設定します。
1. **CadRasterizationOptions.Layers.Add**メソッドを使用して希望するレイヤー名を追加します。
1. **ImageOptionsBase**のインスタンスを作成し、その**VectorRasterizationOptions**プロパティを前のステップで作成した**CadRasterizationOptions**のインスタンスに設定します。
1. **Image.Save**メソッドを呼び出し、ファイルパス（またはMemoryStreamのオブジェクト）と前のステップで作成した**ImageOptionsBase**のインスタンスを渡します。

これが完全なソースコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD for .NETは、APIとバージョン番号に関する情報を出力ドキュメントに直接書き込みます。たとえば、ドキュメントをPDFにレンダリングすると、Aspose.CAD for .NETは、アプリケーションフィールドに「Aspose.CAD」、PDFプロデューサーフィールドに「Aspose.CAD v 17.10」のような値をポピュレートします。

この情報を出力ドキュメントから変更または削除するようにAspose.CAD for .NETに指示することはできませんのでご注意ください。
