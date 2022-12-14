# Planowanie pracy r贸wnoleg艂ej transformator贸w - Tran 2020 馃嚨馃嚤
## Wst臋p
W ramach mojej pracy in偶ynierskiej stworzy艂em program s艂u偶膮cy do obliczania warunk贸w pracy r贸wnoleg艂ej transformator贸w. Ten program jest aktualizacj膮 znacznie starszego programu kt贸ry wykonywa艂 owe zadanie. Oryginalny program, Tran, by艂 programem oknowym napisanym w roku 1993 w j臋zyku Pascal. Ze wzgl臋du na wymagania sprz臋towe uruchomienie tego programu na nowym komputerze wymaga emulacji starszego systemu operacyjnego. Nowa wersja programu, Tran 2020, napisana zosta艂a prze ze mnie w roku 2020 w j臋zyku C#. Nowy program jest programem oknowym obs艂ugiwanym przez system operacyjny Windows 10 bez potrzeby emulacji.
## Praca r贸wnoleg艂a transformator贸w
W systemie energetycznym potrzebne jest zapewnienie niezawodnego dostarczania energii ze 藕r贸d艂a do odbiorc贸w. R贸偶ne rozwi膮zania pomagaj膮 w osi膮gni臋ciu niezawodno艣ci, m. in. systemy zasilania zast臋pczego, zdalne prze艂膮czanie linii przesy艂owych, przenoszenie obci膮偶enia na wiele 藕r贸de艂 zasilenia oraz r贸wnoleg艂a praca transgformator贸w. R贸wnoleg艂a praca transformator贸w polega na wsp贸lnym zasileniu kilku transformator贸w na wsp贸lnych szynach pierwotnych i wt贸rnych. To podej艣cie stosuje sie g艂贸wnie przy kontroli obci膮偶enia zmiennego.

W trakcie dnia obci膮偶enie zmienia si臋 ze wzgl臋du na zachowanie odbiorc贸w. R贸偶nica pomi臋dzy zapotrzebowaniem dziennym a nocnym jest bardzo du偶a. Rano tylko cz臋艣膰 odbiorc贸w wymaga zasilania, z czasem zapotrzebowanie ro艣nie i dochodzi do szczytu w 艣rodku dnia. Potem zapotrzebowanie stopniowo spada, wieczorem jest ma艂y szczyt wynikaj膮cy z powrot贸w do dom贸w a potem ca艂kowicie spada do poziomu nocnego. W tak zmiennych warunkach stosowanie jednej konfiguracji transformator贸w powoduje du偶e straty mocy. Z tego powodu w trakcie dnia prze艂膮cza si臋 konfiguracj臋 transformator贸w zasilaj膮cych. Nie mo偶na jednak byle jak prze艂膮cza膰 transformator贸w - nale偶y najpierw sprawdzi膰 czy zgadzaj膮 si臋 warunki pracy r贸wnoleg艂ej.

Istniej膮 cztery warunki niezb臋dne do pracy r贸wnoleg艂ej transformator贸w:
- Zgodno艣膰 napi臋膰 pierwotnych i wt贸rnych do 0.5%
- Zgodno艣膰 pr膮d贸w zwar膰 do 10%
- Stosunek mocy znamionowych mniejszy ni偶 3 / wi臋kszy ni偶 1/3
- Zgodno艣膰 grup transformator贸w

Warunki niezb臋dne s膮 jednak tylko cz臋艣ci膮 pierwsz膮. Proces decyzyjny polega nie tylko na sprawdzeniu kt贸ra konfiguracja dzia艂a, ale r贸wnie偶 kiedy wyst臋puj膮 minimalne straty mocy. W tym celu oblicza si臋 r贸wnie偶 moce obci膮偶eniowe poszczeg贸lnych transformator贸w. Te dwa zadania s膮 g艂贸wn膮 cz臋艣ci膮 obliczeniow膮 programu.
## Obliczenia
Samo sprawdzenie warunk贸w pracy jest proste - wystarczy por贸wna膰 ze sob膮 kolejne parametry oraz zdecydowa膰 czy ich r贸偶nica jest w granicach wymaganych. Obliczenie obci膮偶e艅 transformator贸w wymaga przekszta艂ce艅 matematycznych z generalnego modelu po艂膮czenia r贸wnoleg艂ego transformator贸w:

