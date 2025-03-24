---
title: كيفية استخدام Aspose.CAD في React
type: docs
description: "استخدام Aspose.CAD في React"
weight: 75
url: /ar/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## المتطلبات الأساسية
- كود مرئي
- Node.js

## تحويل صورة dgn إلى png وعرضها في المتصفح

في هذا المثال، تقوم بإنشاء برنامج تحويل بسيط يقوم بتحويل رسم وحفظه كصورة.

## إنشاء مشروع React

1. تأكد من أنك لست بالفعل في دليل مساحة عمل React.
1. ابدأ واحدة جديدة ثم أضف اسم البرنامج أو استخدم برامج أخرى لإنشاء مشروع مثل كود مرئي أو WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. قم بتثبيت Aspose.CAD من حزمة npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. أنشئ علامة إدخال من نوع ملف وعلامات img لتحميل وعرض الرسم
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. في App.tsx، نقوم بوصف عملية بدء العمليات المساعدة، المعالجة وحفظ الصورة
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("جارٍ تحميل WASM...");
  await boot();
  console.log("تم تحميل WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // تحميل
          var file = Image.load(array);

          // حفظ
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. ابدأ التطبيق
{{< highlight plain >}}
npm start
{{< /highlight >}}

## مثال على التنفيذ

1. اختر ملفًا.<br>
![اختر ملف](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. اختر أي ملف من DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG.
1. إذا كانت الإجابة ناجحة، سيتم عرض الملف على الشاشة وسيتم عرض خيار تنزيله.<br>
![تحويل الصورة](/cad/_assets/javascript-net/react/convert-image.png)<br>

## راجع أيضًا

- [تثبيت كود مرئي](https://code.visualstudio.com/)
- [تثبيت Node.js](https://nodejs.org/en/)
