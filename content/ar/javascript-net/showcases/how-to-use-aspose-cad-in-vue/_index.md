---
title: كيفية استخدام Aspose.CAD في Vue
type: docs
description: "استخدام Aspose.CAD في Vue."
weight: 75
url: /ar/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## المتطلبات الأساسية
- Vue CLI
- Visual Code
- Node.js

## تحويل صورة dgn إلى png وعرضها في المتصفح

في هذا المثال، ستقوم بإنشاء برنامج تحويل بسيط يقوم بتحويل رسم وحفظه كصورة.

## إنشاء مشروع Vue

1. تأكد من أنك لست في دليل مساحة عمل Vue بالفعل.
1. ابدأ واحدة جديدة ثم اذكر اسم البرنامج أو استخدم برامج أخرى لإنشاء مشروع مثل Visual Code أو WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. قم بتثبيت Aspose.CAD من حزمة npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. أنشئ علامة ملف من نوع input وعلامات img لتحميل وعرض الرسم
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. في App.vue، نصف عملية بدء العمليات المساعدة، ومعالجة الصورة وعرضها
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // الحاجة لبدء عملية التجميع
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
      
      console.log("جارٍ تحميل WASM...");
      await dotnet.boot();
      console.log("تم تحميل WASM");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // تحميل
              let file = Image.load(array);
              console.log(file);

              // حفظ
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
    <img alt="شعار Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>مثال على aspose.cad لـ Vue.</p>
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
1. بدء التطبيق
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## مثال على التنفيذ

1. اختر ملفًا.<br>
![اختر ملف](/_assets/javascript-net/vue/choose-file.png)<br>
1. حدد أي ملف DXF أو DWG أو DGN أو DWF أو DWFX أو IFC أو STL أو DWT أو IGES أو PLT أو CF2 أو OBJ أو HPGL أو IGS أو PCL أو FBX أو PDF أو SVG.
1. إذا كانت النتيجة ناجحة، سيتم عرض الملف على الشاشة وسيتم عرض خيار تحميله.<br>
![تحويل الصورة](/_assets/javascript-net/vue/convert-image.png)<br>

## راجع أيضًا

- [تثبيت Visual Code](https://code.visualstudio.com/)
- [تثبيت Node.js](https://nodejs.org/en/)
