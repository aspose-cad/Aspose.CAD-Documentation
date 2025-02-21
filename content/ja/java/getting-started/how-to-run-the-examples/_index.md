---
title: 例を実行する方法
type: docs
weight: 70
url: /ja/java/getting-started/how-to-run-the-examples/
---

## **GitHubからダウンロードする**

Aspose.CAD for Javaのすべての例は[Github](https://github.com/aspose-cad/Aspose.CAD-for-Java)にホストされています。お好みのGithubクライアントを使ってリポジトリをクローンするか、[こちら](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip)からZIPファイルをダウンロードできます。

ZIPファイルの内容をコンピュータ上の任意のフォルダに解凍します。すべての例は**Examples**フォルダにあります。

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**図: Aspose.CAD 例ディレクトリ**|

## **IDEに例をインポートする**

プロジェクトはMavenビルドシステムを使用しています。最新のIDEでプロジェクトとその依存関係を簡単に開いたりインポートしたりできます。以下では、人気のIDEを使用して例をビルドおよび実行する方法を示します。

### **IntelliJ IDEA**

**File**メニューをクリックし、**Open**を選択します。プロジェクトフォルダに移動し、**pom.xml**ファイルを選択します。

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**図: インポートするファイルまたはディレクトリを選択**|
プロジェクトが開き、依存関係が自動的にダウンロードされます。プロジェクトタブから、**src/main/java**フォルダ内の例を参照します。例を実行するには、ファイルを右クリックし、「Run ..」を選択します。例が実行され、出力は組み込みのコンソール出力ウィンドウに表示されます。

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**図: 例を実行する**|

### **Eclipse**

**File**メニューをクリックし、**Import**を選択します。**Maven** - **Existing Maven Projects**を選択します。

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**図: インポート**|
クローンまたはGitHubからダウンロードしたフォルダに移動し、**pom.xml**ファイルを選択します。プロジェクトが開き、依存関係が自動的にダウンロードされます。Package Explorerタブから、**src/main/java**フォルダ内の例を参照します。例を実行するには、ファイルを右クリックし、**Run As** - **Java Application**を選択します。例が実行され、出力は組み込みのコンソール出力ウィンドウに表示されます。

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**図: 例を実行する**|

### **NetBeans**

**File**メニューをクリックし、**Open Project**を選択します。クローンまたはGitHubからダウンロードしたフォルダに移動します。**Examples**フォルダのアイコンは、Mavenプロジェクトであることを示しています。Examplesを選択して開きます。

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**図: プロジェクトを開く**|
プロジェクトが開き、依存関係が自動的にダウンロードされます。Projectsタブから、**source packages**内の例を参照します。例を実行するには、ファイルを右クリックし、**Run File**を選択します。例が実行され、出力は組み込みのコンソール出力ウィンドウに表示されます。

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**図: 例を実行する**|

## **MavenローカルリポジトリにAspose.CADライブラリを追加する**

**Aspose.CAD Examples**プロジェクトをIDEにインポートすると、Mavenは自動的に[Aspose Maven Repository](https://releases.aspose.com/java/repo/)からaspose.cad JARファイルをダウンロードします。インターネットにアクセスできない場合は、手動でJARをローカルリポジトリに追加できます。

### **mvn install**

[aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/)をダウンロードし、解凍してaspose.cad-version.jarを他の場所にコピーします。例えばCドライブなど。次のコマンドを発行します：

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

これで、**aspose.cad** jarがMavenローカルリポジトリにコピーされました。

### **pom.xml**

インストールが完了したら、pom.xmlで**aspose.cad**の座標を宣言します。

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **完了**

ビルドを行うと、**aspose.cad**のjarがMavenローカルリポジトリから取得できるようになります。

## **貢献**

例を追加または改善したい場合は、プロジェクトへの貢献を奨励します。このリポジトリにあるすべての例やショーケースプロジェクトはオープンソースであり、自分のアプリケーションで自由に使用できます。

貢献するには、リポジトリをフォークし、ソースコードを編集してプルリクエストを提出できます。変更を確認し、役立つと判断された場合はリポジトリに含めます。
