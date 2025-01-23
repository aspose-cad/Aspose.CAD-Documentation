---
title: تصدير تنسيق DGN AutoCAD
type: docs
weight: 50
url: /ar/python-net/exporting-dgn-autocad/
---

## **تصدير تنسيق DGN AutoCAD إلى PDF**

لقد قدمت Aspose.CAD لـ Python API وظيفة تحميل ملف DGN AutoCAD وتحويله إلى تنسيق PDF. **فئة CadImage** تخدم هذا الغرض.

تحتاج إلى تحميل ملف DGN موجود كـ **CadImage**. أنشئ مثيلًا من فئة **CadRasterizationOptions** واضبط خصائص مختلفة. أنشئ مثيلًا من فئة **PdfOptions** ومرر مثيل **CadRasterizationOptions**. الآن، استدعِ طريقة **save** من مثيل فئة **CadImage**.

### عينة من الكود

فيما يلي توضيح الكود لتحويل/تصدير [DGN](https://docs.fileformat.com/cad/dgn/) إلى [PDF](https://docs.fileformat.com/pdf/) .

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}

## **تصدير تنسيق DGN AutoCAD إلى تنسيق صورة نقطية**

لقد قدمت Aspose.CAD لـ Python API وظيفة تحميل ملف DGN AutoCAD وتحويله إلى صورة نقطية. **فئة CadImage** تخدم هذا الغرض.

تحتاج إلى تحميل ملف DGN موجود كـ **CadImage**. أنشئ مثيلًا من فئة **CadRasterizationOptions** واضبط خصائص مختلفة. أنشئ مثيلًا من فئة **JpegOptions** ومرر مثيل **CadRasterizationOptions**. الآن، استدعِ طريقة **save** من مثيل فئة **CadImage**.

### عينة من الكود

فيما يلي توضيح الكود لتحويل/تصدير [DGN](https://docs.fileformat.com/cad/dgn/) إلى صورة [JPEG](https://docs.fileformat.com/image/jpeg/) .

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **دعم الكائنات ثلاثية الأبعاد لتنسيق DGN v7**

لقد قدمت Aspose.CAD لـ Python API وظيفة تحميل ملف [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD ودعم الكائنات ثلاثية الأبعاد لتنسيق DGN v7. **فئة CadImage** تخدم هذا الغرض. تدعم كل صورة [DGN](https://docs.fileformat.com/cad/dgn/) 9 من المناظر المسبقة. يتم ترقيمها من 1 إلى 9. إذا لم يتم تعريف المنظر عند التصدير، بالنسبة لتنسيقات الإخراج متعددة الصفحات (مثل PDF) سيتم تصدير جميع المناظر، كل واحدة في صفحة منفصلة. يتم دعم الكائنات ثلاثية الأبعاد في تنسيق ملف DGN، بالإضافة إلى 2D. لهذا، يتم استخدام **VectorRasterizationOptions**، ولم يعد يُستخدم TypeOfEntities لتنسيق DGN (يدعم كل من 2D و 3D في وقت واحد).

### عينة من الكود

فيما يلي عينة من الكود للنظر في العناصر المدعومة من DGN.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
