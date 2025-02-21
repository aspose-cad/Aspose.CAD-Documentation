---
title: ライセンス
type: docs
weight: 50
url: /ja/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Aspose.CAD for .NETの評価に満足したら、Asposeウェブサイトでライセンスを購入してください: [購入ポータル](https://purchase.aspose.com/buy)。利用可能な異なるライセンスタイプに慣れてください。質問がある場合は、[Aspose販売チームにお問い合わせ](https://about.aspose.com/contact)ください。喜んでお手伝いします。

すべてのAsposeライセンスには、期間中に発生する新しいバージョンや修正への無料アップグレードのための1年間のサブスクリプションが含まれています。私たちは、ライセンスを持つユーザーと評価ユーザーの両方に対して、無料で無制限の技術サポートを提供します。

ライセンスは、製品名、ライセンス開発者の数、サブスクリプションの有効期限などの詳細を含むプレーンテキストのXMLファイルです。ファイルはデジタル署名されているため、ファイルを変更しないでください: たとえば、ファイルに余分な改行を追加すると無効になります。

{{% /alert %}}

## **ライセンスの適用時期**

次の簡単なルールに従ってください:

- ライセンスはアプリケーションドメインごとに1回設定する必要があります。
- Aspose.CADの他のクラスを使用する前にライセンスを設定する必要があります。
- SetLicenseを複数回呼び出すことは問題ありませんが、プロセッサの時間を無駄にします。
- Windows Formsまたはコンソールアプリケーションを開発している場合は、Aspose.CADのクラスを使用する前に、スタートアップコードでSetLicenseを呼び出してください。
- ASP.NETアプリケーションを開発している場合は、Application_Start保護されたメソッド内でGlobal.asax.cs（Global.asax.vb）ファイルからSetLicenseを呼び出します。アプリケーションが開始されるときに1回呼び出されます。
- Page_Loadメソッド内からSetLicenseを呼び出さないでください。これは、ライセンスがウェブページが読み込まれるたびに読み込まれることを意味します。
- クラスライブラリを開発している場合は、Aspose.CADを使用するクラスの静的コンストラクターからSetLicenseを呼び出します。静的コンストラクターはクラスのインスタンスが作成される前に実行され、Aspose.CADライセンスが正しく設定されることを確認します。

## **ファイルまたはストリームオブジェクトを使用してライセンスを適用する**

コンポーネントにライセンスを付与するには、**[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)**メソッドを使用してください。ライセンスを設定する最も簡単な方法は、ライセンスファイルをAspose.CAD.dllと同じフォルダーに置き、パスなしでファイル名を指定することです。以下に示します。

### **ファイルからライセンスを読み込む**

このコードスニペットは、ファイルまたは埋め込みリソースに格納されたライセンスを初期化します。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **ストリームオブジェクトからライセンスを読み込む**

このコードスニペットは、ストリームからライセンスを初期化します。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
