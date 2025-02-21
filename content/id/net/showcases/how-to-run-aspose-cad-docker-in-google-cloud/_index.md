---
title: Cara Menjalankan Gambar Docker Aspose.CAD di Google Cloud
type: docs
description: "Jalankan Gambar Docker Aspose.CAD di Google Cloud."
weight: 75
url: /id/net/showcases/how-to-run-aspose-cad-docker-in-google-cloud/
---

## Prasyarat

- Docker harus diinstal di sistem Anda. Untuk informasi mengenai cara menginstal Docker di Windows atau Mac, silakan merujuk ke tautan di bagian “Lihat Juga”.
- Visual Studio 2022.
- Google CLI.
- SDK .NET Core 3.1 digunakan dalam contoh ini.
- Postman

## Fungsi Google Cloud Run

Cloud Run adalah lingkungan komputasi yang sepenuhnya terkelola untuk menerapkan dan mengskalakan kontainer HTTP tanpa server tanpa khawatir tentang penyediaan mesin, mengonfigurasi kluster, atau penskalaan otomatis.

- Tidak ada kunci vendor - Karena Cloud Run mengambil kontainer OCI standar dan mengimplementasikan API Penyajian Knative standar, Anda dapat dengan mudah memindahkan aplikasi Anda ke lingkungan di tempat atau cloud lainnya.
- Penskalaan otomatis yang cepat - Layanan mikro yang diterapkan di Cloud Run secara otomatis diukur berdasarkan jumlah permintaan yang masuk, tanpa Anda harus mengonfigurasi atau mengelola kluster Kubernetes yang lengkap. Cloud Run dapat diskalakan hingga nol—yaitu, tidak menggunakan sumber daya—jika tidak ada permintaan.
- Pembagian lalu lintas - Cloud Run memungkinkan Anda untuk membagi lalu lintas antara beberapa revisi, sehingga Anda dapat melakukan peluncuran bertahap seperti peluncuran canary atau peluncuran biru/hijau.
- Domain kustom - Anda dapat mengatur pemetaan domain kustom di Cloud Run dan akan menyediakan sertifikat TLS untuk domain Anda.
- Redundansi otomatis - Cloud Run menawarkan redundansi otomatis sehingga Anda tidak perlu khawatir tentang membuat beberapa instance untuk ketersediaan tinggi.

Cloud Run dan Cloud Functions adalah layanan yang sepenuhnya dikelola yang berjalan di infrastruktur tanpa server Google Cloud, secara otomatis mengskalakan, dan menangani permintaan HTTP atau peristiwa. Namun, mereka memiliki beberapa perbedaan penting:

- Cloud Functions memungkinkan Anda mengirimkan cuplikan kode (fungsi) yang ditulis dalam seperangkat bahasa pemrograman terbatas, sementara Cloud Run memungkinkan Anda menerapkan gambar kontainer menggunakan bahasa pemrograman yang Anda pilih.
- Cloud Run juga mendukung penggunaan alat atau pustaka sistem apa pun dari aplikasi Anda; Cloud Functions tidak memungkinkan Anda menggunakan eksekusi kustom.
- Cloud Run menawarkan durasi timeout permintaan yang lebih lama hingga 60 menit, sementara dengan Cloud Functions waktu tunggu permintaan dapat diatur hingga 9 menit.
- Cloud Functions hanya mengirim satu permintaan pada satu waktu ke setiap instance fungsi, sementara secara default Cloud Run dikonfigurasi untuk mengirim beberapa permintaan bersamaan di setiap instance kontainer. Ini membantu meningkatkan latensi dan mengurangi biaya jika Anda mengharapkan volume besar.

## Membuat proyek Fungsi Google Cloud

{{% alert color="primary" %}} 
Pastikan Anda memiliki hak yang cukup untuk membuat fungsi Google Cloud Run dan gambar di repositori Artifact Registry.
{{% /alert %}}

Untuk membuat program Fungsi Google Cloud, ikuti langkah-langkah di bawah ini:

1. Instal SDK .NET Core 3.1.
1. Instal paket template:
{{< highlight plain >}}
dotnet new -i Google.Cloud.Functions.Templates
{{< /highlight >}}
1. Selanjutnya, buat direktori untuk proyek Anda, dan gunakan dotnet new untuk membuat fungsi HTTP baru:
{{< highlight plain >}}
mkdir AsposeFunctions //buat folder
cd AsposeFunctions //masuk ke folder AsposeFunctions
dotnet new gcf-http //buat proyek Google Cloud Function dengan pemicu http
{{< /highlight >}}
{{% alert color="primary" %}} 
Ini membuat AsposeFunctions.csproj dan Function.cs di direktori saat ini. Buka Function.cs untuk meninjau kode, dan berikan pesan kustom jika Anda mau.
{{% /alert %}}
1. Contoh kode untuk file csproj (AsposeFunctions.csproj).
{{< highlight plain >}}
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Aspose.CAD" Version="22.7.0" />
    <PackageReference Include="Google.Cloud.Functions.Hosting" Version="1.0.0" />
  </ItemGroup>
