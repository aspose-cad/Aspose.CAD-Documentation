---
title: Πώς να τρέξετε την εικόνα Aspose.CAD Docker στο Google Cloud
type: docs
description: "Τρέξτε την εικόνα Aspose.CAD Docker στο Google Cloud."
weight: 75
url: /el/net/showcases/how-to-run-aspose-cad-docker-image-in-google-cloud
---

## Προαπαιτούμενα

- Πρέπει να είναι εγκατεστημένο το Docker στο σύστημά σας. Για πληροφορίες σχετικά με την εγκατάσταση του Docker σε Windows ή Mac, αναφέρετε τους συνδέσμους στην ενότητα “Δείτε επίσης”.
- Visual Studio 2022.
- Google CLI.
- Το .NET Core 3.1 SDK χρησιμοποιείται στο παράδειγμα.
- Postman

## Λειτουργία Google Cloud Run

Το Cloud Run είναι ένα πλήρως διαχειριζόμενο υπολογιστικό περιβάλλον για την ανάπτυξη και κλιμάκωση χωρίς εξυπηρέτη HTTP κοντέινερ, χωρίς να χρειάζεται να ανησυχείτε για την προμήθεια μηχανών, τη ρύθμιση συστάδων ή την αυτόματη κλιμάκωση.

- Καμία εξάρτηση από προμηθευτή - Επειδή το Cloud Run αναλαμβάνει τυπικές κοντέινερ OCI και εφαρμόζει το τυπικό API Knative Serving, μπορείτε εύκολα να μεταφέρετε τις εφαρμογές σας σε τοπικό ή οποιοδήποτε άλλο περιβάλλον cloud. 
- Γρήγορη αυτόματη κλιμάκωση - Οι μικροϋπηρεσίες που αναπτύσσονται στο Cloud Run κλιμακώνονται αυτόματα με βάση τον αριθμό των εισερχόμενων αιτημάτων, χωρίς να χρειάζεται να ρυθμίσετε ή να διαχειριστείτε μια πλήρη εγκατάσταση Kubernetes. Το Cloud Run κλιμακώνεται σε μηδέν — δηλαδή, δεν χρησιμοποιεί πόρους— αν δεν υπάρχουν αιτήματα.
- Διαχωρισμός κυκλοφορίας - Το Cloud Run σας επιτρέπει να διαχωρίσετε την κυκλοφορία μεταξύ πολλαπλών αναθεωρήσεων, προκειμένου να εκτελέσετε σταδιακώς πλεονασματικές παροχές όπως οι αναπτύξεις καναριών ή οι αναπτύξεις μπλε/πράσινες.
- Προσαρμοσμένα domains - Μπορείτε να ρυθμίσετε μια προσαρμοσμένη χαρτογράφηση domain στο Cloud Run και θα εγκαταστήσει ένα πιστοποιητικό TLS για το domain σας. 
- Αυτόματη εφεδρεία - Το Cloud Run προσφέρει αυτόματη εφεδρεία ώστε να μην χρειάζεται να ανησυχείτε για τη δημιουργία πολλαπλών παραδειγμάτων για υψηλή διαθεσιμότητα.

Το Cloud Run και οι Λειτουργίες Cloud είναι και οι δύο πλήρως διαχειριζόμενες υπηρεσίες που τρέχουν στην υποδομή serverless του Google Cloud, κλιμακώνονται αυτόματα και χειρίζονται αιτήματα HTTP ή γεγονότα. Ωστόσο, έχουν ορισμένες σημαντικές διαφορές:

