---
title: วิธีการรัน Aspose.CAD ใน Multi-platform App UI(MAUI)
type: docs
description: "รัน Aspose.CAD ใน Multi-platform App UI(MAUI)."
weight: 71
url: /th/net/showcases/how-to-run-aspose-cad-in-maui/
---

## ข้อกำหนดเบื้องต้น
- Visual Studio 2022.
- NET 7 SDK ถูกใช้ในตัวอย่างนี้


## MAUI

.NET Multi-platform App UI (.NET MAUI) เป็นกรอบการทำงานข้ามแพลตฟอร์มสำหรับการสร้างแอพมือถือและเดสก์ท็อปที่เป็นเอกลักษณ์ด้วย C# และ XAML
โดยใช้ .NET MAUI คุณสามารถพัฒนาแอพที่สามารถทำงานบน Android, iOS, macOS, และ Windows จากฐานโค้ดที่แชร์เดียวกัน

.NET MAUI เป็นโอเพนซอร์สและเป็นการพัฒนาต่อยอดจาก Xamarin.Forms ที่ขยายจากการใช้งานบนมือถือไปยังสภาพแวดล้อมเดสก์ท็อป โดย UI ควบคุมถูกสร้างขึ้นใหม่จากพื้นฐานเพื่อประสิทธิภาพและการขยายตัว
หากคุณเคยใช้ Xamarin.Forms เพื่อสร้างอินเทอร์เฟซผู้ใช้ข้ามแพลตฟอร์ม คุณจะสังเกตเห็นความคล้ายคลึงกันมากมายกับ .NET MAUI
อย่างไรก็ตาม ก็ยังมีความแตกต่างบางประการ
โดยใช้ .NET MAUI คุณสามารถสร้างแอพหลายแพลตฟอร์มโดยใช้โปรเจ็กต์เดียว แต่คุณสามารถเพิ่มโค้ดและทรัพยากรเฉพาะแพลตฟอร์มหากจำเป็น
หนึ่งในเป้าหมายหลักของ .NET MAUI คือการช่วยให้คุณสามารถดำเนินการตรรกะของแอพและเลย์เอาต์ UI ของคุณให้ได้มากที่สุดในฐานโค้ดเดียว


## การติดตั้ง MAUI

1. เพื่อสร้างแอพ .NET MAUI คุณจะต้องติดตั้งเวอร์ชันล่าสุดของ Visual Studio 2022
1. ติดตั้ง Visual Studio หรือปรับเปลี่ยนการติดตั้งที่มีอยู่และติดตั้ง .NET Multi-platform App UI development workload พร้อมกับตัวเลือกติดตั้งเริ่มต้น:<br>
![ติดตั้ง Visual Studio](/_assets/showcases/maui/visual-installer.png)


## สร้างโปรเจ็กต์

1. เปิด Visual Studio ในหน้าต่างเริ่มต้น คลิก สร้างโปรเจ็กต์ใหม่ เพื่อสร้างโปรเจ็กต์ใหม่:<br>
![สร้างโปรเจ็กต์](/_assets/showcases/maui/create-project.png)<br>
1. ในหน้าต่างสร้างโปรเจ็กต์ใหม่ เลือก MAUI ในรายการประเภทโปรเจ็กต์ทั้งหมด เลือกเทมเพลต .NET MAUI App จากนั้นคลิกปุ่มถัดไป:<br>
![เลือกประเภทโปรเจ็กต์](/_assets/showcases/maui/select-project.png)<br>
1. ในหน้าต่างกำหนดโปรเจ็กต์ใหม่ของคุณ ให้ตั้งชื่อโปรเจ็กต์ของคุณ เลือกตำแหน่งที่เหมาะสมสำหรับโปรเจ็กต์และคลิกปุ่มถัดไป:<br>
![เลือกเส้นทางโปรเจ็กต์](/_assets/showcases/maui/select-project-path.png)<br>
1. ในหน้าต่างข้อมูลเพิ่มเติม เลือกเวอร์ชันของ .NET ที่คุณต้องการกำหนดเป้าหมายและคลิกปุ่มสร้าง:<br>
![กรอบที่กำหนดเป้าหมาย](/_assets/showcases/maui/select-framework.png)<br>
1. รอให้โปรเจ็กต์ถูกสร้างและการพึ่งพาถูกกู้คืน
1. ติดตั้งเวอร์ชันล่าสุดของ Aspose.CAD จาก NuGet:<br>
![NuGet](/_assets/showcases/maui/nuget.png)<br>
1. แทนที่โค้ดใน MainPage.xaml
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
            Text="ยินดีต้อนรับสู่ .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="บอท dot net สุดน่ารักกำลังโบกมือให้คุณ!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="สวัสดี, ชาวโลก!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="ยินดีต้อนรับสู่ .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="ยินดีต้อนรับสู่ dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="เลือกไฟล์"
                SemanticProperties.Hint="นับจำนวนครั้งที่คุณคลิก"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="ล้าง"
                SemanticProperties.Hint="นับจำนวนครั้งที่คุณคลิก"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. เพิ่มวิธีใหม่ใน MainPage.xaml.cs
{{% alert color="primary" %}} 
อย่าลืมเพิ่ม using Aspose.CAD และ using Aspose.CAD.ImageOptions ในไฟล์
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
        PickerTitle = "ใดก็ได้"
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


