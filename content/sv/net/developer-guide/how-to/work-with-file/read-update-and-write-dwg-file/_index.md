---
title: Läsa, uppdatera och skriva DWG-fil
type: docs
weight: 11
url: /sv/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **Hur man läser, uppdaterar och skriver DWG-fil**

**Problem:** Hur man läser, uppdaterar och skriver DWG-fil.

**Tips:** För att göra detta kan du hämta filen med hjälp av metoden load, få de nödvändiga entiteterna och göra ändringar i dem, som att ändra start- och slutpunkter eller linjernas tjocklek.

**Obs:** Denna kodsnutt visar ett exempel på att läsa en dwg-fil, ändra objekt: positionerna för linjer, cirklar, textvärden (du kan lägga till ändringar i andra objekt och deras värden som stödjer läsning/skrivning) och sedan spara till en ny fil. Så du kan öppna en ny fil i AutoCAD och se objekt med ändrade värden.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
