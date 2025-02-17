---
title: SAT/SAB संरचना के साथ संस्थाएँ
type: docs
weight: 40
url: /hi/net/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB संरचना के साथ संस्थाएँ**

कुछ संस्थाएँ अपने संरचनात्मक डेटा को ACIS SAT/SAB प्रारूप में स्टोर करती हैं। ये संस्थाएँ आंशिक रूप से 2D वायरफ्रेम मोड में निर्यात की जा सकती हैं। समर्थित संस्थाओं में शामिल हैं:

* 3DSOLID वस्तुएँ: बॉक्स, गोला, पिरामिड, चॉक, शंकु, सिलेंडर, टोरस, पॉलीसॉलिड
* SURFACE: समतल, निकाली हुई, मोड़ दी गई, स्वेप्ट
* REGION

नीचे निर्यात परिणाम का उदाहरण दिया गया है (बाएँ भाग में DWG फ़ाइल, दाएँ भाग में PDF परिणाम)।

![निष्कासन शंकु और गोलों का](/_assets/guide/coneAndSpheres.png)

ACIS संस्थाओं का निर्यात करने के लिए किसी विशेष विकल्प की आवश्यकता नहीं है। चित्रण के आकार को अनुकूलित करने के लिए, विशेष रूप से जब चित्रण में केवल ACIS संस्थाएँ शामिल हों, cadImage.UpdateSize() फ़ंक्शन का उपयोग करने पर विचार करें ताकि प्रारंभिक चित्रण के आयामों को सटीकता से समायोजित किया जा सके।

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
