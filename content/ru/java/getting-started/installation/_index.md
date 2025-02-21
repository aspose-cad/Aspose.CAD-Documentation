---
title: Установка
type: docs
weight: 30
url: /ru/java/getting-started/installation/
---

## **Установка Aspose.CAD для Java из Maven Repository**

Aspose размещает все Java API в [Maven репозитории](https://releases.aspose.com/java/repo/com/aspose/). Вы можете легко использовать [Aspose.CAD для Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API напрямую в ваших Maven проектах с простыми конфигурациями.

### **Укажите конфигурацию Maven Repository**

Сначала вам нужно указать конфигурацию/расположение Aspose Maven Repository в вашем pom.xml как показано ниже:

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

### **Определите зависимость Aspose.CAD для Java API**

Затем определите зависимость Aspose.CAD для Java API в вашем pom.xml как показано ниже:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

После выполнения вышеперечисленных шагов, зависимость Aspose.CAD для Java будет в конечном итоге определена в вашем Maven проекте.

## **Поддерживаемые платформы**

Aspose.CAD для Java поддерживает наиболее популярные платформы разработки и развертывания.

|**Функция**|**Описание**|
| :- | :- |
|Десктопные приложения|Aspose.CAD для Java можно использовать для разработки десктопных приложений на MS Windows.|
|Корпоративные веб-приложения|Aspose.CAD для Java полностью поддерживает веб-приложения.|
|Linux/Unix|Aspose.CAD для Java является независимым от платформы API и может работать в среде Linux и Unix.|

## **Поддерживаемые версии Java**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