- Οι Λειτουργίες Cloud επιτρέπουν την ανάπτυξη αποσπασμάτων κώδικα (λειτουργίες) γραμμένων σε περιορισμένο σύνολο γλωσσών προγραμματισμού, ενώ το Cloud Run σας επιτρέπει να αναπτύξετε εικόνες κοντέινερ χρησιμοποιώντας τη γλώσσα προγραμματισμού της επιλογής σας. 
- Το Cloud Run υποστηρίζει επίσης τη χρήση οποιουδήποτε εργαλείου ή βιβλιοθήκης συστήματος από την εφαρμογή σας; Οι Λειτουργίες Cloud δεν σας επιτρέπουν να χρησιμοποιήσετε προσαρμοσμένα εκτελέσιμα. 
- Το Cloud Run προσφέρει μεγαλύτερη διάρκεια λήξης αιτήματος, έως 60 λεπτά, ενώ με τις Λειτουργίες Cloud η διάρκεια λήξης των αιτημάτων μπορεί να φτάσει τα 9 λεπτά. 
- Οι Λειτουργίες Cloud στέλνουν μόνο ένα αίτημα τη φορά σε κάθε παράδειγμα λειτουργίας, ενώ από προεπιλογή το Cloud Run είναι ρυθμισμένο να στέλνει πολλαπλά ταυτόχρονα αιτήματα σε κάθε παράδειγμα κοντέινερ. Αυτό είναι χρήσιμο για τη βελτίωση της καθυστέρησης και τη μείωση του κόστους αν περιμένετε μεγάλο όγκο αιτήσεων. 

## Δημιουργία έργου Google Cloud Function

{{% alert color="primary" %}} 
Φροντίστε να έχετε επαρκή δικαιώματα για να δημιουργήσετε τις λειτουργίες Google Cloud Run και τις εικόνες στο αποθετήριο Artifact Registry.
{{% /alert %}}

Για να δημιουργήσετε το πρόγραμμα Google Cloud Function, ακολουθήστε τα παρακάτω βήματα:

