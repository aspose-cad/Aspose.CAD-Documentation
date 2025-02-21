---
title: ตั้งเวลาในขณะบันทึก
type: docs
weight: 70
url: /th/java/developer-guide/set-timeout-on-save/
---

## **ตั้งเวลาในขณะบันทึก**

Aspose.CAD สำหรับ Java API ช่วยให้คุณสามารถตั้งเวลาในขณะบันทึกได้ ซึ่งอาจเป็นประโยชน์ในกรณีที่กระบวนการบันทึกใช้เวลานานหรือใช้หน่วยความจำมากเกินไป สำหรับเรื่องนี้ API จะให้ [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) class ซึ่ง [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) class จะให้โทเคนที่ใช้เพื่อหยุดการดำเนินการที่ยาวนาน

## ตัวอย่างโค้ด

โค้ดตัวอย่างด้านล่างแสดงการใช้ [**InterruptionTokenSource**](https://reference.aspose.com/cad/java/com.aspose.cad/InterruptionTokenSource) class

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-PutTimeoutOnSave-1.java" >}}
