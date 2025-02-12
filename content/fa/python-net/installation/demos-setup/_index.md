---
title: راه اندازی دموها
type: docs
weight: 40
url: /fa/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD برای Python شامل تعدادی پروژه دمو به شما کمک می‌کند تا شروع کنید.

دموهای ارائه شده با Aspose.CAD برای Python دموهای استاندارد Python هستند که برای نشان دادن استفاده از صادرکننده‌های جدید اصلاح شده‌اند.

{{% /alert %}}

برای اجرای دموهای Aspose.CAD برای Python، مراحل زیر را انجام دهید:

1. Python را دانلود کنید (به عنوان مثال https://sourceforge.net/projects/python-net/files/archive/). مطمئن شوید که کل پروژه آرشیوی با کد منبع و دموها را دانلود کنید و فقط یک JAR دانلود نکنید.
1. پروژه آرشیوی را به یک مکان در دیسک سخت خود، برای مثال C:\، استخراج کنید.
1. تمام پوشه‌های دمو را از پوشه \samples **aspose-cad-xx.x.zip** به **\InstallDir\demo\samples** کپی کنید، جایی که "\InstallDir" مکان استخراج شده Python ها است. این مرحله ضروری است زیرا اسکریپت‌های ساخت دمو به ساختار پوشه‌های Python وابسته‌اند، در غیر این صورت باید اسکریپت‌های ساخت را تغییر دهید.
1. **aspose-cad-pythons-xx.x.jar** را از پوشه \lib **aspose-cad-pythons-xx.x.zip** به **\InstallDir\lib** کپی کنید.
1. ابزار ساخت Ant و مدیریت وابستگی Ivy را آماده کنید، به **\InstallDir\readme.txt** مراجعه کنید.
1. **build.xml** واقع در **\InstallDir\demo\samples** را اصلاح کنید، **aspose-cad-pythons-xx.x.jar** را به classpath اضافه کنید:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. دایرکتوری فعلی را به **\InstallDir\demo\hsqldb** تغییر دهید و دستور زیر را اجرا کنید:
   **ant runServer**
1. دایرکتوری فعلی را به یکی از دموهای Aspose.CAD برای Python تغییر دهید، به عنوان مثال **\InstallDir\demo\samples\charts.ai** و دستورات زیر را در خط فرمان اجرا کنید:
   **ant test** - برای تولید فایل‌های گزارش.
1. یکی از اسناد نتیجه‌گیری را برای مشاهده باز کنید، به عنوان مثال **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
