⚠️WIP⚠️
# Planowanie pracy równoległej transformatorów - Tran 2020 🇵🇱
## Wstęp
W ramach mojej pracy inżynierskiej stworzyłem program służący do obliczania warunków pracy równoległej transformatorów. Ten program jest aktualizacją znacznie starszego programu który wykonywał owe zadanie. Oryginalny program, Tran, był programem oknowym napisanym w roku 1993 w języku Pascal. Ze względu na wymagania sprzętowe uruchomienie tego programu na nowym komputerze wymaga emulacji starszego systemu operacyjnego. Nowa wersja programu, Tran 2020, napisana została prze ze mnie w roku 2020 w języku C#. Nowy program jest programem oknowym obsługiwanym przez system operacyjny Windows 10 bez potrzeby emulacji.
## Praca równoległa transformatorów
W systemie energetycznym potrzebne jest zapewnienie niezawodnego dostarczania energii ze źródła do odbiorców. Różne rozwiązania pomagają w osiągnięciu niezawodności, m. in. systemy zasilania zastępczego, zdalne przełączanie linii przesyłowych, przenoszenie obciążenia na wiele źródeł zasilenia oraz równoległa praca transgformatorów. Równoległa praca transformatorów polega na wspólnym zasileniu kilku transformatorów na wspólnych szynach pierwotnych i wtórnych. To podejście stosuje sie głównie przy kontroli obciążenia zmiennego.

W trakcie dnia obciążenie zmienia się ze względu na zachowanie odbiorców. Różnica pomiędzy zapotrzebowaniem dziennym a nocnym jest bardzo duża. Rano tylko część odbiorców wymaga zasilania, z czasem zapotrzebowanie rośnie i dochodzi do szczytu w środku dnia. Potem zapotrzebowanie stopniowo spada, wieczorem jest mały szczyt wynikający z powrotów do domów a potem całkowicie spada do poziomu nocnego. W tak zmiennych warunkach stosowanie jednej konfiguracji transformatorów powoduje duże straty mocy. Z tego powodu w trakcie dnia przełącza się konfigurację transformatorów zasilających. Nie można jednak byle jak przełączać transformatorów - należy najpierw sprawdzić czy zgadzają się warunki pracy równoległej.

Istnieją cztery warunki niezbędne do pracy równoległej transformatorów:
- Zgodność napięć pierwotnych i wtórnych do 0.5%
- Zgodność prądów zwarć do 10%
- Stosunek mocy znamionowych mniejszy niż 3 / większy niż 1/3
- Zgodność grup transformatorów

Warunki niezbędne są jednak tylko częścią pierwszą. Proces decyzyjny polega nie tylko na sprawdzeniu która konfiguracja działa, ale również kiedy występują minimalne straty mocy. W tym celu oblicza się również moce obciążeniowe poszczególnych transformatorów. Te dwa zadania są główną częścią obliczeniową programu.
## Obliczenia
Samo sprawdzenie warunków pracy jest proste - wystarczy porównać ze sobą kolejne parametry oraz zdecydować czy ich różnica jest w granicach wymaganych. Obliczenie obciążeń transformatorów wymaga przekształceń matematycznych z generalnego modelu połączenia równoległego transformatorów:

![Parallel](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/3.1.png)

Jeśli transformatory mają równe napięcia znamionowe, to oznacza że stosunek ich impedancji jest równy stosunkowi przepływających przez nie prądów:

