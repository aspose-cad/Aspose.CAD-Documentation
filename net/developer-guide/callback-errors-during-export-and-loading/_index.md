---
title: Callback errors during export and load
type: docs
weight: 40
url: /net/callback-errors-during-export-and-loading/
---

## **Review of callback errors during export and load**

It is possible that during export or loading of the drawing we may face errors related to the structure of the file 
(e.g. sections in the file are required now but not earlier). 
Some of them are critical and in such cases the exception is thrown, but we can also ignore some of them internally and notify about it using callback messages.
Anyway, all these messages require attention because they may explain e.g. missing entities in export results or other effects.


### **Errors during export**

There is RenderResult field in [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
that includes IsRenderComplete to get if there were errors during export and print information about them:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Errors during load**

Some troubles with drawings may be observed earlier that the export process starts. 
[**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) property in
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) object is used to store messages about them.
[**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) property is useful to decide whether 
it is required to throw exception on load errors or not. 

Here is the example of Errors property usage:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
