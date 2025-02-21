---
title: Как запустить образ Aspose.CAD Docker в Azure Function
type: docs
description: "Запустите образ Aspose.CAD Docker в Azure Function."
weight: 71
url: /ru/java/getting-started/how-to-run-aspose-cad-docker-in-azure-function/
---

## Предварительные требования
- Docker должен быть установлен на вашей системе. Для получения информации о том, как установить Docker на Windows или Mac, обратитесь к ссылкам в разделе "Смотрите также".
- IntelliJ IDEA.
- Azure Toolkit for IntelliJ.
- Postman.

## Azure Function

В этом примере вы создадите простую функцию преобразования, которая конвертирует файл CAD и сохраняет его как изображение. Приложение затем может быть создано в Docker и запущено в Azure Function.

## Создание Azure Function

Чтобы создать программу Azure Function, выполните следующие шаги:
1. После установки Docker убедитесь, что он использует контейнеры Linux (по умолчанию). При необходимости выберите вариант переключения на Linux-контейнеры из меню Docker Desktops.
1. Создайте проект Azure Function в IntelliJ IDEA.<br>
![Создание проекта azure function](/_assets/java/java-azure/create-function-ide-1.png)<br>
![Создание проекта azure function - финал](/_assets/java/java-azure/create-function-ide-2.png)<br>
1. Инструменты -> Azure -> Войти и выберите аутентификацию OAuth 2.0.<br>
![Вход в Azure](/_assets/java/java-azure/sign-in-azure.png)<br>
1. Войдите в браузере.
1. Выберите имя подписки.
1. Добавьте поддержку docker.<br>
![Добавление поддержки docker](/_assets/java/java-azure/add-docker-support.png)<br>
1. Отредактируйте DockerFile, как в разделе <a href="#configuring-a-dockerfile">Настройка Dockerfile</a>.
1. Добавьте блоки для репозитория aspose.cad в pom.xml.
{{< highlight plain >}}
<repositories>
    <repository>
		<id>AsposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.com/java/repo/</url>
    </repository>
</repositories>


<dependencies>
 <dependency>
    <groupId>com.aspose</groupId>
    <artifactId>aspose-cad</artifactId>
    <version>22.3</version>
    <scope>compile</scope>
  </dependency>
</dependencies>
{{< /highlight >}}

1. Когда все необходимые зависимости добавлены, напишите простую программу, которая создает эллипс и сохраняет его как изображение:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Эта функция прослушивает конечную точку "/api/HttpExample". Два способа вызвать ее, используя команду "curl" в bash:
     * 1. curl -d "HTTP Body" {ваш хост}/api/HttpExample
     * 2. curl "{ваш хост}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP trigger обработал запрос.");

        try{
            String body = request.getBody().get();
            InputStream targetStream = new ByteArrayInputStream(body.getBytes());

            CadImage image = (CadImage)Image.load(targetStream);
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.setPageWidth(1200);
                rasterizationOptions.setPageHeight(1200);

                ImageOptionsBase options = new PngOptions();
                options.setVectorRasterizationOptions(rasterizationOptions);

                ByteArrayOutputStream out = new ByteArrayOutputStream();

                image.save(out, options);

                return request.createResponseBuilder(HttpStatus.OK)
                        .header("Content-type", "image/png")
                        .header("Content-Disposition", "attachment;filename=filename.png")
                        .body(out.toByteArray()).build();
            }
        }
        catch (Exception e)
		{
            return request.createResponseBuilder(HttpStatus.BAD_REQUEST).body(e.getMessage()).build();
        }
    }
}
{{< /highlight >}}

### Настройка Dockerfile

Следующий шаг - создать и настроить Dockerfile в корневом каталоге проекта.

