---
title: Cara Menjalankan Aspose.CAD di Docker
type: docs
description: "Jalankan Aspose.CAD dalam wadah Docker untuk Linux, Windows Server, dan sistem operasi lainnya."
weight: 71
url: /id/net/showcases/how-to-run-aspose-cad-in-docker/
---

## Prasyarat
- Docker harus diinstal di sistem Anda. Untuk informasi tentang cara menginstal Docker di Windows atau Mac, silakan merujuk ke tautan di bagian "Lihat Juga".
- Visual Studio 2022.
- SDK .NET 6 digunakan dalam contoh ini.

## Aplikasi Hello World

Dalam contoh ini, Anda membuat aplikasi konsol Hello World sederhana yang menggambar suatu elips dan menyimpannya sebagai gambar. Aplikasi kemudian dapat dibangun dan dijalankan di Docker.

## Membuat Aplikasi Konsol

Untuk membuat program Hello World, ikuti langkah-langkah di bawah ini:
1. Setelah Docker terinstal, pastikan bahwa ini menggunakan Kontainer Linux (default). Jika perlu, pilih opsi Beralih ke kontainer Linux dari menu Docker Desktop.
1. Di Visual Studio, buat aplikasi konsol .NET 6.<br>
![Dialog proyek aplikasi konsol .NET 6](/cad/_assets/showcases/docker/1.png)<br>
1. Instal versi terbaru Aspose.CAD dari NuGet.<br>
![Aspose.CAD di NuGet](/cad/_assets/showcases/docker/2.png)<br>
1. Karena aplikasi akan dijalankan di Linux, Anda mungkin perlu menginstal font tambahan. Anda dapat memilih ttf-mscorefonts-installer.
1. Ketika semua dependensi yang diperlukan telah ditambahkan, tulis program sederhana yang membuat elips dan menyimpannya sebagai gambar:<br>

{{< highlight plain >}}
using (var img = Aspose.CAD.Image.Load(System.IO.Directory.GetCurrentDirectory() + "/input.dxf"))
{
	img.Save(Path.Combine("TestOut", "output.png"), new Aspose.CAD.ImageOptions.PngOptions());
}
{{< /highlight >}}

Perhatikan bahwa folder “TestOut” ditentukan sebagai folder keluaran untuk menyimpan dokumen keluaran. Saat menjalankan aplikasi di Docker, sebuah folder di mesin host akan dipasang ke folder ini di dalam kontainer. Ini akan memungkinkan Anda untuk dengan mudah melihat keluaran yang dihasilkan oleh Aspose.CAD di dalam kontainer Docker.

### Mengonfigurasi Dockerfile

Langkah selanjutnya adalah membuat dan mengonfigurasi Dockerfile.

1. Buat Dockerfile dan tempatkan di samping file solusi aplikasi Anda. Jaga nama file ini tanpa ekstensi (default).
1. Di dalam Dockerfile, tentukan:


{{< highlight plain >}}
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY /Aspose.CAD.Docker.Sample/*.csproj ./Aspose.CAD.Docker.Sample/
RUN dotnet restore ./Aspose.CAD.Docker.Sample/

COPY /Aspose.CAD.Docker.Sample ./Aspose.CAD.Docker.Sample/

WORKDIR /app/Aspose.CAD.Docker.Sample
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=builder /app/Aspose.CAD.Docker.Sample/publish ./

RUN apt-get update
RUN apt-get install -y apt-utils
RUN apt-get install -y libgdiplus
RUN apt-get install -y libc6-dev 
RUN ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll

RUN sed -i'.bak' 's/$/ contrib/' /etc/apt/sources.list
RUN apt-get update; apt-get install -y ttf-mscorefonts-installer fontconfig

RUN apt-get install fonts-freefont-ttf

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Release

EXPOSE 80
ENTRYPOINT ["dotnet", "Aspose.CAD.Docker.Sample.dll"]
{{< /highlight >}}

Di atas adalah Dockerfile sederhana, yang berisi instruksi berikut:

- Gambar SDK yang akan digunakan. Di sini adalah gambar .NET 6. Docker akan mengunduhnya ketika build dijalankan. Versi SDK ditentukan sebagai tag.
- Setelah itu, Anda mungkin perlu menginstal Font karena gambar SDK mengandung sangat sedikit font. Selain itu, Anda juga dapat menggunakan font lokal yang disalin ke gambar docker.
- Direktori kerja, yang ditentukan pada baris berikutnya.
- Perintah untuk menyalin semuanya ke kontainer, menerbitkan aplikasi, dan menentukan titik masuk.


## Membangun dan Menjalankan Aplikasi di Docker
 
Sekarang aplikasi dapat dibangun dan dijalankan di Docker. Buka command prompt favorit Anda, ubah direktori ke folder dengan aplikasi (folder tempat file solusi dan Dockerfile ditempatkan) dan jalankan perintah berikut:

{{< highlight plain >}}
docker build -t dockerfile .
{{< /highlight >}}

Waktu pertama perintah ini dijalankan mungkin memakan waktu lebih lama, karena Docker perlu mengunduh gambar yang diperlukan. Setelah perintah sebelumnya selesai, jalankan perintah berikut:

{{< highlight plain >}}
docker run --mount type=bind,source=C:\Temp,target=/app/TestOut --rm dockerfile
{{< /highlight >}}

{{% alert color="primary" %}} 
Perhatikan argumen mount, karena, seperti yang disebutkan sebelumnya, sebuah folder di mesin host dipasang ke folder kontainer, untuk dengan mudah melihat hasil eksekusi aplikasi. Jalur di Linux bersifat sensitif terhadap huruf besar.
{{% /alert %}}

## Contoh Lain

Untuk lebih banyak contoh tentang bagaimana Anda dapat menggunakan Aspose.CAD di Docker, lihat [contoh](https://github.com/aspose-cad/Aspose.CAD-Documentation).


## Lihat Juga

- [Instal Docker Desktop di Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instal Docker Desktop di Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, SDK .NET 6](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- Opsi [Beralih ke kontainer Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers)
- Informasi tambahan tentang [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
