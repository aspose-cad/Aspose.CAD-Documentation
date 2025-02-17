---
title: DWF ड्रॉइंग
type: docs
weight: 20
url: /hi/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **PDF में DWF ड्रॉइंग का निर्यात**

Aspose.CAD ऑटोकैड [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग संस्थाओं को लोड करने और उन्हें [PDF](https://docs.fileformat.com/pdf/) प्रारूप में एक पूरे ड्रॉइंग के रूप में प्रस्तुत करने की सुविधा प्रदान करता है। [DWF](https://docs.fileformat.com/cad/dwf/) से [PDF](https://docs.fileformat.com/pdf/) रूपांतरण का दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्टरी विधि का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग फ़ाइल लोड करें।
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) प्रॉपर्टीज सेट करें।
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) प्रॉपर्टी सेट करें।
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

### सैंपल कोड

नीचे दिया गया कोड नमूना दिखाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके फ़ाइल को कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF ड्रॉइंग से स्तर निकालना**

Aspose.CAD ऑटोकैड [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग संस्थाओं को लोड करने और उन्हें [JPEG](https://docs.fileformat.com/image/jpeg/) प्रारूप में एक पूरे ड्रॉइंग के रूप में प्रस्तुत करने की सुविधा प्रदान करता है।

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्टरी विधि का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग फ़ाइल लोड करें।
2. [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) वर्ग का एक ऑब्जेक्ट बनाएं।
3. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं।
4. [JPEG](https://docs.fileformat.com/image/jpeg/) ऑब्जेक्ट का उपयोग करके स्तरों के नाम निकालें।
5. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

### सैंपल कोड

नीचे दिया गया कोड नमूना दिखाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके फ़ाइल को कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF में स्तरों का समर्थन**

Aspose.CAD ऑटोकैड [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग संस्थाओं को लोड करने और उन्हें [JPEG](https://docs.fileformat.com/image/jpeg/) प्रारूप में एक पूरे ड्रॉइंग के रूप में प्रस्तुत करने की सुविधा प्रदान करता है।

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्टरी विधि का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग फ़ाइल लोड करें।
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं।
3. इच्छित स्तर जोड़ें।
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

### सैंपल कोड

नीचे दिया गया कोड नमूना दिखाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके फ़ाइल को कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **BMP में DWF ड्रॉइंग का निर्यात**

Aspose.CAD ऑटोकैड [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग संस्थाओं को लोड करने और उन्हें [BMP](https://docs.fileformat.com/image/bmp/) प्रारूप में एक पूरे ड्रॉइंग के रूप में प्रस्तुत करने की सुविधा प्रदान करता है। [DWF](https://docs.fileformat.com/cad/dwf/) से [BMP](https://docs.fileformat.com/image/bmp/) रूपांतरण का दृष्टिकोण इस प्रकार काम करता है:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) फ़ैक्टरी विधि का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) ड्रॉइंग फ़ाइल लोड करें।
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) और [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) प्रॉपर्टीज सेट करें।
3. [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) वर्ग का एक ऑब्जेक्ट बनाएं और [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) प्रॉपर्टी सेट करें।
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) को कॉल करें जबकि [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) का एक ऑब्जेक्ट दूसरे पैरामीटर के रूप में पास करें।

### सैंपल कोड

नीचे दिया गया कोड नमूना दिखाता है कि डिफ़ॉल्ट सेटिंग्स का उपयोग करके [DWF](https://docs.fileformat.com/cad/dwf/) फ़ाइल को [BMP](https://docs.fileformat.com/image/bmp/) में कैसे रूपांतरित किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
