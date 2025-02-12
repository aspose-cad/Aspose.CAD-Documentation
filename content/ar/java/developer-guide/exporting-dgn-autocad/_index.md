---
title: تصدير تنسيق DGN لـ AutoCAD
type: docs
weight: 50
url: /ar/java/developer-guide/exporting-dgn-autocad/
---

## **تصدير تنسيق DGN لـ AutoCAD إلى PDF**

قدمت Aspose.CAD لواجهة برمجة التطبيقات Java إمكانية تحميل ملف [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD وتحويله إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تستخدم فئة [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) لهذه الغرض.

تحتاج إلى تحميل ملف DGN موجود كـ [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). قم بإنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) وقم بتعيين الخصائص المختلفة. قم بإنشاء مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) وقم بتمرير مثيل [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). الآن قم باستدعاء طريقة [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) من مثيل فئة [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### نموذج كود

فيما يلي عرض الكود لتحويل/تصدير DGN إلى تنسيق PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **تصدير تنسيق DGN لـ AutoCAD إلى تنسيق صورة نقطية**

قدمت Aspose.CAD لواجهة برمجة التطبيقات Java إمكانية تحميل ملف [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD وتحويله إلى صورة نقطية. تستخدم فئة [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) لهذه الغرض.

تحتاج إلى تحميل ملف DGN موجود كـ [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). قم بإنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) وقم بتعيين الخصائص المختلفة. قم بإنشاء مثيل من فئة [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) وقم بتمرير مثيل [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). الآن قم باستدعاء طريقة [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) من مثيل فئة [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### نموذج كود

فيما يلي عرض الكود لتحويل/تصدير [DGN](https://docs.fileformat.com/cad/dgn/) إلى صورة [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
