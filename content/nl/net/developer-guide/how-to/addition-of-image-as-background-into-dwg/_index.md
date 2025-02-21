---
title: Toevoegen van een afbeelding als achtergrond in DWG
type: docs
weight: 15
url: /nl/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Hoe een afbeelding als achtergrond in DWG toe te voegen**

**Probleem:** Hoe een afbeelding als achtergrond in DWG toe te voegen.

**Tips:** Om dit te doen, maak je een CadRasterImageDef-object voor de achtergrondafbeelding, maak je een CadRasterImage-object om de achtergrond voor de tekening in te voegen, voeg je een CadRasterImage-object toe aan de tekenobjecten, maak je een CadBaseObject CadBaseObject en voeg je het toe aan cadImage.Objects, verwerk alles via CadBlockTableObject.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
