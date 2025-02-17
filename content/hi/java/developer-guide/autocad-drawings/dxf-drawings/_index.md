---
title: DXF चित्रण
type: docs
weight: 60
url: /hi/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **DXF चित्रण को PDF में निर्यात करना**

Aspose.CAD AutoCAD DXF चित्रण इकाइयों को लोड करने और उन्हें एक संपूर्ण चित्रण के रूप में PDF प्रारूप में रेंडर करने की सुविधा प्रदान करता है। DXF से PDF रूपांतरण दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके DXF चित्रण फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) प्रॉपर्टीज सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) क्लास का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करते हुए Image.Save को कॉल करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि कैसे डिफ़ॉल्ट सेटिंग्स का उपयोग करके फ़ाइल को परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **समर्थित स्वरूप**

वर्तमान में हम AutoCAD DXF 2010 फ़ाइल स्वरूप को पूरी तरह से समर्थन करते हैं। पिछले DXF संस्करणों को 100% वैध होने की गारंटी नहीं है। हम भविष्य के Aspose.CAD संस्करणों में अधिक स्वरूपों और सुविधाओं को शामिल करने की योजना बना रहे हैं।

### **समर्थित इकाइयाँ**

वर्तमान में हम सभी व्यापक 2डी इकाइयों और उनके बेसिक डिफ़ॉल्ट पैरामीटर्स का समर्थन करते हैं जैसे कि:

1. संरेखित आयाम
1. कोणीय आयाम
1. आर्क
1. एट्रीब्यूट
1. ब्लॉक संदर्भ
1. वृत्त
1. व्यास आयाम
1. अंडाकार
1. हैच
1. रेखा
1. मल्टीलाइन टेक्स्ट
1. आर्डिनेट आयाम
1. बिंदु
1. पॉलीलाइन
1. रेडियल आयाम
1. किरण
1. घुमा हुआ आयाम
1. तालिका
1. पाठ
1. एक्सलाइन

{{% alert color="primary" %}}

यदि विश्लेषण के दौरान हम किसी ऐसी इकाई या प्रॉपर्टी का सामना करते हैं जिसका हम समर्थन नहीं करते हैं, तो इकाई या प्रॉपर्टी चुपचाप अनदेखी कर दी जाएगी।

{{% /alert %}}

### **मेमोरी प्रबंधन**

[**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) प्रॉपर्टी का उपयोग मेमोरी फिर से आवंटन को नियंत्रित करने के लिए किया जा सकता है। फिर से आवंटन आमतौर पर पूर्व-निर्धारित कैश के लिए होता है। यह तब होता है जब सिस्टम पता लगाता है कि आवंटित स्थान पर्याप्त नहीं होगा।

- यदि [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) को डिफ़ॉल्ट मान **False** पर सेट किया गया है, तो स्थान को समान माध्यम में फिर से आवंटित किया जाता है।
- जब इसे **True** पर सेट किया जाता है, तो फिर से आवंटन अधिकतम निर्दिष्ट स्थान से अधिक नहीं हो सकता है। इस स्थिति में, मौजूदा आवंटित इन-मेमोरी कैश (जिसे फिर से आवंटित करना आवश्यक है) को मुक्त किया जाता है और डिस्क पर विस्तारित स्थान आवंटित किया जाता है।

## **DXF चित्रण की विशिष्ट परत को PDF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DXF चित्रण फ़ाइल खोलें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) का एक उदाहरण बनाएं और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) प्रॉपर्टीज निर्दिष्ट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) के ऑब्जेक्ट में परतें जोड़ें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) का एक उदाहरण बनाएं और अपनी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके चित्रण को PDF में निर्यात करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि कैसे DXF की एक विशिष्ट परत को PDF में परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **DXF चित्रण की विशिष्ट परत को छवि में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DXF चित्रण फ़ाइल खोलें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) का एक उदाहरण बनाएं और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) प्रॉपर्टीज निर्दिष्ट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) के ऑब्जेक्ट में परतें जोड़ें।
1. [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) का एक उदाहरण बनाएं और उसकी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके चित्रण को PDF में निर्यात करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि कैसे DXF की एक विशिष्ट परत को छवि में परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **DXF चित्रण के रूप में PDF फ़ाइलें रेंडर करें**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके DXF चित्रण फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक ऑब्जेक्ट बनाएं और PDF फ़ाइलें लोड करें।
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) प्रॉपर्टीज सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) को कॉल करें और फ़ाइल बचाएं।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF चित्रण के रूप में PDF फ़ाइलें कैसे रेंडर करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **DXF को WMF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके DXF चित्रण फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक ऑब्जेक्ट बनाएं और PDF फ़ाइलें लोड करें।
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) प्रॉपर्टीज सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) को कॉल करें और फ़ाइल बचाएं।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF को WMF में कैसे निर्यात किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **DXF फ़ाइलों को सहेजने का समर्थन**

