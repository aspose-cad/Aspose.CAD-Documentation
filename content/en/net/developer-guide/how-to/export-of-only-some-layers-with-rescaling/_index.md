---
title: Export of only some layers with rescaling 
type: docs
weight: 31
url: /net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **Export of only some layers with rescaling (CADNET-559)**

**Issue:** How to export of only some layers with rescaling (CADNET-559).

**Tips:** To do this, select the necessary layers, add them to the CadBaseEntity array, then assign them to drawing entities and execute UpdateSize.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}