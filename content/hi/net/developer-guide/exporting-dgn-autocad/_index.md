---
title: DGN ऑटोकैड का निर्यात
type: docs
weight: 50
url: /hi/net/developer-guide/exporting-dgn-autocad/
---

## **DGN ऑटोकैड प्रारूप को PDF में निर्यात करना**

Aspose.CAD के लिए .NET API ने एक DGN ऑटोकैड फ़ाइल को लोड करने और उसे PDF प्रारूप में बदलने की कार्यक्षमता पेश की है। [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) क्लास इसका उद्देश्य पूरा करती है।

आपको एक मौजूदा DGN फ़ाइल को [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) के रूप में लोड करना होगा। [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) क्लास का एक उदाहरण बनाएं और विभिन्न प्रॉपर्टीज़ सेट करें। [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) क्लास का एक उदाहरण बनाएं और [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) उदाहरण पास करें। अब [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) मेथड को [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) क्लास के उदाहरण पर कॉल करें।

### नमूना कोड

[DGN](https://docs.fileformat.com/cad/dgn/) को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में परिवर्तित/निर्यात करने के लिए कोड प्रदर्शन निम्नलिखित है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DGN ऑटोकैड प्रारूप को रास्टर छवि प्रारूप में निर्यात करना**

Aspose.CAD के लिए .NET API ने एक DGN ऑटोकैड फ़ाइल को लोड करने और उसे एक रास्टर छवि में बदलने की कार्यक्षमता पेश की है। [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) क्लास इसका उद्देश्य पूरा करती है।

आपको एक मौजूदा DGN फ़ाइल को [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) के रूप में लोड करना होगा। [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) क्लास का एक उदाहरण बनाएं और विभिन्न प्रॉपर्टीज़ सेट करें। [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) क्लास का एक उदाहरण बनाएं और [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) उदाहरण पास करें। अब [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) मेथड को [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) क्लास के उदाहरण पर कॉल करें।

### नमूना कोड

[DGN](https://docs.fileformat.com/cad/dgn/) को [JPEG](https://docs.fileformat.com/image/jpeg/) छवि में परिवर्तित/निर्यात करने के लिए कोड प्रदर्शन निम्नलिखित है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **DGN v7 के लिए 3D तत्वों का समर्थन**

Aspose.CAD के लिए .NET API ने एक [DGN](https://docs.fileformat.com/cad/dgn/) ऑटोकैड फ़ाइल को लोड करने और DGN v7 के लिए 3D तत्वों का समर्थन करने की कार्यक्षमता पेश की है। [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) क्लास इसका उद्देश्य पूरा करती है। प्रत्येक [DGN](https://docs.fileformat.com/cad/dgn/) छवि 9 पूर्वनिर्धारित दृश्य का समर्थन करती है। इसे 1 से 9 तक क्रमांकित किया गया है। यदि निर्यात पर दृश्य निर्धारित नहीं है, तो मल्टी-पृष्ठ आउटपुट प्रारूपों (जैसे PDF) के लिए सभी दृश्य निर्यात किए जाएंगे, प्रत्येक एक अलग पृष्ठ पर। DGN फ़ाइल प्रारूप पर 3D तत्वों का समर्थन किया गया है, जैसे कि 2D। इसके लिए, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) का उपयोग किया जाता है, TypeOfEntities अब DGN प्रारूप के लिए उपयोग नहीं किया जाता (दोनों 2D और 3D एक साथ समर्थित हैं)।

### नमूना कोड

निम्नलिखित समर्थित DGN तत्वों को देखने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
