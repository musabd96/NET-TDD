# FizzBuzz - TDD övning

## Innan du börjar
- Försök att inte läsa framåt.
- Gör **ett steg/krav i taget**. Meningen är att lära sig att arbeta stegvis.
- Testa först!

## STEG/KRAV 1:
Skriv en funktion som tar ett tal som ett argument och, baserat på scenarierna som beskrivs nedan, returnerar `"Fizz"`, `"Buzz"`, `"FizzBuzz"` eller det numret.

    - Om talet är delbart med 3, returnera `"Fizz"`.
    - Om talet är delbart med 5, returnera `"Buzz"`.
    - Om talet är delbart med både 3 och 5, returnera `"FizzBuzz"`.
    - Om inget av ovanstående gäller, returnera numret som det är.

### Sample output:
```console
- 1 => "1"
- 2 => "2"
- 3 => "Fizz"
- 4 => "4"
- 5 => "Buzz"
- 6 => "Fizz"
- 10 => "Buzz"
- 11 => "11"
- 15 => "FizzBuzz"
```

-----------------------------------------------------------------------------------------------------------------------

## STEG/KRAV 2: 
Skriv en funktion som tar ett tal som ett argument och, baserat på samma scenarier som beskrivs ovan, skriver ut talet.

-----------------------------------------------------------------------------------------------------------------------

## STEG/KRAV 3: 
Skriv en funktion som tar användarinput och skriver ut det numret, baserat på samma scenarier som beskrivs ovan.
    - Om användarinmatning inte är ett nummer, släng ett undantag med meddelandet: `"{inputNumber} är inte ett nummer"`.

-----------------------------------------------------------------------------------------------------------------------
   
## STEG/KRAV 4:
Refaktorera denna kod så att det är mycket enkelt att lägga till den nya funktionen. "Gör förändringen lätt, gör sedan den enkla förändringen".

-----------------------------------------------------------------------------------------------------------------------

### Bonus STEG/KRAV
Förutom att multiplar av 3 är "Fizz" och multiplar av 5 är "Buzz":

Multiplar av 7 är "Whizz"
Multiplar av 11 är "Bang"

Det betyder till exempel att multiplar av 3 & 7 är "FizzWhizz", multiplar av 5 & 11 är "BuzzBang" osv.

### Sample output:
```console
- 1 => "1"
- 2 => "2"
- 3 => "Fizz"
- 4 => "4"
- 5 => "Buzz"
- 6 => "Fizz"
- 7 => "Whizz"
- 8 => "8"
- 9 => "Fizz"
- 10 => "Buzz"
- 11 => "Bang"
- 12 => "Fizz"
- 13 => "13"
- 14 => "Whizz"
- 15 => "FizzBuzz"
- 21 => "FizzWhizz"
- 55 => "BuzzBang"
- 105 => "FizzBazzWhizz"
- 165 => "FizzBuzzBang"
- 231 => "FizzWhizzBang"
- 1155 => "FizzBazzWhizzBang"
```

-----------------------------------------------------------------------------------------------------------------------

# Cheat Sheet

## Mocking Console

### C#

```csharp
public void LogMessage(Service service, string message)
{
    Console.WriteLine($"Service {service.name}: {message}");
}
```

```csharp
[TestMethod]
public void LogMessage_WritesMessageToConsole()
{
    StringWriter stringWriter = new StringWriter();
    Console.SetOut(stringWriter);
    var expected = "Service AuthService: Login successful";

    LogMessage("AuthService", "Login successful");
    var actuall = stringWriter.ToString().Trim();

    Assert.AreEqual(expected, actuall);
}
```

-----------------------------------------------------------------------------------------------------------------------

## Using parametrized / data-driven tests

Om du behöver utföra samma test med olika ingångar, istället för att skriva flera test, kan du använda parametriserade tester.

### C#
I C# kan du uppnå detta genom att lägga till "[DataTestMethod]"-attribut istället för "TestMethod" och lägga till flera "[DataRow]"-attribut som ger indata till testet. Detta gör att testet kan köras flera gånger med olika ingångar.

```csharp
[DataTestMethod]
[DataRow(1)]
[DataRow(2)]
[DataRow(3)]
public void TestName(int number)
{
    var result = GetNumber(number);
    Assert.AreEqual(number, result);
}
```

Om du behöver din indata för att kunna återanvändas kan du skapa en egenskap av typen `IEnumerable<object[]>` och lägga till `[DynamicData]`-attributet till ditt test, för att ange var ditt test kommer att ta emot data från.

```csharp
public static IEnumerable<object[]> MyNumbers => new[]
{
    new object[] { 1 },
    new object[] { 2 },
    new object[] { 3 },
};

[TestMethod]
[DynamicData(nameof(MyNumbers))]
public void TestName(int number)
{
    var result = GetNumber(number);
    Assert.AreEqual(number, result);
}
```
