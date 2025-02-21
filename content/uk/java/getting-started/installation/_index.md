---
title: Встановлення
type: docs
weight: 30
url: /uk/java/getting-started/installation/
---

## **Встановлення Aspose.CAD для Java з репозиторію Maven**

Aspose хостить всі Java API в [репозиторії Maven](https://releases.aspose.com/java/repo/com/aspose/). Ви можете легко використовувати [Aspose.CAD для Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API безпосередньо у ваших Maven проектах з простими конфігураціями.

### **Вкажіть конфігурацію репозиторію Maven**

Спочатку вам потрібно вказати конфігурацію/місцезнаходження репозиторію Aspose Maven у вашому pom.xml таким чином:

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

### **Визначте залежність API Aspose.CAD для Java**

Потім визначте залежність API Aspose.CAD для Java у вашому pom.xml таким чином:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Після виконання вказаних вище кроків, залежність Aspose.CAD для Java нарешті буде визначена у вашому Maven проекті.

## **Підтримувані платформи**

Aspose.CAD для Java підтримує найпопулярніші платформи розробки та розгортання.

|**Особливість**|**Опис**|
| :- | :- |
|Десктопні додатки|Aspose.CAD для Java може використовуватися для розробки десктопних додатків у MS Windows.|
|Корпоративні веб-додатки|Aspose.CAD для Java повністю підтримує веб-додатки.|
|Linux/Unix|Aspose.CAD для Java є платформонезалежним API і може працювати в середовищі Linux та Unix.|

## **Підтримувані версії Java**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
