---
title: Google Cloud で Aspose.CAD Docker イメージを実行する方法
type: docs
description: "Google Cloud で Aspose.CAD Docker イメージを実行します。"
weight: 75
url: /ja/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## 前提条件

- システムに Docker がインストールされている必要があります。Windows または Mac に Docker をインストールする方法については、「参照」セクションのリンクを参照してください。
- Visual Studio 2022。
- Google CLI。
- この例では .NET Core 3.1 SDK が使用されます。
- Postman

## Google Cloud Run 機能

Cloud Run は、マシンのプロビジョニング、クラスターの構成、オートスケーリングを心配することなく、サーバーレス HTTP コンテナを展開およびスケーリングするための完全に管理されたコンピュート環境です。

- ベンダーロックインなし - Cloud Run は標準 OCI コンテナを取り込み、標準 Knative Serving API を実装しているため、アプリケーションをオンプレミスや他のクラウド環境に簡単に移行できます。
- 高速オートスケーリング - Cloud Run に展開されたマイクロサービスは、入ってくるリクエストの数に基づいて自動的にスケーリングされ、完全な Kubernetes クラスターを構成または管理する必要がありません。Cloud Run はゼロにスケールします。つまり、リクエストがない場合はリソースを使用しません。
- トラフィックの分割 - Cloud Run を使用すると、複数のリビジョン間でトラフィックを分割できるため、カナリアデプロイメントやブルー/グリーンデプロイメントなどの段階的ロールアウトを実行できます。
- カスタムドメイン - Cloud Run でカスタムドメインマッピングを設定でき、ドメインの TLS 証明書をプロビジョニングします。
- 自動冗長性 - Cloud Run は自動冗長性を提供するため、高可用性のために複数のインスタンスを作成することを心配する必要はありません。

Cloud Run と Cloud Functions はどちらも Google Cloud のサーバーレスインフラストラクチャ上で実行される完全に管理されたサービスであり、自動スケーリングおよび HTTP リクエストまたはイベントの処理を行います。ただし、いくつかの重要な違いがあります。

- Cloud Functions は、限られたプログラミング言語で書かれたコード（関数）スニペットを展開できるのに対し、Cloud Run はお好きなプログラミング言語を使用してコンテナイメージを展開できます。
- Cloud Run は、アプリケーションからの任意のツールまたはシステムライブラリの使用もサポートしていますが、Cloud Functions ではカスタム実行可能ファイルを使用できません。
- Cloud Run は、最大 60 分のリクエストタイムアウトの期間を提供しますが、Cloud Functions のリクエストタイムアウトは最大 9 分に設定できます。
- Cloud Functions は、各関数インスタンスに同時に 1 つのリクエストを送信しますが、デフォルトでは Cloud Run は各コンテナインスタンス上で複数の同時リクエストを送信するように構成されています。これは、大量のリクエストを予想している場合の待機時間を改善し、コストを削減するのに役立ちます。

## Google Cloud Function プロジェクトの作成

{{% alert color="primary" %}} 
Google Cloud Run 関数と Artifact Registry レポジトリ内に画像を作成するための十分な権限があることを確認してください。
{{% /alert %}}

Google Cloud Function プログラムを作成するには、以下の手順に従ってください。

1. .NET Core SDK 3.1 をインストールします。
1. テンプレートパッケージをインストールします：
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. 次に、プロジェクト用のディレクトリを作成し、dotnet new を使用して新しい HTTP 関数を作成します：
{{< highlight plain >}}
mkdir AsposeFunctions //フォルダーを作成
cd AsposeFunctions //フォルダーに移動
dotnet new gcf-http //http トリガーのある Google Cloud Function プロジェクトを作成します
{{< /highlight >}}
{{% alert color="primary" %}} 
これにより、現在のディレクトリに AsposeFunctions.csproj と Function.cs が作成されます。Function.cs を開いてコードを確認し、必要に応じてカスタムメッセージを提供します。
{{% /alert %}}
1. csproj ファイル（AsposeFunctions.csproj）のコード例。
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. CAD イメージを PNG ファイルに変換するためのコード例（Function.cs）。
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// あなたの関数のロジックはここにあります。
        /// </summary>
        /// <param name="context">リクエストとレスポンスを含む HTTP コンテキスト。</param>
        /// <returns>非同期操作を表すタスク。</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //フォームファイル
                var file = context.Request.Body; //バイナリデータ
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. 以下のように、ローカルで関数をビルドします：
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. サーバーが起動したら、http://localhost:8080 にアクセスして関数を呼び出します。コンソールで Ctrl-C を押してサーバーを停止します。

