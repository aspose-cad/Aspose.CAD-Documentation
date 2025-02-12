---
title: چگونه نمونه‌ها را اجرا کنیم
type: docs
weight: 70
url: /fa/java/getting-started/how-to-run-the-examples/
---

## **دانلود از گیت‌هاب**

تمام نمونه‌های Aspose.CAD برای Java در [گیت‌هاب](https://github.com/aspose-cad/Aspose.CAD-for-Java) میزبانی می‌شوند. شما می‌توانید با استفاده از کلاینت گیت‌هاب مورد علاقه‌تان، مخزن را کلون کنید یا فایل ZIP را از [اینجا](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip) دانلود کنید.

محتویات فایل ZIP را در هر پوشه‌ای در رایانه خود استخراج کنید. تمام نمونه‌ها در پوشه **Examples** قرار دارند.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**شکل: دایرکتوری نمونه‌های Aspose.CAD**|

## **وارد کردن نمونه‌ها به IDE**

این پروژه از سیستم ساخت Maven استفاده می‌کند. هر IDE مدرن می‌تواند به راحتی پروژه و وابستگی‌های آن را باز یا وارد کند. در زیر نشان می‌دهیم که چگونه از IDEهای محبوب برای ساخت و اجرای نمونه‌ها استفاده کنیم.

### **IntelliJ IDEA**

روی منوی **File** کلیک کنید و **Open** را انتخاب کنید. به پوشه پروژه بروید و فایل **pom.xml** را انتخاب کنید.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**شکل: انتخاب فایل یا دایرکتوری برای وارد کردن**|
پروژه باز خواهد شد و وابستگی‌ها به طور خودکار دانلود می‌شوند. از تب پروژه، نمونه‌ها را در پوشه **src/main/java** مشاهده کنید. برای اجرای یک نمونه، کافی است روی فایل راست کلیک کرده و "Run .." را انتخاب کنید، نمونه اجرا خواهد شد و خروجی در پنجره خروجی کنسول داخلی نشان داده می‌شود.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**شکل: اجرای نمونه**|

### **Eclipse**

روی منوی **File** کلیک کرده و **Import** را انتخاب کنید. **Maven** - Existing Maven Projects را انتخاب کنید.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**شکل: وارد کردن**|
به پوشه‌ای که از گیت‌هاب کلون کرده‌اید یا دانلود کرده‌اید بروید و فایل **pom.xml** را انتخاب کنید. پروژه باز خواهد شد و وابستگی‌ها به طور خودکار دانلود می‌شوند. از تب Package Explorer، نمونه‌ها را در پوشه **src/main/java** مشاهده کنید. برای اجرای یک نمونه، کافی است روی فایل راست کلیک کرده و **Run As** - **Java Application** را انتخاب کنید، نمونه اجرا خواهد شد و خروجی در پنجره خروجی کنسول داخلی نشان داده می‌شود.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**شکل: اجرای نمونه**|

### **NetBeans**

روی منوی **File** کلیک کرده و **Open Project** را انتخاب کنید. به پوشه‌ای که از گیت‌هاب کلون کرده‌اید یا دانلود کرده‌اید بروید. نماد پوشه **Examples** نشان می‌دهد که این یک پروژه Maven است. Examples را انتخاب کرده و باز کنید.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**شکل: باز کردن پروژه**|
پروژه باز خواهد شد و وابستگی‌ها به طور خودکار دانلود می‌شوند. از تب Projects، نمونه‌ها را در **source packages** مشاهده کنید. برای اجرای یک نمونه، کافی است روی فایل راست کلیک کرده و **Run File** را انتخاب کنید، نمونه اجرا خواهد شد و خروجی در پنجره خروجی کنسول داخلی نشان داده می‌شود.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**شکل: اجرای نمونه**|

## **افزودن کتابخانه Aspose.CAD به مخزن محلی Maven**

زمانی که پروژه **Aspose.CAD Examples** را به IDE وارد می‌کنید، Maven به طور خودکار فایل JAR aspose.cad را از [Aspose Maven Repository](https://releases.aspose.com/java/repo/) دانلود می‌کند. در صورتی که به اینترنت دسترسی ندارید، می‌توانید به طور دستی JAR را به مخزن محلی خود اضافه کنید.

### **mvn install**

[aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) را دانلود کنید، آن را استخراج کرده و فایل aspose.cad-version.jar را به مکان دیگری، برای مثال در درایو C کپی کنید. فرمان زیر را صادر کنید:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

اکنون، فایل JAR **aspose.cad** به مخزن محلی Maven شما کپی شده است.

### **pom.xml**

پس از نصب، فقط مختصات **aspose.cad** را در pom.xml اعلام کنید.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **تمام شد**

این را بسازید، اکنون فایل JAR **aspose.cad** قادر به بازیابی از مخزن محلی Maven شما است.

## **مشارکت**

اگر می‌خواهید نمونه‌ای را اضافه کنید یا بهبود بخشید، ما شما را به مشارکت در پروژه تشویق می‌کنیم. تمام نمونه‌ها و پروژه‌های نمایشی در این مخزن منبع باز هستند و می‌توانند به طور آزاد در برنامه‌های خود استفاده شوند.

برای مشارکت، می‌توانید مخزن را فورک کنید، کد منبع را ویرایش کنید و یک Pull Request ارسال کنید. ما تغییرات را بررسی خواهیم کرد و اگر مفید بود، آن را در مخزن قرار خواهیم داد.
