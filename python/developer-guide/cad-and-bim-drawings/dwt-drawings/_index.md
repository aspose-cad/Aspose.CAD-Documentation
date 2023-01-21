---
title: DWT Drawings
type: docs
weight: 50
url: /python/dwt-drawings/
---

## **Support for DWT Files**

Aspose.CAD for Python allows developers to load and save [DWT](https://docs.fileformat.com/cad/dwt/) files. Sample code is given below to achieve this feature.

### Sample Code

import aspose.cad as cad;

if __name__ == '__main__':
	cadImage = cad.Image.load("file.dwt");

//do your work here

cadImage.save("result.dwt")

Convert-DWT-to-DWT.cs
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ReadingDWT-ReadingDWT.cs" >}}

