---
title: التثبيت
type: docs
weight: 30
url: /ar/java/installation/
---

## **تثبيت Aspose.CAD لjava من مستودع Maven**

تستضيف Aspose جميع واجهات برمجة التطبيقات Java على [مستودع Maven](https://releases.aspose.com/java/repo/com/aspose/). يمكنك استخدام [Aspose.CAD لjava](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API مباشرة في مشاريع Maven الخاصة بك مع تكوينات بسيطة.

### **تحديد تكوين مستودع Maven**

أولاً، تحتاج إلى تحديد تكوين / موقع مستودع Aspose Maven في ملف pom.xml الخاص بك كما يلي:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>واجهة برمجة تطبيقات Aspose Java</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **تحديد اعتماد واجهة برمجة تطبيقات Aspose.CAD لjava**

ثم حدد اعتماد واجهة برمجة التطبيقات Aspose.CAD لjava في ملف pom.xml الخاص بك كما يلي:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

بعد تنفيذ الخطوات أعلاه، سيتم أخيرًا تعريف اعتماد Aspose.CAD لjava في مشروع Maven الخاص بك.

## **المنصات المدعومة**

يدعم Aspose.CAD لjava أشهر منصات التطوير والنشر.

|**الميزة**|**الوصف**|
| :- | :- |
|تطبيقات سطح المكتب|يمكن استخدام Aspose.CAD لjava لتطوير تطبيقات سطح المكتب في نظام MS Windows.|
|تطبيقات الويب المؤسسية|يدعم Aspose.CAD لjava تمامًا تطبيقات الويب.|
|Linux/Unix|Aspose.CAD لjava هو واجهة برمجة تطبيقات مستقلة عن النظام ويمكن أن تعمل في بيئة Linux و Unix.|

## **إصدارات Java المدعومة**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
