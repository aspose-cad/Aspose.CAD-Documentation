---
title: Πώς να Εκτελέσετε το Aspose.CAD σε Multi-platform App UI(MAUI)
type: docs
description: "Εκτελέστε το Aspose.CAD σε μια Multi-platform App UI(MAUI)."
weight: 71
url: /el/net/showcases/how-to-run-aspose-cad-in-maui
---

## Προαπαιτούμενα
- Visual Studio 2022.
- Το SDK .NET 7 χρησιμοποιείται στο παράδειγμα.


## MAUI

.NET Multi-platform App UI (.NET MAUI) είναι ένα διασχηματιζόμενο πλαίσιο για τη δημιουργία εγγενών κινητών και επιτραπέζιων εφαρμογών με C# και XAML.
Χρησιμοποιώντας το .NET MAUI, μπορείτε να αναπτύξετε εφαρμογές που μπορούν να τρέχουν σε Android, iOS, macOS και Windows από έναν μόνο κοινό κωδικό.

Το .NET MAUI είναι ανοιχτού κώδικα και είναι η εξέλιξη των Xamarin.Forms, επεκτεινόμενο από κινητές σε επιτραπέζιες σκηνές, με UI ελέγχους ξαναχτισμένους από την αρχή για απόδοση και επεκτασιμότητα.
Αν έχετε χρησιμοποιήσει προηγουμένως τα Xamarin.Forms για να κατασκευάσετε διασχηματιζόμενες διεπαφές χρήστη, θα παρατηρήσετε πολλές ομοιότητες με το .NET MAUI.
Ωστόσο, υπάρχουν και κάποιες διαφορές.
Χρησιμοποιώντας το .NET MAUI, μπορείτε να δημιουργήσετε εφαρμογές πολλαπλών πλατφορμών χρησιμοποιώντας ένα μόνο έργο, αλλά μπορείτε να προσθέσετε κωδικό πηγής και πόρους συγκεκριμένων πλατφορμών αν χρειαστεί.
Ένας από τους βασικούς στόχους του .NET MAUI είναι να σας επιτρέψει να υλοποιήσετε το μεγαλύτερο δυνατό κομμάτι της λογικής της εφαρμογής σας και του σχεδιασμού της διεπαφής χρήστη σε μία μόνο βάση κώδικα.


## Εγκατάσταση MAUI

1. Για να δημιουργήσετε εφαρμογές .NET MAUI, θα χρειαστείτε την τελευταία έκδοση του Visual Studio 2022
1. Ή εγκαταστήστε το Visual Studio, ή τροποποιήστε την υπάρχουσα εγκατάστασή σας, και εγκαταστήστε το φορτίο ανάπτυξης .NET Multi-platform App UI με τις προεπιλεγμένες προαιρετικές επιλογές εγκατάστασης:<br>
![Visual installer](/_assets/visual-installer.png)


## Δημιουργία έργου

1. Εκκινήστε το Visual Studio. Στο παράθυρο εκκίνησης, κάντε κλικ στο Δημιουργία νέου έργου για να δημιουργήσετε ένα νέο έργο:<br>
![Create project](/_assets/create-project.png)<br>
1. Στο παράθυρο Δημιουργίας νέου έργου, επιλέξτε MAUI από το αναπτυσσόμενο μενού Όλοι οι τύποι έργων, επιλέξτε το πρότυπο .NET MAUI App, και κάντε κλικ στο κουμπί Επόμενο:<br>
![Select project type](/_assets/select-project.png)<br>
1. Στο παράθυρο Ρύθμιση του νέου σας έργου, δώστε όνομα στο έργο σας, επιλέξτε μια κατάλληλη τοποθεσία για αυτό, και κάντε κλικ στο κουμπί Επόμενο:<br>
![Select project path](/_assets/select-project-path.png)<br>
1. Στο παράθυρο Πρόσθετες πληροφορίες, επιλέξτε την έκδοση του .NET που θέλετε να στοχεύσετε και κάντε κλικ στο κουμπί Δημιουργία:<br>
![Target Framework](/_assets/select-framework.png)<br>
1. Περιμένετε να δημιουργηθεί το έργο και να αποκατασταθούν οι εξαρτήσεις του
1. Εγκαταστήστε την τελευταία έκδοση του Aspose.CAD από το NuGet:<br>
![NuGet](/_assets/nuget.png)<br>
1. Αντικαταστήστε τον κωδικό στο MainPage.xaml
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
            Text="Καλώς ήρθατε στο .NET MAUI!"
            VerticalOptions="Center" 
            HorizontalOptions="Center" />

            <Image
                x:Name="Base64DecodedImage"
                Source="dotnet_bot.png"
                SemanticProperties.Description="Γλυκό μπατ bot του dot net που σας χαιρετά!"
                HeightRequest="600"
                HorizontalOptions="Center" />

            <Label
                Text="Γειά σου, Κόσμε!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                Text="Καλώς ήρθατε στο .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel="Level2"
                SemanticProperties.Description="Καλώς ήρθατε στο dot net Multi platform App U I"
                FontSize="18"
                HorizontalOptions="Center" />

            <Button
                x:Name="FileSelectrBtn"
                Text="Επιλογή αρχείου"
                SemanticProperties.Hint="Μετράει τον αριθμό των φορές που κάνετε κλικ"
                Clicked="OnSelectFileClicked"
                HorizontalOptions="Center" />

            <Button
                x:Name="ClearBtn"
                Text="Εκκαθάριση"
                SemanticProperties.Hint="Μετράει τον αριθμό των φορές που κάνετε κλικ"
                Clicked="OnCleanClicked"
                HorizontalOptions="Center" />

        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
{{< /highlight >}}
1. Προσθέστε νέες μεθόδους στο MainPage.xaml.cs
{{% alert color="primary" %}} 
Μην ξεχάσετε να προσθέσετε using Aspose.CAD και using Aspose.CAD.ImageOptions στο αρχείο.
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
        PickerTitle = "όποιοδήποτε"
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