![Parallel](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/3.1.png)

Je艣li transformatory maj膮 r贸wne napi臋cia znamionowe, to oznacza 偶e stosunek ich impedancji jest r贸wny stosunkowi przep艂ywaj膮cych przez nie pr膮d贸w:

![e1](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e1.png)

Po stronie impedancji mno偶ymy przez pr膮dy znamionowe, uzyskuj膮c napi臋cia:

![e2](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e2.png)

Z definicji mocy znamionowych stosunki pr膮d贸w zast臋pujemy mocami transformator贸w. Wprowadzenie dodatkowego symbolu S = S1 + S2 pozwala na wyznaczenie wzoru na obci膮偶enie transformatora S1. Mo偶na udowodni膰 偶e ko艅cowy wz贸r jest generalny - dla wi臋kszej ilo艣ci transformator贸w wystarczy w mianowniku zsumowa膰 iloczyny mocy i napi臋膰 dla wszystkich transformator贸w.

![e3](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e3.png)

![e4](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e4.png)

![e5](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e5.png)

W por贸wnaniu z powy偶szym obliczenia strat mocy s膮 proste. Jednak ten proces jest znacznie bardziej czasoch艂onny. Straty mocy oblicza si臋 jako suma strat ja艂owych (sta艂e, niezale偶ne od obci膮偶enia) i strat obci膮偶eniowych (zmienne, zale偶ne od obci膮偶enia). Komplikacja wynika z tego, 偶e straty oblicza si臋 dla wszystkich mo偶liwych kombinacji po艂膮cze艅 transformator贸w. Ilo艣膰 oblicze艅 wzrasta eksponencjalnie z ilo艣ci膮 transformator贸w. Dok艂adniej ilo艣膰 kombinacji = 2 ^ ilo艣ci transformator贸w. Z tego powodu obliczenia strat warto wykonywa膰 tylko komputerowo.

![e6](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e6.png)

## Tran
Oryginalny program Tran by艂 programem konsolowym, gdzie wpisywa艂o si臋 dane 'liniowo'. Ogranicza艂 si臋 on do maksymalnie 5 transformator贸w, nie da艂o si臋 szybko zmieni膰 danych transformator贸w a wyniki oblicze艅 by艂y dost臋pne w dw贸ch cz臋艣ciach. Obci膮偶enia transformator贸w pokazywa艂y si臋 od razu, ale straty mocy by艂y niedost臋pne w konsoli - w celu ich zobaczenia trzeba by艂o je wydrukowa膰. Jak wida膰, program wymaga艂 ca艂kowitej modernizacji i przetworzenia na nowoczesne standardy.

![Tran](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/4.1.png)

## Tran 2020
Program Tran 2020 jest pe艂n膮 modernizacj膮 programu Tran. Jest to program oknowy napisany w j臋zyku C#. U偶ytkownik mo偶e wybra膰 dowoln膮 ilo艣膰 transformator贸w, wpisa膰 ich dane w dowolnej kolejno艣ci oraz wy艣wietli膰 wyniki oblicze艅 od razu.

![Tran 2020 Main](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.4.png)

![Tran 2020 Results](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.5.png)

Dodatkowo, Tran 2020 posiada szereg udogodnie艅 i funkcji. U偶ytkownik mo偶e prawym przyciskiem myszki wybra膰 z listy jaki transformator chce doda膰. Wyniki oblicze艅 mo偶na zapisa膰 do schowka lub zapisa膰 jako osobny plik. Istnieje te偶 opcja 'po艂owicznego eksportu' - zapisanie danych w pliku .txt kt贸ry 艂atwo mo偶na otworzy膰 w Excelu.

![Tran 2020 Tooltip](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.3.png)

![Tran 2020 Saved Results](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.6.png)

![tran 2020 Excel](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.9.png)

Por贸wnanie wynik贸w oblicze艅 z obu program贸w potwierdza, 偶e nowy program dzia艂a prawid艂owo. Aktualizacja zako艅czy艂a si臋 sukcesem.

