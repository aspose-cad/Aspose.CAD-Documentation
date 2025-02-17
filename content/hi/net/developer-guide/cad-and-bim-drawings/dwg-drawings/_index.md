---
title: DWG चित्र
type: docs
weight: 40
url: /hi/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG चित्रों को PDF में निर्यात करना**

Aspose.CAD के लिए .NET API [DWG](https://docs.fileformat.com/cad/dwg/) प्रारूप में ऑटोकैड चित्रों को लोड कर सकता है, और इसे [PDF](https://docs.fileformat.com/pdf/) में परिवर्तित कर सकता है। यह विषय Aspose.CAD API के उपयोग की व्याख्या करता है ताकि DWG को PDF प्रारूप में सरल चरणों के माध्यम से परिवर्तित किया जा सके जैसे कि आगे निर्धारित किया गया है।

{{% alert color="primary" %}}

API निम्नलिखित ऑटोकैड DWG संशोधनों का समर्थन करता है:

- DWG 2004 संस्करण 16.0 रिलीज़ 18
- DWG 2005 संस्करण 16.1
- DWG 2010 संस्करण 18.0
- DWG 2013 संस्करण 19.0

{{% /alert %}}

### **DWG फ़ाइल प्रारूप**

[DWG](https://docs.fileformat.com/cad/dwg/) एक बाइनरी फ़ाइल है जिसमें वेक्टर छवि डेटा और मेटाडेटा होता है। वेक्टर छवि डेटा CAD एप्लिकेशन को DWG को प्रदर्शित करने के तरीके के बारे में निर्देश प्रदान करता है; मेटाडेटा फ़ाइल के बारे में विभिन्न प्रकार की जानकारी रख सकता है जिसमें स्थान-विशिष्ट डेटा और क्लाइंट डेटा भी शामिल है। DWG फ़ाइल प्रारूप के लिए ओपन स्पेसिफिकेशन्स [इस PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) में पाया जा सकता है।

### **DWG फ़ाइलों को PDF में परिवर्तित करना**

[DWG](https://docs.fileformat.com/cad/dwg/) को [PDF](https://docs.fileformat.com/pdf/) में परिवर्तित करने के लिए निम्नलिखित सरल चरणों की आवश्यकता है।

1. DWG फ़ाइल को [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) के एक उदाहरण में लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) प्रॉपर्टीज़ सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) प्रॉपर्टी सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) को कॉल करें जब [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास किया गया हो।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि DWG चित्रों को PDF में कैसे निर्यात किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **विभिन्न लेआउट आकारों के साथ एकल PDF बनाना**

Aspose.CAD .NET के लिए DWG फ़ाइल को विभिन्न लेआउट आकारों के साथ एकल PDF में परिवर्तित करने की अनुमति देता है। यह दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्ट्री विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊंचाई और चौड़ाई सेट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वस्तु के लिए आवश्यक [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) जोड़ें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) क्लास का एक उदाहरण बनाएं और इसकी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) प्रॉपर्टी सेट करें।
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके चित्र को PDF के रूप में निर्यात करें।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि विभिन्न लेआउट के साथ एकल [PDF](https://docs.fileformat.com/pdf/) कैसे बनाया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **समर्थित ऑटोकैड प्राथमिकताएँ**

निम्नलिखित ऑटोकैड प्राथमिकताएँ समर्थित हैं।

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

यह दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्ट्री विधि का उपयोग करके DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊंचाई और चौड़ाई सेट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वस्तु के लिए [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) प्रॉपर्टी सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) क्लास का एक उदाहरण बनाएं और इसकी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) प्रॉपर्टी सेट करें।
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि DWG के विशिष्ट लेआउट को PDF में कैसे परिवर्तित किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **निर्देशांक निर्दिष्ट करके DWG दस्तावेज़ को रेंडर करना**

