---
title: Як запустити приклади
type: docs
weight: 70
url: /uk/java/getting-started/how-to-run-the-examples/
---

## **Завантажити з GitHub**

Всі приклади Aspose.CAD для Java розміщені на [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Ви можете або клонувати репозиторій, використовуючи улюблений клієнт Github, або завантажити ZIP-файл [тут](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Витягніть вміст ZIP-файлу в будь-яку папку на вашому комп'ютері. Всі приклади знаходяться в папці **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Рисунок: Директорія прикладів Aspose.CAD**|

## **Імпорт прикладів в IDE**

Проект використовує систему складання Maven. Будь-яка сучасна IDE може легко відкрити або імпортувати проект і його залежності. Нижче ми покажемо, як використовувати популярні IDE для збірки та запуску прикладів.

### **IntelliJ IDEA**

Натисніть на меню **File** і виберіть **Open**. Перейдіть до папки проекту та виберіть файл **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Рисунок: Вибір файлу або директорії для імпорту**|
Це відкриє проект і автоматично завантажить залежності. У вкладці Project знайдіть приклади у папці **src/main/java**. Щоб запустити приклад, просто клацніть правою кнопкою миші на файл і виберіть "Run ..", приклад буде виконано, а вивід буде показано у вбудованому вікні консолі.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Рисунок: Запустити приклад**|

### **Eclipse**

Натисніть на меню **File** і виберіть **Import**. Виберіть **Maven** - Існуючі проекти Maven.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Рисунок: Імпорт**|
Перейдіть до папки, яку ви клонували або завантажили з GitHub, і виберіть файл **pom.xml**. Це відкриє проект і автоматично завантажить залежності. У вкладці Package Explorer знайдіть приклади у папці **src/main/java**. Щоб запустити приклад, просто клацніть правою кнопкою миші на файл і виберіть **Run As** - **Java Application**, приклад буде виконано, а вивід буде показано у вбудованому вікні консолі.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Рисунок: Запустити приклад**|

### **NetBeans**

Натисніть на меню **File** і виберіть **Open Project**. Перейдіть до папки, яку ви клонували або завантажили з GitHub. Іконка папки **Examples** покаже, що це проект Maven. Виберіть Examples і відкрийте його.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Рисунок: Відкрити проект**|
Це відкриє проект і автоматично завантажить залежності. У вкладці Projects знайдіть приклади у **source packages**. Щоб запустити приклад, просто клацніть правою кнопкою миші на файл і виберіть **Run File**, приклад буде виконано, а вивід буде показано у вбудованому вікні консолі.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Рисунок: Запустити приклад**|

## **Додавання бібліотеки Aspose.CAD у локальний репозиторій Maven**

Коли ви імпортуєте проект **Aspose.CAD Examples** в IDE, Maven автоматично завантажує JAR-файл aspose.cad з [Aspose Maven Repository](https://releases.aspose.com/java/repo/). У разі, якщо у вас немає доступу до інтернету, ви можете вручну додати JAR у свій локальний репозиторій.

### **mvn install**

Завантажте [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), витягніть його та скопіюйте aspose.cad-version.jar кудись ще, наприклад, на диск C. Виконайте таку команду:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Тепер JAR-файл **aspose.cad** скопійовано до вашого локального репозиторію Maven.

### **pom.xml**

Після установки просто оголосіть координати **aspose.cad** у pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Готово**

Зберіть проект, тепер JAR-файл **aspose.cad** готовий до отримання з вашого локального репозиторію Maven.

## **Сприяти**

Якщо ви хочете додати або покращити приклад, ми заохочуємо вас внести вклад у проект. Всі приклади та показові проекти в цьому репозиторії є відкритими і можуть бути вільно використані у ваших власних додатках.

Щоб внести вклад, ви можете форкнути репозиторій, редагувати вихідний код і подати запит на злиття. Ми переглянемо зміни і включимо їх у репозиторій, якщо вони виявляться корисними.
