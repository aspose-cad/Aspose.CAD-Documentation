---
title: DWG चित्र
type: docs
weight: 40
url: /hi/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **DWG चित्रों का PDF में निर्यात करना**

Aspose.CAD for Java API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है, और उसे PDF में बदल सकता है। यह विषय Aspose.CAD API के उपयोग की व्याख्या करता है ताकि DWG को PDF प्रारूप में परिवर्तित किया जा सके जैसा आगे सरल चरणों में परिभाषित है।

{{% alert color="primary" %}}

यह API निम्नलिखित AutoCAD DWG संशोधनों का समर्थन करता है:

- DWG 2004 संस्करण 16.0 रिलीज 18
- DWG 2005 संस्करण 16.1
- DWG 2010 संस्करण 18.0
- DWG 2013 संस्करण 19.0

{{% /alert %}}

### **DWG फ़ाइल प्रारूप**

DWG एक बाइनरी फ़ाइल है जो वेक्टर चित्र डेटा और मेटाडाटा को शामिल करता है। वेक्टर चित्र डेटा CAD एप्लिकेशन को DWG को कैसे प्रदर्शित करें इसके बारे में निर्देश प्रदान करता है; मेटाडाटा में फ़ाइल के बारे में विभिन्न सूचना जैसे स्थान-विशिष्ट डेटा और ग्राहक डेटा शामिल हो सकता है। DWG फ़ाइल प्रारूप के लिए ओपन स्पेसिफिकेशंस यहाँ [इस PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) में मिल सकती हैं।

### **DWG फ़ाइलों को PDF में परिवर्तित करना**

DWG को PDF में परिवर्तित करने के लिए निम्नलिखित सरल चरणों की आवश्यकता है।

1. DWG फ़ाइल को [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) के एक उदाहरण में लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) वर्ग की एक वस्तु बनाएं और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) प्रॉपर्टीज सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) वर्ग की एक वस्तु बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) की वस्तु को दूसरे पैरामीटर के रूप में पास करें।

नीचे कोड नमूना दिखाता है कि DWG चित्रों को PDF में कैसे निर्यात किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **विभिन्न लेआउट आकार के साथ एकल PDF बनाना**

Aspose.CAD for Java आपको DWG फ़ाइल को विभिन्न लेआउट आकार के साथ एकल PDF में परिवर्तित करने की अनुमति देता है। यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊँचाई और चौड़ाई सेट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ऑब्जेक्ट के लिए आवश्यक [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) जोड़ें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) क्लास का एक उदाहरण बनाएं और उस के [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे कोड नमूना दिखाता है कि विभिन्न लेआउट के साथ एक एकल PDF कैसे बनाया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **DWG को PDF/A और PDF/E में निर्यात करना**

DWG को PDF में परिवर्तित करने के लिए निम्नलिखित सरल चरणों की आवश्यकता है।

1. DWG फ़ाइल को [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) के एक उदाहरण में लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास की एक वस्तु बनाएं और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) प्रॉपर्टीज सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) क्लास की एक वस्तु बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) की वस्तु को दूसरे पैरामीटर के रूप में पास करें।

नीचे कोड नमूना दिखाता है कि DWG चित्रों को PDF में कैसे निर्यात किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **समर्थित AutoCAD प्राइमिटिव**

