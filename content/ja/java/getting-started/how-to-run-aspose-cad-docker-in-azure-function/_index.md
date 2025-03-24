---
title: Azure FunctionでAspose.CAD Dockerイメージを実行する方法
type: docs
description: "Azure FunctionでAspose.CAD Dockerイメージを実行します。"
weight: 71
url: /ja/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## 前提条件
- システムにDockerがインストールされている必要があります。WindowsまたはMacにDockerをインストールする方法については、「その他参照」セクションのリンクを参照してください。
- IntelliJ IDEA。
- IntelliJ用Azureツールキット。
- Postman。

## Azure Function

この例では、CADファイルを変換し、画像として保存する簡単な変換関数を作成します。アプリケーションは Docker でビルドされ、Azure Function で実行されます。

## Azure Functionの作成

Azure Functionプログラムを作成するには、以下の手順に従ってください。
1. Dockerがインストールされたら、Linuxコンテナ（デフォルト）を使用していることを確認してください。必要に応じて、Docker Desktopメニューから「Linuxコンテナに切り替え」オプションを選択します。
1. IntelliJ IDEAでAzure Functionプロジェクトを作成します。<br>
![Azure Functionプロジェクトの作成](/cad/_assets/java/java-azure/create-function-ide-1.png)<br>
![Azure Functionプロジェクトの作成完了](/cad/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Tools->Azure->サインインし、OAuth 2.0認証を選択します。<br>
![Azureサインイン](/cad/_assets/java/java-azure/sign-in-azure.png)<br>
1. ブラウザでログインします。
1. サブスクリプション名を選択します。
1. Dockerサポートを追加します。<br>
![Dockerサポートの追加](/cad/_assets/java/java-azure/add-docker-support.png)<br>
1. <a href="#configuring-a-dockerfile">Dockerfileの構成</a>セクションに従ってDockerFileを編集します。
1. pom.xmlにリポジトリaspose.cadのブロックを追加します。
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. 必要な依存関係がすべて追加されたら、楕円を作成し、画像として保存する簡単なプログラムを書きます：<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * この関数はエンドポイント"/api/HttpExample"でリスニングします。bashで"curl"コマンドを使用して呼び出す2つの方法：
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTPトリガーがリクエストを処理しました。");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### Dockerfileの構成

次のステップは、ルートプロジェクトフォルダー内にDockerfileを作成して構成することです。

1. Dockerfileに次の内容を指定します：
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

上記は、次の指示を含むシンプルなDockerfileです：

- 使用するSDKイメージ。ビルドが実行されるときにDockerがダウンロードします。SDKのバージョンはタグとして指定されます。
- 次の行で指定される作業ディレクトリ。
- すべてをコンテナにコピーし、アプリケーションを公開し、エントリポイントを指定するコマンド。

## Docker Hub
1. Docker Hubにログインします。
1. 公開リポジトリを作成します。

## Dockerでアプリケーションをビルドして実行する
 
アプリケーションはDockerでビルドして実行できます。お気に入りのコマンドプロンプトを開き、アプリケーションのフォルダー（ソリューションファイルとDockerfileが配置されているフォルダー）にディレクトリを変更し、以下のコマンドを実行します：

1. コンソールでのdockerfileビルドコマンド
{{< highlight plain >}}
//例
docker build -t <ユーザー名>/<リポジトリ名> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. このコマンドを初めて実行するときは、Dockerが必要なイメージをダウンロードするため、少し時間がかかる場合があります。前のコマンドが完了したら、以下のコマンドを実行してイメージをDocker Hubにプッシュします。
{{< highlight plain >}}
//例
docker push <ユーザー名>/<リポジトリ名>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. IDEでdockerfileを実行し、Docker Hubにプッシュします。<br>
![IDEでのDockerの実行](/cad/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Docker Hubリポジトリのようにイメージ名を入力します。<br>
![IDEでのDockerの実行next](/cad/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. 終了までお待ちください。

## Azure

1. Azureにログインします。
1. Azureサービスを選択します。
1. Function Appを選択して関数を作成します。<br>
![Azure関数ボタンを作成](/cad/_assets/java/java-azure/create-function-azure.png)<br>
1. 下の画像のように基本設定を繰り返します。<br>
![Azure関数設定を作成](/cad/_assets/java/java-azure/create-function-settings.png)<br>
1. 'レビュー + 作成'をクリックし、次に作成します。
1. デプロイメントが完了するまで待ちます。
1. 'リソースに移動'ボタンをクリックします。<br>
![リソースボタン](/cad/_assets/java/java-azure/go-to-resource.png)<br>
1. aspose-cad-docker-example関数を停止します。<br>
![コンテナを停止](/cad/_assets/java/java-azure/stop-container.png)<br>
1. デプロイメントセンターメニューに移動し、適切な設定を行います。<br>
![デプロイメントセンター](/cad/_assets/java/java-azure/deployment-center.png)<br>
1. 設定を保存します。
1. デプロイメントセンター設定からWebhook URLをコピーします。<br>
![Webhook URL](/cad/_assets/java/java-azure/webhook-url.png)<br>
1. Docker Hubに移動し、リポジトリを選択してWebhookを選択します。
1. Azureからの'Webhook URL'をDocker HubのWebhook URLに貼り付け、名前を設定します。<br>
![DockerのWebhook設定](/cad/_assets/java/java-azure/webhook.png)<br>
1. 作成ボタンをクリックします。
1. Azure関数の概要に戻り、コンテナを起動します。<br>
![概要メニュー](/cad/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
関数の起動には数分かかることがあります。
{{% /alert %}}

## 実行例

1. Postmanの設定。<br>
![概要メニュー](/cad/_assets/java/java-azure/postman-settings.png)<br>
1. 任意のDXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVGファイルを選択します。
1. 送信ボタンをクリックします。
1. 結果を保存します
![レスポンスを保存](/cad/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
応答が成功した場合、「ファイルに保存」をクリックすると、png形式に変換されたファイルが受け取れます。
{{% /alert %}}

## さらに例

DockerでAspose.CADを使用する方法のさらなるサンプルについては、[例](https://github.com/aspose-cad/Aspose.CAD-Documentation)をご覧ください。


## その他参照

- [WindowsにDocker Desktopをインストール](https://docs.docker.com/docker-for-windows/install/)
- [MacにDocker Desktopをインストール](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Linuxコンテナに切り替え](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)オプション
