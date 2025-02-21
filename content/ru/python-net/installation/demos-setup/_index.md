---
title: Настройка демо
type: docs
weight: 40
url: /ru/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD для Python включает множество демо проектов, которые помогут вам начать работу.

Демо, предоставляемые с Aspose.CAD для Python, являются стандартными демо для Python, модифицированными для демонстрации использования новых экспортеров.

{{% /alert %}}

Чтобы запустить демо Aspose.CAD для Python, выполните следующие шаги:

1. Скачайте Python (например, https://sourceforge.net/projects/python-net/files/archive/). Убедитесь, что вы скачали весь архивированный проект с исходным кодом и демо, а не только один JAR.
1. Распакуйте архивированный проект в любое место на вашем жестком диске, например C:\.
1. Скопируйте все демо папки из папки \samples из **aspose-cad-xx.x.zip** в **\InstallDir\demo\samples**, где "\InstallDir" - это расположение, куда вы распаковали Python. Этот шаг необходим, потому что сценарии сборки демо зависят от структуры папок Python, в противном случае вам потребуется изменить сценарии сборки.
1. Скопируйте **aspose-cad-pythons-xx.x.jar** из папки \lib из **aspose-cad-pythons-xx.x.zip** в **\InstallDir\lib**.
1. Подготовьте инструмент сборки Ant и менеджер зависимостей Ivy, смотрите **\InstallDir\readme.txt**.
1. Измените **build.xml** в **\InstallDir\demo\samples**, добавьте aspose-cad-pythons-xx.x.jar в classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Измените текущий каталог на **\InstallDir\demo\hsqldb** и выполните следующую команду:
   **ant runServer**
1. Измените текущий каталог на один из демо Aspose.CAD для Python, например **\InstallDir\demo\samples\charts.ai** и выполните следующие команды в командной строке:
   **ant test** - для создания отчетных файлов.
1. Откройте один из полученных документов для просмотра, например **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