Aspose.CAD के लिए .NET API अब दस्तावेज़ की चौड़ाई और ऊंचाई के निर्देशांक प्रदान करके DWG दस्तावेज़ों को रेंडर करने की सुविधा प्रदान करता है।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि DWG दस्तावेज़ को कैसे रेंडर किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **DWG को निर्धारित आकार का उपयोग करके रस्टर या PDF में निर्यात करना**

Aspose.CAD के लिए .NET API ऑटोकैड चित्रों को DWG प्रारूप में लोड कर सकता है, और निर्धारित आकार का उपयोग करके इसे PDF या रस्टर में परिवर्तित कर सकता है।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि इस सुविधा को कैसे लागू किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **DWG को PDF/A और PDF/E में निर्यात करना**

यह दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्ट्री विधि का उपयोग करके DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक उदाहरण बनाएं।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) क्लास का एक उदाहरण बनाएं और इसकी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) प्रॉपर्टी सेट करें।
1. PDF अनुपालन प्रॉपर्टी सेट करें और इसे सहेजें।
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि एक DWG फ़ाइल को PDF/A और PDF/E में कैसे परिवर्तित किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **DWG/DXF को BMP और PDF में निर्यात करते समय गोल्ड हिडन लाइनों का समर्थन**

यह दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्ट्री विधि का उपयोग करके DWG फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊंचाई और चौड़ाई सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) क्लास का एक उदाहरण बनाएं और इसकी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) प्रॉपर्टी सेट करें।
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि इस सुविधा को कैसे लागू किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **निर्यातित PDF में DWG छवि के लिए प्रिंट क्षेत्र सेट करने का समर्थन**

Aspose.CAD के लिए .NET API ऑटोकैड चित्रों को DWG प्रारूप में लोड कर सकता है, और इसे PDF में परिवर्तित कर सकता है। यह विषय Aspose.CAD API का उपयोग करने की व्याख्या करता है ताकि निर्यातित PDF में DWG छवि के लिए प्रिंट क्षेत्र सेट करने का समर्थन प्राप्त किया जा सके।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि इस सुविधा को कैसे लागू किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG फ़ाइल के लिए XREF मेटाडेटा पढ़ने का समर्थन**

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फैक्ट्री विधि का उपयोग करके DWG फ़ाइल लोड करें।
1. हर छवि इकाई के माध्यम से यात्रा करें।
1. यदि एक इकाई CadUnderlay है तो XREF इकाई के साथ मेटाडेटा।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि इस सुविधा को कैसे प्राप्त किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) प्रॉपर्टी स्ट्रिंग ऐरे के प्रकार की है ताकि आप PDF प्रारूप में संभावित रूपांतरण के लिए एक बार में एक से अधिक लेआउट निर्दिष्ट कर सकें। [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) प्रॉपर्टी के लिए एकाधिक लेआउट निर्दिष्ट करते समय, परिणामी PDF में कई पृष्ठ होंगे, जहां प्रत्येक पृष्ठ एक व्यक्तिगत ऑटोकैड लेआउट का प्रतिनिधित्व करता है।

### **सभी लेआउट की सूची**

आप निम्नलिखित कोड स्निपेट का उपयोग करके ऑटोकैड चित्रण में उपस्थित सभी लेआउटों की सूची बना सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **DWG प्रारूप के लिए अंडरलॉइंग फ्लैग्स तक पहुँच प्राप्त करना**

Aspose.CAD के लिए .NET ने DWG प्रारूप के लिए अंडरलॉइंग फ्लैग्स को लागू किया है और डेवलपर्स को उन्हें एक्सेस करने की अनुमति देता है। निम्नलिखित एक सरल कोड प्रदर्शन है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **DWG संस्थाओं के लिए समर्थन**

Aspose.CAD के लिए .NET API ऑटोकैड चित्रों को DWG प्रारूप में लोड कर सकता है और विभिन्न संस्थाओं के साथ काम करने को समर्थन देता है।

### **MLeader एंटिटी के लिए समर्थन**

