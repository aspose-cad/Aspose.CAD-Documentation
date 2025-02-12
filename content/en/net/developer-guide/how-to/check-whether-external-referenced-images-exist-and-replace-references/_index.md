---
title: Check whether external referenced images exist and replace references
type: docs
weight: 22
url: /net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **How to edit of hyperlinks on objects**

**Issue:** How to check whether external referenced images exist and replace references (CADNET-8088).

**Tips:** To do this, get an entity of type CadObjectTypeName.IMAGEDEF from the drawing entities and use CadRasterImageDef to check.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}