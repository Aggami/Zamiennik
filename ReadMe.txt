
Model danych:
Rozwi�zanie wykorzystuje Entity Framework 6, podej�cie Code First, st�d diagram ERD nie by� potrzebny.
Diagram wygenerowany przez Entity Framework 6 i wy�wietlony dzi�ki Entity Framework Power Tools b�dzie za��czony do wys�anego rozwi�zania.

Generacja klas z diagramu:
Klasy logiki biznesowej zosta�y wygenerowane przez Visual Paradigm z diagramu klas o nazwie "Model do kreacji ERD/klas".
Wynikiem tej generacji s� te� wykomentowane atrybuty zwi�zane z t� cz�ci� logiki biznesowej, kt�ra nie jest zaimplementowana 
(Mimo wybrania opcji generowania tylko potrzebnych klas, wyb�r ten tworzy wszystkie asocjacje, kt�re s� zapami�tane w projekcie Visual Paradigm)

Informacje o wzorcu projektowym:
Wykorzystany zosta� wzorzec Repozytorium, kt�ry u�atwia po��czenia z baz� danych. 
Chocia� w standardowej jego wersji tworzy si� repozytoria dla ka�dej relacji w bazie danych, 
tutaj do wi�kszo�ci klas zastosowa�am jego generyczn� posta�, na kt�r� pozwala C# i EF6. 
Osobne repozytoria tworzy�am dla wykorzystywanych przeze mnie w przypadkach u�ycia klas, 
w szczeg�lno�ci takich, kt�re wymaga�y przy poleceniu SELECT za��czenia(Include()) swoich potomk�w.

Dokumentacja:
Zosta�a wygenerowana dla projektow: Uslugi, Logika Biznesowa
i zapisana w folderze ../nazwaProjektu/html w formacie html.
Projekt Uslugi ma kompletna dokumentacje dla kazdej klasy. 
Projekt Logika Biznesowa zawiera pe�n� dokumentacje dla klasy Propozycja_zamiennika.
Uwaga: Musia�am usun�� polskie znaki, poniewa� generowana dokumentacja nie wy�wietla�a	ich. Nie da�o si� te� wygenerowa� dokumentacji dla ca�ego rozwi�zania.


Logika biznesowa: 
Zauwa�y�am r�nice w traktowaniu kurs�w przez r�ne wydzia�y: 
jedne wydzia�y traktuj� Grup� Kurs�w w Planie Studi�w jak jeden kurs - nadaj� jeden kod kursu, wsp�lne efekty kszta�cenia, wsp�lne punkty ects i wsp�lne godziny zzu; 
a inne wydzia�y nadaj� te cechy ka�demu kursowi w grupie kurs�w z osobna.
Aby da�o si� pogodzi� oba rozwi�zania, przyj�am, �e je�li Grupa Kurs�w jest przez wydzia� traktowana jak jeden przedmiot, 
tak te� b�dzie trakowana w aplikacji i zapisywana jako kurs z Form� Kursu np. WykladCwiczenia.
Poniewa� jest tak na Wydziale Informatyki i Zarz�dzania, to wi�kszo�� grup kurs�w jest wpisana w ten spos�b.
Klasa "Grupa_kursow" jest wykorzystywana dla wydzia��w takich jak na przyk�ad Wydzia� Elektroniki, gdzie kursy maja odrebne kody i w�asne efekty kszta�cenia.

Przyj�am te�, �e chocia� zamiennik tworzony przez opiniodawc� mo�e sk�ada� si� z wielu kurs�w, student mo�e proponowa� tylko jeden. 


Automatyzacja test�w: 
Wykorzystany Framework: White.



Inne uwagi:
Kontrolka u�ytkownika "PDF Viewer" wykorzystana do wy�wietlania kart przedmiotu nie zosta�a napisana przeze mnie,
a pobrana z GitHuba: https://github.com/LanderVe/WPF_PDFDocument
Autor wyrazi� na swoim blogu zgod� na jej wykorzystanie (https://blogs.u2u.be/lander/post/2018/01/23/Creating-a-PDF-Viewer-in-WPF-using-Windows-10-APIs).
