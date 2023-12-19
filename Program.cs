int liczba1 = 8;
int liczba2 = 3;

//dodawanie
int wynikDodawania = liczba1 + liczba2;// 11
Console.WriteLine($"wynik Dodawania: {wynikDodawania}");

//odejmowanie
int wynikOdejmowania = liczba1 - liczba2; // 5
Console.WriteLine($"wynik Odejmowania: {wynikOdejmowania}");

//mnożenie
int wynikMnozenia = liczba1 * liczba2; // 24
Console.WriteLine($"wynik Mnozenia: {wynikMnozenia}");

//dzielenie
double wynikDzieleniaInt = liczba1 / liczba2; // 2
Console.WriteLine($"wynik Dzielenia Int: {wynikDzieleniaInt}");

double wynikDzieleniaDouble = (double)liczba1 / (double)liczba2; //2,66666...
Console.WriteLine($"wynik Dzielenia Double: {wynikDzieleniaDouble}");

//reszta z dzielenia
int pozostalaLiczba = 8 % liczba2; // 2
Console.WriteLine($"pozostala Liczba: {pozostalaLiczba}");

//inkrementacja
int argumentPrefInk = 8;
int wynikPrefiksInkrement = ++argumentPrefInk; //9
Console.WriteLine($"wynik Pref. Inkrementacji: {wynikPrefiksInkrement}");

int argumentPostfInk = 8;
int wynikPostfiksInkrement = argumentPostfInk++; //8
Console.WriteLine($"wynik Postf. Inkrementacji: {wynikPostfiksInkrement}");

//dekrementacja
int argumentPrefDek = 8;
int wynikPrefiksDekrement = --argumentPrefDek; //7
Console.WriteLine($"wynik Pref. Dekrementacji: {wynikPrefiksDekrement}");

int argumentPostfDek = 8;
int wynikPostfiksDekrement = argumentPostfDek--; //8
Console.WriteLine($"wynik Postf. Dekrementacji: {wynikPostfiksDekrement}");




