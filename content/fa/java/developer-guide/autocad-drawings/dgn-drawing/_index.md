---
title: نقشه DGN
type: docs
weight: 10
url: /fa/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **رسم فرمت DGN به عنوان بخشی از DWG**

Aspose.CAD برای جاوا به توسعه‌دهندگان این امکان را می‌دهد که یک فایل DWG را با زیرلایه DGN جاسازی شده صادر کنند. کد زیر نحوه دسترسی به زیرلایه DGN در یک فایل DWG را در حین صادرات فایل DWG نشان می‌دهد.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **پشتیبانی از موجودیت‌های 3D برای DGN v7**

API Aspose.CAD برای جاوا عملکرد بارگذاری یک فایل DGN AutoCAD و پشتیبانی از موجودیت‌های 3D برای DGN v7 را معرفی کرده است. کلاس [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) به این منظور استفاده می‌شود. هر تصویر DGN از 9 نمای از پیش تعریف شده پشتیبانی می‌کند. این نماها از 1 تا 9 شماره‌گذاری شده‌اند. اگر نما در هنگام صادرات تعریف نشده باشد، برای فرمت‌های خروجی چند صفحه‌ای (مانند PDF) تمام نماها صادر خواهند شد؛ هر کدام در یک صفحه جداگانه. موجودیت‌های 3D در فرمت فایل DGN همچنین با 2D پشتیبانی می‌شوند. 
VectorRasterizationOptions.TypeOfEntities دیگر برای فرمت DGN استفاده نمی‌شود (هر دو 2D و 3D به صورت همزمان پشتیبانی می‌شوند).

کد نمونه‌ای برای بررسی عناصر پشتیبانی‌شده DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
