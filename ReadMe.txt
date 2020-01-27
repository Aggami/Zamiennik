Ro

Model danych:
Rozwi¹zanie wykorzystuje Entity Framework 6, podejœcie Code First, st¹d nie wykorzystuje 


Generacja klas z diagramu:
Klasy logiki biznesowej zosta³y wygenerowane przez Visual Paradigm z diagramu klas o nazwie "".

Informacje



Informacje o wzorcu projektowym:
Wykorzystany zosta³ wzorzec Repozytorium, który u³atwia po³¹czenia z baz¹ danych. 
Chocia¿ w standardowej jego wersji tworzy siê repozytoria dla ka¿dej relacji w bazie danych, 
tutaj do wiêkszoœci klas zastosowa³am jego generyczn¹ postaæ. 
Osobne repozytoria tworzy³am dla wykorzystywanych przeze mnie w przypadkach u¿ycia klas, 
w szczególnoœci takich, które wymaga³y za³¹czenia(Include()) swoich potomków. 


Inne uwagi:
Kontrolka u¿ytkownika "PDF Viewer" wykorzystana do wyœwietlania kart przedmiotu nie zosta³a napisana przeze mnie,
a pobrana z GitHuba: https://github.com/LanderVe/WPF_PDFDocument
Autor wyrazi³ na swoim blogu zgodê na jej wykorzystanie (https://blogs.u2u.be/lander/post/2018/01/23/Creating-a-PDF-Viewer-in-WPF-using-Windows-10-APIs).

