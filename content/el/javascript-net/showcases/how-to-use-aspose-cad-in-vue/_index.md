---
title: Πώς να χρησιμοποιήσετε το Aspose.CAD σε Vue
type: docs
description: "Χρησιμοποιήστε το Aspose.CAD σε Vue."
weight: 75
url: /el/javascript-net/showcases/how-to-use-aspose-cad-in-vue/
---

## Προαπαιτούμενα
- Vue CLI
- Visual Code
- Node.js

## Μετατροπή εικόνας dgn σε png και εμφάνιση στον φυλλομετρητή

Σε αυτό το παράδειγμα, δημιουργείτε ένα απλό πρόγραμμα μετατροπής που μετατρέπει ένα σχέδιο και το αποθηκεύει ως εικόνα.

## Δημιουργία του έργου Vue

1. Βεβαιωθείτε ότι δεν βρίσκεστε ήδη σε έναν φάκελο εργασίας Vue.
1. Ξεκινήστε ένα νέο και στη συνέχεια το όνομα του προγράμματος ή χρησιμοποιήστε άλλα προγράμματα για να δημιουργήσετε ένα έργο όπως το Visual Code ή το WebStorm:
{{< highlight plain >}}
vue create vue-example
{{< /highlight >}}
1. Εγκαταστήστε το Aspose.CAD από το npm package
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Δημιουργήστε μια ετικέτα τύπου εισόδου αρχείου και img για να φορτώσετε και να εμφανίσετε το σχέδιο
{{< highlight plain >}}
<input id="file" type="file">
<img id="image" />
{{< /highlight >}}
1. Στο App.vue, περιγράφουμε τη διαδικασία εκκίνησης των βοηθητικών διαδικασιών, επεξεργασίας και εμφάνισης της εικόνας
{{< highlight plain >}}
<script>
import {Drawing, PngOptions} from "aspose-cad";

export default{
  beforeCreate: function () {
    //χρειάζεται για να ξεκινήσει η διαδικασία συναρμολόγησης
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
      
      console.log("φόρτωση WASM...");
      await dotnet.boot();
      console.log("φορτώθηκε WASM");

      document.querySelector('input').addEventListener('change', function() {
            const reader = new FileReader();
            reader.onload = function() {

              let arrayBuffer = this.result;
              let array = new Uint8Array(arrayBuffer);

              // ΦΟΡΤΩΣΗ
              let file = Image.load(array);
              console.log(file);

              // ΑΠΟΘΗΚΕΥΣΗ
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
    <img alt="Λογότυπο Vue" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <p>Παράδειγμα aspose.cad για Vue.</p>
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
1. Ξεκινήστε την εφαρμογή
{{< highlight plain >}}
npm run dev
{{< /highlight >}}

## Παράδειγμα εκτέλεσης

1. Επιλέξτε αρχείο.<br>
![Επιλογή αρχείου](/cad/_assets/javascript-net/vue/choose-file.png)<br>
1. Επιλέξτε οποιοδήποτε αρχείο DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Εάν η απάντηση είναι επιτυχής, το αρχείο θα εμφανιστεί στην οθόνη και θα προτείνει να το κατεβάσετε.<br>
![Μετατροπή εικόνας](/cad/_assets/javascript-net/vue/convert-image.png)<br>

## Δείτε Επίσης

- [Εγκαταστήστε το Visual Code](https://code.visualstudio.com/)
- [Εγκαταστήστε το Node.js](https://nodejs.org/en/)
