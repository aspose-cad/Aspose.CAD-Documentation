---
title: Настройка на демонстрации
type: docs
weight: 40
url: /bg/jasperreports/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD за JasperReports включва редица демонстрационни проекти, които да ви помогнат да започнете.

Демонстрациите, предоставени с Aspose.CAD за JasperReports, са стандартни демонстрации на JasperReports, модифицирани за демонстриране на използването на новите експортери.

{{% /alert %}}

За да стартирате демонстрациите на Aspose.CAD за JasperReports, изпълнете следните стъпки:

1. Изтеглете JasperReports (например https://sourceforge.net/projects/jasperreports/files/archive/). Убедете се, че изтегляте целия архивиран проект с изходния код и демонстрациите, а не само един JAR.
1. Разархивирайте архивирания проект на някое място на硬 disk, например C:\.
1. Копирайте всички демонстрационни папки от папката \samples на **aspose-cad-xx.x.zip** в **\InstallDir\demo\samples**, където "\InstallDir" е местоположението, където сте разархивирали JasperReports. Тази стъпка е необходима, защото скриптовете за изграждане на демонстрации разчитат на структурата на папките на JasperReports, в противен случай ще трябва да модифицирате скриптовете за изграждане.
1. Копирайте **aspose-cad-jasperreports-xx.x.jar** от папката \lib на **aspose-cad-jasperreports-xx.x.zip** в **\InstallDir\lib**.
1. Подгответе Ant Build Tool и Ivy Dependency Manager, вижте **\InstallDir\readme.txt**.
1. Модифицирайте **build.xml** в **\InstallDir\demo\samples**, добавете aspose-cad-jasperreports-xx.x.jar в classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Променете текущата директория на **\InstallDir\demo\hsqldb** и изпълнете следната командна линия:
   **Ant runServer**
1. Променете текущата директория на една от демонстрациите на Aspose.CAD за JasperReports, например **\InstallDir\demo\samples\charts.ai** и изпълнете следните команди в командната линия:
   **ant test** - за да произведете отчетни файлове.
1. Отворете един от получените документи за преглед, например **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
