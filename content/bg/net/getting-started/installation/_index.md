---
title: Инсталация
type: docs
weight: 30
url: /bg/net/getting-started/installation/
---

## **Инсталиране на Aspose.CAD за .NET чрез NuGet**

NuGet е най-лесният начин да изтеглите и инсталирате Aspose API за .NET. Отворете Microsoft Visual Studio и NuGet пакетен мениджър. Търсете "aspose", за да намерите желаното Aspose API. Щракнете върху "Инсталирай", избраното API ще бъде изтеглено и добавено към вашия проект.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Справяне с Aspose.CAD от .NET проект**

Следвайте тези стъпки (предполага се, че използвате Microsoft Visual Studio):

1. В **Explorer на решения** разширете възела на проекта, към който искате да добавите справка.
1. Щракнете с десния бутон на мишката върху възела **Справки** за проекта и изберете **Добавяне на справка** от контекстното меню.
1. В диалоговия прозорец **Добавяне на справка** прегледайте местоположението на DLL файла.
1. Изберете DLL файла *Aspose.CAD* и щракнете върху бутона **ОК**.
1. Справката *Aspose.CAD* ще се появи под възела **Справки** на вашия проект.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Инсталирайте или актуализирайте Aspose.CAD с помощта на конзолата на пакетния мениджър**

Можете да следвате стъпките по-долу, за да направите справка към [Aspose.CAD API](https://www.nuget.org/packages/Aspose.CAD/) с помощта на конзолата на пакетния мениджър:

1. Отворете решението/проекта си в Visual Studio.
1. Изберете Инструменти -> Мениджър на библиотеки -> Конзола на пакетния мениджър от менюто, за да отворите конзолата на пакетния мениджър.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

Напишете командата “**Install-Package Aspose.CAD**” и натиснете enter, за да инсталирате най-новото пълно издание във вашето приложение. Алтернативно, можете да добавите суфикса "**-prerelease**" към командата, за да укажете, че най-новото издание, включващоhotfix-ове, също трябва да бъде инсталирано.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

Ще видите, че съобщението "Изтегляне на Aspose.CAD..." се появява долу вляво на прозореца, което показва, че изтеглянето е в процес.

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

След като е изтеглено, ще видите следните съобщения за потвърждение. Ако не сте запознати с [EULA на Aspose](https://about.aspose.com/legal/eula), добра идея е да прочетете лиценза, посочен в URL адреса.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

Сега би трябвало да намерите, че Aspose.CAD е успешно добавен и поиска в приложението ви.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

В конзолата на пакетния мениджър можете също да използвате командата “**Update-Package Aspose.CAD**” и натиснете enter, за да проверите дали има актуализации за пакета Aspose.CAD и да ги инсталирате, ако са налични. Можете също да добавите суфикса "-prerelease", за да актуализирате най-новото издание.

## **Разглеждания при работа в среда с общ сървър**

Всички компоненти на Aspose .NET се препоръчват да работят с разрешителен набор за Пълен достъп. Това е така, защото компонентът Aspose .NET понякога трябва да получи достъп до настройки на регистъра и файлове, разположени на места, различни от виртуалната директория, например за четене на шрифтове и т.н. Освен това компонентите на Aspose.NET са основани на основни класове на системата .NET, някои от които също изискват разрешение за Пълен достъп, за да работят в определени случаи.

Доставчиците на интернет услуги, хостващи множество приложения от различни компании, обикновено налагат ниво на сигурност Средно доверие. В случая с .NET 2.0, такова ниво на сигурност може да наложи следните ограничения, които биха могли да повлияят на способността на Aspose.CAD да работи правилно.

- **RegistryPermission** не е налична. Това означава, че не можете да получите достъп до регистъра, което е необходимо за изброяване на инсталираните шрифтове при рендиране на документи.
- **FileIOPermission** е ограничен. Това означава, че можете да осъществявате достъп само до файлове във виртуалната директория на вашето приложение. Това потенциално означава, че шрифтовете не могат да бъдат прочетени по време на експортиране.

По тези причини, посочени по-горе, се препоръчва Aspose.CAD да се изпълнява с разрешения за Пълен достъп. Можете да откриете, че някои функции на библиотеката ще работят, когато извършвате различни задачи в Средно доверие, докато други няма да се (например рендиране), което може да се дължи на повиквания към GDI+ за обработка на изображения.

## **Системни изисквания**

### **Операционни системи**

Aspose.CAD за .NET поддържа всяка 32-битова или 64-битова операционна система, където е инсталиран .NET или Mono фреймуърк, включително, но не само:

- Работни станции на Microsoft Windows (XP, Vista, 7, 8, 10) и сървърни операционни системи (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS и др.)
- Mac OS X

### **Фреймуъркове**

Aspose.CAD за .NET поддържа:

- Версии на .NET Framework от 2.0 до 4.5, включително версиите на Client Profile
- .NET Core
- Mono 2.6.7 или по-късно

### **Развойни среди**

Можете да използвате Aspose.CAD за .NET, за да разработвате приложения в която и да е развойна среда, която цели платформата .NET, но следните среди са изрично поддържани:

- Microsoft Visual Studio 2010 или по-висока
- MonoDevelop 2.4 и по-късно
