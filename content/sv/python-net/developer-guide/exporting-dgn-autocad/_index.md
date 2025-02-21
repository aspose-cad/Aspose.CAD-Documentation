---
title: Exportera DGN AutoCAD
type: docs
weight: 50
url: /sv/python-net/developer-guide/exporting-dgn-autocad/
---

## **Exportera DGN AutoCAD-format till PDF**

Aspose.CAD för Python API har introducerat funktionen att ladda en DGN AutoCAD-fil och konvertera den till PDF-format. **CadImage** klassen tjänar detta syfte.

Du behöver ladda en befintlig DGN-fil som **CadImage**. Skapa en instans av **CadRasterizationOptions** klassen och ställ in olika egenskaper. Skapa en instans av **PdfOptions** klassen och skicka **CadRasterizationOptions** instansen. Anropa nu **save** metoden av **CadImage** klassinstansen.

### Exempel på kod

Följande är koddemonstrationen för att konvertera/exportera [DGN](https://docs.fileformat.com/cad/dgn/) till [PDF](https://docs.fileformat.com/pdf/) format.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exportera DGN AutoCAD-format till rasterbildsformat**

Aspose.CAD för Python API har introducerat funktionen att ladda en DGN AutoCAD-fil och konvertera den till en rasterbild. **CadImage** klassen tjänar detta syfte.

Du behöver ladda en befintlig DGN-fil som **CadImage**. Skapa en instans av **CadRasterizationOptions** klassen och ställ in olika egenskaper. Skapa en instans av **JpegOptions** klassen och skicka **CadRasterizationOptions** instansen. Anropa nu **save** metoden av **CadImage** klassinstansen.

### Exempel på kod

Följande är koddemonstrationen för att konvertera/exportera [DGN](https://docs.fileformat.com/cad/dgn/) till [JPEG](https://docs.fileformat.com/image/jpeg/) bild.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **3D-entiteter stöd för DGN v7**

Aspose.CAD för Python API har introducerat funktionen att ladda en [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-fil och stödja 3D-entiteter för DGN v7. **CadImage** klassen tjänar detta syfte. Varje [DGN](https://docs.fileformat.com/cad/dgn/) bild stöder 9 fördefinierade vyer. Det är numrerat från 1 till 9. Om vy inte definieras vid export, kommer alla vyer att exporteras för fler-sidiga utdataformat (som PDF), var och en på en separat sida. 3D-entiteter stöds i DGN filformat, såväl som 2D. För detta används **VectorRasterizationOptions**, TypeOfEntities används inte längre för DGN-format (både 2D och 3D stöds samtidigt).

### Exempel på kod

Följande är exempel på kod för att se stödda DGN-element.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
