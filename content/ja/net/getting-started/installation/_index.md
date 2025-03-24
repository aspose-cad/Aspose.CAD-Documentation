---
title: インストール
type: docs
weight: 30
url: /ja/net/getting-started/installation/
---

## **NuGetを使用したAspose.CAD for .NETのインストール**

NuGetは、Aspose APIを.NET用にダウンロードしてインストールする最も簡単な方法です。Microsoft Visual StudioとNuGetパッケージマネージャーを開きます。"aspose"で検索して、目的のAspose APIを見つけます。"Install"をクリックすると、選択したAPIがダウンロードされ、プロジェクトに参照されます。

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **.NETプロジェクトからAspose.CADを参照する**

以下の手順に従ってください（Microsoft Visual Studioを使用していると仮定します）:

1. **ソリューションエクスプローラー**で、参照を追加したいプロジェクトノードを展開します。
1. プロジェクトの**参照**ノードを右クリックし、ショートカットメニューから**参照の追加**を選択します。
1. **参照の追加**ダイアログボックスでDLLファイルの場所を参照します。
1. *Aspose.CAD* DLLファイルを選択し、**OK**ボタンをクリックします。
1. *Aspose.CAD*の参照がプロジェクトの**参照**ノードの下に表示されます。

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **パッケージマネージャーコンソールを使用してAspose.CADをインストールまたは更新する**

以下の手順に従って、パッケージマネージャーコンソールを使用して[Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/)に参照を追加できます。

1. Visual Studioでソリューション/プロジェクトを開きます。
1. メニューからツール -> ライブラリパッケージマネージャー -> パッケージマネージャーコンソールを選択して、パッケージマネージャーコンソールを開きます。

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

“**Install-Package Aspose.CAD**”というコマンドを入力し、Enterキーを押してアプリケーションに最新のフルリリースをインストールします。代わりに、コマンドに"**-prerelease**"サフィックスを追加して、最新のリリースにはホットフィックスも含まれることを指定できます。

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

“Downloading Aspose.CAD...”のヒントがウィンドウの左下に表示され、ダウンロードプロセスが進行中であることを示します。

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

ダウンロードが完了すると、次の確認メッセージが表示されます。[Aspose EULA](https://about.aspose.com/legal/eula)に不慣れな場合は、URLに参照されているライセンスを読むことをお勧めします。

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

これでAspose.CADが正常にアプリケーションに追加され、参照されていることがわかります。

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

パッケージマネージャーコンソールでは、コマンド“**Update-Package Aspose.CAD**”を使用して、Aspose.CADパッケージの更新を確認し、存在する場合はインストールするためにEnterキーを押すこともできます。"-prerelease"サフィックスを追加して最新のリリースをアップデートすることもできます。

## **共有サーバー環境での実行時の考慮事項**

すべてのAspose .NETコンポーネントは、フルトラストの権限セットで実行することを推奨します。これは、Aspose .NETコンポーネントが時々レジストリ設定や仮想ディレクトリ以外の場所にあるファイルにアクセスする必要があるためです（フォントの読み取りなど）。さらに、Aspose.NETコンポーネントはコア.NETシステムクラスに基づいており、いくつかは実行するためにフルトラストの権限を必要とする場合もあります。

複数の企業からのアプリケーションをホストしているインターネットサービスプロバイダーは、通常ミディアムトラストのセキュリティレベルを強制します。.NET 2.0の場合、このようなセキュリティレベルは、Aspose.CADが正しく機能する能力に影響を与える可能性のある以下の制約を設定する場合があります。

- **RegistryPermission**が利用できません。これは、フォントをレンダリングする際にインストールされているフォントを列挙するために必要なレジストリにアクセスできないことを意味します。
- **FileIOPermission**が制限されています。これは、アプリケーションの仮想ディレクトリ階層内のファイルにのみアクセスできることを意味します。これは潜在的にエクスポート中にフォントを読み取れないことを意味します。

したがって、上述の理由により、Aspose.CADはフルトラストの権限で実行されることをお勧めします。一部の機能はミディアムトラストでの別のタスクを実行する際に機能するかもしれませんが、他の機能（例えばレンダリングなど）は、GDI+画像処理への呼び出しによるもので機能しない場合があります。

## **システム要件**

### **オペレーティングシステム**

Aspose.CAD for .NETは、.NETまたはMonoフレームワークがインストールされている32ビットまたは64ビットのオペレーティングシステムをサポートしており、以下を含むがこれに限定されません：

- Microsoft Windowsデスクトップ（XP、Vista、7、8、10）およびサーバーオペレーティングシステム（2003、2008、2012）
- Windows Azure
- Linux（Ubuntu、openSUSE、CentOSなど）
- Mac OS X

### **フレームワーク**

Aspose.CAD for .NETは以下をサポートしています：

- クライアントプロファイルバージョンを含む、2.0から4.5までの.NETフレームワークバージョン
- .NET Core
- Mono 2.6.7以降

### **開発環境**

Aspose.CAD for .NETを使用して、.NETプラットフォームをターゲットにしたアプリケーションを開発できますが、以下の環境は明示的にサポートされています：

- Microsoft Visual Studio 2010以降
- MonoDevelop 2.4以降
