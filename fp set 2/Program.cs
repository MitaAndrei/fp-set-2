using System;
using System.Linq;

namespace fp_set_2;

class Program
{
    static void Main(string[] args)
    {
        P1();
        Console.ReadLine();
    }

    /// <summary>
    /// 1. Se da o secventa de n numere.
    /// Sa se determine cate din ele sunt pare.
    /// </summary>

    static void P1()
    {
        int c = 0;
        Console.Write("Introudceti secventa: ");
        string secv = Console.ReadLine() + " ";
        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                    if (int.Parse(current) % 2 == 0)
                        c += 1;

                current = "";
            }

        }

        Console.WriteLine($"{c} numere pare");
    }

    /// <summary>
    /// 2. Se da o secventa de n numere. Sa se determina cate
    /// sunt negative, cate sunt zero si cate sunt pozitive.
    /// </summary>


    static void P2()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        int neg = 0;
        int zero = 0;
        int poz = 0;

        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                {
                    if (int.Parse(current) < 0)
                        neg++;

                    else if (int.Parse(current) > 0)
                        poz++;

                    else
                        zero++;
                }
                current = "";
            }

        }
        Console.WriteLine($"Pozitive: {poz}");
        Console.WriteLine($"Zero: {zero}");
        Console.WriteLine($"Negative: {neg}");
    }

    /// <summary>
    /// 3. Calculati suma si produsul numerelor de la 1 la n.
    /// </summary>

    static void P3()
    {

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int s = 0;
        int p = 1;
        for (int i = 1; i <= n; i++)
        {
            s += i;
            p *= i;
        }
        Console.WriteLine($"suma: {s}, produs: {p}");
    }

    /// <summary>
    /// 4. Se da o secventa de n numere. Determinati pe ce pozitie
    /// se afla in secventa un numara a. Se considera ca primul
    /// element din secventa este pe pozitia zero.
    /// Daca numarul nu se afla in secventa raspunsul va fi -1. 
    /// </summary>

    static void P4()
    {

        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";
        Console.Write("a = ");
        string a = Console.ReadLine();
        int pos = -1;

        int indTracker = 0;
        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                {
                    if (current == a)
                    {
                        pos = indTracker;
                        break;
                    }
                }
                current = "";
                indTracker++;
            }

        }
        Console.WriteLine(pos);

    }

    /// <summary>
    /// 5. Cate elemente dintr-o secventa de n numere sunt
    /// egale cu pozitia pe care apar in secventa.
    /// Se considera ca primul element din secventa este pe pozitia 0. 
    /// </summary>

    static void P5()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        int indTracker = 0;
        string current = "";
        int c = 0;
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                    if (int.Parse(current) == indTracker)
                        c++;

                current = "";
                indTracker++;
            }
        }
        Console.WriteLine(c);
    }

    /// <summary>
    /// 6. Se da o secventa de n numere. Sa se determine daca
    /// numerele din secventa sunt in ordine crescatoare.
    /// </summary>

    static void P6()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        bool eCrescatoare = true;
        string previous = "";
        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        previous = current;
                        current = "";
                        continue;
                    }

                    if (int.Parse(previous) > int.Parse(current))
                    {
                        eCrescatoare = false;
                        break;
                    }
                    previous = current;
                    current = "";
                }
            }
        }
        if (eCrescatoare)
            Console.WriteLine("Numerele sunt in ordine crescatoare");
        else
            Console.WriteLine("Numerele nu sunt in ordine crescatoare");

    }

    /// <summary>
    /// 7. Se da o secventa de n numere. Sa se determine cea mai
    /// mare si cea mai mica valoare din secventa.
    /// </summary>

    static void P7()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        string min = "";
        string max = "";
        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                {
                    if (min == "")
                    {
                        min = current;
                        max = current;
                        current = "";
                        continue;
                    }

                    if (int.Parse(current) > int.Parse(max))
                        max = current;

                    if (int.Parse(current) < int.Parse(min))
                        min = current;


                    current = "";
                }
            }
        }
        Console.WriteLine($"min: {min}, max: {max}");
    }


    /// <summary>
    /// 8. Determianti al n-lea numar din sirul lui Fibonacci.
    /// Sirul lui Fibonacci se construieste astfel:
    /// f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
    /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
    /// </summary>

    static void P8()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        double f = (1 + Math.Sqrt(5)) / 2;
        decimal fn = Convert.ToDecimal((Math.Pow(f, n) - Math.Pow(-f, -n)) / Math.Sqrt(5));
        Console.WriteLine($"F_{n} = {fn}");

    }

    /// <summary>
    /// 9. Sa se determine daca o secventa de n numere este monotona.
    /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
    /// </summary>

    static void P9()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        bool eMonotona = true;
        string monotonie = "";
        string previous = "";
        string current = "";
        int i = 0;
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        previous = current;
                        current = "";
                        i++;
                        continue;
                    }
                    int intprev = int.Parse(previous);
                    int intcur = int.Parse(current);
                    if (i == 1)
                    {
                        if (intprev > intcur)
                            monotonie = "descrescatoare";
                        else if (intcur > intprev)
                            monotonie = "crescatoare";
                        else
                        {
                            previous = current;
                            current = "";
                            continue;
                        }

                    }
                    if (monotonie != "")
                        i++;


                    if ((monotonie == "descrescatoare" & intprev < intcur)
                        || (monotonie == "crescatoare" & intprev > intcur))
                    {
                        eMonotona = false;
                        break;
                    }
                    previous = current;
                    current = "";
                }
            }
        }
        if (eMonotona)
            Console.WriteLine($"Secventa e monoton {monotonie}");

        else
            Console.WriteLine("Secventa nu e monotona");

    }

    /// <summary>
    /// 10.Se da o secventa de n numere.
    /// Care este numarul maxim de numere consecutive egale din secventa. 
    /// </summary>

    static void P10()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        int maxeg = 0;
        int curreg = 0;
        string previous = "";
        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        previous = current;
                        current = "";
                        curreg++;
                        maxeg++;
                        continue;
                    }

                    if (int.Parse(previous) == int.Parse(current))
                    {

                        curreg++;

                        if (curreg > maxeg)
                            maxeg = curreg;

                    }
                    else
                        curreg = 1;

                    previous = current;
                    current = "";
                }
            }
        }
        Console.WriteLine(maxeg);

    }

    /// <summary>
    /// 11. Se da o secventa de n numere.
    /// Se cere sa se caculeze suma inverselor acestor numere.
    /// </summary>

    static void P11()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        string current = "";
        double suma = 0;
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                    suma += 1.0 / int.Parse(current);

                current = "";
            }

        }
        Console.WriteLine($"Suma = {suma}");

    }


    /// <summary>
    /// 12. Cate grupuri de numere consecutive diferite de zero
    /// sunt intr-o secventa de n numere. Considerati fiecare
    /// astfel de grup ca fiind un cuvant, zero fiind delimitator
    /// de cuvinte. De ex. pentru secventa
    /// 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
    /// </summary>

    static void P12()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " 0 ";


        string current = "";
        int c = 0;
        bool e = true;
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                {

                    if (current != "0")
                        e = true;

                    else
                    {
                        if (e)
                            c++;
                        e = false;
                    }
                    current = "";
                }
            }
        }
        Console.WriteLine(c);
    }


    /// <summary>
    /// O <secventa crescatoare rotita> este o secventa de numere care
    /// este in ordine crescatoare sau poate fi transformata intr-o
    /// secventa in ordine crescatoare prin rotiri succesive
    /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o
    /// pozitie spre stanga si primul element devine ultimul).
    /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
    /// </summary>
    static void P13()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        string previous = "";
        string current = "";
        string primul = "";
        int nuecresc = 0;

        bool eSecvCrescRot = true;

        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;

            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        primul = current;
                        previous = current;
                        current = "";
                        continue;
                    }
                    if (int.Parse(previous) > int.Parse(current))
                        nuecresc++;

                    if (nuecresc == 2 || (int.Parse(current) > int.Parse(primul) & nuecresc == 1))
                    {
                        eSecvCrescRot = false;
                        break;
                    }

                    previous = current;
                    current = "";
                }

            }
        }
        if (eSecvCrescRot)
            Console.WriteLine("E secventa crescatoare rotita");
        else
            Console.WriteLine("Nu e secventa crescatoare rotita");
    }

    /// <summary>
    /// 14. O <secventa monotona rotita> este o secventa de numere monotona
    /// sau poate fi transformata intr-o secventa montona prin rotiri
    /// succesive. Determinati daca o secventa de n numere este o
    /// secventa monotona rotita.
    /// </summary>
    static void P14()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        string previous = "";
        string current = "";
        string primul = "";
        string monotonie = "";
        bool eSecvMonRot = true;
        int nue = 0;
        int i = 0;

        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        primul = current;
                        previous = current;
                        current = "";
                        i++;
                        continue;


                    }

                    int intprev = int.Parse(previous);
                    int intcur = int.Parse(current);
                    int intprim = int.Parse(primul);

                    if (i == 1)
                    {
                        if (intprev > intcur)
                        {
                            monotonie = "descrescatoare";
                            i++;
                        }

                        else if (intcur > intprev)
                        {
                            monotonie = "crescatoare";
                            i++;
                        }

                        else
                        {
                            previous = current;
                            current = "";
                            continue;
                        }

                    }

                    if (monotonie == "crescatoare" & intcur < intprev ||
                        monotonie == "descrescatoare" & intcur > intprev)
                    {
                        nue++;
                    }
                    if (nue == 2
                        || (monotonie == "crescatoare" & intcur > intprim & nue == 1)
                        || (monotonie == "descrescatoare" & intcur < intprim & nue == 1)
                        )
                    {
                        eSecvMonRot = false;
                        break;
                    }

                    previous = current;
                    current = "";
                }

            }
        }
        if (eSecvMonRot)
            Console.WriteLine("E secventa monotona rotita");
        else
            Console.WriteLine("Nu e secventa monotona rotita");
    }


    /// <summary>
    /// 15. O secventa bitonica este o secventa de numere care
    /// incepe monoton crescator si continua monoton descrecator.
    /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.
    /// Se da o secventa de n numere. Sa se determine daca este bitonica. 
    /// </summary>

    static void P15()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";
        string previous = "";
        string current = "";
        bool creste = true;
        bool eSecvBitonica = true;
        int i = 1;
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        previous = current;
                        current = "";
                        continue;
                    }
                    int intprev = int.Parse(previous);
                    int intcur = int.Parse(current);
                    if (intprev > intcur)
                    {
                        creste = false;
                        if (i == 1)
                        {
                            eSecvBitonica = false;
                            break;
                        }
                    }
                    if (!creste)
                    {
                        if (intprev < intcur)
                        {
                            eSecvBitonica = false;
                            break;
                        }

                    }
                }
                previous = current;
                current = "";
                i++;
            }
        }

        if (creste)
            eSecvBitonica = false;


        if (eSecvBitonica)
            Console.WriteLine("E secventa bitonica");
        else
            Console.WriteLine("Nu e secventa bitonica");
    }

    /// <summary>
    /// 16. O secventa bitonica rotita este o secventa bitonica sau
    // una ca poate fi transformata intr-o secventa bitonica prin
    // rotiri succesive (rotire = primul element devine ultimul).
    // Se da o secventa de n numere. Se cere sa se determine daca
    // este o secventa bitonica rotita.
    /// </summary>


    static void P16()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";

        string previous = "";
        string current = "";

        int k = 0;
        bool ok = true;

        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current += abc;
            else
            {
                if (current != "")
                {
                    if (previous == "")
                    {
                        previous = current;
                        current = "";
                        continue;
                    }

                    int intprev = int.Parse(previous);
                    int intcur = int.Parse(current);

                    if (intcur < intprev)
                        k++;

                    if (k == 1 || k == 3)
                    {
                        if (intcur > intprev)
                            ok = false;
                    }

                }

                previous = current;
                current = "";

            }
        }

        if (ok)
            Console.WriteLine("E secventa bitonica rotita");
        else
            Console.WriteLine("Nu e secventa bitonica rotita");
    }


    /// <summary>
    /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza
    /// deschisa si 1 inseamna paranteza inchisa.
    /// Determinati daca secventa reprezinta o secventa de paranteze
    /// corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.
    /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2
    /// pe cand 0 0 1 1 1 0 este incorecta.
    /// </summary>
    static void P17()
    {
        Console.Write("Introduceti secventa: ");
        string secv = Console.ReadLine() + " ";


        int incuibare = 0, maxincuibare = 0;

        bool eCorecta = true;
        string current = "";
        foreach (char abc in secv)
        {
            if (abc != ' ' && abc != ',')
                current = Convert.ToString(abc);

            else
            {
                if (current == "0")
                    incuibare += 1;
                else if (current == "1")
                    incuibare -= 1;

                if (incuibare < 0)
                    break;

                if (incuibare > maxincuibare)
                    maxincuibare = incuibare;
            }
        }
        if (incuibare != 0)
            eCorecta = false;

        if (eCorecta)
            Console.WriteLine($"Secventa e corecta si nivelul maxim de incuibare: {maxincuibare}");
        else
            Console.WriteLine("Secventa nu e corecta");
    }
}