## ดีบักเครื่อง Windows

1. ในแถบเครื่องมือ Visual Studio ใช้รายการหมวดหมู่ดีบักเพื่อเลือก Framework และจากนั้นเลือก net7.0-windows:<br>
![เป้าหมายการดีบัก](/_assets/showcases/maui/windows-mode.png)<br>
1. ในแถบเครื่องมือ Visual Studio กดปุ่ม Windows Machine เพื่อสร้างและรันแอพ:<br>
![เริ่มดีบักบนเครื่อง Windows](/_assets/showcases/maui/windows-start-debug.png)<br>
1. ในแอพที่กำลังทำงาน กดปุ่ม "เลือกไฟล์" หลายครั้งและสังเกตเห็นว่าจำนวนการคลิกปุ่มเพิ่มขึ้น:<br>
![หน้าหลัก](/_assets/showcases/maui/windows-home-page.png)<br>
1. เลือกไฟล์ที่ต้องการและคลิกเปิด:<br>
![เลือกไฟล์](/_assets/showcases/maui/select-file.png)<br>
1. หลังจากประมวลผลไฟล์ รูปภาพของไฟล์ที่แปลงควรปรากฏบนหน้าจอ:<br>
![ผลลัพธ์ของการดีบัก Windows](/_assets/showcases/maui/windows-result.png)


## ติดตั้ง Android Emulator

1. ในแถบเครื่องมือ Visual Studio ใช้รายการหมวดหมู่ดีบักเพื่อเลือก Android Emulators และจากนั้นเลือก Android Emulator
1. ในแถบเครื่องมือ Visual Studio กดปุ่ม Android Emulator:<br>
![เริ่มติดตั้ง Emulator](/_assets/showcases/maui/start-install-emulator.png)<br>
1. ในหน้าต่าง Android SDK - ข้อตกลงใบอนุญาต กดปุ่ม Accept:<br>
![Android SDK-ข้อตกลงใบอนุญาต](/_assets/showcases/maui/android-sdk-1.png)<br>
1. ในหน้าต่าง Android SDK - ข้อตกลงใบอนุญาต กดปุ่ม Accept:<br>
![Android SDK ARM -ข้อตกลงใบอนุญาต](/_assets/showcases/maui/android-sdk-2.png)<br>
1. ในหน้าต่าง User Account Control กดปุ่ม Yes:<br>
![SDK Manager](/_assets/showcases/maui/android-sdk-3.png)<br>
1. ในหน้าต่างการยอมรับใบอนุญาต กดปุ่ม Accept:<br>
![SDK ARManagerM -ข้อตกลงใบอนุญาต](/_assets/showcases/maui/android-sdk-4.png)<br>
1. ในแถบเครื่องมือ Visual Studio กดปุ่ม Android Emulator:<br>
![เริ่มติดตั้ง Emulator](/_assets/showcases/maui/start-install-emulator.png)<br>
1. ในหน้าต่าง User Account Control กดปุ่ม Yes:<br>
![Android Device Manager](/_assets/showcases/maui/android-device-manager.png)<br>
1. ในหน้าต่างอุปกรณ์ใหม่ กดปุ่ม Create:<br>
![อุปกรณ์ Android ใหม่](/_assets/showcases/maui/android-new-device.png)<br>
1. ปิดหน้าต่าง Android Device Manager


## ดีบักด้วย Android Emulator

1. ในแถบเครื่องมือ Visual Studio กดปุ่ม Pixel 5 - API 33 (Android 13.0 - API 33) เพื่อสร้างและรันแอพ:<br>
![เลือก android Emulator](/_assets/showcases/maui/select-android-emulator.png)<br>
1. ในแอพที่กำลังทำงานใน Android emulator กดปุ่ม "เลือกไฟล์" หลายครั้งและสังเกตเห็นว่าจำนวนการคลิกปุ่มเพิ่มขึ้น:<br>
![หน้าหลัก Android Emulator](/_assets/showcases/maui/android-home-page.png)<br>
1. เลือกไฟล์ที่ต้องการและคลิกเลือก:<br>
![เลือกไฟล์ใน Android](/_assets/showcases/maui/select-file-android.png)<br>
1. หลังจากประมวลผลไฟล์ รูปภาพของไฟล์ที่แปลงควรปรากฏบนหน้าจอ:<br>
![ผลลัพธ์ของการดีบัก Android](/_assets/showcases/maui/android-result.png)


## ตัวอย่างเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติมเกี่ยวกับวิธีที่คุณสามารถใช้ Aspose.CAD ใน Docker โปรดดูที่ [ตัวอย่าง](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## ดูเพิ่มเติม.

- [ติดตั้ง AWS Toolkit สำหรับ Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [ติดตั้ง Docker Desktop บน Windows](https://docs.docker.com/docker-for-windows/install/)
- [ติดตั้ง Docker Desktop บน Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [เปลี่ยนไปใช้คอนเทนเนอร์ Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) ตัวเลือก
- ข้อมูลเพิ่มเติมเกี่ยวกับ [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
