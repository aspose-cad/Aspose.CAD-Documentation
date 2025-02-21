---
title: 演示设置
type: docs
weight: 40
url: /zh/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for Python 包含了多个演示项目，帮助您入门。

与 Aspose.CAD for Python 一起提供的演示是标准的 Pythons 演示，经过修改以展示新导出器的使用。

{{% /alert %}}

要运行 Aspose.CAD for Python 演示，请执行以下步骤：

1. 下载 Pythons（例如 https://sourceforge.net/projects/python-net/files/archive/）。确保下载整个压缩项目，包括源代码和演示，而不仅仅是单个 JAR。
1. 将压缩项目解压缩到硬盘上的某个位置，例如 C:\。
1. 将 **aspose-cad-xx.x.zip** 中 **\samples** 文件夹的所有演示文件夹复制到 **\InstallDir\demo\samples**，其中 "\InstallDir" 是您解压缩 Pythons 的位置。此步骤是必需的，因为演示构建脚本依赖于 Pythons 的文件夹结构，否则您需要修改构建脚本。
1. 将 **aspose-cad-pythons-xx.x.jar** 从 **aspose-cad-pythons-xx.x.zip** 的 **\lib** 文件夹复制到 **\InstallDir\lib**。
1. 准备 Ant Build Tool 和 Ivy Dependency Manager，参见 **\InstallDir\readme.txt**。
1. 修改 **\InstallDir\demo\samples** 中的 **build.xml**，将 aspose-cad-pythons-xx.x.jar 添加到类路径中：
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**。
1. 将当前目录更改为 **\InstallDir\demo\hsqldb** 并运行以下命令行：
   **ant runServer**
1. 将当前目录更改为 Aspose.CAD for Python 演示之一，例如 **\InstallDir\demo\samples\charts.ai**，并在命令行中运行以下命令：
   **ant test** - 生成报告文件。
1. 打开生成的文档之一进行查看，例如 **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**。
