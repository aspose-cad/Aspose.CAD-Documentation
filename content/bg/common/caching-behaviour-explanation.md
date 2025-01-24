---
title: Обяснение на кеширането на поведението на Aspose.CAD
type: docs
weight: 20
url: /bg/common/caching-behaviour-explanation
---


## **Как Aspose.CAD кешира данни**

Всичкото кеширане, извършено от Aspose.CAD, е напълно автоматично, без необходимост от потребителско участие. Съществуват основно три вида кеширане, всички свързани с шрифтове.

### **Кеш на името на шрифта**

Кешът на името на шрифта се използва, за да се улесни по-бързото стартиране, като предварително обработва всички намерени файлове с шрифтове и компилира списък на имената на шрифтовете, присъстващи в тези файлове, тъй като един файл с шрифт може да съдържа повече от един шрифт. Той се съхранява като временной файл и е с размер, който обикновено е десетки килобайти за повечето системи.

### **Кеш с данни за глифове на шрифта**

Вътрешен кеш на всички глифове, които са били използвани по време на живота на приложението, за да се намали повторното прочитане на действителните файлове с шрифтове на диска по време на последващи експорти. Въпреки това, той ще доведе до постоянно увеличаване на консумацията на памет, ако последващите експорти имат файлове, които се отнасят до нови шрифтове и/или съдържат символи, които не са били срещнати преди. Въпреки това, на практика, дори в цялото тестово существо на Aspose.CAD, с хиляди файлове, включително файлове на различни езици, консумацията на памет е около 200 мегабайта, което не е особено значително за съвременна система.

### **Кеш за резервен шрифт по символ**

Вътрешен кеш, който съхранява шрифтове, които съдържат даден символ за всички символи на Юникод, за да улесни подбора на заместителен шрифт в случай, че шрифтът, предоставен от текстовия елемент в рисунката, не съдържа символ в текстовото съдържание на този елемент. Той се изгражда при първата операция за експортиране по време на живота на приложението и остава до приключване на приложението. На нашите сравнително скромни тестови машини с масивни колекции от шрифтове, използвани в тестовите комплекти, кешът отнема около 30 секунди за изграждане и заема 70 мегабайта. След изграждането, той вече не изисква време и не нараства.