---
title: Read, update and write DWG file
type: docs
weight: 20
url: /net/how-to/work-with-file/read-update-and-write-dwg-file
---


## **How to read, update and write DWG file**

**Issue:** How to read, update and write DWG file.

**Tips:** TTo do this, you can get the file using the load method, get the necessary entities and make changes to them, such as changing the start and end points or the thickness of the lines.

**Note:** This code snippet shows an example of reading a dwg file, changing objects: the positions of lines, circles, text values (you can add changes to other objects and their values for which reading/writing is supported) and then saving to a new file. So you can open a new file in AutoCAD and see objects with changed values

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}