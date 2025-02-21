---
title: デモのセットアップ
type: docs
weight: 40
url: /ja/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD for Pythonには、開始するためのいくつかのデモプロジェクトが含まれています。

Aspose.CAD for Pythonに提供されるデモは、新しいエクスポーターの使用を示すために変更された標準のPythonデモです。

{{% /alert %}}

Aspose.CAD for Pythonのデモを実行するには、以下の手順を実行します。

1. Pythonをダウンロードします（例： https://sourceforge.net/projects/python-net/files/archive/）。ソースコードとデモを含む全体のアーカイブプロジェクトをダウンロードし、単一のJARだけではないことを確認してください。
1. アーカイブされたプロジェクトをハードディスクの任意の場所に展開します。例えばC:\です。
1. **aspose-cad-xx.x.zip**の\samplesフォルダからすべてのデモフォルダを**\InstallDir\demo\samples**にコピーします。「\InstallDir」は、Pythonを展開した場所です。この手順は、デモビルドスクリプトがPythonのフォルダ構造に依存しているため、そうでなければビルドスクリプトを修正する必要があります。
1. **aspose-cad-pythons-xx.x.jar**を**aspose-cad-pythons-xx.x.zip**の\libフォルダから**\InstallDir\lib**にコピーします。
1. AntビルドツールとIvy依存性マネージャを準備します。**\InstallDir\readme.txt**を参照してください。
1. **\InstallDir\demo\samples**の**build.xml**を修正し、classpathにaspose-cad-pythons-xx.x.jarを追加します：
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. 現在のディレクトリを**\InstallDir\demo\hsqldb**に変更し、次のコマンドラインを実行します：
   **ant runServer**
1. 現在のディレクトリをAspose.CAD for Pythonのデモの1つに変更します。例えば**\InstallDir\demo\samples\charts.ai**に変更し、次のコマンドをコマンドラインで実行します：
   **ant test** - レポートファイルを生成します。
1. 得られた文書の1つを開きます。例えば、**\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**です。
