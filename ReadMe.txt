Ro

Model danych:
Rozwi�zanie wykorzystuje Entity Framework 6, podej�cie Code First, st�d diagram ERD nie by� potrzebny.
Diagram wygenerowany przez Entity Framework 6 i wy�wietlony dzi�ki Entity Framework Power Tools b�dzie za��czony do wys�anego rozwi�zania.


Generacja klas z diagramu:
Klasy logiki biznesowej zosta�y wygenerowane przez Visual Paradigm z diagramu klas o nazwie "".

Informacje


Informacje o wzorcu projektowym:
Wykorzystany zosta� wzorzec Repozytorium, kt�ry u�atwia po��czenia z baz� danych. 
Chocia� w standardowej jego wersji tworzy si� repozytoria dla ka�dej relacji w bazie danych, 
tutaj do wi�kszo�ci klas zastosowa�am jego generyczn� posta�, na kt�r� pozwala C#. 
Osobne repozytoria tworzy�am dla wykorzystywanych przeze mnie w przypadkach u�ycia klas, 
w szczeg�lno�ci takich, kt�re wymaga�y za��czenia(Include()) swoich potomk�w. 


Inne uwagi:
Kontrolka u�ytkownika "PDF Viewer" wykorzystana do wy�wietlania kart przedmiotu nie zosta�a napisana przeze mnie,
a pobrana z GitHuba: https://github.com/LanderVe/WPF_PDFDocument
Autor wyrazi� na swoim blogu zgod� na jej wykorzystanie (https://blogs.u2u.be/lander/post/2018/01/23/Creating-a-PDF-Viewer-in-WPF-using-Windows-10-APIs).

Logika biznesowa: 
Z powodu zauwa�onych r�nic w podej�ciach do Grup Kurs�w na r�nych wydzia�ach 
(jedne wydzia�y traktuj� Grup� Kurs�w w Planie Studi�w jak jeden kurs 
- nadaj� jeden kod kursu, wsp�lne efekty kszta�cenia, wsp�lne punkty ects i wsp�lne godziny zzu; 
a inne wydzia�y nadaj� te cechy ka�demu kursowi w grupie kurs�w z osobna)
Aby da�o si� pogodzi� oba rozwi�zania, przyj�am, �e je�li Grupa Kurs�w jest przez wydzia� traktowana jak jeden przedmiot, tak te� b�dzie trakowana w aplikacji i zapisywana jako kurs z Form� Kursu np. WykladCwiczenia.
Poniewa� jest tak na Wydziale Informatyki i Zarz�dzania, to wi�kszo�� grup kurs�w jest wpisana w ten spos�b.

Klasa "Grupa_kursow" jest wykorzystywana dla wydzia��w takich jak Wydzia� Elektroniki. 