1. Εγκαταστήστε το .NET Core SDK 3.1.
1. Εγκαταστήστε το πακέτο πρότυπων:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Στη συνέχεια, δημιουργήστε έναν κατάλογο για το έργο σας και χρησιμοποιήστε το dotnet new για να δημιουργήσετε μια νέα λειτουργία HTTP:
{{< highlight plain >}}
mkdir AsposeFunctions //δημιουργία φακέλου
cd AsposeFunctions //μετάβαση στο φάκελο AsposeFunctions
dotnet new gcf-http //δημιουργία έργου Google Cloud Function με ενεργοποιητή http
{{< /highlight >}}
{{% alert color="primary" %}} 
Αυτό δημιουργεί τα AsposeFunctions.csproj και Function.cs στον τρέχοντα κατάλογο. Ανοίξτε το Function.cs για να ελέγξετε τον κώδικα και να παρέχετε ένα προσαρμοσμένο μήνυμα αν το επιθυμείτε.
{{% /alert %}}
1. Παράδειγμα κώδικα για το αρχείο csproj(AsposeFunctions.csproj).
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. Παράδειγμα κώδικα για την μετατροπή εικόνας cad σε αρχείο png(Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Η λογική για τη λειτουργία σας πηγαίνει εδώ.
        /// </summary>
        /// <param name="context">Το HTTP context, που περιέχει το αίτημα και την απόκριση.</param>
        /// <returns>Μια εργασία που αναπαριστά τη ασύγχρονη λειτουργία.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //αρχείο φόρμας
                var file = context.Request.Body; //δυαδικά δεδομένα
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. Δημιουργήστε τη λειτουργία σας τοπικά ως εξής:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Μόλις ο διακομιστής τρέχει, πηγαίνετε στο http://localhost:8080 για να ενεργοποιήσετε τη λειτουργία. Πατήστε Ctrl-C στην κονσόλα για να σταματήσετε το διακομιστή.

## Ανάπτυξη εικόνας docker στο Google Cloud

1. Συνδεθείτε στο Google Cloud.
1. Δημιουργήστε ένα έργο αν δεν υπάρχει.
1. Μεταβείτε στο 'Artifact Registry' και δημιουργήστε ένα αποθετήριο.<br>
![Δημιουργία Αποθετηρίου Artifact](create-artifact-repository.png)<br>
1. Επιλέξτε το νέο αποθετήριο στο Artifact Registry.
![Επιλέξτε αποθετήριο artifact](select-artifact.png)<br>
1. Κάντε κλικ στο 'SETUP INSTRUCTION' και αντιγράψτε την εντολή 'Configure Docker'.<br>
![ΟΔΗΓΙΕΣ ΡΥΘΜΙΣΗΣ](setup-instruction.png)<br>
1. Προσθέστε μια εγγραφή Docker credHelper στο αρχείο ρύθμισης Docker ή δημιουργήστε το αρχείο αν δεν υπάρχει.
{{< highlight plain >}}
//παράδειγμα
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Δημιουργήστε ένα Dockerfile στο ριζικό κατάλογο του έργου και επεξεργαστείτε το DockerFile όπως στην <a href="#configuring-a-dockerfile">Ενότητα Ρύθμισης ενός Dockerfile</a>.
1. Ξεκινήστε το Docker Desktop.
1. Δημιουργήστε την εικόνα docker με την διαδρομή του cloud repository.
{{< highlight plain >}}
//παράδειγμα
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Ξεκινήστε την εικόνα στο Google Cloud Artifact Registry
{{< highlight plain >}}
//παράδειγμα
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Δημιουργία υπηρεσίας Google Cloud Run

1. Μεταβείτε στο Cloud Run.
1. Δημιουργήστε υπηρεσία Cloud Run.<br>
![Δημιουργία υπηρεσίας Cloud Run](create-cloud-run-service.png)<br>
1. Στο πεδίο URL εικόνας κοντέινερ, επιλέξτε την κοντέινερ από 'ARTIFACT REGISTRY'.<br>
![URL Εικόνας Κοντέινερ](container-url.png)<br>
1. Ελέγξτε άλλες ρυθμίσεις όπως παρακάτω.<br>
![Ρυθμίσεις υπηρεσίας](cloud-run-service-settings.png)<br>
1. Περιμένετε να ολοκληρωθεί η ανάπτυξη.
1. URL υπηρεσίας για να δουλέψετε με την εφαρμογή μετατροπής.<br>
![URL υπηρεσίας](url-service.png)<br>

### Ρύθμιση του Dockerfile

 Το επόμενο βήμα είναι να επεξεργαστείτε και να ρυθμίσετε το Dockerfile στο έργο.

1. Στο Dockerfile, καθορίστε:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

 Το παραπάνω είναι ένα απλό Dockerfile, το οποίο περιλαμβάνει τις εξής οδηγίες:

- Την εικόνα SDK που θα χρησιμοποιηθεί. Εδώ είναι η εικόνα Net Core 3.1. Το Docker θα την κατεβάσει όταν εκτελείται η κατασκευή. Η έκδοση του SDK καθορίζεται ως ετικέτα.
- Στη συνέχεια, ίσως χρειαστεί να εγκαταστήσετε Φόντα, καθώς η εικόνα του SDK περιέχει πολύ λίγα φόντα. Επίσης, μπορείτε να χρησιμοποιήσετε τοπικά φόντα που έχουν αντιγραφεί στη docker image.
- Ο καθορισμένος κατάλογος εργασίας, ο οποίος αναφέρεται στη επόμενη γραμμή.
- Η εντολή αντιγραφής όλων στο κοντέινερ, η δημοσίευση της εφαρμογής και ο καθορισμός του σημείου εισόδου.

## Παράδειγμα εκτέλεσης

1. Ρυθμίσεις Postman.<br>
![Μενού επισκόπησης](postman-settings.png)<br>
1. Επιλέξτε οποιοδήποτε αρχείο DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Κάντε κλικ στο κουμπί αποστολής.

{{% alert color="primary" %}} 
Εάν η απάντηση είναι επιτυχής, κάντε κλικ στην επιλογή Αποθήκευση σε αρχείο και θα λάβετε το μετατραπέν αρχείο σε μορφή png
{{% /alert %}}

## Περισσότερα παραδείγματα

Για περισσότερα παραδείγματα για το πώς μπορείτε να χρησιμοποιήσετε το Aspose.CAD στο Docker, δείτε τα [παραδείγματα](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Δείτε επίσης.

- [Εγκατάσταση Docker Desktop σε Windows](https://docs.docker.com/docker-for-windows/install/)
- [Εγκατάσταση Docker Desktop σε Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET Core 3.1 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Μετάβαση σε κοντέινερ Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) επιλογή
- Πρόσθετες πληροφορίες σχετικά με το [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
