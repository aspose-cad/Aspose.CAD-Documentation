---
title: Cara Menjalankan Gambar Docker Aspose.CAD di Fungsi AWS Lambda
type: docs
description: "Jalankan gambar Docker Aspose.CAD di Fungsi AWS Lambda."
weight: 74
url: /id/net/showcases/how-to-run-aspose-cad-docker-in-aws-lambda-function/
---

## Prasyarat
- Docker harus diinstal di sistem Anda. Untuk informasi tentang cara menginstal Docker di Windows atau Mac, silakan lihat tautan di bagian "Lihat Juga".
- Visual Studio 2022.
- AWS Toolkit untuk Visual Studio 2022.
- NET 6 SDK digunakan dalam contoh ini.
- Postman

## Fungsi AWS Lambda

Lambda adalah layanan komputasi yang memungkinkan Anda menjalankan kode tanpa penyediaan atau pengelolaan server. Lambda menjalankan kode Anda di infrastruktur komputasi dengan ketersediaan tinggi dan melakukan semua administrasi sumber daya komputasi, termasuk pemeliharaan server dan sistem operasi, penyediaan kapasitas dan penskalaan otomatis, serta pencatatan. Dengan Lambda, Anda dapat menjalankan kode untuk hampir semua jenis aplikasi atau layanan backend.

## Membuat Fungsi AWS Lambda

{{% alert color="primary" %}} 
Pastikan Anda memiliki hak yang cukup untuk membuat fungsi dan gambar AWS Lambda di Amazon Elastic Container Registry.
{{% /alert %}}

Untuk membuat program Fungsi AWS Lambda, ikuti langkah-langkah di bawah ini:
1. Buat Proyek AWS Lambda.<br>
![Buat tombol fungsi AWS](/_assets/showcases/aws/create-project.png)<br>
1. Pilih .NET 6 (Gambar Kontainer) dan klik tombol 'Selesai'.<br>
![Buat tombol fungsi kontainer](/_assets/showcases/aws/create-container.png)<br>
1. Buka AWS Explorer di Visual Studio (Tampilan->AWS Explorer).
1. Tambahkan profil kredensial AWS di AWS Explorer.<br>
![Profil kredensial](/_assets/showcases/aws/add-aws-credentials-profile.png)<br>
1. Masukkan Access Key ID dan Secret Access Key, Anda dapat memperoleh kunci ini di kredensial keamanan atau menghubungi administrator dan mendapatkan file csv untuk otorisasi.<br>
![Pengaturan profil akun](/_assets/showcases/aws/account-profile.png)<br>
1. Instal pustaka terbaru dari NuGet.<br>
![Pengelola NuGet](/_assets/showcases/aws/nuget-manager.png)<br>
1. Contoh kode untuk mengonversi gambar cad menjadi file pdf.
{{< highlight plain >}}
public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest stream, ILambdaContext context)
{
    try
    {            
        var parser = HttpMultipartParser.MultipartFormDataParser.Parse(new MemoryStream(Convert.FromBase64String(stream.Body)));
        var file = parser.Files.First();
        Stream fileStream = file.Data;

        using (var img = Aspose.CAD.Image.Load(fileStream))
        {
            var ms = new MemoryStream();
            img.Save(ms, new PdfOptions());
            ms.Seek(0, (System.IO.SeekOrigin)SeekOrigin.Begin);
          
            return new APIGatewayHttpApiV2ProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = Convert.ToBase64String(ms.ToArray()),
                IsBase64Encoded = true,
                Headers = new Dictionary<string, string>
                {
                    {"Content-Type", "application/pdf" },
                    {"Content-Disposition", "attachment;filename=filename.pdf" }
                }
            };
        }
    }
    catch (Exception e)
    {           
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = e.Message,
            Headers = new Dictionary<string, string>
            {
                {
                    "Content-Type", "text/html"
                }
            }
        };
    }
}
{{< /highlight >}}
1. Edit DockerFile seperti di bagian <a href="#configuring-a-dockerfile">Mengonfigurasi Dockerfile</a>.
1. Mulai Docker Desktop.
1. Publikasikan ke AWS Lambda.<br>
![Publikasi AWS lambda](/_assets/showcases/aws/publish-aws.png)<br>
1. Edit konfigurasi unggahan.<br>
![Unggah aws lambda](/_assets/showcases/aws/upload-aws-lambda.png)<br>
1. Klik tombol 'Unggah'.<br>
![Unggah aws lambda terakhir](/_assets/showcases/aws/upload-aws-lambda-finish.png)<br>
1. Pergi ke AWS dan pilih Lambda.<br>
![AWS Lambda](/_assets/showcases/aws/select-aws-lambda.png)<br>
1. Pilih fungsi baru Anda dan buat url fungsi.<br>
![Konfigurasi url fungsi](/_assets/showcases/aws/create-function-url.png)<br>
1. Pilih tipe otentikasi
- AWS_IAM - Hanya pengguna dan peran IAM yang terautentikasi yang dapat membuat permintaan ke URL fungsi Anda.
- NONE - Lambda tidak akan melakukan otentikasi IAM pada permintaan ke URL fungsi Anda. Titik akhir URL akan bersifat publik kecuali Anda menerapkan logika otorisasi Anda sendiri di fungsi Anda.

### Mengonfigurasi Dockerfile

Langkah selanjutnya adalah mengedit konfigurasi Dockerfile dalam proyek.

1. Dalam Dockerfile, tetapkan:

{{< highlight plain >}}
FROM public.ecr.aws/lambda/dotnet:6

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .

RUN yum install -y amazon-linux-extras 
RUN amazon-linux-extras install epel -y
RUN yum install -y libgdiplus  

CMD ["AWSLambda::AWSLambda.Function::FunctionHandler"]
{{< /highlight >}}

 Di atas adalah Dockerfile sederhana, yang berisi instruksi berikut:

- Gambar SDK yang akan digunakan. Di sini adalah gambar Net 6. Docker akan mengunduhnya saat build dijalankan. Versi SDK ditentukan sebagai tag.
- Setelah itu, Anda mungkin perlu menginstal Font karena gambar SDK mengandung sangat sedikit font. Juga, Anda dapat menggunakan font lokal yang disalin ke gambar docker.
- Direktori kerja, yang ditetapkan di baris berikutnya.
- Perintah untuk menyalin semua ke kontainer, menerbitkan aplikasi, dan menentukan titik masuk.

## Contoh Eksekusi

1. Pengaturan Postman.<br>
![Menu gambaran umum](/_assets/showcases/aws/postman-settings.png)<br>
1. Pilih DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, atau file SVG lainnya.
1. Klik tombol kirim.

{{% alert color="primary" %}} 
Jika jawaban berhasil, klik Simpan ke file dan Anda akan menerima file yang dikonversi dalam format pdf
{{% /alert %}}

## Contoh Lainnya

Untuk lebih banyak sampel tentang cara Anda dapat menggunakan Aspose.CAD di Docker, lihat [contoh](https://github.com/aspose-cad/Aspose.CAD-Documentation).

## Lihat Juga.

- [Instal AWS Toolkit untuk Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=AmazonWebServices.AWSToolkitforVisualStudio2022)
- [Instal Docker Desktop di Windows](https://docs.docker.com/docker-for-windows/install/)
- [Instal Docker Desktop di Mac](https://docs.docker.com/docker-for-mac/install/)
- [Visual Studio 2022, NET 6 SDK](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#dependencies)
- [Beralih ke kontainer Linux](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) opsi
- Informasi tambahan tentang [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-sdk)
