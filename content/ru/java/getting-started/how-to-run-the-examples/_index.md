---
title: Как запустить примеры
type: docs
weight: 70
url: /ru/java/getting-started/how-to-run-the-examples/
---

## **Скачивание с GitHub**

Все примеры Aspose.CAD для Java размещены на [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Вы можете либо клонировать репозиторий, используя ваш любимый клиент GitHub, либо скачать ZIP-файл [отсюда](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Извлеките содержимое ZIP-файла в любую папку на вашем компьютере. Все примеры находятся в папке **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Рисунок: Директория примеров Aspose.CAD**|

## **Импорт примеров в IDE**

Проект использует систему сборки Maven. Любая современная IDE может легко открыть или импортировать проект и его зависимости. Ниже мы покажем вам, как использовать популярные IDE для сборки и запуска примеров.

### **IntelliJ IDEA**

Нажмите на меню **File** и выберите **Open**. Перейдите в папку проекта и выберите файл **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Рисунок: Выбор файла или директории для импорта**|
Это откроет проект и автоматически загрузит зависимости. Вкладка Project, просмотрите примеры в папке **src/main/java**. Чтобы запустить пример, просто щелкните правой кнопкой мыши на файле и выберите "Run ..", пример будет выполнен, а вывод будет показан в встроенном консольном окне.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Рисунок: Запуск примера**|

### **Eclipse**

Нажмите на меню **File** и выберите **Import**. Выберите **Maven** - Существующие проекты Maven.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Рисунок: Импорт**|
Перейдите в папку, которую вы клонировали или скачали с GitHub, и выберите файл **pom.xml**. Это откроет проект и автоматически загрузит зависимости. Вкладка Package Explorer, просмотрите примеры в папке **src/main/java**. Чтобы запустить пример, просто щелкните правой кнопкой мыши на файле и выберите **Run As** - **Java Application**, пример будет выполнен, а вывод будет показан в встроенном консольном окне.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Рисунок: Запуск примера**|

### **NetBeans**

Нажмите на меню **File** и выберите **Open Project**. Перейдите в папку, которую вы клонировали или скачали с GitHub. Иконка папки **Examples** покажет, что это проект Maven. Выберите Examples и откройте его.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Рисунок: Открытие проекта**|
Это откроет проект и автоматически загрузит зависимости. Вкладка Projects, просмотрите примеры в **source packages**. Чтобы запустить пример, просто щелкните правой кнопкой мыши на файле и выберите **Run File**, пример будет выполнен, а вывод будет показан в встроенном консольном окне.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Рисунок: Запуск примера**|

## **Добавление библиотеки Aspose.CAD в локальный репозиторий Maven**

Когда вы импортируете проект **Aspose.CAD Examples** в IDE, Maven автоматически загружает JAR-файл aspose.cad из [Aspose Maven Repository](https://releases.aspose.com/java/repo/). В случае отсутствия доступа к интернету вы можете вручную добавить JAR в ваш локальный репозиторий.

### **mvn install**

Скачайте [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), извлеките его и скопируйте aspose.cad-version.jar куда-нибудь еще, например, на диск C. Выполните следующую команду:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Теперь JAR-файл **aspose.cad** скопирован в ваш локальный репозиторий Maven.

### **pom.xml**

После установки просто укажите координаты **aspose.cad** в pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Готово**

Соберите проект, теперь JAR-файл **aspose.cad** можно получить из вашего локального репозитория Maven.

## **Участие**

Если вы хотите добавить или улучшить пример, мы призываем вас внести вклад в проект. Все примеры и демонстрационные проекты в этом репозитории являются открытым исходным кодом и могут быть свободно использованы в ваших собственных приложениях.

Чтобы внести свой вклад, вы можете форкнуть репозиторий, отредактировать исходный код и отправить Pull Request. Мы рассмотрим изменения и включим их в репозиторий, если они окажутся полезными.
