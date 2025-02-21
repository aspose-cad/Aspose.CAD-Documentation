---
title: Förklaring av cachebeteende i Aspose.CAD
type: docs
weight: 20
url: /sv/common/caching-behaviour-explanation/
---


## **Hur Aspose.CAD cachar data**

All caching som görs av Aspose.CAD är helt automatisk, utan någon användarinmatning som behövs eller är möjlig. Det finns i huvudsak tre typer av caching, alla är relaterade till teckensnitt.

### **Cache för teckensnittsnamn**

Cache för teckensnittsnamn används för att underlätta snabbare uppstart genom att förbearbeta alla hittade teckensnittsfiler och sammanställa en lista över teckensnittsnamn som finns i dessa filer, eftersom en teckensnittsfil kan innehålla mer än ett teckensnitt. Den lagras som en temporär fil och är som mest tiotals kilobyte stor för de flesta system.

### **Cache för teckensnittsglyphdata**

En cache i minnet av alla glyphs som har använts under applikationens livslängd för att minska omläsning av faktiska teckensnittsfiler på disken under efterföljande exporter. Som sådan skulle det resultera i stadigt ökande minnesanvändning om efterföljande exporter skulle ha filer som refererar till nya teckensnitt och/eller innehåller tecken som inte tidigare har förekommit. Men i praktiken, även på hela 
Aspose.CAD:s testsvit, med tusentals filer inklusive filer på olika språk, är dess minnesanvändning cirka 200 megabyte, vilket inte är särskilt signifikant för ett modernt system.

### **Cache för teckensnittsalternativ per tecken**

En cache i minnet som lagrar teckensnitt som innehåller ett givet tecken för alla Unicode-tecken för att underlätta valet av ett ersättningsteckensnitt i händelse av att ett teckensnitt som tillhandahålls av en texthanterare i en ritning inte innehåller ett tecken i den enhetens textinnehåll. Den byggs vid den första exportoperationen under applikationens livslängd och finns kvar tills applikationen terminera. På våra relativt blygsamma testmaskiner med omfattande teckensnittssamlingar som används i testsviterna, tar cachen cirka 30 sekunder att bygga och tar 70 megabyte. När den väl är byggd, tar den inte längre någon tid och växer inte.
