---
title: How to use Aspose.CAD in React
type: docs
description: "Use Aspose.CAD in React"
weight: 75
url: /javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Prerequisites
- Visual Code
- Node.js

## Convert dgn image to png and display in browser

In this example, you create a simple conversion program that converts a drawing and saves it as an image.

## Creating the React Project

1. Ensure that you aren't already in an React workspace directory.
1. Start a new one and then the name of the program or use other programs to create a project such as Visual Code or WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Install Aspose.CAD from npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Create an input type file and img tags to load and display the drawing
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. In App.tsx, we describe the process of starting the helper processes, processing and saving the image
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
  console.log("loading WASM...");
  await boot();
  console.log("loaded WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // LOAD
          var file = Image.load(array);

          // SAVE
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
1. Start application
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Execution example

1. Choose file.<br>
![Choose file](/_assets/javascript-net/react/choose-file.png)<br>
1. Select any DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG file.
1. If the answer is successful, the file will be displayed on the screen and will offer to download it.<br>
![Convert image](/_assets/javascript-net/react/convert-image.png)<br>

## See Also

- [Install Visual Code](https://code.visualstudio.com/)
- [Install Node.js](https://nodejs.org/en/)