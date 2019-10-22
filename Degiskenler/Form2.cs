using System;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
   Değişken Nedir?       
   Değişkenleri en sabit şekilde verilerin depolandğı yerler olarak tanımlayabiliriz. Değişkenlerin içine verilerimizi koyabilirirz veya değişkenlerimizin içindeki verileri C# programındaki işlemlerimiz için kullanabilliriz
 */

        /*
         Degisken Kuralları
         
         1)Kullanmayacagimiz degiskenleri asla tanimlamamaliyiz...
         2)Deger araliklarina gore dogru veri tiplerini secmeye ozen gostermeliyiz... (Degisken Yonetimi = Performans Yonetimi)
         3)Bir degisken adi asla iki kelimeden olusamaz... Eger iki kelime ise mutlaka izin verilen ozel bir karakterle (_) birbirinden ayrilmalidir...
         4)Degisken adlari asla sayiyla baslamaz ancak sayiyla bitebilir...
        */


        private void btnTamSayilar_Click(object sender, EventArgs e)
        {
            // Ctrl + R + G => gereksiz using'leri siler
            // Ctrl + K + D => kodları düzenleme
            // Ctrl + E + W => Wordwrap
            // Ctrl + K + C => yorum satırına alma
            // Ctrl + K + U => yorum satırından çıkartma


            // byte => ram üzerinde 8 bit'lik bir alan kapsar
            // MaxValue = 255;
            // MinValue = 0;

            byte sayi1 = 12;

            // tanımlanan nesne'nin altı yeşil çizili ise, daha önce kullanılmadığına işaret eder, bu bizim için performans kaybıdır. kullanmayacağımız nesneleri, yorum satırına alınız ya da siliniz.      

            // sbyte => ram üzerinde 8 bit'lik bir alan kapsar
            // MaxValue = 127;
            // MinValue = -128;
            sbyte sayi2 = 23;


            // short => ram üzerinde 16 bit'lik bir alan kapsar
            // MaxValue = 32767;
            // MinValue = -32768;
            short sayi3 = -213;


            // ushort => ram üzerinde 16 bit'lik bir alan kapsar
            // UInt16 MaxValue = 65535;
            // UInt16 MinValue = 0;
            ushort sayi4 = 123;


            // int  => ram üzerinde 32 bit'lik bir alan kapsar
            // MaxValue = 2147483647;
            // MinValue = -2147483648;
            int sayi5 = 21321;


            // uint => ram üzerinde 32 bit'lik bir alan kapsar
            // MaxValue = 4294967295;
            // MinValue = 0;
            uint sayi6 = 2131;

            // long => ram üzerinde 64 bit'lik bir alan kapsar
            //  MaxValue = 9223372036854775807;
            //  MinValue = -9223372036854775808;
            long sayi7 = 2312321;

            // ulong => ram üzerinde 64 bit'lik bir alan kapsar
            // MaxValue = 18446744073709551615;
            // MinValue = 0;

            ulong sayi8 = 213213;
        }

        private void btnOndalikliSayilar_Click(object sender, EventArgs e)
        {
            // float => ram üzerinde 32 bit'lik bir alan kapsar
            // MinValue = -3.40282347E+38F;
            // Epsilon = 1.401298E-45F;
            // MaxValue = 3.40282347E+38F;
            // PositiveInfinity = 1F / 0F;
            // NegativeInfinity = -1F / 0F;
            // NaN = 0F / 0F;

            float sayi1 = 213.1231F;


            // MinValue = -1.7976931348623157E+308;
            // MaxValue = 1.7976931348623157E+308;
            // Epsilon = 4.94065645841247E-324;
            // NegativeInfinity = -1D / 0D;
            // PositiveInfinity = 1D / 0D;
            // NaN = 0D / 0D;

            double sayi2 = 23213.213213;



            // Zero = 0;
            // One = 1;
            // MinusOne = -1;
            // MaxValue = 79228162514264337593543950335M;
            // MinValue = -79228162514264337593543950335M;
            decimal sayi3 = 213.123213213M;
        }

        private void btnMetinsel_Click(object sender, EventArgs e)
        {
            // char => ram üzerinde 16 bit'lik bir alan kapsar 
            //MaxValue = '\uffff';
            //MinValue = '\0';

            char karakter = 'A';
            string metin = "bilge \"{adam}\" beşiktaş";

            //MessageBox.Show(metin);
            //MessageBox.Show("bilge adam beşiktaş yazılım dersleri");

            // bilge "adam" beşiktaş
            metin = "bilge\nadam\nbeşiktaş";  // \n => new line (yeni bir satır)

            //bilge
            //adam
            //beşiktaş
            metin = "bilge\tadam\tbeşiktaş";
            MessageBox.Show(metin);
        }

        private void btnMantiksal_Click(object sender, EventArgs e)
        {
            bool olumlu = true;
            bool olumsuz = false;

            bool result1 = 10 > 4; // => true
            bool result2 = 10 < 4; // => false 
        }
    }
}
