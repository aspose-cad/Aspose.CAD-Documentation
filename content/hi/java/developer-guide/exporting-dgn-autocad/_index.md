---
title: DGN ऑटोकैड का निर्यात
type: docs
weight: 50
url: /hi/java/developer-guide/exporting-dgn-autocad/
---

## **PDF में DGN ऑटोकैड प्रारूप का निर्यात**

Aspose.CAD के लिए Java API ने [DGN](https://docs.fileformat.com/cad/dgn/) ऑटोकैड फ़ाइल को लोड करने और उसे [PDF](https://docs.fileformat.com/pdf/) प्रारूप में परिवर्तित करने की कार्यक्षमता पेश की है। [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) वर्ग इसका उद्देश्य पूरा करता है।

आपको एक मौजूदा DGN फ़ाइल को [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) के रूप में लोड करने की आवश्यकता है। [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) वर्ग का एक उदाहरण बनाएं और विभिन्न गुण सेट करें। [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) वर्ग का एक उदाहरण बनाएं और [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) उदाहरण को पास करें। अब [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) वर्ग के उदाहरण के [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि को कॉल करें।

### नमूना कोड

DGN को PDF प्रारूप में परिवर्तित/निर्यात करने के लिए कोड प्रदर्शन निम्नलिखित है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **रेस्टर छवि प्रारूप में DGN ऑटोकैड का निर्यात**

Aspose.CAD के लिए Java API ने एक [DGN](https://docs.fileformat.com/cad/dgn/) ऑटोकैड फ़ाइल को लोड करने और उसे रेस्टर छवि में परिवर्तित करने की कार्यक्षमता पेश की है। [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) वर्ग इसका उद्देश्य पूरा करता है।

आपको एक मौजूदा DGN फ़ाइल को [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) के रूप में लोड करने की आवश्यकता है। [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) वर्ग का एक उदाहरण बनाएं और विभिन्न गुण सेट करें। [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) वर्ग का एक उदाहरण बनाएं और [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) उदाहरण को पास करें। अब [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) वर्ग के उदाहरण के [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) विधि को कॉल करें।

### नमूना कोड

[DGN](https://docs.fileformat.com/cad/dgn/) को [JPEG](https://docs.fileformat.com/image/jpeg/) छवि में परिवर्तित/निर्यात करने के लिए कोड प्रदर्शन निम्नलिखित है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
