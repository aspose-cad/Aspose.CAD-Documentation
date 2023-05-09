---
title: How to use Aspose.CAD in Vue
type: docs
description: "Use Aspose.CAD in Vue."
weight: 75
url: /javascript-net/how-to-use-aspose-cad-in-vue
---

## Prerequisites
- Vue CLI
- Visual Code
- Node.js

## Convert dgn image to png and display in browser

In this example, you create a simple conversion program that converts a drawing and saves it as an image.

## Creating the Vue Project

1. Ensure that you aren't already in an Vue workspace directory.
1. Start a new one and then the name of the program or use other programs to create a project such as Visual Code or WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Install Aspose.CAD from npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Create an input type file and img tags to load and display the drawing
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. In App.vue, we describe the process of starting the helper processes, processing and show the image
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //need for start assembly process
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
      
      console.log("loading WASM...");
      await dotnet.boot();
      console.log("loaded WASM");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // LOAD
              let file = Image.load(array);
              console.log(file);

              // SAVE
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
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Example aspose.cad for Vue.</p>
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
1. Start application
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Execution example

1. Choose file.<br>
![Choose file](choose-file.png)<br>
1. Select any DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG file.
1. If the answer is successful, the file will be displayed on the screen and will offer to download it.<br>
![Convert image](convert-image.png)<br>

## See Also

- [Install Visual Code](https://code.visualstudio.com/)
- [Install Node.js](https://nodejs.org/en/)