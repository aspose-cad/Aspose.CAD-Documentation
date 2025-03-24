---
title: איך להריץ Aspose.CAD ב-UI של אפליקציות רב-פלטפורמיות (MAUI)
type: docs
description: "הרץ Aspose.CAD ב-UI של אפליקציות רב-פלטפורמיות (MAUI)."
weight: 71
url: /he/net/showcases/how-to-run-aspose-cad-in-maui/
---

## דרישות מקדימות
- Visual Studio 2022.
- SDK של NET 7 בשימוש בדוגמה.


## MAUI

. .NET MAUI (ממשק אפליקציות רב-פלטפורמיות) היא מסגרת עבור יצירת אפליקציות ניידות ודסקטופיות מקוריות עם C# ו-XAML.
באמצעות .NET MAUI, תוכל לפתח אפליקציות שיכולות לפעול על Android, iOS, macOS ו-Windows מתוך קוד-בסיס משותף אחד.

. .NET MAUI היא קוד פתוח וההמשך של Xamarin.Forms, שהורחבה מתרחישים ניידים לתרחישים של דסקטופ, עם רכיבי UI שנבנו מחדש מהיסוד עבור ביצועים ונגישות.
אם השתמשת בעבר ב-Xamarin.Forms כדי לבנות ממשקי משתמש רב-פלטפורמיים, תבחין בהרבה דמיון עם .NET MAUI.
עם זאת, יש גם כמה הבדלים.
באמצעות .NET MAUI, תוכל ליצור אפליקציות רב-פלטפורמיות באמצעות פרויקט אחד, אך תוכל להוסיף קוד מקור ומשאבים ספציפיים לפלטפורמה אם יש צורך.
אחת מהמטרות המרכזיות של .NET MAUI היא לאפשר לך ליישם את מירב המאפיינים הלוגיים של האפליקציה שלך ואת פריסת ה-UI ככל האפשר בקוד-בסיס אחד.


## התקנת MAUI

1. כדי ליצור אפליקציות .NET MAUI, תצטרך את הגרסה האחרונה של Visual Studio 2022
1. או להתקין את Visual Studio, או לשנות את ההתקנה הקיימת שלך, ולהתקין את חבילת הפיתוח של .NET MAUI עם אפשרויות ההתקנה האופציונליות המוגדרות כברירת מחדל:<br>
![Visual installer](/cad/_assets/showcases/maui/visual-installer.png)


## יצירת פרויקט

1. הפעל את Visual Studio. בחלון ההתחלה, לחץ על צור פרויקט חדש על מנת ליצור פרויקט חדש:<br>
![Create project](/cad/_assets/showcases/maui/create-project.png)<br>
1. בחלון צור פרויקט חדש, בחר MAUI בתפריט סוגי פרויקטים, בחר בתבנית .NET MAUI App, ולחץ על כפתור הבא:<br>
![Select project type](/cad/_assets/showcases/maui/select-project.png)<br>
1. בחלון הגדר את הפרויקט החדש שלך, תן שם לפרויקט שלך, בחר מקום מתאים עבורו, ולחץ על כפתור הבא:<br>
![Select project path](/cad/_assets/showcases/maui/select-project-path.png)<br>
1. בחלון מידע נוסף, בחר את גרסת .NET שתרצה להתמקד בה ולחץ על כפתור יצירה:<br>
![Target Framework](/cad/_assets/showcases/maui/select-framework.png)<br>
1. המתן להיווצרות הפרויקט והחזרת התלויות שלו
1. התקן את הגרסה האחרונות של Aspose.CAD מ-NuGet:<br>
![NuGet](/cad/_assets/showcases/maui/nuget.png)<br>
1. החלף את הקוד ב-MainPage.xaml
{{< highlight plain >}}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MauiApp1.MainPage">

    <ScrollView>
        <VerticalStackLayout
            Spacing="25"
            Padding="30,0"
            VerticalOptions="Center">

             <Label 
            Text="ברוך הבא ל-.NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="בוט חמוד של דוט נט מנופף לך!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="שלום, עולם!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="ברוך הבא ל-.NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="ברוך הבא ל-doto.net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="בחר קובץ"
                SemanticProperties.Hint="סופר את מספר הפעמים שאתה לוחץ"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="נקה"
                SemanticProperties.Hint="סופר את מספר הפעמים שאתה לוחץ"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. הוסף שיטות חדשות ב-MainPage.xaml.cs
{{% alert color="primary" %}} 
אל תשכח להוסיף using Aspose.CAD ו-using Aspose.CAD.ImageOptions בקובץ.
{{% /alert %}}
{{< highlight plain >}}
private void OnCleanClicked(object sender, EventArgs e)
{
    Base64DecodedImage.Source = "dotnet_bot.png";
}
private async void OnSelectFileClicked(object sender, EventArgs e)
{
    var result = await FilePicker.PickAsync(new PickOptions()
    {
        PickerTitle = "כל אחד"
    });
    if (result == null)
    {
        return;
    }
    var stream = await result.OpenReadAsync();
    var img = Aspose.CAD.Image.Load(stream);
    var ms = new MemoryStream();
    await img.SaveAsync(ms, new PngOptions());
    Base64DecodedImage.Source = ImageSource.FromStream(() => ms);
}
{{< /highlight >}}


