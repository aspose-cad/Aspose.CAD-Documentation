---
title: Πώς να εκτελέσετε την εικόνα Aspose.CAD Docker σε Azure Function
type: docs
description: "Εκτελέστε την εικόνα Aspose.CAD Docker σε Azure Function."
weight: 73
url: /el/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Προαπαιτήσεις
- Το Docker πρέπει να είναι εγκατεστημένο στο σύστημα σας. Για πληροφορίες σχετικά με την εγκατάσταση του Docker σε Windows ή Mac, ανατρέξτε στους συνδέσμους στην ενότητα “Δείτε επίσης”.
- Visual Studio 2022.
- Το SDK NET 6 χρησιμοποιείται στο παράδειγμα.
- Postman

## Azure Function

Σε αυτό το παράδειγμα, δημιουργείτε μια απλή συνάρτηση μετατροπής που μετατρέπει ένα αρχείο CAD και το αποθηκεύει ως εικόνα. Στη συνέχεια, η εφαρμογή μπορεί να κατασκευαστεί σε Docker και να εκτελείται σε Azure Function.

## Δημιουργία της Azure Function

Για να δημιουργήσετε το πρόγραμμα Azure Function, ακολουθήστε τα παρακάτω βήματα:
1. Αφού εγκαταστήσετε το Docker, βεβαιωθείτε ότι χρησιμοποιεί Linux Containers (προεπιλογή). Εάν είναι απαραίτητο, επιλέξτε την επιλογή Switch to Linux containers από το μενού της επιφάνειας εργασίας Docker.
1. Στο Visual Studio, δημιουργήστε μια η Azure Function NET 6.<br>
![Διάλογος έργου Azure Function NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Πρόσθετες πληροφορίες.<br>
![Διάλογος έργου Azure Function NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Εγκαταστήστε την τελευταία έκδοση του Aspose.CAD από το NuGet.<br>
![Aspose.CAD στο NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Δεδομένου ότι η εφαρμογή θα εκτελείται σε Linux, μπορεί να χρειαστεί να εγκαταστήσετε πρόσθετες γραμματοσειρές. Θα μπορούσατε να προτιμήσετε το ttf-mscorefonts-installer.
1. Όταν προστεθούν όλες οι απαραίτητες εξαρτήσεις, γράψτε ένα απλό πρόγραμμα που δημιουργεί έναν ελλειπτικό και το αποθηκεύει ως εικόνα:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Η συνάρτηση HTTP trigger C# επεξεργάστηκε ένα αίτημα.");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### Διαμόρφωση ενός Dockerfile

 Το επόμενο βήμα είναι να δημιουργήσετε και να διαμορφώσετε το Dockerfile στον φάκελο ρίζας του έργου.

1. Δημιουργήστε το Dockerfile και τοποθετήστε το δίπλα στο αρχείο λύσης της εφαρμογής σας. Διατηρήστε αυτό το όνομα αρχείου χωρίς κατάληξη (προεπιλογή).
![Φάκελος ρίζας έργου](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Στο Dockerfile, καθορίστε:


{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

 Το παραπάνω είναι ένα απλό Dockerfile, το οποίο περιέχει τις εξής οδηγίες:

- Η εικόνα SDK που θα χρησιμοποιηθεί. Εδώ είναι η εικόνα Net 6. Το Docker θα την κατεβάσει όταν εκτελείται η κατασκευή. Η έκδοση του SDK καθορίζεται ως ετικέτα.
- Μετά, μπορεί να χρειαστεί να εγκαταστήσετε γραμματοσειρές επειδή η εικόνα SDK περιέχει πολύ λίγες γραμματοσειρές. Επίσης, μπορείτε να χρησιμοποιήσετε γραμματοσειρές τοπικές που έχουν αντιγραφεί στην εικόνα docker.
- Ο φάκελος εργασίας, ο οποίος καθορίζεται στην επόμενη γραμμή.
- Η εντολή για να αντιγράψετε τα πάντα στο δοχείο, να δημοσιεύσετε την εφαρμογή και να καθορίσετε το σημείο εισόδου.

## Docker Hub
1. Συνδεθείτε στο Docker Hub
1. Δημιουργήστε δημόσιο αποθετήριο

## Κατασκευή και Εκτέλεση της Εφαρμογής σε Docker
 
 Τώρα η εφαρμογή μπορεί να κατασκευαστεί και να εκτελείται σε Docker. Ανοίξτε την αγαπημένη σας γραμμή εντολών, αλλάξτε κατάλογο στον φάκελο με την εφαρμογή (φάκελο όπου βρίσκονται το αρχείο της λύσης και το Dockerfile) και εκτελέστε την παρακάτω εντολή:

{{< highlight plain >}}
//παράδειγμα
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
Την πρώτη φορά που θα εκτελέσετε αυτήν την εντολή, μπορεί να διαρκέσει περισσότερο επειδή το Docker χρειάζεται να κατεβάσει τις απαραίτητες εικόνες. Αφού ολοκληρωθεί η προηγούμενη εντολή, εκτελέστε την παρακάτω εντολή για να σπρώξετε την εικόνα στο docker hub:
 
{{< highlight plain >}}
//παράδειγμα
docker push <user name>/<repository name>:tagname

docker push user/asposefunction:latest
{{< /highlight >}}

## Azure

1. Συνδεθείτε στο Azure.
1. Επιλέξτε υπηρεσίες Azure.
1. Επιλέξτε την Εφαρμογή Function και δημιουργήστε μια συνάρτηση.<br>
![Κουμπί δημιουργίας λειτουργίας Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. Επαναλάβετε τις βασικές ρυθμίσεις όπως στην παρακάτω εικόνα.<br>
![Ρυθμίσεις δημιουργίας λειτουργίας Azure](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Κάντε κλικ στο 'Ανασκόπηση + δημιουργία' -> Δημιουργία.
1. Περιμένετε να ολοκληρωθεί η ανάπτυξη.
1. Κάντε κλικ στο κουμπί 'Μετάβαση στο πόρο'.<br>
![Κουμπί πόρου](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Σταματήστε τη λειτουργία aspose-cad-docker-example.<br>
![Σταματήστε το δοχείο](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Μεταβείτε στο μενού του κέντρου ανάπτυξης και κάντε τις κατάλληλες ρυθμίσεις.<br>
![Κέντρο ανάπτυξης](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Αποθηκεύστε τις ρυθμίσεις
1. Αντιγράψτε το URL Webhook από τις ρυθμίσεις του κέντρου ανάπτυξης.<br>
![URL Webhook](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Μεταβείτε στο Docker Hub, επιλέξτε το αποθετήριο σας και επιλέξτε τα webhooks.
1. Επικολλήστε το 'URL Webhook' από το Azure στο URL webhook του Docker Hub και καθορίστε το όνομά του.<br>
![Ρυθμίσεις Webhook στο docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Κάντε κλικ στο κουμπί δημιουργίας.
1. Επιστρέψτε στην επισκόπηση της azure function και ξεκινήστε το δοχείο.<br>
![Μενού επισκόπησης](/cad/_assets/showcases/azure/overview.png)<br>

## Παράδειγμα εκτέλεσης

1. Ρυθμίσεις Postman.<br>
![Μενού επισκόπησης](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Επιλέξτε οποιοδήποτε από τα αρχεία DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Κάντε κλικ στο κουμπί αποστολής.

{{% alert color="primary" %}} 
Εάν η απάντηση είναι επιτυχής, κάντε κλικ στην επιλογή Αποθήκευση σε αρχείο και θα λάβετε το μετατρεπόμενο αρχείο σε μορφή png
{{% /alert %}}

## Περισσότερα Παραδείγματα

Για περισσότερα δείγματα σχετικά με το πώς μπορείτε να χρησιμοποιήσετε το Aspose.CAD σε Docker, δείτε τα [παραδείγματα](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Δείτε επίσης

- [Εγκατάσταση του Docker Desktop στα Windows](https://docs.docker.com/docker-for-windows/install/)
- [Εγκατάσταση του Docker Desktop στο Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Επιλογή Switch to Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Πρόσθετες πληροφορίες σχετικά με το [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
