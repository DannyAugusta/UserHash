# UserHash

UserHash je jednoduchá WinForms aplikace v jazyce C#, která umožňuje správu uživatelských účtů s hashovanými hesly. Uživatelé se mohou přihlásit, změnit své heslo a administrátor má možnost přidávat, mazat nebo měnit hesla ostatním uživatelům.

## Funkce

- Přihlášení uživatele (včetně admina)
- Hashování hesel pomocí SHA-256
- Správa uživatelů (admin):
  - Přidávání nových uživatelů
  - Mazání existujících uživatelů
  - Změna hesla jinému uživateli
- Možnost změny vlastního hesla uživatelem
- Automatické ukládání uživatelů do `users.xml`
- Okenní formuláře se zobrazují vycentrovaně na obrazovce
- Skrytí hesel v textboxech pomocí `*`
- Výchozí admin účet:  
  - **Uživatelské jméno:** `admin`  
  - **Heslo:** `admin`
