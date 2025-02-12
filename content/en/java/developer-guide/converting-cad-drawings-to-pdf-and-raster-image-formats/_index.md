---
title: Converting CAD Drawings to PDF and Raster Image Formats
type: docs
weight: 30
url: /java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD for Java directly writes the information about API and Version Number in output documents. For example, upon rendering Document to PDF, Aspose.CAD for Java populates the Application field with value 'Aspose.CAD' and PDF Producer field with a value, e.g 'Aspose.CAD v 17.9'.

Please note that you cannot instruct Aspose.CAD for Java to change or remove this information from output Documents.

{{% /alert %}} 
## **Converting CAD Drawings to Raster Image Formats**
Aspose.CAD for Java is capable of converting CAD drawing formats such as [**DXF**](https://docs.fileformat.com/cad/dxf/) & [**DWG**](https://docs.fileformat.com/cad/dwg/) to the supported raster image formats such as [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) & [**GIF**](https://docs.fileformat.com/image/gif/). Aspose.CAD for Java API has exposed efficient & easy to use means to achieve this goal.
You can convert any supported CAD drawing format to raster image formats using the simple steps as elaborated below.

1. Load the CAD file into an instance of [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Create an instance of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) and set its mandatory properties such as [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Create an instance of **ImageOptionsBase** and set its [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) property to the instance of **CadRasterizationOptions** created in the previous step.
1. Call **Image.save** by passing the file path (or an object of MemoryStream) as well as the instance of [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



By default, the API renders only the "Model" layout. However, you may also specify the layouts of your choice while converting CAD drawings to image formats.
## **Customizing CAD Conversion**
The CAD to [PDF](https://docs.fileformat.com/pdf/) & CAD to raster image conversion procedures are highly configurable because the [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) class has been implemented in such a way that it provides many optional features that upon setting can override the rendering process according to the application needs.
### **CadRasterizationOptions Class**
The [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) class is common for all supported CAD formats such as [**DWG**](https://docs.fileformat.com/cad/dwg/) & [DXF](https://docs.fileformat.com/cad/dxf/), therefore, the information shared in this article is valid for both aforesaid CAD formats.

The most useful **CadRasterizationOptions** class properties are:

|**Property**|**Default Value**|**Required**|**Description**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Yes|Specifies the page width.|
|**PageHeight**|**0**|Yes|Specifies the page height|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|No|Specifies whether the drawing should be automatically scaled. The default value automatically shrinks the image to fit the canvas size. Switch to **GrowToFit** mode, or use the **None** setting to disable automatic scaling.|
|**BackgroundColor**|**Color.White**|No|Specifies the output image's background color.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|No|Specifies the entity's colorization mode. Specify the **UseObjectColor** option to draw entities using their native color, or the **UseDrawColor** option to over-ride native colors.|
|**DrawColor**|**Color.Black**|No|Specifies the overridden entity's color (only if **DrawType** is set to the **UseDrawColor** property value).|
|**AutomaticLayoutsScaling**|False|No|Specifies if auto layout scaling has to be performed to match the Model layout.|
### **Setting the Canvas Size & Mode**
Export from CAD to PDF or CAD to raster image formats is not a trivial task. Since the resultant PDF or image requires the canvas size to be defined, we need to specify the output dimensions for the PDF page to render the drawing properly. Set the **CadRasterizationOptions.PageWidth** and **CadRasterizationOptions.PageHeight** properties explicitly, or you may get an **ImageSaveException**.

Additionally, you may specify dimension scale options. The scaling options are set by the **CadRasterizationOptions.ScaleMethod** property. Use this option to automatically adjust the image dimensions according to the **CadRasterizationOptions.PageWidth** and **CadRasterizationOptions.PageHeight** values. By default **CadRasterizationOptions.ScaleMethod** is set to **ScaleType.ShrinkToFit** mode. This property defines the following behavior:

- If the CAD drawing dimensions are greater than the resultant canvas size, then the drawing dimensions are reduced to fit into the resultant canvas while preserving the aspect ratio.
- If the CAD drawing dimensions are smaller than the resultant canvas size, set the **CadRasterizationOptions.ScaleMethod** property to **ScaleType.GrowToFit** in order to increase the drawing size to fit into the PDF canvas while preserving the aspect ratio.
- Or disable automatic scaling with the **ScaleType.None** option.

The code sample below shows the auto-scaling option in use.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Setting the Background & Drawing Colors**
By default, the color palette for the resultant canvas is set to the common document scheme. That means that all entities inside the CAD drawing are drawn with a black color pen on a solid white background. These settings can be changed with **CadRasterizationOptions.BackgroundColor** and **CadRasterizationOptions.DrawColor** properties. Changing the **CadRasterizationOptions.DrawColor** property also requires setting the **CadRasterizationOptions.DrawType** property to make use of the drawing color to be used. The **CadRasterizationOptions.DrawType** property controls whether CAD entities preserve their colors or are converted to custom colors. To preserve entity colors, specify **CadRasterizationOptions.DrawType** as **CadDrawTypeMode.UseObjectColor**, otherwise specify the **CadDrawTypeMode.UseDrawColor** value.

The code sample below shows how to use different color properties.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Setting Auto Layout Scaling**
Most of the CAD drawings have more than one layouts stored in a single file, and each layout could have different dimensions. While rendering such CAD drawings to PDF, each page of the PDF could have different scaling according to the layout size. In order to make the rendering homogeneous, the Aspose.CAD APIs have exposed the **CadRasterizationOptions.AutomaticLayoutsScaling** property. Its default value is **false** but when true, the API will try to search for a corresponding scale for each separate layout and draw them in a corresponding manner by performing automatic re-size operation according to page size.

Here is how the **CadRasterizationOptions.AutomaticLayoutsScaling** property works in collaboration with **CadRasterizationOptions.ScaleMethod** property.

1. If **ScaleMethod** is set to **ScaleType.ShrinkToFit** or **ScaleType.GrowToFit** with **AutomaticLayoutsScaling** set to false then all layouts (including the Model) will be processed according to the first option.
1. If **ScaleMethod** is set to **ScaleType.ShrinkToFit** or **ScaleType.GrowToFit** with **AutomaticLayoutsScaling** set to true then all layouts (except Model) will be processed according to their size whereas the Model will be processed according to the first option.
1. If **ScaleMethod** is set to **ScaleType.None** with **AutomaticLayoutsScaling** set to true or false then no scaling will be performed.

The code sample below shows how to set the auto layout scaling for CAD to PDF conversion.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Converting CAD Layouts to Raster Image Formats**
Aspose.CAD for Java API is capable of converting CAD layouts of supported formats such as DXF & DWG to the raster images such as PNG, BMP, TIFF, JPEG & GIF. The API also provides the support to render the specific layouts of a CAD drawing to different PSD layers. 
Aspose.CAD for Java API has exposed efficient & easy to use means to specify the list of required CAD layouts and render them to raster image formats. Here is how you can achieve the same in 5 simple steps as listed below.

1. Load the CAD file into an instance of **Image** using the factory method **load**.
1. Create an instance of **CadRasterizationOptions** and set its mandatory properties such as **PageWidth** & **PageHeight**.
1. Specify the desired layout name(s) using the CadRasterizationOptions.Layouts property.
1. Create an instance of **ImageOptionsBase** and set its **VectorRasterizationOptions** property to the instance of **CadRasterizationOptions** created in the previous step.
1. Call **Image.Save** by passing the file path (or an object of MemoryStream) as well as the instance of **ImageOptionsBase** created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

The property **CadRasterizationOptions.Layouts** is of type string array so you may specify more than one layouts at a time for possible conversion to image formats. While specifying multiple layouts for the **CadRasterizationOptions.Layouts** property, the resultant TIFF image would have multiple pages, GIF image would have multiple frames and PSD format would have multiple layers, where each page/frame/layer represents an individual AutoCAD layout. In case any other image format such as PNG, BMP, JPEG is selected to store the result then the API will render only the default layout; that is "Model".

{{% /alert %}} 
## **Enabling Tracking for CAD Rendering Process**
Aspose.CAD has introduced a series of classes and supporting enumeration fields to assist with the tracking of CAD rendering process. With these changes in place, the CAD to PDF conversion can now be achieved as follow while enabling the tracking.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Tracking of CAD rendering process can detect the following possible problems.

1. Missing or corrupted header information.
1. Missing layout information.
1. Missing block entities.
1. Missing dimension styles.
1. Missing styles.
## **Substituting Fonts while Converting CAD Drawings**
It is quite possible that a particular CAD drawing uses some specific font that isn't available on the machine where CAD to PDF or CAD to raster image conversion is taking place. In such situations, the Aspose.CAD API will trigger an appropriate exception to highlight the missing font(s) and stop the conversion process because the API requires these fonts to properly render the contents onto the resultant PDF and/or images.
Aspose.CAD API provides an easy way to use the mechanism to substitute the required font(s) with the available font(s). The **CadImage.Styles** property returns an instance of **CadStylesDictionary** that in turn contains the **CadStyleTableObject** for each style in the CAD drawing, whereas the **CadStyleTableObject.PrimaryFontName** can be used to specify the available font name.

The following code snippet demonstrates the usage of Aspose.CAD for Java API to change the font of all styles in a CAD drawing.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




It is also possible to change the font of only one particular style by accessing it via the style name. The following code snippet demonstrates the usage of this approach.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Converting CAD Layers to Raster Image Formats**
Aspose.CAD for Java API has exposed an efficient & easy to use means to specify the name of the required CAD layer and render it to raster image formats. Here is how you can achieve the same in 5 simple steps as listed below.

1. Load the CAD file into an instance of **Image** using the factory method **load**.
1. Create an instance of **CadRasterizationOptions** and set its mandatory properties such as **PageWidth** & **PageHeight**.
1. Add the desired layer name using the **CadRasterizationOptions.Layers.add** method.
1. Create an instance of **ImageOptionsBase** and set its **VectorRasterizationOptions** property to the instance of **CadRasterizationOptions** created in the previous step.
1. Call the **Image.save** method by passing the file path (or an object of MemoryStream) as well as the instance of **ImageOptionsBase** created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Converting All CAD Layers to Separate Images**
You may get all the layers from a CAD drawing using the **CadImage.Layers** and render each layer to separate image as demonstrated below.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Converting DWF CAD Layers to Raster Image Formats**
Aspose.CAD for Java API has exposed an efficient & easy to use means to specify the name of the required CAD layer and render it to raster image formats. Here is how you can achieve the same in 5 simple steps as listed below.

1. Load the DWF CAD file into an instance of **Image** using the factory method **Load**.
1. Create an instance of **CadRasterizationOptions** and set its mandatory properties such as **PageWidth** & **PageHeight**.
1. Add the desired layer name using the **CadRasterizationOptions.Layers.Add** method.
1. Create an instance of **ImageOptionsBase** and set its **VectorRasterizationOptions** property to the instance of **CadRasterizationOptions** created in previous step.
1. Call the **Image.Save** method by passing the file path (or an object of MemoryStream) as well as the instance of **ImageOptionsBase** created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}


