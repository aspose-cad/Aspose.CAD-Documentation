---
title: Addition of image as background into DWG
type: docs
weight: 15
url: /net/how-to/addition-of-image-as-background-into-dwg/
---

## **How to add an image as a background in DWG**

**Issue:** How to add an image as a background in DWG.

**Tips:** To do this, create a CadRasterImageDef object for the background image, create a CadRasterImage object to insert the background for the drawing, add a CadRasterImage object to the drawing objects, create a CadBaseObject CadBaseObject and add it to cadImage.Objects, process everything via CadBlockTableObject.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}