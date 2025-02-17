---
title: DXF चित्र
type: docs
weight: 60
url: /hi/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF चित्रों को PDF में निर्यात करना**

Aspose.CAD ऑटोकैड DXF चित्र इकाइयों को लोड करने और उन्हें एक संपूर्ण चित्र के रूप में PDF प्रारूप में रेंडर करने की सुविधा प्रदान करता है। DXF से PDF रूपांतरण दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके DXF चित्र फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके फ़ाइल को कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **समर्थित प्रारूप**

वर्तमान में हम पूरी तरह से ऑटोकैड DXF 2010 फ़ाइल प्रारूप का समर्थन करते हैं। पिछले DXF संस्करण को 100% मान्य होने की गारंटी नहीं है। हम भविष्य के Aspose.CAD संस्करणों में और अधिक प्रारूप और सुविधाएँ शामिल करने की योजना बना रहे हैं।

### **समर्थित इकाइयाँ**

वर्तमान में हम सभी व्यापक 2D इकाइयों और उनके मूल डिफ़ॉल्ट पैरामीटर का समर्थन करते हैं:

1. संरेखित आयाम
1. कोणीय आयाम
1. आर्क
1. गुण
1. ब्लॉक संदर्भ
1. वृत्त
1. व्यास आयाम
1. अंडाकार
1. हैच
1. रेखा
1. मल्टीलाइन टेक्स्ट
1. ऑर्डिनेट आयाम
1. बिंदु
1. बहुरेखा
1. रेडियल आयाम
1. रेज़
1. घूर्णन आयाम
1. तालिका
1. पाठ
1. एक्सलाइन

{{% alert color="primary" %}}

यदि पार्स करते समय हमें कोई ऐसी इकाई या गुण मिलता है जिसका हम समर्थन नहीं करते हैं, तो उस इकाई या गुण को चुपचाप अनदेखा कर दिया जाएगा।

{{% /alert %}}

### **मेमोरी प्रबंधन**

[**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) वर्ग का [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) गुण मेमोरी पुनः आवंटन को नियंत्रित करने के लिए उपयोग किया जा सकता है। पुनः आवंटन प्री-अलोकेटेड कैश के लिए सबसे अधिक होने की संभावना है। यह तब हो सकता है जब सिस्टम यह पता लगाता है कि आवंटित स्थान पर्याप्त नहीं होगा।

- यदि [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) को डिफ़ॉल्ट मान **False** पर सेट किया गया है, तो स्थान को उसी माध्यम पर पुनः आवंटित किया जाता है।
- जब **True** पर सेट किया जाता है, तो पुनः आवंटन को अधिकतम निर्दिष्ट स्थान से अधिक नहीं होना चाहिए। इस मामले में मौजूदा आवंटित इन-मेमोरी कैश (जिसे पुनः आवंटन की आवश्यकता होती है) को मुक्त किया जाता है और डिस्क पर बढ़ा हुआ स्थान आवंटित किया जाता है।

## **DXF चित्रों की विशेष परत को PDF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके एक DXF चित्र फ़ाइल खोलें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) का एक उदाहरण बनाएं और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) गुण निर्दिष्ट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) के ऑब्जेक्ट में परतें जोड़ें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक उदाहरण बनाएं और उसके [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि को कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF की विशेष परत को PDF में कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **DXF चित्रों के एक भाग के रूप में PDF फ़ाइलों को रेंडर करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके DXF चित्र फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और PDF फ़ाइल लोड करें।
1. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें और फ़ाइल सहेजें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF चित्रों के एक भाग के रूप में PDF फ़ाइलों को कैसे रेंडर किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **DXF प्रारूप के लिए एम्बेडेड DGN अंडरलै लै का निर्यात**

Aspose.CAD ऑटोकैड DXF फ़ाइलों को लोड करने और DXF प्रारूप के लिए एम्बेडेड DGN अंडरलै को निर्यात करने की सुविधा प्रदान करता है।

नीचे दिए गए कोड नमूने में दिखाया गया है कि निर्दिष्ट आवश्यकताओं को कैसे पूरा किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DXF फ़ाइलों को सहेजने का समर्थन**

Aspose.CAD ऑटोकैड DXF फ़ाइलों को लोड करने और उसमें परिवर्तन करने और इसे फिर से DXF फ़ाइल के रूप में सहेजने की सुविधा प्रदान करता है।

नीचे दिए गए कोड नमूने में दिखाया गया है कि निर्दिष्ट आवश्यकताओं को कैसे पूरा किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXF को WMF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके DXF चित्र फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और PDF फ़ाइलें लोड करें।
1. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें और फ़ाइल सहेजें।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **विशेष DXF लेआउट को PDF में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके एक DXF चित्र फ़ाइल खोलें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) का एक उदाहरण बनाएं और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) गुण निर्दिष्ट करें।
1. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) गुण का उपयोग करते हुए इच्छित लेआउट नाम (नाम) निर्दिष्ट करें।
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक उदाहरण बनाएं और उसके [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि को PDF में निर्यात करने के लिए कॉल करें और [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF के विशेष लेआउट को PDF में कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

गुण [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) का प्रकार स्ट्रींग एर्रे है इसलिए आप PDF प्रारूप में रूपांतरण के लिए एक समय में एक से अधिक लेआउट निर्दिष्ट कर सकते हैं। [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) गुण के लिए कई लेआउट निर्दिष्ट करते समय, परिणामस्वरूप PDF में कई पृष्ठ होंगे, जहाँ प्रत्येक पृष्ठ एक व्यक्तिगत ऑटोकैड लेआउट का प्रतिनिधित्व करेगा।

{{% /alert %}}

## **ब्लॉक क्लिपिंग का समर्थन**

Aspose.CAD ब्लॉक क्लिपिंग की सुविधा प्रदान करता है। ब्लॉक क्लिपिंग दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके DXF चित्र फ़ाइल लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और PDF फ़ाइलें लोड करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) के इच्छित गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें और फ़ाइल सहेजें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि ब्लॉक क्लिपिंग कैसे काम करता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **DXF में चित्र निर्यात करना**

Aspose.CAD का उपयोग करके, आप चित्रों को DXF प्रारूप में निर्यात कर सकते हैं। इस दृष्टिकोण का उपयोग करते हुए, आप निम्नलिखित कार्य कर सकते हैं:

1. नया फ़ॉन्ट सेट करें
1. इकाइयाँ छुपाएं
1. पाठ अपडेट करें

नीचे दिया गया कोड स्निप्पेट आपको उपरोक्त कार्यों को करने का तरीका दिखाता है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **DXF चित्रों की विशेष परत को चित्र में निर्यात करना**

यह दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) फ़ैक्टरी विधि का उपयोग करके DXF चित्र फ़ाइल खोलें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) का एक उदाहरण बनाएं और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) गुण निर्दिष्ट करें।
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) के ऑब्जेक्ट में परतें जोड़ें।
1. [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) का एक उदाहरण बनाएं और उसके [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) गुण सेट करें।
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) विधि का उपयोग करके चित्र को निर्यात करें।

नीचे दिए गए कोड नमूने में दिखाया गया है कि DXF की विशेष परत को चित्र में कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
