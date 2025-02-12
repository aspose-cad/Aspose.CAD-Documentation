---
title: تنظیم دموها
type: docs
weight: 40
url: /fa/jasperreports/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD برای JasperReports شامل تعدادی پروژه دمو است تا به شما در شروع کمک کند.

دموهای ارائه شده با Aspose.CAD برای JasperReports دموهای استاندارد JasperReports هستند که برای نمایش استفاده از صادرکننده‌های جدید تغییر یافته‌اند.

{{% /alert %}}

برای اجرای دموهای Aspose.CAD برای JasperReports، مراحل زیر را انجام دهید:

1. JasperReports را دانلود کنید (برای مثال https://sourceforge.net/projects/jasperreports/files/archive/). اطمینان حاصل کنید که کل پروژه آرشیو شده شامل کد منبع و دموها را دانلود کنید، نه فقط یک JAR واحد.
1. پروژه آرشیو شده را در یک مکان روی دیسک سخت خود، به عنوان مثال C:\، استخراج کنید.
1. تمام پوشه‌های دمو را از پوشه \samples **aspose-cad-xx.x.zip** به **\InstallDir\demo\samples** کپی کنید، جایی که "\InstallDir" مکان استخراج شده JasperReports است. این مرحله الزامی است زیرا اسکریپت‌های ساخت دمو به ساختار پوشه‌های JasperReports وابسته هستند، در غیر این صورت باید اسکریپت‌های ساخت را تغییر دهید.
1. **aspose-cad-jasperreports-xx.x.jar** را از پوشه \lib **aspose-cad-jasperreports-xx.x.zip** به **\InstallDir\lib** کپی کنید.
1. ابزار ساخت Ant و مدیر وابستگی Ivy را آماده کنید، به **\InstallDir\readme.txt** مراجعه کنید.
1. **build.xml** را در **\InstallDir\demo\samples** تغییر دهید، **aspose-cad-jasperreports-xx.x.jar** را به classpath اضافه کنید:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. دایرکتوری فعلی را به **\InstallDir\demo\hsqldb** تغییر دهید و فرمان زیر را اجرا کنید:
   **Ant runServer**
1. دایرکتوری فعلی را به یکی از دموهای Aspose.CAD برای JasperReports تغییر دهید، به عنوان مثال **\InstallDir\demo\samples\charts.ai** و دستورات زیر را در خط فرمان اجرا کنید:
   **ant test** - برای تولید فایل‌های گزارش.
1. یکی از اسناد نتیجه‌گیری شده را برای مشاهده باز کنید، به عنوان مثال **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
