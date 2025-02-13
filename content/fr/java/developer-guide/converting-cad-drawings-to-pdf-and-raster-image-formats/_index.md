---
title: Conversion des dessins CAD en PDF et formats d'image raster
type: docs
weight: 30
url: /fr/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java écrit directement les informations concernant l'API et le numéro de version dans les documents de sortie. Par exemple, lors du rendu d'un document au format PDF, Aspose.CAD for Java remplit le champ Application avec la valeur 'Aspose.CAD' et le champ PDF Producer avec une valeur, par exemple 'Aspose.CAD v 17.9'.

Veuillez noter que vous ne pouvez pas demander à Aspose.CAD for Java de changer ou de supprimer ces informations des documents de sortie.

{{% /alert %}} 
## **Conversion des dessins CAD en formats d'image raster**
Aspose.CAD for Java est capable de convertir des formats de dessins CAD tels que [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) en formats d'image raster pris en charge tels que [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). L'API Aspose.CAD for Java a exposé des moyens efficaces et faciles à utiliser pour atteindre cet objectif.
Vous pouvez convertir n'importe quel format de dessin CAD pris en charge en formats d'image raster en suivant les étapes simples décrites ci-dessous.

1. Chargez le fichier CAD dans une instance de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez ses propriétés obligatoires telles que [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Créez une instance de **ImageOptionsBase** et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
1. Appelez **Image.save** en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Par défaut, l'API ne rend que la mise en page "Modèle". Cependant, vous pouvez également spécifier les mises en page de votre choix lors de la conversion des dessins CAD en formats d'image.
## **Personnalisation de la conversion CAD**
Les procédures de conversion CAD en [PDF](https://docs.fileformat.com/pdf/) & CAD en image raster sont hautement configurables car la classe [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) a été implémentée de telle manière qu'elle offre de nombreuses fonctionnalités optionnelles qui, une fois définies, peuvent remplacer le processus de rendu en fonction des besoins de l'application.
### **Classe CadRasterizationOptions**
La classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) est commune à tous les formats CAD pris en charge tels que [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), par conséquent, les informations partagées dans cet article sont valables pour les deux formats CAD susmentionnés.

Les propriétés les plus utiles de la classe **CadRasterizationOptions** sont :

|**Propriété**|**Valeur par défaut**|**Requise**|**Description**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Oui|Spécifie la largeur de la page.|
|**PageHeight**|**0**|Oui|Spécifie la hauteur de la page|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Non|Spécifie si le dessin doit être automatiquement mis à l'échelle. La valeur par défaut réduit automatiquement l'image pour s'adapter à la taille du canevas. Passez en mode **GrowToFit** ou utilisez le paramètre **None** pour désactiver l'échelle automatique.|
|**BackgroundColor**|**Color.White**|Non|Spécifie la couleur d'arrière-plan de l'image de sortie.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Non|Spécifie le mode de coloration des entités. Spécifiez l'option **UseObjectColor** pour dessiner des entités en utilisant leur couleur native, ou l'option **UseDrawColor** pour remplacer les couleurs natives.|
|**DrawColor**|**Color.Black**|Non|Spécifie la couleur de l'entité remplacée (uniquement si **DrawType** est défini sur la valeur de propriété **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Non|Spécifie si l'échelle automatique des mises en page doit être effectuée pour correspondre à la mise en page du Modèle.|
### **Définir la taille et le mode du canevas**
Exporter de CAD en PDF ou en formats d'image raster n'est pas une tâche triviale. Étant donné que le PDF ou l'image résultante nécessite que la taille du canevas soit définie, nous devons spécifier les dimensions de sortie pour que la page PDF puisse rendre correctement le dessin. Définissez explicitement les propriétés **CadRasterizationOptions.PageWidth** et **CadRasterizationOptions.PageHeight**, sinon vous risquez d'obtenir une **ImageSaveException**.

De plus, vous pouvez spécifier des options d'échelle de dimension. Les options d'échelle sont définies par la propriété **CadRasterizationOptions.ScaleMethod**. Utilisez cette option pour ajuster automatiquement les dimensions de l'image selon les valeurs **CadRasterizationOptions.PageWidth** et **CadRasterizationOptions.PageHeight**. Par défaut, **CadRasterizationOptions.ScaleMethod** est défini sur le mode **ScaleType.ShrinkToFit**. Cette propriété définit le comportement suivant :

- Si les dimensions du dessin CAD sont supérieures à la taille du canevas résultant, alors les dimensions de dessin sont réduites pour s'adapter au canevas résultant tout en préservant le rapport d'aspect.
- Si les dimensions du dessin CAD sont inférieures à la taille du canevas résultant, définissez la propriété **CadRasterizationOptions.ScaleMethod** sur **ScaleType.GrowToFit** afin d'augmenter la taille du dessin pour s'adapter au canevas PDF tout en préservant le rapport d'aspect.
- Ou désactivez l'échelle automatique avec l'option **ScaleType.None**.

L'exemple de code ci-dessous montre l'option d'échelle automatique en cours d'utilisation.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Définir les couleurs d'arrière-plan et de dessin**
Par défaut, la palette de couleurs pour le canevas résultant est définie selon le schéma de document commun. Cela signifie que toutes les entités à l'intérieur du dessin CAD sont dessinées avec un stylo noir sur un fond blanc solide. Ces paramètres peuvent être modifiés avec les propriétés **CadRasterizationOptions.BackgroundColor** et **CadRasterizationOptions.DrawColor**. Changer la propriété **CadRasterizationOptions.DrawColor** nécessite également de définir la propriété **CadRasterizationOptions.DrawType** pour utiliser la couleur de dessin qui sera utilisée. La propriété **CadRasterizationOptions.DrawType** détermine si les entités CAD préservent leurs couleurs ou sont converties en couleurs personnalisées. Pour préserver les couleurs des entités, spécifiez **CadRasterizationOptions.DrawType** comme **CadDrawTypeMode.UseObjectColor**, sinon spécifiez la valeur **CadDrawTypeMode.UseDrawColor**.

L'exemple de code ci-dessous montre comment utiliser différentes propriétés de couleur.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Définir l'échelle automatique des mises en page**
La plupart des dessins CAD ont plus d'un mise en page stockée dans un seul fichier, et chaque mise en page pourrait avoir des dimensions différentes. Lors du rendu de tels dessins CAD en PDF, chaque page du PDF pourrait avoir une échelle différente selon la taille de la mise en page. Afin de rendre le rendu homogène, les API Aspose.CAD ont exposé la propriété **CadRasterizationOptions.AutomaticLayoutsScaling**. Sa valeur par défaut est **false**, mais lorsqu'elle est vraie, l'API essaiera de rechercher une échelle correspondante pour chaque mise en page séparée et de les dessiner de manière correspondante en effectuant une opération de redimensionnement automatique selon la taille de la page.

Voici comment fonctionne la propriété **CadRasterizationOptions.AutomaticLayoutsScaling** en collaboration avec la propriété **CadRasterizationOptions.ScaleMethod**.

1. Si **ScaleMethod** est défini sur **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** avec **AutomaticLayoutsScaling** défini sur false, alors toutes les mises en page (y compris le Modèle) seront traitées selon la première option.
1. Si **ScaleMethod** est défini sur **ScaleType.ShrinkToFit** ou **ScaleType.GrowToFit** avec **AutomaticLayoutsScaling** défini sur true, alors toutes les mises en page (sauf le Modèle) seront traitées selon leur taille tandis que le Modèle sera traité selon la première option.
1. Si **ScaleMethod** est défini sur **ScaleType.None** avec **AutomaticLayoutsScaling** défini sur true ou false, alors aucune échelle ne sera effectuée.

L'exemple de code ci-dessous montre comment définir l'échelle automatique pour la conversion CAD en PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Conversion des mises en page CAD en formats d'image raster**
L'API Aspose.CAD for Java est capable de convertir des mises en page CAD de formats pris en charge tels que DXF & DWG en images raster telles que PNG, BMP, TIFF, JPEG & GIF. L'API fournit également la prise en charge du rendu des mises en page spécifiques d'un dessin CAD sur différentes couches PSD. 
L'API Aspose.CAD for Java a exposé des moyens efficaces et faciles à utiliser pour spécifier la liste des mises en page CAD requises et les rendre aux formats d'image raster. Voici comment vous pouvez réaliser cela en 5 étapes simples comme indiqué ci-dessous.

1. Chargez le fichier CAD dans une instance de **Image** en utilisant la méthode de fabrique **load**.
1. Créez une instance de **CadRasterizationOptions** et définissez ses propriétés obligatoires telles que **PageWidth** & **PageHeight**.
1. Spécifiez le(s) nom(s) de mise en page souhaités en utilisant la propriété CadRasterizationOptions.Layouts.
1. Créez une instance de **ImageOptionsBase** et définissez sa propriété **VectorRasterizationOptions** sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
1. Appelez **Image.Save** en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de **ImageOptionsBase** créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

La propriété **CadRasterizationOptions.Layouts** est de type tableau de chaînes, donc vous pouvez spécifier plus d'une mise en page à la fois pour une conversion possible en formats d'image. Lors de la spécification de plusieurs mises en page pour la propriété **CadRasterizationOptions.Layouts**, l'image TIFF résultante aurait plusieurs pages, l'image GIF aurait plusieurs images et le format PSD aurait plusieurs couches, où chaque page/image/couche représente une mise en page AutoCAD individuelle. Dans le cas où tout autre format d'image tel que PNG, BMP, JPEG est sélectionné pour stocker le résultat, alors l'API rendra uniquement la mise en page par défaut ; à savoir "Modèle".

{{% /alert %}} 
## **Activation du suivi pour le processus de rendu CAD**
Aspose.CAD a introduit une série de classes et de champs d'énumération de soutien pour aider à suivre le processus de rendu CAD. Avec ces changements en place, la conversion CAD en PDF peut maintenant être réalisée comme suit tout en activant le suivi.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Le suivi du processus de rendu CAD peut détecter les problèmes suivants :

1. Informations d'en-tête manquantes ou corrompues.
1. Informations de mise en page manquantes.
1. Entités de bloc manquantes.
1. Styles de dimension manquants.
1. Styles manquants.
## **Substitution des polices lors de la conversion des dessins CAD**
Il est tout à fait possible qu'un dessin CAD particulier utilise une police spécifique qui n'est pas disponible sur la machine où la conversion CAD en PDF ou en image raster a lieu. Dans de telles situations, l'API Aspose.CAD déclenchera une exception appropriée pour mettre en évidence la ou les polices manquantes et arrêter le processus de conversion car l'API nécessite ces polices pour rendre correctement le contenu sur le PDF et/ou les images résultants.
L'API Aspose.CAD fournit un moyen facile d'utiliser le mécanisme pour substituer la ou les polices requises avec les polices disponibles. La propriété **CadImage.Styles** renvoie une instance de **CadStylesDictionary** qui contient à son tour le **CadStyleTableObject** pour chaque style dans le dessin CAD, tandis que le **CadStyleTableObject.PrimaryFontName** peut être utilisé pour spécifier le nom de la police disponible.

Le snippet de code suivant démontre l'utilisation de l'API Aspose.CAD for Java pour changer la police de tous les styles dans un dessin CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Il est également possible de changer la police d'un style particulier en y accédant par son nom. Le snippet de code suivant démontre l'utilisation de cette approche.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Conversion des couches CAD en formats d'image raster**
L'API Aspose.CAD for Java a exposé un moyen efficace et facile à utiliser pour spécifier le nom de la couche CAD requise et la rendre aux formats d'image raster. Voici comment vous pouvez réaliser cela en 5 étapes simples comme indiqué ci-dessous.

1. Chargez le fichier CAD dans une instance de **Image** en utilisant la méthode de fabrique **load**.
1. Créez une instance de **CadRasterizationOptions** et définissez ses propriétés obligatoires telles que **PageWidth** & **PageHeight**.
1. Ajoutez le nom de couche souhaité en utilisant la méthode **CadRasterizationOptions.Layers.add**.
1. Créez une instance de **ImageOptionsBase** et définissez sa propriété **VectorRasterizationOptions** sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
1. Appelez la méthode **Image.save** en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de **ImageOptionsBase** créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Conversion de toutes les couches CAD en images séparées**
Vous pouvez obtenir toutes les couches d'un dessin CAD en utilisant **CadImage.Layers** et rendre chaque couche à une image séparée comme démontré ci-dessous.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Conversion des couches DWF CAD en formats d'image raster**
L'API Aspose.CAD for Java a exposé un moyen efficace et facile à utiliser pour spécifier le nom de la couche CAD requise et la rendre aux formats d'image raster. Voici comment vous pouvez réaliser cela en 5 étapes simples comme indiqué ci-dessous.

1. Chargez le fichier DWF CAD dans une instance de **Image** en utilisant la méthode de fabrique **Load**.
1. Créez une instance de **CadRasterizationOptions** et définissez ses propriétés obligatoires telles que **PageWidth** & **PageHeight**.
1. Ajoutez le nom de la couche souhaitée en utilisant la méthode **CadRasterizationOptions.Layers.Add**.
1. Créez une instance de **ImageOptionsBase** et définissez sa propriété **VectorRasterizationOptions** sur l'instance de **CadRasterizationOptions** créée à l'étape précédente.
1. Appelez la méthode **Image.Save** en passant le chemin du fichier (ou un objet MemoryStream) ainsi que l'instance de **ImageOptionsBase** créée à l'étape précédente.

Voici le code source complet.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
