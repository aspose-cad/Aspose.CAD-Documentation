---
title: 如何在 React 中使用 Aspose.CAD
type: docs
description: "在 React 中使用 Aspose.CAD"
weight: 75
url: /zh/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## 前提条件
- Visual Code
- Node.js

## 将 dgn 图像转换为 png 并在浏览器中显示

在这个示例中，您将创建一个简单的转换程序，它将一个绘图转换并保存为图像。

## 创建 React 项目

1. 确保您还不在 React 工作区目录中。
1. 启动一个新的项目并输入程序名称，或者使用其他程序创建项目，如 Visual Code 或 WebStorm：
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. 从 npm 包安装 Aspose.CAD
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. 创建一个输入类型文件和 img 标签以加载和显示绘图
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. 在 App.tsx 中，我们描述了启动辅助进程、处理和保存图像的过程
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
  console.log("正在加载 WASM...");
  await boot();
  console.log("WASM已加载");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // 加载
          var file = Image.load(array);

          // 保存
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
1. 启动应用程序
{{< highlight plain >}}
npm start
{{< /highlight >}}

## 执行示例

1. 选择文件。<br>
![选择文件](/_assets/javascript-net/react/choose-file.png)<br>
1. 选择任何 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 如果响应成功，文件将显示在屏幕上并提供下载。<br>
![转换图像](/_assets/javascript-net/react/convert-image.png)<br>

## 另见

- [安装 Visual Code](https://code.visualstudio.com/)
- [安装 Node.js](https://nodejs.org/en/)