निम्नलिखित AutoCAD प्राइमिटिव का समर्थन किया जाता है।

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **विशिष्ट DWG लेआउट को PDF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊँचाई और चौड़ाई सेट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ऑब्जेक्ट के लिए [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) प्रॉपर्टी सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) क्लास का एक उदाहरण बनाएं और उसके [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे कोड नमूना दिखाता है कि किसी DWG के विशेष लेआउट को PDF में कैसे परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **फिक्स्ड साइज का उपयोग करके DWG को रास्टर या PDF में निर्यात करना**

Aspose.CAD for Java API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है, और उसे PDF या रास्टर में फिक्स्ड साइज का उपयोग करके बदल सकता है।

नीचे कोड नमूना दिखाता है कि इस सुविधाओं को कैसे लागू किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **DWG/DXF को BMP और PDF में निर्यात करते समय गोल:hidden लाइनों के लिए समर्थन**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक उदाहरण बनाएं।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊँचाई और चौड़ाई सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) क्लास का एक उदाहरण बनाएं और उसके [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे कोड नमूना दिखाता है कि इस सुविधाओं को कैसे लागू किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **निर्यातित PDF में DWG चित्र के लिए प्रिंट क्षेत्र सेट करने का समर्थन**

Aspose.CAD for Java API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है, और उसे PDF में बदल सकता है। यह विषय Aspose.CAD API के उपयोग की व्याख्या करता है ताकि निर्यातित PDF में DWG चित्र के लिए प्रिंट क्षेत्र सेट करने का समर्थन प्राप्त किया जा सके।

नीचे कोड नमूना दिखाता है कि इस सुविधाओं को कैसे लागू किया जाए।

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG फ़ाइल के लिए XREF मेटाडेटा पढ़ने का समर्थन**

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. हर चित्र इकाई से गुजरें।
1. यदि इकाई [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) है, तो मेटाडेटा के साथ XREF इकाई।

नीचे कोड नमूना दिखाता है कि इस सुविधाओं को कैसे प्राप्त किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **निर्देशांक देकर DWG दस्तावेज़**

Aspose.CAD for Java API अब दस्तावेज़ की चौड़ाई और ऊँचाई के निर्देशांक देकर DWG दस्तावेज़ों को प्रस्तुत करने की सुविधा प्रदान करता है।

नीचे कोड नमूना दिखाता है कि DWG दस्तावेज़ को कैसे प्रस्तुत करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

प्रॉपर्टी [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) स्ट्रिंग ऐरे का प्रकार है इसलिए आप PDF प्रारूप में संभावित परिवर्तनों के लिए एक समय में एक से अधिक लेआउट निर्दिष्ट कर सकते हैं। [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) प्रॉपर्टी के लिए एक से अधिक लेआउट निर्दिष्ट करते समय, परिणामी PDF में कई पृष्ठ होंगे, जहाँ प्रत्येक पृष्ठ एक व्यक्तिगत AutoCAD लेआउट का प्रतिनिधित्व करता है।

### **सभी लेआउटों की सूची**

आप निम्नलिखित कोड स्निपेट का उपयोग करके एक AutoCAD चित्र में सभी लेआउटों की सूची तैयार कर सकते हैं।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **बाहरी संदर्भ की ब्लॉक विशेषता का मान प्राप्त करना**

Aspose.CAD for Java API आपको एक ब्लॉक विशेषता के बाहरी संदर्भ को प्राप्त करने की अनुमति देता है। Aspose.CAD API [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) प्रॉपर्टी को बाहरी संदर्भ को प्राप्त करने के लिए उजागर करता है [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) संकलन में।

नीचे कोड दिखाता है कि एक ब्लॉक विशेषता के बाहरी संदर्भ को कैसे प्राप्त करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **DWG AutoCAD फ़ाइल में पाठ खोजें**

Aspose.CAD for Java API आपको DWG AutoCAD फ़ाइल में पाठ खोजने की अनुमति देता है। Aspose.CAD API [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) क्लास को उजागर करता है जो DWG AutoCAD फ़ाइल में पाठ इकाइयों का प्रतिनिधित्व करता है। [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) क्लास को भी Aspose.CAD API में शामिल किया गया है क्योंकि कुछ अन्य इकाइयों में भी पाठ हो सकता है।

नीचे कोड दिखाता है कि DWG AutoCAD फ़ाइल में पाठ कैसे खोजा जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **विशिष्ट लेआउट में पाठ खोजें**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **DWG प्रारूप के लिए उपरि ध्वज तक पहुँच प्राप्त करना**

Aspose.CAD for Java ने DWG प्रारूप के लिए उपरि ध्वज लागू किया है और डेवलपर्स को इन तक पहुँचने की अनुमति दी है। निम्नलिखित सरल कोड प्रदर्शन है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **DWG संस्थाओं का समर्थन**

Aspose.CAD for Java API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है और साथ काम करने के लिए विभिन्न संस्थाओं का समर्थन करता है।

### **MLeader संस्थाओं का समर्थन**

DWG एक बाइनरी फ़ाइल है जो वेक्टर चित्र डेटा और मेटाडाटा को शामिल करती है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग DWG फ़ाइल के भीतर MLeader संस्था के साथ कार्य करने के उदाहरण का वर्णन करता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **DWG संस्था को चित्र में निर्यात करने का समर्थन**

DWG एक बाइनरी फ़ाइल है जो वेक्टर चित्र डेटा और मेटाडाटा को शामिल करती है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग एक विशेष DWG संस्था को चित्र में निर्यात करने का उदाहरण वर्णन करता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **DWG फ़ाइल में छवि आयात करने का समर्थन**

Aspose.CAD for Java API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है और साथ काम करने के लिए विभिन्न संस्थाओं का समर्थन करता है। DWG एक बाइनरी फ़ाइल है जो वेक्टर चित्र डेटा और मेटाडाटा को शामिल करती है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग वर्णन करता है कि हम DWG फ़ाइल के भीतर चित्रों को कैसे आयात कर सकते हैं।

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **DWG में पाठ जोड़ने का समर्थन**

Aspose.CAD for Java API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है और साथ काम करने के लिए विभिन्न संस्थाओं का समर्थन करता है। DWG एक बाइनरी फ़ाइल है जो वेक्टर चित्र डेटा और मेटाडाटा को शामिल करती है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग वर्णन करता है कि हम DWG फ़ाइल के भीतर पाठ को कैसे जोड़ सकते हैं।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **DWG में मेष का समर्थन**

Aspose.CAD for Java API अब मेष का समर्थन करने वाली संस्थाओं तक पहुँच प्राप्त कर सकता है, जिसमें [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) और [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) प्रकार शामिल हैं। निम्नलिखित उदाहरण वर्णन करता है कि हम मेष प्रकारों तक कैसे पहुँच सकते हैं।

## **DWG चित्रों को DXF में परिवर्तित करना**

Aspose.CAD DWG फ़ाइल को लोड करने और इसे DXF फ़ॉर्मेट में एक्सपोर्ट करने की सुविधा प्रदान करता है। DWG से DXF रूपांतरण का दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके DWG चित्र फ़ाइल लोड करें।
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके DWG चित्र को DXF में निर्यात करें।

नीचे कोड नमूना दिखाता है कि एक DWG फ़ाइल को DXF प्रारूप में कैसे परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **DWG चित्रों को SVG में परिवर्तित करना**

Aspose.CAD API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है, और उसे SVG में परिवर्तित कर सकता है। यह विषय Aspose.CAD API के उपयोग की व्याख्या करता है ताकि DWG को SVG प्रारूप में परिवर्तित किया जा सके जैसा नीचे सरल चरणों में परिभाषित है।

1. DWG फ़ाइल को [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) के एक उदाहरण में लोड करें।
1. [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) वर्ग की एक वस्तु बनाएं और आवश्यक प्रॉपर्टीज सेट करें।
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके DWG चित्र को SVG में निर्यात करें।

नीचे कोड नमूना दिखाता है कि एक DWG फ़ाइल को SVG प्रारूप में कैसे परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
