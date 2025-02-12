---
title: Konvertieren von CAD-Zeichnungen in PDF- und Rasterbildformate
type: docs
weight: 30
url: /de/java/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD für Java schreibt direkt die Informationen über API und Versionsnummer in Ausgabedokumente. Beispielsweise füllt Aspose.CAD für Java beim Rendern eines Dokuments in PDF das Feld Anwendung mit dem Wert 'Aspose.CAD' und das Feld PDF-Produzent mit einem Wert wie 'Aspose.CAD v 17.9'.

Bitte beachten Sie, dass Sie Aspose.CAD für Java nicht anweisen können, diese Informationen aus den Ausgabedokumenten zu ändern oder zu entfernen.

{{% /alert %}} 
## **Konvertieren von CAD-Zeichnungen in Rasterbildformate**
Aspose.CAD für Java kann CAD-Zeichnungsformate wie [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) in die unterstützten Rasterbildformate wie [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/) konvertieren. Die Aspose.CAD API für Java bietet effiziente und benutzerfreundliche Mittel, um dieses Ziel zu erreichen.
Sie können jedes unterstützte CAD-Zeichnungsformat in Rasterbildformate umwandeln, indem Sie die nachstehend ausführlich erläuterten einfachen Schritte befolgen.

1. Laden Sie die CAD-Datei in eine Instanz von [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Erstellen Sie eine Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und setzen Sie die obligatorischen Eigenschaften wie [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Erstellen Sie eine Instanz von **ImageOptionsBase** und setzen Sie seine [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) Eigenschaft auf die in Schritt 2 erstellte Instanz von **CadRasterizationOptions**.
1. Rufen Sie **Image.save** auf, indem Sie den Dateipfad (oder ein MemoryStream-Objekt) sowie die Instanz von [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) übergeben, die im vorherigen Schritt erstellt wurde.

Hier ist der vollständige Quellcode.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Standardmäßig rendert die API nur das "Model"-Layout. Sie können jedoch auch die Layouts Ihrer Wahl angeben, wenn Sie CAD-Zeichnungen in Bildformate konvertieren.
## **Anpassung der CAD-Konvertierung**
Die CAD zu [PDF](https://docs.fileformat.com/pdf/) & CAD zu Rasterbildkonvertierungsverfahren sind hoch konfigurierbar, da die [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) Klasse so implementiert ist, dass sie viele optionale Funktionen bietet, die beim Setzen den Renderingprozess gemäß den Anwendungsanforderungen überschreiben können.
### **Klasse CadRasterizationOptions**
Die [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) Klasse ist für alle unterstützten CAD-Formate wie [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/) gemeinsam, daher sind die Informationen in diesem Artikel gleichermaßen für beide genannten CAD-Formate gültig.

Die nützlichsten Eigenschaften der **CadRasterizationOptions** Klasse sind:

|**Eigenschaft**|**Standardwert**|**Erforderlich**|**Beschreibung**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Ja|Gibt die Seitenbreite an.|
|**PageHeight**|**0**|Ja|Gibt die Seitenhöhe an.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Nein|Gibt an, ob die Zeichnung automatisch skaliert werden soll. Der Standardwert verkleinert automatisch das Bild, um in die Leinwandgröße zu passen. Wechseln Sie zum **GrowToFit**-Modus oder verwenden Sie die **None**-Einstellung, um die automatische Skalierung zu deaktivieren.|
|**BackgroundColor**|**Color.White**|Nein|Gibt die Hintergrundfarbe des Ausgabebildes an.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Nein|Gibt den Farbmodus der Entität an. Geben Sie die Option **UseObjectColor** an, um Entitäten in ihrer nativen Farbe zu zeichnen, oder die Option **UseDrawColor**, um native Farben zu überschreiben.|
|**DrawColor**|**Color.Black**|Nein|Gibt die Farbe der überschriebenen Entität an (nur wenn **DrawType** auf den Wert der **UseDrawColor**-Eigenschaft gesetzt ist).|
|**AutomaticLayoutsScaling**|False|Nein|Gibt an, ob eine automatische Layoutskalierung durchgeführt werden soll, um das Modell-Layout anzupassen.|
### **Festlegen der Leinwandgröße und des Modus**
Der Export von CAD nach PDF oder von CAD in Rasterbildformate ist keine triviale Aufgabe. Da das resultierende PDF oder Bild die Leinwandgröße definiert benötigt, müssen die Ausgabedimensionen für die PDF-Seite spezifiziert werden, um die Zeichnung ordnungsgemäß zu rendern. Setzen Sie die Eigenschaften **CadRasterizationOptions.PageWidth** und **CadRasterizationOptions.PageHeight** explizit oder es wird eine **ImageSaveException** ausgelöst.

Zusätzlich können Dimensions-Skalierungsoptionen angegeben werden. Die Skalierungsoptionen werden durch die **CadRasterizationOptions.ScaleMethod** Eigenschaft festgelegt. Verwenden Sie diese Option, um die Bildabmessungen automatisch gemäß den Werten von **CadRasterizationOptions.PageWidth** und **CadRasterizationOptions.PageHeight** anzupassen. Standardmäßig ist **CadRasterizationOptions.ScaleMethod** auf den Modus **ScaleType.ShrinkToFit** gesetzt. Diese Eigenschaft definiert das folgende Verhalten:

- Wenn die CAD-Zeichnungsmaße größer als die resultierende Leinwandgröße sind, werden die Zeichnungsmaße verkleinert, um in die resultierende Leinwand zu passen, während das Seitenverhältnis erhalten bleibt.
- Sind die CAD-Zeichnungsmaße kleiner als die resultierende Leinwandgröße, setzen Sie die **CadRasterizationOptions.ScaleMethod** Eigenschaft auf den Modus **ScaleType.GrowToFit**, um die Zeichnungsgröße zu erhöhen, damit sie in das PDF-Cover passt, während das Seitenverhältnis erhalten bleibt.
- Oder deaktivieren Sie die automatische Skalierung mit der Option **ScaleType.None**.

Das folgende Codebeispiel zeigt die Verwendung der automatischen Skalierungsoption.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Festlegen von Hintergrund- & Zeichenfarben**
Standardmäßig ist die Farbpalette für die resultierende Leinwand dem üblichen Dokumentschema zugeordnet. Das bedeutet, dass alle Elemente innerhalb der CAD-Zeichnung mit einem schwarzen Farbstift auf einem einfarbigen weißen Hintergrund gezeichnet werden. Diese Einstellungen können mit den Eigenschaften **CadRasterizationOptions.BackgroundColor** und **CadRasterizationOptions.DrawColor** geändert werden. Die Änderung der **CadRasterizationOptions.DrawColor** Eigenschaft erfordert auch das Setzen der **CadRasterizationOptions.DrawType** Eigenschaft, um die Verwendung der Zeichenfarbe zu ermöglichen. Die **CadRasterizationOptions.DrawType** Eigenschaft steuert, ob CAD-Entitäten ihre Farben beibehalten oder in benutzerdefinierte Farben konvertiert werden. Um die Farben der Entitäten beizubehalten, geben Sie **CadRasterizationOptions.DrawType** als **CadDrawTypeMode.UseObjectColor** an, andernfalls geben Sie den Wert **CadDrawTypeMode.UseDrawColor** an.

Das folgende Codebeispiel zeigt, wie verschiedene Farbeigenschaften verwendet werden können.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Einstellen der automatischen Layoutskalierung**
Die meisten CAD-Zeichnungen enthalten mehrere Layouts in einer einzelnen Datei, wobei jedes Layout unterschiedliche Abmessungen haben kann. Beim Rendern solcher CAD-Zeichnungen in PDF könnte jede Seite des PDF entsprechend der Layoutgröße unterschiedlich skaliert sein. Um das Rendering homogen zu gestalten, haben die Aspose.CAD APIs die **CadRasterizationOptions.AutomaticLayoutsScaling** Eigenschaft bereitgestellt. Ihr Standardwert ist **false,** aber wenn **true**, wird die API versuchen, für jedes separate Layout eine entsprechende Skala zu suchen und sie entsprechend zu zeichnen, indem automatisch eine Größenänderung entsprechend der Seitengröße vorgenommen wird.

So funktioniert die **CadRasterizationOptions.AutomaticLayoutsScaling** Eigenschaft in Zusammenarbeit mit der **CadRasterizationOptions.ScaleMethod** Eigenschaft.

1. Wenn **ScaleMethod** auf **ScaleType.ShrinkToFit** oder **ScaleType.GrowToFit** mit **AutomaticLayoutsScaling** auf false gesetzt ist, werden alle Layouts (einschließlich des Modells) gemäß der ersten Option verarbeitet.
1. Wenn **ScaleMethod** auf **ScaleType.ShrinkToFit** oder **ScaleType.GrowToFit** mit **AutomaticLayoutsScaling** auf true gesetzt ist, werden alle Layouts (außer dem Modell) gemäß ihrer Größe verarbeitet, wobei das Modell gemäß der ersten Option verarbeitet wird.
1. Wenn **ScaleMethod** auf **ScaleType.None** mit **AutomaticLayoutsScaling** auf true oder false gesetzt ist, wird keine Skalierung durchgeführt.

Das folgende Codebeispiel zeigt, wie die automatische Layoutskalierung für die CAD zu PDF-Konvertierung eingestellt wird.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Konvertieren von CAD-Layouts in Rasterbildformate**
Die Aspose.CAD API für Java ist in der Lage, CAD-Layouts von unterstützten Formaten wie DXF & DWG in Rasterbilder wie PNG, BMP, TIFF, JPEG & GIF zu konvertieren. Die API bietet auch die Unterstützung, um spezifische Layouts einer CAD-Zeichnung in verschiedene PSD-Ebenen zu rendern.
Die Aspose.CAD API für Java hat effiziente und benutzerfreundliche Mittel bereitgestellt, um die Liste der erforderlichen CAD-Layouts anzugeben und sie in Rasterbildformate zu rendern. Hier ist, wie Sie in 5 einfachen Schritten dasselbe erreichen können.

1. Laden Sie die CAD-Datei in eine Instanz von **Image** mithilfe der Factory-Methode **load**.
1. Erstellen Sie eine Instanz von **CadRasterizationOptions** und setzen Sie seine obligatorischen Eigenschaften wie **PageWidth** & **PageHeight**.
1. Geben Sie den gewünschten Layoutnamen mit der CadRasterizationOptions.Layouts-Eigenschaft an.
1. Erstellen Sie eine Instanz von **ImageOptionsBase** und setzen Sie seine **VectorRasterizationOptions**-Eigenschaft auf die in Schritt 2 erstellte Instanz von **CadRasterizationOptions**.
1. Rufen Sie **Image.Save** auf, indem Sie den Dateipfad (oder ein MemoryStream-Objekt) sowie die Instanz von **ImageOptionsBase** übergeben, die im vorherigen Schritt erstellt wurde.

Hier ist der vollständige Quellcode.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Die Eigenschaft **CadRasterizationOptions.Layouts** ist vom Typ Zeichenfolgenarray, sodass Sie mehr als ein Layout gleichzeitig für eine mögliche Konvertierung in Bildformate angeben können. Wenn Sie mehrere Layouts für die **CadRasterizationOptions.Layouts**-Eigenschaft angeben, werden das resultierende TIFF-Bild mehrere Seiten enthalten, das GIF-Bild mehrere Frames und das PSD-Format mehrere Ebenen haben, wobei jede Seite/Frame/Ebene ein individuelles AutoCAD-Layout darstellt. Wenn ein anderes Bildformat wie PNG, BMP, JPEG ausgewählt wird, um das Ergebnis zu speichern, rendert die API nur das Standardlayout, nämlich "Model".

{{% /alert %}} 
## **Verfolgen der CAD-Renderingprozesse aktivieren**
Aspose.CAD hat eine Reihe von Klassen und unterstützenden Aufzählungsfeldern eingeführt, um das Verfolgen der CAD-Renderingprozesse zu erleichtern. Mit diesen Änderungen kann die CAD zu PDF-Konvertierung nun folgendermaßen erreicht werden, während das Verfolgen aktiviert ist.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Das Verfolgen des CAD-Renderingprozesses kann die folgenden möglichen Probleme erkennen.

1. Fehlende oder beschädigte Header-Informationen.
1. Fehlende Layout-Informationen.
1. Fehlende Blockentitäten.
1. Fehlende Dimension-Stile.
1. Fehlende Stile.
## **Schriftarten beim Konvertieren von CAD-Zeichnungen ersetzen**
Es ist durchaus möglich, dass eine bestimmte CAD-Zeichnung eine bestimmte Schriftart verwendet, die auf dem Computer, auf dem die CAD-zu-PDF- oder CAD-zu-Rasterbildkonvertierung stattfindet, nicht verfügbar ist. In solchen Situationen löst die Aspose.CAD API eine entsprechende Ausnahme aus, um auf die fehlenden Schriftarten hinzuweisen und den Konvertierungsprozess zu stoppen, da die API diese Schriftarten benötigt, um die Inhalte ordnungsgemäß auf das resultierende PDF und/oder die Bilder zu rendern.
Aspose.CAD API bietet eine einfache Möglichkeit, den Mechanismus zu nutzen, um die erforderlichen Schriftarten durch verfügbare Schriftarten zu ersetzen. Die **CadImage.Styles** Eigenschaft gibt eine Instanz von **CadStylesDictionary** zurück, die wiederum das **CadStyleTableObject** für jeden Stil in der CAD-Zeichnung enthält, wobei der **CadStyleTableObject.PrimaryFontName** verwendet werden kann, um den verfügbaren Schriftartnamen anzugeben.

Das folgende Code-Snippet zeigt die Verwendung der Aspose.CAD für Java API, um die Schriftart aller Stile in einer CAD-Zeichnung zu ändern.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Es ist auch möglich, die Schriftart nur eines bestimmten Stils zu ändern,