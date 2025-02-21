---
title: デモセットアップ
type: docs
weight: 40
url: /ja/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReportsには、始めるためのいくつかのデモプロジェクトが含まれています。

Aspose.CAD for JasperReportsに付属するデモは、新しいエクスポーターの使用を示すために修正された標準JasperReportsデモです。

{{% /alert %}}

Aspose.CAD for JasperReportsデモを実行するには、次の手順を実行してください：

1. JasperReportsをダウンロードします（例：https://sourceforge.net/projects/jasperreports/files/archive/）。ソースコードとデモを含む全アーカイブプロジェクトをダウンロードし、単一のJARだけではなくしてください。
1. アーカイブされたプロジェクトをハードディスクの任意の場所に展開します。例えば、C:\に展開します。
1. **aspose-cad-xx.x.zip**の\samplesフォルダーからすべてのデモフォルダーを**\InstallDir\demo\samples**にコピーします。ここで「\InstallDir」とは、JasperReportsを展開した場所です。このステップは、デモビルドスクリプトがJasperReportsのフォルダー構造に依存しているため、必要です。そうでなければ、ビルドスクリプトを修正する必要があります。
1. **aspose-cad-jasperreports-xx.x.jar**を**aspose-cad-jasperreports-xx.x.zip**の\libフォルダーから**\InstallDir\lib**にコピーします。
1. AntビルドツールとIvy依存関係マネージャーを準備します。**\InstallDir\readme.txt**を参照してください。
1. **\InstallDir\demo\samples**にある**build.xml**を修正し、classpathにaspose-cad-jasperreports-xx.x.jarを追加します：
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**。
1. 現在のディレクトリを**\InstallDir\demo\hsqldb**に変更し、次のコマンドラインを実行します：
   **Ant runServer**
1. 現在のディレクトリをAspose.CAD for JasperReportsデモの1つ、例えば**\InstallDir\demo\samples\charts.ai**に変更し、コマンドラインで次のコマンドを実行します：
   **ant test** - レポートファイルを生成するために。
1. 結果として得られたドキュメントの1つを開いて表示します。例えば、**\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**。
