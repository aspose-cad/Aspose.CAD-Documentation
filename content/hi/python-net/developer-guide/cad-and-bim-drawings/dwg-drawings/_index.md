---
title: DWG चित्र
type: docs
weight: 70
url: /hi/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG चित्रों को PDF में निर्यात करना**

Aspose.CAD के लिए Python API [DWG](https://docs.fileformat.com/cad/dwg/) प्रारूप में AutoCAD चित्रों को लोड कर सकता है, और इसे [PDF](https://docs.fileformat.com/pdf/) में परिवर्तित कर सकता है। यह विषय Aspose.CAD API का उपयोग करने के तरीके को सरल चरणों के माध्यम से समझाता है जैसा कि आगे परिभाषित किया गया है।

{{% alert color="primary" %}}

API निम्नलिखित AutoCAD DWG संशोधनों का समर्थन करता है:

- DWG 2004 संस्करण 16.0 रिलीज 18
- DWG 2005 संस्करण 16.1
- DWG 2010 संस्करण 18.0
- DWG 2013 संस्करण 19.0

{{% /alert %}}

### **DWG फ़ाइल प्रारूप**

[DWG](https://docs.fileformat.com/cad/dwg/) एक बाइनरी फ़ाइल है जिसमें वेक्टर छवि डेटा और मेटाडेटा होता है। वेक्टर छवि डेटा CAD एप्लिकेशन को DWG को प्रदर्शित करने के तरीके के बारे में निर्देश प्रदान करता है; मेटाडेटा में फ़ाइल के बारे में विभिन्न प्रकार की जानकारी हो सकती है जिसमें स्थान-विशिष्ट डेटा और ग्राहक डेटा भी शामिल हैं। DWG फ़ाइल प्रारूप के लिए खुली विशिष्टताएँ [इस PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) में पाई जा सकती हैं।

### **DWG फ़ाइलों को PDF में परिवर्तित करना**

[DWG](https://docs.fileformat.com/cad/dwg/) को [PDF](https://docs.fileformat.com/pdf/) में परिवर्तित करने के लिए निम्नलिखित सरल चरणों की आवश्यकता है।

1. DWG फ़ाइल को **Image** के एक उदाहरण में लोड करें।
1. **CadRasterizationOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **page_height** और **page_width** विशेषताओं को सेट करें।
1. **PdfOptions** वर्ग का एक ऑब्जेक्ट बनाएं और **VectorRasterizationOptions** विशेषता को सेट करें।
1. **Image.save** को कॉल करें जबकि **PdfOptions** के एक ऑब्जेक्ट को दूसरे पैरामीटर के रूप में पास करें।

नीचे दिया गया कोड नमूना दिखाता है कि DWG चित्रों को PDF में कैसे निर्यात किया जाता है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **समर्थित AutoCAD प्राइमिटिव्स**

निम्नलिखित AutoCAD प्राइमिटिव्स का समर्थन किया जाता है।

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

1. **Aspose.CAD.Image.load** फ़ैक्टरी विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक उदाहरण बनाएं और परिणामी पृष्ठ की ऊँचाई और चौड़ाई सेट करें।
1. **CadRasterizationOptions** ऑब्जेक्ट के लिए **Layouts** विशेषता सेट करें।
1. **PdfOptions** वर्ग का एक उदाहरण बनाएं और इसकी **VectorRasterizationOptions** विशेषता सेट करें।
1. **Image.save()** विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे दिया गया कोड नमूना दिखाता है कि DWG को PDF में विशेष लेआउट कैसे परिवर्तित किया जाता है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **DWG को PDF/A और PDF/E में निर्यात करना**

यह दृष्टिकोण इस प्रकार कार्य करता है:

1. **Image.load** फ़ैक्टरी विधि का उपयोग करके एक DWG फ़ाइल लोड करें।
1. **CadRasterizationOptions** वर्ग का एक उदाहरण बनाएं।
1. **PdfOptions** वर्ग का एक उदाहरण बनाएं और इसकी **VectorRasterizationOptions** विशेषता सेट करें।
1. PDF अनुपालन विशेषता सेट करें और इसे सहेजें।
1. **Image.save()** विधि का उपयोग करके चित्र को PDF में निर्यात करें।

नीचे दिया गया कोड नमूना दिखाता है कि DWG फ़ाइल को PDF/A और PDF/E में कैसे परिवर्तित किया जाता है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG चित्रों को DXF में परिवर्तित करना**

Aspose.CAD AutoCAD DWG फ़ाइल को लोड करने और इसे DXF प्रारूप में निर्यात करने की सुविधा प्रदान करता है। DWG से DXF परिवर्तित करने का दृष्टिकोण इस प्रकार कार्य करता है:

1. **Image.load** फ़ैक्टरी विधि का उपयोग करके DWG चित्र फ़ाइल लोड करें।
1. **Image.save()** विधि का उपयोग करके DWG चित्र को DXF में निर्यात करें।

नीचे दिया गया कोड नमूना दिखाता है कि कैसे एक DWG फ़ाइल को DXF प्रारूप में परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG चित्रों को SVG में परिवर्तित करना**

Aspose.CAD के लिए Python API DWG प्रारूप में AutoCAD चित्रों को लोड कर सकता है, और इसे SVG में परिवर्तित कर सकता है। यह विषय Aspose.CAD API का उपयोग करने के तरीके को सरल चरणों के माध्यम से समझाता है जैसा कि नीचे परिभाषित किया गया है।

1. DWG फ़ाइल को **Image** के एक उदाहरण में लोड करें।
1. **SvgOptions** वर्ग का एक ऑब्जेक्ट बनाएं और आवश्यक विशेषताएँ सेट करें।
1. **Image.save()** विधि का उपयोग करके DWG चित्र को SVG में निर्यात करें।

नीचे दिया गया कोड नमूना दिखाता है कि DWG फ़ाइल को SVG प्रारूप में कैसे परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
