---
title: ライセンス
type: docs
weight: 40
url: /ja/python-net/getting-started/licensing/
---
## **Call setLicense**
ライセンスを適用するには:

ライセンスファイルをディスクのフォルダーに保存します。例えば C:\Lic\Aspose.CAD.Python.lic。
License.set_license(filename) メソッドを呼び出し、ファイル名を引数として渡します。このステートメントが呼び出されると、ライセンスが設定され、評価メッセージが画像の上部に表示されなくなります。
以下のコードスニペットは、Aspose.CAD for Python のライセンスを設定します。

{{< highlight java >}}

// ライセンスを設定

lic = License();

lic.set_license("C:\Lic\Aspose.CAD.Pythons.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

set_license() メソッドは、プロセスまたはアプリケーションごとに一度だけ呼び出す必要があります。

{{% /alert %}}

## **applicationContext.xmlのライセンスエクスポーターパラメータを設定する**
{{% alert color="primary" %}}
このメソッドは、JasperServerでの使用に適用されます。
{{% /alert %}}
1. ライセンスをコンピュータにダウンロードし、\apache-tomcat\webapps\jasperserver\WEB-INF フォルダーにコピーします。ここで、「」はJasperServerのインストールディレクトリを表します。
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xml ファイルを見つけ、以下の行を追加します:
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.pythons.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.Pythons.lic"/>
</bean>
{{< /highlight >}}
