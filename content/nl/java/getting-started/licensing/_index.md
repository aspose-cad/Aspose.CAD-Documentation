---
title: Licentie
type: docs
weight: 50
url: /nl/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Je kunt een evaluatieversie van **Aspose.CAD** voor Java downloaden van [de downloadpagina](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). De evaluatieversie biedt volledig dezelfde mogelijkheden als de gelicentieerde versie van het product. Bovendien wordt de evaluatieversie gewoon gelicentieerd wanneer je een licentie aanschaft en een paar regels code toevoegt om de licentie toe te passen.

Zodra je tevreden bent met je evaluatie van **Aspose.CAD**, kun je een [licentie aanschaffen](https://purchase.aspose.com/buy) op de Aspose-website. Maak jezelf vertrouwd met de verschillende abonnementsvormen die worden aangeboden. Als je vragen hebt, aarzel dan niet om contact op te nemen met het verkoopteam van Aspose.

Elke Aspose-licentie biedt een jaar gratis upgrades naar nieuwe versies of bugfixes die tijdens deze periode uitkomen. Technische ondersteuning is gratis en onbeperkt en wordt verstrekt aan zowel gelicentieerde als evaluatiegebruikers.

{{% /alert %}}

Als je **Aspose.CAD** wilt testen zonder beperkingen van de evaluatieversie, vraag dan een tijdelijke licentie van 30 dagen aan. Raadpleeg [Hoe vraag je een tijdelijke licentie aan?](https://purchase.aspose.com/temporary-license) voor meer informatie.

## **Een Licentie Instellen**

De licentie is een platte tekst XML-bestand dat details bevat zoals de productnaam, het aantal ontwikkelaars waarvoor het is gelicentieerd, de vervaldatum van het abonnement en meer. Het bestand is digitaal ondertekend, dus wijzig het bestand niet; zelfs de onbedoelde toevoeging van een extra regel break in het bestand maakt het ongeldig.

Je moet een licentie instellen voordat je enige bewerkingen met AutoCAD-bestanden uitvoert. Je hoeft slechts één keer per applicatie of proces een licentie in te stellen.

De licentie kan worden geladen vanuit een stream of bestand op de volgende locaties:

1. Expliciet pad.
1. De map die de Aspose.CAD.jar bevat.

Gebruik de License.setLicense() methode om de component te licentiëren. Vaak is de eenvoudigste manier om een licentie in te stellen, het licentiebestand in dezelfde map als Aspose.CAD.jar te plaatsen en alleen de bestandsnaam zonder pad op te geven, zoals in het volgende voorbeeld:

### **Voorbeeld 1**

In dit voorbeeld zal **Aspose.CAD** proberen het licentiebestand te vinden in de map die de JAR-bestanden van je applicatie bevat.

{{< highlight java >}}

com.aspose.cad.License licentie = new com.aspose.cad.License();

licentie.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Voorbeeld 2**

Initialiseert een licentie vanuit een stream.

{{< highlight java >}}

com.aspose.cad.License licentie = new com.aspose.cad.License();

licentie.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Valideer de Licentie**

Het is mogelijk om te valideren of de licentie correct is ingesteld of niet. De License-klasse heeft het isLicensed-veld dat true retourneert als de licentie correct is ingesteld.

{{< highlight java >}}

Licentie licentie = new Licentie();

licentie.setLicense("Aspose.CAD.Java.lic");

if (Licentie.isLicensed()) {

    System.out.println("Licentie is ingesteld!");

}

{{< /highlight >}}
