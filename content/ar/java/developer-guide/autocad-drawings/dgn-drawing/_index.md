---
title: رسم DGN
type: docs
weight: 10
url: /ar/java/dgn-drawing/
---

## **رسم تنسيق DGN كجزء من DWG**

يوفر Aspose.CAD لـ Java للمطورين إمكانية تصدير ملف DWG مع إدراج DGN مدمج داخله. فيما يلي الكود الذي يوضح كيفية الوصول إلى إدراج DGN داخل ملف DWG أثناء تصدير ملف DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **دعم الكيانات ثلاثية الأبعاد لــ DGN v7**

قدمت واجهة برمجة التطبيقات Aspose.CAD لـ Java وظيفة تحميل ملف DGN AutoCAD ودعم الكيانات ثلاثية الأبعاد لــ DGN v7. فئة [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) تخدم هذا الغرض. يدعم كل صورة DGN 9 وجهات محددة مسبقًا. يتم تعدادها من 1 إلى 9. إذا لم يتم تعريف العرض أثناء التصدير، سيتم تصدير جميع الوجهات بتنسيقات المخرجات متعددة الصفحات (مثل PDF)، كل منها في صفحة منفصلة. تدعم تنسيق ملف DGN الكيانات ثلاثية الأبعاد وكذلك ثنائية الأبعاد.
لم يعد يتم استخدام VectorRasterizationOptions.TypeOfEntities لتنسيق DGN (يتم دعم كل من 2D و 3D في نفس الوقت).

كود عينة للاطلاع على العناصر المدعومة في DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
