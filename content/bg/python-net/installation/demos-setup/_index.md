---
title: Настройка на демонстрациите
type: документация
weight: 40
url: /bg/python-net/setup-for-demos/
---

{{% alert color="primary" %}}

Aspose.CAD за Python включва няколко демо проекта, които ще ви помогнат да започнете.

Демонстрациите, предоставени с Aspose.CAD за Python, са стандартни демонстрации на Python, модифицирани за да демонстрират използването на новите експортьори.

{{% /alert %}}

За да стартирате демонстрациите на Aspose.CAD за Python, изпълнете следните стъпки:

1. Изтеглете Python (например https://sourceforge.net/projects/python-net/files/archive/). Уверете се, че сте изтеглили целия архивиран проект със изходния код и демонстрациите, а не само един JAR файл.
1. Разархивирайте проекта на някое място на вашия твърд диск, например C:\.
1. Копирайте всички папки с демонстрации от папката \samples на **aspose-cad-xx.x.zip** в папката **\InstallDir\demo\samples**, където "\InstallDir" е мястото, на което сте разархивирали Python. Тази стъпка е необходима, защото скриптовете за създаване на демонстрациите зависят от структурата на папките на Python, в противен случай ще трябва да модифицирате скриптовете за създаване.
1. Копирайте **aspose-cad-pythons-xx.x.jar** от папката \lib на **aspose-cad-pythons-xx.x.zip** в папката **\InstallDir\lib**.
1. Подгответе Ant Build Tool и Ivy Dependency Manager, вижте **\InstallDir\readme.txt**.
1. Променете **build.xml** в **\InstallDir\demo\samples**, добавете aspose-cad-pythons-xx.x.jar в пътя към класовете:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Променете текущата директория на **\InstallDir\demo\hsqldb** и стартирайте следната команда в командния ред:
   **ant runServer**
1. Променете текущата директория на едно от демонстрациите на Aspose.CAD за Python, например **\InstallDir\demo\samples\charts.ai** и стартирайте следните команди в командния ред:
   **ant test** - за да се генерират файлове с доклади.
1. Отворете един от получените документи за преглед, например **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