Aspose.CAD AutoCAD DXF फ़ाइलों को लोड करने, उसमें बदलाव करने और इसे फिर से DXF फ़ाइल के रूप में सहेजने की सुविधा प्रदान करता है। नीचे दिए गए कोड नमूने में दिखाया गया है कि कैसे निर्धारित आवश्यकताओं को प्राप्त करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **DXF प्रारूप के लिए एम्बेडेड DGN अंडरले निर्यात करना**

Aspose.CAD AutoCAD DXF फ़ाइलों को लोड करने और DXF प्रारूप के लिए एम्बेडेड DGN अंडरले निर्यात करने की सुविधा प्रदान करता है।

नीचे दिए गए कोड नमूने में दिखाया गया है कि कैसे निर्धारित आवश्यकताओं को प्राप्त करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **DXF की विशिष्ट लेआउट को PDF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DXF चित्रण फ़ाइल खोलें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) का एक उदाहरण बनाएं और [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) और [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) प्रॉपर्टीज निर्दिष्ट करें।
1. इच्छित लेआउट नामों का उपयोग करते हुए [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) प्रॉपर्टी का उपयोग करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) का एक उदाहरण बनाएं और उसकी [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) प्रॉपर्टी सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि का उपयोग करके चित्रण को PDF में निर्यात करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF की एक विशिष्ट लेआउट को PDF में कैसे परिवर्तित किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) प्रॉपर्टी स्ट्रिंग एरे प्रकार की है इसलिए आप एक साथ संभावित PDF प्रारूप में परिवर्तित करने के लिए एक से अधिक लेआउट निर्दिष्ट कर सकते हैं। [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) प्रॉपर्टी के लिए एक से अधिक लेआउट निर्दिष्ट करते समय, परिणामी PDF में कई पृष्ठ होंगे, जहां प्रत्येक पृष्ठ एक व्यक्तिगत AutoCAD लेआउट का प्रतिनिधित्व करता है।

{{% /alert %}}

## **ATTRIB और MTEXT ऑब्जेक्ट्स की पहुँच**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक DXF चित्रण फ़ाइल खोलें।
1. CAD फ़ाइल के अंदर इकाइयों तक पहुँचें।
1. [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) और [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) इकाइयों के लिए जाँच करें।
1. आगे की प्रक्रिया के लिए अस्थायी सूची में जोड़ें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **CAD इंसर्ट ऑब्जेक्ट्स के विघटन**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके एक **DXF** चित्रण फ़ाइल खोलें।
1. CAD फ़ाइल के अंदर इकाइयों तक पहुँचें।
1. [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) इकाइयों के लिए जाँच करें।
1. [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) प्रकार की सूची के लिए जाँच करें।
1. इकाइयों पर प्रक्रिया करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **ब्लॉक क्लिपिंग का समर्थन**

Aspose.CAD ब्लॉक क्लिपिंग की सुविधा प्रदान करता है। ब्लॉक क्लिपिंग दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) फ़ैक्टरी विधि का उपयोग करके DXF चित्रण फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) क्लास का एक ऑब्जेक्ट बनाएं और PDF फ़ाइलें लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) की इच्छित प्रॉपर्टीज सेट करें।
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) का एक ऑब्जेक्ट पास करते हुए फ़ाइल को सहेजें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि ब्लॉक क्लिपिंग कैसे काम करता है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **DXF में छवियों का निर्यात करें**

Aspose.CAD का उपयोग करके, आप DXF प्रारूप में छवियों का निर्यात कर सकते हैं। इस दृष्टिकोण का उपयोग करते हुए, आप निम्नलिखित कार्य किए जा सकते हैं:

1. नया फ़ॉन्ट सेट करें
1. इकाइयों को छिपाएँ
1. टेक्स्ट अपडेट करें

निम्नलिखित कोड स्निप्पेट दिखाता है कि आप ऊपर सूचीबद्ध कार्यों को कैसे करेंगे।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
