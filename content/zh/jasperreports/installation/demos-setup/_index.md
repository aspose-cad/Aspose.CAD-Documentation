---
title: Demos 设置
type: docs
weight: 40
url: /zh/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports 包含多个示例项目，以帮助您入门。

提供的 Aspose.CAD for JasperReports 示例是标准的 JasperReports 示例，经过修改以演示新导出器的使用。

{{% /alert %}}

要运行 Aspose.CAD for JasperReports 示例，请执行以下步骤：

1. 下载 JasperReports（例如 https://sourceforge.net/projects/jasperreports/files/archive/）。确保下载整个带有源代码和示例的存档项目，而不仅仅是单个 JAR。
2. 将归档项目解压到您硬盘的某个位置，例如 C:\。
3. 将 **aspose-cad-xx.x.zip** 的 \samples 文件夹中的所有示例文件夹复制到 **\InstallDir\demo\samples**，其中 "\InstallDir" 是您解压 JasperReports 的位置。此步骤是必需的，因为示例构建脚本依赖于 JasperReports 的文件夹结构，否则您需要修改构建脚本。
4. 将 **aspose-cad-jasperreports-xx.x.jar** 从 **aspose-cad-jasperreports-xx.x.zip** 的 \lib 文件夹复制到 **\InstallDir\lib**。
5. 准备 Ant 构建工具和 Ivy 依赖管理器，请参阅 **\InstallDir\readme.txt**。
6. 修改 **\InstallDir\demo\samples** 中的 **build.xml**，将 aspose-cad-jasperreports-xx.x.jar 添加到类路径中：
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**。
7. 将当前目录更改为 **\InstallDir\demo\hsqldb**，并运行以下命令：
   **Ant runServer**
8. 将当前目录更改为 Aspose.CAD for JasperReports 示例之一，例如 **\InstallDir\demo\samples\charts.ai**，并在命令行中运行以下命令：
   **ant test** - 以生成报告文件。
9. 打开生成的文档之一进行查看，例如 **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**。
