این سند روش استفاده از الگوی Factory برای ساختن نمونه‌های DbContext با کانکشن استرینگ مناسب را در پروژه ASP.NET Core توضیح می‌دهد.
این روش به مدیریت بهتر چندین کانکشن استرینگ، افزایش انعطاف‌پذیری و بهبود عملکرد کمک می‌کند.
<br>
**بعد از تنظیم کانکشن استرینگ
**dotnet ef migrations add InitialCreate
dotnet ef database update
