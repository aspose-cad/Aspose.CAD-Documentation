---
title: چگونه از Aspose.CAD در React استفاده کنیم
type: docs
description: "استفاده از Aspose.CAD در React"
weight: 75
url: /fa/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## پیش نیازها
- Visual Code
- Node.js

## تبدیل تصویر dgn به png و نمایش در مرورگر

در این مثال، شما یک برنامه تبدیل ساده ایجاد می‌کنید که یک طراحی را تبدیل کرده و به عنوان یک تصویر ذخیره می‌کند.

## ایجاد پروژه React

1. اطمینان حاصل کنید که در دایرکتوری کار فضای React نیستید.
1. یک فضای کاری جدید شروع کنید و سپس نام برنامه را وارد کنید یا از برنامه‌های دیگر برای ایجاد یک پروژه مانند Visual Code یا WebStorm استفاده کنید:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Aspose.CAD را از بسته npm نصب کنید
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. یک نوع ورودی فایل و تگ img ایجاد کنید تا طراحی را بارگذاری و نمایش دهید
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="تبدیل شده" id="image" />
</span>
{{< /highlight >}}
1. در App.tsx، ما فرایند شروع فرآیندهای کمکی، پردازش و ذخیره تصویر را توصیف می‌کنیم
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
          <img alt="تبدیل شده" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("بارگذاری WASM...");
  await boot();
  console.log("WASM بارگذاری شد");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // بارگذاری
          var file = Image.load(array);

          // ذخیره
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
1. شروع برنامه
{{< highlight plain >}}
npm start
{{< /highlight >}}

## مثال اجرا

1. انتخاب فایل.<br>
![انتخاب فایل](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. اگر پاسخ موفقیت‌آمیز باشد، فایل در صفحه نمایش داده می‌شود و پیشنهاد دانلود آن داده می‌شود.<br>
![تبدیل تصویر](/cad/_assets/javascript-net/react/convert-image.png)<br>

## همچنین ببینید

- [نصب Visual Code](https://code.visualstudio.com/)
- [نصب Node.js](https://nodejs.org/en/)
