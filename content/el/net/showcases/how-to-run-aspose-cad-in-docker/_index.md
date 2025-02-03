---
title: Πώς να εκτελέσετε το Aspose.CAD σε Docker
type: docs
description: "Εκτελέστε το Aspose.CAD σε ένα δοχείο Docker για Linux, Windows Server και οποιοδήποτε λειτουργικό σύστημα."
weight: 71
url: /el/net/showcases/how-to-run-aspose-cad-in-docker
---

## Προαπαιτούμενα
- Το Docker πρέπει να είναι εγκατεστημένο στο σύστημά σας. Για πληροφορίες σχετικά με την εγκατάσταση του Docker σε Windows ή Mac, ανατρέξτε στους συνδέσμους στην ενότητα “Δείτε επίσης”.
- Visual Studio 2022.
- Το SDK .NET 6 χρησιμοποιείται στο παράδειγμα.

## Εφαρμογή Hello World

Σε αυτό το παράδειγμα, δημιουργείτε μια απλή κονσόλα Hello World που σχεδιάζει μια έλλειψη και την αποθηκεύει ως εικόνα. Στη συνέχεια, η εφαρμογή μπορεί να κατασκευαστεί και να εκτελεστεί σε Docker.

## Δημιουργία της Εφαρμογής Κονσόλας

Για να δημιουργήσετε το πρόγραμμα Hello World, ακολουθήστε τα παρακάτω βήματα:
1. Μόλις εγκατασταθεί το Docker, βεβαιωθείτε ότι χρησιμοποιεί τα Linux Containers (προεπιλεγμένο). Εάν χρειαστεί, επιλέξτε την επιλογή Μετάβαση σε Linux containers από το μενού του Docker Desktop.
1. Στο Visual Studio, δημιουργήστε μια εφαρμογή κονσόλας .NET 6.<br>
![Διάλογος έργου εφαρμογής κονσόλας .NET 6](1.png)<br>
1. Εγκαταστήστε την τελευταία έκδοση Aspose.CAD από το NuGet.<br>
![Aspose.CAD στο NuGet](2.png)<br>
1. Δεδομένου ότι η εφαρμογή θα εκτελείται σε Linux, μπορείτε να χρειαστεί να εγκαταστήσετε επιπλέον γραμματοσειρές. Μπορείτε να προτιμήσετε το ttf-mscorefonts-installer.
1. Όταν προστεθούν όλες οι απαιτούμενες εξαρτήσεις, γράψτε ένα απλό πρόγραμμα που δημιουργεί μια έλλειψη και την αποθηκεύει ως εικόνα:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Σημειώστε ότι ο φάκελος “TestOut” έχει καθοριστεί ως φάκελος εξόδου για την αποθήκευση των παραγόμενων εγγράφων. Όταν εκτελείτε την εφαρμογή σε Docker, ένας φάκελος στον υπολογιστή θα προσαρτηθεί σε αυτόν το φάκελο στο δοχείο. Αυτό θα σας επιτρέψει να δείτε εύκολα την έξοδο που παράγεται από το Aspose.CAD στο δοχείο Docker.

### Ρύθμιση ενός Dockerfile

Το επόμενο βήμα είναι να δημιουργήσετε και να ρυθμίσετε το Dockerfile.

1. Δημιουργήστε το Dockerfile και τοποθετήστε το δίπλα στο αρχείο λύσης της εφαρμογής σας. Διατηρήστε αυτό το όνομα αρχείου χωρίς κατάληξη (προεπιλογή).
1. Στο Dockerfile, καθορίστε:


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
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

Το παραπάνω είναι ένα απλό Dockerfile, το οποίο περιέχει τις εξής οδηγίες:

- Η εικόνα SDK που θα χρησιμοποιηθεί. Εδώ είναι η εικόνα .NET 6. Το Docker θα την κατεβάσει όταν εκτελείται η κατασκευή. Η έκδοση του SDK καθορίζεται ως tag.
- Μετά, μπορεί να χρειαστεί να εγκαταστήσετε γραμματοσειρές επειδή η εικόνα SDK περιέχει πολύ λίγες γραμματοσειρές. Επίσης, μπορείτε να χρησιμοποιήσετε τοπικές γραμματοσειρές που έχουν αντιγραφεί στην εικόνα docker.
- Ο εργάσιμος φάκελος, ο οποίος καθορίζεται στην επόμενη γραμμή.
- Η εντολή για την αντιγραφή όλων μέσα στο δοχείο, την έκδοση της εφαρμογής και την καθορισμένη είσοδο.


## Κατασκευή και εκτέλεση της εφαρμογής σε Docker
 
Τώρα η εφαρμογή μπορεί να κατασκευαστεί και να εκτελείται σε Docker. Ανοίξτε την αγαπημένη σας γραμμή εντολών, αλλάξτε φάκελο στο φάκελο με την εφαρμογή (φάκελος όπου βρίσκονται το αρχείο λύσης και το Dockerfile) και εκτελέστε την παρακάτω εντολή:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

Την πρώτη φορά που εκτελείται αυτή η εντολή μπορεί να διαρκέσει περισσότερο, καθώς το Docker χρειάζεται να κατεβάσει τις απαιτούμενες εικόνες. Μόλις ολοκληρωθεί η προηγούμενη εντολή, εκτελέστε την παρακάτω εντολή:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile from Docker
{{< /highlight >}}

{{% alert color="primary" %}} 
Δώστε προσοχή στην παράμετρο mount, διότι, όπως αναφέρθηκε νωρίτερα, ένας φάκελος στον υπολογιστή προσαρτάται στο φάκελο του δοχείου, για να δείτε εύκολα τα αποτελέσματα της εκτέλεσης της εφαρμογής. Οι διαδρομές στο Linux είναι ευαίσθητες σε πεζά και κεφαλαία.
{{% /alert %}}

## Περισσότερα Παραδείγματα

Για περισσότερα δείγματα σχετικά με το πώς μπορείτε να χρησιμοποιήσετε το Aspose.CAD σε Docker, δείτε τα [παραδείγματα](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Δείτε Επίσης

- [Εγκατάσταση Docker Desktop σε Windows](https://docs.docker.com/docker-for-windows/install/)
- [Εγκατάσταση Docker Desktop σε Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Επιλογή Μετάβασης σε Linux containers](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Πρόσθετες πληροφορίες σχετικά με το [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
