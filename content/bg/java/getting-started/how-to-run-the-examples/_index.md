---
title: Как да стартирате примерите
type: docs
weight: 70
url: /bg/java/getting-started/how-to-run-the-examples/
---

## **Изтегляне от GitHub**

Всички примери на Aspose.CAD за Java са хоствани на [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Можете или да клонирате репозитория с любимия си клиент на Github, или да изтеглите ZIP файла от [тук](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Разархивирайте съдържанието на ZIP файла в желаната папка на компютъра си. Всички примери се намират в папката **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Фигура: Директория на примери на Aspose.CAD**|

## **Импортиране на примери в IDE**

Проектът използва Maven система за изграждане. Всяка съвременна IDE може лесно да отвори или импортира проекта и зависимостите му. По-долу ви показваме как да използвате популярни IDE за изграждане и стартиране на примерите.

### **IntelliJ IDEA**

Кликнете върху менюто **File** и изберете **Open**. Придвижете се до папката на проекта и изберете файла **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Фигура: Изберете файл или директория за импортиране**|
Това ще отвори проекта и автоматично ще изтегли зависимостите. От таба с Проекти, преминете през примерите в папката **src/main/java**. За да стартирате пример, просто кликнете с десен бутон върху файла и изберете "Run ..", примерът ще бъде изпълнен, а изходът ще бъде показан в интегрирания конзолен изход.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Фигура: Стартиране на пример**|

### **Eclipse**

Кликнете върху менюто **File** и изберете **Import**. Изберете **Maven** - Съществуващи Maven проекти.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Фигура: Импорт**|
Придвижете се до папката, която сте клонирали или изтеглили от GitHub, и изберете файла **pom.xml**. То ще отвори проекта и автоматично ще изтегли зависимостите. От таба Package Explorer, преминете през примерите в папката **src/main/java**. За да стартирате пример, просто кликнете с десен бутон върху файла и изберете **Run As** - **Java Application**, примерът ще бъде изпълнен, а изходът ще бъде показан в интегриния конзолен изход.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Фигура: Стартиране на пример**|

### **NetBeans**

Кликнете върху менюто **File** и изберете **Open Project**. Придвижете се до папката, която сте клонирали или изтеглили от GitHub. Иконата на папката **Examples** ще покаже, че е Maven проект. Изберете Examples и го отворете.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Фигура: Отваряне на проект**|
То ще отвори проекта и автоматично ще изтегли зависимостите. От таба Projects, преминете през примерите в **source packages**. За да стартирате пример, просто кликнете с десен бутон върху файла и изберете **Run File**, примерът ще бъде изпълнен, а изходът ще бъде показан в интегриния конзолен изход.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Фигура: Стартиране на пример**|

## **Добавяне на библиотеката Aspose.CAD в локалното хранилище на Maven**

Когато импортирате проекта **Aspose.CAD Examples** в IDE, Maven автоматично изтегля JAR файла на aspose.cad от [Aspose Maven Repository](https://releases.aspose.com/java/repo/). В случай, че нямате достъп до интернет, можете ръчно да добавите JAR във вашето локално хранилище.

### **mvn install**

Изтеглете [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), извлечете го и копирайте aspose.cad-version.jar на друго място, например на диск C. Изпълнете следната команда:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Сега JAR файлът **aspose.cad** е копиран в локалното хранилище на Maven.

### **pom.xml**

След инсталирането просто декларайте координатите на **aspose.cad** в pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Готово**

Изградете го, сега JAR файлът **aspose.cad** може да бъде извлечен от вашето локално хранилище на Maven.

## **Принос**

Ако искате да добавите или подобрите пример, насърчаваме ви да направите принос към проекта. Всички примери и демонстрационни проекти в този репозиторий са с отворен код и могат да бъдат свободно използвани във вашите приложения.

За да направите принос, можете да форкнете репозитория, да редактирате изходния код и да подадете Pull Запитване. Ние ще прегледаме промените и ще ги включим в репозитория, ако ги сметнем за полезни.
