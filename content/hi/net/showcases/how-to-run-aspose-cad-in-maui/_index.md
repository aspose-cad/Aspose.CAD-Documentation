---
title: Aspose.CAD को Multi-platform App UI(MAUI) में कैसे चलाएं
type: docs
description: "Multi-platform App UI(MAUI) में Aspose.CAD चलाएं।"
weight: 71
url: /hi/net/showcases/how-to-run-aspose-cad-in-maui/
---

## पूर्वापेक्षाएँ
- विजुअल स्टूडियो 2022।
- उदाहरण में .NET 7 SDK का उपयोग किया गया है।

## MAUI

.NET Multi-platform App UI (.NET MAUI) C# और XAML के साथ नATIVE मोबाइल और डेस्कटॉप ऐप बनाने के लिए एक क्रॉस-प्लेटफ़ॉर्म ढांचा है।
.NET MAUI का उपयोग करके, आप एक साझा कोड-बेस से Android, iOS, macOS और Windows पर चलने वाले ऐप विकसित कर सकते हैं।

.NET MAUI ओपन-सोर्स है और यह Xamarin.Forms का विकास है, जो मोबाइल से डेस्कटॉप परिदृश्यों में विस्तारित होता है, UI नियंत्रणों को प्रदर्शन और विस्तार के लिए मौलिक रूप से फिर से बनाया गया है।
यदि आप पहले से ही क्रॉस-प्लेटफ़ॉर्म उपयोगकर्ता इंटरफेस बनाने के लिए Xamarin.Forms का उपयोग कर चुके हैं, तो आप .NET MAUI के साथ कई समानताएँ देखेंगे।
हालांकि, कुछ अंतर भी हैं।
.NET MAUI का उपयोग करते समय, आप एक ही परियोजना का उपयोग करके बहु-प्लेटफ़ॉर्म ऐप बना सकते हैं, लेकिन आप यदि आवश्यक हो तो प्लेटफ़ॉर्म-विशिष्ट सोर्स कोड और संसाधन जोड़ सकते हैं।
.NET MAUI का एक मुख्य उद्देश्य यह सुनिश्चित करना है कि आप अपनी ऐप लॉजिक और UI लेआउट का अधिकतम भाग एक ही कोड-बेस में लागू कर सकें।

## MAUI स्थापित करें

1. .NET MAUI ऐप बनाने के लिए, आपको विजुअल स्टूडियो 2022 का नवीनतम संस्करण चाहिए
1. या तो विजुअल स्टूडियो स्थापित करें, या अपने मौजूदा इंस्टॉलेशन को संशोधित करें, और इसकी डिफ़ॉल्ट वैकल्पिक स्थापना विकल्पों के साथ .NET Multi-platform App UI विकास कार्यभार स्थापित करें:<br>
![Visual installer](/_assets/showcases/maui/visual-installer.png)

## परियोजना बनाएँ

1. विजुअल स्टूडियो लॉन्च करें। प्रारंभ विंडो में, एक नया प्रोजेक्ट बनाने के लिए एक नया प्रोजेक्ट बनाएं पर क्लिक करें:<br>
![Create project](/_assets/showcases/maui/create-project.png)<br>
1. एक नए प्रोजेक्ट बनाएं विंडो में, सभी प्रोजेक्ट प्रकार ड्रॉप-डाउन में MAUI चुनें, .NET MAUI ऐप टेम्पलेट चुनें और अगला बटन दबाएं:<br>
![Select project type](/_assets/showcases/maui/select-project.png)<br>
1. अपने नए प्रोजेक्ट कॉन्फ़िगर करें विंडो में, अपने प्रोजेक्ट का नाम दें, इसके लिए उपयुक्त स्थान चुनें, और अगला बटन दबाएं:<br>
![Select project path](/_assets/showcases/maui/select-project-path.png)<br>
1. अतिरिक्त जानकारी विंडो में, लक्ष्य बनाने के लिए आप जिस .NET संस्करण का चयन करना चाहते हैं, उसे चुनें और बनाएँ बटन पर क्लिक करें:<br>
![Target Framework](/_assets/showcases/maui/select-framework.png)<br>
1. प्रोजेक्ट के निर्माण और इसके निर्भरता को पुनर्स्थापित करने की प्रतीक्षा करें
1. NuGet से नवीनतम Aspose.CAD संस्करण स्थापित करें:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. MainPage.xaml में कोड को बदलें
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
            Text="स्वागत है .NET MAUI में!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="नमस्ते कहने वाला प्यारा डॉट नेट बॉट!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="हैलो, वर्ल्ड!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text=".NET Multi-platform App UI में आपका स्वागत है"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="डॉट नेट मल्टी प्लेटफ़ॉर्म ऐप यू आई में आपका स्वागत है"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="फ़ाइल का चयन करें"
                SemanticProperties.Hint="आप कितनी बार क्लिक करते हैं, यह गिनता है"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="स्पष्ट करें"
                SemanticProperties.Hint="आप कितनी बार क्लिक करते हैं, यह गिनता है"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. MainPage.xaml.cs में नए तरीके जोड़ें
{{% alert color="primary" %}} 
Aspose.CAD और Aspose.CAD.ImageOptions का उपयोग करना न भूलें।
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
        PickerTitle = "कोई भी"
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

