---
title: メーター方式のライセンス
type: docs
weight: 60
url: /ja/java/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CADは、開発者がメーター方式のキーを適用できるようにします。これは新しいライセンス機構です。この新しいライセンス機構は、既存のライセンス方法と併用されます。API機能の使用に基づいて請求されたい顧客は、メーター方式のライセンスを使用することができます。詳細については、[メーター方式のライセンス FAQ](https://purchase.aspose.com/faqs/licensing/metered) セクションをご覧ください。

{{% /alert %}} 
## **メーター方式のライセンス**
メータークラスを使用するための簡単な手順は次のとおりです。

1. メータークラスのインスタンスを作成します。
1. setMeteredKey メソッドに公開鍵と秘密鍵を渡します。
1. 処理を実行します（タスクを実行）。
1. メータークラスのメソッド getConsumptionQuantity を呼び出します。
1. これにより、これまでに消費したAPIリクエストの量が返されます。

以下は、メーター方式の公開鍵と秘密鍵を設定する方法を示すサンプルコードです：

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