G艂臋bsza analiza zagadnienia, pe艂na analiza kod贸w obu program贸w oraz wykonane testy s膮 dost臋pne w mojej [pracy in偶ynierskiej](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/RE000000-95009-INZ.pdf).

---
# Planning the parallel operation of transformers - Tran 2020 馃嚞馃嚙
## Introduction
As part or my engineering thesis, I have created a program used for planning the parallel operation of transformers. This program is a modernization of an older program which used to preform this task. The original program, Tran, was written in 1993 in Pascal. Due to its system requirements, running it on a modern computer required emulating an older operating system. The new version of this program, Tran 2020, was written by me in 2020 in C#. The new program is a window application that can run on Windows 10 without the need for emulation.
## Parallel operation of transformers
In the power system there is a necessity to ensure total reliability of power supply. Different solutions help with achieving high reliability, ex. backup power systems, remote switching of power lines, distributing the load on many sources and parallel operation of transformers. Parallel operation of transformers occurs when multiple transformers are connected to the same busbars. This solution can be used in the case of highly variable loads.

During the day the load changes due to the behaviour of recievers. The difference between day load and night load is very large. In the morning only some recievers need power, but with time the need grows and reaches peak during midday. Then the load falls, leading to a much smaller evening peak and finally settling at the night low. With such changing loads using only one configuration of transformers leads to high power losses. Because of this during day the configuration of transformers changes to reach minimum losses. However, you cannot switch configurations in just any way - there are conditions which must be satisfied first.

There are four main condition for the parallel operation of transformers:
- Equality of primary and secondary voltages down to 0.5%
- Equality of short circuit currents down to 10%
- Ratio or transformer powers is lower than 3 / higher than 1/3
- Equality of transformer goups

Necessary conditions are only the first part. Decision process requires not only finding a configuration that works, but also findinf an optimal minimum of losses. Because of this we calculate the relative loads of each transformer. Those two tasks are the main part of the program's calculations.
## Calculations
Checking the conditions is easy - simply take the values of all transformers and check if their differences are within range. Calculating the loads of transformers requires mathematical transformations from the general model of parallel transformers:

![Parallel](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/3.1.png)

If the transformers have the same voltages, then the ratios of their impedances and currents must be equal:

![e1](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e1.png)

Multiplying the impedance side by currents we get voltages:

![e2](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e2.png)

From the definition of transformer power we replace ratios of currents with their powers. Using the additional symbol S = S1 + S2 allows us to calculate load S1. It's possible to prove that the final equation is general - simply replace the demominator with the sum of ratios.

![e3](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e3.png)

![e4](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e4.png)

![e5](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e5.png)

In comparison calculating losses is easy. However, this prosecc is actually more time consuming. Power losses are the sum of idle losses (constant, independent of load) and load losses (variable, dependent of load). Complication arise from the fact that losses must be calculated for each combination of transformers. The number of calculations increases exponentially. To be percise, the number of calculations = 2 ^ number of transformers. Because of this it's only worth it to perform these calculations programmatically.

![e6](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/e6.png)

## Tran
The originat program was a console application, where you input information 'linearly'. It was limited to 5 transformers, you couldn't quickly change transformer data and calculation results were available in two parts. Loads were visible immediately, but losses were inaccessible through console - in order to view them you had to print them. As you can see, this program needed modernization for modern standards.

![Tran](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/4.1.png)

## Tran 2020
Program Tran 2020 is a full modernization of Tran. It's a window application written in C#. The user can choose any number of transformers, input their data in any order and view calculation results immediately.

![Tran 2020 Main](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.4.png)

![Tran 2020 Results](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.5.png)

Additionally, Tran 202 possesses a set of accessibility upgrades. The user can right click to choose a transformer to be added. Results can be saved to clipboard or a seperate file. There is also the option of 'half export' - produce a .txt file that you can easly open in Excel.

![Tran 2020 Tooltip](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.3.png)

![Tran 2020 Saved Results](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.6.png)

![tran 2020 Excel](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.9.png)

Comparing results confirms that the new program functions correctly. The modernization was succesful.

Deeper analisys of the topic, full analisys of code as well as tests are available in my [engineering thesis (馃嚨馃嚤 only)](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/RE000000-95009-INZ.pdf).
