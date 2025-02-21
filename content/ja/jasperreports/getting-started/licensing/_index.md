---
title: ライセンス
type: docs
weight: 40
url: /ja/jasperreports/getting-started/licensing/
---
## **setLicenseを呼び出す**
ライセンスを適用するには：

ライセンスファイルをディスク上のフォルダーに保存します。たとえばC:\Lic\Aspose.CAD.JasperReport.licです。
License.setLicense(filename)メソッドを呼び出し、ファイル名を引数として渡します。このステートメントが呼び出されると、ライセンスが設定され、評価メッセージが画像の上に表示されなくなります。
以下のコードスニペットは、Aspose.CAD for JasperReportsのライセンスを設定します。

{{< highlight java >}}

// ライセンスを設定する

License lic = new License();

lic.setLicense("C:\\Lic\\Aspose.CAD.JasperReports.lic");

{{< /highlight >}}

{{% alert color="primary" %}}

setLicense()メソッドは、プロセスまたはアプリケーションごとに1回だけ呼び出す必要があります。

{{% /alert %}}

## **applicationContext.xmlでライセンスエクスポーターパラメーターを設定する**
{{% alert color="primary" %}}
この方法はJasperServerでの使用に適用されます。
{{% /alert %}}
1. ライセンスをコンピューターにダウンロードし、JasperServerのインストールディレクトリを表す\apache-tomcat\webapps\jasperserver\WEB-INFフォルダーにコピーします。
2. \apache-tomcat\webapps\jasperserver\WEB-INF\applicationContext.xmlファイルを見つけて、以下の行を追加します：
{{< highlight xml >}}
<bean id="jpgExportParameters" class="com.aspose.cad.jasperreports.jpg.ASJpegExportParametersBean">
    <property name="license" value="C:\jasperserver-7.6\apache-tomcat\webapps\jasperserver\WEB-INFAspose.CAD.JasperReports.lic"/>
</bean>
{{< /highlight >}}
