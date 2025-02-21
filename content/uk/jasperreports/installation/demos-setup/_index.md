---
title: Налаштування демонстрацій
type: docs
weight: 40
url: /uk/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports включає ряд демонстраційних проектів, які допоможуть вам почати.

Демонстрації, надані з Aspose.CAD для JasperReports, є стандартними демонстраціями JasperReports, модифікованими для демонстрації використання нових експортерів.

{{% /alert %}}

Щоб запустити демонстрації Aspose.CAD для JasperReports, виконайте наступні кроки:

1. Завантажте JasperReports (наприклад, https://sourceforge.net/projects/jasperreports/files/archive/). Переконайтеся, що завантажили весь архів проекту з вихідним кодом і демонстраціями, а не лише один JAR.
1. Розпакуйте архівований проект у деяке місце на вашому жорсткому диску, наприклад, C:\.
1. Скопіюйте всі папки з демонстраціями з папки \samples **aspose-cad-xx.x.zip** в **\InstallDir\demo\samples**, де "\InstallDir" - це місце, куди ви розпакували JasperReports. Цей крок є необхідним, оскільки скрипти збірки демонстрацій покладаються на структуру папок JasperReports, в іншому випадку вам потрібно буде змінити скрипти збірки.
1. Скопіюйте **aspose-cad-jasperreports-xx.x.jar** з папки \lib **aspose-cad-jasperreports-xx.x.zip** в **\InstallDir\lib**.
1. Підготуйте Ant Build Tool та Ivy Dependency Manager, дивіться **\InstallDir\readme.txt**.
1. Змініть **build.xml** в **\InstallDir\demo\samples**, додайте aspose-cad-jasperreports-xx.x.jar до classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Змініть поточну директорію на **\InstallDir\demo\hsqldb** і виконайте наступну команду в командному рядку:
   **Ant runServer**
1. Змініть поточну директорію на одну з демонстрацій Aspose.CAD для JasperReports, наприклад, **\InstallDir\demo\samples\charts.ai** та виконайте наступні команди в командному рядку:
   **ant test** - для отримання файлів звітів.
1. Відкрийте один з отриманих документів для перегляду, наприклад, **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
