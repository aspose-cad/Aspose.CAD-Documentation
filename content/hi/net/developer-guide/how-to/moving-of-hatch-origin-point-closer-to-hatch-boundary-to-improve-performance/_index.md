---
title: हैच उत्पत्ति बिंदु को हैच सीमा के करीब लाने के लिए प्रदर्शन में सुधार
type: docs
weight: 41
url: /hi/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **कैसे हैच उत्पत्ति बिंदु को हैच सीमा के करीब लाया जाए ताकि प्रदर्शन में सुधार हो**

**समस्या:** हैच उत्पत्ति बिंदु को हैच सीमा के करीब लाने के लिए प्रदर्शन में सुधार कैसे करें (CADNET-1340)।

**टिप्स:** ऐसा करने के लिए, ड्राइंग से CadHatch इकाइयां प्राप्त करें, आवश्यक बिंदुओं को Point2D के साथ सेट करें, दूरी की गणना करें और CadHatchPatternData में X और Y के लिए LineBasePoint सेट करें।

**उदाहरण:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
