---
title: رسومات DWF
type: docs
weight: 20
url: /ar/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **تصدير رسومات DWF إلى PDF**

تقدم Aspose.CAD ميزة تحميل كائنات رسم [DWF](https://docs.fileformat.com/cad/dwf/) من أوتوكاد وعرضها كرسمة كاملة إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تعمل طريقة تحويل [DWF](https://docs.fileformat.com/cad/dwf/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. تحميل ملف الرسم [DWF](https://docs.fileformat.com/cad/dwf/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين الخصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. إنشاء كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كوسيط ثانٍ.

### نموذج كود

يظهر نموذج الكود أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **استخراج الطبقات من رسم DWF**

تقدم Aspose.CAD ميزة تحميل كائنات رسم [DWF](https://docs.fileformat.com/cad/dwf/) من أوتوكاد وعرضها كرسمة كاملة إلى تنسيق [JPEG](https://docs.fileformat.com/image/jpeg/).

1. تحميل ملف الرسم [DWF](https://docs.fileformat.com/cad/dwf/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء كائن من فئة [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. استخراج أسماء الطبقات باستخدام كائن [JPEG](https://docs.fileformat.com/image/jpeg/).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) كوسيط ثانٍ.

### نموذج كود

يظهر نموذج الكود أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **دعم الطبقات في DWF**

تقدم Aspose.CAD ميزة تحميل كائنات رسم [DWF](https://docs.fileformat.com/cad/dwf/) من أوتوكاد وعرضها كرسمة كاملة إلى تنسيق [JPEG](https://docs.fileformat.com/image/jpeg/).

1. تحميل ملف الرسم [DWF](https://docs.fileformat.com/cad/dwf/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. إضافة الطبقات المطلوبة.
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) كوسيط ثانٍ.

### نموذج كود

يظهر نموذج الكود أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **تصدير رسومات DWF إلى BMP**

تقدم Aspose.CAD ميزة تحميل كائنات رسم [DWF](https://docs.fileformat.com/cad/dwf/) من أوتوكاد وعرضها كرسمة كاملة إلى تنسيق [BMP](https://docs.fileformat.com/image/bmp/). تعمل طريقة تحويل [DWF](https://docs.fileformat.com/cad/dwf/) إلى [BMP](https://docs.fileformat.com/image/bmp/) كما يلي:

1. تحميل ملف الرسم [DWF](https://docs.fileformat.com/cad/dwf/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين الخصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. إنشاء كائن من فئة [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) كوسيط ثانٍ.

### نموذج كود

يظهر نموذج الكود أدناه كيفية تحويل ملف [DWF](https://docs.fileformat.com/cad/dwf/) إلى [BMP](https://docs.fileformat.com/image/bmp/) باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