## ניפוי באגים במכונת Windows

1. בסרגל הכלים של Visual Studio, השתמש בתפריט היעד של ההגנה כדי לבחור Framework ואחר כך את הרישום net7.0-windows:<br>
![Debug Target](/cad/_assets/showcases/maui/windows-mode.png)<br>
1. בסרגל הכלים של Visual Studio, לחץ על כפתור Windows Machine כדי לבנות ולהפעיל את האפליקציה:<br>
![Start Debugging on Windows Machine](/cad/_assets/showcases/maui/windows-start-debug.png)<br>
1. באפליקציה הפועלת, לחץ על כפתור "בחר קובץ" כמה פעמים ושמור שהתוצאה של מספר הלחיצות על הכפתור מתעדכנת:<br>
![Home Page](/cad/_assets/showcases/maui/windows-home-page.png)<br>
1. בחר את הקובץ הנדרש ולחץ על פתח:<br>
![Select file](/cad/_assets/showcases/maui/select-file.png)<br>
1. לאחר עיבוד הקובץ, התמונה של הקובץ המומר צריכה להופיע על המסך:<br>
![The result of debugging windows](/cad/_assets/showcases/maui/windows-result.png)


## התקנת אמולטור אנדרואיד

1. בסרגל הכלים של Visual Studio, השתמש בתפריט היעד של ההגנה כדי לבחור אנדרואיד אמולטורים ולאחר מכן את רישום האמולטור אנדרואיד
1. בסרגל הכלים של Visual Studio, לחץ על כפתור האמולטור אנדרואיד:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. בחלון הסכם רישוי של Android SDK, לחץ על כפתור קבל:<br>
![Android SDK-License Agreement](/cad/_assets/showcases/maui/android-sdk-1.png)<br>
1. בחלון הסכם רישוי של Android SDK, לחץ על כפתור קבל:<br>
![Android SDK ARM -License Agreement](/cad/_assets/showcases/maui/android-sdk-2.png)<br>
1. בחלון בקרת חשבון המשתמש, לחץ על כפתור כן:<br>
![SDK Manager](/cad/_assets/showcases/maui/android-sdk-3.png)<br>
1. בחלון קבלת רישוי, לחץ על כפתור קבל:<br>
![SDK ARManagerM -License Agreement](/cad/_assets/showcases/maui/android-sdk-4.png)<br>
1. בסרגל הכלים של Visual Studio, לחץ על כפתור האמולטור אנדרואיד:<br>
![Start install Emulator button](/cad/_assets/showcases/maui/start-install-emulator.png)<br>
1. בחלון בקרת חשבון המשתמש, לחץ על כפתור כן:<br>
![Android Device Manager](/cad/_assets/showcases/maui/android-device-manager.png)<br>
1. בחלון מכשיר חדש, לחץ על כפתור צור:<br>
![New Android Device](/cad/_assets/showcases/maui/android-new-device.png)<br>
1. סגור את חלון מנהל המכשירים של אנדרואיד


## ניפוי באגים עם אמולטור אנדרואיד

1. בסרגל הכלים של Visual Studio, לחץ על כפתור Pixel 5 - API 33 (Android 13.0 - API 33) כדי לבנות ולהפעיל את האפליקציה:<br>
![Select android Emulator](/cad/_assets/showcases/maui/select-android-emulator.png)<br>
1. באפליקציה הפועלת באמולטור אנדרואיד, לחץ על כפתור "בחר קובץ" מספר פעמים ושמור שהספירה של מספר הלחיצות על הכפתור מתעדכנת:<br>
![Android Emulator Home Page](/cad/_assets/showcases/maui/android-home-page.png)<br>
1. בחר את הקובץ הנדרש ולחץ על בחר:<br>
![Select file in andoid](/cad/_assets/showcases/maui/select-file-android.png)<br>
1. לאחר עיבוד הקובץ, התמונה של הקובץ המומר צריכה להופיע על המסך:<br>
![The result of debugging android](/cad/_assets/showcases/maui/android-result.png)


## דוגמאות נוספות

למבצעות נוספות על איך תוכל להשתמש ב-Aspose.CAD ב-Docker, ראה את [דוגמאות](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## עוד אוכל לראות גם.

- [התקן AWS Toolkit עבור Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [התקן Docker Desktop על Windows](https://docs.docker.com/docker-for-windows/install/)
- [התקן Docker Desktop על Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK של NET 7](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [מעבר לקונטיינרים של לינוקס](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) אפשרות
- מידע נוסף על [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
