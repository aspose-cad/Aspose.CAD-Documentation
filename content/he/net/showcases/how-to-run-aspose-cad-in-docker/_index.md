---
title: איך להריץ Aspose.CAD ב-Docker
type: docs
description: "הרץ Aspose.CAD במיכל Docker עבור Linux, Windows Server וכל מערכת הפעלה אחרת."
weight: 71
url: /he/net/showcases/how-to-run-aspose-cad-in-docker/
---

## דרישות מקדימות
- Docker חייב להיות מותקן במערכת שלך. למידע על איך להתקין Docker על Windows או Mac, עיין בקישורים בסעיף "ראו גם".
- Visual Studio 2022.
- SDK של NET 6 משמש בדוגמה.

## אפליקציית Hello World

בדוגמה זו, אתה יוצר אפליקציית קונסול פשוטה של Hello World שמציירת אליפסה ושומרת אותה כבתמונה. לאחר מכן ניתן לבנות ולהריץ את האפליקציה ב-Docker.

## יצירת אפליקציית הקונסול

כדי ליצור את תוכנית Hello World, עקוב אחרי הצעדים מטה:
1. לאחר ש-Docker מותקן, ודא שהוא משתמש בקונטיינרים של Linux (ברירת מחדל). אם יש צורך, בחר באופציה "Switch to Linux containers" מתפריט Docker Desktop.
1. ב-Visual Studio, צור אפליקציית קונסול NET 6.<br>
![Dialog פרויקט אפליקציית קונסול NET 6](/cad/_assets/showcases/docker/1.png)<br>
1. התקן את הגרסה האחרונה של Aspose.CAD מ-NuGet.<br>
![Aspose.CAD על NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. מכיוון שהאפליקציה תורץ על Linux, ייתכן שצריך להתקין גופנים נוספים. אפשר להעדיף את ttf-mscorefonts-installer.
1. כאשר כל התלויות הדרושות נוספו, כתוב תוכנית פשוטה שמייצרת אליפסה ושומרת אותה כבתמונה:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

שים לב שההתיק "TestOut" מוגדר כתיקיית פלט לשמירת המסמכים המתקבלים. כאשר מריצים את האפליקציה ב-Docker, תיקיה במחשב המארח תשויך לתיקיה זו במיכל. זה יאפשר לך לראות בקלות את הפלט שנוצר על ידי Aspose.CAD במיכל Docker.

### קונפיגורציית Dockerfile

השלב הבא הוא ליצור ולהגדיר את ה-Dockerfile.

1. צור את ה-Dockerfile ושמור אותו ליד קובץ הפתרון של האפליקציה שלך. השאר את שם הקובץ ללא סיומת (ברירת מחדל).
1. ב-Dockerfile, ציין:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

מעל זה הוא Dockerfile פשוט, שמכיל את ההוראות הבאות:

- תמונת ה-SDK שיש להשתמש בה. כאן מדובר בתמונת Net 6. Docker יוריד אותה כאשר תופעל הבנייה. גרסת SDK מצוינת כתייג.
- לאחר מכן, עשוי להיות צורך להתקין גופנים מכיוון שהתמונת SDK מכילה מאוד מעט גופנים. בנוסף, תוכל להשתמש בגופנים מקומיים שמועתקים לתמונה של docker.
- ספריית העבודה, שהיא מצוינת בשורה הבאה.
- הפקודה להעתיק הכל למיכל, לפרסם את האפליקציה, ולציין את נקודת הכניסה.


## בניית והרצת האפליקציה ב-Docker

עכשיו ניתן לבנות ולהריץ את האפליקציה ב-Docker. פתח את חלון הפקודות המועדף עליך, שנה את התיקיה לתיקיה שבה נמצאת האפליקציה (תיקיה שבה ממוקם קובץ הפתרון ואת ה-Dockerfile) והרץ את הפקודה הבאה:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

בפעם הראשונה שהפקודה הזו מתקיימת, זה עשוי לקחת יותר זמן, מכיוון ש-Docker צריך להוריד את התמונות הנדרשות. ברגע שהפקודה הקודמת הושלמה, הרץ את הפקודה הבאה:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
שימו לב לארגומנט המודל, מכיוון שכפי שצוין קודם, תיקיה במחשב המארח מודבקת לתיקיית המיכל, כדי לראות בקלות את התוצאות של הפעלת האפליקציה. מסלולים בלינוקס רגישים לאותיות גדולות וקטנות.
{{% /alert %}}

## דוגמאות נוספות

לעוד דוגמאות על איך ניתן להשתמש ב-Aspose.CAD ב-Docker, ראה את [דוגמאות](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## ראו גם

- [התקנת Docker Desktop על Windows](https://docs.docker.com/docker-for-windows/install/)
- [התקנת Docker Desktop על Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK של NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [החלפה לקונטיינרים של לינוקס](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 
- מידע נוסף על [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
