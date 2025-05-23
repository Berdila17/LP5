# LP5

2.5 bis 23.5

# Grob-Planung
Ich möchte die Daten in einer SQL-Datenbank speichern. Im moment bin ich mir nicht sicher wie viele Spalten pro Tabelle aber ich rechne mit so ca. 3 Tabellen.

# 2.5

- [x] Datenmodell erstellen
- [x] SQL Datenbank einrichten (Tabellen etc. erstellen)

✍️ Heute habe ich mit Umlet zuerst ein Datenmodell gemacht am Anfang dachte ich wären es 3 Tabellen nötig aber dann habe ich mich entschieden das 2 auch passen. Danach hab ich die Datenbank von SQL aufgebaut die Tabellen erstellt und die Struktur allgemein die letzten 20 Minuten hab ich dann noch Videos dazu angeschaut wie man Management Studio mit Visual Studio für das nächste mal verbinden kann.Die SQL Statements hab ich in Code.cs geladen.


# 9.5 Kernfunktionalität
- [x] Aufgaben aus Datenbank laden und anzeigen (nachdem Management Studio mit Visual Studio verbunden wurde)
- [x] Button speichern hinzufügen mit dem man die Aufgaben speichern kann.
- [x] Aufgaben aus Datenbank entfern indem man den Löschen Button drückt
✍️ Heute habe ich mein Projekt erfolgreich mit einer SQL-Datenbank verbunden. Ich habe eine Hilfsklasse erstellt um Aufgaben zentral in die Datenbank einzufügen, zu laden und zu löschen. Die Verbindung zur Datenbank LP5 wurde erfolgreich getestet und ich konnte Aufgaben plus Priorität und Fälligkeitsdatum speichern. Dabei habe ich auch einen Foreign-Key Problem gelöst indem ich einen Benutzer in der Datenbank angelegt habe.Jetzt kann ich Aufgaben nicht nur anzeigen, sondern auch dauerhaft speichern und verwalten.

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

# 16.5 Kernfunktionalität und Ausbau
- [x] Benutzerverwaltung einbauen ( Benutzer auswählen, denn momentan kann man nur mit 1 Benutzer arbeiten)
- [x] Aufgaben nach Benutzer filtern (nur Aufgaben zeigen die der momentane Benutzer auch ist)
- [x] Aufgaben bearbeiten also jetzt auch in der Datenbank
- [ ] DataGridView statt ListBox einführen
      
✍️ Heute habe ich drei Arbeitspakete  umgesetzt, die Benutzerverwaltung mit eine ComboBox, das Filtern der Aufgaben nach Benutzer und die Bearbeitungsfunktion direkt in der Datenbank. Das vierte Arbeitspaket, die Umstellung auf DataGridView konnte ich aus Zeitgründen nicht mehr beginnen, da ich einen unerwarteten Fehler mit der Foreign Key-Verknüpfung beheben musste und da ich so sehr wollte diesen zu beheben war ich so konzentriert das ich sogar den Call um 11:15 verpasst habe weil dieser zuerst gelöst werden musste damit die anderen Funktionen korrekt laufen.

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

# 23.5 Abschluss
- [x] Datagridview statt Listbox einführen
- [ ] evtl. mit Powershell ein Skript erstellen das regelmässig ein Backup erstellt
- [x] Reflexion über Ihre Arbeitsweise
- [x] Beschreibung des fertigen Projekts mit .gif etc.
✍️ Heute habe ich eine Datagridview statt Listbox eingeführt weil dann die Darstellung besser aussieht da es Spalten hat, ich wollte noch ein Powershell Skript schreiben aber da wir es nur einmal hatten war es ein bisschen schwer zu schreiben ohne jegliche Hilfe ich habe Videos darüber angeschaut aber konnte am Schluss aufgrund der Zeit nicht fertig werden.

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

# Fertiges Projekt

Mein Projekt hat jetzt eine Datenbank mit der man die Aufgaben jetzt speichern kann dabei wurde geachtet was passiert wenn man eine Aufgabe löscht,bearbeitet etc.
![image](https://github.com/user-attachments/assets/a44d7b9e-c678-43e1-bbb7-3a9d65aa15a9)
![image](https://github.com/user-attachments/assets/50f2134d-add6-45d9-bc28-2774c6af495f)




# Reflexion
✍️ In dieser Lernperiode ging vieles gut. Das Projekt wurde Schritt für Schritt aufgebaut und mit der Datenbank verbunden. Die Benutzerverwaltung, das Speichern von Aufgaben und das Filtern nach Benutzer haben funktioniert. Auch das Bearbeiten und Löschen von Aufgaben konnte umgesetzt werden. Die Arbeit mit SQL war anfangs ungewohnt, aber durch Übung wurde es besser.Etwas schwieriger war der Umgang mit Fehlern in der Datenbank, zum Beispiel bei Verknüpfungen mit Foreing Keys. Das hat Zeit gekostet, wurde aber am Ende gelöst.Für die nächste Lernperiode ist das Ziel, Aufgaben besser zu planen und Funktionen frühzeitig zu testen. Ein persönlicher Vorsatz für das nächste Jahr im Lernatelier ist: konzentrierter arbeiten und sich nicht von allem ablenken lassen. 
