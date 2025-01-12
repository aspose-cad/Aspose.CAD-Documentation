---
title: Support of CTB files
type: docs
weight: 40
url: /java/support-ctb/
---

## **Support of CTB files**

Sometimes color, lineweights and some other options for drawings may be used not only from drawings itself but also from plot styles in separate CTB files.
The simplest way to use this information is to put the corresponding CTB files near the file with drawing in DWG/DXF format and the information from them will be applied
automatically during export.

It is also possible to load all CTB files in a form of Stream using 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) property of 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object.

Here is the example how to do this:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
