---
title: رسومات DWF
type: docs
weight: 20
url: /ar/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **تصدير رسومات DWF إلى PDF**

يمكن لواجهة برمجة تطبيقات Aspose.CAD لـ Java تحميل رسومات AutoCAD في تنسيق DWF، وتحويلها إلى PDF. تشرح هذه الموضوع استخدام واجهة برمجة تطبيقات Aspose.CAD لتحقيق تحويل DWF إلى تنسيق PDF من خلال خطوات بسيطة كما هو موضح في ما يلي.

### **تحويل ملفات DWF إلى PDF**

الخطوات البسيطة التالية مطلوبة لتحويل DWF إلى PDF.

1. قم بتحميل ملف DWF إلى مثيل من [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. أنشئ كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. أنشئ كائنًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) واضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) كمعامل ثانٍ.

يظهر نموذج الكود أدناه كيفية تصدير رسومات DWF إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **دعم الطبقات في DWF**

يوفر Aspose.CAD ميزة تحميل كيانات رسومات DWF من AutoCAD وعرضها كرسمة كاملة بتنسيق JPG.

1. قم بتحميل ملف رسم DWF باستخدام طريقة المصنع [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. أنشئ كائنًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. أضف الطبقات المرغوبة.
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) مع تمرير كائن من [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) كمعامل ثانٍ.

يظهر نموذج الكود أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