## Docker イメージを Google Cloud にデプロイする

1. Google Cloud にログインします。
1. プロジェクトが存在しない場合は作成します。
1. 「Artifact Registry」に移動し、リポジトリを作成します。<br>
![アーティファクトリポジトリの作成](/cad/_assets/showcases/google/create-artifact-repository.png)<br>
1. Artifact Registry で新しいリポジトリを選択します。
![アーティファクトリポジトリの選択](/cad/_assets/showcases/google/select-artifact.png)<br>
1. 「SETUP INSTRUCTION」をクリックし、「Configure Docker」コマンドをコピーします。<br>
![SETUP INSTRUCTION](/cad/_assets/showcases/google/setup-instruction.png)<br>
1. Docker の構成ファイルに Docker credHelper エントリを追加するか、存在しない場合はファイルを作成します。
{{< highlight plain >}}
//例
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. プロジェクトのルートディレクトリに Dockerfile を作成し、<a href="#configuring-a-dockerfile">Dockerfile の設定</a> セクションに従って DockerFile を編集します。
1. Docker Desktop を起動します。
1. クラウドリポジトリのパスで Docker イメージをビルドします。
{{< highlight plain >}}
//例
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Google Cloud Artifact Registry にイメージをプッシュします
{{< highlight plain >}}
//例
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Google Cloud Run サービスの作成 

1. Cloud Run に移動します。
1. Cloud Run サービスを作成します。<br>
![Cloud Run サービスの作成](/cad/_assets/showcases/google/create-cloud-run-service.png)<br>
1. コンテナイメージ URL フィールドで、「ARTIFACT REGISTRY」からコンテナを選択します。<br>
![コンテナイメージ URL](/cad/_assets/showcases/google/container-url.png)<br>
1. その他の設定を以下のように確認します。<br>
![サービス設定](/cad/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. デプロイが完了するまで待ちます。
1. 変換アプリケーションで使用するサービス URL。<br>
![サービスの URL](/cad/_assets/showcases/google/url-service.png)<br>

### Dockerfile の設定

次のステップは、プロジェクト内の Dockerfile を編集して設定することです。

1. Dockerfile で、次のように指定します。

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

上記は、次の指示を含むシンプルな Dockerfile です。

- 使用される SDK イメージ。ここでは .NET Core 3.1 イメージです。ビルドが実行される際に Docker によってダウンロードされます。SDK のバージョンはタグとして指定されます。
- 次に、SDK イメージには非常に少ないフォントが含まれているため、フォントをインストールする必要があります。また、Docker イメージにコピーされたローカルフォントを使用できます。
- 次の行で指定された作業ディレクトリ。
- コンテナにすべてをコピーし、アプリケーションを発行し、エントリポイントを指定するためのコマンド。

## 実行例

1. Postman 設定。<br>
![概要メニュー](/cad/_assets/showcases/google/postman-settings.png)<br>
1. 任意の DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG ファイルを選択します。
1. 送信ボタンをクリックします。

{{% alert color="primary" %}} 
応答が成功した場合は、「ファイルに保存」をクリックすると、png 形式の変換されたファイルを受け取ります。
{{% /alert %}}

## さらなる例

Docker で Aspose.CAD を使用する方法のサンプルについては、[例](https://github.com/aspose-cad/Aspose.CAD-Documentation)をご覧ください。

## 参照

- [Windows に Docker Desktop をインストールする](https://docs.docker.com/docker-for-windows/install/)
- [Mac に Docker Desktop をインストールする](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Linux コンテナに切り替える](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)オプション
- [.NET Core SDK に関する追加情報](https://hub.docker.com/_/microsoft-dotnet-sdk)
