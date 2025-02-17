---
title: CAD निर्यात
type: docs
weight: 40
url: /hi/net/developer-guide/exporting-cad/
---

## **3D AutoCAD छवियों को PDF में निर्यात करें**

Aspose.CAD आपको 3D AutoCAD छवियों को PDF में निर्यात करने की अनुमति देता है। कृपया [**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) का उपयोग करें ताकि यह निर्दिष्ट किया जा सके कि आप 3D एन्टिटीज़ को निर्यात करना चाहते हैं।

निम्नलिखित उदाहरण कोड एक AutoCAD 3D फ़ाइल को लोड करता है और उसे [PDF](https://docs.fileformat.com/pdf/) में निर्यात करता है। एक बार जब फ़ाइल को PDF में बदल दिया जाता है, तो आप इसे अपने पसंदीदा PDF व्यूअर का उपयोग करके खोल सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **CAD लेआउट को PDF में निर्यात करना**

Aspose.CAD for .NET आपको CAD लेआउट को PDF में निर्यात करने की अनुमति देता है। [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) मेथड का उपयोग [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) क्लास के द्वारा लेआउट(s) को [PDF](https://docs.fileformat.com/pdf/) प्रारूप में निर्यात करने के लिए किया जा सकता है।

निम्नलिखित उदाहरण कोड एक CAD फ़ाइल को लोड करता है और इसके "Model" लेआउट को PDF में निर्यात करता है। एक बार जब फ़ाइल को PDF में बदल दिया जाता है, तो आप इसे अपने पसंदीदा PDF व्यूअर का उपयोग करके खोल सकते हैं।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **निर्यात में पेन सेटअप के लिए समर्थन**

Aspose.CAD for .NET आपको CAD के निर्यात गुणों में पेन विकल्प जोड़ने की अनुमति देता है। [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) का उपयोग करके हम पेन गुण विकल्प सेट कर सकते हैं।

नीचे निर्दिष्ट आवश्यकताओं को पूरा करने के लिए एक उदाहरण कोड दिया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **CAD Insert Object को विघटित करें**

Aspose.CAD for .NET आपको CAD ऑब्जेक्ट्स को विघटित करने और इन्सर्ट के अंदर अलग-अलग एन्टिटीज़ को प्रोसेस करने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को पूरा करने के लिए एक उदाहरण कोड दिया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **ACAD Proxy Entities के लिए समर्थन**

Aspose.CAD for .NET आपको ACAD_PROXY_ENTITY एन्टिटीज़ को पढ़ने और निर्यात करने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को पूरा करने के लिए एक उदाहरण कोड दिया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **IGES प्रारूप का एकीकरण**

Aspose.CAD for .NET आपको IGES प्रारूप को पढ़ने और निर्यात करने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को पूरा करने के लिए एक उदाहरण कोड दिया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **Mesh मॉडलों के लिए समर्थन**

Aspose.CAD for .NET आपको पॉलीगॉनल प्रतिनिधित्व का उपयोग करने वाले एजेस, वर्टिस, और फेस जैसे मेश मॉडलों को लागू और गिनने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को पूरा करने के लिए एक उदाहरण कोड दिया गया है।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **कस्टम दृष्टिकोण सेट करें**

Aspose.CAD for .NET आपको मॉडल लेआउट के लिए एक कस्टम दृष्टिकोण सेट करने की अनुमति देता है। [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) का उपयोग करके आप एक कस्टम दृष्टिकोण सेट कर सकते हैं। नीचे का कोड उदाहरण दिखाता है कि कैसे एक कस्टम दृष्टिकोण सेट किया जाए।

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
