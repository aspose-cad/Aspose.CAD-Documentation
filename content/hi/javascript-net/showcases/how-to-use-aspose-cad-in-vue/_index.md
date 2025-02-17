---
title: Vue में Aspose.CAD का उपयोग कैसे करें
type: docs
description: "Vue में Aspose.CAD का उपयोग करें।"
weight: 75
url: /hi/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## पूर्वापेक्षाएँ
- Vue CLI
- विजुअल कोड
- Node.js

## DGN छवि को PNG में रूपांतरित करें और ब्राउज़र में प्रदर्शित करें

इस उदाहरण में, आप एक साधारण रूपांतरण कार्यक्रम बनाते हैं जो एक ड्राइंग को रूपांतरित करता है और उसे एक छवि के रूप में सहेजता है।

## Vue प्रोजेक्ट बनाना

1. सुनिश्चित करें कि आप पहले से किसी Vue कार्यक्षेत्र निर्देशिका में नहीं हैं।
1. एक नया प्रारंभ करें और फिर कार्यक्रम का नाम दें या प्रोजेक्ट बनाने के लिए विजुअल कोड या वेबस्टॉर्म जैसे अन्य कार्यक्रमों का उपयोग करें:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. npm पैकेज से Aspose.CAD स्थापित करें
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. ड्राइंग को लोड और प्रदर्शित करने के लिए इनपुट प्रकार फ़ाइल और img टैग बनाएं
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. App.vue में, हम सहायक प्रक्रियाओं को प्रारंभ करने, प्रोसेस करने और छवि प्रदर्शित करने की प्रक्रिया का वर्णन करते हैं
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    // असेंबली प्रक्रिया शुरू करने की आवश्यकता
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
      
      console.log("WASM लोड हो रहा है...");
      await dotnet.boot();
      console.log("WASM लोड हो गया");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // लोड करें
              let file = Image.load(array);
              console.log(file);

              // सहेजें
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
    <img alt="Vue लोगो" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Vue के लिए aspose.cad का उदाहरण।</p>
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
1. अनुप्रयोग प्रारंभ करें
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## कार्यान्वयन उदाहरण

1. फ़ाइल चुनें।<br>
![फ़ाइल चुनें](/_assets/javascript-net/vue/choose-file.png)<br>
1. किसी भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल का चयन करें।
1. यदि उत्तर सफल होता है, तो फ़ाइल स्क्रीन पर प्रदर्शित होगी और डाउनलोड करने की पेशकश करेगी।<br>
![छवि रूपांतरित करें](/_assets/javascript-net/vue/convert-image.png)<br>

## देखें भी

- [विजुअल कोड स्थापित करें](https://code.visualstudio.com/)
- [Node.js स्थापित करें](https://nodejs.org/en/)
