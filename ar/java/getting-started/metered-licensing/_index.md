---
title: الترخيص المقنن
type: docs
weight: 60
url: /ar/java/metered-licensing/
---

{{% alert color="primary" %}} 

تسمح Aspose.CAD للمطورين بتطبيق مفتاح مقنن. إنها آلية ترخيص جديدة. ستستخدم آلية الترخيص الجديدة مع طريقة الترخيص الحالية. يمكن للعملاء الذين يرغبون في أن يتم فواتيرهم بناءً على استخدام ميزات واجهة برمجة التطبيقات استخدام الترخيص المقنن. لمزيد من التفاصيل، يُرجى الرجوع إلى قسم [الأسئلة الشائعة حول الترخيص المقنن](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **الترخيص المقنن**
فيما يلي الخطوات البسيطة لاستخدام فئة Metered.

1. أنشئ مثيلاً لفئة Metered.
1. مرر المفاتيح العامة والخاصة إلى طريقة setMeteredKey.
1. قم بمعالجة (نفذ المهمة).
1. استدعِ طريقة getConsumptionQuantity لفئة Metered.
1. ستعيد كمية طلبات API التي استهلكتها حتى الآن.

فيما يلي نموذج للشفرة يوضح كيفية تعيين المفتاحين العام والخاص المقننين:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
