
Model danych:
Rozwi¹zanie wykorzystuje Entity Framework 6, podejœcie Code First, st¹d diagram ERD nie by³ potrzebny.
Diagram wygenerowany przez Entity Framework 6 i wyœwietlony dziêki Entity Framework Power Tools bêdzie za³¹czony do wys³anego rozwi¹zania.

Generacja klas z diagramu:
Klasy logiki biznesowej zosta³y wygenerowane przez Visual Paradigm z diagramu klas o nazwie "Model do kreacji ERD/klas".
Wynikiem tej generacji s¹ te¿ wykomentowane atrybuty zwi¹zane z t¹ czêœci¹ logiki biznesowej, która nie jest zaimplementowana 
(Mimo wybrania opcji generowania tylko potrzebnych klas, wybór ten tworzy wszystkie asocjacje, które s¹ zapamiêtane w projekcie Visual Paradigm)

Informacje o wzorcu projektowym:
Wykorzystany zosta³ wzorzec Repozytorium, który u³atwia po³¹czenia z baz¹ danych. 
Chocia¿ w standardowej jego wersji tworzy siê repozytoria dla ka¿dej relacji w bazie danych, 
tutaj do wiêkszoœci klas zastosowa³am jego generyczn¹ postaæ, na któr¹ pozwala C# i EF6. 
Osobne repozytoria tworzy³am dla wykorzystywanych przeze mnie w przypadkach u¿ycia klas, 
w szczególnoœci takich, które wymaga³y przy poleceniu SELECT za³¹czenia(Include()) swoich potomków.

Dokumentacja:
Zosta³a wygenerowana dla projektow: Uslugi, Logika Biznesowa
i zapisana w folderze ../nazwaProjektu/html w formacie html.
Projekt Uslugi ma kompletna dokumentacje dla kazdej klasy. 
Projekt Logika Biznesowa zawiera pe³n¹ dokumentacje dla klasy Propozycja_zamiennika.
Uwaga: Musia³am usun¹æ polskie znaki, poniewa¿ generowana dokumentacja nie wyœwietla³a	ich. Nie da³o siê te¿ wygenerowaæ dokumentacji dla ca³ego rozwi¹zania.


Logika biznesowa: 
Zauwa¿y³am ró¿nice w traktowaniu kursów przez ró¿ne wydzia³y: 
jedne wydzia³y traktuj¹ Grupê Kursów w Planie Studiów jak jeden kurs - nadaj¹ jeden kod kursu, wspólne efekty kszta³cenia, wspólne punkty ects i wspólne godziny zzu; 
a inne wydzia³y nadaj¹ te cechy ka¿demu kursowi w grupie kursów z osobna.
Aby da³o siê pogodziæ oba rozwi¹zania, przyjê³am, ¿e jeœli Grupa Kursów jest przez wydzia³ traktowana jak jeden przedmiot, 
tak te¿ bêdzie trakowana w aplikacji i zapisywana jako kurs z Form¹ Kursu np. WykladCwiczenia.
Poniewa¿ jest tak na Wydziale Informatyki i Zarz¹dzania, to wiêkszoœæ grup kursów jest wpisana w ten sposób.
Klasa "Grupa_kursow" jest wykorzystywana dla wydzia³ów takich jak na przyk³ad Wydzia³ Elektroniki, gdzie kursy maja odrebne kody i w³asne efekty kszta³cenia.

Przyjê³am te¿, ¿e chocia¿ zamiennik tworzony przez opiniodawcê mo¿e sk³adaæ siê z wielu kursów, student mo¿e proponowaæ tylko jeden. 


Automatyzacja testów: 
Wykorzystany Framework: White.



Inne uwagi:
Kontrolka u¿ytkownika "PDF Viewer" wykorzystana do wyœwietlania kart przedmiotu nie zosta³a napisana przeze mnie,
a pobrana z GitHuba: https://github.com/LanderVe/WPF_PDFDocument
Autor wyrazi³ na swoim blogu zgodê na jej wykorzystanie (https://blogs.u2u.be/lander/post/2018/01/23/Creating-a-PDF-Viewer-in-WPF-using-Windows-10-APIs).
