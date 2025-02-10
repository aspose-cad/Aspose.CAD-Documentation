---
title: Πώς να Εκτελέσετε την Εικόνα Docker Aspose.CAD σε Λειτουργία AWS Lambda
type: docs
description: "Εκτελέστε την εικόνα Docker Aspose.CAD σε Λειτουργία AWS Lambda."
weight: 74
url: /el/net/showcases/how-to-run-aspose-cad-docker-image-in-aws-lambda-function
---

## Προϋποθέσεις
- Το Docker πρέπει να είναι εγκατεστημένο στο σύστημα σας. Για πληροφορίες σχετικά με την εγκατάσταση του Docker στα Windows ή στο Mac, ανατρέξτε στους συνδέσμους στην ενότητα "Δείτε επίσης".
- Visual Studio 2022.
- AWS Toolkit για Visual Studio 2022.
- Το NET 6 SDK χρησιμοποιείται στο παράδειγμα.
- Postman

## Λειτουργία AWS Lambda

Το Lambda είναι μια υπηρεσία υπολογιστικού νέφους που σας επιτρέπει να εκτελείτε κώδικα χωρίς να προμηθεύεστε ή να διαχειρίζεστε διακομιστές. Το Lambda εκτελεί τον κώδικα σας σε μια υποδομή υπολογιστικού υψηλής διαθεσιμότητας και εκτελεί όλη τη διαχείριση των υπολογιστικών πόρων, συμπεριλαμβανομένης της συντήρησης διακομιστών και λειτουργικών συστημάτων, της προμήθειας δυναμικότητας και της αυτόματης κλιμάκωσης, καθώς και της καταγραφής. Με το Lambda, μπορείτε να εκτελέσετε κώδικα για σχεδόν οποιοδήποτε τύπο εφαρμογής ή υπηρεσίας backend.

## Δημιουργία της Λειτουργίας AWS Lambda

{{% alert color="primary" %}} 
Βεβαιωθείτε ότι έχετε επαρκή δικαιώματα για να δημιουργήσετε λειτουργίες και εικόνες AWS Lambda στο Amazon Elastic Container Registry.
{{% /alert %}}

Για να δημιουργήσετε το πρόγραμμα λειτουργίας AWS Lambda, ακολουθήστε τα παρακάτω βήματα:
1. Δημιουργήστε ένα Πρόγραμμα AWS Lambda.<br>
![Δημιουργία κουμπιού AWS function](/_assets/create-project.png)<br>
1. Επιλέξτε .NET 6(Εικόνα κοντέινερ) και κάντε κλικ στο κουμπί 'Τέλος'.<br>
![Δημιουργία κουμπιού κοντέινερ](/_assets/create-container.png)<br>
1. Ανοίξτε τον AWS Explorer στο Visual Studio(Προβολή->AWS Explorer).
1. Προσθέστε το προφίλ πιστοποίησης AWS στον AWS Explorer.<br>
![Προφίλ πιστοποίησης](/_assets/add-aws-credentials-profile.png)<br>
1. Εισάγετε το Access Key ID και το Secret Access Key, μπορείτε να αποκτήσετε αυτά τα κλειδιά στις Πιστοποιήσεις ασφαλείας ή να επικοινωνήσετε με τον διαχειριστή και να αποκτήσετε ένα αρχεία csv για εξουσιοδότηση.<br>
![Ρυθμίσεις προφίλ λογαριασμού](/_assets/account-profile.png)<br>
1. Εγκαταστήστε τις τελευταίες βιβλιοθήκες από το NuGet.<br>
![Διαχειριστής NuGet](/_assets/nuget-manager.png)<br>
1. Παράδειγμα κώδικα για τη μετατροπή της εικόνας cad σε αρχείο pdf.
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. Επεξεργαστείτε το DockerFile όπως στην ενότητα <a href="#configuring-a-dockerfile">Διαμόρφωση ενός Dockerfile</a>.
1. Εκκινήστε το Docker Desktop.
1. Δημοσιεύστε στο AWS Lambda.<br>
![Δημοσίευση AWS lambda](/_assets/publish-aws.png)<br>
1. Επεξεργαστείτε την παραμετροποίηση ανέβασμα.<br>
![Ανέβασμα aws lambda](/_assets/upload-aws-lambda.png)<br>
1. Κάντε κλικ στο κουμπί 'Ανέβασμα'.<br>
![Ανέβασμα τελευταίο aws lambda](/_assets/upload-aws-lambda-finish.png)<br>
1. Μεταβείτε στο AWS και επιλέξτε Lambda.<br>
![AWS Lambda](/_assets/select-aws-lambda.png)<br>
1. Επιλέξτε τη νέα λειτουργία σας και δημιουργήστε διεύθυνση url λειτουργίας.<br>
![Διαμόρφωση διεύθυνσης url λειτουργίας](/_assets/create-function-url.png)<br>
1. Επιλέξτε τον τύπο αυθεντικοποίησης
- AWS_IAM - Μόνο οι αυθεντικοποιημένοι χρήστες και ρόλοι IAM μπορούν να κάνουν αιτήματα στη διεύθυνση url της λειτουργίας σας.
- ΚΑΝΕΝΑ - Το Lambda δεν θα εκτελέσει αυθεντικοποίηση IAM σε αιτήματα προς τη διεύθυνση url της λειτουργίας σας. Το σημείο λήξης URL θα είναι δημόσιο εκτός αν υλοποιήσετε τη δική σας λογική εξουσιοδότησης στη λειτουργία σας.