</Project>
{{< /highlight >}}
1. Contoh kode untuk mengonversi gambar cad ke file png (Function.cs).
{{< highlight plain >}}
namespace AsposeFunctions
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logika untuk fungsi Anda dituliskan di sini.
        /// </summary>
        /// <param name="context">Konteks HTTP, yang berisi permintaan dan respons.</param>
        /// <returns>Tugas yang mewakili operasi asinkron.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                //var file = context.Request.Form.Files.FirstOrDefault(); //form file
                var file = context.Request.Body; //data biner
                
                var msFile = new MemoryStream();
                await file.CopyToAsync(msFile);
                msFile.Seek(0, SeekOrigin.Begin);
                
                using (var image = (CadImage)Image.Load(msFile))
                {
                    var ms = new MemoryStream();
                    image.Save(ms, new PngOptions());
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    context.Response.Headers.Add("Content-Type", "image/png");
                    context.Response.Headers.Add("Content-Disposition", "attachment;filename=result.png");

                    await context.Response.Body.WriteAsync(ms.ToArray(), 0, ms.ToArray().Length);
                }
            }
            catch (Exception e)
            {
                await context.Response.WriteAsync(e.Message);
            }
        }
    }
}
{{< /highlight >}}
1. Bangun fungsi Anda secara lokal sebagai berikut:
{{< highlight plain >}}
dotnet run
{{< /highlight >}}
1. Setelah server berjalan, telusuri ke http://localhost:8080 untuk memanggil fungsi. Tekan Ctrl-C di konsol untuk menghentikan server.

## Terapkan gambar docker ke Google Cloud

1. Masuk ke Google Cloud.
1. Buat proyek jika belum ada.
1. Pergi ke 'Artifact Registry' dan buat repositori.<br>
![Buat Repositori Artefak](/_assets/showcases/google/create-artifact-repository.png)<br>
1. Pilih repositori baru di Artifact Registry.
![Pilih repositori artefak](/_assets/showcases/google/select-artifact.png)<br>
1. Klik 'INSTRUKSI SETUP' dan salin perintah 'Konfigurasi Docker'.<br>
![INSTRUKSI SETUP](/_assets/showcases/google/setup-instruction.png)<br>
1. Tambahkan entri credHelper Docker ke file konfigurasi Docker, atau buat file jika belum ada.
{{< highlight plain >}}
//contoh
gcloud auth configure-docker {region}-docker.pkg.dev

gcloud auth configure-docker europe-west1-docker.pkg.dev
{{< /highlight >}}
1. Buat file Dockerfile di direktori root proyek dan edit DockerFile seperti di bagian <a href="#configuring-a-dockerfile">Mengonfigurasi Dockerfile</a>.
1. Mulai Docker Desktop.
1. Bangun gambar docker dengan jalur repositori cloud.
{{< highlight plain >}}
//contoh
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker build -t europe-west1-docker.pkg.dev/test/aspose/function:latest .
{{< /highlight >}}
1. Dorong gambar ke Google Cloud Artifact Registry
{{< highlight plain >}}
//contoh
docker build -t {region}-docker.pkg.dev/{project-name}/{repository-name}/{any-name}:{tag} .

docker push europe-west1-docker.pkg.dev/test/aspose-cloud/function:latest
{{< /highlight >}}

## Buat layanan Google Cloud Run 

1. Pergi ke Cloud Run.
1. Buat layanan Cloud Run.<br>
![Buat layanan Cloud Run](/_assets/showcases/google/create-cloud-run-service.png)<br>
1. Di field URL Gambar Kontainer, pilih kontainer dari 'ARTIFAK REGISTRY'.<br>
![URL Gambar Kontainer](/_assets/showcases/google/container-url.png)<br>
1. Periksa pengaturan lainnya seperti di bawah ini.<br>
![Pengaturan layanan](/_assets/showcases/google/cloud-run-service-settings.png)<br>
1. Tunggu hingga penyebaran selesai.
1. URL layanan untuk berfungsi dengan aplikasi konversi.<br>
![Url layanan](/_assets/showcases/google/url-service.png)<br>

### Mengonfigurasi Dockerfile

Langkah selanjutnya adalah mengedit konfigurasi Dockerfile di proyek.

1. Di Dockerfile, tentukan:

{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build /app .

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so/usr/lib/gdiplus.dll

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ASPNETCORE_ENVIRONMENT=Release
ENV TAPTAKE_SEED=false
ENTRYPOINT ["dotnet", "AsposeFunctions.dll"]
{{< /highlight >}}

Di atas adalah Dockerfile sederhana, yang berisi instruksi berikut:

- Gambar SDK yang akan digunakan. Di sini adalah gambar Net Core 3.1. Docker akan mengunduhnya saat build dijalankan. Versi SDK ditentukan sebagai tag.
- Setelah itu, Anda mungkin perlu menginstal Font karena gambar SDK berisi sangat sedikit font. Juga, Anda dapat menggunakan font lokal yang disalin ke gambar docker.
- Direktori kerja, yang ditentukan di baris berikutnya.
- Perintah untuk menyalin semuanya ke dalam kontainer, menerbitkan aplikasi, dan menentukan titik masuk.

## Contoh Eksekusi

1. Pengaturan Postman.<br>
![Menu Ikhtisar](/_assets/showcases/google/postman-settings.png)<br>
1. Pilih file DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. Klik tombol kirim.

{{% alert color="primary" %}} 
Jika jawabannya sukses, klik Simpan ke file dan Anda akan menerima file yang telah dikonversi dalam format png
{{% /alert %}}

## Lebih Banyak Contoh

Untuk lebih banyak contoh tentang bagaimana Anda dapat menggunakan Aspose.CAD di Docker, lihat [contoh](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Lihat Juga.

- [Instal Docker Desktop di Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instal Docker Desktop di Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies)
- [Google Cloud CLI](https://cloud.google.com/sdk/docs/install)
- [Berganti ke kontainer Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opsi
- Informasi tambahan tentang [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
