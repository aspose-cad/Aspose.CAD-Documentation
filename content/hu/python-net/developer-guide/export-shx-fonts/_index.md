---
title: SHX betűtípusok exportálása
type: docs
weight: 40
url: /hu/python-net/developer-guide/export-shx-fonts/
---

## **SHX betűtípusok exportálása DXF/DWG rajzokhoz**

Egyes rajzok tartalmazhatnak betűtípusokat különleges SHX formátumban, amely a betűtípus szimbólumait formák formájában tárolja. Ez a formátum további
betöltési eljárást igényel minden egyes betűtípushoz, amelyet a rajzban használnak. Az Apose.CAD képes exportálni a rajzokat SHX-ben írt szövegekkel, és különböző lehetőségei vannak ennek végrehajtására. A legegyszerűbb módja ennek az, ha egyszerűen használja a 
**ShxFonts** tulajdonságot a 
**CadRasterizationOptions** objektumban.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