### Διαμόρφωση ενός Dockerfile

 Το επόμενο βήμα είναι να επεξεργαστείτε τη διαμόρφωση του Dockerfile στο έργο.

1. Στο Dockerfile, specify:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Το παραπάνω είναι ένα απλό Dockerfile, το οποίο περιέχει τις εξής οδηγίες:

- Η εικόνα SDK που θα χρησιμοποιηθεί. Εδώ είναι η εικόνα Net 6. Το Docker θα την κατεβάσει κατά τη διάρκεια της εκτέλεσης της κατασκευής. Η έκδοση του SDK καθορίζεται ως ετικέτα.
- Μετά, μπορεί να χρειαστεί να εγκαταστήσετε γραμματοσειρές διότι η εικόνα SDK περιέχει πολύ λίγες γραμματοσειρές. Επίσης, μπορείτε να χρησιμοποιήσετε τοπικές γραμματοσειρές που αντιγράφονται στην εικόνα docker.
- Ο κατάλογος εργασίας, ο οποίος καθορίζεται στην επόμενη γραμμή.
- Η εντολή για να αντιγράψετε τα πάντα στο κοντέινερ, να δημοσιεύσετε την εφαρμογή και να καθορίσετε το σημείο εισόδου.

## Παράδειγμα εκτέλεσης

1. Ρυθμίσεις Postman.<br>
![Μενού επισκόπησης](/_assets/postman-settings.png)<br>
1. Επιλέξτε οποιοδήποτε DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG αρχείο.
1. Κάντε κλικ στο κουμπί αποστολής.

{{% alert color="primary" %}} 
Εάν η απάντηση είναι επιτυχής, κάντε κλικ στην επιλογή Αποθήκευση σε αρχείο και θα λάβετε το μετατραπέν αρχείο σε μορφή pdf
{{% /alert %}}

## Περισσότερα Παραδείγματα

Για περισσότερα παραδείγματα σχετικά με το πώς μπορείτε να χρησιμοποιήσετε το Aspose.CAD στο Docker, δείτε τα [παραδείγματα](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Δείτε Επίσης.

- [Εγκατάσταση AWS Toolkit για Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Εγκατάσταση Docker Desktop στα Windows](https://docs.docker.com/docker-for-windows/install/)
- [Εγκατάσταση Docker Desktop στο Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Εναλλαγή σε κοντέινερ Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) επιλογή
- Πρόσθετες πληροφορίες για [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
