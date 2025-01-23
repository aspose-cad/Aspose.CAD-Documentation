---
title: Как да стартиране на Docker изображение Aspose.CAD в Azure Function
type: docs
description: "Стартиране на Docker изображение Aspose.CAD в Azure Function."
weight: 71
url: /bg/java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Предварителни изисквания
- Docker трябва да бъде инсталиран на вашата система. За информация как да инсталирате Docker на Windows или Mac, се обърнете към линковете в секцията „Вижте също“.
- IntelliJ IDEA.
- Azure Toolkit за IntelliJ.
- Postman.

## Azure Function

В този пример, вие създавате проста функция за конвертиране, която конвертира CAD файл и го записва като изображение. Приложението след това може да бъде компилирано в Docker и да бъде стартирано в Azure Function.

## Създаване на Azure Function

За да създадете програмата Azure Function, следвайте стъпките по-долу:
1. След инсталирането на Docker, уверете се, че използва Linux Containers (по подразбиране). При нужда, изберете опцията Switch to Linux containers от менюто на Docker Desktops.
1. Създайте проект Azure Function в IntelliJ IDEA.<br>
![Създаване на проект azure function](create-function-ide-1.png)<br>
![Създаване на проект azure function-крайно](create-function-ide-2.png)<br>
1. Tools->Azure->Вход и изберете удостоверяване OAuth 2.0.<br>
![Вход в Azure](sign-in-azure.png)<br>
1. Влезте в браузъра.
1. Изберете име на абонамент.
1. Добавете поддръжка на docker.<br>
![Вход в Azure](add-docker-support.png)<br>
1. Редактирайте DockerFile, както в секцията <a href="#configuring-a-dockerfile">Конфигуриране на Dockerfile</a>.
1. Добавете блокове за хранилище aspose.cad в pom.xml.
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

1. Когато всички необходими зависимости са добавени, напишете проста програма, която създава елипса и я записва като изображение:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Тази функция слуша на крайна точка "/api/HttpExample". Два начина да я извикате, използвайки командата "curl" в bash:
     * 1. curl -d "HTTP Body" {вашият хост}/api/HttpExample
     * 2. curl "{вашият хост}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Java HTTP trigger обработва заявка.");

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

### Конфигуриране на Dockerfile

 Следващата стъпка е да създадете и конфигурирате Dockerfile в кореновата папка на проекта.

1. В Dockerfile, посочете:
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

 Горният Dockerfile е прост, който съдържа следните инструкции:

- Образа на SDK, който да се използва. Docker ще го изтегли, когато се изпълни компилацията. Версията на SDK е посочена като етикет.
- Работната директория, която е посочена в следващия ред.
- Командата да копиете всичко в контейнера, публикувайте приложението и определете входната точка.

## Docker Hub
1. Вход в Docker Hub
1. Създайте публично хранилище

## Компилиране и стартиране на приложението в Docker
 
 Сега приложението може да бъде компилирано и стартирано в Docker. Отворете любимия си команден ред, сменете директорията на папката с приложението (папката, където се намира файлът на решението и Dockerfile) и изпълнете следната команда:


1. Команда за компилиране на dockerfile в конзолата
{{< highlight plain >}}
//пример
docker build -t <потребителско име>/<име на хранилище> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. При първото изпълнение на тази команда, може да отнеме повече време, тъй като Docker трябва да изтегли необходимите изображения. След като предишната команда завърши, стартирайте следната команда, за да качите изображението в docker hub.
{{< highlight plain >}}
//пример
docker push <потребителско име>/<име на хранилище>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Изпълнете dockerfile в IDE и след това го качете в docker hub.<br>
![Стартиране на docker в ide](docker-run-in-ide.png)<br>
1. Въведете името на изображението, както в хранилището Docker HUb.<br>
![Стартиране на docker в ide-следващ](docker-run-in-ide-1.png)<br>
1. Изчакайте за завършване.

## Azure

1. Вход в Azure.
1. Изберете Azure услуги.
1. Изберете Function App и създайте функция.<br>
![Бутон Създаване на функция Azure](create-function-azure.png)<br>
1. Повторете основните настройки, както на изображението по-долу.<br>
![Настройки за създаване на функция Azure](create-function-settings.png)<br>
1. Щракнете на 'Преглед + създаване' -> Създаване.
1. Изчакайте да завърши внедряването.
1. Щракнете на бутона 'Отидете на ресурса'.<br>
![Бутон Ресурс](go-to-resource.png)<br>
1. Спиране на функцията aspose-cad-docker-example.<br>
![Спиране на контейнера](stop-container.png)<br>
1. Отидете в менюто на центъра за внедряване и направете необходимите настройки.<br>
![Център за внедряване](deployment-center.png)<br>
1. Запазване на настройките
1. Копирайте Webhook URL от настройките на центъра за внедряване.<br>
![Webhook url](webhook-url.png)<br>
1. Отидете в Docker Hub, изберете вашето хранилище и изберете уебхукове.
1. Поставете 'Webhook url' от Azure в URL адреса на уебхука на Docker Hub и задайте името.<br>
![Настройки на Webhook в docker](webhook.png)<br>
1. Щракнете бутона създаване.
1. Върнете се в прегледа на azure функцията и стартирайте контейнера.<br>
![Меню Преглед](overview.png)<br>
{{% alert color="primary" %}} 
Може да отнеме няколко минути за функцията да започне.
{{% /alert %}}

## Пример за изпълнение

1. Настройки на Postman.<br>
![Меню Преглед](postman-settings.png)<br>
1. Изберете всеки DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG файл.
1. Щракнете бутона за изпращане.
1. Запазете резултата
![Запазване на отговор](response-postman.png)<br>

{{% alert color="primary" %}} 
Ако отговорът е успешен, щракнете на Запази в файл и ще получите преобразувания файл в png формат.
{{% /alert %}}

## Повече примери

За повече примери как можете да използвате Aspose.CAD в Docker, вижте [примерите](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Вижте също

- [Инсталирайте Docker Desktop на Windows](https://docs.docker.com/docker-for-windows/install/)
- [Инсталирайте Docker Desktop на Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Опция Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