DWG एक बाइनरी फ़ाइल है जिसमें वेक्टर छवि डेटा और मेटाडेटा होता है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग में DWG फ़ाइल के अंदर MLeader एंटिटी के साथ काम करने का एक उदाहरण वर्णित है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **DWG एंटिटी को छवि में निर्यात करने का समर्थन**

DWG एक बाइनरी फ़ाइल है जिसमें वेक्टर छवि डेटा और मेटाडेटा होता है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग में एक विशेष DWG एंटिटी को छवि में निर्यात करने का एक उदाहरण वर्णित है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **DWG में पाठ जोड़ने का समर्थन**

Aspose.CAD के लिए .NET API ऑटोकैड चित्रों को DWG प्रारूप में लोड कर सकता है और विभिन्न संस्थाओं के साथ काम करने के लिए समर्थन करता है।  DWG एक बाइनरी फ़ाइल है जिसमें वेक्टर छवि डेटा और मेटाडेटा होता है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग में यह वर्णित है कि हम DWG फ़ाइल के अंदर पाठ कैसे जोड़ सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **DWG फ़ाइल में छवि आयात करने का समर्थन**

Aspose.CAD के लिए .NET API ऑटोकैड चित्रों को DWG प्रारूप में लोड कर सकता है और विभिन्न संस्थाओं के साथ काम करने के लिए समर्थन करता है।  DWG एक बाइनरी फ़ाइल है जिसमें वेक्टर छवि डेटा और मेटाडेटा होता है। DWG फ़ाइल में विभिन्न संस्थाएँ होती हैं। निम्नलिखित अनुभाग में यह वर्णित है कि हम DWG फ़ाइल के अंदर छवियों को कैसे आयात कर सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **DWG में मेष का समर्थन**

Aspose.CAD के लिए .NET API अब [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) और [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) प्रकारों सहित मेष का समर्थन करने वाली संस्थाओं तक पहुँच प्राप्त कर सकता है। निम्नलिखित उदाहरण में दर्शाया गया है कि हम मेष प्रकारों तक कैसे पहुँच सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG चित्रों को DXF में परिवर्तित करना**

Aspose.CAD ऑटोकैड DWG फ़ाइल को लोड करने और इसे DXF प्रारूप में निर्यात करने की सुविधा प्रदान करता है। DWG से DXF में रूपांतरण का दृष्टिकोण इस प्रकार कार्य करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फैक्ट्री विधि का उपयोग करके DWG ड्राइंग फ़ाइल लोड करें।
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके DWG ड्राइंग को DXF में निर्यात करें।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि एक DWG फ़ाइल को DXF प्रारूप में कैसे परिवर्तित किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG चित्रों को SVG में परिवर्तित करना**

Aspose.CAD के लिए .NET API ऑटोकैड चित्रों को DWG फ़ॉर्मेट में लोड कर सकता है, और इसे SVG में परिवर्तित कर सकता है। यह विषय Aspose.CAD API के उपयोग की व्याख्या करता है ताकि DWG को SVG प्रारूप में परिवर्तित किया जा सके सरल चरणों के माध्यम से जैसे कि नीचे निर्धारित किया गया है।

1. DWG फ़ाइल को [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) के एक उदाहरण में लोड करें।
1. [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) क्लास का एक ऑब्जेक्ट बनाएं और आवश्यक प्रॉपर्टीज़ सेट करें।
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके DWG ड्राइंग को SVG में निर्यात करें।

नीचे दिए गए कोड नमूने में यह दिखाया गया है कि एक DWG फ़ाइल को SVG प्रारूप में कैसे परिवर्तित किया जाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **बड़े DWG फ़ाइल को लोड करना**

Aspose.CAD के लिए .NET बहुत बड़े DWG फ़ाइलों को [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) क्लास का उपयोग करके खोलने की सुविधा प्रदान करता है। अब आप नीचे दिए गए नमूने के कोड की मदद से बड़े फ़ाइलों को आसानी से खोल सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
