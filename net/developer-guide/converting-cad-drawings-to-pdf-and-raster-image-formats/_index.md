---
title: DWG DXF to PDF C# | Convert Auto CAD Files to PDF JPEG PNG in C# .NET
type: docs
weight: 30
url: /net/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG to PDF C#, DXF to PDF C#, DWF DWT to PDF C#, convert AutoCAD, convert DWG, convert DWF, convert DWT, convert DXF, convert autocad to pdf, convert DWG to PDF, convert DWG to PNG, convert DWG to TIFF, convert DWG to JPG"
description: Use C# .NET AutoCAD to PDF converter to convert DWG or DXF to PDF in C#. You can convert DWG, DWF, DWT and DXF to PDF, JPEG, PNG, BMP, GIF and TIFF in C# .NET as well.
---

## **Convert DWG or DXF to PNG, JPEG, BMP GIF or TIFF in C#**

Aspose.CAD for .NET can convert AutoCAD drawing formats such as [DXF](https://docs.fileformat.com/cad/dxf/) and [DWG](https://docs.fileformat.com/cad/dwg/) to [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) and [GIF](https://docs.fileformat.com/image/gif/). It has exposed efficient and easy to use API to achieve this goal.

You can convert any supported AutoCAD drawing format to raster image formats using the simple steps as elaborated below.

1. Load the AutoCAD DWG or DXF file into the [**Image**](https://apireference.aspose.com/cad/net/aspose.cad/image) class.
1. Create an instance of [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Set/change the size of the image using [**PageWidth**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) and [**PageHeight**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Create an instance of [**ImageOptionsBase**](https://apireference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Set [**VectorRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property to the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) created in the previous step.
1. Save AutoCAD drawing as PDF with [**Image.Save**](https://apireference.aspose.com/cad/net/aspose.cad/image/methods/save) by passing the file path (or an object of MemoryStream) as well as the instance of [**ImageOptionsBase**](https://apireference.aspose.com/cad/net/aspose.cad/imageoptionsbase) created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

By default, the API renders only the "Model" layout. However, you may also specify the layouts of your choice while converting CAD drawings to image formats.

## **Customizing CAD Conversion**

The CAD to [PDF](https://docs.fileformat.com/pdf/) & CAD to raster image conversion procedures are highly configurable because the [**CadRasterizationOptions**](https://apireference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class has been implemented in such a way that it provides many optional features that upon setting can override the rendering process according to the application needs.

### **CadRasterizationOptions Class**

The **CadRasterizationOptions** class is common for all supported CAD formats such as DWG & DXF therefore, the information shared in this article is valid for both aforesaid CAD formats.

The most useful **CadRasterizationOptions** class properties are:

|**Property**|**Default Value**|**Required**|**Description**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Yes|Specifies the page width.|
|**PageHeight**|**0**|Yes|Specifies the page height|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|No|Specifies whether the drawing should be automatically scaled. The default value automatically shrinks the image to fit the canvas size. Switch to **GrowToFit** mode, or use the **None** setting to disable automatic scaling.|
|**BackgroundColor**|**Color.White**|No|Specifies the output image's background color.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|No|Specifies the entity's colorization mode. Specify the **UseObjectColor** option to draw entities using their native color, or the **UseDrawColor** option to over-ride native colors.|
|**DrawColor**|**Color.Black**|No|Specifies the overridden entity's color (only if **DrawType** is set to the **UseDrawColor** property value).|
|**AutomaticLayoutsScaling**|False|No|Specifies if auto-layout scaling has to be performed to match the Model layout.|

### **Setting the Canvas Size & Mode**

Export from CAD to PDF or CAD to raster image formats is not a trivial task. Since the resultant PDF or image requires the canvas size to be defined, we need to specify the output dimensions for the PDF page to render the drawing properly. Set the **CadRasterizationOptions.PageWidth** and **CadRasterizationOptions.PageHeight** properties explicitly, or you may get an **ImageSaveException**.

Additionally, you may specify dimension scale options. The scaling options are set by the **CadRasterizationOptions.ScaleMethod** property. Use this option to automatically adjust the image dimensions according to the **CadRasterizationOptions.PageWidth** and **CadRasterizationOptions.PageHeight** values. By default **CadRasterizationOptions.ScaleMethod** is set to **ScaleType.ShrinkToFit** mode. This property defines the following behavior:

- If the CAD drawing dimensions are greater than the resultant canvas size, then the drawing dimensions are reduced to fit into the resultant canvas while preserving the aspect ratio.
- If the CAD drawing dimensions are smaller than the resultant canvas size, set the **CadRasterizationOptions.ScaleMethod** property to **ScaleType.GrowToFit** in order to increase the drawing size to fit into the PDF canvas while preserving the aspect ratio.
- Or disable automatic scaling with the **ScaleType.None** option.

The code sample below shows the auto-scaling option in use.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Setting the Background & Drawing Colors**

By default, the color palette for the resultant canvas is set to the common document scheme. That means that all entities inside the CAD drawing are drawn with a black color pen on a solid white background. These settings can be changed with **CadRasterizationOptions.BackgroundColor** and **CadRasterizationOptions.DrawColor** properties. Changing the **CadRasterizationOptions.DrawColor** property also requires setting the **CadRasterizationOptions.DrawType** property to make use of the drawing color to be used. The **CadRasterizationOptions.DrawType** property controls whether CAD entities preserve their colors or are converted to custom colors. To preserve entity colors, specify **CadRasterizationOptions.DrawType** as **CadDrawTypeMode.UseObjectColor**, otherwise specify the **CadDrawTypeMode.UseDrawColor** value.

The code sample below shows how to use different color properties.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Setting Auto Layout Scaling**

Most of the CAD drawings have more than one layouts stored in a single file, and each layout could have different dimensions. While rendering such CAD drawings to PDF, each page of the PDF could have different scaling according to the layout size. In order to make the rendering homogeneous, the Aspose.CAD APIs have exposed **CadRasterizationOptions.AutomaticLayoutsScaling** property. Its default value is **false** but when true, the API will try to search for a corresponding scale for each separate layout and draw them in a corresponding manner by performing automatic re-size operation according to page size.

Here is how the **CadRasterizationOptions.AutomaticLayoutsScaling** property works in collaboration with **CadRasterizationOptions.ScaleMethod** property.

1. If **ScaleMethod** is set to **ScaleType.ShrinkToFit** or **ScaleType.GrowToFit** with **AutomaticLayoutsScaling** set to false then all layouts (including the Model) will be processed according to the first option.
1. If **ScaleMethod** is set to **ScaleType.ShrinkToFit** or **ScaleType.GrowToFit** with **AutomaticLayoutsScaling** set to true then all layouts (except Model) will be processed according to their size whereas the Model will be processed according to the first option.
1. If **ScaleMethod** is set to **ScaleType.None** with **AutomaticLayoutsScaling** set to true or false then no scaling will be performed.

The code sample below shows how to set the auto layout scaling for CAD to PDF conversion.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Convert AutoCAD DXF or DWG Layouts to PNG or Other Image Formats in C#**

Aspose.CAD for .NET API can convert CAD layouts of supported formats such as DXF and DWG to PNG BMP TIFF JPEG and GIF. The API also provides the support to render the specific layouts of a CAD drawing to different PSD layers.

Here is how you can achieve the same in the following simple steps.

- Load the AutoCAD DWG or DXF file using **Image** class.
- Set/change width and height of the image.
- Set the desired layout name(s) using the CadRasterizationOptions.Layouts property.
- Create an instance of **ImageOptionsBase** and set its **VectorRasterizationOptions** property to the instance of **CadRasterizationOptions** created in the previous step.
- Save the CAD layout as TIFF or image.

Here is the complete source code.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

The property **CadRasterizationOptions.Layouts** is of type string array so you may specify more than one layouts at a time for possible conversion to image formats. While specifying multiple layouts for the **CadRasterizationOptions.Layouts** property, the resultant [TIFF](https://docs.fileformat.com/image/tiff/) image would have multiple pages, [GIF](https://docs.fileformat.com/image/gif/) image would have multiple frames and [PSD](https://docs.fileformat.com/image/psd/) format would have multiple layers, where each page/frame/layer represents an individual AutoCAD layout. In case any other image format such as [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [JPEG](https://docs.fileformat.com/image/jpeg/) is selected to store the result then the API will render only the default layout; that is "Model".

{{% /alert %}}

## **Enabling Tracking for CAD Rendering Process**

Aspose.CAD has introduced a series of classes and supporting enumeration fields to assist with the tracking of CAD rendering process. With these changes in place, the CAD to [PDF](https://docs.fileformat.com/pdf/) conversion can now be achieved as follow while enabling the tracking.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Tracking of CAD rendering process can detect the following possible problems.

1. Missing or corrupted header information.
1. Missing layout information.
1. Missing block entities.
1. Missing dimension styles.
1. Missing styles.

## **Substituting Fonts while Converting CAD Drawings**

It is quite possible that a particular CAD drawing uses some specific font that isn't available on the machine where CAD to [PDF](https://docs.fileformat.com/pdf/) or CAD to raster image conversion is taking place. In such situations, the Aspose.CAD API will trigger an appropriate exception to highlight the missing font(s) and stop the conversion process because the API requires these fonts to properly render the contents onto the resultant PDF and/or images.

Aspose.CAD API provides an easy way to use the mechanism to substitute the required font(s) with the available font(s). The **CadImage.Styles** property returns an instance of **CadStylesDictionary** that in turn contains the **CadStyleTableObject** for each style in the CAD drawing, whereas the **CadStyleTableObject.PrimaryFontName** can be used to specify the available font name.

The following code snippet demonstrates the usage of Aspose.CAD for .NET API to change the font of all styles in a CAD drawing.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

It is also possible to change the font of only one particular style by accessing it via the style name. The following code snippet demonstrates the usage of this approach.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Converting CAD Layers to Raster Image Formats**

Aspose.CAD for .NET API has exposed an efficient & easy to use means to specify the name of the required CAD layer and render it to raster image formats. Here is how you can achieve the same in 5 simple steps as listed below.

1. Load the CAD file into an instance of **Image** using the factory method **Load**.
1. Create an instance of **CadRasterizationOptions** and set its mandatory properties such as **PageWidth** & **PageHeight**.
1. Add the desired layer name using the **CadRasterizationOptions.Layers.Add** method.
1. Create an instance of **ImageOptionsBase** and set its **VectorRasterizationOptions** property to the instance of **CadRasterizationOptions** created in the previous step.
1. Call the **Image.Save** method by passing the file path (or an object of MemoryStream) as well as the instance of **ImageOptionsBase** created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Converting All CAD Layers to Separate Images**

You may get all the layers from a CAD drawing using the **CadImage.Layers** and render each layer to separate image as demonstrated below.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Converting DWF CAD Layers to Raster Image Formats**

Aspose.CAD for .NET API has exposed an efficient & easy to use means to specify the name of the required CAD layer and render it to raster image formats. Here is how you can achieve the same in 5 simple steps as listed below.

1. Load the DWF CAD file into an instance of **Image** using the factory method **Load**.
1. Create an instance of **CadRasterizationOptions** and set its mandatory properties such as **PageWidth** & **PageHeight**.
1. Add the desired layer name using the **CadRasterizationOptions.Layers.Add** method.
1. Create an instance of **ImageOptionsBase** and set its **VectorRasterizationOptions** property to the instance of **CadRasterizationOptions** created in the previous step.
1. Call the **Image.Save** method by passing the file path (or an object of MemoryStream) as well as the instance of **ImageOptionsBase** created in the previous step.

Here is the complete source code.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD for .NET directly writes the information about API and Version Number in output documents. For example, upon rendering Document to PDF, Aspose.CAD for .NET populates Application field with value 'Aspose.CAD' and PDF Producer field with a value, e.g 'Aspose.CAD v 17.10'.

Please note that you cannot instruct Aspose.CAD for .NET to change or remove this information from output Documents.
