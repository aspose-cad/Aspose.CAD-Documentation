---
title: ส่งออกไปยังรูปแบบ PDF/A
type: docs
weight: 33
url: /th/net/developer-guide/how-to/export-to-pdfa-format/
---

## **วิธีการส่งออกไปยังรูปแบบ PDF/A**

**ปัญหา:** วิธีการส่งออกไปยังรูปแบบ PDF/A (CADNET-281).

**เคล็ดลับ:** เพื่อทำเช่นนี้ ให้สร้าง pdfOptions.CorePdfOptions และตั้งค่า pdfOptions.CorePdfOptions.Compliance เป็น Aspose.CAD.ImageOptions.PdfCompliance.PdfA1a.

**ตัวอย่าง:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-pdfa-format.cs" >}}
