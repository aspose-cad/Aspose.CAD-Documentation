---
title: 如何在 Vue 中使用 Aspose.CAD
type: docs
description: "在 Vue 中使用 Aspose.CAD。"
weight: 75
url: /zh/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## 先决条件
- Vue CLI
- Visual Code
- Node.js

## 将 dgn 图像转换为 png 并在浏览器中显示

在这个例子中，您将创建一个简单的转换程序，将绘图转换并保存为图像。

## 创建 Vue 项目

1. 确保您不在 Vue 工作区目录中。
1. 启动一个新的项目，然后输入程序名称，或者使用其他程序创建项目，例如 Visual Code 或 WebStorm：
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. 从 npm 包安装 Aspose.CAD
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. 创建一个输入类型文件和 img 标签以加载和显示绘图
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. 在 App.vue 中，我们描述了启动辅助进程、处理和显示图像的过程
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //需要启动组装过程
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
      
      console.log("加载 WASM...");
      await dotnet.boot();
      console.log("WASM 已加载");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // 加载
              let file = Image.load(array);
              console.log(file);

              // 保存
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
    <p>Vue 的 aspose.cad 示例。</p>
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
1. 启动应用程序
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## 执行示例

1. 选择文件。<br>
![选择文件](/_assets/javascript-net/vue/choose-file.png)<br>
1. 选择任何 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 如果回答成功，文件将在屏幕上显示并提供下载选项。<br>
![转换图像](/_assets/javascript-net/vue/convert-image.png)<br>

## 另见

- [安装 Visual Code](https://code.visualstudio.com/)
- [安装 Node.js](https://nodejs.org/en/)
