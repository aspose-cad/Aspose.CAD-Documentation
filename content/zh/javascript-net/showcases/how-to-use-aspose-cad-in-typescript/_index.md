---
title: 如何在 TypeScript 中使用 Aspose.CAD
type: docs
description: "在 TypeScript 中使用 Aspose.CAD."
weight: 74
url: /zh/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## 先决条件
- Visual Code + Live Server
- Node.js

## 将 dgn 图像转换为 png 并在浏览器中显示

在这个例子中，您创建一个简单的转换程序，将图纸转换并保存为图像。

## 创建 JavaScript

1. 在项目文件夹中创建 package.json
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. 修改 package.json，添加 aspose-cad 依赖
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
1. 创建 index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //获取文件格式
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // 加载
    var file = Image.load(array);
    console.log(file);
    
    // 保存
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. 使用 npm 命令创建 index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. 创建 index.html
{{< highlight plain >}}
<!DOCTYPE html>
打开控制台 (Ctrl+Shift+I) 以查看输出。

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
	<input id="file" type="file">
	<img id="image" />
</body>

<script>
window.onload = async function () {
	document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
		  //获取文件格式
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // 加载
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // 保存
		  exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
		  exportedFilePromise.then(exportedFile => {
			console.log(exportedFile);
			
			var urlCreator = window.URL || window.webkitURL;
			var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
		  });
      }
	  
      reader.readAsArrayBuffer(this.files[0]);
    }, 
	false);
};
</script>
{{< /highlight >}}

1. 使用 npm 命令安装软件包
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. 使用 [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) 或 yarn 启动应用程序
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## 执行示例

1. 选择文件。<br>
![选择文件](/_assets/javascript-net/typescript/choose-file.png)<br>
1. 选择任何 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 如果响应成功，文件将显示在屏幕上，并提供下载。<br>
![转换图像](/_assets/javascript-net/typescript/convert-image.png)<br>
## 另请参阅

- [安装 Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [安装 Node.js](https://nodejs.org/en/)
