---
title: SAT/SAB संरचना के साथ संस्थाएँ
type: docs
weight: 40
url: /hi/java/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB संरचना के साथ संस्थाएँ**

कुछ संस्थाएँ अपनी संरचनात्मक डेटा को ACIS SAT/SAB प्रारूप में संग्रहित करती हैं। इन संस्थाओं को 2D वायरफ्रेम मोड में आंशिक रूप से निर्यात किया जा सकता है। समर्थित संस्थाओं में शामिल हैं:

* 3DSOLID वस्तुएँ: बॉक्स, गोल, पिरामिड, वेज, शंकु, सिलेंडर, टॉरस, पॉलिसॉलिड
* SURFACE: प्लानर, एक्सट्रूडेड, रिवोल्व्ड, स्वीप्ड
* REGION

नीचे निर्यात परिणाम का उदाहरण दिया गया है (DWG फ़ाइल बाएं भाग में, PDF परिणाम दाएं).

![Export of cone and spheres](/_assets/guide/coneAndSpheres.png)

ACIS संस्थाओं का निर्यात करने के लिए किसी विशेष विकल्प की आवश्यकता नहीं होती है। ड्राइंग के आकार का अनुकूलन करने के लिए, विशेष रूप से जब ड्राइंग पूरी तरह से ACIS संस्थाओं से बनी हो, cadImage.updateSize() फ़ंक्शन का उपयोग करें ताकि प्रारंभिक ड्राइंग आयामों को सटीकता से समायोजित किया जा सके।

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
