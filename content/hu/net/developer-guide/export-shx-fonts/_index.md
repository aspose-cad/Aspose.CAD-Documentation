---
title: SHX betűtípusok exportálása
type: docs
weight: 40
url: /hu/net/developer-guide/export-shx-fonts/
---

## **SHX betűtípusok exportálása DXF/DWG rajzokhoz**

Néhány rajz tartalmazhat betűtípusokat különleges SHX formátumban, amely a betűtípus szimbólumait formák formájában tárolja. Ez a formátum további
betöltési eljárást igényel minden betűtípushoz, amelyet a rajzban használnak. Az Apose.CAD képes SHX-ban írt szöveggel exportálni a rajzokat, és különböző lehetőségei vannak ennek megvalósítására. A legegyszerűbb módja ennek az, ha egyszerűen használjuk a 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) tulajdonságot a 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objektumban.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts példa.cs">}}


Lehetséges elkerülni az összes elérési út beállítását több SHX betűtípushoz a következő példával:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts mappával példa.cs">}}
	
Minden SHX betűtípushoz a megfelelő kódoldal tartozik. Ezek az összefüggések ismertek, és részben beépítve vannak az Aspose.CAD-be a jól ismert SHX betűtípusokhoz.
Ha egyéni SHX betűtípust használnak, lehetőség van a ShxCodePages tulajdonság alkalmazására, és az SHX fájlhoz és a megfelelő kódoldalhoz tartozó elérési út beállítására. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages példa.cs">}}
