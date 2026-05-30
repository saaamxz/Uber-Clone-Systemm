# Uber Clone System 

نظام محاكاة لمنصة Uber تم تطويره باستخدام تقنيات Microsoft الحديثة.

## التقنيات المستخدمة
- **Framework:** ASP.NET Core MVC (net10.0)
- **Database:** SQL Server (Entity Framework Core)
- **Architecture:** Model-View-Controller (MVC)

## المميزات الرئيسية
- نظام تسجيل دخول وتسجيل مستخدمين.
- إدارة الرحلات وحجز المركبات.
- الربط مع قاعدة بيانات SQL Server لإدارة البيانات.

## متطلبات التشغيل
1. تثبيت **Visual Studio 2022** أو أحدث.
2. تثبيت **.NET SDK 10.0**.
3. تحديث سلسلة الاتصال (`Connection Strings`) في ملف `appsettings.Development.json` لتتوافق مع جهازك.
4. تنفيذ الأوامر التالية في الـ Package Manager Console لإنشاء قاعدة البيانات:
   ```powershell
   Update-Database
