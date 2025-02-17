---
title: SHX betűtípusok exportálása
type: docs
weight: 40
url: /hu/java/developer-guide/export-shx-fonts/
---

## **SHX betűtípusok exportálása DXF/DWG rajzokhoz**

Egyes rajzok különleges SHX formátumban tárolhatják a betűtípusokat, ami a betűtípus szimbólumait formák formájában tárolja. 
Ez a formátum további betöltési eljárást igényel minden használt betűtípushoz a rajzban. 
Az Apose.CAD képes SHX-ban írt szöveget tartalmazó rajzokat exportálni, és különböző lehetőségei vannak erre. 
A legegyszerűbb módja ennek a [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) tulajdonság használata a [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objektumban.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Minden SHX betűtípus a megfelelő kódoldallal rendelkezik, ami hozzá van rendelve. Ezek az asszociációk ismertek és részben be vannak ágyazva az Aspose.CAD-be a jól ismert SHX betűtípusok esetén. 
Ha egy egyedi SHX betűtípust használnak, akkor a **setShxCodePages** tulajdonságot lehet alkalmazni, és meg lehet adni a SHX fájl elérési útját és a megfelelő kódoldalt.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
