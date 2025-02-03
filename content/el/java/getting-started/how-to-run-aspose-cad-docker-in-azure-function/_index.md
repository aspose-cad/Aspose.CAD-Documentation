---
title: Πώς να Εκτελέσετε την Εικόνα Docker Aspose.CAD σε Azure Function
type: docs
description: "Εκτελέστε την εικόνα Docker Aspose.CAD σε Azure Function."
weight: 71
url: /el/java/how-to-run-aspose-cad-docker-image-in-azure-function
---

## Προαπαιτούμενα
- Το Docker πρέπει να είναι εγκατεστημένο στο σύστημά σας. Για πληροφορίες σχετικά με το πώς να εγκαταστήσετε το Docker σε Windows ή Mac, ανατρέξτε στους συνδέσμους στην ενότητα "Δείτε επίσης".
- IntelliJ IDEA.
- Azure Toolkit για IntelliJ.
- Postman.

## Azure Function

Σε αυτό το παράδειγμα, δημιουργείτε μια απλή συνάρτηση μετατροπής που μετατρέπει ένα αρχείο CAD και το αποθηκεύει ως εικόνα. Η εφαρμογή μπορεί στη συνέχεια να κατασκευαστεί σε Docker και να εκτελείται σε Azure Function.

## Δημιουργία της Azure Function

Για να δημιουργήσετε το πρόγραμμα Azure Function, ακολουθήστε τα παρακάτω βήματα:
1. Αφού εγκαταστήσετε το Docker, βεβαιωθείτε ότι χρησιμοποιεί Linux Containers (προεπιλογή). Αν χρειαστεί, επιλέξτε την επιλογή Εναλλαγή σε Linux containers από το μενού του Docker Desktop.
1. Δημιουργήστε έργο Azure Function στο IntelliJ IDEA.<br>
![Create azure function project](create-function-ide-1.png)<br>
![Create azure function project-final](create-function-ide-2.png)<br>
1. Tools->Azure->Σύνδεση και επιλέξτε την αυθεντικοποίηση OAuth 2.0.<br>
![Azure sign In](sign-in-azure.png)<br>
1. Συνδεθείτε στο πρόγραμμα περιήγησης.
1. Επιλέξτε το όνομα συνδρομής.
1. Προσθέστε υποστήριξη docker.<br>
![Azure sign In](add-docker-support.png)<br>
1. Επεξεργαστείτε το DockerFile όπως στην ενότητα <a href="#configuring-a-dockerfile">Διαμόρφωση ενός Dockerfile</a>.
1. Προσθέστε μπλοκ για το αποθετήριο aspose.cad στο pom.xml.
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

