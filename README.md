# German
# MenuSystem
Ein kleines, deutsches Menüsystem mit PlayerPrefs, 4 Speicherslots und einem zufälligem Namen-Generator (C#, Unity)

# 1 – Setup
Ziehe Alle Buttons, Textfelder, Texte und Panels aus dem Prefab in die Felder von den Scripten "Main Menu" und "Saves". Alle Elemente sind Passend benannt.

# 2 – PlayerPrefs
Im Script "Saves" findest du einen Reiter "PlayerPrefsNewGame". Es gibt zwei Unterkategorien. In der Kategorie "Player Pref Int Names" kannst du die Namen einspeichern, unter denen die Variablen gespeichert werden. In der Kategorie "Player Prefs Ints" kannst du die Werte eintragen. Diese werden unter dem Namen, den du bei "Player Pref Int Names" eingegeben hast, gespeichert. Wenn du diese benutzen willst nutze:

PlayerPrefs.GetInt(Name + "SaveGame" + Speicherslot)
(Ersetze diese Wörter mit dem Namen und der Nummer des Speicherslots.)

# 3 – Fertig!
Viel Spaß mit dem Menü!
