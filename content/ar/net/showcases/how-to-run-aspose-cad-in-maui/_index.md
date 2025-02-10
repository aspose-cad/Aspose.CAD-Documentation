---
title: كيفية تشغيل Aspose.CAD في واجهة تطبيق متعددة المنصات (MAUI)
type: docs
description: "تشغيل Aspose.CAD في واجهة تطبيق متعددة المنصات (MAUI)."
weight: 71
url: /ar/net/how-to-run-aspose-cad-in-maui
---

## المتطلبات السابقة
- Visual Studio 2022.
- يتم استخدام .NET 7 SDK في المثال.


## MAUI

واجهة تطبيق متعددة المنصات (.NET MAUI) هي إطار عمل متعدد المنصات لإنشاء تطبيقات أصلية للأجهزة المحمولة وسطح المكتب باستخدام C# و XAML.
باستخدام .NET MAUI، يمكنك تطوير تطبيقات يمكن تشغيلها على Android و iOS و macOS و Windows من قاعدة رمز مشتركة واحدة.

.NET MAUI هو مفتوح المصدر وهو تطور لـ Xamarin.Forms، ممتدًا من السيناريوهات المحمولة إلى سطح المكتب، مع إعادة بناء عناصر التحكم في واجهة المستخدم من الأساس للأداء وقابلية التوسع.
إذا كنت قد استخدمت سابقًا Xamarin.Forms لبناء واجهات مستخدم متعددة المنصات، ستلاحظ العديد من التشابهات مع .NET MAUI.
ومع ذلك، هناك أيضًا بعض الاختلافات.
باستخدام .NET MAUI، يمكنك إنشاء تطبيقات متعددة المنصات باستخدام مشروع واحد، ولكن يمكنك إضافة رمز مصدر وموارد خاصة بالمنصة إذا لزم الأمر.
واحدة من الأهداف الرئيسية لـ .NET MAUI هي تمكينك من تنفيذ أكبر قدر ممكن من منطق تطبيقك وتخطيط واجهة المستخدم في قاعدة رمز واحدة.


## تثبيت MAUI

1. لإنشاء تطبيقات .NET MAUI، سوف تحتاج إلى أحدث إصدار من Visual Studio 2022
1. إما تثبيت Visual Studio، أو تعديل تثبيتك الحالي، وتثبيت مجموعة أدوات تطوير واجهة التطبيقات متعددة المنصات (.NET MAUI) مع خيارات التثبيت الافتراضية الخاصة بها:<br>
![مثبت Visual](/_assets/visual-installer.png)


## إنشاء مشروع

1. قم بتشغيل Visual Studio. في نافذة البدء، انقر فوق "إنشاء مشروع جديد" لإنشاء مشروع جديد:<br>
![إنشاء مشروع](/_assets/create-project.png)<br>
1. في نافذة "إنشاء مشروع جديد"، اختر MAUI من قائمة "جميع أنواع المشاريع"، اختر قالب .NET MAUI App، وانقر على زر Next:<br>
![اختيار نوع المشروع](/_assets/select-project.png)<br>
1. في نافذة "تكوين مشروعك الجديد"، قم بتسمية مشروعك، واختر موقعًا مناسبًا له، وانقر على زر Next:<br>
![اختيار مسار المشروع](/_assets/select-project-path.png)<br>
1. في نافذة "معلومات إضافية"، اختر نسخة .NET التي ترغب باستهدافها وانقر على زر Create:<br>
![توجيه الإطار](/_assets/select-framework.png)<br>
1. انتظر حتى يتم إنشاء المشروع واستعادة تبعياته
1. قم بتثبيت أحدث إصدار من Aspose.CAD من NuGet:<br>
![NuGet](/_assets/nuget.png)<br>
1. استبدل الكود في MainPage.xaml
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
            Text="مرحبًا بك في .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="روبوت دوت نت اللطيف يلوح لك!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="مرحبًا، العالم!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="مرحبًا بك في واجهة التطبيقات متعددة المنصات .NET"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="مرحبًا بك في واجهة التطبيقات متعددة المنصات دوت نت"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="اختر ملف"
                SemanticProperties.Hint="يعد عدد المرات التي انقر فيها"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="مسح"
                SemanticProperties.Hint="يعد عدد المرات التي انقر فيها"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. أضف طرق جديدة في MainPage.xaml.cs
{{% alert color="primary" %}} 
لا تنس إضافة using Aspose.CAD و using Aspose.CAD.ImageOptions في الملف.
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
        PickerTitle = "أي"
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


