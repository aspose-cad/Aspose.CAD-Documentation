---
title: CAD का निर्यात
type: docs
weight: 40
url: /hi/java/developer-guide/exporting-cad/
---

## **3D AutoCAD छवियों को PDF में निर्यात करें**
Aspose.CAD आपको 3D AutoCAD छवियों को PDF में निर्यात करने की अनुमति देता है। कृपया निर्दिष्ट करें कि आप **ImageOptions.CadRasterizationOptions** में **TypeOfEntities.Entities3D** का उपयोग करना चाहते हैं ताकि आप 3D संस्थाओं को निर्यात कर सकें।
निम्नलिखित नमूना कोड एक AutoCAD 3D फ़ाइल को लोड करता है और इसे PDF में निर्यात करता है। एक बार जब फ़ाइल को PDF में परिवर्तित किया जाता है, तो आप इसे अपने पसंदीदा PDF प्रदर्शनकर्ता का उपयोग करके खोल सकते हैं।

नीचे का कोड नमूना दिखाता है कि 3D AutoCAD छवियों को PDF में कैसे निर्यात किया जाए।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-Export3DAutoCADImagesToPDF-.java" >}}

## **CAD लेआउट को PDF में निर्यात करना**
Aspose.CAD for Java आपको CAD लेआउट को PDF में निर्यात करने की अनुमति देता है। **CadImage** क्लास की **save** विधि का उपयोग करके लेआउट(ओं) को PDF प्रारूप में निर्यात किया जा सकता है।
निम्नलिखित नमूना कोड एक CAD फ़ाइल को लोड करता है और उसके "मॉडल" लेआउट को PDF में निर्यात करता है। एक बार जब फ़ाइल को PDF में परिवर्तित किया जाता है, तो आप इसे अपने पसंदीदा PDF प्रदर्शनकर्ता का उपयोग करके खोल सकते हैं।

यहाँ नमूना कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportCADLayoutsToPDF-.java" >}}

## **निर्यात में पेन की स्थापना के लिए सहायता**
Aspose.CAD for Java आपको CAD के निर्यात गुणों में पेन विकल्प जोड़ने की अनुमति देता है। रास्टराइजेशन विकल्पों का उपयोग करके हम पेन गुण विकल्प सेट कर सकते हैं।

नीचे निर्दिष्ट आवश्यकताओं को प्राप्त करने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}

## **Cad Insert वस्तु को विघटन करना**
Aspose.CAD for Java आपको cad वस्तुओं को विघटित करने और सम्मिलन के अंदर अलग संस्थाओं को संसाधित करने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को प्राप्त करने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **ACAD प्रॉक्सी संस्थाओं के लिए सहायता**
Aspose.CAD for Java आपको ACAD_PROXY_ENTITY संस्थाओं को पढ़ने और निर्यात करने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को प्राप्त करने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-PenSupportInExport-PenSupportInExport.java" >}}

## **IGES प्रारूप को एकीकृत करना**
Aspose.CAD for Java आपको IGES प्रारूप को पढ़ने और निर्यात करने की अनुमति देता है। नीचे निर्दिष्ट आवश्यकताओं को प्राप्त करने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-IGESDrawings-ExportIGEStoPDF-ExportIGEStoPDF.java" >}}

## **Mesh मॉडल के लिए सहायता**
Aspose.CAD for Java आपको धारी, शीर्षांक और चेहरे जैसे मैश मॉडल को कार्यान्वित करने और उनकी गिनती करने की अनुमति देता है जो बहुपृष्ठीय प्रतिनिधित्व का उपयोग करते हैं। नीचे निर्दिष्ट आवश्यकताओं को प्राप्त करने के लिए नमूना कोड है।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-MeshSupportForDWG-MeshSupportForDWG.java" >}}

## **कस्टम दृष्टिकोण सेट करें**
Aspose.CAD for Java आपको मॉडल लेआउट के लिए कस्टम दृष्टिकोण सेट करने की अनुमति देता है। **vectorRasterizationOptions** का उपयोग करके आप कस्टम दृष्टिकोण सेट कर सकते हैं। नीचे दिया गया कोड नमूना दिखाता है कि कस्टम दृष्टिकोण कैसे सेट करें।

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-FreePointOfView-FreePointOfView.java" >}}
