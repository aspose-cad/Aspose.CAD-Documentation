---
title: 例を実行する方法
type: docs
weight: 70
url: /ja/net/showcases/how-to-run-the-examples/
---

## **ソフトウェア要件**

例をダウンロードして実行する前に、以下の要件を満たしていることを確認してください。

1. Visual Studio 2010 以上
1. Visual Studio に NuGet パッケージマネージャーがインストールされていること。最新の NuGet API バージョンが Visual Studio にインストールされていることを確認してください。NuGet パッケージマネージャーのインストール方法の詳細については、https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools を確認してください。
1. Tools->Options->NuGet Package Manager->Package Sources に移動し、**nuget.org** のオプションがチェックされていることを確認してください。
1. サンプルプロジェクトは NuGet 自動パッケージ復元機能を使用しているため、アクティブなインターネット接続が必要です。サンプルを実行するマシンにアクティブなインターネット接続がない場合は、[インストール](/ja/cad/net/installation/) を確認して、サンプルプロジェクトに Aspose.CAD.dll の参照を追加してください。

## **GitHubからダウンロード**

Aspose.CAD for .NET のすべての例は [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET) にホストされています。

- お気に入りの GitHub クライアントを使用してリポジトリをクローンするか、[こちら](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip) から ZIP ファイルをダウンロードできます。
- ZIP ファイルの内容をコンピューターの任意のフォルダーに抽出します。すべての例は **Examples** フォルダーにあります。
- C# 用の Visual Studio ソリューションファイルがあります。
- プロジェクトは Visual Studio 2013 で作成されていますが、ソリューションファイルは Visual Studio 2010 SP1 以上と互換性があります。
- Visual Studio でソリューションファイルを開き、プロジェクトをビルドします。
- 初回実行時に、依存関係が NuGet を介して自動的にダウンロードされます。
- **Examples** のルートフォルダーにある **Data** フォルダーには、CSharp の例で使用される入力ファイルが含まれています。例のプロジェクトとともに **Data** フォルダーをダウンロードすることが必須です。
- RunExamples.cs ファイルを開き、すべての例はここから呼び出されます。
- プロジェクト内で実行したい例のコメントを外してください。

例の設定や実行に問題がある場合は、お気軽にフォーラムをご利用ください。

## **貢献**

例を追加または改善したい場合は、プロジェクトに貢献することをお勧めします。このリポジトリ内のすべての例やショーケースプロジェクトはオープンソースであり、自由に自分のアプリケーションで使用できます。

貢献するには、リポジトリをフォークし、ソースコードを編集してプルリクエストを作成することができます。変更をレビューし、有用であればリポジトリに含めます。
