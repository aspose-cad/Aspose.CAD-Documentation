---
title: SHXフォントのエクスポート
type: docs
weight: 40
url: /ja/python-net/developer-guide/export-shx-fonts/
---

## **DXF/DWG図面用のSHXフォントのエクスポート**

一部の図面には、フォントのシンボルを形状の形で保存する特別なSHX形式のフォントが含まれている場合があります。この形式では、図面で使用される各フォントに対して追加のロード手順が必要です。Apose.CADは、SHXで書かれたテキストを含む図面をエクスポートでき、これを行うためのさまざまなオプションがあります。最も簡単な方法は、**CadRasterizationOptions**オブジェクトの**ShxFonts**プロパティを使用することです。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
