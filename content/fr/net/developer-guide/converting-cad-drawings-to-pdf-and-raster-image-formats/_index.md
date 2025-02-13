---
title: DWG DXF vers PDF C# | Convertir des fichiers Auto CAD en PDF JPEG PNG en C# .NET
type: docs
weight: 30
url: /fr/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG vers PDF C#, DXF vers PDF C#, DWF DWT vers PDF C#, convertir AutoCAD, convertir DWG, convertir DWF, convertir DWT, convertir DXF, convertir autocad en pdf, convertir DWG en PDF, convertir DWG en PNG, convertir DWG en TIFF, convertir DWG en JPG"
description: Utilisez le convertisseur AutoCAD en PDF C# .NET pour convertir DWG ou DXF en PDF en C#. Vous pouvez convertir DWG, DWF, DWT et DXF en PDF, JPEG, PNG, BMP, GIF et TIFF en C# .NET également.
---

## **Convertir DWG ou DXF en PNG JPEG BMP GIF ou TIFF en C#**

Aspose.CAD pour .NET peut convertir des formats de dessin AutoCAD tels que [DXF](https://docs.fileformat.com/cad/dxf/) et [DWG](https://docs.fileformat.com/cad/dwg/) en [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) et [GIF](https://docs.fileformat.com/image/gif/). Il expose une API efficace et facile à utiliser pour atteindre cet objectif.

Vous pouvez convertir tout format de dessin AutoCAD pris en charge en formats d'image raster en utilisant les étapes simples expliquées ci-dessous.

1. Chargez le fichier DWG ou DXF AutoCAD dans la classe [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Définissez/modifiez la taille de l'image en utilisant [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) et [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Créez une instance de [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) à l'instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) créée à l'étape précédente.
1. Enregistrez le dessin AutoCAD en tant que PDF avec [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Par défaut, l'API ne rend que la mise en page "Modèle". Cependant, vous pouvez également spécifier les mises en page de votre choix lors de la conversion de dessins CAD en formats image.

## **Personnaliser la conversion CAD**

Les procédures de conversion CAD en [PDF](https://docs.fileformat.com/pdf/) et CAD en image raster sont très configurables car la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) a été mise en œuvre de manière à fournir de nombreuses fonctionnalités optionnelles qui, une fois définies, peuvent remplacer le processus de rendu en fonction des besoins de l'application.

### **Classe CadRasterizationOptions**

La classe **CadRasterizationOptions** est commune à tous les formats CAD pris en charge tels que DWG et DXF, par conséquent, les informations partagées dans cet article sont valables pour les deux formats CAD susmentionnés.

Les propriétés les plus utiles de la classe **CadRasterizationOptions** sont :

|**Propriété**|**Valeur par défaut**|**Requis**|**Description**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Oui|Spécifie la largeur de la page.|
|**PageHeight**|**0**|Oui|Spécifie la hauteur de la page.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Non|Spécifie si le dessin doit être automatiquement mis à l'échelle. La valeur par défaut réduit automatiquement l'image pour s'adapter à la taille du canevas. Passez en mode **GrowToFit**, ou utilisez le paramètre **None** pour désactiver le redimensionnement automatique.|
|**BackgroundColor**|**Color.White**|Non|Spécifie la couleur de fond de l'image de sortie.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Non|Spécifie le mode de coloration de l'entité. Spécifiez l'option **UseObjectColor** pour dessiner des entités avec leur couleur native, ou l'option **UseDrawColor** pour remplacer les couleurs natives.|
|**DrawColor**|**Color.Black**|Non|Spécifie la couleur de l'entité remplacée (uniquement si **DrawType** est défini sur la valeur de propriété **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Non|Spécifie si le redimensionnement automatique des mises en page doit être effectué pour s'adapter à la mise en page Modèle.|

### **Définir la taille et le mode du canevas**

Exporter de CAD vers PDF ou des formats d'image raster CAD n'est pas une tâche triviale. Étant donné que le PDF ou l'image résultante nécessite une taille de canevas définit, nous devons spécifier les dimensions de sortie pour que la page PDF rende correctement le dessin. Définissez explicitement les propriétés **CadRasterizationOptions.PageWidth** et **CadRasterizationOptions.PageHeight**, sinon vous risquez d'obtenir une **ImageSaveException**.

De plus, vous pouvez spécifier les options d'échelle des dimensionnements. Les options de mise à l'échelle sont définies par la propriété **CadRasterizationOptions.ScaleMethod**. Utilisez cette option pour ajuster automatiquement les dimensions de l'image en fonction des valeurs de **CadRasterizationOptions.PageWidth** et **CadRasterizationOptions.PageHeight**. Par défaut, **CadRasterizationOptions.ScaleMethod** est défini sur le mode **ScaleType.ShrinkToFit**. Cette propriété définit le comportement suivant :

- Si les dimensions du dessin CAD sont supérieures à la taille de canevas résultante, les dimensions du dessin seront réduites pour s'adapter au canevas résultant tout en préservant le rapport d'aspect.
- Si les dimensions du dessin CAD sont inférieures à la taille du canevas résultant, définissez la propriété **CadRasterizationOptions.ScaleMethod** sur **ScaleType.GrowToFit** afin d'augmenter la taille du dessin pour s'adapter au canevas PDF tout en préservant le rapport d'aspect.
- Ou désactivez le redimensionnement automatique avec l'option **ScaleType.None**.

L'exemple de code ci-dessous montre l'option de mise à l'échelle automatique en action.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Définir les couleurs de fond et de dessin**

Par défaut, la palette de couleurs pour le canevas résultant est définie selon le schéma de document commun. Cela signifie que toutes les entités à l'intérieur du dessin CAD sont dessinées avec un stylo noir sur un fond blanc solide. Ces paramètres peuvent être modifiés avec les propriétés **CadRasterizationOptions.BackgroundColor** et **CadRasterizationOptions.DrawColor**. Changer la propriété **CadRasterizationOptions.DrawColor** nécessite également de définir la propriété **CadRasterizationOptions.DrawType** pour utiliser la couleur de dessin souhaitée. La propriété **CadRasterizationOptions.DrawType** contrôle si les entités CAD préservent leurs couleurs ou sont converties en couleurs personnalisées. Pour préserver les couleurs des entités, spécifiez **CadRasterizationOptions.DrawType** comme **CadDrawTypeMode.UseObjectColor**, sinon spécifiez la valeur **CadDrawTypeMode.UseDrawColor**.

L'exemple de code ci-dessous montre comment utiliser différentes propriétés de couleur.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Définir le redimensionnement automatique de la mise en page**

La plupart des dessins CAD contiennent plus d'une mise en page stockée dans un seul fichier, et chaque mise en page peut avoir des dimensions différentes. Lors du rendu de tels dessins CAD en PDF, chaque page du PDF peut avoir une mise à l'échelle différente en fonction de la taille de la mise en page. Afin de rendre le rendu homogène, les API Aspose.CAD ont exposé la propriété **CadRasterizationOptions.AutomaticLayoutsScaling**. Sa valeur par défaut est **false**, mais lorsqu'elle est vraie, l'API essaiera de rechercher une échelle correspondante pour chaque mise en page séparée et de les dessiner de manière correspondante en effectuant une opération de redimensionnement automatique en fonction de la taille de la page.

Voici comment la propriété **CadRasterizationOptions.AutomaticLayoutsScaling** fonctionne en collaboration avec la propriété **CadRasterizationOptions.ScaleMethod**.

1. Si **ScaleMethod** est défini sur **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** avec **AutomaticLayoutsScaling** défini sur false, toutes les mises en page (y compris le modèle) seront traitées selon la première option.
1. Si **ScaleMethod** est défini sur **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** avec **AutomaticLayoutsScaling** défini sur true, toutes les mises en page (sauf le modèle) seront traitées selon leur taille alors que le modèle sera traité selon la première option.
1. Si **ScaleMethod** est défini sur **ScaleType.None** avec **AutomaticLayoutsScaling** défini sur true ou false, aucune mise à l'échelle ne sera effectuée.

L'exemple de code ci-dessous montre comment définir le redimensionnement automatique de la mise en page pour la conversion CAD vers PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Convertir des mises en page AutoCAD DXF ou DWG en PNG ou autres formats d'image en C#**

L'API Aspose.CAD pour .NET peut convertir les mises en page CAD de formats pris en charge tels que DXF et DWG en PNG BMP TIFF JPEG et GIF. L'API prend également en charge le rendu des mises en page spécifiques d'un dessin CAD sous différents calques PSD.

Voici comment vous pouvez y parvenir en suivant les étapes simples suivantes.

- Chargez le fichier DWG ou DXF AutoCAD en utilisant la classe **Image**.
- Définissez/modifiez la largeur et la hauteur de l'image.
- Définissez le nom(s) de mise en page désiré(s) en utilisant la propriété CadRasterizationOptions.Layouts.
- Créez une instance de **ImageOptionsBase** et définissez sa propriété **VectorRasterizationOptions** sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
- Enregistrez la mise en page CAD en tant que TIFF ou image.

Voici le code source complet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

La propriété **CadRasterizationOptions.Layouts** est de type tableau de chaînes, donc vous pouvez spécifier plus d'une mise en page à la fois pour une conversion possible en formats d'image. En spécifiant plusieurs mises en page pour la propriété **CadRasterizationOptions.Layouts**, l'image TIFF résultante comportera plusieurs pages, l'image GIF comportera plusieurs cadres et le format [PSD](https://docs.fileformat.com/image/psd/) comportera plusieurs calques, où chaque page/cadre/calque représente une mise en page AutoCAD individuelle. Si un autre format d'image tel que PNG, BMP, JPEG est sélectionné pour stocker le résultat, alors l'API ne rendra que la mise en page par défaut ; c'est-à-dire "Modèle".

{{% /alert %}}

## **Activer le suivi du processus de rendu CAD**

Aspose.CAD a introduit une série de classes et de champs d'énumération de support pour aider au suivi du processus de rendu CAD. Avec ces changements en place, la conversion CAD en PDF peut désormais être réalisée de la manière suivante tout en activant le suivi.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Le suivi du processus de rendu CAD peut détecter les problèmes possibles suivants.

1. Informations d'en-tête manquantes ou corrompues.
1. Informations sur la mise en page manquantes.
1. Entités de bloc manquantes.
1. Styles de dimension manquants.
1. Styles manquants.

## **Substituer des polices lors de la conversion de dessins CAD**

Il est tout à fait possible qu'un dessin CAD particulier utilise une police spécifique qui n'est pas disponible sur la machine où la conversion CAD en PDF ou en image raster est en cours. Dans de telles situations, l'API Aspose.CAD déclenchera une exception appropriée pour signaler la ou les polices manquantes et arrêter le processus de conversion, car l'API nécessite ces polices pour rendre correctement le contenu sur le PDF ou les images résultantes.

L'API Aspose.CAD fournit un moyen facile d'utiliser le mécanisme pour substituer la ou les polices requises avec les polices disponibles. La propriété **CadImage.Styles** renvoie une instance de **CadStylesDictionary** qui contient à son tour l'**ObjetTableauDeStylesCad** pour chaque style dans le dessin CAD, tandis que la **CadStyleTableObject.PrimaryFontName** peut être utilisée pour spécifier le nom de la police disponible.

Le fragment de code suivant démontre l'utilisation de l'API Aspose.CAD pour .NET pour changer la police de tous les styles dans un dessin CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Il est également possible de changer la police d'un style particulier en y accédant via le nom du style. Le fragment de code suivant démontre l'utilisation de cette approche.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Convertir des calques CAD en formats d'image raster**

L'API Aspose.CAD pour .NET a exposé un moyen efficace et facile à utiliser pour spécifier le nom du calque CAD requis et le rendre en formats d'image raster. Voici comment vous pouvez y parvenir en 5 étapes simples énumérées ci-dessous.

1. Chargez le fichier CAD dans une instance de **Image** en utilisant la méthode de fabrique **Load**.
1. Créez une instance de **CadRasterizationOptions** et définissez ses propriétés obligatoires telles que **PageWidth** et **PageHeight**.
1. Ajoutez le nom de calque désiré en utilisant la méthode **CadRasterizationOptions.Layers.Add**.
1. Créez une instance de **ImageOptionsBase** et définissez sa propriété **VectorRasterizationOptions** sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
1. Appelez la méthode **Image.Save** en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de **ImageOptionsBase** créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Convertir tous les calques CAD en images séparées**

Vous pouvez obtenir tous les calques d'un dessin CAD en utilisant **CadImage.Layers** et rendre chaque calque en une image séparée comme démontré ci-dessous.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Convertir les calques CAD DWF en formats d'image raster**

L'API Aspose.CAD pour .NET a exposé un moyen efficace et facile à utiliser pour spécifier le nom du calque CAD requis et le rendre en formats d'image raster. Voici comment vous pouvez y parvenir en 5 étapes simples énumérées ci-dessous.

1. Chargez le fichier CAD DWF dans une instance de **Image** en utilisant la méthode de fabrique **Load**.
1. Créez une instance de **CadRasterizationOptions** et définissez ses propriétés obligatoires telles que **PageWidth** et **PageHeight**.
1. Ajoutez le nom de calque désiré en utilisant la méthode **CadRasterizationOptions.Layers.Add**.
1. Créez une instance de **ImageOptionsBase** et définissez sa propriété **VectorRasterizationOptions** sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
1. Appelez la méthode **Image.Save** en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de **ImageOptionsBase** créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD pour .NET écrit directement l'information sur l'API et le numéro de version dans les documents de sortie. Par exemple, lors du rendu d'un document en PDF, Aspose.CAD pour .NET remplit le champ Application avec la valeur 'Aspose.CAD' et le champ PDF Producer avec une valeur, par exemple 'Aspose.CAD v 17.10'.

Veuillez noter que vous ne pouvez pas demander à Aspose.CAD pour .NET de changer ou de supprimer ces informations des documents de sortie.
