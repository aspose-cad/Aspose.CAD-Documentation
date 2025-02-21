---
title: Lees, update en schrijf DWG-bestand
type: docs
weight: 11
url: /nl/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Hoe een DWG-bestand te lezen, bij te werken en te schrijven**

**Probleem:** Hoe een DWG-bestand te lezen, bij te werken en te schrijven.

**Tips:** Hiervoor kun je het bestand ophalen met de load-methode, de benodigde entiteiten verkrijgen en wijzigingen aanbrengen, zoals het veranderen van de begin- en eindpunten of de dikte van de lijnen.

**Opmerking:** Dit codefragment toont een voorbeeld van het lezen van een dwg-bestand, het veranderen van objecten: de posities van lijnen, cirkels, tekstwaarden (je kunt wijzigingen toevoegen aan andere objecten en hun waarden waarvoor lezen/schrijven wordt ondersteund) en vervolgens opslaan in een nieuw bestand. Zo kun je een nieuw bestand openen in AutoCAD en objecten met gewijzigde waarden zien.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
