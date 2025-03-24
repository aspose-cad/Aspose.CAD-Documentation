---
title: 3D विकल्पों के साथ निर्यात
type: docs
weight: 40
url: /hi/java/developer-guide/export-with-3d-options/
---

## **3D विकल्पों के साथ निर्यात**

PDF/रास्टर में संबंधित FBX, OBJ, STL प्रारूपों से 3D मॉडल को निर्यात करने के लिए कुछ विकल्प पेश किए गए हैं।

यहां विभिन्न दृष्टिकोणों से 3D दृश्य के उदाहरण दिए गए हैं:

![Figures](/cad/_assets/guide/3d/fig1.png)

![अन्य दृष्टिकोणों से चित्र](/cad/_assets/guide/3d/fig2.png)

ObserverPoint प्रॉपर्टी को एक्सिस के चारों ओर निर्दिष्ट कोणों के अनुसार 3D दृश्य को घुमाने की अनुमति देती है। यह उदाहरण कुछ मनमाने घूर्णन कोणों का उपयोग करते हुए कोड और निर्यात परिणाम को दिखाता है।

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![घुमाव के साथ निर्यात](/cad/_assets/guide/3d/fig3.png)

ObserverAngle को ObserverPoint = new ObserverPoint(5, 60, 0) में बदलने से दृश्य को घुमाने की अनुमति मिलती है।

![बदले हुए घुमाव के साथ निर्यात](/cad/_assets/guide/3d/fig4.png)

अन्य RenderMode3D प्रॉपर्टी को यह निर्दिष्ट करने की अनुमति देती है कि निर्यात परिणाम को कैसे प्रस्तुत किया जाना चाहिए। 3 मोड हैं: ठोस (डिफ़ॉल्ट), वायर्डफ़्रेम, और ठोस किनारों के साथ।

नीचे का उदाहरण गोलाकार वस्तु के लिए वायर्डफ़्रेम मॉडल बनाने की अनुमति देता है।

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![वायर्डफ़्रेम मोड](/cad/_assets/guide/3d/fig5.png)

नीचे का उदाहरण ठोस और ठोस किनारों के साथ मोड के बीच का अंतर दिखाता है।

![ठोस मोड](/cad/_assets/guide/3d/fig6.png)
![किनारे के साथ ठोस मोड](/cad/_assets/guide/3d/fig7.png)