## विंडोज मशीन पर डिबग करें

1. विजुअल स्टूडियो टूलबार में, Debug Target ड्रॉप-डाउन का उपयोग करके Framework का चयन करें और फिर net7.0-windows प्रविष्टि का चयन करें:<br>
![Debug Target](/_assets/showcases/maui/windows-mode.png)<br>
1. विजुअल स्टूडियो टूलबार में, ऐप बनाने और चलाने के लिए Windows Machine बटन दबाएं:<br>
![Start Debugging on Windows Machine](/_assets/showcases/maui/windows-start-debug.png)<br>
1. चल रहे ऐप में, "Select file" बटन को कई बार दबाएं और देखें कि बटन क्लिक की संख्या बढ़ रही है:<br>
![Home Page](/_assets/showcases/maui/windows-home-page.png)<br>
1. आवश्यक फ़ाइल का चयन करें और खोलें पर क्लिक करें:<br>
![Select file](/_assets/showcases/maui/select-file.png)<br>
1. फ़ाइल को प्रोसेस करने के बाद, परिवर्तित फ़ाइल की एक छवि स्क्रीन पर दिखाई देगी:<br>
![The result of debugging windows](/_assets/showcases/maui/windows-result.png)

## Android Emulator स्थापित करें

1. विजुअल स्टूडियो टूलबार में, Debug Target ड्रॉप-डाउन का उपयोग करके Android Emulators का चयन करें और फिर Android Emulator प्रविष्टि को चुनें
1. विजुअल स्टूडियो टूलबार में, Android Emulator बटन दबाएँ:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. Android SDK - लाइसेंस समझौता विंडो में, Accept बटन दबाएँ:<br>
![Android SDK-License Agreement](/_assets/showcases/maui/android-sdk-1.png)<br>
1. Android SDK - लाइसेंस समझौता विंडो में, Accept बटन दबाएँ:<br>
![Android SDK ARM -License Agreement](/_assets/showcases/maui/android-sdk-2.png)<br>
1. उपयोगकर्ता खाता नियंत्रण संवाद में, Yes बटन दबाएँ:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. लाइसेंस स्वीकृति विंडो में, Accept बटन दबाएँ:<br>
![SDK ARManagerM -License Agreement](/_assets/showcases/maui/android-sdk-4.png)<br>
1. विजुअल स्टूडियो टूलबार में, Android Emulator बटन दबाएँ:<br>
![Start install Emulator button](/_assets/showcases/maui/start-install-emulator.png)<br>
1. उपयोगकर्ता खाता नियंत्रण संवाद में, Yes बटन दबाएँ:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. New Device विंडो में, Create बटन दबाएँ:<br>
![New Android Device](/_assets/showcases/maui/android-new-device.png)<br>
1. Android Device Manager विंडो को बंद करें

## Android Emulator के साथ डिबग करें

1. विजुअल स्टूडियो टूलबार में, Pixel 5 - API 33 (Android 13.0 - API 33) बटन दबाकर ऐप को बनाएं और चलाएँ:<br>
![Select android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. Android एम्यूलेटर में चल रहे ऐप में, "Select file" बटन को कई बार दबाएं और देखें कि बटन क्लिक की संख्या बढ़ रही है:<br>
![Android Emulator Home Page](/_assets/showcases/maui/android-home-page.png)<br>
1. आवश्यक फ़ाइल का चयन करें और चयन करें पर क्लिक करें:<br>
![Select file in andoid](/_assets/showcases/maui/select-file-android.png)<br>
1. फ़ाइल को प्रोसेस करने के बाद, परिवर्तित फ़ाइल की एक छवि स्क्रीन पर दिखाई देगी:<br>
![The result of debugging android](/_assets/showcases/maui/android-result.png)

## अधिक उदाहरण

आप Docker में Aspose.CAD का उपयोग कैसे कर सकते हैं, इसके अधिक नमूनों के लिए, [examples](https://github.com/aspose-cad/Aspose.CAD-Documentation) देखें।

## संबंधित लेख

- [Visual Studio 2022 के लिए AWS Toolkit स्थापित करें](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Windows पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-windows/install/)
- [Mac पर Docker Desktop स्थापित करें](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, .NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Linux कंटेनरों पर स्विच करें](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) विकल्प
- [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk) पर अतिरिक्त जानकारी
