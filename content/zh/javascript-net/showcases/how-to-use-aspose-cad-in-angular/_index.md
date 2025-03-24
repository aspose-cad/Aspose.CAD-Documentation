---
title: 如何在 Angular 中使用 Aspose.CAD
type: docs
description: "在 Angular 中使用 Aspose.CAD。"
weight: 71
url: /zh/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## 先决条件
- Angular CLI
- Visual Code
- Node.js

## 将 dgn 图像转换为 png 并在浏览器中显示

在此示例中，您将创建一个简单的转换程序，该程序将绘图转换并保存为图像。

## 创建 Angular 项目

1. 确保您不在 Angular 工作区目录中。
1. 启动一个新项目，然后输入程序名称，或使用其他程序创建项目，如 Visual Code 或 WebStorm：
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. 从 npm 包安装 Aspose.CAD
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. 打开 angular.json 文件，在 script 字段中添加一个条目，该脚本会随着项目的加载而启动，处理文件时需要它
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. 在 app.component.html 中，创建一个类型为文件的输入框和 img 标签以加载并显示绘图
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. 在 app.component.ts 中，描述启动助手进程、处理和保存图像的过程
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//需要启动 dotnet 进程
declare let dotnet: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-example';

  imageUrl: any;
  imgFile: Uint8Array | null | undefined;

  constructor(private sanitizer: DomSanitizer) {
  }

  // @ts-ignore
  async ngOnInit() {
    console.log("aspose-cad WASM 正在加载...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM 已加载");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //加载图像
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //将图像保存为 png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //为转换后的图像创建 src
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //下载 png 图像
      let url = window.URL.createObjectURL(blob);
      let a = document.createElement('a');
      document.body.appendChild(a);
      a.setAttribute('style', 'display: none');
      a.href = url;
      a.download = "file.png";
      a.click();
      window.URL.revokeObjectURL(url);
      a.remove();

    });
  }
}
{{< /highlight >}}
1. 启动应用程序
{{< highlight plain >}}
npm start
//或
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
ng serve 命令：

- 构建应用程序
- 启动开发服务器
- 监视源文件
- 在您进行更改时重新构建应用程序

--open 标志将在 http://localhost:4200 中打开浏览器。
{{% /alert %}}

## 执行示例

1. 选择文件。<br>
![选择文件](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. 选择任意 DXF、DWG、DGN、DWF、DWFX、IFC、STL、DWT、IGES、PLT、CF2、OBJ、HPGL、IGS、PCL、FBX、PDF、SVG 文件。
1. 如果响应成功，文件将在屏幕上显示并提供下载选项。<br>
![转换图像](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## 另见

- [安装 Angular CLI](https://angular.io/guide/setup-local/)
- [安装 Visual Code](https://code.visualstudio.com/)
- [安装 Node.js](https://nodejs.org/en/)
