---
title: メーター制ライセンス
type: docs
weight: 40
url: /ja/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD は、開発者がメーター制のキーを適用できるようにします。これは新しいライセンスメカニズムです。新しいライセンスメカニズムは、既存のライセンス方法と併用されます。API機能の使用量に基づいて請求されたい顧客は、メーター制ライセンスを使用できます。詳細については、[メーター制ライセンスFAQ](https://purchase.aspose.com/faqs/licensing/metered) セクションを参照してください。

{{% /alert %}} 
## **メーター制ライセンス**
メータークラスを使用するための簡単な手順は以下の通りです。

1. メータークラスのインスタンスを作成します。
1. 公開鍵と秘密鍵を SetMeteredKey メソッドに渡します。
1. 処理を行います（タスクを実行します）。
1. メータークラスの GetConsumptionQuantity メソッドを呼び出します。
1. それは、これまでに消費したAPIリクエストの量/数量を返します。

次に、メーター制公開鍵と秘密鍵を設定する方法を示すサンプルコードがあります。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
