---
title: DGN Drawing
type: docs
weight: 10
url: /java/dgn-drawing/
---

## **Drawing DGN Format As Part of DWG**
Aspose.CAD for Java allows developers to export a DWG file with embedded DGN underlay inside. Following is the code demonstrating how to access the DGN underlay inside a DWG file while exporting the DWG file.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}


## **3D entities support for DGN v7**
Aspose.CAD for Java API has introduced the functionality to load a DGN AutoCAD file and support 3D entities for DGN v7. The [**CadImage**](https://apireference.aspose.com/java/cad/com.aspose.cad.fileformats.cad/CadImage)** **class serves the purpose. Each DGN image supports 9 predefined views. It's enumerated from 1 to 9. If view not defined on export, for multi-paged output formats (like PDF) all views will be exported, each on a separate page. 3D entities supported on DGN file format, as well as 2D.
VectorRasterizationOptions.TypeOfEntities is not used anymore for DGN format (both 2d and 3d are supported simultaneously). 

` `Sample code to look at supported DGN elements.



{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}



{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
