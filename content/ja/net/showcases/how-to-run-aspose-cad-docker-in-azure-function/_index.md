---
title: Azure FunctionsでAspose.CAD Dockerイメージを実行する方法
type: docs
description: "Azure FunctionsでAspose.CAD Dockerイメージを実行します。"
weight: 73
url: /ja/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## 必要条件
- Dockerはシステムにインストールされている必要があります。WindowsまたはMacにDockerをインストールする方法については、「参照」セクションのリンクを参照してください。
- Visual Studio 2022。
- 例では、.NET 6 SDKが使用されます。
- Postman

## Azure Function

この例では、CADファイルを変換して画像として保存するシンプルな変換関数を作成します。その後、アプリケーションをDockerでビルドし、Azure Functionで実行します。

## Azure Functionの作成

Azure Functionプログラムを作成するには、以下の手順に従ってください：
1. Dockerがインストールされたら、Linuxコンテナを使用していることを確認してください（デフォルト）。必要に応じて、Docker Desktopメニューから「Linuxコンテナに切り替え」オプションを選択します。
1. Visual Studioで、.NET 6 Azure Functionを作成します。<br>
![NET 6 Azure Functionプロジェクトダイアログ](/_assets/showcases/azure/Create-project.png)<br>
1. 追加情報。<br>
![NET 6 Azure Functionプロジェクトダイアログ](/_assets/showcases/azure/Additional-information.png)<br>
1. NuGetから最新のAspose.CADバージョンをインストールします。<br>
![Aspose.CAD on NuGet](/_assets/showcases/azure/NuGet.png)<br>
1. アプリケーションがLinuxで実行されるため、追加のフォントをインストールする必要があります。ttf-mscorefonts-installerを使用することをお勧めします。
1. 必要な依存関係がすべて追加されたら、楕円を作成し、画像として保存するシンプルなプログラムを書きます：<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTPトリガー関数がリクエストを処理しました。");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### Dockerfileの設定

次のステップは、プロジェクトルートフォルダーにDockerfileを作成して構成することです。

1. Dockerfileを作成し、アプリケーションのソリューションファイルの隣に置きます。このファイル名は拡張子なしで保持します（デフォルト）。
![プロジェクトルートフォルダー](/_assets/showcases/azure/root-folder.png)<br>
1. Dockerfileに指定します：


{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

 上記はシンプルなDockerfileで、以下の命令が含まれています：

- 使用するSDKイメージ。ここでは.NET 6イメージです。Dockerはビルド時にこれをダウンロードします。SDKのバージョンはタグとして指定されます。
- その後、フォントをインストールする必要があります。SDKイメージには非常に少ないフォントが含まれているため、ローカルフォントをDockerイメージにコピーして使用することもできます。
- 次の行で指定された作業ディレクトリ。
- コンテナにすべてをコピーし、アプリケーションを公開し、エントリーポイントを指定するコマンド。

## Docker Hub
1. Docker Hubにログインします。
1. パブリックリポジトリを作成します。

## Dockerでアプリケーションをビルドして実行する

アプリケーションはDockerでビルドおよび実行できます。お気に入りのコマンドプロンプトを開き、アプリケーションのフォルダー（ソリューションファイルとDockerfileが置かれているフォルダー）にディレクトリを変更し、次のコマンドを実行します：

{{< highlight plain >}}
//例
docker build -t <ユーザー名>/<リポジトリ名> .

docker build -t user/asposefunction .
{{< /highlight >}}

このコマンドを初めて実行する際、Dockerが必要なイメージをダウンロードする必要があるため、時間がかかる場合があります。前のコマンドが完了した後、次のコマンドを実行してイメージをDocker Hubにプッシュします：

{{< highlight plain >}}
//例
docker push <ユーザー名>/<リポジトリ名>:タグ名

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Azureにログインします。
1. Azureサービスを選択します。
1. Function Appを選択し、関数を作成します。<br>
![Azure関数作成ボタン](/_assets/showcases/azure/create-function.png)<br>
1. 以下の画像と同様に基本設定を繰り返します。<br>
![Azure関数設定](/_assets/showcases/azure/create-function-setting.png)<br>
1. 'レビューと作成'をクリックし、次に'作成'をクリックします。
1. デプロイが完了するのを待ちます。
1. 'リソースに移動'ボタンをクリックします。<br>
![リソースボタン](/_assets/showcases/azure/go-to-resource.png)<br>
1. aspose-cad-docker-example関数を停止します。<br>
![コンテナを停止](/_assets/showcases/azure/stop-container.png)<br>
1. デプロイメントセンターメニューに移動し、適切な設定を行います。<br>
![デプロイメントセンター](/_assets/showcases/azure/deployment-center.png)<br>
1. 設定を保存します。
1. デプロイメントセンター設定からWebhook URLをコピーします。<br>
![Webhook URL](/_assets/showcases/azure/webhook-url.png)<br>
1. Docker Hubに移動し、リポジトリを選択し、Webhooksを選択します。
1. Azureからの'Webhook URL'をDocker HubのWebhook URLに貼り付けて名前を設定します。<br>
![DockerのWebhook設定](/_assets/showcases/azure/webhook.png)<br>
1. 作成ボタンをクリックします。
1. Azure Functionの概要に戻り、コンテナを起動します。<br>
![概要メニュー](/_assets/showcases/azure/overview.png)<br>

## 実行例

1. Postman設定。<br>
![概要メニュー](/_assets/showcases/azure/postman-settings.png)<br>
1. 任意のDXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVGファイルを選択します。
1. 送信ボタンをクリックします。

{{% alert color="primary" %}} 
応答が成功すれば、ファイルに保存をクリックすると、png形式で変換されたファイルを受け取ることができます。
{{% /alert %}}

## その他の例

Docker内でAspose.CADを使用する方法のサンプルについては、[例](https://github.com/aspose-cad/Aspose.CAD-Documentation)を参照してください。


## 参照

- [WindowsにDocker Desktopをインストール](https://docs.docker.com/docker-for-windows/install/)
- [MacにDocker Desktopをインストール](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022、.NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linuxコンテナに切り替える](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)オプション
- [.NET Core SDKに関する追加情報](https://hub.docker.com/_/microsoft-dotnet-sdk)
