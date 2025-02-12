---
title: چگونه از Aspose.CAD در Vue استفاده کنیم
type: docs
description: "استفاده از Aspose.CAD در Vue."
weight: 75
url: /fa/javascript-net/how-to-use-aspose-cad-in-vue
---

## الزامات اولیه
- Vue CLI
- Visual Code
- Node.js

## تبدیل تصویر dgn به png و نمایش در مرورگر

در این مثال، شما یک برنامه تبدیل ساده ایجاد می‌کنید که یک نقاشی را تبدیل کرده و آن را به عنوان یک تصویر ذخیره می‌کند.

## ایجاد پروژه Vue

1. اطمینان حاصل کنید که در یک دایرکتوری فضای کاری Vue نیستید.
1. یک دایرکتوری جدید شروع کنید و سپس نام برنامه را وارد کنید یا از برنامه‌های دیگر مانند Visual Code یا WebStorm برای ایجاد یک پروژه استفاده کنید:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Aspose.CAD را از بسته npm نصب کنید
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. یک تگ فایل ورودی و تگ img برای بارگذاری و نمایش نقاشی ایجاد کنید
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. در App.vue، ما روند شروع فرایندهای کمکی، پردازش و نمایش تصویر را توصیف می‌کنیم
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // نیاز به شروع فرایند جمع‌آوری
    let recaptchaScript = document.createElement('script')
    recaptchaScript.setAttribute('src', '/node_modules/aspose-cad/dotnet.js')
    document.head.appendChild(recaptchaScript)

    let dotnet;
  },
  mounted() {
    window.addEventListener('load', this.onWindowLoad)
  },
  methods: {
    async onWindowLoad() {
      
      console.log("در حال بارگذاری WASM...");
      await dotnet.boot();
      console.log("WASM بارگذاری شد");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // بارگذاری
              let file = Image.load(array);
              console.log(file);

              // ذخیره‌سازی
              let exportedFilePromise = Image.save(array, new PngOptions());
              exportedFilePromise.then(exportedFile => {
                console.log(exportedFile);

                let urlCreator = window.URL || window.webkitURL;
                let blob = new Blob([exportedFile], { type: 'application/octet-stream' });
                let imageUrl = urlCreator.createObjectURL(blob);
                document.querySelector("#image").src = imageUrl;
              });
            }

            reader.readAsArrayBuffer(this.files[0]);
          },
          false);
    },
  },
}
</script>

<template>
  <header>
    <img alt="آرم Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>مثال aspose.cad برای Vue.</p>
  </header>

  <main>
    <input id="file" type="file">
    <br/>
    <img id="image" />
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
}
main{
  text-align: center;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }


  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
{{< /highlight >}}
1. اجرای برنامه
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## مثال اجرای

1. فایل را انتخاب کنید.<br>
![انتخاب فایل](/_assets/javascript-net/vue/choose-file.png)<br>
1. هر فایل DXF، DWG، DGN، DWF، DWFX، IFC، STL، DWT، IGES، PLT، CF2، OBJ، HPGL، IGS، PCL، FBX، PDF، SVG را انتخاب کنید.
1. اگر پاسخ موفقیت‌آمیز باشد، فایل روی صفحه نمایش داده شده و پیشنهاد می‌دهد که آن را دانلود کنید.<br>
![تبدیل تصویر](/_assets/javascript-net/vue/convert-image.png)<br>

## همچنین ببینید

- [نصب Visual Code](https://code.visualstudio.com/)
- [نصب Node.js](https://nodejs.org/en/)
