---
title: کار با متن
type: docs
weight: 40
url: /fa/net/work-with-text/
---

## **کار با متن**

تقریباً تمام نقاشی‌ها شامل اشیاء متنی هستند و این مثال‌ها نشان می‌دهند که چگونه می‌توان عملیات مختلفی را با آن‌ها انجام داد. 
انواع مختلفی از موجودیت‌ها برای DWG/DXF وجود دارد که می‌توانند متن را ذخیره کنند، این‌ها هستند [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/)، 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/)،
CadAttDef، CadAttrib. دو نوع آخر معمولاً مربوط به 
[**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
هستند و درون آن یا در بلوک مربوطه ذخیره می‌شوند.

در اینجا چند مثال وجود دارد که عملیات با متن را توصیف می‌کند.

### **جستجوی متن**

این مثال نشان می‌دهد که چگونه می‌توان مقادیر متنی را در فایل DWG/DXF پیدا کرد و ممکن است همچنین برای جایگزینی مقادیر متنی استفاده شود.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **اضافه کردن اشیاء جدید Text و MText**

این مثال نشان می‌دهد چگونه می‌توان اشیاء جدید Text/MText را به نقاشی اضافه کرد. اضافه کردن موجودیت‌های جدید ممکن است اندازه نقاشی را تغییر دهد، بنابراین توصیه می‌شود 
پس از این عملیات‌ها، UpdateSize() را فراخوانی کنید.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
