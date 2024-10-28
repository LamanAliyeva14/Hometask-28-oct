namespace TEST123;
class Program
{
    static void Main(string[] args)
    {


        //1. int tipindən bir array olur içində müsbət və mənfi ədədlər olur
        //elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin və q
        //əbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha sonra
        //içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın


        int[] array = { 1, -3, -9, 10, -15, };
        int[] newArray = Negativ(array);
        foreach (var number in newArray)
        {
            Console.WriteLine(number);
        }









        // 2. Repeat deyə bir method olsun və iki parametr qəbul etsin
        // biri "word" digəri "count" yəni bu şəkildə
        // "Repeat(string word, int count)" bu method göndərilən word-ü
        // göndərilən count qədər yan-yana yazdırıb geri qaytarsın.

        //Repeat("Hola!", 4);
        //Console.WriteLine(Repeat("Hola!", 4));







        //// 3. Verilmiş stringin Palindrome olub olmamağını yoxlayın.
        //string e = "asdFGFdsa";
        //Console.WriteLine(Palindrome(e));




        ////4. Verilmiş stringin içərisindəki təkrarlanan karakterləri silin

        //string a = "Madagascar";
        //Console.WriteLine(RepeatDelete(a));







        // 5.Verilmiş stringi tərsinə yazdırın

        //string a = "Have a nice day";
        //Backwards(a);
        //Console.WriteLine(Backwards(a));


        // 6.Verilmiş string bir mətnin içərisindəki boşluqlara qədər
        // olan sözdəri ayrılıqda yazın.


        //string a = "Summer Winter Autumn Spring";
        //Console.WriteLine(Splitword(a));








        // 7. Verilmiş strigin ilk 4 hərfini ekrana yazdırın

        //string b = "Alahamora";
        //Console.WriteLine(First4letters(b));


        //8.Verilmiş email dəyərinin domain hissəni qaytaran metod
        //string d = "lamania@code.edu.az";
        //Console.WriteLine(Domain(d));







        // 9.Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod

        //string word = "bsu23nd28";
        //Console.WriteLine(Contains(word));


        // 10.Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib
        // qaytaran metod
        //string word = "AcaDEMy";
        //Console.WriteLine(CorrectWord(word));






    }



    //1. int tipindən bir array olur içində müsbət və mənfi ədədlər olur
    //elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin və q
    //əbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha sonra
    //içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın


    public static int[] Negativ(int[] array)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                newArray[i] = -array[i];
            else
                newArray[i] = array[i];
        }
        return newArray;
    }
    













    // 2. Repeat deyə bir method olsun və iki parametr qəbul etsin
    // biri "word" digəri "count" yəni bu şəkildə
    // "Repeat(string word, int count)" bu method göndərilən word-ü
    // göndərilən count qədər yan-yana yazdırıb geri qaytarsın.


    public static string Repeat(string word, int count)
    {
        string result = "";
        for (int i=0; i<count; i++)
        {
            result += word;
        }
        return result;
    }









    //3. Verilmiş stringin Palindrome olub olmamağını yoxlayın.

    public static bool Palindrome(string e)
    {
        string f = "";
        for (int i=e.Length-1; i>=0; i--)
        {
             f+= e[i];
        }
        return f == e;
    }



    //4. Verilmiş stringin içərisindəki təkrarlanan karakterləri silin
    public static string RepeatDelete(string a)
    {
        string newword = "";
        foreach (char c in a)
        {
            if (!newword.Contains(c))
            {
                newword += c;
            }
        }
        return newword;


    }







    // 5. Verilmiş stringi tərsinə yazdırın

    public static string Backwards(string a)
    {
        char[] charArray = a.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }







    // 6.Verilmiş string bir mətnin içərisindəki boşluqlara qədər
    // olan sözdəri ayrılıqda yazın.

    public static string[] Splitword(string a)
    {
        string []result = a.Split(' ');
        foreach (string v in result)
        {
            Console.WriteLine(v);
        }
        return result;
    }
   







    // 7. Verilmiş strigin ilk 4 hərfini ekrana yazdırın
    public static string First4letters(string b)
    {
        string cutword = "";
        for (int i=0; i<b.Length && i<4; i++)
        {
            cutword += b[i];
        }
        return cutword;
    }



    //8.Verilmiş email dəyərinin domain hissəni qaytaran metod

    public static string Domain(string d)
    {
        int a = d.IndexOf('@');
        if (a >=0 -1 && a < d.Length - 1)
        {
            return d.Substring(a+1);
        }
        return string.Empty;
        
    }















    // 9.Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod

    public static bool Contains(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return false;
        }
        for (int i = 0; i < word.Length; i++)
        {
            if (!char.IsLetter(word[i]))
            {
                return false;
            } 
        }
        return true;

    }










    // 10.Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib
    // qaytaran metod

    public static string CorrectWord(string word)
    {
        string lowerform = word.ToLower();
        string correctform = char.ToUpper(lowerform[0]) + lowerform.Substring(1);
        return correctform;
            
    }


    // 11.Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod

    public static void FullNames(string []array)
    {
        string[] newarray = new string[array.Length];
        
    }









}

