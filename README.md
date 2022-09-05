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

---
# Planning the parallel operation of transformers - Tran 2020 🇬🇧
