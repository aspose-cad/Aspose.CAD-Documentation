---
title: 如何运行示例
type: docs
weight: 70
url: /zh/java/getting-started/how-to-run-the-examples/
---

## **从 GitHub 下载**

所有 Aspose.CAD for Java 示例都托管在 [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java)。您可以使用您喜欢的 Github 客户端克隆该存储库，或从 [这里](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip) 下载 ZIP 文件。

将 ZIP 文件的内容提取到您计算机上的任何文件夹中。所有示例都位于 **Examples** 文件夹中。

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**图：Aspose.CAD 示例目录**|

## **将示例导入 IDE**

该项目使用 Maven 构建系统。任何现代 IDE 都可以轻松打开或导入该项目及其依赖项。下面我们将向您展示如何使用流行的 IDE 构建和运行示例。

### **IntelliJ IDEA**

点击 **文件** 菜单并选择 **打开**。浏览到项目文件夹并选择 **pom.xml** 文件。

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**图：选择要导入的文件或目录**|
这将打开项目并自动下载依赖项。从项目选项卡中，浏览 **src/main/java** 文件夹中的示例。要运行示例，只需右键单击文件并选择“运行 ..”，示例将执行，并且输出将显示在内置控制台输出窗口中。

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**图：运行示例**|

### **Eclipse**

点击 **文件** 菜单并选择 **导入**。选择 **Maven** - 现有 Maven 项目。

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**图：导入**|
浏览到您从 GitHub 克隆或下载的文件夹，选择 **pom.xml** 文件。它将打开项目并自动下载依赖项。从包资源管理器选项卡中，浏览 **src/main/java** 文件夹中的示例。要运行示例，只需右键单击文件并选择 **作为** - **Java 应用程序**，示例将执行，并且输出将显示在内置控制台输出窗口中。

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**图：运行示例**|

### **NetBeans**

点击 **文件** 菜单并选择 **打开项目**。浏览到您从 GitHub 克隆或下载的文件夹。**Examples** 文件夹的图标将显示它是一个 Maven 项目。选择 Examples 并打开它。

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**图：打开项目**|
这将打开项目并自动下载依赖项。从项目选项卡中，浏览 **源包** 中的示例。要运行示例，只需右键单击文件并选择 **运行文件**，示例将执行，并且输出将显示在内置控制台输出窗口中。

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**图：运行示例**|

## **将 Aspose.CAD 库添加到 Maven 本地存储库**

当您将 **Aspose.CAD 示例** 项目导入到 IDE 时，Maven 会自动从 [Aspose Maven Repository](https://releases.aspose.com/java/repo/) 下载 aspose.cad JAR 文件。如果您无法访问互联网，您可以手动将 JAR 添加到本地存储库。

### **mvn install**

下载 [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/)，解压并将 aspose.cad-version.jar 复制到其他位置，例如 C 盘。执行以下命令：

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

现在 **aspose.cad** jar 已复制到您的 Maven 本地存储库中。

### **pom.xml**

安装后，只需在 pom.xml 中声明 **aspose.cad** 坐标。

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **完成**

构建它，现在 **aspose.cad** jar 可以从您的 Maven 本地存储库中检索。

## **贡献**

如果您想添加或改进示例，我们鼓励您为该项目做出贡献。该存储库中的所有示例和展示项目都是开源的，可以自由地在自己的应用程序中使用。

要做出贡献，您可以叉出存储库，编辑源代码并提交拉取请求。我们将审查更改，并在发现有用时将其包含在存储库中。