## Εντοπισμός σφαλμάτων σε υπολογιστή Windows

1. Στην εργαλειοθήκη του Visual Studio, χρησιμοποιήστε το αναπτυσσόμενο μενού Στόχος Εντοπισμού σφαλμάτων για να επιλέξετε το Framework και στη συνέχεια την εγγραφή net7.0-windows:<br>
![Debug Target](/_assets/windows-mode.png)<br>
1. Στην εργαλειοθήκη του Visual Studio, πατήστε το κουμπί Υπολογιστής Windows για να κατασκευάσετε και να εκτελέσετε την εφαρμογή:<br>
![Start Debugging on Windows Machine](/_assets/windows-start-debug.png)<br>
1. Στην εκτελούμενη εφαρμογή, πατήστε το κουμπί "Επιλογή αρχείου" πολλές φορές και παρατηρήστε ότι ο αριθμός των κλικ αυξάνεται:<br>
![Home Page](/_assets/windows-home-page.png)<br>
1. Επιλέξτε το απαιτούμενο αρχείο και κάντε κλικ στο άνοιγμα:<br>
![Select file](/_assets/select-file.png)<br>
1. Μετά την επεξεργασία του αρχείου, μια εικόνα του μετασχηματισμένου αρχείου θα πρέπει να εμφανιστεί στην οθόνη:<br>
![The result of debugging windows](/_assets/windows-result.png)


## Εγκατάσταση προσομοιωτή Android

1. Στην εργαλειοθήκη του Visual Studio, χρησιμοποιήστε το αναπτυσσόμενο μενού Στόχος Εντοπισμού σφαλμάτων για να επιλέξετε Προσομοιωτές Android και στη συνέχεια την εγγραφή Προσομοιωτής Android
1. Στην εργαλειοθήκη του Visual Studio, πατήστε το κουμπί Προσομοιωτής Android:<br>
![Start install Emulator button](/_assets/start-install-emulator.png)<br>
1. Στο παράθυρο Άδεια Χρήσης SDK Android, πατήστε το κουμπί Αποδοχή:<br>
![Android SDK-License Agreement](/_assets/android-sdk-1.png)<br>
1. Στο παράθυρο Άδεια Χρήσης SDK Android, πατήστε το κουμπί Αποδοχή:<br>
![Android SDK ARM -License Agreement](/_assets/android-sdk-2.png)<br>
1. Στο παράθυρο Ελέγχου Λογαριασμού Χρήστη, πατήστε το κουμπί Ναι:<br>
![SDK Manager](/_assets/android-sdk-3.png)<br>
1. Στο παράθυρο Αποδοχής Άδειας, πατήστε το κουμπί Αποδοχή:<br>
![SDK ARManagerM -License Agreement](/_assets/android-sdk-4.png)<br>
1. Στην εργαλειοθήκη του Visual Studio, πατήστε το κουμπί Προσομοιωτής Android:<br>
![Start install Emulator button](/_assets/start-install-emulator.png)<br>
1. Στο παράθυρο Ελέγχου Λογαριασμού Χρήστη, πατήστε το κουμπί Ναι:<br>
![Android Device Manager](/_assets/android-device-manager.png)<br>
1. Στο παράθυρο Νέα Συσκευή, πατήστε το κουμπί Δημιουργία:<br>
![New Android Device](/_assets/android-new-device.png)<br>
1. Κλείστε το παράθυρο Διαχειριστή Συσκευών Android


## Εντοπισμός σφαλμάτων με Προσομοιωτή Android

1. Στην εργαλειοθήκη του Visual Studio, πατήστε το κουμπί Pixel 5 - API 33 (Android 13.0 - API 33) για να κατασκευάσετε και να εκτελέσετε την εφαρμογή:<br>
![Select android Emulator](/_assets/select-android-emulator.png)<br>
1. Στην εκτελούμενη εφαρμογή στον προσομοιωτή Android, πατήστε το κουμπί "Επιλογή αρχείου" πολλές φορές και παρατηρήστε ότι ο αριθμός των κλικ αυξάνεται:<br>
![Android Emulator Home Page](/_assets/android-home-page.png)<br>
1. Επιλέξτε το απαιτούμενο αρχείο και κάντε κλικ στην επιλογή:<br>
![Select file in andoid](/_assets/android-select-file.png)<br>
1. Μετά την επεξεργασία του αρχείου, μια εικόνα του μετασχηματισμένου αρχείου θα πρέπει να εμφανιστεί στην οθόνη:<br>
![The result of debugging android](/_assets/android-result.png)


## Περισσότερα παραδείγματα

Για περισσότερα δείγματα σχετικά με το πώς μπορείτε να χρησιμοποιήσετε το Aspose.CAD σε Docker, δείτε τα [παραδείγματα](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Δείτε επίσης.

- [Εγκαταστήστε το AWS Toolkit για το Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Εγκαταστήστε το Docker Desktop στα Windows](https://docs.docker.com/docker-for-windows/install/)
- [Εγκαταστήστε το Docker Desktop στο Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 7 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70#dependencies)
- [Μεταβείτε σε κοντέινερ Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) επιλογή
- Πρόσθετες πληροφορίες σχετικά με το [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
