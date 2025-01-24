---
title: DWG DXF zu PDF C# | Auto CAD Dateien in PDF JPEG PNG in C# .NET konvertieren
type: docs
weight: 30
url: /de/net/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG zu PDF C#, DXF zu PDF C#, DWF DWT zu PDF C#, AutoCAD konvertieren, DWG konvertieren, DWF konvertieren, DWT konvertieren, DXF konvertieren, AutoCAD zu PDF konvertieren, DWG zu PDF konvertieren, DWG zu PNG konvertieren, DWG zu TIFF konvertieren, DWG zu JPG konvertieren"
description: Verwenden Sie den C# .NET AutoCAD zu PDF Konverter, um DWG oder DXF in PDF zu konvertieren. Sie können DWG, DWF, DWT und DXF in PDF, JPEG, PNG, BMP, GIF und TIFF in C# .NET konvertieren.
---

## **DWG oder DXF in PNG JPEG BMP GIF oder TIFF in C# konvertieren**

Aspose.CAD für .NET kann AutoCAD Zeichnungsformate wie [DXF](https://docs.fileformat.com/cad/dxf/) und [DWG](https://docs.fileformat.com/cad/dwg/) in [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) und [GIF](https://docs.fileformat.com/image/gif/) konvertieren. Es hat eine effiziente und benutzerfreundliche API bereitgestellt, um dieses Ziel zu erreichen.

Sie können jedes unterstützte AutoCAD Zeichnungsformat in Rasterbildformate mit den einfachen Schritten konvertieren, wie unten erläutert.

1. Laden Sie die AutoCAD DWG oder DXF Datei in die [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) Klasse.
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Setzen/ändern Sie die Größe des Bildes mit [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) und [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Erstellen Sie eine Instanz von [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Setzen Sie die [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) Eigenschaft auf die [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions), die im vorherigen Schritt erstellt wurde.
1. Speichern Sie die AutoCAD Zeichnung als PDF mit [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), indem Sie den Dateipfad (oder ein Objekt von MemoryStream) sowie die Instanz von [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase), die im vorherigen Schritt erstellt wurde, übergeben.

Hier ist der komplette Quellcode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Standardmäßig rendert die API nur das "Model" Layout. Sie können jedoch auch die Layouts Ihrer Wahl angeben, während Sie CAD Zeichnungen in Bildformate konvertieren.

## **CAD Konvertierung anpassen**

Die CAD zu [PDF](https://docs.fileformat.com/pdf/) & CAD zu Rasterbild-Konvertierungsverfahren sind hochgradig konfigurierbar, da die [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse so implementiert wurde, dass sie viele optionale Funktionen bietet, die durch Setzen die Renderprozess entsprechend den Anforderungen der Anwendung überschreiben können.

### **CadRasterizationOptions Klasse**

Die **CadRasterizationOptions** Klasse ist für alle unterstützten CAD Formate wie DWG & DXF allgemein, daher sind die in diesem Artikel geteilten Informationen für beide vorgenannten CAD Formate gültig.

Die nützlichsten Eigenschaften der **CadRasterizationOptions** Klasse sind:

|**Eigenschaft**|**Standardwert**|**Erforderlich**|**Beschreibung**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ja|Bestimmt die Seitenbreite.|
|**PageHeight**|**0**|Ja|Bestimmt die Seitenhöhe|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nein|Bestimmt, ob die Zeichnung automatisch skaliert werden soll. Der Standardwert reduziert automatisch das Bild, um es an die Leinwandgröße anzupassen. Stellen Sie auf den **GrowToFit**-Modus um oder verwenden Sie die **None**-Einstellung, um die automatische Skalierung zu deaktivieren.|
|**BackgroundColor**|**Color.White**|Nein|Bestimmt die Hintergrundfarbe des Ausgabebildes.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nein|Bestimmt den Farbmodus der Entität. Geben Sie die **UseObjectColor**-Option an, um Entitäten mit ihrer natürlichen Farbe zu zeichnen, oder die **UseDrawColor**-Option, um die natürlichen Farben zu überschreiben.|
|**DrawColor**|**Color.Black**|Nein|Bestimmt die überschreibene Farbe der Entität (nur wenn **DrawType** auf den Wert der **UseDrawColor** Eigenschaft gesetzt ist).|
|**AutomaticLayoutsScaling**|False|Nein|Bestimmt, ob die automatische Layoutskalierung ausgeführt werden muss, um das Modell-Layout anzupassen.|

### **Einstellung der Leinwandgröße & des Modus**

Der Export von CAD nach PDF oder CAD in Rasterbildformate ist keine triviale Aufgabe. Da das resultierende PDF oder Bild die Definition der Leinwandgröße erfordert, müssen wir die Ausmaße für die PDF-Seite festlegen, um die Zeichnung richtig darzustellen. Setzen Sie die Eigenschaften **CadRasterizationOptions.PageWidth** und **CadRasterizationOptions.PageHeight** explizit, oder Sie erhalten eine **ImageSaveException**.

Zusätzlich können Sie auch Dimensionsskalierungsoptionen angeben. Die Skalierungsoptionen werden durch die Eigenschaft **CadRasterizationOptions.ScaleMethod** festgelegt. Verwenden Sie diese Option, um die Bilddimensionen gemäß den Werten von **CadRasterizationOptions.PageWidth** und **CadRasterizationOptions.PageHeight** automatisch anzupassen. Standardmäßig ist **CadRasterizationOptions.ScaleMethod** auf den Modus **ScaleType.ShrinkToFit** eingestellt. Diese Eigenschaft definiert das folgende Verhalten:

- Wenn die Abmessungen der CAD Zeichnung größer als die resultierende Leinwandgröße sind, werden die Abmessungen der Zeichnung verkleinert, um in die resultierende Leinwand zu passen, während das Seitenverhältnis beibehalten wird.
- Wenn die Abmessungen der CAD Zeichnung kleiner sind als die resultierende Leinwandgröße, setzen Sie die Eigenschaft **CadRasterizationOptions.ScaleMethod** auf **ScaleType.GrowToFit**, um die Zeichnungsgröße zu erhöhen, damit sie in die PDF-Leinwand passt, während das Seitenverhältnis beibehalten wird.
- Oder deaktivieren Sie die automatische Skalierung mit der **ScaleType.None**-Option.

Die folgende Beispielanwendung zeigt die Nutzung der automatischen Skalierungsoption.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Hintergrund- & Zeichnungsfarben festlegen**

Standardmäßig wird die Farbpalette für die resultierende Leinwand auf das allgemeine Dokumentenlayout eingestellt. Das bedeutet, dass alle Entitäten innerhalb der CAD Zeichnung mit einem schwarzen Farbstift auf einem einfarbigen weißen Hintergrund gezeichnet werden. Diese Einstellungen können mit den Eigenschaften **CadRasterizationOptions.BackgroundColor** und **CadRasterizationOptions.DrawColor** geändert werden. Das Ändern der **CadRasterizationOptions.DrawColor**-Eigenschaft erfordert ebenfalls die Einstellung der **CadRasterizationOptions.DrawType**-Eigenschaft, um die verwendete Zeichnungsfarbe zu nutzen. Die **CadRasterizationOptions.DrawType**-Eigenschaft steuert, ob CAD-Entitäten ihre Farben beibehalten oder in benutzerdefinierte Farben umgewandelt werden. Um die Farben der Entitäten zu erhalten, geben Sie **CadRasterizationOptions.DrawType** als **CadDrawTypeMode.UseObjectColor** an, andernfalls geben Sie den Wert **CadDrawTypeMode.UseDrawColor** an.

Die folgende Beispielanwendung zeigt, wie man verschiedene Farbeigenschaften verwendet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Automatische Layout-Skalierung festlegen**

Die meisten CAD Zeichnungen haben mehr als ein Layout, das in einer einzigen Datei gespeichert ist, und jedes Layout könnte unterschiedliche Abmessungen haben. Beim Rendern solcher CAD Zeichnungen in PDF könnte jede Seite des PDFs unterschiedliche Skalierungen gemäß der Layoutgröße aufweisen. Um das Rendering homogen zu gestalten, haben die Aspose.CAD APIs die Eigenschaft **CadRasterizationOptions.AutomaticLayoutsScaling** bereitgestellt. Ihr Standardwert ist **false**, aber wenn sie wahr ist, versucht die API, eine entsprechende Skalierung für jedes separate Layout zu finden und diese entsprechend durchzuführen, indem die automatische Größenänderung gemäß der Seitengröße erfolgt.

Hier ist, wie die **CadRasterizationOptions.AutomaticLayoutsScaling**-Eigenschaft in Zusammenarbeit mit der **CadRasterizationOptions.ScaleMethod**-Eigenschaft funktioniert.

1. Wenn **ScaleMethod** auf **ScaleType.ShrinkToFit** oder **ScaleType.GrowToFit** und **AutomaticLayoutsScaling** auf false gesetzt ist, werden alle Layouts (einschließlich des Modells) gemäß der ersten Option verarbeitet.
1. Wenn **ScaleMethod** auf **ScaleType.ShrinkToFit** oder **ScaleType.GrowToFit** und **AutomaticLayoutsScaling** auf true gesetzt ist, werden alle Layouts (außer dem Modell) gemäß ihrer Größe verarbeitet, während das Modell gemäß der ersten Option verarbeitet wird.
1. Wenn **ScaleMethod** auf **ScaleType.None** und **AutomaticLayoutsScaling** auf true oder false gesetzt ist, wird keine Skalierung durchgeführt.

Die folgende Beispielanwendung zeigt, wie man die automatische Layoutskalierung für die CAD zu PDF-Konvertierung festlegt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **AutoCAD DXF oder DWG Layouts in PNG oder andere Bildformate in C# konvertieren**

Aspose.CAD für .NET API kann CAD Layouts von unterstützten Formaten wie DXF und DWG in PNG, BMP, TIFF, JPEG und GIF konvertieren. Die API bietet auch Unterstützung dafür, spezifische Layouts einer CAD Zeichnung in verschiedene PSD-Schichten zu rendern.

Hier ist, wie Sie dasselbe in den folgenden einfachen Schritten erreichen können.

- Laden Sie die AutoCAD DWG oder DXF Datei mit der **Image** Klasse.
- Setzen/ändern Sie die Breite und Höhe des Bildes.
- Setzen Sie die gewünschten Layoutnamen mit der CadRasterizationOptions.Layouts-Eigenschaft.
- Erstellen Sie eine Instanz von **ImageOptionsBase** und setzen Sie deren **VectorRasterizationOptions**-Eigenschaft auf die Instanz von **CadRasterizationOptions**, die im vorherigen Schritt erstellt wurde.
- Speichern Sie das CAD Layout als TIFF oder Bild.

Hier ist der komplette Quellcode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}}

Die Eigenschaft **CadRasterizationOptions.Layouts** ist vom Typ String-Array, sodass Sie mehr als ein Layout gleichzeitig für die mögliche Konvertierung in Bildformate angeben können. Wenn Sie mehrere Layouts für die **CadRasterizationOptions.Layouts**-Eigenschaft angeben, hat das resultierende TIFF-Bild mehrere Seiten, das GIF-Bild mehrere Frames und das [PSD](https://docs.fileformat.com/image/psd/) Format mehrere Schichten, wobei jede Seite/Frame/Schicht ein individuelles AutoCAD Layout darstellt. Falls ein anderes Bildformat wie PNG, BMP, JPEG zum Speichern des Ergebnisses ausgewählt wird, rendert die API nur das Standardlayout, das "Modell" ist.

{{% /alert %}}

## **Verfolgung des CAD Rendering-Prozesses aktivieren**

Aspose.CAD hat eine Reihe von Klassen und unterstützenden Enumerationsfeldern eingeführt, um bei der Verfolgung des CAD Rendering-Prozesses zu helfen. Mit diesen Änderungen kann die CAD zu PDF Konvertierung nun wie folgt durchgeführt werden, während die Verfolgung aktiviert ist.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Die Verfolgung des CAD Rendering-Prozesses kann die folgenden möglichen Probleme erkennen:

1. Fehlende oder beschädigte Kopfzeileninformationen.
1. Fehlende Layoutinformationen.
1. Fehlende Blockentitäten.
1. Fehlende Dimensionstile.
1. Fehlende Stile.

## **Schriftarten beim Konvertieren von CAD Zeichnungen ersetzen**

Es ist durchaus möglich, dass eine bestimmte CAD Zeichnung eine spezifische Schriftart verwendet, die nicht auf dem Computer verfügbar ist, auf dem die CAD zu PDF oder CAD zu Rasterbild-Konvertierung stattfindet. In solchen Situationen wird die Aspose.CAD API eine entsprechende Ausnahme auslösen, um die fehlenden Schriftarten hervorzuheben und den Konvertierungsprozess zu stoppen, da die API diese Schriftarten benötigt, um die Inhalte richtig in die resultierenden PDFs oder Bilder darzustellen.

Die Aspose.CAD API bietet eine einfache Möglichkeit, den Mechanismus zur Substitution der benötigten Schriftarten mit verfügbaren Schriftarten zu verwenden. Die **CadImage.Styles**-Eigenschaft gibt eine Instanz von **CadStylesDictionary** zurück, die wiederum das **CadStyleTableObject** für jeden Stil in der CAD Zeichnung enthält, während der **CadStyleTableObject.PrimaryFontName** verwendet werden kann, um den verfügbaren Schriftartnamen anzugeben.

Der folgende Codeausschnitt demonstriert die Verwendung der Aspose.CAD für .NET API, um die Schriftart aller Stile in einer CAD Zeichnung zu ändern.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Es ist auch möglich, die Schriftart nur eines bestimmten Stils zu ändern, indem man über den Stilnamen darauf zugreift. Der folgende Codeausschnitt demonstriert die Verwendung dieses Ansatzes.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **CAD Layer in Rasterbildformate konvertieren**

Aspose.CAD für .NET API hat eine effiziente und benutzerfreundliche Möglichkeit bereitgestellt, den Namen des benötigten CAD Layers festzulegen und diesen in Rasterbildformate zu rendern. Hier ist, wie Sie dasselbe in 5 einfachen Schritten erreichen können:

1. Laden Sie die CAD Datei in eine Instanz von **Image** unter Verwendung der Fabrikmethode **Load**.
1. Erstellen Sie eine Instanz von **CadRasterizationOptions** und setzen Sie deren obligatorische Eigenschaften wie **PageWidth** & **PageHeight**.
1. Fügen Sie den gewünschten Layernamen mithilfe der **CadRasterizationOptions.Layers.Add**-Methode hinzu.
1. Erstellen Sie eine Instanz von **ImageOptionsBase** und setzen Sie deren **VectorRasterizationOptions**-Eigenschaft auf die Instanz von **CadRasterizationOptions**, die im vorherigen Schritt erstellt wurde.
1. Rufen Sie die **Image.Save**-Methode auf, indem Sie den Dateipfad (oder ein Objekt von MemoryStream) sowie die Instanz von **ImageOptionsBase**, die im vorherigen Schritt erstellt wurde, übergeben.

Hier ist der komplette Quellcode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Alle CAD Layer in separate Bilder konvertieren**

Sie können alle Layer aus einer CAD Zeichnung mithilfe der **CadImage.Layers** abrufen und jeden Layer in ein separates Bild rendern, wie unten demonstriert.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **DWF CAD Layer in Rasterbildformate konvertieren**

Aspose.CAD für .NET API hat eine effiziente und benutzerfreundliche Möglichkeit bereitgestellt, den Namen des benötigten CAD Layers festzulegen und diesen in Rasterbildformate zu rendern. Hier ist, wie Sie dasselbe in 5 einfachen Schritten erreichen können:

1. Laden Sie die DWF CAD Datei in eine Instanz von **Image** unter Verwendung der Fabrikmethode **Load**.
1. Erstellen Sie eine Instanz von **CadRasterizationOptions** und setzen Sie deren obligatorische Eigenschaften wie **PageWidth** & **PageHeight**.
1. Fügen Sie den gewünschten Layernamen mithilfe der **CadRasterizationOptions.Layers.Add**-Methode hinzu.
1. Erstellen Sie eine Instanz von **ImageOptionsBase** und setzen Sie deren **VectorRasterizationOptions**-Eigenschaft auf die Instanz von **CadRasterizationOptions**, die im vorherigen Schritt erstellt wurde.
1. Rufen Sie die **Image.Save**-Methode auf, indem Sie den Dateipfad (oder ein Objekt von MemoryStream) sowie die Instanz von **ImageOptionsBase**, die im vorherigen Schritt erstellt wurde, übergeben.

Hier ist der komplette Quellcode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD für .NET schreibt direkt die Informationen über die API und die Versionsnummer in die Ausgabedokumente. Zum Beispiel füllt Aspose.CAD für .NET das Anwendungsfeld mit dem Wert 'Aspose.CAD' und das PDF Producer-Feld mit einem Wert, z.B. 'Aspose.CAD v 17.10'.

Bitte beachten Sie, dass Sie Aspose.CAD für .NET nicht anweisen können, diese Informationen aus den Ausgabedokumenten zu ändern oder zu entfernen.