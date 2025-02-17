---
title: DGN ऑटोकैड का निर्यात
type: docs
weight: 50
url: /hi/python-net/developer-guide/exporting-dgn-autocad/
---

## **DGN ऑटोकैड प्रारूप को PDF में निर्यात करना**

Aspose.CAD के लिए Python API ने DGN ऑटोकैड फ़ाइल को लोड करने और उसे PDF प्रारूप में बदलने की कार्यक्षमता पेश की है। **CadImage** क्लास इसका उद्देश्य पूरा करती है।

आपको एक मौजूदा DGN फ़ाइल को **CadImage** के रूप में लोड करना होगा। **CadRasterizationOptions** क्लास का एक उदाहरण बनाएं और विभिन्न प्रॉपर्टीज़ सेट करें। **PdfOptions** क्लास का एक उदाहरण बनाएं और **CadRasterizationOptions** उदाहरण को पास करें। अब **CadImage** क्लास के उदाहरण की **save** विधि को कॉल करें।

### नमूना कोड

[DGN](https://docs.fileformat.com/cad/dgn/) को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में परिवर्तित/निर्यात करने के लिए कोड प्रदर्शन निम्नलिखित है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}

## **DGN ऑटोकैड प्रारूप को रास्टर छवि प्रारूप में निर्यात करना**

Aspose.CAD के लिए Python API ने DGN ऑटोकैड फ़ाइल को लोड करने और इसे एक रास्टर छवि में बदलने की कार्यक्षमता पेश की है। **CadImage** क्लास इसका उद्देश्य पूरा करती है।

आपको एक मौजूदा DGN फ़ाइल को **CadImage** के रूप में लोड करना होगा। **CadRasterizationOptions** क्लास का एक उदाहरण बनाएं और विभिन्न प्रॉपर्टीज़ सेट करें। **JpegOptions** क्लास का एक उदाहरण बनाएं और **CadRasterizationOptions** उदाहरण को पास करें। अब **CadImage** क्लास के उदाहरण की **save** विधि को कॉल करें।

### नमूना कोड

[DGN](https://docs.fileformat.com/cad/dgn/) को [JPEG](https://docs.fileformat.com/image/jpeg/) छवि में परिवर्तित/निर्यात करने के लिए कोड प्रदर्शन निम्नलिखित है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **DGN v7 के लिए 3D एंटिटीज़ का समर्थन**

Aspose.CAD के लिए Python API ने [DGN](https://docs.fileformat.com/cad/dgn/) ऑटोकैड फ़ाइल को लोड करने और DGN v7 के लिए 3D एंटिटीज़ का समर्थन करने की कार्यक्षमता पेश की है। **CadImage** क्लास इसका उद्देश्य पूरा करती है। प्रत्येक [DGN](https://docs.fileformat.com/cad/dgn/) छवि 9 पूर्व-निर्धारित दृश्यों का समर्थन करती है। इसे 1 से 9 तक संख्या दी गई है। यदि निर्यात पर दृश्य परिभाषित नहीं है, तो बहु-पृष्ठ आउटपुट प्रारूपों (जैसे PDF) के लिए सभी दृश्य निर्यात किए जाएंगे, प्रत्येक अलग पृष्ठ पर। DGN फ़ाइल प्रारूप पर 3D एंटिटीज़ का समर्थन किया गया है, साथ ही 2D का भी। इसके लिए, **VectorRasterizationOptions** का उपयोग किया जाता है, TypeOfEntities अब DGN प्रारूप (दोनों 2D और 3D एक साथ समर्थित) के लिए नहीं किया जाता है।

### नमूना कोड

निम्नलिखित समर्थित DGN तत्वों को देखने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
