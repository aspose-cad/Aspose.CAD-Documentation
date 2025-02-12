---
title: كيفية تشغيل الأمثلة
type: docs
weight: 70
url: /ar/java/getting-started/how-to-run-the-examples/
---

## **تحميل من GitHub**

جميع أمثلة Aspose.CAD لـ Java موجودة على [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). يمكنك إما استنساخ المستودع باستخدام عميل Github المفضل لديك أو تنزيل ملف ZIP من [هنا](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

استخرج محتويات ملف ZIP إلى أي مجلد على جهاز الكمبيوتر الخاص بك. جميع الأمثلة موجودة في مجلد **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**الشكل: دليل أمثلة Aspose.CAD**|

## **استيراد الأمثلة إلى بيئة التطوير المتكاملة**

يستخدم المشروع نظام بناء Maven. يمكن لأي بيئة تطوير متكاملة حديثة فتح أو استيراد المشروع بسهولة ومكتباته. أدناه نوضح لك كيفية استخدام بيئات التطوير المتكاملة الشائعة لبناء وتشغيل الأمثلة.

### **IntelliJ IDEA**

انقر على قائمة **File** واختر **Open**. انتقل إلى مجلد المشروع وحدد ملف **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**الشكل: تحديد ملف أو دليل للاستيراد**|

سيفتح المشروع ويقوم بتنزيل المكتبات تلقائيًا. من علامة تبويب المشروع، تصفح الأمثلة في مجلد **src/main/java**. لتشغيل مثال، انقر بزر الماوس الأيمن على الملف واختر "Run .."، سيتم تنفيذ المثال وسيظهر الناتج في نافذة الإخراج المدمجة.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**الشكل: تشغيل المثال**|

### **Eclipse**

انقر على قائمة **File** واختر **Import**. اختر **Maven** - مشاريع Maven الموجودة.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**الشكل: استيراد**|

انتقل إلى المجلد الذي قمت باستنساخه أو تنزيله من GitHub وحدد ملف **pom.xml**. سيفتح المشروع ويقوم بتنزيل المكتبات تلقائيًا. من علامة تبويب Package Explorer، تصفح الأمثلة في مجلد **src/main/java**. لتشغيل مثال، انقر بزر الماوس الأيمن على الملف واختر **Run As** - **Java Application**، سيتم تنفيذ المثال وسيظهر الناتج في نافذة الإخراج المدمجة.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**الشكل: تشغيل المثال**|

### **NetBeans**

انقر على قائمة **File** واختر **Open Project**. انتقل إلى المجلد الذي قمت باستنساخه أو تنزيله من GitHub. سيظهر رمز مجلد **Examples** أنه مشروع Maven. حدد Examples وافتحه.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**الشكل: فتح المشروع**|

سيفتح المشروع ويقوم بتنزيل المكتبات تلقائيًا. من علامة تبويب Projects، تصفح الأمثلة في **source packages**. لتشغيل مثال، انقر بزر الماوس الأيمن على الملف واختر **Run File**، سيتم تنفيذ المثال وسيظهر الناتج في نافذة الإخراج المدمجة.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**الشكل: تشغيل المثال**|

## **إضافة مكتبة Aspose.CAD إلى مستودع Maven المحلي**

عند استيراد مشروع **Aspose.CAD Examples** إلى بيئة التطوير المتكاملة، يقوم Maven تلقائيًا بتنزيل ملف JAR الخاص بـ aspose.cad من [Aspose Maven Repository](https://releases.aspose.com/java/repo/). في حال لم يكن لديك وصول إلى الإنترنت، يمكنك إضافة ملف JAR يدويًا إلى مستودعك المحلي.

### **mvn install**

قم بتنزيل [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) ، واستخرج منه وانسخ aspose.cad-version.jar إلى مكان آخر، على سبيل المثال، القرص C. أصدِر الأمر التالي:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

الآن، تم نسخ ملف **aspose.cad** JAR إلى مستودع Maven المحلي الخاص بك.

### **pom.xml**

بعد التثبيت، فقط قم بتعريف إحداثيات **aspose.cad** في pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **تم**

قم ببنائها، الآن يمكن استرداد ملف **aspose.cad** JAR من مستودع Maven المحلي الخاص بك.

## **المساهمة**

إذا كنت ترغب في إضافة أو تحسين مثال، نشجعك على المساهمة في المشروع. جميع الأمثلة ومشاريع العرض في هذا المستودع مفتوحة المصدر ويمكن استخدامها بحرية في تطبيقاتك الخاصة.

للمساهمة، يمكنك استنساخ المستودع، وتحرير الشيفرة المصدرية ويمكنك تقديم طلب سحب. سنقوم بمراجعة التغييرات وإدراجها في المستودع إذا وُجدت مفيدة.
