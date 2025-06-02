# 🛒 Website Thương Mại Điện Tử - .NET 9

Đây là một dự án website thương mại điện tử được xây dựng bằng công nghệ **ASP.NET Core (.NET 9)**.

## 🚀 Công nghệ sử dụng

- ASP.NET Core 9 (MVC hoặc Razor Pages)
- Entity Framework Core
- SQLite
- Bootstrap 5
- Identity (xác thực người dùng)

## 📂 Cấu trúc thư mục

ECommerceWebsite/
│
├── Controllers/
├── Models/
├── Views/
├── wwwroot/
├── appsettings.json
├── Program.cs
└── ECommerceWebsite.csproj

## ▶️ Cách chạy dự án

> ⚠️ Yêu cầu: Đã cài đặt [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### 1. Clone dự án về máy
```bash
git clone https://github.com/NgoHuynh03/Proj.git
cd Proj
2. Restore các package
dotnet restore
3. Chạy bằng chế độ theo dõi (hot reload)
dotnet watch run
Hệ thống sẽ tự động build lại và reload khi bạn thay đổi file mã nguồn.
4. Truy cập website
Mở trình duyệt và truy cập:
https://localhost:5001
🧪 Migration & CSDL
dotnet ef migrations add InitialCreate
dotnet ef database update
Cần cài đặt dotnet-ef:
dotnet tool install --global dotnet-ef
