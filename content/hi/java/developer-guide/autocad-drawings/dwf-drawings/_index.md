---
title: DWF चित्र
type: docs
weight: 20
url: /hi/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **DWF चित्रों को PDF में निर्यात करना**

Aspose.CAD для Java API DWF प्रारूप में AutoCAD चित्र लोड कर सकता है, और इसे PDF में परिवर्तित कर सकता है। यह विषय Aspose.CAD API का उपयोग करने की प्रक्रिया को स्पष्ट करता है ताकि सरल चरणों के माध्यम से DWF को PDF प्रारूप में परिवर्तित किया जा सके।

### **DWF फ़ाइलों को PDF में परिवर्तित करना**

DWF को PDF में परिवर्तित करने के लिए निम्नलिखित सरल चरण आवश्यक हैं।

1. DWF फ़ाइल को [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) के एक उदाहरण में लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) कक्षा का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) प्रोपर्टीज सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) कक्षा का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

नीचे दिए गए कोड उदाहरण में दिखाया गया है कि DWF चित्रों को PDF में कैसे निर्यात किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **DWF में लेयरों का समर्थन**

Aspose.CAD DWF ड्राइंग संस्थाओं को लोड करने और उन्हें JPG प्रारूप में पूरी ड्राइंग के रूप में रेंडर करने की सुविधा प्रदान करता है।

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके DWF ड्राइंग फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) कक्षा का एक ऑब्जेक्ट बनाएं।
1. इच्छित लेयर जोड़ें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) को कॉल करें और [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

नीचे दिए गए कोड उदाहरण में दिखाया गया है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके एक फ़ाइल को कैसे परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
