---
title: 安装
type: docs
weight: 30
url: /zh/java/getting-started/installation/
---

## **从 Maven 仓库安装 Aspose.CAD for Java**

Aspose 在 [Maven 仓库](https://releases.aspose.com/java/repo/com/aspose/)中托管所有 Java API。您可以很方便地在您的 Maven 项目中直接使用 [Aspose.CAD for Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API，配置简单。

### **指定 Maven 仓库配置**

首先，您需要在 Maven pom.xml 中指定 Aspose Maven 仓库的配置/位置，如下所示：

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

### **定义 Aspose.CAD for Java API 依赖**

然后在您的 pom.xml 中定义 Aspose.CAD for Java API 依赖，如下所示：

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

完成上述步骤后，Aspose.CAD for Java 依赖最终将在您的 Maven 项目中定义。

## **支持的平台**

Aspose.CAD for Java 支持最流行的开发和部署平台。

|**功能**|**描述**|
| :- | :- |
|桌面应用程序|Aspose.CAD for Java 可用于开发 MS Windows 下的桌面应用程序。|
|企业 Web 应用程序|Aspose.CAD for Java 完全支持 Web 应用程序。|
|Linux/Unix|Aspose.CAD for Java 是跨平台的 API，可以在 Linux 和 Unix 环境中工作。|

## **支持的 Java 版本**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
