//słownik do szyfrowania
 const string chars = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUVWXYZŹŻ ";
string toAsciiCaesar(string clearText);
String fromAsciiCaesar(string encrypatedText);

string toArrayCaesar(String clearText)
{
    //zmień tekst na wielkie litery
    clearText = clearText.ToUpper();
    //zdefinuj zmienną na zaszyfrowany tekst
    string encryptedTxt = "";
        //deklarujemy tablicę pojedyńczych charów i wypełniamy ją
        char[] charArry = chars.ToCharArray();
    //przechodzimy pętlą przez tekst do zaszyfrowania
    foreach (char c in clearText)
    {
        //znajdujemy pozycję w słowniku pierwotnej (nie zaszyfrowaniej)
        int index = Array.IndexOf(charArry, c);
        //dodajemy wartośc klucza
        index += 3;
        //jeżeli wynikowy index jest wyższy niż liczba liter w słowniku
        if(index > charArry.Length - 1)
        {
            //odjemji
            index -= charArry.Length;
        }
            //zapisz do zaszyfrowanego tekstu literę pod indeksem
            encryptedTxt+= charArry[index];

    }

    return encryptedTxt;
}
//zddefinuj string do zaszyfrowania 
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia ";
string encryptedText = toAsciiCaesar(clearText);
string encryptedText2 = toArrayCaesar(clearText);

Console.WriteLine("Zaszyfrowany tekst;" + encryptedText);
Console.WriteLine("Zaszyforwany tekst:" + fromAsciiCaesar(clearText));

Console.WriteLine("Zaszyfrowany drugą metoda tekst:" + encryptedText2);