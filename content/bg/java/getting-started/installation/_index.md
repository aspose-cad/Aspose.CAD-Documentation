---
title: Инсталация
type: docs
weight: 30
url: /bg/java/getting-started/installation/
---

## **Инсталиране на Aspose.CAD за Java от Maven хранилище**

Aspose хоства всички Java API на [Maven хранилище](https://releases.aspose.com/java/repo/com/aspose/). Можете лесно да използвате [Aspose.CAD за Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API директно в проектите си Maven с прости конфигурации.

### **Определете конфигурацията на Maven хранилище**

Първо, трябва да посочите конфигурацията/местоположението на Aspose Maven хранилище в pom.xml на Вашия Maven, както следва:

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

### **Определяне на зависимостта Aspose.CAD за Java API**

След това определете зависимостта Aspose.CAD за Java API в pom.xml на Вашия проект, както следва:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

След изпълнението на горепосочените стъпки, зависимостта Aspose.CAD за Java ще бъде окончателно определена във Вашия Maven проект.

## **Поддържани платформи**

Aspose.CAD за Java поддържа най-популярните платформи за разработка и внедряване.

|**Функция**|**Описание**|
| :- | :- |
|Десктоп приложения|Aspose.CAD за Java може да се използва за разработка на десктоп приложения в MS Windows.|
|Корпоративни уеб приложения|Aspose.CAD за Java напълно поддържа уеб приложения.|
|Linux/Unix|Aspose.CAD за Java е платформа-независим API и може да работи в среда Linux и Unix.|

## **Поддържани версии на Java**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
