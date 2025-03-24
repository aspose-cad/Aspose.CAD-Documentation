---
title: 如何在JavaScript中使用Aspose.CAD
type: docs
description: "在JavaScript中使用Aspose.CAD。"
weight: 73
url: /zh/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## 前提条件
- Visual Code + Live Server
- Node.js

## 将dgn图像转换为png并在浏览器中显示

在此示例中，您将创建一个简单的转换程序，该程序将图纸转换并保存为图像。

## 创建JavaScript

1. 创建带有aspose-cad依赖项的package.json
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
1. 创建index.html
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

1. 使用npm命令安装软件包
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. 使用[Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)或yarn启动应用程序
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## 执行示例

1. 选择文件。<br>
![选择文件](/cad/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. 选择任何DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG文件。
1. 如果响应成功，文件将在屏幕上显示并提供下载。<br>
![转换图像](/cad/_assets/javascript-net/javascript-net/convert-image.png)<br>
## 另见

- [安装Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [安装Node.js](https://nodejs.org/en/)
