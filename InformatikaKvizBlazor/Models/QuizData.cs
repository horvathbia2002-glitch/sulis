using System.Collections.Generic;\n\nnamespace QuizApp.Models\n{\n    public static class QuizData\n    {\n        public static List<QuizItem> GetQuestions()\n        {\n            return new List<QuizItem>\n            {\n                new QuizItem {
                    Text = "Melyik programban nem lehet SmartArt alakzatot létrehozni?",
                    Options = new List<string> { "Word", "PowerPoint", "Excel", "Outlook", "GoogleDokumentum" },
                    CorrectIndex = 4,
                    Explanation = "A SmartArt a Microsoft Office termékek (Word, Excel, PowerPoint, Outlook) sajátossága, a Google Dokumentumok nem támogatja."
                },
                new QuizItem {
                    Text = "Egy GoogleDrive mappa vagy dokumentum megosztásához elegendő elküldeni a böngészőben található linket.",
                    Options = new List<string> { "igaz", "hamis" },
                    CorrectIndex = 1,
                    Explanation = "A link elküldése önmagában nem elég, a fájl megosztási beállításainál is engedélyezni kell a hozzáférést (pl. 'A link birtokában bárki megtekintheti')."
                },
                new QuizItem {
                    Text = "Mit nem lehet az élőfejben elhelyezni?",
                    Options = new List<string> { "Tabulátorpozíciókat", "Oldaltörést", "Több bekezdést", "Képet" },
                    CorrectIndex = 1,
                    Explanation = "Az oldaltörés a dokumentum fő szövegtörzsének oldalakra bontására szolgál, így élőfejbe (ami minden oldalon ismétlődik) nem szúrható be."
                },
                new QuizItem {
                    Text = "Milyen tabulátorokkal rendeztük el az alábbi árjegyzéket? (Zokni 90 Ft, Sapka 750 Ft, Sál 900 Ft, Kesztyű 2300 Ft)",
                    Options = new List<string> { "Balra igazodó tabulátor", "Középre igazodó tabulátor", "Jobbra igazodó tabulátor", "Tizedesjelhez igazodó tabulátor" },
                    CorrectIndex = 2,
                    Explanation = "Az árak a jobb szélükhöz vannak igazítva, hogy a számjegyek helyiérték szerint egymás alá kerüljenek."
                },
                new QuizItem {
                    Text = "Az alábbi állítások közül melyik HAMIS?",
                    Options = new List<string> { "Ha kimutatásban értékek szerint csoportosítunk, akkor minden csoportnak egyenlő az osztályköze.", "Ha kimutatásban értékek szerint csoportosítunk, akkor beállíthatunk csoportonként eltérő osztályközt is.", "Ha a kimutatás forrástáblázatában egy mező különböző adattípusú adatokat is tartalmaz, akkor az adott mezőre nem tudunk csoportosítást beállítani." },
                    CorrectIndex = 1,
                    Explanation = "Az Excel kimutatásokban a számértékek csoportosításakor (pl. 1-10, 11-20) az osztályközöknek azonos méretűeknek kell lenniük, nem lehetnek eltérőek."
                },
                new QuizItem {
                    Text = "Jelölje meg, hogy az alább felsorolt elrendezések közül melyikkel hoztuk létre az alábbi képen látható kimutatást!",
                    Options = new List<string> { "a (Sorok: Név, Értékek: Összeg/Másodperc)", "b (Sorok: Összeg/Másodperc, Értékek: Összeg/Másodperc)", "c (Sorok: Másodperc, Értékek: Mennyiség/Név)" },
                    CorrectIndex = 0,
                    Explanation = "A kimutatás sorai a neveket tartalmazzák, az értékmezőben pedig a másodpercek összege látható."
                },
                new QuizItem {
                    Text = "Kördiagramot leggyakrabban milyen típusú adatsorból készítünk?",
                    Options = new List<string> { "több adatsor összehasonlítása", "idősor", "értékpárok összetartozása", "megoszlás" },
                    CorrectIndex = 3,
                    Explanation = "A kördiagram egyetlen adatsor elemeinek az egészhez viszonyított arányát (megoszlását) mutatja be."
                },
                new QuizItem {
                    Text = "Mi az eredménye az alábbi képletnek: =DARABTELI(B3:B8;\">100\")",
                    Options = new List<string> { "4", "6", "2", "120" },
                    CorrectIndex = 0,
                    Explanation = "A B3:B8 tartományban a 100-nál nagyobb értékeket számolja össze. A táblázatban 4 ilyen érték található (234, 180, 120, 150)."
                },
                new QuizItem {
                    Text = "Az A8-as cellában az alábbi képlet található: =SZUM(A1:A7). Mi történik, ha beszúrunk egy új sort a 4. és 5. sor közé?",
                    Options = new List<string> { "Az A9-es cellában az alábbi képlet marad: =SZUM(A1:A7)", "Az A9-es cellában az alábbi képlet lesz: =SZUM(A1:A8)", "Az A9-es cellában az alábbi képlet lesz: =SZUM(A1:A4;A6:A8)", "Az A9-es cellában az alábbi képlet lesz: =SZUM(A2:A8)" },
                    CorrectIndex = 1,
                    Explanation = "Az Excel dinamikusan leköveti a tartományon belüli sorbeszúrásokat, így a hivatkozott tartomány egy sorral megnő."
                },
                new QuizItem {
                    Text = "Milyen hivatkozásnak nevezzük az alábbi képletben látható cellahivatkozásokat? =B3+C3",
                    Options = new List<string> { "abszolút", "vegyes", "hyper", "relatív" },
                    CorrectIndex = 3,
                    Explanation = "A relatív hivatkozások ($ jel nélküliek) a képlet másolásakor az elmozdulás irányának és mértékének megfelelően automatikusan módosulnak."
                },
                new QuizItem {
                    Text = "Mi a különbség, ha importálás után megtartjuk vagy megszüntetjük a kapcsolatot a forrásállománnyal?",
                    Options = new List<string> { "Ha megtartjuk a kapcsolatot, akkor a forrásállomány változásakor lehetőségünk van az adatok frissítésére a munkafüzetben is, ellenkező esetben a forrásfájl semmilyen hatással nincs a munkafüzetre.", "Ha töröljük a kapcsolatot, akkor a forrásállomány változásakor lehetőségünk van a frissítésre", "A kapcsolatot nem lehet törölni, csak azt tudjuk beállítani", "A kapcsolatot nem lehet törölni, a forrásállomány változásakor" },
                    CorrectIndex = 0,
                    Explanation = "A kapcsolat fenntartása lehetővé teszi, hogy az Excel kiolvassa a forrás legfrissebb adatait (Adatok frissítése)."
                },
                new QuizItem {
                    Text = "Ha nincs külön formázva, akkor hova igazodik a cellán belül a szám?",
                    Options = new List<string> { "Középre", "Jobbra", "Balra" },
                    CorrectIndex = 1,
                    Explanation = "Az Excel alapértelmezetten jobbra igazítja a számokat és a dátumokat, míg a szöveget balra."
                },
                new QuizItem {
                    Text = "Milyen típusú adatokat kezel az Excel táblázatkezelő?",
                    Options = new List<string> { "csak számokat és szövegeket", "számokat, szöveg típusú adatokat, logikai adatokat", "csak szövegeket", "csak diagramokat" },
                    CorrectIndex = 1,
                    Explanation = "Az Excel cellái numerikus (szám, dátum), szöveges, valamint logikai (IGAZ/HAMIS) értékeket tartalmazhatnak."
                },
                new QuizItem {
                    Text = "Hogyan lehet hibás vagy felesleges adatok tömeges cseréje, törlését megvalósítani?",
                    Options = new List<string> { "Csak egyenként lehetséges", "Kijelöljük az adatokat és Keres/Csere műveletet alkalmazzuk." },
                    CorrectIndex = 1,
                    Explanation = "A Keresés és csere (Ctrl+H) ablak segítségével az azonos típusú hibák vagy felesleges karakterek pillanatok alatt lecserélhetők."
                },
                new QuizItem {
                    Text = "Ha internetről másolt számokat a táblázatkezelő dátummá alakítja, hogyan tudjuk visszakapni az eredeti számadatot?",
                    Options = new List<string> { "Függvénnyel számmá konvertáljuk.", "Általános szám formátumot választunk", "Sehogy, az adatokat érdemes először egy szöveges állományba illeszteni és ott beállítani a megfelelő számformátumot." },
                    CorrectIndex = 2,
                    Explanation = "Amikor az Excel automatikusan dátummá alakít egy szöveget, dátumsorszámmá konvertálja, így utólagos formázással nem állítható vissza az eredeti karakterlánc."
                },
                new QuizItem {
                    Text = "Az ábrajegyzék és a táblázat jegyzéke hasonlóan készül, a felirat beszúrásánál döntünk arról, hogy az adott objektum ábra, táblázat vagy egyenlet.",
                    Options = new List<string> { "Igaz", "Hamis" },
                    CorrectIndex = 0,
                    Explanation = "A Hivatkozások lapon a Felirat beszúrása funkciónál lehet kiválasztani a felirat címkéjét (pl. Ábra, Táblázat), ez alapján fogja a Word a megfelelő jegyzékbe gyűjteni azokat."
                },
                new QuizItem {
                    Text = "Mi a lábjegyzet és a végjegyzet közötti különbség?",
                    Options = new List<string> { "A lábjegyzet magyarázata megfelelő oldalon, a végjegyzeté a dokumentum szöveg után található.", "A lábjegyzet a szövegterületen, a végjegyzet a margón található", "Nincs lényegi különbség, kis méretű dokumentumoknál végjegyzetnek, nagyoknál lábjegyzetnek nevezzük." },
                    CorrectIndex = 0,
                    Explanation = "A lábjegyzet közvetlenül az adott oldal alján helyezkedik el, míg a végjegyzet a teljes dokumentum (vagy szakasz) legvégén gyűlik össze."
                },
                new QuizItem {
                    Text = "Melyik állítás hamis a következő, stílusokra vonatkozó állítások közül?",
                    Options = new List<string> { "Ha a címsorokat a beépített Címsor 1, Címsor 2 ... stílusokkal formázzuk, akkor a címsorokból gyorsan készíthető tartalomjegyzék", "Tartalomjegyzék készítésekor az oldalszámokat be kell gépelni", "Tartalomjegyzék készítésekor be lehet állítani, hogy hány szintet jelenítsen meg." },
                    CorrectIndex = 1,
                    Explanation = "A tartalomjegyzék automatikus generálásának pont az a lényege, hogy az oldalszámokat a program számolja ki és illeszti be, nekünk nem kell (és nem is szabad) gépelni."
                },
            };
        }
    }
}
