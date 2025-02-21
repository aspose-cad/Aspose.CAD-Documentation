---
title: Установка демонстрационных проектов
type: docs
weight: 40
url: /ru/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports включает в себя ряд демонстрационных проектов, чтобы помочь вам начать работу.

Демострации, предоставленные с Aspose.CAD для JasperReports, являются стандартными демонстрациями JasperReports, модифицированными для демонстрации использования новых экспортёров.

{{% /alert %}}

Для запуска демонстрационных проектов Aspose.CAD для JasperReports выполните следующие шаги:

1. Скачайте JasperReports (например, https://sourceforge.net/projects/jasperreports/files/archive/). Убедитесь, что вы скачали весь архивированный проект с исходным кодом и демонстрациями, а не только один JAR.
1. Распакуйте архивированный проект в любое место на вашем жестком диске, например C:\.
1. Скопируйте все папки с демонстрациями из папки \samples файла **aspose-cad-xx.x.zip** в **\InstallDir\demo\samples**, где "\InstallDir" - это местоположение, куда вы распаковали JasperReports. Этот шаг необходим, потому что скрипты сборки демо зависят от структуры папок JasperReports, иначе вам придется модифицировать скрипты сборки.
1. Скопируйте **aspose-cad-jasperreports-xx.x.jar** из папки \lib файла **aspose-cad-jasperreports-xx.x.zip** в **\InstallDir\lib**.
1. Подготовьте Ant Build Tool и Ivy Dependency Manager, смотрите **\InstallDir\readme.txt**.
1. Измените файл **build.xml** в **\InstallDir\demo\samples**, добавьте aspose-cad-jasperreports-xx.x.jar в classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Перейдите в текущую директорию **\InstallDir\demo\hsqldb** и выполните следующую команду в командной строке:
   **Ant runServer**
1. Перейдите в текущую директорию одной из демонстраций Aspose.CAD для JasperReports, например **\InstallDir\demo\samples\charts.ai** и выполните следующие команды в командной строке:
   **ant test** - для создания отчетных файлов.
1. Откройте один из полученных документов для просмотра, например **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
