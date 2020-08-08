---
title: Aspose.CAD for Java 17.02.0 - Release notes
type: docs
weight: 40
url: /java/aspose-cad-for-java-17-02-0-release-notes/
---

Aspose.CAD for .Net has been updated to version 17.02.0 and we are pleased to announce it.
The following is a list of changes in this version of Aspose.Imaging.
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|CADJAVA-93|Normalize drawing size to absolute metrics|Feature|
|CADJAVA-94|Add support for clipping of raster images|Feature|
|CADJAVA-71|[Determine the external references for a dwg and their filepaths](http://www.aspose.com/community/forums/thread/740200/features-in-aspose.cad-and-possible-roadmap-for-additions.aspx)|Feature|
|CADJAVA-96|[Support for DWG 2007(AC1021) Format](http://www.aspose.com/community/forums/thread/780521/dwg-to-pdf-failed.aspx)|Feature|
|CADJAVA-97|Implement right entity order for dwg format|Enhancement|
|CADJAVA-98|[Converting DWG to PDF format is producing incorrect PDF file of 1kb size](https://www.aspose.com/community/forums/thread/808490/convert-dwg-to-pdf-failed.aspx)|Enhancement|
|CADJAVA-52|[Converting DWG to PDF file is throwing exception](http://www.aspose.com/community/forums/thread/794601/pdf-result-seems-to-be-pixelated.aspx)|Enhancement|
|CADJAVA-53|[Converting DWG to PDF is not exporting external raster images linked with DWG file](http://www.aspose.com/community/forums/thread/796472/convert-a-dwg-to-pdf-with-included-external-references.aspx)|Enhancement|
# **Usage examples**
**CADNET-179 Normalize drawing size to absolute metrics** 
Automatic shrink (Aspose.CAD.[FileFormats](/pages/createpage.action?spaceKey=cadjava&title=FileFormats&linkCreation=true&fromPageId=25002162).Cad.[ScaleType](/pages/createpage.action?spaceKey=cadjava&title=ScaleType&linkCreation=true&fromPageId=25002162) enum has been removed)

{{< highlight java >}}

 String fileName = getFileFromDesktop("APFH Floor Plan (DWG).dwg");

        com.aspose.cad.Image image = com.aspose.cad.Image.load(fileName);

        {

            BmpOptions pdfOptions = new BmpOptions();

            CadRasterizationOptions cadRasterizationOptions = new CadRasterizationOptions();

            pdfOptions.setVectorRasterizationOptions(cadRasterizationOptions);

            cadRasterizationOptions.setCenterDrawing(true);

            cadRasterizationOptions.setPageHeight(500);

            cadRasterizationOptions.setPageWidth(500);

            cadRasterizationOptions.setLayouts(new String[] { "Model" });

            // export

            String outPath = fileName + ".bmp";

            image.save(outPath, pdfOptions);

        }

{{< /highlight >}}

**CADNET-179 Normalize drawing size to absolute metrics** 
Automatic sizing (Width and Height properties of [CadRasterizationOptions](/pages/createpage.action?spaceKey=cadjava&title=CadRasterizationOptions&linkCreation=true&fromPageId=25002162)/[DgnRasterizationOptions](/pages/createpage.action?spaceKey=cadjava&title=DgnRasterizationOptions&linkCreation=true&fromPageId=25002162) could be not set)

{{< highlight java >}}

 String fileName = getFileFromDesktop("APFH Floor Plan (DWG).dwg");

        com.aspose.cad.Image image = com.aspose.cad.Image.load(fileName);

        {

            BmpOptions pdfOptions = new BmpOptions();

            CadRasterizationOptions cadRasterizationOptions = new CadRasterizationOptions();

            pdfOptions.setVectorRasterizationOptions(cadRasterizationOptions);

            cadRasterizationOptions.setCenterDrawing(true);

            cadRasterizationOptions.setLayouts(new String[] { "Model" });

            // export

            String outPath = fileName + ".bmp";

            image.save(outPath, pdfOptions);

        }

{{< /highlight >}}

**CADNET-179 Normalize drawing size to absolute metrics** 
[UnitType](/pages/createpage.action?spaceKey=cadjava&title=UnitType&linkCreation=true&fromPageId=25002162) property gives the ability to adjust automatic scaling when Width and Height are not set (Assume source drawing has size as 1 meter to 1 meter and [UnitType](/pages/createpage.action?spaceKey=cadjava&title=UnitType&linkCreation=true&fromPageId=25002162) is specified as Centimeter then resulted image will be 1000x1000 pixels if Width and Height were not set)

{{< highlight java >}}

 String fileName = getFileFromDesktop("APFH Floor Plan (DWG).dwg");

        com.aspose.cad.Image image = com.aspose.cad.Image.load(fileName);

        {

            BmpOptions pdfOptions = new BmpOptions();

            CadRasterizationOptions cadRasterizationOptions = new CadRasterizationOptions();

            pdfOptions.setVectorRasterizationOptions(cadRasterizationOptions);

            cadRasterizationOptions.setCenterDrawing(true);

            cadRasterizationOptions.setUnitType(UnitType.Centimenter);

            cadRasterizationOptions.setLayouts(new String[] { "Model" });

            // export

            String outPath = fileName + ".bmp";

            image.save(outPath, pdfOptions);

        }


{{< /highlight >}}

**CADNET-183 Converting DWG to PDF is not exporting external raster images linked with DWG file**

{{< highlight java >}}

         String fileName = "test-a-802.dwg";

        CadImage cadImage = (CadImage)Image.load(fileName);

        {

            for (CadBaseObject obj : cadImage.getObjects())

            if (obj.getTypeName() == CadObjectTypeName.IMAGEDEF)

            {

                CadRasterImageDef imageDef = (CadRasterImageDef)obj;

                System.out.println(imageDef.getImageSizeU());

                System.out.println(imageDef.getImageSizeV());

                System.out.println(imageDef.getDefaultSize1PixelU());

                System.out.println(imageDef.getDefaultSize1PixelV());

                System.out.println(imageDef.getFileName());

            }

        }

{{< /highlight >}}
