---  
title: SVG 描画  
type: docs  
weight: 170  
url: /ja/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/  
---  

## **SVGフォーマットをPDFにエクスポートする**  

Aspose.CAD for Pythonを使用すると、開発者は[SVG](https://docs.fileformat.com/page-description-language/svg/)ファイルを[PDF](https://docs.fileformat.com/pdf/)形式にエクスポートできます。[SVG](https://docs.fileformat.com/page-description-language/svg/)から[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは以下のとおりです：

1. **Image.load**ファクトリーメソッドを使用してSVG描画ファイルを読み込みます。  
1. **CadRasterizationOptions**クラスのオブジェクトを作成し、**page_height**と**page_width**プロパティを設定します。  
1. **PdfOptions**クラスのオブジェクトを作成し、**VectorRasterizationOptions**プロパティを設定します。  
1. **Image.save**を呼び出し、第二パラメータとして**PdfOptions**のオブジェクトを渡します。  

## サンプルコード  

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
