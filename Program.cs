using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;

            while (true)
            {
                Console.WriteLine("Kayıt olma ekranı");
                Console.Write("Lütfen kullanıcı adınızı oluşturunuz : ");
                string kadı = Console.ReadLine();
                Console.Write("Lütfen şifre oluşturunuz : ");
                string gşifre = Console.ReadLine();
                Console.WriteLine("Giriş yapma ekranı");
                Console.Write("Lütfen kullanıcı adınızı giriniz : ");
                string badı = Console.ReadLine();
                Console.Write("Lütfen şifrenizi giriniz : ");
                string hşifre = Console.ReadLine();



                if (kadı == badı && gşifre == hşifre)
                {
                    Console.Clear();
                    int bakiye = 1000;
                    int vergi = 3;
                    Console.WriteLine("ATM'ye hoş geldin...");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("1 - Bakiye sorgula ");
                    Console.WriteLine("2 - Para çekme ");
                    Console.WriteLine("3 - Para yatırma ");
                    Console.WriteLine("4 - IBAN'a para yatırma");
                    Console.WriteLine("5 - Fatura yatırma");
                    Console.WriteLine("6- Şifre değiştirme");
                    Console.WriteLine("7 - Çıkış yapma");
                    string seçim = Console.ReadLine();

                    switch (seçim)
                    {
                        case "1":
                            Console.WriteLine("Bakiyeniz : " + bakiye);

                            break;
                        case "2":

                            Console.WriteLine("Lütfen çekmek istediğiniz giriniz ");
                            int çpara = int.Parse(Console.ReadLine());
                            int kalan1 = (bakiye - çpara) - vergi;
                            if (çpara > (bakiye - vergi) && çpara < bakiye)
                            {
                                Console.WriteLine("Lütfen " + vergi + " TL değerindeki vergiyi hesaba katınız");
                            }
                            else if (çpara < 1000 && çpara > 5)
                            {
                                Console.WriteLine("Çekilen vergi ücreti " + vergi + " TL");
                                Console.WriteLine("Kalan para : " + kalan1);
                            }

                            else if (çpara >= 1000)
                            {
                                Console.WriteLine("Mevcut bakiyeden fazla tutar çekemezsiniz");
                            }
                            else if (çpara < 5)
                            {

                                Console.WriteLine("Lütfen sadece kağıt para ile işlem yapınız.");

                            }
                            else
                            {
                                Console.WriteLine("Çekilen vergi ücreti " + vergi + " TL");
                                Console.WriteLine("Kalan para : " + kalan1);
                            }

                            break;
                        case "3":

                            Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz ");
                            int ypara = int.Parse(Console.ReadLine());
                            int toplam = bakiye + ypara;

                            if (ypara >= 5)
                            {
                                Console.WriteLine("Toplam tutar : " + (toplam - vergi));
                                Console.WriteLine("Çekilen vergi tutarı " + vergi + "TL");
                            }
                            else if (ypara < 5)
                            {
                                Console.WriteLine("Lütfen kayğıt para ile işlem yapınız.");
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir tutar giriniz");
                            }

                            break;

                        case "4":
                            Console.WriteLine("Lütfen para yatırmak istediğiniz hesabın IBAN numarasını yazınız.");
                            string iban = Console.ReadLine();
                            Console.WriteLine(iban + " Numaralı karta para yatırıyorsunuz. Emin misiniz?");
                            Console.WriteLine("Evet ise : 7 Hayır ise : 8");
                            string emin = Console.ReadLine();

                            switch (emin)
                            {
                                case "7":
                                    {
                                        Console.WriteLine(" Yatırmak istediğiniz tutarı seçiniz ");
                                        int ytutar = int.Parse(Console.ReadLine());
                                        int vergili = (bakiye - ytutar) - vergi;
                                        if (ytutar > 1000)
                                        {
                                            Console.WriteLine("Lütfen hesabınızdaki mevcut bakiyeyi aşmayacak şekilde tutar giriniz");
                                        }
                                        else
                                        {
                                            Console.Write("Hesabınızda kalan para : " + vergili);
                                        }
                                    }
                                    break;
                                case "8":
                                    {
                                        Console.WriteLine("Çıkış yapılıyor...");
                                    }
                                    break;

                            }
                            break;
                        case "5":
                            int yfatura = 80;
                            Console.WriteLine("Faturanız : " + yfatura);
                            Console.WriteLine("Lütfen madeni para kullanmayınız.");
                            Console.WriteLine("Parayı hazneye yerleştiriniz");

                            int yatırma = int.Parse(Console.ReadLine());
                            int bozukluk = yatırma - yfatura;
                            if (yatırma <= 80)
                            {
                                Console.WriteLine("Yatırdığınız miktar faturayı ödemeye yetmiyor");

                            }
                            else
                            {
                                Console.WriteLine("İşlem tamamlanmıştır. Lütfen para üstünü almayı unutmayınız." + bozukluk);
                            }
                            break;
                        case "6":
                            int şifre = 1111;

                            Console.WriteLine("Lütfen değiştirmek istediğiniz şifreyi yazınız");
                            int yşifre = int.Parse(Console.ReadLine());
                            if (yşifre < 1000)
                            {
                                Console.WriteLine("Lütfen 4 haneli bir şifre giriniz.");
                            }

                            else if (yşifre > 9999)
                            {
                                Console.WriteLine("Lütfen 4 haneli bir şifre giriniz.");
                            }
                            else
                            {

                                Console.WriteLine("Yeni şifreniz " + şifre + "'den " + yşifre + "'a değiştirilmiştir.");
                            }
                            break;
                        case "7":

                            Console.WriteLine("Çıkış yapılıyor. ATLAS Bank iyi günler diler...");

                            break;
                        default:

                            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                            Console.WriteLine("Bu 1, 2 ,3 veya 4 sayısı olabilir.");

                            break;
                    }
                }
                else
                {
                    if (hak > 0)
                    {
                        hak -= 1;
                    }
                    if (hak == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı adı veya şifreyi yanlış girdiniz.");

                    }
                    if (hak == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı adı veya şifreyi yanlış girdiniz.");
                    }
                    if (hak == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hesabınız 1 saat sonra erişime açılacaktır.");
                    }

                    Console.WriteLine(hak + " hakkınız kaldı ");

                }
                Console.ReadLine();

            }
        }
    }
}
