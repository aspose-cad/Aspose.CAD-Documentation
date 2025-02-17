---
title: पाठ, हैच और आर्क के लिए गुणवत्ता विकल्प स्थापित करना
type: docs
weight: 46
url: /hi/net/developer-guide/how-to/setting-up-quality-options-for-the-text-hatches-and-arcs/
---

## **पाठ, हैच और आर्क के लिए गुणवत्ता विकल्प स्थापित करने का तरीका**

**समस्या:** पाठ, हैच और आर्क के लिए गुणवत्ता विकल्प स्थापित करने का तरीका (CADNET-986)।

**टिप्स:** पाठ, स्ट्रोक्स और आर्क के लिए गुणवत्ता पैरामीटर को समायोजित करने के लिए, ये समायोजन rasterizationOptions वर्ग में किए जाते हैं (rasterizationOptions.Quality.Text, rasterizationOptions.Quality.Hatch, rasterizationOptions.Quality.Arc, rasterizationOptions.Quality.ObjectsPrecision)
.

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "setting-up-quality-options-for-the-text-hatches-and-arcs.cs" >}}
