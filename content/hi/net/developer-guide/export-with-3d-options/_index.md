---
title: 3D विकल्पों के साथ निर्यात
type: docs
weight: 40
url: /hi/net/developer-guide/export-with-3d-options/
---

## **3D विकल्पों के साथ निर्यात**

कुछ विकल्पों को PDF/रास्टर में संबंधित FBX, OBJ, STL प्रारूपों से 3D मॉडल निर्यात करने के लिए पेश किया गया था।

यहां विभिन्न दृष्टिकोणों से 3D दृश्य के उदाहरण दिए गए हैं:

![Figures](/_assets/guide/3d/fig1.png)

![Figures from other points of view](/_assets/guide/3d/fig2.png)

ObserverPoint प्रॉपर्टी को निर्दिष्ट कोणों के चारों ओर धुरी के अनुसार 3D दृश्य को घुमाने की अनुमति देती है। यह उदाहरण कुछ मनमाने घूर्णन कोणों का उपयोग करके कोड और निर्यात परिणाम दिखाता है।

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}

![Export with rotation](/_assets/guide/3d/fig3.png)

ObserverAngle को ObserverPoint = new ObserverPoint(5, 60, 0) में बदलने से दृश्य को घुमाने की अनुमति मिलती है।

![Export with changed rotation](/_assets/guide/3d/fig4.png)

दूसरी RenderMode3D प्रॉपर्टी निर्यात परिणाम को प्रस्तुत करने के तरीके को निर्दिष्ट करने की अनुमति देती है। यहां 3 मोड हैं: ठोस (डिफ़ॉल्ट), तारफ्रेम, और ठोस किनारों के साथ।

नीचे दिया गया उदाहरण गोलाकार वस्तु के लिए तारफ्रेम मॉडल बनाने की अनुमति देता है।

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Wireframe mode](/_assets/guide/3d/fig5.png)

नीचे दिया गया उदाहरण ठोस और ठोस किनारों के साथ मोड के बीच का अंतर दिखाता है।

![Solid mode](/_assets/guide/3d/fig6.png)
![Solid with edge mode](/_assets/guide/3d/fig7.png)
