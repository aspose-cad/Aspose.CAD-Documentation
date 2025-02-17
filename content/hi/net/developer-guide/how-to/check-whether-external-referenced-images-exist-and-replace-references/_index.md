---
title: बाहरी संदर्भित छवियों के अस्तित्व की जांच करना और संदर्भों को बदलना
type: docs
weight: 22
url: /hi/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **ऑब्जेक्ट्स पर हाइपरलिंक्स संपादित करने का तरीका**

**समस्या:** बाहरी संदर्भित छवियों के अस्तित्व की जांच करना और संदर्भों को बदलना (CADNET-8088)।

**सुझाव:** ऐसा करने के लिए, ड्राइंग वस्तुओं से CadObjectTypeName.IMAGEDEF के प्रकार की एक इकाई प्राप्त करें और जांचने के लिए CadRasterImageDef का उपयोग करें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
