---
title: Aspose.CADをDockerで実行する方法
type: docs
description: "Linux、Windows Server、そして任意のOSでDockerコンテナ内でAspose.CADを実行します。"
weight: 71
url: /ja/net/showcases/how-to-run-aspose-cad-in-docker/
---

## 前提条件
- Dockerはシステムにインストールされている必要があります。WindowsやMacにDockerをインストールする方法については、「参照」セクションのリンクを参照してください。
- Visual Studio 2022。
- この例では、NET 6 SDKが使用されています。

## ハローワールドアプリケーション

この例では、楕円を描画し、それを画像として保存するシンプルなハローワールドコンソールアプリケーションを作成します。その後、このアプリケーションをDockerでビルドして実行できます。

## コンソールアプリケーションの作成

ハローワールドプログラムを作成するには、以下の手順に従ってください：
1. Dockerがインストールされたら、Linuxコンテナを使用するように設定されていることを確認します（デフォルト）。必要に応じて、Dockerデスクトップメニューから「Linuxコンテナに切り替える」オプションを選択してください。
1. Visual Studioで、NET 6コンソールアプリケーションを作成します。<br>
![NET 6コンソールアプリケーションプロジェクトダイアログ](/_assets/showcases/docker/1.png)<br>
1. NuGetから最新のAspose.CADバージョンをインストールします。<br>
![NuGetのAspose.CAD](/_assets/showcases/docker/2.png)<br>
1. アプリケーションがLinuxで実行されるため、追加のフォントをインストールする必要がある場合があります。ttf-mscorefonts-installerを使用することをお勧めします。
1. 必要な依存関係がすべて追加されたら、楕円を作成し、それを画像として保存するシンプルなプログラムを書きます：<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

「TestOut」フォルダは、出力ドキュメントを保存するための出力フォルダとして指定されています。Dockerでアプリケーションを実行する際には、ホストマシンのフォルダがコンテナ内のこのフォルダにマウントされます。これにより、Dockerコンテナ内のAspose.CADによって生成された出力を簡単に表示できます。

### Dockerfileの設定

次のステップは、Dockerfileを作成し、設定することです。

1. Dockerfileを作成し、アプリケーションのソリューションファイルの隣に配置します。このファイル名は拡張子なし（デフォルト）のままにします。
1. Dockerfileに次のことを指定します：

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

上記は、次の指示を含むシンプルなDockerfileです：

- 使用するSDKイメージ。ここではNET 6イメージです。Dockerはビルドが実行されるときにそれをダウンロードします。SDKのバージョンはタグとして指定されています。
- 次に、フォントをインストールする必要があります。SDKイメージには非常に少ないフォントが含まれているためです。また、ローカルフォントをDockerイメージにコピーして使用できます。
- 次の行で指定された作業ディレクトリ。
- コンテナにすべてをコピーし、アプリケーションを発行し、エントリポイントを指定するためのコマンド。

## Dockerでのアプリケーションのビルドと実行
 
現在、アプリケーションをDockerでビルドして実行できます。お気に入りのコマンドプロンプトを開き、アプリケーションのフォルダにディレクトリを変更（ソリューションファイルとDockerfileが配置されているフォルダ）し、次のコマンドを実行します：

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

このコマンドを初めて実行すると、必要なイメージをダウンロードする必要があるため、時間がかかる場合があります。前のコマンドが完了したら、次のコマンドを実行します：

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
マウント引数に注意してください。前述したように、ホストマシンのフォルダがコンテナのフォルダにマウントされ、アプリケーションの実行結果を見るのが容易になります。Linuxではパスは大文字小文字を区別します。
{{% /alert %}}

## その他の例

DockerでAspose.CADを使用する方法についてのサンプルは、[例](https://github.com/aspose-cad/Aspose.CAD-Documentation)をご覧ください。

## 参考情報

- [WindowsにDocker Desktopをインストールする](https://docs.docker.com/docker-for-windows/install/)
- [MacにDocker Desktopをインストールする](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Linuxコンテナに切り替える](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)オプション
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)に関する追加情報
