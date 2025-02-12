---
title: Support of CTB files
type: docs
weight: 40
url: /net/developer-guide/support-ctb/
---

## **Support of CTB files**

Sometimes color, lineweights and some other options for drawings may be used not only from drawings itself but also from plot styles in separate CTB files. 
The simplest way to use this information is to put the corresponding CTB files near the file with drawing in DWG/DXF format and the information from them will be applied
automatically during export.

It is also possible to load all CTB files in a form of Stream using 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) property of 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) object.

Here is the example how to do this:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
