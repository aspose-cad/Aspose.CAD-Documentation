---
title: Cara Menjalankan Gambar Docker Aspose.CAD di Azure Function
type: docs
description: "Jalankan gambar Docker Aspose.CAD di Azure Function."
weight: 73
url: /id/net/showcases/how-to-run-aspose-cad-docker-in-azure-function/
---

## Prasyarat
- Docker harus diinstal di sistem Anda. Untuk informasi tentang cara menginstal Docker di Windows atau Mac, lihat tautan di bagian "Lihat Juga".
- Visual Studio 2022.
- SDK NET 6 digunakan dalam contoh ini.
- Postman

## Azure Function

Dalam contoh ini, Anda membuat fungsi konversi sederhana yang mengonversi file CAD dan menyimpannya sebagai gambar. Aplikasi kemudian dapat dibangun dalam Docker dan dijalankan di Azure Function.

## Membuat Azure Function

Untuk membuat program Azure Function, ikuti langkah-langkah di bawah ini:
1. Setelah Docker diinstal, pastikan bahwa itu menggunakan Kontainer Linux (default). Jika perlu, pilih opsi Alihkan ke kontainer Linux dari menu Docker Desktops.
1. Di Visual Studio, buat Azure Function NET 6.<br>
![Dialog proyek Azure Function NET 6](/cad/_assets/showcases/azure/Create-project.png)<br>
1. Informasi tambahan.<br>
![Dialog proyek Azure Function NET 6](/cad/_assets/showcases/azure/Additional-information.png)<br>
1. Instal versi terbaru Aspose.CAD dari NuGet.<br>
![Aspose.CAD di NuGet](/cad/_assets/showcases/azure/NuGet.png)<br>
1. Karena aplikasi akan dijalankan di Linux, Anda mungkin perlu menginstal font tambahan. Anda dapat memilih ttf-mscorefonts-installer.
1. Ketika semua dependensi yang diperlukan ditambahkan, tulis program sederhana yang membuat elips dan menyimpannya sebagai gambar:<br>

{{< highlight plain >}}
public static class Function1
{
    [FunctionName("convert")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Fungsi trigger HTTP C# memproses permintaan.");
        try
        {
            using (var image = (CadImage)Image.Load(req.Body))
            {
                var ms = new MemoryStream();
                image.Save(ms, new PngOptions());

                ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);

                return new FileContentResult(ms.ToArray(), "application/octet-stream")
                {
                    FileDownloadName = "Export.png"
                };
            }
        }
        catch (Exception e)
        {
            return new OkObjectResult(e.Message);
        }
    }
}
{{< /highlight >}}

### Mengonfigurasi Dockerfile

Langkah selanjutnya adalah membuat dan mengonfigurasi Dockerfile di folder proyek root.

1. Buat Dockerfile dan tempatkan di samping file solusi aplikasi Anda. Pertahankan nama file ini tanpa ekstensi (default).
![Folder proyek root](/cad/_assets/showcases/azure/root-folder.png)<br>
1. Dalam Dockerfile, tentukan:

{{< highlight plain >}}
FROM mcr.microsoft.com/azure-functions/dotnet:4 AS base
WORKDIR /home/site/wwwroot
RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aspose.CAD.Function/Aspose.CAD.Function.csproj", "Aspose.CAD.Function/"]
RUN dotnet restore "Aspose.CAD.Function/Aspose.CAD.Function.csproj"
COPY . .
WORKDIR "/src/Aspose.CAD.Function"
RUN dotnet build "Aspose.CAD.Function.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aspose.CAD.Function.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
{{< /highlight >}}

Di atas adalah Dockerfile sederhana, yang berisi instruksi berikut:

- Gambar SDK yang akan digunakan. Di sini adalah gambar Net 6. Docker akan mengunduhnya ketika build dijalankan. Versi SDK ditentukan sebagai tag.
- Setelah itu, Anda mungkin perlu menginstal font karena gambar SDK tidak memiliki banyak font. Juga, Anda dapat menggunakan font lokal yang disalin ke gambar docker.
- Direktori kerja, yang ditentukan di baris berikutnya.
- Perintah untuk menyalin semua ke kontainer, menerbitkan aplikasi, dan menentukan titik masuk.

## Docker Hub
1. Masuk ke Docker Hub
1. Buat Repository publik

## Membangun dan Menjalankan Aplikasi di Docker

Sekarang aplikasi dapat dibangun dan dijalankan di Docker. Buka command prompt favorit Anda, ubah direktori ke folder dengan aplikasi (folder tempat file solusi dan Dockerfile ditempatkan) dan jalankan perintah berikut:

{{< highlight plain >}}
//contoh
docker build -t <nama pengguna>/<nama repository> .

docker build -t pengguna/asposefunction .
{{< /highlight >}}

Waktu pertama Anda menjalankan perintah ini, mungkin akan memakan waktu lebih lama karena Docker perlu mengunduh gambar yang diperlukan. Setelah perintah sebelumnya selesai, jalankan perintah berikut untuk mendorong gambar ke docker hub:

{{< highlight plain >}}
//contoh
docker push <nama pengguna>/<nama repository>:tagname

docker push pengguna/asposefunction:latest
{{< /highlight >}}

## Azure

1. Masuk ke Azure.
1. Pilih layanan Azure.
1. Pilih Aplikasi Function dan buat fungsi.<br>
![Tombol buat fungsi Azure](/cad/_assets/showcases/azure/create-function.png)<br>
1. Ulangi pengaturan dasar seperti di gambar di bawah.<br>
![Pengaturan fungsi buat Azure](/cad/_assets/showcases/azure/create-function-setting.png)<br>
1. Klik 'Tinjau + buat' -> Buat.
1. Tunggu hingga penyebaran selesai.
1. Klik tombol 'Pergi ke sumber daya'.<br>
![Tombol sumber daya](/cad/_assets/showcases/azure/go-to-resource.png)<br>
1. Hentikan fungsi aspose-cad-docker-example.<br>
![Hentikan kontainer](/cad/_assets/showcases/azure/stop-container.png)<br>
1. Pergi ke menu pusat penyebaran dan buat pengaturan yang sesuai.<br>
![Pusat penyebaran](/cad/_assets/showcases/azure/deployment-center.png)<br>
1. Simpan pengaturan
1. Salin URL Webhook dari pengaturan pusat penyebaran.<br>
![URL Webhook](/cad/_assets/showcases/azure/webhook-url.png)<br>
1. Pergi ke Docker Hub, pilih repository Anda dan pilih webhooks.
1. Tempelkan 'URL Webhook' dari Azure ke URL webhook Docker Hub dan atur namanya.<br>
![Pengaturan Webhook di docker](/cad/_assets/showcases/azure/webhook.png)<br>
1. Klik tombol buat.
1. Kembali ke overview fungsi azure dan mulai kontainer.<br>
![Menu overview](/cad/_assets/showcases/azure/overview.png)<br>

## Contoh Eksekusi

1. Pengaturan Postman.<br>
![Pengaturan Postman](/cad/_assets/showcases/azure/postman-settings.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klik tombol kirim.

{{% alert color="primary" %}} 
Jika jawaban berhasil, klik Simpan ke file dan Anda akan menerima file yang dikonversi dalam format png
{{% /alert %}}

## Contoh Lainnya

Untuk lebih banyak contoh tentang bagaimana Anda dapat menggunakan Aspose.CAD di Docker, lihat [contoh](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lihat Juga

- [Instal Docker Desktop di Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instal Docker Desktop di Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Alihkan ke kontainer Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opsi
- Informasi tambahan tentang [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
