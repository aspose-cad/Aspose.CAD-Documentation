---
title: ライセンス
type: docs
weight: 50
url: /ja/java/getting-started/licensing/
---

{{% alert color="primary" %}}

**Aspose.CAD** for Java の評価版を[ダウンロードページ](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/)からダウンロードできます。評価版は製品のライセンス版と全く同じ機能を提供します。さらに、評価版はライセンスを購入し、ライセンスを適用するための数行のコードを追加するだけでライセンス版になります。

**Aspose.CAD**の評価に満足したら、Asposeのウェブサイトで[ライセンスを購入](https://purchase.aspose.com/buy)できます。提供されるさまざまなサブスクリプションタイプに慣れておきましょう。質問がある場合は、Asposeの営業チームに遠慮なくお問い合わせください。

すべてのAsposeライセンスには、新しいバージョンや修正が出る間に無料でアップグレードできる1年間のサブスクリプションが付いています。技術サポートは無制限で無料で提供され、ライセンスユーザーと評価ユーザーの両方に提供されます。

{{% /alert %}}

評価版の制限なしに**Aspose.CAD**をテストしたい場合は、30日間の仮ライセンスをリクエストしてください。詳細については[一時ライセンスの取得方法?](https://purchase.aspose.com/temporary-license)を参照してください。

## **ライセンスの設定**

ライセンスは、製品名、ライセンスが付与された開発者の数、サブスクリプションの期限などの詳細を含むプレーンテキストのXMLファイルです。このファイルはデジタル署名されているため、ファイルを変更しないでください。ファイルに余分な改行を誤って追加するだけでも無効になります。

AutoCADファイルで操作を行う前にライセンスを設定する必要があります。アプリケーションまたはプロセスごとに一度だけライセンスを設定する必要があります。

ライセンスは次の場所からストリームまたはファイルで読み込むことができます。

1. 明示的なパス。
1. Aspose.CAD.jarを含むフォルダー。

License.setLicense()メソッドを使用してコンポーネントにライセンスを設定します。ライセンスファイルをAspose.CAD.jarと同じフォルダーに置き、パスなしでファイル名だけを指定するのが最も簡単な方法です。以下の例のようにします。

### **例 1**

この例では、**Aspose.CAD**はアプリケーションのJARを含むフォルダーでライセンスファイルを探そうとします。

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **例 2**

ストリームからライセンスを初期化します。

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **ライセンスの検証**

ライセンスが正しく設定されているかどうかを検証することができます。Licenseクラスには、ライセンスが正しく設定されている場合にtrueを返すisLicensedフィールドがあります。

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("ライセンスが設定されました！");

}

{{< /highlight >}}