1. В Dockerfile укажите:
{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/java:3.0-java8-build AS installer-env

COPY . /src/java-function-app
RUN cd /src/java-function-app && \
    mkdir -p /home/site/wwwroot && \
    mvn clean package && \
    cd ./target/azure-functions/ && \
    cd $(ls -d */|head -n 1) && \
    cp -a . /home/site/wwwroot

FROM mcr.microsoft.com/azure-functions/java:3.0-java8-appservice

ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true

COPY --from=installer-env ["/home/site/wwwroot", "/home/site/wwwroot"]
{{< /highlight >}}

Выше приведён простой Dockerfile, который содержит следующие инструкции:

- Образ SDK, который будет использоваться. Docker загрузит его при запуске сборки. Версия SDK указана в виде тега.
- Рабочий каталог, который указан в следующей строке.
- Команда для копирования всего в контейнер, публикации приложения и определения точки входа.

## Docker Hub
1. Войдите в Docker Hub
1. Создайте публичный репозиторий

## Создание и запуск приложения в Docker
 
Теперь приложение можно создать и запустить в Docker. Откройте свою любимую командную строку, измените каталог на папку с приложением (папка, в которой находится файл решения и Dockerfile) и выполните следующую команду:

1. Построение команды dockerfile в консоли
{{< highlight plain >}}
//пример
docker build -t <имя пользователя>/<имя репозитория> .

docker build -t user/asposefunction .
{{< /highlight >}}

1. Первый раз, когда вы запускаете эту команду, это может занять больше времени, так как Docker должен загрузить необходимые образы. После завершения предыдущей команды выполните следующую команду для отправки изображения в docker hub.
{{< highlight plain >}}
//пример
docker push <имя пользователя>/<имя репозитория>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Запустите dockerfile в IDE и после отправки в docker hub.<br>
![Запуск docker в IDE](/_assets/java/java-azure/docker-run-in-ide.png)<br>
1. Введите имя изображения, как в репозитории Docker HUb.<br>
![Запуск docker в ide - следующий](/_assets/java/java-azure/docker-run-in-ide-1.png)<br>
1. Ждите завершения.

## Azure

1. Войдите в Azure.
1. Выберите службы Azure.
1. Выберите Function App и создайте функцию.<br>
![Кнопка создания функции Azure](/_assets/java/java-azure/create-function-azure.png)<br>
1. Повторите основные настройки, как на изображении ниже.<br>
![Настройки создания функции Azure](/_assets/java/java-azure/create-function-settings.png)<br>
1. Нажмите 'Обзор + создание' -> Создать.
1. Подождите, пока развертывание завершится.
1. Нажмите кнопку 'Перейти к ресурсу'.<br>
![Кнопка ресурса](/_assets/java/java-azure/go-to-resource.png)<br>
1. Остановите функцию aspose-cad-docker-example.<br>
![Остановить контейнер](/_assets/java/java-azure/stop-container.png)<br>
1. Перейдите в меню центра развертывания и внесите соответствующие настройки.<br>
![Центр развертывания](/_assets/java/java-azure/deployment-center.png)<br>
1. Сохраните настройки
1. Скопируйте URL-адрес вебхука из настроек центра развертывания.<br>
![URL вебхука](/_assets/java/java-azure/webhook-url.png)<br>
1. Перейдите в Docker Hub, выберите свой репозиторий и выберите вебхуки.
1. Вставьте 'URL вебхука' из Azure в URL вебхука Docker Hub и задайте имя.<br>
![Настройки вебхука в docker](/_assets/java/java-azure/webhook.png)<br>
1. Нажмите кнопку создать.
1. Вернитесь к обзору функции Azure и запустите контейнер.<br>
![Меню обзора](/_assets/java/java-azure/overview.png)<br>
{{% alert color="primary" %}} 
Это может занять несколько минут, чтобы функция запустилась.
{{% /alert %}}

## Пример выполнения

1. Настройки Postman.<br>
![Меню обзора](/_assets/java/java-azure/postman-settings.png)<br>
1. Выберите любой файл DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Нажмите кнопку отправки.
1. Сохраните результат
![Сохранить ответ](/_assets/java/java-azure/response-postman.png)<br>

{{% alert color="primary" %}} 
Если ответ успешен, нажмите Сохранить в файл, и вы получите конвертированный файл в формате png
{{% /alert %}}

## Другие примеры

Для получения дополнительных примеров использования Aspose.CAD в Docker смотрите [примеры](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Смотрите также

- [Установите Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Установите Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Переключитесь на контейнеры Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
