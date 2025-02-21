---
title: インストール
type: docs
weight: 30
url: /ja/java/getting-started/installation/
---

## **MavenリポジトリからのAspose.CAD for Javaのインストール**

AsposeはすべてのJava APIを [Mavenリポジトリ](https://releases.aspose.com/java/repo/com/aspose/)にホストしています。シンプルな設定で、Mavenプロジェクト内で直接[Aspose.CAD for Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) APIを簡単に使用できます。

### **Mavenリポジトリの設定を指定する**

まず、Maven pom.xmlにAspose Mavenリポジトリの設定/場所を次のように指定する必要があります：

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **Aspose.CAD for Java API依存関係を定義する**

次に、pom.xmlにAspose.CAD for Java API依存関係を次のように定義します：

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

上記の手順を実行すると、最終的にMavenプロジェクト内にAspose.CAD for Java依存関係が定義されます。

## **サポートされているプラットフォーム**

Aspose.CAD for Javaは、最も人気のある開発および展開プラットフォームをサポートしています。

|**特徴**|**説明**|
| :- | :- |
|デスクトップアプリケーション|Aspose.CAD for JavaはMS Windows上でデスクトップアプリケーションを開発するために使用できます。|
|エンタープライズウェブアプリケーション|Aspose.CAD for Javaはウェブアプリケーションを完全にサポートしています。|
|Linux/Unix|Aspose.CAD for Javaはプラットフォームに依存しないAPIであり、LinuxおよびUnix環境で動作できます。|

## **サポートされているJavaバージョン**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
