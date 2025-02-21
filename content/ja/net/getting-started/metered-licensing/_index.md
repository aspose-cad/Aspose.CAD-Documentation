---
title: メーター付きライセンス
type: docs
weight: 60
url: /ja/net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD は、開発者がメーター付きキーを適用できるようにします。これは新しいライセンスメカニズムです。新しいライセンスメカニズムは、既存のライセンス方法と併用されます。API機能の使用に基づいて請求されることを希望する顧客は、メーター付きライセンスを使用できます。詳細については、[メーター付きライセンス FAQ](https://purchase.aspose.com/faqs/licensing/metered) セクションを参照してください。

{{% /alert %}} 
## **メーター付きライセンス**
メータークラスを使用するための簡単な手順は次のとおりです。

1. メータークラスのインスタンスを作成します。
1. 公開キーと秘密キーを SetMeteredKey メソッドに渡します。
1. 処理を行います（タスクを実行します）。
1. メータークラスの GetConsumptionQuantity メソッドを呼び出します。
1. これまでに消費した API リクエストの量/数量が返されます。

以下は、メーター付きの公開鍵と秘密鍵を設定する方法を示すサンプルコードです。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
