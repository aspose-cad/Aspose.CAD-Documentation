---
title: Налаштування демонстрацій
type: docs
weight: 40
url: /uk/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD для Python включає ряд демонстраційних проектів, які допоможуть вам розпочати роботу.

Демонстрації, надані з Aspose.CAD для Python, є стандартними демо-програми Python, модифікованими для демонстрації використання нових експортерів.

{{% /alert %}}

Щоб запустити демонстрації Aspose.CAD для Python, виконайте такі кроки:

1. Завантажте Python (наприклад, https://sourceforge.net/projects/python-net/files/archive/). Переконайтеся, що ви завантажуєте весь архівований проект з вихідним кодом та демонстраціями, а не лише один JAR.
1. Розпакуйте архівований проект у будь-яке місце на вашому жорсткому диску, наприклад, C:\.
1. Скопіюйте всі папки з демонстраціями з папки \samples **aspose-cad-xx.x.zip** до **\InstallDir\demo\samples**, де "\InstallDir" — це місце, в яке ви розпакували Python. Цей крок є обов'язковим, оскільки сценарії зборки демонстрацій покладаються на структуру папок Python, в іншому випадку вам доведеться змінити сценарії зборки.
1. Скопіюйте **aspose-cad-pythons-xx.x.jar** з папки \lib **aspose-cad-pythons-xx.x.zip** до **\InstallDir\lib**.
1. Підготуйте Ant Build Tool та Ivy Dependency Manager, дивіться **\InstallDir\readme.txt**.
1. Змініть **build.xml** у **\InstallDir\demo\samples**, додайте aspose-cad-pythons-xx.x.jar до classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Змініть поточний каталог на **\InstallDir\demo\hsqldb** і запустіть наступну команду:
   **ant runServer**
1. Змініть поточний каталог на одну з демонстрацій Aspose.CAD для Python, наприклад, **\InstallDir\demo\samples\charts.ai** і запустіть наступні команди в командному рядку:
   **ant test** - для створення файлів звітів.
1. Відкрийте один з отриманих документів для перегляду, наприклад, **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