## تصحيح على جهاز Windows

1. في شريط أدوات Visual Studio، استخدم قائمة خيارات التصحيح للاختيار من بين الإطارات وقم بتحديد إدخال net7.0-windows:<br>
![تصحيح الهدف](/_assets/windows-mode.png)<br>
1. في شريط أدوات Visual Studio، اضغط على زر "جهاز Windows" لبناء وتشغيل التطبيق:<br>
![بدء التصحيح على جهاز Windows](/_assets/windows-start-debug.png)<br>
1. في التطبيق الذي يتم تشغيله، اضغط على زر "اختر ملف" عدة مرات ولاحظ أن عدد نقرات الأزرار يتزايد:<br>
![الصفحة الرئيسية](/_assets/windows-home-page.png)<br>
1. اختر الملف المطلوب وانقر على فتح:<br>
![اختر الملف](/_assets/select-file.png)<br>
1. بعد معالجة الملف، يجب أن تظهر صورة الملف المحول على الشاشة:<br>
![نتيجة تصحيح Windows](/_assets/windows-result.png)


## تثبيت محاكي Android

1. في شريط أدوات Visual Studio، استخدم قائمة خيارات التصحيح للاختيار من بين محاكيات Android ثم اختر إدخال المحاكي الخاص بـ Android
1. في شريط أدوات Visual Studio، اضغط على زر محاكي Android:<br>
![بدء تثبيت زر المحاكي](/_assets/start-install-emulator.png)<br>
1. في نافذة "اتفاقية ترخيص SDK Android"، اضغط على زر قبول:<br>
![SDK Android - اتفاقية الترخيص](/_assets/android-sdk-1.png)<br>
1. في نافذة "اتفاقية ترخيص SDK Android"، اضغط على زر قبول:<br>
![SDK ARM - اتفاقية الترخيص](/_assets/android-sdk-2.png)<br>
1. في مربع حوار "تحكم حساب المستخدم"، اضغط على زر نعم:<br>
![مدير SDK](/_assets/android-sdk-3.png)<br>
1. في نافذة قبول الترخيص، اضغط على زر قبول:<br>
![مدير SDK AR - اتفاقية الترخيص](/_assets/android-sdk-4.png)<br>
1. في شريط أدوات Visual Studio، اضغط على زر محاكي Android:<br>
![بدء تثبيت زر المحاكي](/_assets/start-install-emulator.png)<br>
1. في مربع حوار "تحكم حساب المستخدم"، اضغط على زر نعم:<br>
![مدير جهاز Android](/_assets/android-device-manager.png)<br>
1. في نافذة "جهاز جديد"، اضغط على زر إنشاء:<br>
![جهاز Android جديد](/_assets/android-new-device.png)<br>
1. أغلق نافذة مدير جهاز Android


## تصحيح باستخدام محاكي Android

1. في شريط أدوات Visual Studio، اضغط على زر Pixel 5 - API 33 (Android 13.0 - API 33) لبناء وتشغيل التطبيق:<br>
![اختيار محاكي Android](/_assets/select-android-emulator.png)<br>
1. في التطبيق الذي يتم تشغيله في محاكي Android، اضغط على زر "اختر ملف" عدة مرات ولاحظ أن عدد نقرات الأزرار يتزايد:<br>
![الصفحة الرئيسية لمحاكي Android](/_assets/android-home-page.png)<br>
1. اختر الملف المطلوب وانقر على اختيار:<br>
![اختر ملف في Android](/_assets/android-select-file.png)<br>
1. بعد معالجة الملف، يجب أن تظهر صورة الملف المحول على الشاشة:<br>
![نتيجة تصحيح Android](/_assets/android-result.png)


## المزيد من الأمثلة

لمزيد من العينات حول كيفية استخدام Aspose.CAD في Docker، انظر إلى [الأمثلة](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## انظر أيضًا.

- [تثبيت AWS Toolkit لـ Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [تثبيت Docker Desktop على Windows](https://docs.docker.com/docker-for-windows/install/)
- [تثبيت Docker Desktop على Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022، NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [التحويل إلى حاويات Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) الخيار
- معلومات إضافية حول [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