1. Όταν προστεθούν όλες οι απαιτούμενες εξαρτήσεις, γράψτε ένα απλό πρόγραμμα που δημιουργεί μια έλλειψη και την αποθηκεύει ως εικόνα:<br>
{{< highlight plain >}}
public class HttpTriggerFunction {
    /**
     * Αυτή η συνάρτηση ακούει στο endpoint "/api/HttpExample". Δύο τρόποι να την καλέσετε χρησιμοποιώντας την εντολή "curl" στο bash:
     * 1. curl -d "HTTP Body" {your host}/api/HttpExample
     * 2. curl "{your host}/api/HttpExample?name=HTTP%20Query"
     */
    @FunctionName("HttpExample")
    public HttpResponseMessage run(
            @HttpTrigger(
                name = "req",
                methods = {HttpMethod.GET, HttpMethod.POST},
                authLevel = AuthorizationLevel.ANONYMOUS)
                HttpRequestMessage<Optional<String>> request,
            final ExecutionContext context) throws FileNotFoundException {
        context.getLogger().info("Η Java HTTP trigger επεξεργάστηκε ένα αίτημα.");

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

### Διαμόρφωση ενός Dockerfile

Το επόμενο βήμα είναι να δημιουργήσετε και να διαμορφώσετε το Dockerfile στον φάκελο ρίζας του έργου.

1. Στο Dockerfile, προσδιορίστε:
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

Το παραπάνω είναι ένα απλό Dockerfile, το οποίο περιέχει τις εξής οδηγίες:

- Η εικόνα SDK που θα χρησιμοποιηθεί. Το Docker θα την κατεβάσει όταν εκτελείται η κατασκευή. Η έκδοση του SDK καθορίζεται ως ετικέτα.
- Ο φάκελος εργασίας, ο οποίος καθορίζεται στην επόμενη γραμμή.
- Η εντολή για την αντιγραφή όλων στο κοντέινερ, τη δημοσίευση της εφαρμογής και την καθοριστική σημείο εισόδου.

## Docker Hub
1. Σύνδεση στο Docker Hub
1. Δημιουργία Δημόσιου Αποθετηρίου

## Δημιουργία και Εκτέλεση της Εφαρμογής σε Docker
 
 Τώρα η εφαρμογή μπορεί να κατασκευαστεί και να εκτελείται σε Docker. Ανοίξτε την αγαπημένη σας γραμμή εντολών, αλλάξτε τον κατάλογο στον φάκελο με την εφαρμογή (φάκελος όπου βρίσκονται το αρχείο λύσης και το Dockerfile) και εκτελέστε την παρακάτω εντολή:

1. Εντολή κατασκευής dockerfile στη κονσόλα
{{< highlight plain >}}
//παράδειγμα
docker build -t <user name>/<repository name> .

docker build -t user/asposefunction .
{{< /highlight >}}
 
1. Την πρώτη φορά που εκτελείτε αυτήν την εντολή, μπορεί να χρειαστεί περισσότερος χρόνος porque χρειάζεται το Docker να κατεβάσει τις απαραίτητες εικόνες. Αφού ολοκληρωθεί η προηγούμενη εντολή, εκτελέστε την παρακάτω εντολή για να στείλετε την εικόνα στο docker hub.
{{< highlight plain >}}
//παράδειγμα
docker push <user name>/<repository name>:tagname

docker push user/aspose-cad-java:latest
{{< /highlight >}}

1. Εκτελέστε το dockerfile στο IDE και αφού στείλετε στο docker hub.<br>
![Run docker in ide](docker-run-in-ide.png)<br>
1. Εισάγετε το όνομα της εικόνας, όπως στο αποθετήριο Docker HUb.<br>
![Run docker in ide-next](docker-run-in-ide-1.png)<br>
1. Περιμένετε μέχρι να ολοκληρωθεί.

## Azure

1. Σύνδεση στο Azure.
1. Επιλέξτε τις υπηρεσίες Azure.
1. Επιλέξτε την εφαρμογή Function και δημιουργήστε μια συνάρτηση.<br>
![Azure create function button](create-function-azure.png)<br>
1. Επαναλάβετε τις βασικές ρυθμίσεις όπως στην εικόνα παρακάτω.<br>
![Azure create function settings](create-function-settings.png)<br>
1. Κάντε κλικ στο 'Αξιολόγηση + Δημιουργία' -> Δημιουργία.
1. Περιμένετε να ολοκληρωθεί η ανάπτυξη.
1. Κάντε κλικ στο κουμπί 'Μετάβαση σε πόρο'.<br>
![Resource button](go-to-resource.png)<br>
1. Σταματήστε τη συνάρτηση aspose-cad-docker-example.<br>
![Stop conteiner](stop-container.png)<br>
1. Μεταβείτε στο μενού του κέντρου ανάπτυξης και κάντε τις κατάλληλες ρυθμίσεις.<br>
![Deployment center](deployment-center.png)<br>
1. Αποθηκεύστε τις ρυθμίσεις
1. Αντιγράψτε το URL Webhook από τις ρυθμίσεις του κέντρου ανάπτυξης.<br>
![Webhook url](webhook-url.png)<br>
1. Μεταβείτε στο Docker Hub, επιλέξτε το αποθετήριο σας και επιλέξτε webhooks.
1. Επικολλήστε το 'URL Webhook' από το Azure στο URL webhook του Docker Hub και καθορίστε το όνομα.<br>
![Webhook settings in docker](webhook.png)<br>
1. Κάντε κλικ στο κουμπί δημιουργίας.
1. Επιστρέψτε στην επισκόπηση της συνάρτησης azure και ξεκινήστε το κοντέινερ.<br>
![Overview menu](overview.png)<br>
{{% alert color="primary" %}} 
Μπορεί να χρειαστούν μερικά λεπτά για να ξεκινήσει η συνάρτηση.
{{% /alert %}}

## Παράδειγμα εκτέλεσης

1. Ρυθμίσεις Postman.<br>
![Overview menu](postman-settings.png)<br>
1. Επιλέξτε οποιοδήποτε αρχείο DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Κάντε κλικ στο κουμπί αποστολής.
1. Αποθηκεύστε το αποτέλεσμα
![Save responce](response-postman.png)<br>

{{% alert color="primary" %}} 
Εάν η απάντηση είναι επιτυχής, κάντε κλικ στην Αποθήκευση σε αρχείο και θα λάβετε το μετατραπέν αρχείο σε μορφή png
{{% /alert %}}

## Περισσότερα Παραδείγματα

Για περισσότερα δείγματα σχετικά με το πώς μπορείτε να χρησιμοποιήσετε το Aspose.CAD σε Docker, δείτε τα [δείγματα](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Δείτε Επίσης

- [Εγκαταστήστε το Docker Desktop σε Windows](https://docs.docker.com/docker-for-windows/install/)
- [Εγκαταστήστε το Docker Desktop σε Mac](https://docs.docker.com/docker-for-mac/install/)
- [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- [Επιλογή εναλλαγής σε Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