![e1](http://www.sciweavers.org/tex2img.php?eq=%20%5Cfrac%7BZ_%7Bk2%7D%7D%7BZ_%7Bk1%7D%7D%20%3D%20%5Cfrac%7BI_1%7D%7BI_2%7D%20&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

Po stronie mocy mnożymy przez prądy znamionowe, uzyskując napięcia:

![e2](http://www.sciweavers.org/tex2img.php?eq=%20%5Cfrac%7BZ_%7Bk2%7D%7D%7BZ_%7Bk1%7D%7D%20%20%5Cfrac%7BI_%7BN2%7D%7D%7BI_%7BN1%7D%7D%20%20%5Cfrac%7BI_%7BN1%7D%7D%7BI_%7BN2%7D%7D%20%3D%20%5Cfrac%7BI_1%7D%7BI_2%7D%20&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

![e3](https://bit.ly/3qbZD85)

Z definicji mocy znamionowych stosunki prądów zastępujemy mocami transformatorów. Wprowadzenie dodatkowego symbolu S = S1 + S2 pozwala na wyznaczenie wzoru na obciążenie transformatora S1:

![e4](https://bit.ly/3cLATR5)

![e5](http://www.sciweavers.org/tex2img.php?eq=%20%5Cfrac%7BU_%7Bk2%7D%7D%7BU_%7Bk1%7D%7D%20%20%5Cfrac%7BS_%7BN1%7D%7D%7BS_%7BN2%7D%7D%20%3D%20%5Cfrac%7BS_1%7D%7BS-S_1%7D%20&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

![e6](http://www.sciweavers.org/tex2img.php?eq=%20%5Cfrac%7BS-S_1%7D%7BS_1%7D%3D%20%5Cfrac%7BU_%7Bk1%7D%7D%7BU_k2%7D%20%5Cfrac%7BS_%7BN2%7D%7D%7BS_%7Bn1%7D%7D%20%20%20&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

![e7](https://bit.ly/3RhiR8k)

![e8](http://www.sciweavers.org/tex2img.php?eq=S%3DS_1%28%20%5Cfrac%7BU_%7Bk1%7D%7D%7BU_k2%7D%20%5Cfrac%7BS_%7BN2%7D%7D%7BS_%7Bn1%7D%7D%29%2BS_1&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

![e9](https://bit.ly/3wTpjdd)

![e10](http://www.sciweavers.org/tex2img.php?eq=S%3DS_1%28%20%5Cfrac%7BU_%7Bk1%7D%7D%7BU_%7Bk2%7D%7D%20%5Cfrac%7BS_%7BN2%7D%7D%7BS_%7Bn1%7D%7D%2B%20%5Cfrac%7BU_%7Bk2%7DS_%7BN1%7D%7D%7BU_%7Bk2%7DS_%7BN1%7D%7D%20%29&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

![e11](https://bit.ly/3CVh9Fe)

![e12](http://www.sciweavers.org/tex2img.php?eq=S_1%3DS%28%20%5Cfrac%7BU_%7Bk2%7DS_%7BN1%7D%7D%7BU_%7Bk1%7DS_%7BN2%7D%2BU_%7Bk2%7DS_%7BN1%7D%7D%20%29&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

![e13](https://bit.ly/3wXfCuF)

![e14](http://www.sciweavers.org/tex2img.php?eq=S_1%3DS%28%20%5Cfrac%7B%5Cfrac%7BS_%7BN1%7D%7D%7BU_k1%7D%7D%7B%5Cfrac%7BS_%7BN2%7D%7D%7BU_%7Bk2%7D%7D%20%2B%20%5Cfrac%7BS_%7BN1%7D%7D%7BU_%7Bk1%7D%7D%7D%20%29&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0)

Można udowodnić że powyższy wzór jest generalny - dla większej ilości transformatorów wystarczy w mianowniku zsumować iloczyny mocy i napięć dla wszystkich transformatorów:

![e15](https://bit.ly/3cM06Lb)

W porównaniu z powyższym obliczenia strat mocy są proste. Jednak ten proces jest znacznie bardziej czasochłonny. Straty mocy oblicza się jako suma strat jałowych (stałe, niezależne od obciążenia) i strat obciążeniowych (zmienne, zależne od obciążenia). Komplikacja wynika z tego, że straty oblicza się dla wszystkich możliwych kombinacji połączeń transformatorów. Ilość obliczeń wzrasta eksponencjalnie z ilością transformatorów. Dokładniej ilość kombinacji = 2 ^ ilości transformatorów. Z tego powodu obliczenia strat warto wykonywać tylko komputerowo.

![e16](https://bit.ly/3cL7QNm)

## Tran
Oryginalny program Tran był programem konsolowym, gdzie wpisywało się dane 'liniowo'. Ograniczał się on do maksymalnie 5 transformatorów, nie dało się szybko zmienić danych transformatorów a wyniki obliczeń były dostępne w dwóch częściach. Obciążenia transformatorów pokazywały się od razu, ale straty mocy były niedostępne w konsoli - w celu ich zobaczenia trzeba było je wydrukować. Jak widać, program wymagał całkowitej modernizacji i przetworzenia na nowoczesne standardy.

![Tran](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/4.1.png)

## Tran 2020
Program Tran 2020 jest pełną modernizacją programu Tran. Jest to program oknowy napisany w języku C#. Użytkownik może wybrać dowolną ilość transformatorów, wpisać ich dane w dowolnej kolejności oraz wyświetlić wyniki obliczeń od razu.

![Tran 2020 Main](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.4.png)

![Tran 2020 Results](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.5.png)

Dodatkowo, Tran 2020 posiada szereg udogodnień i funkcji. Użytkownik może prawym przyciskiem myszki wybrać z listy jaki transformator chce dodać. Wyniki obliczeń można zapisać do schowka lub zapisać jako osobny plik. Istnieje też opcja 'połowicznego eksportu' - zapisanie danych w pliku .txt który łatwo można otworzyć w Excelu.

![Tran 2020 Tooltip](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.3.png)

![Tran 2020 Saved Results](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.6.png)

![tran 2020 Excel](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/7.9.png)

Porównanie wyników obliczeń z obu programów potwierdza, że nowy program działa prawidłowo. Aktualizacja zakończyła się sukcesem.

Głębsza analiza zagadnienia, pełna analiza kodów obu programów oraz wykonane testy są dostępne w mojej ![pracy inżynierskiej](https://github.com/Kacper-Hoffman/Parallel-Operation/blob/main/RE000000-95009-INZ.pdf).

---
# Planning the parallel operation of transformers - Tran 2020 🇬🇧
