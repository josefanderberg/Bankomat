🎯 Syfte
Denna övning ger träning i:

- Objektorienterad programmering (OOP) i C# (klasser, objekt, metoder, properties).
- Inkapsling: skydda data med private fields och exponera dem via properties/metoder.
- Kontrollstrukturer & input/output i en konsolapplikation.
- Källkodshantering med Git (repo, commits, inlämning via Learnpoint).

📚 Koppling till lärandemål i kursplanen Programmering grund
- Kunskaper i att: förklara konstruktion av enkla program innehållande kontrollstrukturer.
- Färdigheter i att: konstruera enkla program, hantera input/output, använda samlingsklasser.
- Färdigheter i att: använda Git för enklare källkodshantering.

🧩 Kravspecifikation

Funktionalitet

-- Vid programstart: användaren måste ange en fyrsiffrig PIN-kod.
- PIN jämförs mot en hårdkodad konstant i en Customer-klass.
-- När PIN är korrekt ska en meny visas med följande val:
1. Sätt in pengar
2. Ta ut pengar
3. Visa saldo
4. Avsluta
Validering:
- Uttag får inte överstiga saldo.
- Belopp måste vara > 0 och numeriska.

#OOP-struktur

++ BankAccount
- private decimal balance;
- public decimal Balance { get; } (read-only property).
- Deposit(amount), Withdraw(amount) med validering.
++ Person
- Namn och personnummer som readonly properties.
Customer
Kopplar Person + BankAccount + PIN.
Authenticate(pin) → returnerar true/false.

Git-krav
- Projektet ska versionshanteras med Git.
- Minst 5 commits med beskrivande meddelanden.
- Repo ska innehålla en README.md med:
Kort beskrivning av projektet.
Instruktioner för att köra (dotnet run).
Beskrivning av OOP/inkapsling i projektet.

Inlämning
Länka till ditt GitHub-repo i Learnpoint-kommentaren.

📘 Kodexempel (skelett)
class BankAccount
{
    private decimal balance;
    public decimal Balance => balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0) balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }
}

Studenterna förväntas bygga ut Person, Customer och Program (ATM) själva utifrån kravspecifikationen.

🏆 Bedömning
Godkänt (G)
Bankomat med PIN, meny och funktionerna insättning/uttag/saldo.
Inkapsling används (private balance + property/metoder).
Program körbart i konsolen.
Git-repo med README och commit-historik.

Väl godkänt (VG)
Extra validering och felhantering.
Kod uppdelad i flera klasser med tydlig struktur.
README innehåller förklaring av inkapsling i egna ord.
Git-logg visar logiska, välbeskrivna commits.
