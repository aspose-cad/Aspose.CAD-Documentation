---
title: エクスポートおよび読み込み中のコールバックエラー
type: docs
weight: 40
url: /ja/net/developer-guide/callback-errors-during-export-and-loading/
---

## **エクスポートおよび読み込み中のコールバックエラーのレビュー**

エクスポートまたは描画の読み込み中に、ファイルの構造に関連するエラーに直面する可能性があります 
（例: 現在はファイル内のセクションが必要ですが、以前は必要ありませんでした）。 
その中には重大なものもあり、その場合は例外がスローされますが、内部でそれらの一部を無視し、コールバックメッセージを使用して通知することもできます。
いずれにせよ、これらすべてのメッセージは注意を要します。なぜなら、それらは例えばエクスポート結果における欠落したエンティティやその他の影響を説明するかもしれないからです。


### **エクスポート中のエラー**

[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) には RenderResult フィールドがあり、export 中にエラーがあったかどうかを取得するための IsRenderComplete が含まれています。そして、それらに関する情報を出力します：

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **読み込み中のエラー**

エクスポートプロセスが開始される前に、図面に関する問題が観察されることがあります。 
[**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) プロパティは 
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) オブジェクト内でそれらのメッセージを格納するために使用されます。
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) プロパティは、 
読み込みエラーが発生した場合に例外をスローする必要があるかどうかを判断するのに役立ちます。

以下は Errors プロパティの使用例です：

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
