این سند روش استفاده از الگوی Factory برای ساختن نمونه‌های DbContext با کانکشن استرینگ مناسب را در پروژه ASP.NET Core توضیح می‌دهد.
<br>
این روش به مدیریت بهتر چندین کانکشن استرینگ، افزایش انعطاف‌پذیری و بهبود عملکرد کمک می‌کند.
<br>
* بعد از تنظیم کانکشن استرینگ
<br>
dotnet ef migrations add InitialCreate
<br>
dotnet ef database update
