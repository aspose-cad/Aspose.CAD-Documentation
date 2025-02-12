---
title: نصب
type: docs
weight: 30
url: /fa/java/installation/
---

## **نصب Aspose.CAD برای جاوا از مخزن Maven**

Aspose تمامی APIهای جاوا را در [مخزن Maven](https://releases.aspose.com/java/repo/com/aspose/) میزبانی می‌کند. شما می‌توانید به راحتی از API [Aspose.CAD برای جاوا](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) به‌طور مستقیم در پروژه‌های Maven خود با پیکربندی‌های ساده استفاده کنید.

### **تعیین پیکربندی مخزن Maven**

اول، باید پیکربندی/محل مخزن Aspose Maven را در فایل pom.xml پروژه Maven خود به صورت زیر مشخص کنید:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>Aspose Java API</name>
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

### **تعریف وابستگی API Aspose.CAD برای جاوا**

سپس وابستگی API Aspose.CAD برای جاوا را در فایل pom.xml خود به صورت زیر تعریف کنید:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

پس از انجام مراحل فوق، وابستگی Aspose.CAD برای جاوا در پروژه Maven شما نهایتاً تعریف خواهد شد.

## **پلتفرم‌های پشتیبانی‌شده**

Aspose.CAD برای جاوا از محبوب‌ترین پلتفرم‌های توسعه و استقرار پشتیبانی می‌کند.

|**ویژگی**|**توضیحات**|
| :- | :- |
|برنامه‌های دسکتاپ|Aspose.CAD برای جاوا می‌تواند برای توسعه برنامه‌های دسکتاپ در MS Windows استفاده شود.|
|برنامه‌های وب سازمانی|Aspose.CAD برای جاوا به‌طور کامل از برنامه‌های وب پشتیبانی می‌کند.|
|لینوکس/یونیکس|Aspose.CAD برای جاوا یک API مستقل از پلتفرم است و می‌تواند در محیط لینوکس و یونیکس کار کند.|

## **نسخه‌های پشتیبانی‌شده جاوا**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
