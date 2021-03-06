namespace MyApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			// **************************************************
			// Comment Types:
			// **************************************************
			// Inline Comment
			// Add: Ctrl + K + C
			// Remove: Ctrl + K + U

			/*
			* Multi
			* Line
			* Comment
			*/

			/// Hello!
			/// This is:
			/// XML Comment...
			// **************************************************

			// **************************************************
			// متغیر
			// **************************************************

			// فضایی از حافظه
			// برای نگه داشتن یک مقدار، و بعد هم استفاده از آن

			// می تواند جنس خاص خودش را داشته باشد
			// char, bool, string, integer, floating point!

			// **************************************************

			// **************************************************
			// حافظه: Stack, Heap
			// **************************************************

			// **************************************************
			// دسته بندی متغیرها
			// **************************************************

			// *************************
			// تعریف اول
			// *************************
			// بر اساس یک تعریف، متغیرها دو دسته می باشند
			// Field
			// Local Variable
			// *************************

			// *************************
			// Local Variable - متغیرهای محلی
			// *************************
			// دسته ی اول
			// متغیرهایی که در داخل توابع تعریف می شوند
			// می گوییم Local Variable و اصطلاحا به آن ها، متغیرهای محلی یا

			// ها Local Variable همه ی
			// قرار می گیرند Stack در داخل
			// مطلقا مقدار اولیه ندارند
			// خواهند داشت null حتی نباید بگوییم، مقدار

			// وقتی یک متغیر محلی تعریف میکنیم
			// ایجاد می شود Stack یک فضا در
			// به همان اسم، و از جنس همان متغیر
			// *************************

			// *************************
			// Field
			// *************************
			// دسته ی دوم
			// و در داخل کلاس تعریف می شوند ،Function متغیرهایی که بیرون از تابع یا

			// همه ی متغیرهایی که خارج از تابع تعریف می شوند
			// قرار می گیرند Heap در
			// ها، مقدار اولیه ی مشخص دارند Local Variable و برعکس
			// *************************

			// *************************
			// تعریف دوم
			// *************************
			// بر اساس یک تعریف دیگر، این بار هم متغیرها به دو دسته تقسیم می شوند
			// Reference Type
			// Value/Primitive Type
			// *************************

			// *************************
			// Value Type or Primitive Type:
			// *************************
			// دسته ی اول
			// متغیرهایی که خودشان، و مقدارشان در یک جا قرار دارد
			// Heap یا در ،Stack یا در
			// *************************

			// *************************
			// Reference Type:
			// *************************

			// دسته ی دوم: Reference Type نوع داده ی مرجع، یا

			// این دسته از متغیرها
			// (Stack خودشان در یک جا (در
			// قرار می گیرد (Heap و مقدارشان در یک جا (در
			// می کنند Point و اصطلاحا به مقدارشان، اشاره یا
			// دارند null مقدار ،Reference Type همه ی متغیرهای
			// در این دسته قرار می گیرند string به عنوان مثال، همه ی آرایه ها (از هر نوع)، و

			// *************************

			// *************************
			// نکته:
			// *************************
			// ها استثنا هستند Reference Type در ،string متغیرهای رشته ای یا
			// *************************

			// **************************************************
			// تعریف متغیر
			// **************************************************
			// سه مرحله
			// 1. مشخص کردن نوع داده
			// 2. نام گذاری برای آن متغیر
			// 3. (مقداردهی به آن متغیر (در همان لحظه، یا بعد

			// { Data Type - نوع داده } { Variable Name - نام متغیر } = { Initial Value - مقدار اولیه };

			//string teacherName = "Mr. Dariush Tasdighi";

			//string teacherName;
			//teacherName = "Mr. Dariush Tasdighi";
			// **************************************************

			// **************************************************
			// نوع داده - Data Type:
			// **************************************************

			// می تواند رشته ای، عدد صحیح، عدد اعشاری و... باشد

			// **************************************************

			// **************************************************
			// نام متغیر - Variable Name
			// **************************************************
			// نمی تواند با عدد شروع بشود

			// نمی تواند در لیست کلمات کلیدی سی شارپ باشد

			// می تواند ترکیبی از حروف، اعداد و کاراکترهای مجاز باشد

			// نباید از کلمات به صورت مخفف، یا به صورت فینگلیش استفاده نماییم

			// باید از کلماتی استفاده کرد، که بار معنایی مناسبی دارند و مشخص کننده ی محتوای آن متغیر هستند
			// **************************************************

			// **************************************************
			// مقدار اولیه - Initial Value
			// **************************************************
			// در اکثر موارد اختیاری است
			// در اکثر مواقع، می توانیم بعدا به آن متغیر مقداردهی کنیم
			// **************************************************

			// **************************************************
			// نوع داده ی عداد صحیح
			// **************************************************

			// sbyte, byte, short, ushort, int, uint, long, ulong

			// *************************
			// s: signed → دارای علامت منفی
			// u: unsigned → بدون علامت منفی
			// *************************

			// *************************
			// Correct usage:
			// *************************
			//int number = 1500;
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//int number = "1500";
			// *************************
			// result → Compile Error!
			// *************************

			// **************************************************

			// **************************************************
			// نوع داده ی اعشاری
			// **************************************************

			// *************************
			// float, double, decimal
			// *************************
			// use Suffix:
			// float → f/F
			// decimal → m/M
			// *************************

			// *************************
			// Correct usage:
			// *************************
			//float number = 1.5f;
			//float number = 1.5F;
			//double number = 1.5;
			//decimal number = 1.5m;
			//decimal number = 1.5M;
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//float number = 1.5;
			//decimal number = 1.5;
			// *************************
			// result → Compile Error!
			// *************************

			// **************************************************

			// **************************************************
			// نوع داده ی کاراکتری
			// **************************************************

			// کاراکتر ها بین کوتیشن قرار می گیرند

			// !باید فقط و فقط از یک کاراکتر استفاده کرد، نه کمتر و نه بیشتر

			// *************************
			// Correct usage:
			// *************************
			//char character = ' ';
			//char character = 'D';
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//char character = '';
			//char character = 'Da';
			// *************************
			// result → Compile Error!
			// *************************

			// **************************************************

			// **************************************************
			// Boolean نوع داده ی منطقی یا
			// **************************************************

			// false و true ذخیره ی دو مقدار

			// *************************
			// Correct usage:
			// *************************
			//bool result = true;
			//bool result = false;
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//bool result = True;
			//bool result = "true";
			// *************************
			// result → Compile Error!
			// *************************

			// **************************************************

			// **************************************************
			// نوع داده ی رشته ای
			// **************************************************

			// رشته ها بین دابل کوتیشن یا "" قرار می گیرند

			// برای کار با رشته های متنی، از این نوع داده استفاده می کنیم

			// *************************
			//string firstName = "Ali";
			//string lastName = "Shariati";
			// *************************

			// *************************
			// چاق کردن رشته ها
			// *************************
			//string fullName =
			//	firstName + " " + lastName;

			//System.Console.WriteLine(fullName);
			//System.Console.ReadLine();
			// *************************

			// *************************
			//string birthDate =
			//	1973 + "/Feb/" + 17;

			//System.Console.WriteLine(birthDate);
			//System.Console.ReadLine();
			// *************************

			// *************************
			//string month = "/Feb/";
			//string birthDate = 1973 + month + 17;

			//System.Console.WriteLine(birthDate);
			//System.Console.ReadLine();
			// *************************

			// **************************************************

			// **************************************************
			// کار کردن با متغیرهای رشته ای
			// **************************************************

			// *************************
			//string result;
			//string title = "Mr.";
			//string name = "Tasdighi";
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//result =
			//	"title name";
			// *************************
			// result → title name
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//result =
			//	title name;
			// *************************
			// result → Compile Error!
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//result =
			//	title + name;
			// *************************
			// result → Mr.Tasdighi
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//result =
			//	title + "" + name;
			// *************************
			// result → Mr.Tasdighi
			// *************************

			// *************************
			// "" → null string
			// "" → استرینگی به طول صفر
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//result =
			//	string.Format("{0} {1}", title);
			// *************************
			// result → Runtime Error!
			// *************************

			// *************************
			// Correct usage:
			// *************************
			// String Format:

			//result =
			//	string.Format("{0} {1}", title, name);
			// *************************
			// result → Mr. Tasdighi
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//teacherName =
			//	string.Format("{ 0 } { 1 }", title, name);
			// *************************
			// result → Runtime Error!
			// *************************

			// *************************
			// Correct usage:
			// *************************
			//result =
			//	string.Format("{0} Dariush {1}", title, name);
			// *************************
			// result → Mr. Dariush Tasdighi
			// *************************

			// *************************
			// Correct usage [Dollar Sign]:
			// *************************
			//result =
			//	$"{title} {name}";
			// *************************
			// result → Mr. Tasdighi
			// *************************

			// *************************
			// Correct usage:
			// *************************
			//result =
			//	$"{ title } { name }";
			// *************************
			// result → Mr. Tasdighi
			// بعد از آکولاد باز، و قبل از آکولاد بسته، خوانایی کد را بالا تر می بریم ،space با نوشتن
			// *************************

			// *************************
			// Correct usage:
			// *************************
			//result =
			//	$"{ title } Dariush { name }";
			// *************************
			// result → Mr. Dariush Tasdighi
			// *************************

			// *************************
			// Wrong usage!
			// *************************
			//result =
			//	"{ title } Dariush { name }";
			// *************************
			// result → { title } Dariush { name }
			// *************************

			// **************************************************
		}
	}
}
