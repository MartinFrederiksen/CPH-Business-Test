# Assignment 2

## 1. Reflections
### 1.1 Computer mouse
Identify the types of testing you would perform on a computer mouse, to make sure that it is of the highest quality.
- Tjek om musen er optisk eller ej. Normalt vil en optisk mus ikke have behov for rensning. I hvert fald ikke særlig meget da der ikke er nogen bevægelige dele ligesom de gamle modeller der brugte en kugle. En kugle mus har lettere ved at samle støv og andre ting.
- Tjek om både højre og venstre klik virker korrekt. Registrere computeren disse kliks?
- Tjek om dobbelt klik funktionen fungere korrekt. Tjek tiden i mellem kliks for at finde ud af hvad der er et dobbelt klik.
- Test scrollhjulet på musen. Scroller den i den rigtige retning som er specificeret af indstillingerne.
- Hvis der er side knapper så tjek om disse fungere korrekt.
- Tjek om bevægelse bliver overført korrekt til cursoren på computeren. Når musen bliver bevæget op ad, bevæger cursoren sig så også op ad?
- Tjek bygge kvaliteten af musen så som vægt, materialer, er der en raslen fra musen hvis du ryster den?
- Tjek formen på musen. Er det en højre, venstre hånds mus eller begge dele? Er størrelsen korrekt, kan du holde ordenligt på musen?
- Hvis musen er trådløs så test levetiden på batteriet.

### 1.2 Catastrophic failure
Find a story where a software system defect had a bad outcome. Describe what happened. Can you identify a test that would have prevented it?
- [Link 1 besøgt 28/09/21][https://solarsystem.nasa.gov/missions/mars-climate-orbiter/in-depth/]
- [Link 2 besøgt 28/09/21][https://en.wikipedia.org/wiki/Mars_Climate_Orbiter]

Historien:
The Mars climate orbiter was launched by NASA on december 11, 1998 and was supposed to study the martian climate, martian atmosphere and surface changes. However NASA permanently lost contact to the spacecraft on september 23, 1999 as it was about to enter orbit insertion. The spacecraft encountered Mars on a trajectory that got it too close to the planet, and it was either destroyed in the atmosphere or escaped the planet’s vicinity and entered an orbit around the sun. An investigation attributed the failure to a measurement mismatch between two software systems: metric units by NASA and imperial units by spacecraft builder Lockheed Martin. 

Tests:
Den mest åbenbare test der kunne være implementeret ville være at sammenligne de målinger NASA lavede med dem Martin lavede. Ved at køre en serie af tests for at sikre at de forskellige variationer af metrisk data var omdannet korrekt til empirisk data og den anden vej rundt. Disse tests ville sikre at beregningerne der er lavet af begge hold var korrekt oversat eftersom det aldrig er givet at en offentlig organisation og verdens største rumfarts virksomhed kan kommunikere sammen.

Dette kan godt være lidt simplificeret, eftersom beregningerne som både NASA og Martin lavede er ret kompleks. Tests ville have hjulpet men "rocket science" kræver detaljerede og præcise udregninger som holdene nok skulle have opstillet nogle standarder for på forhånd

## 2. Two Katas
Complete the following using TDD. Remember the TDD mantra.
### 2.1 String Utility
- [String Utility Tests](./assignment-02.Tests/StringUtilityTest.cs)
- [String Utility Metoder](./assignment-02/StringUtility.cs)

### 2.2 Bowling Game Kata
- [Bowling Game Test](./assignment-02.Tests/BowlingGameTest.cs)
- [Bowling Game Metoder](./assignment-02/BowlingGame.cs)

### How to run
#### Use dotnet cli
```
dotnet test
```

## 3. Investigation of tools
### 3.1 JUnit 5
Investigate JUnit 5 (Jupiter). Explain the following, and how they are useful.
- @Tag: Tests kan blive tagget med et brugerdefineret tag. Du kan knytte et tag til alle integrations tests og unit tests. Du kan vælge at eksekvere alle tags med samme tag navn så du kan eksempelvis vælge at køre alle unit tests. På denne måde kan du filtrere ved at bruge forskellige tags.
- @Disabled: Du kan deaktivere specifikke tests. Dette kan være en nyttig ting hvis du har oprettet en test uden funktionalitet 
- @RepeatedTest: Testen er eksekveret x antal gange. Dette er smart hvis du vil have flere iterationer af samme test.
- @BeforeEach, @AfterEach: BeforeEach er brugt på metoder der indeholder noget kode som skal eksekveres før hver test. AfterEach er brugt på metoder der indeholder noget kode som skal eksekveres efter hver test. Dette kan fx være nyttigt i forbindelse med data i en database.
- @BeforeAll, @AfterAll: Disse er næsten ligesom BeforeEach og AfterEach, men her er der bare tale om hele test klassen. Igen er dette nyttigt i forbindelse med database.
- @DisplayName: Denne notation bruges til at vise brugerdefineret tekst fra en test klasse eller metode. Dette kan være nyttigt i forhold til at kunne printe navnet på den test der er ved at blive kørt.
- @Nested: Denne notation giver testeren mulighed for at oprette en indre test i sin test klasse. Derved bliver det nemmere at gruppere tests i en test suite, hvilket skaber et bedre overblik og organisering.
- assumeFalse, assumeTrue: Disse bruges til at validere antagelser. Hvis en antagelse fejler vil testen blive "smidt væk" i stedet for at give en fejl som vi ser med assert.

### 3.2 Mocking frameworks
Investigate mocking frameworks for your preferred language. Choose at least two frameworks, and answer the questions. (One could be Mockito, which we saw in class.)
- What are their similarities?
- What are their differences?
- Which one would you prefer, if any, and why?
