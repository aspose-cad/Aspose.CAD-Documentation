---
title: Лицензиране
type: docs
weight: 50
url: /bg/java/licensing/
---

{{% alert color="primary" %}}

Можете да изтеглите оценъчна версия на **Aspose.CAD** за Java от [нейната страница за изтегляне](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Оценъчната версия предоставя абсолютно същите възможности като лицензираната версия на продукта. Освен това, оценъчната версия просто става лицензирана, когато закупите лиценз и добавите няколко реда код, за да приложите лиценза.

След като сте доволни от вашата оценка на **Aspose.CAD**, можете да [закупите лиценз](https://purchase.aspose.com/buy) на сайта на Aspose. Запознайте се с различните видове абонаменти, предлагани. Ако имате въпроси, не се колебайте да се свържете с екипа за продажби на Aspose.

Всеки лиценз на Aspose носи едногодишен абонамент за безплатни актуализации до всякакви нови версии или корекции, които излизат през това време. Техническата поддръжка е безплатна и неограничена и се предоставя както на лицензирани, така и на оценъчни потребители.

{{% /alert %}}

Ако искате да тествате **Aspose.CAD** без ограничения на оценъчната версия, поискайте 30-дневен временный лиценз. Моля, прочетете [Как да получите временный лиценз?](https://purchase.aspose.com/temporary-license) за повече информация.

## **Настройка на лиценз**

Лицензът е обикновен текстов XML файл, който съдържа подробности като име на продукта, брой разработчици, на които е лицензиран, дата на изтичане на абонамента и т.н. Файлът е цифрово подписан, затова не променяйте файла; дори случайното добавяне на допълнителен ред ще го направи невалиден.

Трябва да зададете лиценз преди да извършвате каквито и да е операции с AutoCAD файлове. Обикновено е нужно да зададете лиценз само веднъж за приложение или процес.

Лицензът може да бъде зареден от поток или файл в следните местоположения:

1. Ясен път.
1. Папката, която съдържа Aspose.CAD.jar.

Използвайте метода License.setLicense(), за да лицензирате компонента. Често най-лесният начин да зададете лиценз е да поставите лицензионния файл в същата папка като Aspose.CAD.jar и да посочите само името на файла без път, както е показано в следния пример:

### **Пример 1**

В този пример **Aspose.CAD** ще се опита да намери лицензионния файл в папката, която съдържа JAR файловете на вашето приложение.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Пример 2**

Инициализира лиценз от поток.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Валидирайте лиценза**

Възможно е да се провери дали лицензът е зададен правилно или не. Класът License има полето isLicensed, което ще върне true, ако лицензът е зададен правилно.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Лицензът е зададен!");

}

{{< /highlight >}}