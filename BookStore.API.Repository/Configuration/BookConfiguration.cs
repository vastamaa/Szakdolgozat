using BookStore.API.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Repository.Configuration
{
    [ExcludeFromCodeCoverage]
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
            (
                new Book
                {
                    Id = new Guid("7699abec-ebeb-4c2b-8b04-cdc45dcab666"),
                    Title = "Stranger Things: Tűzben égve",
                    Description = "A Netflix népszerű STRANGER THINGS sorozata és a HAT c. képregényben megismert szereplők története végre folytatódik! Évekkel azután, hogy megszöktek Dr. Brenner laboratóriumából, Marcy és Ricky még mindig próbálnak beilleszkedni a normális életbe. Amikor azonban hírét veszik, hogy a laboratórium bezárt, elindulnak megkeresni Marcy ikertestvérét, a tűzgyújtási képességgel rendelkező Kilencet. Hamarosan rájönnek, hogy barátjukat nem csak kiszabadítaniuk kell, de kimenteniük is saját elméjének rabságából, mielőtt Jamie mindent elpusztítana maga körül. És ahogy közelebb kerülnek Kilenchez, egyre több titokra jönnek rá a Dr. Brenner kisérleteivel kapcsolatban, olyan titkokra, ami mindannyiukat mélyen megrázza...",
                    ISBN = "9789634976578",
                    ProductImage = File.ReadAllBytes("stranger_things_tuzben_egve.jpg"),
                    PageNumber = 112,
                    Price = 4990,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("442b8e4a-319e-43ea-a1c4-902436ec741f"),
                    Title = "Bosszúállók 1. - Új veszély",
                    Description = "Elkezdődött a Bosszúállók kalandjainak fergeteges új korszaka! Egy új csapat áll össze, hogy megküzdjenek egy hihetetlenül óriási fenyegetéssel, ami furább és féktelenebb, mint amivel a szuperhősök valaha találkoztak! Az \"Új veszély\" tökéletes választás kezdő olvasóknak és rajongóknak egyaránt, ugyanis Metthew K. Manning író és Jon Sommariva rajzoló lehetővé teszik, hpgy most először korosztálytól függetlenül élhessük át a Bosszúállók képregények nyújtotta szenzációs izgalmakat.",
                    ISBN = "9789639998896",
                    ProductImage = File.ReadAllBytes("marvel_akciohosok_bosszuallok_uj_veszely.jpg"),
                    PageNumber = 72,
                    Price = 990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("7ee9d4a8-432e-48aa-b980-7b2a478ba125"),
                    Title = "Bosszúállók 2. - Rubinvilág",
                    Description = "A Bosszúállók kalandjainak fergeteges új korszaka folytatódik! A Föld Legnagyobb Hőseinek legújabb kalandjában mágia és puszta erő feszül egymásnak, hamisítatlan Marvel stílusban! Thor, Marvel Kapitány és Doktor Strange eltűntek! Vajon képesek lesznek a Bosszúállók időben rátalálni barátaikra, miközben még rettenetes rémségekkel is meg kell küzdeniük nélkülük? Matthew K. Mamming író és Jon Sommariva rajzoló kötete kiváló választás kezdő olvasóknak és rajongóknak egyaránt.",
                    ISBN = "9789635950041",
                    ProductImage = File.ReadAllBytes("marvel_akciohosok_bosszuallok_rubinvilag.jpg"),
                    PageNumber = 72,
                    Price = 1490,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("f3e381b2-21e4-4d18-bf30-92cdb0958fde"),
                    Title = "García! 1.",
                    Description = "Hatvan éve legenda volt. Aztán eltűnt, nyoma veszett. Mindenki elfelejtette. Most visszatért. A legnehezebb pillanatban. Mert a múlt sosem halhat meg. Spanyolországban a múlt mindig visszatér. És nem felejt.\r\nLebilincselő bűnügyi történet a politikailag megosztott Spanyolországból, amelyben egy fiatal újságírónő és egy hibernációból ébredt régivágású titkos ügynök próbálja kibogozni a szálakat.\r\nA képregény alapján készült sorozat 2022-ben érkezik az HBO Max kínálatába.",
                    ISBN = "9789635950133",
                    ProductImage = File.ReadAllBytes("garcia.jpg"),
                    PageNumber = 192,
                    Price = 3990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("202fa58b-2487-476d-9cc9-dee76dfd29bf"),
                    Title = "Batman - Az utolsó lovag a Földön",
                    Description = "Bruce Wayne napjainkhoz képest húsz év elteltével ébred fel az Arkham Elmegyógyintézetben. Fiatal. Épelméjű. És... sosem volt Batman. Hogy összeilleszthesse rejtélyes múltjának darabjait, a Sötét Lovag hosszú útra indul az ismeretlen külvilágban, és találkozik hajdani barátaival és ellenségeivel - vagyis azzal, amivé váltak a jövőben. Elsőként rémséges útitársával, Joker fejével. Ugyanis Joker valamiképpen életben maradt levágott feje lesz Batman démoni idegenvezetője az apokalipszis sújtotta DC-univerzum poklán át. De ahhoz, hogy kiderítse, mi vezetett ehhez a borzalmas jövőhöz, nyomára kell bukkannia annak a rémísztő és manipulatív hatalomnak, amely romba döntötte a hajdani világot.",
                    ISBN = "9789634702313",
                    ProductImage = File.ReadAllBytes("batman_az_utolso_lovag_a_foldon.jpg"),
                    PageNumber = 172,
                    Price = 7495,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("7aedad58-5e65-4c28-95af-202d00731858"),
                    Title = "A teljes Maus",
                    Description = "\"Ezek nem emberek!\" Ha ez a gyűlölettel átitatott mondat egy állam ideológiájává válik, az minden esetben világméretű tragédiához vezet. A náci Németországban a goebbelsi propaganda elhitette az emberekkel, hogy bizonyos embertársaik alsóbbrendűek, akiket el kell pusztítani. E szörnyűséges, egész Európát érintő történelmi bűntett áldozatainak állít emléket Art Spiegelman Pulitzer-díjas képregénye, a Maus. A szereplők antropomorf állatok: egérfejű zsidók, macskafejű németek és kutyafejű amerikaiak. Az ő sorsukon keresztül ismerjük meg a holokauszt megrázó eseményeit és következményeit. A történet gerincét Spiegelman lengyel származású apjának magnószalagra rögzített visszaemlékezései alkotják, így a Maus fikciós, önéletrajzi és dokumentumkötet egyben. Műfajteremtő, egyetemes érvényű irodalmi alkotás egy szégyenletes korszakról, mely nem merülhet feledésbe.",
                    ISBN = "9789634333678",
                    ProductImage = File.ReadAllBytes("a_teljes_maus.jpg"),
                    PageNumber = 296,
                    Price = 3990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("20ae263a-0db8-4bff-b8df-61cb22c54a25"),
                    Title = "How To - Wie man\'s hinkriegt",
                    Description = "Für jede Aufgabe, die sich uns stellt, gibt es einen richtigen Weg, einen falschen, und einen, der so offensichtlich absurd ist, dass man ihn niemals in Betracht ziehen würde. -How to- ist eine Anleitung zu diesem dritten Ansatz. Es zeigt uns, wie wir digitale Daten versenden, indem wir USB-Sticks an Zugvögeln befestigen. Wie wir unserem Auto Starthilfe geben, indem wir elf Jahre auf eine Sonneneruption warten. Wie wir herausfinden, ob wir zur Generation der Babyboomer gehören oder ein Kind der Neunziger sind - nämlich, indem wir die Radioaktivität unserer Zähne messen lassen. Und wir erfahren, wie wir endlich pünktlich zu Verabredungen kommen: indem wir mal eben den Mond zerstören. Mit seinen berühmten Strichzeichnungen erklärt Randall Munroe, wie man einfache Probleme auf die allerschwierigste Weise bewältigen kann. Wie schon sein Bestseller -What if?- ist -How to- witzig und horizonterweiternd und hilft uns zu verstehen, welche wissenschaftlichen und technischen Phänomene unserem Alltag zugrunde liegen.",
                    ISBN = "9783328600916",
                    ProductImage = File.ReadAllBytes("how_to_wie_mans_hinkriegt.jpg"),
                    PageNumber = 383,
                    Price = 8490,
                    PublishingYear = 2019
                },
                new Book
                {
                    Id = new Guid("688cf081-3185-4bd0-b216-76dbe5635155"),
                    Title = "Mi lenne, ha?",
                    Description = "\"Néha az is felemelő érzést jelent, ha nem döntjük romba a világot\" Tudják, mekkora az az erő, amellyel Yoda mester felemelte az űrhajót a mocsárból? Sokan vakarjuk a fejünket, amikor gyermekünk vagy gyermekkorú ismerősünk furcsánál furcsább kérdéseket tesz fel, a legkülönfélébb tudományágakban. Randall Munroe szülei a fejvakaráson túl megpróbálták megválaszolni ezeket, így az érdeklődő gyermekből érdeklődő felnőtt lett, aki kedvenc kérdéseit hamarosan vicces formában válaszolta meg saját honlapján. A szerző nélkül soha nem tudnánk meg, hogy valójában, tényleg milyen nehéz megtalálni a lelki társunkat, vagy hogy mi történik egy marhaszelettel, ha (megfelelő magasságból) földre dobjuk. Egy biztos: a szerző gondolatmeneteinek fele a Föld elpusztításával végződik, így ajánlatos komolyan venni a figyelmeztetést: Ezt otthon semmiképpen ne próbálja ki!",
                    ISBN = "9789632933689",
                    ProductImage = File.ReadAllBytes("mi_lenne_ha.jpg"),
                    PageNumber = 397,
                    Price = 4490,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("70af79cd-02b0-4f70-8208-92226361c07c"),
                    Title = "Conan, a barbár - Elveszett legendák",
                    Description = "Conan, a kimmériai barbár három története egy Atlantisz elsüllyedése utáni és az ismert ókori civilizációk felemelkedését megelőző, elképzelt világba, a hybóriai korba vezet vissza bennünket. Conan magányosan, mindenhol idegenként járja a világot. Ha megfizetik, szembeszáll gonosz varázslópapokkal, félelmet nem ismerő, vad bennszülöttekkel, kígyónyelvű nagyurakkal. Módszerei, barbársága gyakran kelt ellenérzést a civilizált emberek szemében.Ám eljön az idő, amikor csak ő segíthet...Az Éditions  Glénat francia képregénykiadó 2018-ban hadat üzent az amerikai Marvelnek és a Dark Horse-nak. Megbízta minden idők legsikeresebb francia képregényrajzolóit, hogy alkossák újra Robert E. Howard  1932-ben kitalált  hősének,  Conannak, a barbárnak a történeteit. A legyőzhetetlen  kimmériai harcos  kalandjai 21 történetben jelentek meg az elmúlt években, hatalmas sikert aratva szerte a világon. Ezekből választottunk ki hármat, talán a legjobbakat, hogy egyetlen kötetben bemutassuk őket a magyar képregényrajongók számára.",
                    ISBN = "9786158152747",
                    ProductImage = File.ReadAllBytes("conan_a_barbar.jpg"),
                    PageNumber = 184,
                    Price = 6930,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("5b2a07d6-b0f7-4edc-ac20-6b62f91552d2"),
                    Title = "Monstress - Fenevad - Első kötet - Ébredés",
                    Description = "Farkasvérű Maikát szörnyetegnek csúfolják... és nem is állnak messze a valóságtól. A világot felforgatta a szörnyű háború, amit az emberek gyűlölt ellenségeik, az arkánok ellen vívtak. Maika nem csak a fél karját, de szabadságát is elvesztette a harcokban, rabszolgaként adják el Zamora boszorkányainak, akik az arkánok véréből nyerik erejüket. Azt azonban még a nagyhatalmú mágusnők sem tudják, hogy a lány testében egy ősi, kozmikus erejű, éhező fenevad szunnyad, amely csak az alkalomra vár, hogy kitörhessen...",
                    ISBN = "9789634700883",
                    ProductImage = File.ReadAllBytes("monstress_fenevad.jpg"),
                    PageNumber = 208,
                    Price = 6495,
                    PublishingYear = 2019
                },
                new Book
                {
                    Id = new Guid("bc7636e9-9ffd-4a96-9e21-992a44ea71b2"),
                    Title = "Orgyilkos osztály - Deadly Class 3. - Kígyóverem",
                    Description = "A Haláltanok Királyi Iskolájában, a hírhedt orgyilkosképző tanintézményben a vége felé közeledik a tanév. Marcus Lopez problémái meglehetősen eltérnek korosztályának tipikus gondjaitól. Múltját számos bűntett - és jó néhány holttest - csúfítja, és ez immár barátait is komolyan veszélyezteti. Marcus világában könnyen rosszra fordulnak a dolgok. Amikor őt és társait újabb csapás éri, az eddigi barátságok megkérdőjeleződnek, a korábbi szövetségek és vonzalmak átrendeződnek, és ő rádöbben, hogy ez a darabjaira hulló, torz világ a kíméletleneké és az önzőké, a hatalom pedig azok jussa, akiknek semmi sem drága azért, hogy megszerezzék. Ebben a világban a szerelem, a barátság, a tisztesség csak célponttá tesz és a mélybe ránt. Amikor pedig úgy tűnik, ennél rosszabb már nem lehet, elérkezik a tanév vége - és ebben az iskolában a záróvizsgát halálosan komolyan veszik!",
                    ISBN = "9789634701088",
                    ProductImage = File.ReadAllBytes("orgyilkos_osztaly.jpg"),
                    PageNumber = 116,
                    Price = 4590,
                    PublishingYear = 2019
                },
                new Book
                {
                    Id = new Guid("6b24c001-516f-4c66-8015-5595d0e027d2"),
                    Title = "Orgyilkos osztály - Deadly Class 3. - Kígyóverem",
                    Description = "A Haláltanok Királyi Iskolájában, a hírhedt orgyilkosképző tanintézményben a vége felé közeledik a tanév. Marcus Lopez problémái meglehetősen eltérnek korosztályának tipikus gondjaitól. Múltját számos bűntett - és jó néhány holttest - csúfítja, és ez immár barátait is komolyan veszélyezteti. Marcus világában könnyen rosszra fordulnak a dolgok. Amikor őt és társait újabb csapás éri, az eddigi barátságok megkérdőjeleződnek, a korábbi szövetségek és vonzalmak átrendeződnek, és ő rádöbben, hogy ez a darabjaira hulló, torz világ a kíméletleneké és az önzőké, a hatalom pedig azok jussa, akiknek semmi sem drága azért, hogy megszerezzék. Ebben a világban a szerelem, a barátság, a tisztesség csak célponttá tesz és a mélybe ránt. Amikor pedig úgy tűnik, ennél rosszabb már nem lehet, elérkezik a tanév vége - és ebben az iskolában a záróvizsgát halálosan komolyan veszik!",
                    ISBN = "9789634701088",
                    ProductImage = File.ReadAllBytes("orgyilkos_osztaly.jpg"),
                    PageNumber = 116,
                    Price = 4590,
                    PublishingYear = 2019
                },
                new Book
                {
                    Id = new Guid("fb3e524f-2942-464c-9ea0-e0b20291b9a7"),
                    Title = "Konc 1. - Távozás Koncfalváról",
                    Description = "Ebben az elképesztően humoros és kalandos képregényben a három Konc kuzin, miután elmenekül Koncfalváról, eltéved egy hatalmas, ismeretlen sivatagban. Külön utakon, de mindegyikük egy sűrű erdővel borított, titokzatos völgybe jut, amelyet csodálatos és rémisztő teremtmények népesítenek be. A völgyből télvíz idején nincs kiút, így az igazi kaland csak most kezdődik, hiszen meg kell mente- niük az idilli völgyet az ellenük szervezkedő gonosz erők támadásától. A sorozat 11 Harvey-díj és 10 Eisner-díj nyertese, beleértve a Legjobb író-rajzoló és a Legjobb humoros kiadvány díját is.",
                    ISBN = "9789639998773",
                    ProductImage = File.ReadAllBytes("konc_tavozas_koncfalvarol.jpg"),
                    PageNumber = 144,
                    Price = 2690,
                    PublishingYear = 2020
                },
                new Book
                {
                    Id = new Guid("e0c2b2c3-d2b4-43ea-8694-65435ab92e4f"),
                    Title = "Konc 4. - A Sárkányölő",
                    Description = "Konc Fülének sokféle veszéllyel kell szembenéznie a sorozat negyedik kötetében: Ben nagyanyóval és Tövissel karöltve a félelmetes Dokkirállyal, a patkánylények uralkodójával szemben kell megvédeniük magukat. Eközben a Csuklyába Öltözött totális háborúra buzdítja hadseregét, Tövist pedig egyre furcsább álmok gyötrik. A helyzetet súlyosbítja, hogy Ben nagyanyó eltűnik, Svindli pedig elhiteti a falusiakkal, hogy ő a hatalmas Sárkányölő. Amikor - legnagyobb meglepetésére - valóban elkapja a Vörös Sárkányt, szembe kell néznie saját ígéretével és napfelkeltekor megölni a sárkányt. A sorozat 11 Harvey-díj és 10 Eisner-díj nyertese, beleértve a Legjobb író-rajzoló és a Leghumorosabb kiadvány díját is.",
                    ISBN = "9789639998919",
                    ProductImage = File.ReadAllBytes("konc_a_sarkanyolo.jpg"),
                    PageNumber = 176,
                    Price = 2690,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("c6dc94d2-326f-4e75-a807-abca54992025"),
                    Title = "Alvilág 2. - Lawless",
                    Description = "Húsz évvel ezelőtt, Tracy Lawless a város bűnnel teli utcáiról a katonaságba menekült, és soha nem nézett vissza. Most a múltja visszahúzza az iraki és afganisztáni sivatagból, hogy megtudja, ki hagyta a bátyját holtan fekve egy sikátorban. Miközben a testvére, Rick alvilági életébe beszivárogva a családja történetének roncsait ássa elő, az egyetlen dolog, amire Tracy rájön, hogy már senki sem tudja, ki is ő. A nemtudás pedig gyakran vezet halálhoz... A Lawless a díjnyertes szerzőpáros Alvilág című sorozatának második kötete. A 21. század legelismertebb bűnügyi képregénye: hat Eisner- és Harvey-díj nyertese, beleértve a Legjobb író és a Legjobb új sorozat díját is.",
                    ISBN = "9789639998995",
                    ProductImage = File.ReadAllBytes("alvilag_lawless.jpg"),
                    PageNumber = 128,
                    Price = 3990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("b6124eff-d671-42c3-b6f7-9d6d7777c42c"),
                    Title = "The Witcher: Sötét emlékek",
                    Description = "Geralt, a vaják felkérést kap Badreine város elöljárójától, hogy legyen segítségére, mert a településről gyermekeket raboltak el. Geralt elfogadja a megbízást, majd beleveti magát egy gyászoló anya és eltűnt gyermeke titokzatos múltjának felderítésébe. Ám saját nyomasztó víziói közepette a szörnyvadász hamarosan rájön, csak a megérzéseire hagyatkozhat, hogyha meg akarja oldani a rejtélyt és elkerülni az egyre közeledő halálos veszélyt... A The Witcher, mely Andrzej Sapkowski Vaják c. fantasy könyvsorozatából született, 2015-ben a közönség és a kritikusok által is leginkább elismert videójáték volt. Képregényünk bár a játék alapján készült, de benne attól és a Vaják könyvektől független, teljesen új történetet ismerhetnek meg az olvasók.",
                    ISBN = "9789634976677",
                    ProductImage = File.ReadAllBytes("witcher_sotet_emlekek.jpg"),
                    PageNumber = 104,
                    Price = 4990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("6507aac7-47ee-4472-ab84-d757f077b8b3"),
                    Title = "Oracle Year -Tödliche Wahrheit",
                    Description = "Will Dando erwacht eines Morgens mit dem Gefühl, vielleicht noch zu träumen - denn ihm schwirren Prophezeiungen durch den Kopf. Totaler Quatsch, denkt er, und widmet sich weiter seiner bescheidenen Karriere als Musiker. Doch als erste Visionen sich bewahrheiten, wird Will die Brisanz und der Wert seiner Gabe bewusst. Zusammen mit seinem besten Freund, einem Investmentbanker, beschließt er, mit den Prophezeiungen Geld zu verdienen. Dafür jedoch müssen sie an die Öffentlichkeit gehen - und die Menschen reagieren zutiefst verunsichert. Als erste Unruhen ausbrechen, beginnt Will zu ahnen, wie gefährlich sein Wissen wirklich ist...",
                    ISBN = "9783442487202",
                    ProductImage = File.ReadAllBytes("oracle_year.jpg"),
                    PageNumber = 510,
                    Price = 4190,
                    PublishingYear = 2018
                },
                new Book
                {
                    Id = new Guid("692a5edb-081f-4227-9ecf-93d8caef2a5b"),
                    Title = "Star Wars: Lando",
                    Description = "LANDO CALRISSIAN, A KÖZKEDVELT GAZFICKÓ NAGY KALANDJA! Mielőtt csatlakozott volna a lázadáshoz, vagy Felhőváros vezetőjévé vált volna, a rámenős és vígkedélyű Lando szélhámossággal és ravaszsággal boldogult a galaxisban, és nem is rosszul... Ezúttal - a hűséges Lobottal az oldalán - azt terveli ki, hogy ellop egy rendkívül értékes hajót. De lehet, hogy most túl nagyot markolt? Ugyanis a galaxis egyik legjobb és legveszélyesebb fejvadásza ered a nyomába, és a nagy dobás csakhamar az életben maradásért vívott küzdelemmé válik a szerencsejátékos számára. Bár Lando és Lobot csak a könnyű pénz miatt vállalta el ezt a melót, ha sikerül megúszniuk ezt a kalandot, már soha nem lesznek ugyanazok... Ez a képregénysorozat a MARVEL Lando című ötrészes, önálló képregénysorozatát tartalmazza. A kötetben található történeteket Charles Soule írta és Alex Maleev rajzolta.",
                    ISBN = "9789634976585",
                    ProductImage = File.ReadAllBytes("star_wars_lando.jpg"),
                    PageNumber = 112,
                    Price = 5290,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("631cd711-ed49-49dc-bfc5-69fb638c0f25"),
                    Title = "Lovecraft antológia - Első kötet",
                    Description = "Howard Phillips Lovecraft csodagyerekként korán érdeklődni kezdett a kémia és a csillagászat iránt, noha beteges természete és szorongásos alvászavara megakadályozták benne, hogy elvégezze tanulmányait. Az ezt követő idegösszeomlás és depresszió sokban hozzájárultak az írásaiban megjelenő cinikus és nyugtalanító világkép kialakulásához. Miközben gyakran visszatért a téboly, a bűntudat és az emberek jelentéktelenségének témájához, fokozatosan dolgozta ki a \"kozmikus rettenet\" - az emberiséget többször is leigázni igyekvő gonosz, földönkívüli szörnylények és régi istenek - koncepcióját.\"Mert ami felemelkedett, újra elsüllyedhet...\" A természetfeletti horror atyja, Howard Phillips Lovecraf képzeletének legsötétebb bugyraiból bukkant elő az a hét történet, amit ebben a képregénygyűjteményben találunk. Legyen szó akár az éj sötétjében suttogó kozmikus rettenetről, akár a tengerek mélységeiben támadt nyugtalanító mozgolódásról, Lovecraft elbeszélései a mai napig felkavarnak bennünket. Jelen képregényünk pedig még valóságosabb életet lehel a horror nagymesterének ezen legismertebb írásaiba. \"...és ami elsüllyedt, újra felemelkedhet.\"",
                    ISBN = "9789634976660",
                    ProductImage = File.ReadAllBytes("lovecraft_antologia_elso_kotet.jpg"),
                    PageNumber = 120,
                    Price = 5990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("40bfa8e4-f5aa-4edf-803a-aa2876f834ff"),
                    Title = "World of Warcraft: Első könyv",
                    Description = "Kalimdor partján egy férfit vet partra a tenger, aki semmire sem emlékszik a múltjából. Ezzel veszi kezdetét Lo\'Gosh a félelmetes harcos és nem mindennapi bajtársai, Medveirha Broll és Vérengző Valeera lélegzetelállító kalandjai. Hőseinknek a túlélés érdekében nem csak más fajok képviselőivel, de egymással is együtt kell működniük, s miközben apránként fényt derítenek Lo\'Gosh múltjára, hol a Horda, hol a Szövetség oldalán kénytelenek harcba szállni... A történetet olyan nevek jegyzik, mint a Thor képregények szerzője, Walter Simonson író, és Ludo Lullabi és Sandra Hope illusztrátorok.",
                    ISBN = "9789634976608",
                    ProductImage = File.ReadAllBytes("wow_kepregeny_elso_konyv.jpg"),
                    PageNumber = 176,
                    Price = 6990,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("df26ecff-aee1-494e-9b56-760685d053fb"),
                    Title = "Napóleon 1814 - Franciaország védelme",
                    Description = "A könyv a modern kori európai történelem egyik legdrámaibb eseménysorát, az egyik legnagyobb katonai és politikai bukás történetét meséli el hitelesen és olvasmányosan. A korábban sikert sikerre halmozó Napóleon 1814-ben, az előző két év nagy vereségei után már a végső katasztrófával volt kénytelen szembenézni: küszöbön állt a vele szemben álló szövetséges hatalmak (Oroszország, Poroszország, Anglia) inváziója Franciaország ellen. Az ezt követő intenzív hadjáratot Franciaország területén gyakran szokták Napóleon egyik legnagyobb hadvezéri teljesítményeként emlegetni, ugyanakkor még soha nem mutatták be ilyen részletességgel. A szerző izgalmasan kíséri végig a hadjárat történetét, amelynek végkimenetele alapvető hatással volt Európa sorsára. A kortárs szemtanúk beszámolóira támaszkodva érzékletesen mutatja be az egymást követő nagy csaták sorozatát, amely végül a hadjárat legnagyobb és legvéresebb, Párizs melletti ütközetében érte el a csúcs- és végpontját. Ezután következett Napóleon lemondásának elképesztő drámája, ami szintén fontos témája a könyvnek. A könyvben nagy hangsúlyt kap a polgári lakosság háborús tapasztalata, a szerző eleven színekkel és megindítóan ábrázolja a háborús körülmények között élő lakosság szenvedéseit, azokat a morális dilemmákat, amelyekkel az idegen megszállás alatt kellett szembenézniük. A könyv maradandó olvasmányélményt kínál a beavatottak és a nem beavatottak számára egyaránt.",
                    ISBN = "9786155583278",
                    ProductImage = File.ReadAllBytes("napoleon_franciaorszag_vedelme.jpg"),
                    PageNumber = 536,
                    Price = 6990,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("1ad50f0f-625d-48cf-b4cd-abfec605c96d"),
                    Title = "A Hidegháború és még 30 év",
                    Description = "A szerző őszintén, néhol szenvedélyesen, de tényszerűen igyekszik elénk tárni a Hidegháború korszakát és az azt követő 30 évet. Egyéni látásmódja új megvilágításba helyezi ezt a történelmi korszakot. Bemutatja azokat a politikai és hatalmi játszmákat, amelyek korunk történelmét és emberek millióinak sorsát alakítják, amely segít megérteni a jelenkor gyors változásait, háborúit és a társadalmi törekvéseket. A könyv nem csak azoknak készült, akik szeretik a történelmet, hanem mindenkinek, ezért a szerzője igyekezett úgy fogalmazni, hogy minden érdeklődő számára érthető legyen.",
                    ISBN = "9786156297198",
                    ProductImage = File.ReadAllBytes("a_hideghaboru_es_meg_harminc_ev.jpg"),
                    PageNumber = 254,
                    Price = 5590,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("f6a83e2b-ee83-466f-a1bc-f14d365f0a96"),
                    Title = "Egy izraeli páncélostiszt élete - Bajmoktól Szarajevóig",
                    Description = "Ez a különleges könyv egy páratlan életút összegzése, amely a vajdasági Bajmoktól vezetett az 1973-as háborúban kulcsszerepet játszott izraeli 600. páncélosdandár parancsnokságáig. A szerző 18 évesen, 1952-ben a harckocsizókhoz bevonulva kezdte meg sok évtizedes katonai pályáját az izraeli fegyveres erőknél. Részt vett négy nagy, sorsfordító háborúban, amelyek egyes epizódjai nagy hangsúly kapnak a könyvben: az 1956-osban (ekkor harckocsija telitalálatot kap), az 1967-esben, majd már dandárparancsok-helyettesként az 1967-1970-es, ún. \"felőrlő\" háborúban. Katonai karrierjének és egyben e könyvnek is drámai csúcspontját az 1973-as háború jelenti, amelyben az M60-asokkal felszerelt 600. páncélosdandár parancsnokaként harcolt a Sínai-félszigeten egy nagyon fontos terepszakaszon. Minden szépítés nélkül, forrásértékűen és részletesen számol be ezekről a kritikus napokról, amikor Izrael léte forgott kockán. A hadosztályparancsnoka nem más volt, mint Ariel Saron, későbbi miniszterelnök. Nagy erénye a könyvnek, hogy egy különlegesen energikus, a katonai hierarchia szinte minden szintjét megjárt ember személyes tapasztalatain át pillanthatunk be a teljesen egyedi izraeli katonai kultúrába, a fegyveres erők és a társadalom különleges viszonyába, érthetünk meg valamit a döntéshozatali mechanizmusokból, a személyiség szerepéből, és persze ott lehetünk a szerzővel egyes kritikus hadmozdulatoknál is. És mindeközben megismerhetjük azt a mifelénk ma már szokatlannak ható lelkesedést, azonosulást, patriotizmust, amely felépítette és megvédte új hazáját. A szerző Révész Tamásként született 1934-ben az akkor a Jugoszláviához tartozó vajdasági Bajmokon, méghozzá egy igen jómódú, mezőgazdasággal foglalkozó családban. A terület 1941-ben visszakerült Magyarországhoz, és a háborús időkre való tekintettel a család hamarosan Budapestre költözött. Itt érte őket 1944-1945 rettenete, ami számukra az állandó életveszélyt jelentette zsidó származásuk miatt. A kis Tamás egy zagyvarékasi családnál vészelt át pár hónapot, majd végül édesanyjával és bátyjával Rákoshegyen találtak menedékre, ahol valamikor 1944 decemberében haladt át rajtuk a front, ami számukra a megmenekülést jelentette. Ezután megpróbálták újrakezdeni az életüket a Jugoszláviához visszakerült Bajmokon, de végül hosszas viták után 1948-ban kivándoroltak Izraelbe. A hadseregtől leszerelve a szerző életében újabb drámai csomópontok következtek: így a boszniai háború idején, sokszor életveszélyben mentette a helyi zsidóságot az 1990-es évek első felében. Az életútja körbeért: így lett megmentettből megmentő. Könyve nem csupán a közelmúlt hadtörténete szempontjából izgalmas olvasmány, élettörténete az emberi élni akarás és életszeretet inspiráló és lenyűgöző példája is.",
                    ISBN = "9786155583698",
                    ProductImage = File.ReadAllBytes("egy_izraeli_pancelostiszt_elete.jpg"),
                    PageNumber = 280,
                    Price = 5490,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("633b2f6f-3ded-4cfe-9b0a-9914f8af9f6f"),
                    Title = "The Golden Bull of Hungary",
                    Description = "Promulgated by Andrew II of Hungary 800 years ago, the Golden Bull (1222) is the best known but also most misunderstood medieval Hungarian document. The book analyses the reform policies that served as the background to the Golden Bull, the circumstances of the bull\'s conception, the events leading to its renewal in 1231, and the consequences of that revision. Finally, the afterlife of the Golden Bull in the medieval period is explored. Attila Zsoldos is a member of the Hungarian Academy of Sciences. He works at the Institute of History of the Research Centre for the Humanities (Budapest, Hungary). His main fields of interest are the social and political history and the institutions of 11-14th-century Hungary. A 800 évvel ezelőtt II. András által kihirdetett Aranybulla (1222) a legismertebb, de egyben a leginkább félreértett középkori magyar dokumentum. A kötet szerzője elemzi az Aranybulla hátteréül szolgáló reformpolitikát, a bulla megszületésének körülményeit, az 1231-es megújításához vezető eseményeket és a felülvizsgálat következményeit, végül az Aranybulla középkori utóéletét vizsgálja. Zsoldos Attila a Magyar Tudományos Akadémia tagja. A Bölcsészettudományi Kutatóközpont Történettudományi Intézetének munkatársa. Fő érdeklődési területe a 11-14. századi Magyarország társadalom- és politikatörténete, valamint intézményei.",
                    ISBN = "9789634163053",
                    ProductImage = File.ReadAllBytes("the_golden_bull_of_hungary.jpg"),
                    PageNumber = 260,
                    Price = 4500,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("6050a459-38ae-43c2-b580-ffe16e78d46c"),
                    Title = "Sorsfordítók a magyar történelemben - IV. Béla",
                    Description = "A Kossuth Kiadó új történelmi sorozata a magyar államiság ezeréves történetéből tizennyolc olyan alakot mutat be, akik uralkodóként, politikusként vagy \"szürke eminenciásként\" Magyarország és a magyarság sorsát meghatározó módon irányították - olykor kedvezőbb, máskor szerencsétlenebb irányba. A Romsics Ignác főszerkesztő nevével fémjelzett sorozat szerzői az adott korszak, illetve személyiség elismert történész szakértői. A kötetek gazdag képanyaggal, korabeli dokumentumokkal illusztrálva állítják az olvasó elé ezeket a sorsfordító egyéniségeket.",
                    ISBN = "9789630990295",
                    ProductImage = File.ReadAllBytes("sorsforditok_negyedik_bela.jpg"),
                    PageNumber = 64,
                    Price = 1790,
                    PublishingYear = 2018
                },
                new Book
                {
                    Id = new Guid("590054d6-f15a-45c7-ba90-fbac55db6b9c"),
                    Title = "E-könyv - Nagy uralkodók és kiskirályok a XIII. században",
                    Description = "A Kossuth Kiadó népszerű történelmi ismeretterjesztő sorozata, a Magyarország története 4. kötete. A Magyarország története című sorozat történelmünk kezdeteitől napjainkig összefoglalja a legfontosabb eseményeket, bemutatja a kiemelkedő történelmi személyiségeket. Ez a kitűnő, átfogó tudásanyagot nyújtó történelmi alapmű nélkülözhetetlen segítség diákoknak, tartalmas és színes olvasmány a magyar történelem iránt érdeklődőknek. A neves szerzők a sorozat anyagát a legújabb kutatási eredmények felhasználásával állították össze. A kötetek rendkívül gazdag forrásanyagból merítve, eredeti dokumentumok felhasználásával készültek. ,,A Kossuth Kiadó magyar történelmi sorozata a honfoglalástól napjainkig terjedő több mint ezer év történetét mutatja be.Ilyen jellegű munka ekkora terjedelemben és magyar nyelven még soha nem jelent meg. A szerzők, az adott korszak avatott ismerői közérthető, ám egyben szakszerű összefoglalást nyújtanak mindazoknak, akik múltunk megismerésére törekszenek.A kiváló történészek magas színvonalú munkái páratlan élménnyel ajándékozzák meg azokat, akik elolvassák e köteteket.\"Romsics Ignácakadémikus, történész,a sorozat főszerkesztőjeA sorozat kötetei:1. Őstörténet és honfoglalás2. Államalapítás 970-10383. Pogánylázadások és konszolidáció 1038-11964. Nagy uralkodók és kiskirályok a XIII. században5. Az Anjouk birodalma 1301-13876. Luxemburgi Zsigmond uralkodása 1387-14377. A Hunyadiak kora 1437-14908. Mohács felé 1490-15269. Az ország három részre szakadása 1526-160610. Romlás és kiútkeresés 1606-170311. A Rákóczi-szabadságharc 1703-171112. Megbékélés és újjáépítés 1711-179013. A nemzeti ébredés kora 1790-184814. Forradalom és szabadságharc 1848-184915. Neoabszolutizmus és kiegyezés 1849-186716. A dualizmus kora 1868-191417. Világháború és forradalmak 1914-191918. A Horthy-korszak 1920-194119. A második világháborúban20. Demokráciából diktatúrába 1944-195621. Az 1956-os forradalom és szabadságharc22. A Kádár-korszak 1956-198923. A Harmadik Magyar Köztársaság 1989-200724. Időrendi áttekintés.",
                    ISBN = "9789630969598",
                    ProductImage = File.ReadAllBytes("nagy_uralkodok_es_kiskiralyok_a_tizenharmadik_szazadban.jpg"),
                    PageNumber = 0,
                    Price = 990,
                    PublishingYear = 2013
                },
                new Book
                {
                    Id = new Guid("aea9916d-a802-4499-a7e7-0b31e12c2aac"),
                    Title = "A humanista Janus Pannonius és Mátyás könyvtára",
                    Description = "Mátyást uralkodásának első felében lefoglalták a török ellenes háborúk és hódítások. Hírnevét egyrészt az oszmán expanziós törekvések visszaszorításával, másrészt budai udvarának humanista központtá alakításával vívta ki. A fiú, aki elnyerte a koronát, dicsőségben uralkodott több mint 30 éven át, szuperhatalommá tette országát és páratlan kulturális fellendülést indított útjára. Európa hírű könyvtárának létrehozásában kimagasló szerepe volt nevelőjének, Vitéz János kancellárnak és Janus Pannoniusnak, a pécsi püspöknek, aki itáliai bevásárló körútjai során nemcsak a király, hanem maga számára is vásárolta/készíttette a könyveket. Az Itáliában tanult Janus Pannonius/polgári nevén Csezmicei János a Hunyadiak korának és egyben a magyar humanizmus kiemelkedő alakja, az első magyar lírikus, a hazai latin nyelvű humanista költészet megteremtője: először írt a magyar tájról, édesanyjáról, mesteréről, barátairól, betegségéről, Mátyás király háborúiról...Több, mint 400 verset írt latin és görög nyelven (utóbbiak lefordítása még várat magára), sőt prózákat is. Mátyás trónra lépésének évében tért haza. Janus költészete nyomán megszületett a magyar humanista líra: legérettebb gyümölcseit lírai epigrammáiban, főként elégiáiban hozta Magyarországon. Janus a pécsi püspökség mellett különböző funkciókat, diplomáciai feladatokat töltött be a királyi udvarban. Mátyás király ellen a főurak lázadásához csatlakozott nagybátyjával együtt, mivel nem értett egyet Mátyás király nyugati hódításaival abban a korban, amikor délről a török fenyegetése állandó volt. Mátyás udvarában Attila-kultusz dívott, így Janus munkásságában fellelhető a hun öntudat, amely nemzeti önérzetében jelenik meg. Kegyvesztetten halt meg. Janus a humanista világi líra megteremtője és legkiemelkedőbb művelője, az első magyar költő, aki világhírnévre tett szert. Egy-két évtized alatt a török játszi könnyedséggel leigázta Magyarországot, amely nagyhatalomból prédává vált kiszolgáltatva az oszmán szultánoknak és a Habsburg császároknak. A történelem nagyon kevés példát ismer arra, hogy egy erős és gazdag állam ilyen gyorsan hulljon szét. Az Appendix rész a világháborúk poklát megjárt két szomorú sorsot mutat be.",
                    ISBN = "9789633023334",
                    ProductImage = File.ReadAllBytes("a_humanista_jannus_pannonius_es_matyas_konyvtara.jpg"),
                    PageNumber = 220,
                    Price = 3300,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("a6ebad27-d6d1-430f-8896-a0536d0a51f2"),
                    Title = "Egy szokatlan bűnöző krónikája",
                    Description = "Az antikapitalista érzelmű brit egyetemi hallgató, Stephen Jackley 2007-ben, a globális pénzügyi válság hajnalán úgy dönt, itt az ideje a kezébe venni a dolgokat. Mivel a kapitalizmus mérhetetlen szegénységhez és ökológiai katasztrófához vezet, a magányos és elszigetelt Stephen egy hatalmas Szervezet létrehozását tervezi, amely változtathat a dolgokon. És mivel ez rengeteg pénzbe kerül, Stephen bankrablónak áll. Modern Robin Hoodként küzd a mindent tönkretevő gazdasági rendszer és a bankok ellen: el akarja venni a gazdagok pénzét, hogy a szegényeknek adja. Húszéves, magányos, tapasztalatlan elkövető: aligha fogadna bárki is nagy tétben vállalkozása sikerére. Stephen azonban fél év leforgása alatt tíz rablási kísérletet hajt végre, és több ezer fontot zsákmányol úgy, hogy az angol rendőrség mindvégig sötétben tapogatózik - holott még a DNS-mintáját is megszerzik rögtön az első, balul sikerült bankrablás alkalmával. Stephen persze végül lebukik, és arra is fény derül, hogy Asperger-szindrómás. És ezzel tovább nő a megválaszolásra váró kérdések száma. Harcolhatunk-e nemtelen eszközökkel a nemes cél érdekében? Enyhítő körülmény-e az Asperger-szindróma, vagy épp ellenkezőleg? Felelőssé tehető-e Stephen működésképtelen családja a később általa elkövetett bűncselekményekért? És vajon tud-e új életet kezdeni valaki ilyen a múlttal a háta mögött? Ben Machell dokumentumregénye a krimi izgalmát pszichológiával és társadalomkritikus gondolatokkal övező, vérbeli 21. századi olvasmány, amely után másként tekintünk a jól ismert, mindennapi dolgokra is.",
                    ISBN = "9789635822942",
                    ProductImage = File.ReadAllBytes("egy_szokatlan_bunozo_kronikaja.jpg"),
                    PageNumber = 336,
                    Price = 4599,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("9f79277b-b043-4c05-bf25-dfd1151f8074"),
                    Title = "A háború öröksége",
                    Description = "A HÁBORÚ és a COURTNEY HÁBORÚ című könyvek folytatása. A háborúnak vége, Hitler meghalt, de a gonosz öröksége mégis él. Saffron Courtney és férje, Gerhard csak most élte túl a brutális konfliktusokat, de Konrád, Gerhard náci testvére még mindig szabad, és elhatározza, hogy visszaszerzi a hatalmat. A veszélyes macska-egér játék keretében kavarognak a pár elleni cselekmények, amelyek kihatnak egész Európára... Kenyában, ugyanakkor felszínre tör az elégedetlenség, a helyzet erőszakossá válik, és a Courtney-család birtoka veszélybe kerül. Leon Courtney itt veti be magát és harcol a birtokért és a szabadságért.",
                    ISBN = "9789639124684",
                    ProductImage = File.ReadAllBytes("egy_szokatlan_bunozo_kronikaja.jpg"),
                    PageNumber = 456,
                    Price = 4299,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("9f79277b-b043-4c05-bf25-dfd1151f8074"),
                    Title = "A háború öröksége",
                    Description = "A HÁBORÚ és a COURTNEY HÁBORÚ című könyvek folytatása. A háborúnak vége, Hitler meghalt, de a gonosz öröksége mégis él. Saffron Courtney és férje, Gerhard csak most élte túl a brutális konfliktusokat, de Konrád, Gerhard náci testvére még mindig szabad, és elhatározza, hogy visszaszerzi a hatalmat. A veszélyes macska-egér játék keretében kavarognak a pár elleni cselekmények, amelyek kihatnak egész Európára... Kenyában, ugyanakkor felszínre tör az elégedetlenség, a helyzet erőszakossá válik, és a Courtney-család birtoka veszélybe kerül. Leon Courtney itt veti be magát és harcol a birtokért és a szabadságért.",
                    ISBN = "9789639124684",
                    ProductImage = File.ReadAllBytes("egy_szokatlan_bunozo_kronikaja.jpg"),
                    PageNumber = 456,
                    Price = 4299,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("305e9235-2d1a-4fe0-adaa-139810ede534"),
                    Title = "Tíz nap a világvége előtt",
                    Description = "Miért nem tud hinni abban, hogy túlélik? Két robbanásfal halad egymással szemben, kilométerről kilométerre emésztik fel a Földet. Senki nem tudja, honnan erednek, de megállíthatatlanul közelednek egymás felé, hogy tíz nap múlva egyesüljenek. Menekültek áradata indul meg az Atlanti-óceán partja felé, ahol a legtovább lehet életben maradni. A véletlen egymás mellé sodor öt embert, három férfit és két nőt. Együtt vágnak neki a bedugult utaknak - és életük utolsó tíz napjának. Kezdetét veszi a könyörtelen visszaszámlálás. Egy letehetetlen road movie - térben és lélekben. És te? Te mit tennél, ha csak tíz napod maradna az életből? \"Ez az apokaliptikus regény lebilincselőbb, mint egy sorozat. Letehetetlen.\" - Elle\"Lélegzetelállító regény, feszültséggel teli versenyfutás az idővel.\"- Book-en-stock, babelio.com\"Feszített ritmusú, jó cselekményvezetésű, megkapó történet arról, hogyan viselkedik az ember a halál torkában. Nem lennék meglepve, ha néhány év múlva azt hallanám, film készül a regényből.\"- Analire, babelio.com Mélyedj el! Kapcsolj ki! Légy jelen!",
                    ISBN = "9789634578185",
                    ProductImage = File.ReadAllBytes("tiz_nap_a_vilagvege_elott.jpg"),
                    PageNumber = 416,
                    Price = 3999,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("afadca6c-25e1-432a-8ad7-f65cd076bd27"),
                    Title = "Metszéspontok",
                    Description = "A kötet tizennégy novellája remek példája Archer kitűnő jellemábrázoló képességének, izgalmas témaválasztásának. Témái között szerepel a szerelem, a felebaráti segítségnyújtás, illetve a jog és a jogász olykor meglepően alakuló viszonya is.",
                    ISBN = "9789634525578",
                    ProductImage = File.ReadAllBytes("metszespontok.jpg"),
                    PageNumber = 307,
                    Price = 3690,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("97037cd2-11e2-4f83-8484-bf39224ba7c4"),
                    Title = "Párbaj",
                    Description = "Csupán egyetlen dolog közös bennük... Ugyanazon a napon, 1906. április 18-án két újszülött látja meg a napvilágot két fiúgyermek: egyikük Bostonban, egy gazdag bankárcsalád sarjaként, a másikuk egy eldugott lengyelországi faluban. Két évtized múltán William Kane, a nagy reményű bankár és Abel Rosnowski, a nincstelen, ámde céltudatos és eltökélt bevándorló útjai keresztezik egymást. Miközben mindketten elszánt harcot folytatnak a sikerért, nem kerülhetik el a végzetüket: a sors ugyanis úgy rendelte, hogy megmentsék - és tönkretegyék - egymás életét. Jeffrey Archer remekműve, amelyet első kiadása óta milliók olvastak szerte a világon, egyaránt bővelkedik drámai jelenetekben, kalandokban, nagy összecsapásokban és megrázó mozzanatokban. Egymást követik a váratlan fordulatok, egészen a legutolsó mondat végső csattanójáig.",
                    ISBN = "9789634523796",
                    ProductImage = File.ReadAllBytes("metszespontok.jpg"),
                    PageNumber = 608,
                    Price = 4490,
                    PublishingYear = 2020
                },
                new Book
                {
                    Id = new Guid("6b8dcca7-9c29-4d37-95e7-e921cb971b6d"),
                    Title = "Végtelen az út, amelyen te jársz 1. rész",
                    Description = "Az emberiség eddigi történetének legnagyobb felfedezése, az ember legfőbb álmának beteljesülése áll a szerző könyvének fókuszában. De valóban áldás-e ez a felfedezés fajunk jövőjére nézve, ahogy elsőre gondolnánk? Vagy, ha jobban a dolgok mélyére ásunk, arra jövünk rá, hogy mégis inkább átok? Főhősünk, miután felismeri felfedezése igazi arcát, menekülni kényszerül, sarkában a kormánnyal és az alvilág leggátlástalanabb bandájával, hogy időt nyerjen tervének megvalósításához, amellyel megmentheti a világot és saját lelkiismeretét. Esélyei csekélyek, csak misztikus múltjából nyert tapasztalataira és pár támogatójára számíthat. Vajon végül sikerrel jár? Ennek a fordulatos és izgalmas kalandregénynek az első részében, amelyet átsző a főhős megdöbbentő múltja, emberszeretete és szárba szökkenő szerelme, korunk egyik sokat kutatott kérdésére kapunk választ.",
                    ISBN = "9786156153975",
                    ProductImage = File.ReadAllBytes("vegtelen_az_ut_amelyen_te_jarsz.jpg"),
                    PageNumber = 416,
                    Price = 3990,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("2df74dab-d206-4dff-9fcf-5e29285ed8cc"),
                    Title = "Likvidált szerelem",
                    Description = "A 2010-es években az ISIS terrorszervezet tagjai azon munkálkodtak, hogy észrevétlenül eljussanak Európa nagyvárosaiba, ahol az újraszerveződő alvó sejtek a kalifátus parancsára bármikor képesek lettek nagyszabású terrortámadások végrehajtására. A különlegesen kiképzett izraeli csapat, élén Dovval ezeket az embereket hivatott kiiktatni. Munkájuk során ezernyi veszély leselkedik rájuk, és minden tudásukra szükségük van a feladat végrehajtásához. Azonban a harcosok emberi oldala is megmutatkozik, amikor az izraeli csapatvezető szerelmes lesz a titokzatos arab szépségbe, aki a terroristák fedő szervezeténél dolgozik. Lehet jövője egy eleve halálra ítélt szerelemnek? Feloldhatók az évezredes konfliktusok, és győzedelmeskedhet az emberi jóság? Bihary Péter elképesztő fordulatokban, izgalmas akciókban bővelkedő regénye kegyetlen őszinteséggel mesél életről, szerelemről, halálról.",
                    ISBN = "9789635701056",
                    ProductImage = File.ReadAllBytes("likvidalt_szerelem.jpg"),
                    PageNumber = 247,
                    Price = 4199,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("3f0d37d6-1516-4192-9b20-2581b01858ca"),
                    Title = "Elrabolt jövő",
                    Description = "Dov terroristák elleni harca folytatódik, ám a küzdelem ezúttal még személyesebb, mert a hozzá legközelebb állók élete van veszélyben. A hamis személyazonosság álcája nem képes megvédeni egy számára fontos személyt, akit elrabolnak. De ki is ő valójában? Mindenkinek vannak rejtegetnivalói, ám amikor a holtak titkai nem maradhatnak tovább a felszín alatt, a törékeny világ darabjaira hullik. Dovnak erősnek kell lennie, és megmozgatni kapcsolati hálóját, hogy a szeretteit újra biztonságban tudhassa. Szíriai összecsapás, török támadás, orosz katonai alakulatok, a CIA befolyása - többek között ezek teszik elképesztően izgalmassá és letehetetlenné Bihary Péter A holtak arca című sorozatának második kötetét, amelyben Dov újabb kihívások elé néz.",
                    ISBN = "9789635701209",
                    ProductImage = File.ReadAllBytes("elrabolt_jovo.jpg"),
                    PageNumber = 250,
                    Price = 4199,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("3f0d37d6-1516-4192-9b20-2581b01858ca"),
                    Title = "Léghajó",
                    Description = "A Mexikói-öböl felett egy hőlégballont sodor a szél, mindössze egyetlen utasa van, Louis Hugo, aki akarata ellenére került a gondolába. Eszméletlen volt, amikor a hajót magával ragadta a vihar, és csak ködös emlékképei vannak arról, hogy mi történt vele indulás előtt. Szerencsére üzemanyag van elégséges, de irányítani már képtelen az elszabadult szerkezetet. Az elemek játékszerévé válik, és ahogyan az idő telik, Louis úgy döbben rá arra, hogy eddig az élete is pontosan úgy hánykolódott, mint az elszabadult léghajó. Csigalassúsággal követik egymást a kényszerből ébren töltött órák, nem alhat el, mert akkor a vízbe zuhan, ami biztos halál lenne. Élete elfeledettnek hitt pillanatai bukkannak elő sorra, gyermekkorától egészen a közelmúltig, és mire feltűnnek Mexikó partjai, már arra is rájön, hogy miért kapta a sorstól ezt az embert próbáló utazást.",
                    ISBN = "9786150097763",
                    ProductImage = File.ReadAllBytes("leghajo.jpg"),
                    PageNumber = 195,
                    Price = 2490,
                    PublishingYear = 2021
                },
                new Book
                {
                    Id = new Guid("dc747336-3a8d-4def-9bfd-fb0459c79941"),
                    Title = "A holtak erdeje - és más titokzatos történetek",
                    Description = "A huszadik század első felének egyik legkiemelkedőbb fantasztikus és horror-szerzője kétségtelenül Algernon Blackwood. Jelentőségét mi sem szemléltetheti jobban, mint hogy a természet és a természetfeletti által átjárt és áthatott művei napjainkban, egy évszázad múltán is tökéletesen összetalálkozhatnak a közönség ízlésével. Kötetünk tartalmazza az író két, talán legismertebb novelláját - ezek a Füzek és A wendigo. Ám életműve még számtalan kincset és meglepetést rejt...",
                    ISBN = "9786156173485",
                    ProductImage = File.ReadAllBytes("a_holtak_erdeje.jpg"),
                    PageNumber = 184,
                    Price = 2800,
                    PublishingYear = 2022
                },
                new Book
                {
                    Id = new Guid("14f33f5d-7948-4f7f-87b8-cae38ebad87d"),
                    Title = "Nincs kegyelem",
                    Description = "\"Wardes csendbiztos gyanútlanul állt a folyóparton, mert a Húsos Farkas fegyvertelen kézzel lépett eléje a bokrok közül, és megemelte a kalapját. De nem mondta azt, hogy jó napot, hanem kivett a kalapjából egy revolvert, és főbe lőtte vele a csendbiztost. Mindez oly gyorsan és váratlanul történt, hogy a Denveri Kopó hírhedt ügyessége sem előzhette meg a halálos lövést. Hej, Fernandez rikoltotta a rablóvezér, akit széles arca és vastag ajkai miatt neveztek Húsos Farkasnak. Egy megrettent mesztic lépett ki a bokrok közül, és tétován nézett hol a halottra, hol gazdájára, aztán hebegve mondta: Ez... meghalt uram. Azt hitted tán, hogy dalolni fog, miután főbe lőttem? Cipeld oda a bokrok mögé, te barom! Mikor Wardes teteme a bokrok mögött volt, Húsos Farkas parancsot adott Fernandeznek: Hívd a fiúkat! De ne szólj arról, ami történt. Ó, Farkas... Ez nem volt igazi harc... Na és?! Tán jártatni akarod a szádat? Fernandez néma, és Fernandez nem lát. A Farkas az ő ura felelte remegve, mert a hatalmas rabló szeme villant, és a revolver felé nyúlt Csak még azt mondd meg: ez volt a híres csendbiztos, akit Keletről küldtek ide? Eltaláltad! Ez a Denveri Kopó! Wardes, aki híresebb az Államokban, mint amilyen Buffalo Bill volt valamikor! Wyomingban kipusztította a rablókat. Senki sem menekült meg előle, akit üldözött. Most itt van! És belerúgott a tetembe. Eredj!\"",
                    ISBN = "9786155476617",
                    ProductImage = File.ReadAllBytes("nincs_kegyelem.jpg"),
                    PageNumber = 144,
                    Price = 1490,
                    PublishingYear = 2015
                },
                new Book
                {
                    Id = new Guid("e7f2e4cf-7d49-40e0-b8dc-5edf95bfdd72"),
                    Title = "A pokol zsoldosai",
                    Description = "\"A hadvezetőség megállapította, hogy a szökések száma az idegenlégióban negyven százalékkal emelkedett az utolsó hónapban. Az okkal tisztában voltak. A caid ügynökei francia nyelven írt röpiratokat terjesztettek. A röpiratok tudtára adják a gyarmati katonáknak, hogy azokat, akik Lebel puskájukat bármelyik lázadó törzsnél, de különösen a Tafilalet-oázisban beszolgáltatják, semmiféle bántódás nem éri Tirone éppen egy ilyen levelet olvasott. A fiatal Berg ült melléje. Beteg vagy? A fejem nagyon nyilall mondta Berg. Nem bírod soká ezt a klímát. Én is azt hiszem. Később azután nem fog fájni a fejed, csak tompa leszel és kábult. Ilyenkor jön a cafard. Az mi? Afrikai téboly. a meleg, az egyhangúság, az örökös sárga és fehér színek tompa hülyeséget okoznak. az ember néhány hétig gondolat és szó nélkül jár. iszik, de nem rúg be. néha halkan dúdol magában, vagy hirtelen mosolyogni kezd. Azután elhatározza, hogy ír a köztársasági elnöknek, vagy rájön arra, hogy neki a felkelők élére kellene állnia. Végül azon veszi észre magát, hogy nem bírja ki az őrmester szemöldökét, amint folyton rángatózik, és hogy ez megszűnjön, nagyot csap a puskatussal az egyik szemöldökre... Tényleg kibírhatatlan... folyton rángatózik a szemöldöke... A cafard nagy veszély. a legtöbb légionista átment már rajta. Az a kutyaság, hogy ha valaki gyilkol, akkor a cafard enyhítő körülmény, de azért felkötik a gyilkost. Nem volna kedved eljönni innen? Eljönni?... Hová?... A Tafilaletbe. Közel vagyunk hozzá. Már a negyedik pohár rumot itta. Berg is ivott egy keveset. A hőség még jobban kínozta, de felélénkült kissé az alkoholtól. Végighallgatta Tirone-t. Nem tudom mondta Berg. Holnapig gondolkozom. Az óra zörrent egyet és elnémult. Negyed hat volt. a legyek ellepték a rumos pohár szélét. Mellettük pergett a kocka.\"",
                    ISBN = "9786155476709",
                    ProductImage = File.ReadAllBytes("a_pokol_zsoldosai.jpg"),
                    PageNumber = 176,
                    Price = 1490,
                    PublishingYear = 2015
                },
                new Book
                {
                    Id = new Guid("8db5c5c7-87d8-47bf-ace2-2a422322d410"),
                    Title = "Barack Obama szupersztár",
                    Description = "Két elnöki ciklus és Biden elnökké választása után többé senki sem hiszi, hogy Barack Obama valamiféle divatfiguraként, netán szerencselovagként jutott volna a világ legfontosabb közhatalmi tisztségébe. Ettől azonban útja a Fehér Házig csak még izgalmasabb. A kenyai kecskepásztor unokája elkélpesztő pályát fut be, mely egy fehér édesanya és egy indonéz második férj jóvoltából vagy hibájából egy djakartai muzulmán iskolában kezdődik, később a Harvardon és a Columbia egyetemen folytatódik. Egy ügyvédi irodában gyakornokoskodunk Obamával, ahol egy Michelle nevű langaléta fekete lány eleinte észrevenni se hajlandó a jóképű és szorgalmas, megnyerő, de talán még nem eléggé magabiztos félvér fiatalembert, aki azonban a magánéletben, később a politikában, az eszelősségig kitartó, bámulatosan megfontolt és céltudatos. A férfi, aki képes elérni, amit akar? Többről van szó. A napjainkban hiánycikké vált politikai tisztességről. Miként a szerző - volt washingtoni tudósító - előszavában olvasható, ez a könyv \"először is azért született meg, mert ez a kisfiúsan mosolygó, színes bőrű és egyéniségű politikus, minden emberi hibájával, fáradékonyságával, ismétlődő retorikai fogásaival és néha szembeötlő hiúságával együtt is jó benyomást tett rám. Másodszor pedig azért, mert már az első alkalommal, amikor az iowai előválasztás utáni győzelmi beszédét hallgattam, megelégedéssel töltött el az érzés, hogy a siker nem mindenütt és nem minden körülmények között gyanús.\"",
                    ISBN = "9789638516275",
                    ProductImage = File.ReadAllBytes("barack_obama_szupersztar.jpg"),
                    PageNumber = 144,
                    Price = 1690,
                    PublishingYear = 2008
                },
                new Book
                {
                    Id = new Guid("b0775fe6-78f7-4d97-adc6-ed55115d90f1"),
                    Title = "'Assassin\'s Creed - Testvériség",
                    Description = "\"Alászállok egy romlott birodalom fekete szívébe, hogy eltapossam ellenségeimet. De Rómát nem egy nap alatt építették, és egyetlen magányos orgyilkos nem lesz képes visszaállítani régi fényét. A nevem Ezio Auditore da Firenze. Ez az én testvériségem.\" Az egykor oly dicsőséges Róma romokban hever. A városban szenvedés és pusztulás az úr, polgárai a kegyetlen Borgia család tehetetlen bábjai. Csak egyvalaki mentheti meg őket a Borgiák zsarnokságától - Ezio Auditore, a orgyilkos hagyományok mestere. Küldetése során Eziónak latba kell vetnie minden képességét. Cesare Borgia, aki apjánál, a pápánál is elvetemültebb és veszélyesebb, nem nyugszik, amíg egész Itáliát meg nem hódította. Mivel ez a köpönyegforgatók kora, az összeesküvők mindenhová befészkelik magukat, még a Testvériség soraiba is…\"Alászállok egy romlott birodalom fekete szívébe, hogy eltapossam ellenségeimet. De Rómát nem egy nap alatt építették, és egyetlen magányos orgyilkos nem lesz képes visszaállítani régi fényét. A nevem Ezio Auditore da Firenze. Ez az én testvériségem.\" Az egykor oly dicsőséges Róma romokban hever. A városban szenvedés és pusztulás az úr, polgárai a kegyetlen Borgia család tehetetlen bábjai. Csak egyvalaki mentheti meg őket a Borgiák zsarnokságától - Ezio Auditore, a orgyilkos hagyományok mestere. Küldetése során Eziónak latba kell vetnie minden képességét. Cesare Borgia, aki apjánál, a pápánál is elvetemültebb és veszélyesebb, nem nyugszik, amíg egész Itáliát meg nem hódította. Mivel ez a köpönyegforgatók kora, az összeesküvők mindenhová befészkelik magukat, még a Testvériség soraiba is…",
                    ISBN = "9789639861350",
                    ProductImage = File.ReadAllBytes("ac_testveriseg.jpg"),
                    PageNumber = 470,
                    Price = 4995,
                    PublishingYear = 2021
                }
            );
        }
    }
}
