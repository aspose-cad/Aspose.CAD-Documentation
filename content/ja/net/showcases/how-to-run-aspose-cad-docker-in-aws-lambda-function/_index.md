---
title: AWS Lambda 関数で Aspose.CAD Docker イメージを実行する方法
type: docs
description: "AWS Lambda 関数で Aspose.CAD Docker イメージを実行します。"
weight: 74
url: /ja/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## 前提条件
- システムに Docker をインストールする必要があります。Windows または Mac に Docker をインストールする方法については、「関連リンク」セクションのリンクを参照してください。
- Visual Studio 2022。
- Visual Studio 2022 用 AWS Toolkit。
- サンプルでは .NET 6 SDK が使用されます。
- Postman

## AWS Lambda 関数

Lambda は、サーバーをプロビジョニングまたは管理することなくコードを実行できるコンピューティングサービスです。Lambda は、高可用性のコンピューティングインフラストラクチャ上でコードを実行し、サーバーやオペレーティングシステムのメンテナンス、キャパシティプロビジョニング、自動スケーリング、ロギングなど、コンピューティングリソースのすべての管理を行います。Lambdaを使用すると、ほぼすべての種類のアプリケーションやバックエンドサービスのコードを実行できます。

## AWS Lambda 関数の作成

{{% alert color="primary" %}} 
AWS Lambda 関数およびイメージを Amazon Elastic Container Registry で作成するための十分な権限があることを確認してください。
{{% /alert %}}

AWS Lambda 関数プログラムを作成するには、以下の手順に従います：
1. AWS Lambda プロジェクトを作成します。<br>
![AWS 関数作成ボタン](/cad/_assets/showcases/aws/create-project.png)<br>
1. .NET 6 (コンテナイメージ) を選択し、「終了」ボタンをクリックします。<br>
![コンテナ関数作成ボタン](/cad/_assets/showcases/aws/create-container.png)<br>
1. Visual Studio で AWS Explorer を開きます (表示 -> AWS Explorer)。
1. AWS Explorer に AWS 資格情報プロファイルを追加します。<br>
![資格情報プロファイル](/cad/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. アクセスキーIDとシークレットアクセスキーを入力します。これらのキーはセキュリティ資格情報で取得するか、管理者に連絡して承認用のCSVファイルを取得してください。<br>
![アカウントプロファイル設定](/cad/_assets/showcases/aws/account-profile.png)<br>
1. NuGet から最新のライブラリをインストールします。<br>
![NuGet マネージャー](/cad/_assets/showcases/aws/nuget-manager.png)<br>
1. CAD イメージを PDF ファイルに変換するコード例。
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. <a href="#configuring-a-dockerfile">Dockerfile の設定</a> セクションで示すように DockerFile を編集します。
1. Docker Desktop を起動します。
1. AWS Lambda に公開します。<br>
![AWS Lambda 公開](/cad/_assets/showcases/aws/publish-aws.png)<br>
1. アップロード設定を編集します。<br>
![AWS Lambda アップロード](/cad/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. 「アップロード」ボタンをクリックします。<br>
![AWS Lambda 最後のアップロード](/cad/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. AWS に移動し、Lambda を選択します。<br>
![AWS Lambda](/cad/_assets/showcases/aws/select-aws-lambda.png)<br>
1. 新しい関数を選択し、URL 関数を作成します。<br>
![構成 URL 関数](/cad/_assets/showcases/aws/create-function-url.png)<br>
1. 認証タイプを選択する
- AWS_IAM - 認証された IAM ユーザーおよびロールのみが関数の URL にリクエストを送信できます。
- NONE - Lambda は関数の URL に対するリクエストで IAM 認証を行いません。独自の認証ロジックを関数に実装しない限り、URL エンドポイントは公開されます。

### Dockerfile の設定

次のステップは、プロジェクト内の Dockerfile を編集して設定することです。

1. Dockerfile で次のことを指定します：

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

上記は、以下の指示を含むシンプルな Dockerfile です：

- 使用する SDK イメージ。ここでは .NET 6 イメージです。ビルドが実行されたときに Docker がダウンロードします。SDK のバージョンはタグとして指定されます。
- その後、SDK イメージには非常に少ないフォントしか含まれていないため、フォントをインストールする必要があるかもしれません。また、Docker イメージにコピーされたローカルフォントを使用することもできます。
- 次の行で指定された作業ディレクトリ。
- コンテナにすべてをコピーし、アプリケーションを公開し、エントリーポイントを指定するためのコマンド。

## 実行例

1. Postman 設定。<br>
![概要メニュー](/cad/_assets/showcases/aws/postman-settings.png)<br>
1. 任意の DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG ファイルを選択します。
1. 送信ボタンをクリックします。

{{% alert color="primary" %}} 
レスポンスが成功した場合、「ファイルに保存」をクリックすると、PDF 形式で変換されたファイルが受け取れます。
{{% /alert %}}

## さらなる例

Docker 内で Aspose.CAD を使用する方法のさらなるサンプルについては、[examples](https://github.com/aspose-cad/Aspose.CAD-Documentation)をご覧ください。

## 関連リンク。

- [Visual Studio 2022 用 AWS Toolkit のインストール](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows に Docker Desktop をインストール](https://docs.docker.com/docker-for-windows/install/)
- [Mac に Docker Desktop をインストール](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022、.NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linux コンテナに切り替える](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) オプション
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) に関する追加情報
