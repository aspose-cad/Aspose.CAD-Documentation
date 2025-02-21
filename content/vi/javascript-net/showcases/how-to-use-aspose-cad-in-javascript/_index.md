---
title: Cách sử dụng Aspose.CAD trong JavaScript
type: docs
description: "sử dụng Aspose.CAD trong JavaScript."
weight: 73
url: /vi/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## Điều kiện tiên quyết
- Visual Code + Live Server
- Node.js

## Chuyển đổi hình ảnh dgn thành png và hiển thị trong trình duyệt

Trong ví dụ này, bạn tạo một chương trình chuyển đổi đơn giản có thể chuyển đổi một bản vẽ và lưu nó dưới dạng hình ảnh.

## Tạo JavaScript

1. Tạo package.json với các phụ thuộc aspose-cad
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
1. Tạo index.html
{{< highlight plain >}}
<!DOCTYPE html>
Mở console (Ctrl+Shift+I) để xem đầu ra.

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
          
		  //LẤY ĐỊNH DẠNG TẬP TIN
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // TẢI
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // LƯU
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

1. Cài đặt các gói bằng lệnh npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Khởi động ứng dụng với [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) hoặc yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Ví dụ thực thi

1. Chọn tệp.<br>
![Chọn tệp](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nếu phản hồi thành công, tệp sẽ được hiển thị trên màn hình và sẽ đề nghị tải xuống.<br>
![Chuyển đổi hình ảnh](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## Xem thêm

- [Cài đặt Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Cài đặt Node.js](https://nodejs.org/en/)
