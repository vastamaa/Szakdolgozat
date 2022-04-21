-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Ápr 07. 12:42
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `bookstoreapi`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('1b4197aa-e86d-4b91-be80-8b29d5a80f05', 'User', 'User', '2'),
('368ffde5-dfae-4095-9ab9-9da3811b6a85', 'Admin', 'Admin', '1');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` text DEFAULT NULL,
  `UserId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('b7820293-275e-429c-8a46-ad7dd17f51c9', '368ffde5-dfae-4095-9ab9-9da3811b6a85');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(85) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LastName` text DEFAULT NULL,
  `DateOfJoining` datetime NOT NULL,
  `RefreshToken` text DEFAULT NULL,
  `RefreshTokenExpiryTime` datetime NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `FirstName`, `LastName`, `DateOfJoining`, `RefreshToken`, `RefreshTokenExpiryTime`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('b7820293-275e-429c-8a46-ad7dd17f51c9', 'Admin', 'Admin', '2022-03-25 14:28:07', 'f2lLprp7OxBTM5aBRfKa3jiczE22+bd55jb/owQQmZ+Ol8v9maUg6sCSQ7sWoKxUvydXyFQjxg/nMBG/7mss/A==', '2022-04-08 12:29:21', 'Admin', 'ADMIN', 'manope5041@moonran.com', 'MANOPE5041@MOONRAN.COM', 1, 'AQAAAAEAACcQAAAAEAFy3e8pe3B9GbJuckeurjbGgYKhu3kS5BSpo6V2sLN5Hta+KLoLbC7AC3YRhgYyuA==', '32ZY4AGQN7ICXT6LRGQZ3UCEEKB3ZUUB', '2cdcedb4-7bf2-466f-ab8f-5a91c6bfbaec', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `authors`
--

CREATE TABLE `authors` (
  `Id` int(11) NOT NULL,
  `Name` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `authors`
--

INSERT INTO `authors` (`Id`, `Name`) VALUES
(1, 'Jody Houser'),
(2, 'Matthew K. Manning'),
(3, 'Santiago García'),
(4, 'Scott Snyder'),
(5, 'Art Spiegelman'),
(6, 'Randall Munroe'),
(7, 'Robert E. Howard'),
(8, 'Marjorie Liu'),
(9, 'Rick Remender'),
(10, 'Jeff Smith'),
(11, 'Ed Brubaker'),
(12, 'Bartosz Sztybor'),
(13, 'Charles Soule'),
(14, 'Howard Phillips Lovecraft'),
(15, 'Walter Simonson'),
(16, 'Andrew Uffindell'),
(17, 'Gombos László'),
(18, 'Tuvja Raviv'),
(19, 'Zsoldos Attila'),
(20, 'Somos Zsuzsanna'),
(21, 'Ben Machell'),
(22, 'Wilbur Smith'),
(23, 'Manon Fargetton'),
(24, 'Jeffrey Archer'),
(25, 'Kenéz Péter'),
(26, 'Bihary Péter'),
(27, 'Kőműves Tamás'),
(28, 'Algernon Blackwood'),
(29, 'Rejtő Jenő'),
(30, 'Bokor Pál'),
(31, 'Oliver Bowden'),
(32, 'Jennifer Lynn Barnes'),
(33, 'Bartos Erika'),
(34, 'Adam Silvera'),
(35, 'J. K. Rowling'),
(36, 'Fazekas Anna'),
(37, 'Julia Donaldson'),
(38, 'Louisa May Alcott'),
(39, 'Richard Scarry'),
(40, 'Beth Kempton'),
(41, 'Yutaka Yazawa'),
(42, 'Dr. Paul Conti MD'),
(43, 'Eckhart Tolle'),
(44, 'Kovács József'),
(45, 'Stéphane Garnier'),
(46, 'Shunmyo Masuno'),
(47, 'Dr. Julie Smith'),
(48, 'Dr. Mike Dow'),
(49, 'Jan Andersen'),
(50, 'Andrea Owen'),
(51, 'Sol Rayond'),
(52, 'Grandpierre K. Endre'),
(53, 'Nógrádi György'),
(54, 'Arthur Brand'),
(55, 'Kollai István'),
(56, 'Samin Nosrat'),
(57, 'Tóthné Libor Mária'),
(58, 'Wichmann Anna'),
(59, 'Rézi néni'),
(60, 'Tanja Dusy'),
(61, 'Radvánszky Béla'),
(62, 'Gaál Bence'),
(63, 'Karen Edwards'),
(64, 'Dirk Wallenburg'),
(65, 'Bud Spencer'),
(66, 'Gáspár Bea'),
(67, 'Vida József');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `books`
--

CREATE TABLE `books` (
  `Id` int(11) NOT NULL,
  `Title` text DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `ISBN` text DEFAULT NULL,
  `ImgLink` text DEFAULT NULL,
  `PageNumber` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `PublishingYear` int(11) NOT NULL,
  `PublisherId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `books`
--

INSERT INTO `books` (`Id`, `Title`, `Description`, `ISBN`, `ImgLink`, `PageNumber`, `Price`, `PublishingYear`, `PublisherId`) VALUES
(1, 'Stranger Things: Tűzben égve', 'A Netflix népszerű STRANGER THINGS sorozata és a HAT c. képregényben megismert szereplők története végre folytatódik!\r\n\r\nÉvekkel azután, hogy megszöktek Dr. Brenner laboratóriumából, Marcy és Ricky még mindig próbálnak beilleszkedni a normális életbe. Amikor azonban hírét veszik, hogy a laboratórium bezárt, elindulnak megkeresni Marcy ikertestvérét, a tűzgyújtási képességgel rendelkező Kilencet. Hamarosan rájönnek, hogy barátjukat nem csak kiszabadítaniuk kell, de kimenteniük is saját elméjének rabságából, mielőtt Jamie mindent elpusztítana maga körül. És ahogy közelebb kerülnek Kilenchez, egyre több titokra jönnek rá a Dr. Brenner kisérleteivel kapcsolatban, olyan titkokra, ami mindannyiukat mélyen megrázza...', '9789634976578', 'https://s02.static.libri.hu/cover/ee/5/8455925_5.jpg', 112, 4990, 2022, 1),
(2, 'Bosszúállók 1. - Új veszély', 'Elkezdődött a Bosszúállók kalandjainak fergeteges új korszaka!\r\nEgy új csapat áll össze, hogy megküzdjenek egy hihetetlenül óriási fenyegetéssel, ami furább és féktelenebb, mint amivel a szuperhősök valaha találkoztak!\r\nAz \"Új veszély\" tökéletes választás kezdő olvasóknak és rajongóknak egyaránt, ugyanis Metthew K. Manning író és Jon Sommariva rajzoló lehetővé teszik, hpgy most először korosztálytól függetlenül élhessük át a Bosszúállók képregények nyújtotta szenzációs izgalmakat.', '9789639998896', 'https://s04.static.libri.hu/cover/7d/9/7553588_5.jpg', 72, 990, 2021, 2),
(3, 'Bosszúállók 2. - Rubinvilág', 'A Bosszúállók kalandjainak fergeteges új korszaka folytatódik!\r\nA Föld Legnagyobb Hőseinek legújabb kalandjában mágia és puszta erő feszül egymásnak, hamisítatlan Marvel stílusban!\r\nThor, Marvel Kapitány és Doktor Strange eltűntek! Vajon képesek lesznek a Bosszúállók időben rátalálni barátaikra, miközben még rettenetes rémségekkel is meg kell küzdeniük nélkülük?\r\nMatthew K. Mamming író és Jon Sommariva rajzoló kötete kiváló választás kezdő olvasóknak és rajongóknak egyaránt.', '9789635950041', 'https://s04.static.libri.hu/cover/82/0/7896959_5.jpg', 72, 1490, 2021, 2),
(4, 'García! 1.', 'Hatvan éve legenda volt. Aztán eltűnt, nyoma veszett. Mindenki elfelejtette. Most visszatért. A legnehezebb pillanatban. Mert a múlt sosem halhat meg. Spanyolországban a múlt mindig visszatér. És nem felejt.\r\nLebilincselő bűnügyi történet a politikailag megosztott Spanyolországból, amelyben egy fiatal újságírónő és egy hibernációból ébredt régivágású titkos ügynök próbálja kibogozni a szálakat.\r\nA képregény alapján készült sorozat 2022-ben érkezik az HBO Max kínálatába.', '9789635950133', 'https://s02.static.libri.hu/cover/d1/3/8429640_5.jpg', 192, 3990, 2022, 2),
(5, 'Batman - Az utolsó lovag a Földön', 'Bruce Wayne napjainkhoz képest húsz év elteltével ébred fel az Arkham Elmegyógyintézetben. Fiatal. Épelméjű. És... sosem volt Batman.\r\n\r\nHogy összeilleszthesse rejtélyes múltjának darabjait, a Sötét Lovag hosszú útra indul az ismeretlen külvilágban, és találkozik hajdani barátaival és ellenségeivel - vagyis azzal, amivé váltak a jövőben. Elsőként rémséges útitársával, Joker fejével. Ugyanis Joker valamiképpen életben maradt levágott feje lesz Batman démoni idegenvezetője az apokalipszis sújtotta DC-univerzum poklán át.\r\n\r\nDe ahhoz, hogy kiderítse, mi vezetett ehhez a borzalmas jövőhöz, nyomára kell bukkannia annak a rémísztő és manipulatív hatalomnak, amely romba döntötte a hajdani világot.', '9789634702313', 'https://s02.static.libri.hu/cover/93/9/8387066_5.jpg', 172, 7495, 2022, 3),
(6, 'A teljes Maus', '\"Ezek nem emberek!\" Ha ez a gyűlölettel átitatott mondat egy állam ideológiájává válik, az minden esetben világméretű tragédiához vezet. A náci Németországban a goebbelsi propaganda elhitette az emberekkel, hogy bizonyos embertársaik alsóbbrendűek, akiket el kell pusztítani.\r\nE szörnyűséges, egész Európát érintő történelmi bűntett áldozatainak állít emléket Art Spiegelman Pulitzer-díjas képregénye, a Maus. A szereplők antropomorf állatok: egérfejű zsidók, macskafejű németek és kutyafejű amerikaiak. Az ő sorsukon keresztül ismerjük meg a holokauszt megrázó eseményeit és következményeit.\r\nA történet gerincét Spiegelman lengyel származású apjának magnószalagra rögzített visszaemlékezései alkotják, így a Maus fikciós, önéletrajzi és dokumentumkötet egyben. Műfajteremtő, egyetemes érvényű irodalmi alkotás egy szégyenletes korszakról, mely nem merülhet feledésbe.', '9789634333678', 'https://s02.static.libri.hu/cover/e4/3/4564753_5.jpg', 296, 3990, 2021, 4),
(7, 'How To - Wie man\'s hinkriegt', 'Für jede Aufgabe, die sich uns stellt, gibt es einen richtigen Weg, einen falschen, und einen, der so offensichtlich absurd ist, dass man ihn niemals in Betracht ziehen würde. -How to- ist eine Anleitung zu diesem dritten Ansatz. Es zeigt uns, wie wir digitale Daten versenden, indem wir USB-Sticks an Zugvögeln befestigen. Wie wir unserem Auto Starthilfe geben, indem wir elf Jahre auf eine Sonneneruption warten. Wie wir herausfinden, ob wir zur Generation der Babyboomer gehören oder ein Kind der Neunziger sind - nämlich, indem wir die Radioaktivität unserer Zähne messen lassen. Und wir erfahren, wie wir endlich pünktlich zu Verabredungen kommen: indem wir mal eben den Mond zerstören. Mit seinen berühmten Strichzeichnungen erklärt Randall Munroe, wie man einfache Probleme auf die allerschwierigste Weise bewältigen kann. Wie schon sein Bestseller -What if?- ist -How to- witzig und horizonterweiternd und hilft uns zu verstehen, welche wissenschaftlichen und technischen Phänomene unserem Alltag zugrunde liegen.', '9783328600916', 'https://s05.static.libri.hu/cover/c5/5/5838626_5.jpg', 383, 8490, 2019, 5),
(8, 'Mi lenne, ha?', '\"Néha az is felemelő érzést jelent, ha nem döntjük romba a világot\"\r\n\r\nTudják, mekkora az az erő, amellyel Yoda mester felemelte az űrhajót a mocsárból? Sokan vakarjuk a fejünket, amikor gyermekünk vagy gyermekkorú ismerősünk furcsánál furcsább kérdéseket tesz fel, a legkülönfélébb tudományágakban. Randall Munroe szülei a fejvakaráson túl megpróbálták megválaszolni ezeket, így az érdeklődő gyermekből érdeklődő felnőtt lett, aki kedvenc kérdéseit hamarosan vicces formában válaszolta meg saját honlapján. A szerző nélkül soha nem tudnánk meg, hogy valójában, tényleg milyen nehéz megtalálni a lelki társunkat, vagy hogy mi történik egy marhaszelettel, ha (megfelelő magasságból) földre dobjuk. Egy biztos: a szerző gondolatmeneteinek fele a Föld elpusztításával végződik, így ajánlatos komolyan venni a figyelmeztetést: Ezt otthon semmiképpen ne próbálja ki!', '9789632933689', 'https://s06.static.libri.hu/cover/b5/8/1242730_5.jpg', 397, 4490, 2021, 6),
(9, 'Conan, a barbár - Elveszett legendák', 'Conan, a kimmériai barbár három története egy Atlantisz elsüllyedése utáni és az ismert ókori civilizációk felemelkedését megelőző, elképzelt világba, a hybóriai korba vezet vissza bennünket. Conan magányosan, mindenhol idegenként járja a világot. Ha megfizetik, szembeszáll gonosz varázslópapokkal, félelmet nem ismerő, vad bennszülöttekkel, kígyónyelvű nagyurakkal. \r\nMódszerei, barbársága gyakran kelt ellenérzést a civilizált emberek szemében.\r\nÁm eljön az idő, amikor csak ő segíthet...\r\nAz Éditions  Glénat francia képregénykiadó 2018-ban hadat üzent az amerikai Marvelnek és a Dark Horse-nak. Megbízta minden idők legsikeresebb francia képregényrajzolóit, hogy alkossák újra Robert E. Howard  1932-ben kitalált  hősének,  Conannak, a barbárnak a történeteit. A legyőzhetetlen  kimmériai harcos  kalandjai 21 történetben jelentek meg az elmúlt években, hatalmas sikert aratva szerte a világon. Ezekből választottunk ki hármat, talán a legjobbakat, hogy egyetlen kötetben bemutassuk őket a magyar képregényrajongók számára.', '9786158152747', 'https://s02.static.libri.hu/cover/2e/9/8167416_5.jpg', 184, 6930, 2021, 7),
(10, 'Monstress - Fenevad - Első kötet - Ébredés', 'Farkasvérű Maikát szörnyetegnek csúfolják... és nem is állnak messze a valóságtól.\r\n\r\nA világot felforgatta a szörnyű háború, amit az emberek gyűlölt ellenségeik, az arkánok ellen vívtak. Maika nem csak a fél karját, de szabadságát is elvesztette a harcokban, rabszolgaként adják el Zamora boszorkányainak, akik az arkánok véréből nyerik erejüket. Azt azonban még a nagyhatalmú mágusnők sem tudják, hogy a lány testében egy ősi, kozmikus erejű, éhező fenevad szunnyad, amely csak az alkalomra vár, hogy kitörhessen...', '9789634700883', 'https://s05.static.libri.hu/cover/a9/e/5258517_5.jpg', 208, 6495, 2019, 3),
(11, 'Orgyilkos osztály - Deadly Class 3. - Kígyóverem', 'A Haláltanok Királyi Iskolájában, a hírhedt orgyilkosképző tanintézményben a vége felé közeledik a tanév. Marcus Lopez problémái meglehetősen eltérnek korosztályának tipikus gondjaitól. Múltját számos bűntett - és jó néhány holttest - csúfítja, és ez immár barátait is komolyan veszélyezteti.\r\n\r\nMarcus világában könnyen rosszra fordulnak a dolgok. Amikor őt és társait újabb csapás éri, az eddigi barátságok megkérdőjeleződnek, a korábbi szövetségek és vonzalmak átrendeződnek, és ő rádöbben, hogy ez a darabjaira hulló, torz világ a kíméletleneké és az önzőké, a hatalom pedig azok jussa, akiknek semmi sem drága azért, hogy megszerezzék. Ebben a világban a szerelem, a barátság, a tisztesség csak célponttá tesz és a mélybe ránt.\r\n\r\nAmikor pedig úgy tűnik, ennél rosszabb már nem lehet, elérkezik a tanév vége - és ebben az iskolában a záróvizsgát halálosan komolyan veszik!', '9789634701088', 'https://s06.static.libri.hu/cover/8b/d/5601294_5.jpg', 116, 4590, 2019, 3),
(12, 'Konc 1. - Távozás Koncfalváról', 'Ebben az elképesztően humoros és kalandos képregényben a három Konc kuzin, miután elmenekül Koncfalváról, eltéved egy hatalmas, ismeretlen sivatagban. Külön utakon, de mindegyikük egy sűrű erdővel borított, titokzatos völgybe jut,\r\namelyet csodálatos és rémisztő teremtmények népesítenek be. A völgyből télvíz idején nincs kiút, így az igazi kaland csak most kezdődik, hiszen meg kell mente- niük az idilli völgyet az ellenük szervezkedő gonosz erők támadásától.\r\nA sorozat 11 Harvey-díj és 10 Eisner-díj nyertese, beleértve a Legjobb író-rajzoló és a Legjobb humoros kiadvány díját is.', '9789639998773', 'https://s01.static.libri.hu/cover/cf/e/6474636_5.jpg', 144, 2690, 2020, 2),
(13, 'Konc 4. - A Sárkányölő', 'Konc Fülének sokféle veszéllyel kell szembenéznie a sorozat negyedik kötetében: Ben nagyanyóval és Tövissel karöltve a félelmetes Dokkirállyal, a patkánylények uralkodójával szemben kell megvédeniük magukat. Eközben a Csuklyába Öltözött totális háborúra buzdítja hadseregét, Tövist pedig egyre furcsább álmok gyötrik. A helyzetet súlyosbítja, hogy Ben nagyanyó eltűnik, Svindli pedig elhiteti a falusiakkal, hogy ő a hatalmas Sárkányölő. Amikor - legnagyobb meglepetésére - valóban elkapja a Vörös Sárkányt, szembe kell néznie saját ígéretével és napfelkeltekor megölni a sárkányt.\r\nA sorozat 11 Harvey-díj és 10 Eisner-díj nyertese, beleértve a Legjobb író-rajzoló és a Leghumorosabb kiadvány díját is.', '9789639998919', 'https://s01.static.libri.hu/cover/1e/8/8116392_5.jpg', 176, 2690, 2021, 2),
(14, 'Alvilág 2. - Lawless', 'Húsz évvel ezelőtt, Tracy Lawless a város bűnnel teli utcáiról a katonaságba menekült, és soha nem nézett vissza. Most a múltja visszahúzza az iraki és afganisztáni sivatagból, hogy megtudja, ki hagyta a bátyját holtan fekve egy sikátorban. Miközben a testvére, Rick alvilági életébe beszivárogva a családja történetének roncsait ássa elő, az egyetlen dolog, amire Tracy rájön, hogy már senki sem tudja, ki is ő. A nemtudás pedig gyakran vezet halálhoz...\r\nA Lawless a díjnyertes szerzőpáros Alvilág című sorozatának második kötete.\r\nA 21. század legelismertebb bűnügyi képregénye: hat Eisner- és Harvey-díj nyertese, beleértve a Legjobb író és a Legjobb új sorozat díját is.', '9789639998995', 'https://s04.static.libri.hu/cover/1b/1/8116393_5.jpg', 128, 3990, 2021, 2),
(15, 'The Witcher: Sötét emlékek', 'Geralt, a vaják felkérést kap Badreine város elöljárójától, hogy legyen segítségére, mert a településről gyermekeket raboltak el. Geralt elfogadja a megbízást, majd beleveti magát egy gyászoló anya és eltűnt gyermeke titokzatos múltjának felderítésébe. Ám saját nyomasztó víziói közepette a szörnyvadász hamarosan rájön, csak a megérzéseire hagyatkozhat, hogyha meg akarja oldani a rejtélyt és elkerülni az egyre közeledő halálos veszélyt...\r\n\r\nA The Witcher, mely Andrzej Sapkowski Vaják c. fantasy könyvsorozatából született, 2015-ben a közönség és a kritikusok által is leginkább elismert videójáték volt. Képregényünk bár a játék alapján készült, de benne attól és a Vaják könyvektől független, teljesen új történetet ismerhetnek meg az olvasók.', '9789634976677', 'https://s02.static.libri.hu/cover/da/a/8079340_5.jpg', 104, 4990, 2021, 1),
(16, 'Oracle Year -Tödliche Wahrheit', 'Will Dando erwacht eines Morgens mit dem Gefühl, vielleicht noch zu träumen - denn ihm schwirren Prophezeiungen durch den Kopf. Totaler Quatsch, denkt er, und widmet sich weiter seiner bescheidenen Karriere als Musiker. Doch als erste Visionen sich bewahrheiten, wird Will die Brisanz und der Wert seiner Gabe bewusst. Zusammen mit seinem besten Freund, einem Investmentbanker, beschließt er, mit den Prophezeiungen Geld zu verdienen. Dafür jedoch müssen sie an die Öffentlichkeit gehen - und die Menschen reagieren zutiefst verunsichert. Als erste Unruhen ausbrechen, beginnt Will zu ahnen, wie gefährlich sein Wissen wirklich ist ...', '9783442487202', 'https://s02.static.libri.hu/cover/16/3/4862317_5.jpg', 510, 4190, 2018, 8),
(17, 'Star Wars: Lando', 'LANDO CALRISSIAN, A KÖZKEDVELT GAZFICKÓ NAGY KALANDJA!\r\n\r\nMielőtt csatlakozott volna a lázadáshoz, vagy Felhőváros vezetőjévé vált volna, a rámenős és vígkedélyű Lando szélhámossággal és ravaszsággal boldogult a galaxisban, és nem is rosszul... Ezúttal - a hűséges Lobottal az oldalán - azt terveli ki, hogy ellop egy rendkívül értékes hajót. De lehet, hogy most túl nagyot markolt? Ugyanis a galaxis egyik legjobb és legveszélyesebb fejvadásza ered a nyomába, és a nagy dobás csakhamar az életben maradásért vívott küzdelemmé válik a szerencsejátékos számára. Bár Lando és Lobot csak a könnyű pénz miatt vállalta el ezt a melót, ha sikerül megúszniuk ezt a kalandot, már soha nem lesznek ugyanazok...\r\n\r\nEz a képregénysorozat a MARVEL Lando című ötrészes, önálló képregénysorozatát tartalmazza. A kötetben található történeteket Charles Soule írta és Alex Maleev rajzolta.', '9789634976585', 'https://s02.static.libri.hu/cover/6d/3/8076986_5.jpg', 112, 5290, 2021, 1),
(18, 'Lovecraft antológia - Első kötet', 'Howard Phillips Lovecraft csodagyerekként korán érdeklődni kezdett a kémia és a csillagászat iránt, noha beteges természete és szorongásos alvászavara megakadályozták benne, hogy elvégezze tanulmányait. Az ezt követő idegösszeomlás és depresszió sokban hozzájárultak az írásaiban megjelenő cinikus és nyugtalanító világkép kialakulásához. Miközben gyakran visszatért a téboly, a bűntudat és az emberek jelentéktelenségének témájához, fokozatosan dolgozta ki a \"kozmikus rettenet\" - az emberiséget többször is leigázni igyekvő gonosz, földönkívüli szörnylények és régi istenek - koncepcióját.\r\n\r\n\"Mert ami felemelkedett, újra elsüllyedhet...\"\r\n\r\nA természetfeletti horror atyja, Howard Phillips Lovecraf képzeletének legsötétebb bugyraiból bukkant elő az a hét történet, amit ebben a képregénygyűjteményben találunk. Legyen szó akár az éj sötétjében suttogó kozmikus rettenetről, akár a tengerek mélységeiben támadt nyugtalanító mozgolódásról, Lovecraft elbeszélései a mai napig felkavarnak bennünket. Jelen képregényünk pedig még valóságosabb életet lehel a horror nagymesterének ezen legismertebb írásaiba.\r\n\r\n\"...és ami elsüllyedt, újra felemelkedhet.\"', '9789634976660', 'https://s06.static.libri.hu/cover/37/2/8056342_5.jpg', 120, 5990, 2021, 1),
(19, 'World of Warcraft: Első könyv', 'Kalimdor partján egy férfit vet partra a tenger, aki semmire sem emlékszik a múltjából. Ezzel veszi kezdetét Lo\'Gosh a félelmetes harcos és nem mindennapi bajtársai, Medveirha Broll és Vérengző Valeera lélegzetelállító kalandjai. Hőseinknek a túlélés érdekében nem csak más fajok képviselőivel, de egymással is együtt kell működniük, s miközben apránként fényt derítenek Lo\'Gosh múltjára, hol a Horda, hol a Szövetség oldalán kénytelenek harcba szállni...\r\n\r\nA történetet olyan nevek jegyzik, mint a Thor képregények szerzője, Walter Simonson író, és Ludo Lullabi és Sandra Hope illusztrátorok.', '9789634976608', 'https://s05.static.libri.hu/cover/28/3/8056341_5.jpg', 176, 6990, 2021, 1),
(20, 'Napóleon 1814 - Franciaország védelme', 'A könyv a modern kori európai történelem egyik legdrámaibb eseménysorát, az egyik legnagyobb katonai és politikai bukás történetét meséli el hitelesen és olvasmányosan.\r\n\r\nA korábban sikert sikerre halmozó Napóleon 1814-ben, az előző két év nagy vereségei után már a végső katasztrófával volt kénytelen szembenézni: küszöbön állt a vele szemben álló szövetséges hatalmak (Oroszország, Poroszország, Anglia) inváziója Franciaország ellen. Az ezt követő intenzív hadjáratot Franciaország területén gyakran szokták Napóleon egyik legnagyobb hadvezéri teljesítményeként emlegetni, ugyanakkor még soha nem mutatták be ilyen részletességgel. A szerző izgalmasan kíséri végig a hadjárat történetét, amelynek végkimenetele alapvető hatással volt Európa sorsára. A kortárs szemtanúk beszámolóira támaszkodva érzékletesen mutatja be az egymást követő nagy csaták sorozatát, amely végül a hadjárat legnagyobb és legvéresebb, Párizs melletti ütközetében érte el a csúcs- és végpontját. Ezután következett Napóleon lemondásának elképesztő drámája, ami szintén fontos témája a könyvnek.\r\n\r\nA könyvben nagy hangsúlyt kap a polgári lakosság háborús tapasztalata, a szerző eleven színekkel és megindítóan ábrázolja a háborús körülmények között élő lakosság szenvedéseit, azokat a morális dilemmákat, amelyekkel az idegen megszállás alatt kellett szembenézniük.\r\nA könyv maradandó olvasmányélményt kínál a beavatottak és a nem beavatottak számára egyaránt.', '9786155583278', 'https://s02.static.libri.hu/cover/14/8/6652931_5.jpg', 536, 6990, 2022, 9),
(21, 'A Hidegháború és még 30 év', 'A szerző őszintén, néhol szenvedélyesen, de tényszerűen igyekszik elénk tárni a Hidegháború korszakát és az azt követő 30 évet. Egyéni látásmódja új megvilágításba helyezi ezt a történelmi korszakot. Bemutatja azokat a politikai és hatalmi játszmákat, amelyek korunk történelmét és emberek millióinak sorsát alakítják, amely segít megérteni a jelenkor gyors változásait, háborúit és a társadalmi törekvéseket. A könyv nem csak azoknak készült, akik szeretik a történelmet, hanem mindenkinek, ezért a szerzője igyekezett úgy fogalmazni, hogy minden érdeklődő számára érthető legyen.', '9786156297198', 'https://s03.static.libri.hu/cover/f4/d/8197290_5.jpg', 254, 5590, 2021, 10),
(22, 'Egy izraeli páncélostiszt élete - Bajmoktól Szarajevóig', 'Ez a különleges könyv egy páratlan életút összegzése, amely a vajdasági Bajmoktól vezetett az 1973-as háborúban kulcsszerepet játszott izraeli 600. páncélosdandár parancsnokságáig.\r\n\r\nA szerző 18 évesen, 1952-ben a harckocsizókhoz bevonulva kezdte meg sok évtizedes katonai pályáját az izraeli fegyveres erőknél. Részt vett négy nagy, sorsfordító háborúban, amelyek egyes epizódjai nagy hangsúly kapnak a könyvben: az 1956-osban (ekkor harckocsija telitalálatot kap), az 1967-esben, majd már dandárparancsok-helyettesként az 1967-1970-es, ún. \"felőrlő\" háborúban. Katonai karrierjének és egyben e könyvnek is drámai csúcspontját az 1973-as háború jelenti, amelyben az M60-asokkal felszerelt 600. páncélosdandár parancsnokaként harcolt a Sínai-félszigeten egy nagyon fontos terepszakaszon. Minden szépítés nélkül, forrásértékűen és részletesen számol be ezekről a kritikus napokról, amikor Izrael léte forgott kockán. A hadosztályparancsnoka nem más volt, mint Ariel Saron, későbbi miniszterelnök.\r\n\r\nNagy erénye a könyvnek, hogy egy különlegesen energikus, a katonai hierarchia szinte minden szintjét megjárt ember személyes tapasztalatain át pillanthatunk be a teljesen egyedi izraeli katonai kultúrába, a fegyveres erők és a társadalom különleges viszonyába, érthetünk meg valamit a döntéshozatali mechanizmusokból, a személyiség szerepéből, és persze ott lehetünk a szerzővel egyes kritikus hadmozdulatoknál is. És mindeközben megismerhetjük azt a mifelénk ma már szokatlannak ható lelkesedést, azonosulást, patriotizmust, amely felépítette és megvédte új hazáját.\r\n\r\nA szerző Révész Tamásként született 1934-ben az akkor a Jugoszláviához tartozó vajdasági Bajmokon, méghozzá egy igen jómódú, mezőgazdasággal foglalkozó családban. A terület 1941-ben visszakerült Magyarországhoz, és a háborús időkre való tekintettel a család hamarosan Budapestre költözött. Itt érte őket 1944-1945 rettenete, ami számukra az állandó életveszélyt jelentette zsidó származásuk miatt. A kis Tamás egy zagyvarékasi családnál vészelt át pár hónapot, majd végül édesanyjával és bátyjával Rákoshegyen találtak menedékre, ahol valamikor 1944 decemberében haladt át rajtuk a front, ami számukra a megmenekülést jelentette. Ezután megpróbálták újrakezdeni az életüket a Jugoszláviához visszakerült Bajmokon, de végül hosszas viták után 1948-ban kivándoroltak Izraelbe.\r\n\r\nA hadseregtől leszerelve a szerző életében újabb drámai csomópontok következtek: így a boszniai háború idején, sokszor életveszélyben mentette a helyi zsidóságot az 1990-es évek első felében. Az életútja körbeért: így lett megmentettből megmentő. Könyve nem csupán a közelmúlt hadtörténete szempontjából izgalmas olvasmány, élettörténete az emberi élni akarás és életszeretet inspiráló és lenyűgöző példája is.', '9786155583698', 'https://s02.static.libri.hu/cover/46/0/8504697_5.jpg', 280, 5490, 2022, 9),
(23, 'The Golden Bull of Hungary', 'Promulgated by Andrew II of Hungary 800 years ago, the Golden Bull (1222) is the best known but also most misunderstood medieval Hungarian document. The book analyses the reform policies that served as the background to the Golden Bull, the circumstances of the bull\'s conception, the events leading to its renewal in 1231, and the consequences of that revision. Finally, the afterlife of the Golden Bull in the medieval period is explored.\r\nAttila Zsoldos is a member of the Hungarian Academy of Sciences. He works at the Institute of History of the Research Centre for the Humanities (Budapest, Hungary). His main fields of interest are the social and political history and the institutions of 11-14th-century Hungary.\r\n\r\n\r\nA 800 évvel ezelőtt II. András által kihirdetett Aranybulla (1222) a legismertebb, de egyben a leginkább félreértett középkori magyar dokumentum. A kötet szerzője elemzi az Aranybulla hátteréül szolgáló reformpolitikát, a bulla megszületésének körülményeit, az 1231-es megújításához vezető eseményeket és a felülvizsgálat következményeit, végül az Aranybulla középkori utóéletét vizsgálja.\r\nZsoldos Attila a Magyar Tudományos Akadémia tagja. A Bölcsészettudományi Kutatóközpont Történettudományi Intézetének munkatársa. Fő érdeklődési területe a 11-14. századi Magyarország társadalom- és politikatörténete, valamint intézményei.', '9789634163053', 'https://s03.static.libri.hu/cover/c5/f/8502585_5.jpg', 260, 4500, 2022, 11),
(24, 'Sorsfordítók a magyar történelemben - IV. Béla', 'A Kossuth Kiadó új történelmi sorozata a magyar államiság ezeréves történetéből tizennyolc olyan alakot mutat be, akik uralkodóként, politikusként vagy \"szürke eminenciásként\" Magyarország és a magyarság sorsát meghatározó módon irányították - olykor kedvezőbb, máskor szerencsétlenebb irányba. A Romsics Ignác főszerkesztő nevével fémjelzett sorozat szerzői az adott korszak, illetve személyiség elismert történész szakértői. A kötetek gazdag képanyaggal, korabeli dokumentumokkal illusztrálva állítják az olvasó elé ezeket a sorsfordító egyéniségeket.', '9789630990295', 'https://s02.static.libri.hu/cover/69/c/4529434_5.jpg', 64, 1790, 2018, 12),
(25, 'E-könyv - Nagy uralkodók és kiskirályok a XIII. században', 'A Kossuth Kiadó népszerű történelmi ismeretterjesztő sorozata, a Magyarország története 4. kötete. A Magyarország története című sorozat történelmünk kezdeteitől napjainkig összefoglalja a legfontosabb eseményeket, bemutatja a kiemelkedő történelmi személyiségeket. Ez a kitűnő, átfogó tudásanyagot nyújtó történelmi alapmű nélkülözhetetlen segítség diákoknak, tartalmas és színes olvasmány a magyar történelem iránt érdeklődőknek. A neves szerzők a sorozat anyagát a legújabb kutatási eredmények felhasználásával állították össze. A kötetek rendkívül gazdag forrásanyagból merítve, eredeti dokumentumok felhasználásával készültek. ,,A Kossuth Kiadó magyar történelmi sorozata a honfoglalástól napjainkig terjedő több mint ezer év történetét mutatja be.Ilyen jellegű munka ekkora terjedelemben és magyar nyelven még soha nem jelent meg. A szerzők, az adott korszak avatott ismerői közérthető, ám egyben szakszerű összefoglalást nyújtanak mindazoknak, akik múltunk megismerésére törekszenek.A kiváló történészek magas színvonalú munkái páratlan élménnyel ajándékozzák meg azokat, akik elolvassák e köteteket.\"Romsics Ignácakadémikus, történész,a sorozat főszerkesztőjeA sorozat kötetei:1. Őstörténet és honfoglalás2. Államalapítás 970-10383. Pogánylázadások és konszolidáció 1038-11964. Nagy uralkodók és kiskirályok a XIII. században5. Az Anjouk birodalma 1301-13876. Luxemburgi Zsigmond uralkodása 1387-14377. A Hunyadiak kora 1437-14908. Mohács felé 1490-15269. Az ország három részre szakadása 1526-160610. Romlás és kiútkeresés 1606-170311. A Rákóczi-szabadságharc 1703-171112. Megbékélés és újjáépítés 1711-179013. A nemzeti ébredés kora 1790-184814. Forradalom és szabadságharc 1848-184915. Neoabszolutizmus és kiegyezés 1849-186716. A dualizmus kora 1868-191417. Világháború és forradalmak 1914-191918. A Horthy-korszak 1920-194119. A második világháborúban20. Demokráciából diktatúrába 1944-195621. Az 1956-os forradalom és szabadságharc22. A Kádár-korszak 1956-198923. A Harmadik Magyar Köztársaság 1989-200724. Időrendi áttekintés.', '9789630969598', 'https://s01.static.libri.hu/cover/96/2/1080943_4.jpg', 0, 990, 2013, 12),
(26, 'A humanista Janus Pannonius és Mátyás könyvtára', 'Mátyást uralkodásának első felében lefoglalták a török ellenes háborúk és hódítások. Hírnevét egyrészt az oszmán expanziós törekvések visszaszorításával, másrészt budai udvarának humanista központtá alakításával vívta ki. A fiú, aki elnyerte a koronát, dicsőségben uralkodott több mint 30 éven át, szuperhatalommá tette országát és páratlan kulturális fellendülést indított útjára. Európa hírű könyvtárának létrehozásában kimagasló szerepe volt nevelőjének, Vitéz János kancellárnak és Janus Pannoniusnak, a pécsi püspöknek, aki itáliai bevásárló körútjai során nemcsak a király, hanem maga számára is vásárolta/készíttette a könyveket. Az Itáliában tanult Janus Pannonius/polgári nevén Csezmicei János a Hunyadiak korának és egyben a magyar humanizmus kiemelkedő alakja, az első magyar lírikus, a hazai latin nyelvű humanista költészet megteremtője: először írt a magyar tájról, édesanyjáról, mesteréről, barátairól, betegségéről, Mátyás király háborúiról...Több, mint 400 verset írt latin és görög nyelven (utóbbiak lefordítása még várat magára), sőt prózákat is. Mátyás trónra lépésének évében tért haza. Janus költészete nyomán megszületett a magyar humanista líra: legérettebb gyümölcseit lírai epigrammáiban, főként elégiáiban hozta Magyarországon. Janus a pécsi püspökség mellett különböző funkciókat, diplomáciai feladatokat töltött be a királyi udvarban. Mátyás király ellen a főurak lázadásához csatlakozott nagybátyjával együtt, mivel nem értett egyet Mátyás király nyugati hódításaival abban a korban, amikor délről a török fenyegetése állandó volt. Mátyás udvarában Attila-kultusz dívott, így Janus munkásságában fellelhető a hun öntudat, amely nemzeti önérzetében jelenik meg. Kegyvesztetten halt meg. Janus a humanista világi líra megteremtője és legkiemelkedőbb művelője, az első magyar költő, aki világhírnévre tett szert. Egy-két évtized alatt a török játszi könnyedséggel leigázta Magyarországot, amely nagyhatalomból prédává vált kiszolgáltatva az oszmán szultánoknak és a Habsburg császároknak. A történelem nagyon kevés példát ismer arra, hogy egy erős és gazdag állam ilyen gyorsan hulljon szét. Az Appendix rész a világháborúk poklát megjárt két szomorú sorsot mutat be.', '9789633023334', 'https://s02.static.libri.hu/cover/2d/c/8494813_5.jpg', 220, 3300, 2022, 13),
(27, 'Egy szokatlan bűnöző krónikája', 'Az antikapitalista érzelmű brit egyetemi hallgató, Stephen Jackley 2007-ben, a globális pénzügyi válság hajnalán úgy dönt, itt az ideje a kezébe venni a dolgokat. Mivel a kapitalizmus mérhetetlen szegénységhez és ökológiai katasztrófához vezet, a magányos és elszigetelt Stephen egy hatalmas Szervezet létrehozását tervezi, amely változtathat a dolgokon. És mivel ez rengeteg pénzbe kerül, Stephen bankrablónak áll. Modern Robin Hoodként küzd a mindent tönkretevő gazdasági rendszer és a bankok ellen: el akarja venni a gazdagok pénzét, hogy a szegényeknek adja. Húszéves, magányos, tapasztalatlan elkövető: aligha fogadna bárki is nagy tétben vállalkozása sikerére. Stephen azonban fél év leforgása alatt tíz rablási kísérletet hajt végre, és több ezer fontot zsákmányol úgy, hogy az angol rendőrség mindvégig sötétben tapogatózik - holott még a DNS-mintáját is megszerzik rögtön az első, balul sikerült bankrablás alkalmával.\r\nStephen persze végül lebukik, és arra is fény derül, hogy Asperger-szindrómás. És ezzel tovább nő a megválaszolásra váró kérdések száma. Harcolhatunk-e nemtelen eszközökkel a nemes cél érdekében? Enyhítő körülmény-e az Asperger-szindróma, vagy épp ellenkezőleg? Felelőssé tehető-e Stephen működésképtelen családja a később általa elkövetett bűncselekményekért? És vajon tud-e új életet kezdeni valaki ilyen a múlttal a háta mögött? Ben Machell dokumentumregénye a krimi izgalmát pszichológiával és társadalomkritikus gondolatokkal övező, vérbeli 21. századi olvasmány, amely után másként tekintünk a jól ismert, mindennapi dolgokra is.', '9789635822942', 'https://s02.static.libri.hu/cover/79/4/8486058_5.jpg', 336, 4599, 2022, 14),
(28, 'A háború öröksége', 'A HÁBORÚ és a COURTNEY HÁBORÚ című könyvek folytatása.\r\n\r\nA háborúnak vége, Hitler meghalt, de a gonosz öröksége mégis él. Saffron Courtney és férje, Gerhard csak most élte túl a brutális konfliktusokat, de Konrád, Gerhard náci testvére még mindig szabad, és elhatározza, hogy visszaszerzi a hatalmat. A veszélyes macska-egér játék keretében kavarognak a pár elleni cselekmények, amelyek kihatnak egész Európára...\r\n\r\nKenyában, ugyanakkor felszínre tör az elégedetlenség, a helyzet erőszakossá válik, és a Courtney-család birtoka veszélybe kerül.\r\n\r\nLeon Courtney itt veti be magát és harcol a birtokért és a szabadságért.', '9789639124684', 'https://s01.static.libri.hu/cover/45/8/7883931_5.jpg', 456, 4299, 2021, 15),
(29, 'Tíz nap a világvége előtt', 'Miért nem tud hinni abban, hogy túlélik?\r\n\r\nKét robbanásfal halad egymással szemben, kilométerről kilométerre emésztik fel a Földet.\r\nSenki nem tudja, honnan erednek, de megállíthatatlanul közelednek egymás felé, hogy tíz nap múlva egyesüljenek.\r\nMenekültek áradata indul meg az Atlanti-óceán partja felé, ahol a legtovább lehet életben maradni.\r\nA véletlen egymás mellé sodor öt embert, három férfit és két nőt.\r\nEgyütt vágnak neki a bedugult utaknak - és életük utolsó tíz napjának.\r\nKezdetét veszi a könyörtelen visszaszámlálás.\r\nEgy letehetetlen road movie - térben és lélekben.\r\n\r\nÉs te?\r\n\r\nTe mit tennél, ha csak tíz napod maradna az életből?\r\n\r\n\"Ez az apokaliptikus regény lebilincselőbb, mint egy sorozat.\r\n\r\nLetehetetlen.\" - Elle\r\n\r\n\"Lélegzetelállító regény, feszültséggel teli versenyfutás az idővel.\"\r\n\r\n- Book-en-stock, babelio.com\r\n\r\n\"Feszített ritmusú, jó cselekményvezetésű, megkapó történet arról, hogyan viselkedik az ember a halál torkában. Nem lennék meglepve, ha néhány év múlva azt hallanám, film készül a regényből.\"\r\n\r\n- Analire, babelio.com\r\n\r\nMélyedj el! Kapcsolj ki! Légy jelen!', '9789634578185', 'https://s05.static.libri.hu/cover/61/2/8478976_5.jpg', 416, 3999, 2022, 16),
(30, 'Metszéspontok', 'A kötet tizennégy novellája remek példája Archer kitűnő jellemábrázoló képességének, izgalmas témaválasztásának. Témái között szerepel a szerelem, a felebaráti segítségnyújtás, illetve a jog és a jogász olykor meglepően alakuló viszonya is.', '9789634525578', 'https://s02.static.libri.hu/cover/3e/f/7624578_5.jpg', 307, 3690, 2021, 17),
(31, 'Párbaj', 'Csupán egyetlen dolog közös bennük...\r\n\r\nUgyanazon a napon, 1906. április 18-án két újszülött látja meg a napvilágot két fiúgyermek: egyikük Bostonban, egy gazdag bankárcsalád sarjaként, a másikuk egy eldugott lengyelországi faluban. Két évtized múltán William Kane, a nagy reményű bankár és Abel Rosnowski, a nincstelen, ámde céltudatos és eltökélt bevándorló útjai keresztezik egymást. Miközben mindketten elszánt harcot folytatnak a sikerért, nem kerülhetik el a végzetüket: a sors ugyanis úgy rendelte, hogy megmentsék - és tönkretegyék - egymás életét.\r\nJeffrey Archer remekműve, amelyet első kiadása óta milliók olvastak szerte a világon, egyaránt bővelkedik drámai jelenetekben, kalandokban, nagy összecsapásokban és megrázó mozzanatokban. Egymást követik a váratlan fordulatok, egészen a legutolsó mondat végső csattanójáig.', '9789634523796', 'https://s02.static.libri.hu/cover/61/0/5985880_5.jpg', 608, 4490, 2020, 17),
(32, 'Végtelen az út, amelyen te jársz 1. rész', 'Az emberiség eddigi történetének legnagyobb felfedezése, az ember legfőbb álmának beteljesülése áll a szerző könyvének fókuszában. De valóban áldás-e ez a felfedezés fajunk jövőjére nézve, ahogy elsőre gondolnánk? Vagy, ha jobban a dolgok mélyére ásunk, arra jövünk rá, hogy mégis inkább átok?\r\nFőhősünk, miután felismeri felfedezése igazi arcát, menekülni kényszerül, sarkában a kormánnyal és az alvilág leggátlástalanabb bandájával, hogy időt nyerjen tervének megvalósításához, amellyel megmentheti a világot és saját lelkiismeretét. Esélyei csekélyek, csak misztikus múltjából nyert tapasztalataira és pár támogatójára számíthat. Vajon végül sikerrel jár?\r\nEnnek a fordulatos és izgalmas kalandregénynek az első részében, amelyet átsző a főhős megdöbbentő múltja, emberszeretete és szárba szökkenő szerelme, korunk egyik sokat kutatott kérdésére kapunk választ.', '9786156153975', 'https://s02.static.libri.hu/cover/46/a/8462152_5.jpg', 416, 3990, 2022, 18),
(33, 'Likvidált szerelem', 'A 2010-es években az ISIS terrorszervezet tagjai azon munkálkodtak, hogy észrevétlenül eljussanak Európa nagyvárosaiba, ahol az újraszerveződő alvó sejtek a kalifátus parancsára bármikor képesek lettek nagyszabású terrortámadások végrehajtására.\r\nA különlegesen kiképzett izraeli csapat, élén Dovval ezeket az embereket hivatott kiiktatni. Munkájuk során ezernyi veszély leselkedik rájuk, és minden tudásukra szükségük van a feladat végrehajtásához.\r\nAzonban a harcosok emberi oldala is megmutatkozik, amikor az izraeli csapatvezető szerelmes lesz a titokzatos arab szépségbe, aki a terroristák fedő szervezeténél dolgozik.\r\n\r\nLehet jövője egy eleve halálra ítélt szerelemnek? Feloldhatók az évezredes konfliktusok, és győzedelmeskedhet az emberi jóság?\r\n\r\nBihary Péter elképesztő fordulatokban, izgalmas akciókban bővelkedő regénye kegyetlen őszinteséggel mesél életről, szerelemről, halálról.', '9789635701056', 'https://s06.static.libri.hu/cover/04/6/7285046_5.jpg', 247, 4199, 2021, 19),
(34, 'Elrabolt jövő', 'Dov terroristák elleni harca folytatódik, ám a küzdelem ezúttal még személyesebb, mert a hozzá legközelebb állók élete van veszélyben.\r\nA hamis személyazonosság álcája nem képes megvédeni egy számára fontos személyt, akit elrabolnak. De ki is ő valójában? Mindenkinek vannak rejtegetnivalói, ám amikor a holtak titkai nem maradhatnak tovább a felszín alatt, a törékeny világ darabjaira hullik. Dovnak erősnek kell lennie, és megmozgatni kapcsolati hálóját, hogy a szeretteit újra biztonságban tudhassa.\r\n\r\nSzíriai összecsapás, török támadás, orosz katonai alakulatok, a CIA befolyása - többek között ezek teszik elképesztően izgalmassá és letehetetlenné Bihary Péter A holtak arca című sorozatának második kötetét, amelyben Dov újabb kihívások elé néz.', '9789635701209', 'https://s06.static.libri.hu/cover/23/b/7285047_5.jpg', 250, 4199, 2021, 19),
(35, 'Léghajó', 'A Mexikói-öböl felett egy hőlégballont sodor a szél, mindössze egyetlen utasa van, Louis Hugo, aki akarata ellenére került a gondolába. Eszméletlen volt, amikor a hajót magával ragadta a vihar, és csak ködös emlékképei vannak arról, hogy mi történt vele indulás előtt. Szerencsére üzemanyag van elégséges, de irányítani már képtelen az elszabadult szerkezetet. Az elemek játékszerévé válik, és ahogyan az idő telik, Louis úgy döbben rá arra, hogy eddig az élete is pontosan úgy hánykolódott, mint az elszabadult léghajó. Csigalassúsággal követik egymást a kényszerből ébren töltött órák, nem alhat el, mert akkor a vízbe zuhan, ami biztos halál lenne. Élete elfeledettnek hitt pillanatai bukkannak elő sorra, gyermekkorától egészen a közelmúltig, és mire feltűnnek Mexikó partjai, már arra is rájön, hogy miért kapta a sorstól ezt az embert próbáló utazást.', '9786150097763', 'https://s01.static.libri.hu/cover/80/0/7948703_5.jpg', 195, 2490, 2021, 20),
(36, 'A holtak erdeje - és más titokzatos történetek', 'A huszadik század első felének egyik legkiemelkedőbb fantasztikus és horror-szerzője kétségtelenül Algernon Blackwood. Jelentőségét mi sem szemléltetheti jobban, mint hogy a természet és a természetfeletti által átjárt és áthatott művei napjainkban, egy évszázad múltán is tökéletesen összetalálkozhatnak a közönség ízlésével.\r\n\r\nKötetünk tartalmazza az író két, talán legismertebb novelláját - ezek a Füzek és A wendigo. Ám életműve még számtalan kincset és meglepetést rejt...', '9786156173485', 'https://s02.static.libri.hu/cover/4a/3/8300624_5.jpg', 184, 2800, 2022, 21),
(37, 'Nincs kegyelem', '\"Wardes csendbiztos gyanútlanul állt a folyóparton, mert a Húsos Farkas fegyvertelen kézzel lépett eléje a bokrok közül, és megemelte a kalapját. De nem mondta azt, hogy jó napot, hanem kivett a kalapjából egy revolvert, és főbe lőtte vele a csendbiztost. Mindez oly gyorsan és váratlanul történt, hogy a Denveri Kopó hírhedt ügyessége sem előzhette meg a halálos lövést.\r\nHej, Fernandez rikoltotta a rablóvezér, akit széles arca és vastag ajkai miatt neveztek Húsos Farkasnak. Egy megrettent mesztic lépett ki a bokrok közül, és tétován nézett hol a halottra, hol gazdájára, aztán hebegve mondta:\r\nEz... meghalt uram.\r\nAzt hitted tán, hogy dalolni fog, miután főbe lőttem? Cipeld oda a bokrok mögé, te barom! Mikor Wardes teteme a bokrok mögött volt, Húsos Farkas parancsot adott Fernandeznek:\r\nHívd a fiúkat! De ne szólj arról, ami történt.\r\nÓ, Farkas... Ez nem volt igazi harc...\r\nNa és?! Tán jártatni akarod a szádat?\r\nFernandez néma, és Fernandez nem lát. A Farkas az ő ura felelte remegve, mert a hatalmas rabló szeme villant, és a revolver felé nyúlt\r\nCsak még azt mondd meg: ez volt a híres csendbiztos, akit Keletről küldtek ide?\r\nEltaláltad! Ez a Denveri Kopó! Wardes, aki híresebb az Államokban, mint amilyen Buffalo Bill volt valamikor! Wyomingban kipusztította a rablókat. Senki sem menekült meg előle, akit üldözött. Most itt van! És belerúgott a tetembe. Eredj!\"', '9786155476617', 'https://s02.static.libri.hu/cover/27/5/2290902_5.jpg', 144, 1490, 2015, 22),
(38, 'A pokol zsoldosai', '\"A hadvezetőség megállapította, hogy a szökések száma az idegenlégióban negyven százalékkal emelkedett az utolsó hónapban. Az okkal tisztában voltak. A caid ügynökei francia nyelven írt röpiratokat terjesztettek. A röpiratok tudtára adják a gyarmati katonáknak, hogy azokat, akik Lebel puskájukat bármelyik lázadó törzsnél, de különösen a Tafilalet-oázisban beszolgáltatják, semmiféle bántódás nem éri\r\nTirone éppen egy ilyen levelet olvasott. A fiatal Berg ült melléje.\r\nBeteg vagy?\r\nA fejem nagyon nyilall mondta Berg.\r\nNem bírod soká ezt a klímát.\r\nÉn is azt hiszem.\r\nKésőbb azután nem fog fájni a fejed, csak tompa leszel és kábult. Ilyenkor jön a cafard.\r\nAz mi?\r\nAfrikai téboly. a meleg, az egyhangúság, az örökös sárga és fehér színek tompa hülyeséget okoznak. az ember néhány hétig gondolat és szó nélkül jár. iszik, de nem rúg be. néha halkan dúdol magában, vagy hirtelen mosolyogni kezd. Azután elhatározza, hogy ír a köztársasági elnöknek, vagy rájön arra, hogy neki a felkelők élére kellene állnia. Végül azon veszi észre magát, hogy nem bírja ki az őrmester szemöldökét, amint folyton rángatózik, és hogy ez megszűnjön, nagyot csap a puskatussal az egyik szemöldökre...\r\nTényleg kibírhatatlan... folyton rángatózik a szemöldöke...\r\nA cafard nagy veszély. a legtöbb légionista átment már rajta. Az a kutyaság, hogy ha valaki gyilkol, akkor a cafard enyhítő körülmény, de azért felkötik a gyilkost. Nem volna kedved eljönni innen?\r\nEljönni?... Hová?...\r\nA Tafilaletbe. Közel vagyunk hozzá.\r\nMár a negyedik pohár rumot itta. Berg is ivott egy keveset. A hőség még jobban kínozta, de felélénkült kissé az alkoholtól. Végighallgatta Tirone-t.\r\nNem tudom mondta Berg. Holnapig gondolkozom.\r\nAz óra zörrent egyet és elnémult. Negyed hat volt. a legyek ellepték a rumos pohár szélét. Mellettük pergett a kocka.\"', '9786155476709', 'https://s02.static.libri.hu/cover/c8/a/2290918_5.jpg', 176, 1490, 2015, 22),
(39, 'Barack Obama szupersztár', 'Két elnöki ciklus és Biden elnökké választása után többé senki sem hiszi, hogy Barack Obama valamiféle divatfiguraként, netán szerencselovagként jutott volna a világ legfontosabb közhatalmi tisztségébe. Ettől azonban útja a Fehér Házig csak még izgalmasabb. A kenyai kecskepásztor unokája elkélpesztő pályát fut be, mely egy fehér édesanya és egy indonéz második férj jóvoltából vagy hibájából egy djakartai muzulmán iskolában kezdődik, később a Harvardon és a Columbia egyetemen folytatódik. Egy ügyvédi irodában gyakornokoskodunk Obamával, ahol egy Michelle nevű langaléta fekete lány eleinte észrevenni se hajlandó a jóképű és szorgalmas, megnyerő, de talán még nem eléggé magabiztos félvér fiatalembert, aki azonban a magánéletben, később a politikában, az eszelősségig kitartó, bámulatosan megfontolt és céltudatos.\r\n\r\nA férfi, aki képes elérni, amit akar? Többről van szó. A napjainkban hiánycikké vált politikai tisztességről. Miként a szerző - volt washingtoni tudósító - előszavában olvasható, ez a könyv \"először is azért született meg, mert ez a kisfiúsan mosolygó, színes bőrű és egyéniségű politikus, minden emberi hibájával, fáradékonyságával, ismétlődő retorikai fogásaival és néha szembeötlő hiúságával együtt is jó benyomást tett rám. Másodszor pedig azért, mert már az első alkalommal, amikor az iowai előválasztás utáni győzelmi beszédét hallgattam, megelégedéssel töltött el az érzés, hogy a siker nem mindenütt és nem minden körülmények között gyanús.\"', '9789638516275', 'https://s05.static.libri.hu/cover/ec/2/679457_5.jpg', 144, 1690, 2008, 23),
(40, 'Assassin\'s Creed - Testvériség', '\"Alászállok egy romlott birodalom fekete szívébe, hogy eltapossam ellenségeimet. De Rómát nem egy nap alatt építették, és egyetlen magányos orgyilkos nem lesz képes visszaállítani régi fényét. A nevem Ezio Auditore da Firenze. Ez az én testvériségem.\" Az egykor oly dicsőséges Róma romokban hever. A városban szenvedés és pusztulás az úr, polgárai a kegyetlen Borgia család tehetetlen bábjai. Csak egyvalaki mentheti meg őket a Borgiák zsarnokságától - Ezio Auditore, a orgyilkos hagyományok mestere. Küldetése során Eziónak latba kell vetnie minden képességét. Cesare Borgia, aki apjánál, a pápánál is elvetemültebb és veszélyesebb, nem nyugszik, amíg egész Itáliát meg nem hódította. Mivel ez a köpönyegforgatók kora, az összeesküvők mindenhová befészkelik magukat, még a Testvériség soraiba is…', '9789639861350', 'https://s03.static.libri.hu/cover/35/3/831414_5.jpg', 470, 4995, 2021, 3),
(41, 'Assassin\'s Creed - Reneszánsz', 'Bosszút állok mindazokon, kik elárulták családomat. Nevem: Ezio Auditore Da Firenze. Orgyilkos vagyok. - Egy bosszúra szomjas fiatalember eposzi méretű küldetésre indul, miután Itália uralkodó dinasztiái elárulták őt. Ám ahhoz, hogy visszaállítsa családja becsületét, és véget vessen hazája romlásának, ki kell tanulnia az orgyilkosok mesterségét. Miközben a szabadságért és igazságért harcol, Ezio útját olyan kiváló elmék segítik, mint Leonardo da Vinci és Niccol Machiavelli, akik mint koruk legbölcsebb gondolkodói beavatják a túlélés fortélyaiba. Társai számára Ezio fogja megtestesíteni az erőt, mely elsöpri a régit, és újat hoz a helyébe. Ellenségei szemében pedig fenyegető jelképpé válik, kinek rendeltetése, hogy eltiporja a zsarnokságot, mely Itália népét sanyargatja. Kezdődjék a hatalom, az összeesküvés és a bosszú örök színjátékának reneszánsz krónikája. Hiszen az igazságot vérrel írják. Az Ubisoft nagysikerű videojátéka alapján!', '9789639861343', 'https://s03.static.libri.hu/cover/b7/8/828782_5.jpg', 484, 4495, 2011, 3),
(42, 'Az örökség ára', 'Az Örökösök viadala című kötet folytatása\r\nAlig egy hét telt el a villában tett sokkoló felfedezés óta, és Avery semmivel sem jutott közelebb a megfejtéshez, hogy miért hagyta rá az öreg milliárdos, Tobias Hawthorne a vagyonát. A DNS-teszt bebizonyította, hogy a lány nem vérrokon, a jelek mégis arra utalnak, hogy sokkal szorosabb szálak fűzik a rejtélyes családhoz, mint hitte.\r\nAvery próbál kizárólag a rejtély megoldására összpontosítani, de nem könnyű tiszta fejjel gondolkodni, amikor a két szívdöglesztő Hawthorne testvér, Grayson és Jameson egyre jobban beférkőzik a bizalmába, és ez talán kockázatosabb, mint a folyamatosan rá leselkedő veszélyek.\r\n\r\nHónapok ót a New York Times bestsellerlistájának élén!', '9789633248096', 'https://s04.static.libri.hu/cover/28/f/8396399_5.jpg', 250, 4299, 2022, 24),
(43, 'Bogyó és Babóca - Hónapok meséi', 'Kísérd végig az év hónapjait Bogyóval és Babócával!\r\nA könyvben tizenkét mese szerepel, a hónapok, évszakok jellegzetességeit követve.\r\nMinden hónapra jut egy történet, melyekben szinte az összes szereplővel találkozhatunk!\r\nA katicalány és a csigafiú történetei a 2004-es első kötet óta számos elismerést szereztek, a sorozat megannyi jótékonysági ügyet szolgál, a kötetetek több nyelven is megjelentek.', '9786155883774', 'https://s04.static.libri.hu/cover/5b/2/6121995_5.jpg', 235, 4490, 2020, 25),
(44, 'Mindketten meghalnak a végén', 'ADAM SILVERA gyönyörűen szívszaggató regénye fiatalok százezreit érintette meg. A TikTokon több mint 74 millió bejegyzés szól erről a könyvről, valamint a The New York Times sikerlistáján is bérelt helye van. Mi, a Végső Barát Zrt. csapata, borzasztóan sajnáljuk, hogy elveszítünk. Őszinte részvétünk mindazoknak, akik szerettek, és azoknak, akik már sosem ismerhetnek meg téged. Reméljük, ma értékes, új barátra lelsz, és vele töltöd végső óráidat. Szeptember 5-én, kicsivel éjfél után a Halál-Hírek felhívja Mateo Torrezt és Rufus Emeteriót. Rossz hírei vannak számukra: még aznap meghalnak. Mateo és Rufus nem ismerik egymást, és más-más okokból ugyan, de mindketten szeretnének egy új barátot találni a Végnapjukon. A jó hír: erre is létezik egy alkalmazás, a neve: Végső Barát. Rufus és Mateo ennek segítségével akarnak találkozni, hogy együtt még egy utolsó, nagyszerű kalandban legyen részük - egyetlen nap alatt akarnak leélni egy egész életet.\r\nAdam Silvera bemutatkozó regényét a New York Times komoly, érzékeny műként jellemezte, most pedig itt az elismert író újabb virtuóz alkotása, a felemelő és megsemmisítő, elbűvölő és megragadó Mindketten meghalnak a végén. Ez a történet emlékeztet rá, hogy halál nélkül nincs élet, veszteség nélkül nincs szeretet - és egyetlen nap alatt is megváltoztathatjuk az egész világunkat.\r\n\r\n\"Üdvözlöm! A Halál-Hírektől telefonálok. Sajnálattal jelzem, hogy az elkövetkező huszonnégy óra során az Ön élete korai véget ér. A Halál-Hírek teljes csapata nevében, kérem, fogadja mély együttérzésünket. Ez az utolsó napja, használja ki minden percét, rendben?\"\r\n\r\nVélemények:\r\n\"Merész, nagyszerű, fájdalmasan szép történet veszteségről, reményről, és a barátság megváltó erejéről.\" - Lauren Oliver, a Before I Fall New York Times-sikerlistás szerzője\r\n\r\n\"Magával ragad, elgondolkodtat, és éppolyan szívszorító, ahogy a címből sejtheti az ember.\" - Kirkus Reviews\r\n\r\n\"Rendkívüli és felejthetetlen.\" - Booklist\r\n\r\n\"Egy könyv barátságról, szerelemről, és a sorsról - nem árt, ha kéznél van egy csomag zsebkendő olvasás közben.\" - Brightly', '9789635841523', 'https://s04.static.libri.hu/cover/75/3/8546962_5.jpg', 480, 3990, 2022, 26),
(45, 'Harry Potter és a Főnix Rendje', 'Harry Potter nem hitte volna, hogy egyszer ő fogja megvédeni basáskodó unokatestvérét, Dudley-t. Ám amikor fényes nappal dementorok támadnak kettőjükre, ez történik. De számos más vészjósló esemény is mutatja, hogy a varázsvilág békéjét sötét erők fenyegetik.\r\nHarry nincs egyedül az ellenük vívott küzdelemben: a Főnix Rendje egy titkos főhadiszálláson szervezi a Sötét Nagyúr elleni harcot, ami minden fronton zajlik. Harry például kénytelen különórákat venni Piton professzortól, hogy ki tudja védeni Voldemort erőszakos behatolásait a tudatába.', '9789633244418', 'https://s03.static.libri.hu/cover/d0/9/3511853_5.jpg', 811, 4290, 2021, 27);
INSERT INTO `books` (`Id`, `Title`, `Description`, `ISBN`, `ImgLink`, `PageNumber`, `Price`, `PublishingYear`, `PublisherId`) VALUES
(46, 'Harry Potter és a Halál ereklyéi', 'Amikor a tizenhetedik évét betöltő Harry ezúttal Hagrid motorjának oldalkocsijában utoljára hagyja el a Privet Drive-ot, az őt védő bűbáj szertefoszlik, és a halálfalók azonnal a nyomába erednek. A Főnix Rendje azon fáradozik, hogy biztos helyre szöktesse őt, csakhogy Harrynek a bujkáláson kívül egyéb tervei is vannak: Dumbledore professzortól kapott feladatát kell végrehajtania. Így a tanév nélküle kezdődik el a Roxfortban. Vajon sikerül-e a folytonos életveszély közepette teljesítenie a küldetést, amitől a végső összecsapás kimenetele függ?', '9789633247358', 'https://s03.static.libri.hu/cover/f2/8/3511856_5.jpg', 653, 3990, 2020, 27),
(47, 'Harry Potter és a Titkok Kamrája', 'Harry Potter, aki éppen egy éve tudta meg magáról, hogy varázslónak született, Dobby figyelmeztetése ellenére tovább folytatja tanulmányait a Roxfort Boszorkány- és Varázslóképző Szakiskolában. Mivel lekési a különvonatot, barátjával, Ronnal együtt egy repülő autón érkezik tanulmányai színhelyére. S a java csak ezután következik! Hamarosan bebizonyosodik, hogy Dobby nem a levegőbe beszélt, amikor óvni próbálta őt.', '9789633247341', 'https://s03.static.libri.hu/cover/14/f/3511849_5.jpg', 365, 3290, 2020, 27),
(48, 'Harry Potter és az azkabani fogoly', 'Harry Potter szokásos rémes vakációját tölti Dursley-éknél, ám a helyzet úgy elfajul, hogy Harry elviharzik a Privet Drive-ról. Így köt ki a Kóbor Grimbuszon, ami elviszi őt abba a világba, ahová egész nyáron vágyott. Az Abszol úton ijesztő hírek járják: az Azkabanból, a gonosz varázslókat őrző rettegett börtönből megszökött egy fogoly. A Mágiaügyi Minisztériumban tudják, hogy a veszélyes szökevény a Roxfort Boszorkány- és Varázslóképző Szakiskolába tart. Harry pedig egy véletlen folytán tudomást szerez róla, hogy az illető az ő nyomát követi.', '9789633247396', 'https://s03.static.libri.hu/cover/3f/b/3511851_5.jpg', 480, 3690, 2020, 27),
(49, 'Öreg néne őzikéje', 'A törött lábú őzgidát meggyógyító öreg néne annyira közismert, hogy már-már azt hinnénk, népmesei alak, pedig Fazekas Anna írta, és Róna Emy rajzolta meg őt. A népdalszerűen egyszerű, fülbemászó rímek kitörölhetetlenül emlékeinkbe vésődtek, és elkísérnek minket óvodáskorunktól egészen addig, amíg majd egyszer, nagyszülőként mi magunk elmeséljük ezt a történetet az unokáinknak.\r\n\r\n\"Mátraalján, falu szélén\r\nlakik az én öreg néném,\r\nmelegszívű, dolgos, derék,\r\ntőle tudom ezt a mesét...\"\r\n\r\n\r\nMindenki ismeri ezt a mesét, ezeket a rímeket és ezeket a rajzokat, akinek valaha mesét olvasott az anyukája, a nagymamája vagy az óvó néni. Egyszerűbben szólva, aki Magyarországon volt kisgyerek valamikor az elmúlt bő fél évszázadban. A törött lábú őzgidát meggyógyító öreg néne annyira közismert, hogy már-már azt hinnénk, népmesei alak, pedig Fazekas Anna írta, és Róna Emy rajzolta meg őt. A népdalszerűen egyszerű, fülbemászó rímek kitörölhetetlenül emlékeinkbe vésődtek, és elkísérnek minket óvodáskorunktól egészen addig, amíg majd egyszer, nagyszülőként mi magunk elmeséljük ezt a történetet az unokáinknak.', '9789634159285', 'https://s05.static.libri.hu/cover/28/4/842159_5.jpg', 16, 2499, 2022, 28),
(50, 'A majom mamája', 'Elvesztettem a mamámat! Így szólt a pillangó: Szegény majom! Ne sírjál, segítek én a bajon. A bohókás pillangó lelkesen keresi, ki lehet a kicsi mamája - az elefánttól a denevérig. Mulatságos rímekkel bukdácsolunk át a dzsungelen, vissza majom mama karjaiba. Julia Donaldson és Axel Scheffler párosa már Magyarországon sem ismeretlen (A róka zoknija, Mackó levelei, és A Graffaló). A mese magyarítása ezúttal is Papp Gábor Zsigmond munkája.', '9789634108078', 'https://s04.static.libri.hu/cover/af/7/828171_5.jpg', 24, 2490, 2016, 29),
(51, 'Kisasszonyok', 'A négy March nővér - Meg, Jo, Beth és Amy -egy új-angliai településen, nehéz anyagi körülmények között élnek édesanyjukkal, miközben apjuk a polgárháborúban szolgál tábori lelkészként. A lányokat rengeteg kaland és váratlan balszerencse éri, és a sok tapasztalat révén egyre jobban kirajzolódik a személyiségük: a józan és megfontolt Meg társaságszerető, a fiús Jo imádja a könyveket, a szégyenlős Bethet a zenélés érdekli, a kissé önző Amynek pedig művészi hajlamai vannak.\r\n\r\nA Kisasszonyok lányregénynek íródott, ám mára az egyik legismertebb amerikai klasszikusként ismert, amely női írók generációinak adott ihletet, és számos film- és egyéb feldolgozás készült belőle.\r\n\r\nLouisa May Alcott (1832-1888) a Kisasszonyokon kívül több, gyermekkori élményein alapuló klasszikus regényt is írt, és a szüfrazsett mozgalomban is tevékenyen részt vett.\r\n\r\nA könyv végén található szerzői életrajz és egy, a cselekményről szóló kvíz plusz ajándék az olvasónak.', '9789634036340', 'https://s03.static.libri.hu/cover/f2/d/5195645_5.jpg', 353, 2990, 2021, 30),
(52, 'Tesz-Vesz város', 'Tesz-Vesz városban senki sem unatkozik. Tarts velünk, és ismerd meg, mi minden történik az iskolában, az utcán, az orvosi rendelőben, a tűzoltóságon vagy épp a kikötőben. A jó hangulatot nemcsak a szeleburdi szereplők, hanem Réz András remek fordítása is szavatolja.', '9789634864950', 'https://s03.static.libri.hu/cover/e2/5/6110485_5.jpg', 46, 2990, 2021, 28),
(53, 'Wabi Sabi - Útmutató a belső békéhez', 'A wabi sabi a japán esztétika egyik irányzata, amely segít, hogy megtaláljuk a szépséget a tökéletlenségben, és értékeljük az egyszerűséget, illetve a természetességet.\r\nA zenben gyökerező wabi sabi bölcsessége különösen fontos a modern korban, amikor folyamatosan keressük az élet anyagi világon túlmutató értelmét és belső békénket.\r\nA wabi sabi a maga évezredes bölcsességével segít lelassítani, és megmutatja, hogyan kapcsolódhatunk újra a természethez. Legyen szó az évszakok váltakozásban való gyönyörködésről, a hívogató otthon megteremtéséről vagy akár a méltósággal teli öregedésről, ez az ősi japán megközelítés és a könyvben található gyakorlati tanácsok segítenek, hogy tökéletesen tökéletlen életünk örömteli és tartalmas legyen.\r\n\r\nBeth Kempton a japán kultúra nagy tisztelője és követője. Japán szakot végzett az egyetemen, s második otthonaként tekint Japánra. Volt műsora a japán televízióban, és rendszeresen publikál a keleti filozófiákról. Online is népszerű workshopjainak köszönhetően emberek ezreinek segített rájönni, mi az, ami valóban inspirálja őket, és hogyan élhetnek kreatívabb és teljesebb életet.', '9789634339991', 'https://s03.static.libri.hu/cover/33/a/5168264_5.jpg', 277, 4199, 2022, 4),
(54, 'Hogyan éljünk japánul', 'A japán szokások és hagyományok évszázadokon át virágoztak és gyarapították a jól-lét modern gyakorlatát: elég csak az ikigaiban (elégedettség), a shinrin-yokuban (erdőfürdőzés), a wabi sabiban (a tökéletlenség szépsége) vagy a teaszertartásban rejlő megannyi bölcsességre gondolnunk.\r\n\r\nA Hogyan éljünk japánul szerzője hozzáértő és bennfentes útmutatót ad Japánhoz, hogy segítse az olvasót a japán design, a konyhaművészet, a kultúra és az esztétika mélyebb megismerésében. Már maga Tokió, az összes metropolisz anyja, ragyogóan megvilágítja, miként lehet barátságban együtt élni a természettel: a túlurbanizált mega-fővárost a világ egyik legkiterjedtebb erdősége övezi. E kettősség tökéletesen szimbolizálja a japánok tiszteletét a természet és a természetes világ, illetve az ember által alkotott környezet iránt.', '9789632449296', 'https://s01.static.libri.hu/cover/4c/1/4818346_4.jpg', 224, 5995, 2022, 31),
(55, 'Trauma - A láthatatlan járvány', 'Út a megértés, a felépülés és a társadalmi trauma megelőzése felé\r\n\r\nKépzelj el egy betegséget, aminek ránézésre csak néhány alig észlelhető tünete van, de az egész testedet az uralma alá hajtja, és még csak észre sem veszed. Könnyen terjed szülőről gyerekre, és akár életünk végéig is kísérhet, ha nem teszünk ellene. Dr. Paul Conti szerint a társadalomnak pontosan így kellene tekintenie a traumára: egy potenciálisan halálos kimenetelű járványként, amely fölött már nincs uralmunk.\r\n\r\nTrauma: A láthatatlan járvány című könyvében Dr. Conti a legújabb kutatásokra, a legjobb klinikai eljárásokra és a való életből vett történetekre támaszkodva vázolja fel a trauma részletes és aggasztó kórképét. Lépésről lépésre segíti az olvasót abban, hogy milyen konkrét változásokat kell az életünkben eszközölnünk egyénként és a társadalom tagjaként a trauma hatásának enyhítése és további traumatizálódás ellen. A könyv lerántja a leplet a hazugságról: az élethosszig tartó, gyógyíthatatlan betegség igenis kezelhető és meg is előzhető.\r\n\r\nAmit a Traumából elsajátíthatunk:\r\n\r\nátfogó képet kapunk a traumáról és a szégyenérzetről,\r\na készséget, hogy felismerjük a traumát magunkban, másokban és a bennünket körülvevő társadalomban,\r\ntudást arról, hogy az egyéni és a kollektív trauma miként dolgozik társadalmi szinteken,\r\nmotivációt, hogy megállíthassuk a traumát,\r\npraktikus eszközöket, melyekkel önmagunkon és másokon egyaránt segíteni tudunk.\r\n\r\n\r\n\r\nVégtelenül fontos, életigenlő könyv ez, amely erővel vértez fel a traumák ellen, segít, hogy elfogadjuk és szembenézzünk életünk történéseivel, és arra biztat, tanuljunk meg magabiztosan boldogulni, ne csak kényszeredetten túlélni az élet nehézségei közepette.\r\n\"Paul embertársamként, bizalmasomként viszonyult hozzám. Megmutatta, hogy élni érdemes. De, ami ennél is fontosabb, arra biztatott, hogy újra megtaláljam és visszaszerezzem önmagam.\" - Lady Gaga\r\n\r\n\r\n\r\nA szerzőről: Dr. Paul Conti a Stanford Egyetem orvosi karán tanult. Pszichiátriai képzését a Stanfordon és a Harvardon szerezte, utóbbin főrezidensnek nevezték ki. A Harvard orvosi karán dolgozott egészen addig, míg az Oregon állambeli Portlandbe költözött, ahol megalapította saját klinikáját.', '9789635073016', 'https://s03.static.libri.hu/cover/44/d/8523867_5.jpg', 263, 5490, 2022, 32),
(56, 'A most hatalma a gyakorlatban', 'Nélkülözhetetlen gyakorlatok és meditációk a jelen pillanat erejének felismeréséhez\r\nA most hatalma rövid idő alatt bebizonyította, hogy az egyik legnagyobb spirituális könyv, amelyet manapság írtak. Ez a könyv egyfajta szavakon túli hatalomról szól, és képes elvezetni minket egy - a gondolataink mögött lévő - jóval csöndesebb helyre, ahol megoldódnak gondolat teremtette problémáink, s felfedezzük, mit is jelent létrehozni egy szabadabb életet. Eckhart Tolle szavaival élve: \"Én az emberi tudatosság mélyreható átváltozásáról beszélek. Nem úgy, mint egy messzi jövőbeli lehetőségről, hanem valamiről, ami most elérhető - nem számít, ki vagy és hol élsz. Láthatóvá válik, miként szabadíthatod fel magad az elme fogságából, és hogyan léphetsz be a tudatosság eme megvilágosodott állapotába, s milyen módon tarthatod ezt fenn a mindennapi életben.\r\nE kötet minden részében speciális gyakorlatok és egyértelmű kulcsok vannak, amelyek megmutatják, hogyan fedezzük fel magunknak a \"megbocsátást, könnyűséget és fényességet\". Ezek akkor érkeznek meg, amikor lecsendesítjük a gondolatainkat és látjuk a világot elterülni magunk előtt a jelen pillanatban. Olvassuk a könyvet lassan, vagy éppen csak nyissuk ki hirtelen, töprengjünk a szavakon és a közöttük lévő űrön, hogy - talán egy idő után, talán azonnal - felfedezhessünk valami \"életmegváltoztató\" összefüggést. Találjuk meg a hatalmat: a képességet, hogy átalakítsuk, és emelkedetté tegyük életünket és világunkat is. A lehetőség itt van, most, ebben a pillanatban: a szent jelenlét a Létezésünkben. Egy hely bennünk, ami mindig jelen volt, és mindig is jelen lesz a zavaros életen túl, a nyugalom világa a szavak mögött.\r\nEz mind a kezünkben van. Fedezzük fel a most hatalmát!\r\n\r\nA mű az Édesvíz Kiadó gondozásában utoljára 2021-ben jelent meg azonos címmel és tartalommal, eltérő borítóval.', '9789635073139', 'https://s05.static.libri.hu/cover/ea/d/8523862_5.jpg', 184, 4490, 2022, 32),
(57, 'A só - Mítoszok és realitások', '\"Ebben a könyvben nem csak a sóról írok, hanem össze-gyűjtöttem különböző betegségek népi gyógymódjait, melyeknek a só sok esetben csak kiegészítő eszköze, a teakúrák, főzetek, kivonatok, borogatások stb. mellett.\r\nTermészetesen, most se hagyhattam ki rövid összefoglalásban a só jelentőségét az emberiség történetében, a különböző sók alkalmazását a táplálékainkban, szerepét a gyermekek táplálkozásában vagy épp különböző betegségek gyógyításában.\r\nA könyvben részletesen megismertetem az Olvasót a különböző bőrbetegségek gyógyításával sós kádfürdők segítségével, és természetesen leírom néhány szerző, így például az orosz dr. Korodeckij vagy az Ukrajnában élő Bolotov akadémikus módszereit is.\"', '9786156156044', 'https://s04.static.libri.hu/cover/4a/a/8514556_5.jpg', 166, 3300, 2022, 33),
(58, 'Úgy döntöttem, boldog leszek, mert az nagyon egészséges', 'Mi van, ha a boldogság valóban döntés kérdése? Mi van, ha a nézőpontunk módosítása a legjobb módja annak, hogy megváltoztassuk az életünket? Stéphane Garnier sokat idéz híres költőktől, íróktól, aktivistáktól, politikusoktól, zenészektől, filozófusoktól - akik, úgy tűnik, már saját bőrükön tapasztalták, hogy minden fejben dől el. A szerző szenvedélyes és humorral teli mondatai gyakorlati tanácsokkal szolgálnak a boldog mindennapokhoz.\r\n\r\nA filozofikus és inspiráló utazás, melyre a könyv invitál, konkrét példákon keresztül, szemléletesen mutatja be, milyen fontos, hogy egyszerű életet éljünk, hogy megosszuk másokkal mindazt, amink van, és hogy a döntéseinkért felelősséget vállaljunk. Figyelmeztet, hogy sosem késő bátornak lenni és hinni az álmainkban - ha szeretet van bennünk, és kitartóak vagyunk, képesek leszünk beteljesíteni vágyainkat.', '9789635094585', 'https://s01.static.libri.hu/cover/3d/b/8471986_4.jpg', 240, 3999, 2022, 31),
(59, 'Nyugalom - 48 lecke a kiegyensúlyozott élethez', 'Nemzetközi bestseller\r\nAz egyszerű élet művészete szerzőjétől\r\n\r\nFélsz?\r\nTartasz valamitől?\r\nSzorongsz?\r\n\r\nShunmyo Masuno könyvéből kiderül, hogy aggodalmaid többsége egyszerűen nem igazolódik be.\r\n\r\nGondolj bele: hányszor fordul elő, hogy a mindennapjaidat megmérgezi egy rossz sejtelem, de amitől féltél, végül nem következik be!\r\n\r\nAz életedet jobbá, szebbé, élvezetesebbé teheted pusztán azzal, hogy megszabadulsz felesleges félelmeidtől.\r\n\r\nNe hasonlítsd magadat másokhoz - a nyugtalanságod oroszlánrésze máris elillan;\r\nSzabadulj meg a felesleges dolgoktól, a lehető legegyszerűbb életet éld;\r\nNe keresgélj, ne rohanj, ne hagyd, hogy megszállottságok legyenek úrrá rajtad;\r\nÉrtelmezd pozitívan a dolgokat - egyedül rajtad múlik a döntés, hogy boldog vagy, vagy boldogtalan;\r\nNe áraszd el magadat túl sok információval;\r\nSzállj ki a versengésből - a zen így kerüli a stresszt;\r\nAggódás helyett inkább cselekedj - ezáltal kétségtelenül jobbra fordulnak a dolgok.\r\n\r\nEz a könyv eszköz, amelynek 48 leckéje és csaknem 30 zen szólásmondása segít abban, hogy elfogadd magadat, és örömödet leld a korábbinál nyugodtabb, higgadtabb, pozitívabb énedben.', '9789635682140', 'https://s04.static.libri.hu/cover/ff/3/8471985_5.jpg', 207, 4690, 2022, 34),
(60, 'Miért nem mondta EZT nekem eddig senki? - Hogyan tegyük jobbá a rossz napokat', 'Hatalmas ereje van annak, ha megértjük, hogy milyen sokféle módon befolyásolhatjuk a közérzetünket és ápolhatjuk a mentális egészségünket.\"\r\n\r\nDr. Julie Smith internetes szenzáció, több éves pszichológusi tapasztalatára támaszkodva azokat a készségeket mutatja be, amelyek segítenek, hogy eligazodhass a mindennapi élet kihívásaiban, és átvehesd az irányítást az érzelmi és mentális egészséged felett.\r\nA lelki egészséged ugyanolyan fontos, mint a fizikai egészséged, így nem kell megvárnod, hogy padlóra kerülj, hogy kézbe vedd ezt a könyvet, hiszen: \"Minél többet dolgozunk az öntudat és a kitartás kialakításán, amikor minden rendben van, annál jobban tudunk majd szembenézni az élet kihívásaival, amikor utunkba kerülnek.\"\r\nA Miért nem mondta EZT eddig nekem senki? mindennapi problémákkal foglalkozik, és praktikus megoldásokat kínál rövid, könnyen emészthető fejezetek formájában, így gördülékenyen és gyorsan megtalálhatod a számodra szükséges információt és útmutatást. Olyan terápiás titkokkal és bevált stratégiákkal ismeretet meg, amelyekkel betekintést nyerhetsz az elmédbe, megértheted annak működését, és amelyek segítségével mindennap ápolhatod és fejlesztheted a mentális egészséged.\r\nIsmerj meg minden olyan eszközt, amire szükséged lehet az újraértékeléshez, a megfelelő irány megtalálásához, az egészségesebb szokások kialakításához és az öntudathoz való visszatéréshez. Dr. Julie Smith szakértői tanácsai és hatékony technikái a segítségedre lesznek, hogy mindvégig rugalmas maradj, legyen szó akár a szorongásod vagy a kritikák kezeléséről, a depresszióval való küzdelemről, az önbizalmad növeléséről, a motiváció megtalálásáról vagy a megbocsátás gyakorlásáról.\r\nTanuld meg, hogyan erősítheted meg és ápolhatod a mentális egészséged, még a legnehezebb időszakokban is.\r\n\r\n\"Az általam elsajátított eszközök nem fogják megakadályozni, hogy az élet utadba állítson dolgokat. Segítenek eligazodni, kanyarodni, ütközni, majd helyreállni. Nem akadályozzák meg, hogy útközben eltévedj. Segítenek észrevenni, ha eltévedtél, és bátran sarkon fordulni, és visszatérni egy olyan élet irányába, amely jelentőségteljes, és amelyben céltudatosnak érzed magad. Ez a könyv nem a problémamentes élet kulcsa. Ez egy nagyszerű eszköztár, amely nekem és sokaknak segít megtalálni az utat.\"', '9789635072972', 'https://s03.static.libri.hu/cover/c9/0/8467836_5.jpg', 324, 5490, 2022, 32),
(61, 'Cukoragykúra', 'Mitől függ agyunk egészsége? A válasz egyszerűbb, mint gondolná!\r\n\r\nElsősorban a cukorfüggőség a felelős a rossz egészségi állapotért és az olyan olyan krónikus betegségekért, mint a szívbetegség, a stroke, a rák vagy az elhízás. Dr. Mike Dow forradalmian új könyve ötvözi a tudomány élvonalába tartozó kutatásokat és a könnyen megvalósítható életvezetési stratégiákat.\r\n\r\nAlaposan megvizsgálja, hogyan befolyásolja a cukor az agy kémiáját. A cukor az agyban felszabadítja a szerotonint, egy \"jó érzést\" kiváltó vegyületet, amely arra késztet bennünket, hogy még többet együnk. A legújabb tanulmányok azonban kimutatták, hogy a cukor ténylegesen zsugorítja az agyat, ez pedig a hippokampusz méretének csökkenéséhez és egy sor más problémához vezet: többek között memóriaproblémákhoz, depresszióhoz és súlygyarapodáshoz. Idővel cukorfüggővé válunk, és máris benne is vagyunk egy ördögi körben.\r\n\r\nDr. Dow a legújabb kutatások alapján rengeteg adatot gyűjtött össze arról, hogyan károsítja agyunkat és testünket a felesleges, káros szénhidrátokban és rossz zsírokban gazdag étrend - és azt is pontosan leírja, hogy mit tehetünk ellene!\r\n\r\nA 28 napos Cukoragykúra szénhidrátszegény, gyógyító zsírokban gazdag, mediterrán étrenden alapul, amely lehetővé teszi a fokozatos méregtelenítést. A könyvben található tesztek kitöltésével megtudhatjuk, hogy szerotonin- vagy dopaminhiányban (esetleg mindkettőben) szenvedünk-e. Részletes útmutatást találunk arról is, hogyan küzdhetjük le a cukor és a rossz zsírok utáni sóvárgást a káros ételek egészségesekre cserélésével, finom receptekkel, hasznos táplálékkiegészítőkkel, és új, segítő tevékenységek beiktatásával.\r\n\r\nA módszer egyéb technikákat is javasol agyunk egészségének megőrzésére, többek között a kognitív viselkedésterápiát és az önhipnózist.\r\n\r\nA Cukoragykúra sikeres módszer agyunk egészségének megőrzéséhez és a hasi zsírtól való megszabaduláshoz, fokozatosan és tervszerűen segít leküzdeni az életveszélyes cukorfüggőséget.\r\n\r\n************\r\n\r\n\"Nagy részben a cukorfüggőség felelős a civilizált országokban egyre gyakrabban előforduló krónikus betegségekért és az emberek rossz egészségi állapotáért. Dr. Mike Dow forradalmian új könyve ötvözi a tudomány élvonalába tartozó kutatásokat és a könnyen megvalósítható életvezetési stratégiákat. Az itt leírtak segítenek abban, hogy ön a lehető legjobban nézzen ki, és a lehető legjobban érezze magát. Kötelező olvasmány mind az orvosok, mind a betegek számára.\"\r\n\r\n- Dr. Anthony Youn, a The Age Fix című sikerkönyv szerzője\r\n\r\n\"A cukor egy agyzsugorító, hízlaló molekula, amelynek semmi köze nincs a teljes értékű táplálékforrásokhoz. Gyakran telített zsírokkal párosulva (helló, fánk!) a tápértéket nélkülöző, gyilkos élelmiszerektől való függőséghez vezet, és ez végül szívbetegséget, stroke-ot, rákot, elhízást és cukorbetegséget okozhat. Elismerésemet fejezem ki dr. Mike Dow-nak, amiért a cukor szerelmeseinek egy valóban működő programot kínál.\"\r\n\r\n- Dr. Kristi Funk sebész, mellrák-specialista, a Breast: The Owner\'s Manual című sikerkönyv szerzője.', '9789635446537', 'https://s03.static.libri.hu/cover/ed/9/8396194_5.jpg', 352, 4800, 2022, 12),
(62, 'Dusty - Egy életre szóló barátság', 'Paul egy nap szorult helyzetbe kerül. Tudja, hogy semmi esélye nincs az öt utcagyerekkel szemben, akik a pénzét akarják. Ám hirtelen megjelenik egy kutya, és elijeszti a támadókat. Ettől kezdve Paul és Dusty elválaszthatatlan barátok lesznek. A fiú érzi, hogy a kutya fél valamitől. De vajon mitől? Paul előtt lassan, lépésről-lépésre feltárul egy titok. Tudja, hogy Dusty ártatlan, de vajon be tudja majd bizonyítani?', '9789634037798', 'https://s05.static.libri.hu/cover/f6/1/6179699_5.jpg', 256, 1990, 2022, 30),
(63, 'Hogyan állj ki magadért', 'A Hogyan állj ki magadért merész és szókimondó kézikönyv azoknak, akik a hangjukat keresik a vágyaik kifejezéséhez és ahhoz, hogy olyan életet éljenek, amilyenre szívük mélyén áhítoznak.\r\n\r\nNőként eléggé unalmas már állandóan azt hallgatnunk, hogy \"túl ilyenek meg olyanok\" vagyunk. Csak mert végre kinyitjuk a szánkat, és kiállunk önmagukért és azokért a dolgokért, amikben hiszünk, amikre vágyunk vagy amikre szükségünk van. Eljött az idő, hogy kiteljesedjünk, hogy megmutassuk, itt vagyunk mi is! Andrea Owennek, a Hogyan ne érezd magad sz*rul szerzőjének, életmód-tanácsadónak és coachnak mélységes meggyőződése, hogy mindez elérhető.\r\n\r\nJelen korunk egyik alapvetése, hogy a nőknek a partvonalon illik leélni az életüket, saját igényeiket és szükségleteiket mindig a háttérbe szorítva. Ezt a társadalmi kondicionálást kérdőjelezi meg és töri darabokra ez a közvetlen hangnemben megírt könyv. Megmutatja, hogyan vehetjük kezünkbe saját életünk irányítását, hogyan lehetünk végre saját magunk urai.\r\n\r\nA Hogyan állj ki magadért azokat a beidegződéseket elemzi, amelyek a nők erejét roncsolják és ássák alá, helyettük pedig új viselkedési formákat kínál, melyek segítségével kiteljesíthetjük a vágyainkat és saját szükségleteinket. Owen nyers és őszinte iránymutatást ad a tudatos felejtés módszeréhez, mellyel leszokhatunk végre arról, hogy mindig apróra összehúzzuk magunkat, és rászokhatunk arra, hogy bízzunk az ösztöneinkben és belső bölcsességünkben. Hallassuk végre a hangunkat! Ne csak önmagunkért, hanem minden előttünk járó és utánunk jövő nőtársunkért.', '9789634199885', 'https://s03.static.libri.hu/cover/1a/d/8333155_5.jpg', 347, 3980, 2022, 35),
(64, 'Amit a testünk üzen', 'Számtalan információ áll a rendelkezésünkre ahhoz, hogy boldog és beteljesült életet tudjunk élni. Mégis akadnak az életünkben kisebb-nagyobb szakaszok, amikor nehézségekkel, betegségekkel kerülünk szembe - legyen akár egy ártalmatlannak tűnő nátha vagy egy csonttörés. A testünk ilyenkor üzenetet szeretne közvetíteni, hiszen lelkünk számára nem áll rendelkezésre más eszköztár. A tudatalattink a testünkön keresztül küldi az információt a sorsunk alakulásáról. Ez a könyv egyfajta lexikon az üzenetek sikeres megfejtéséhez. A Te tested mit üzen számodra? Most kiderül!', '9786156367044', 'https://s03.static.libri.hu/cover/17/c/8354147_5.jpg', 260, 3950, 2022, 36),
(65, 'A magyarok Istenének elrablása', 'Borzasztó tájékozatlanság és tudatlanság uralkodik nemzeti múltunk minden kérdésében. Hazugságok, titkok átláthatatlan leple fedi előlünk igaz történelmünket. Magyarok titkos története című sorozatunk előző, Királygyilkosságok című kötetében a titkok halmaza között egy roppant különös eseményről számolunk be, Willermus apát cseléről, aki egy templomi falrésen át kileste Salamon király titkos tanácskozását a későbbi Géza (Magnus) király meggyilkolásának kiterveléséről s a résen át, lelkesedve, nekünk is bepillantást engedett a történelem felszíne mögött folyó titkos eseményekbe: \"Willermus vagy Vilmos apát, miután látta, hogy Salamon király bizalmas követeivel tanácskozásra állt össze, elrejtőzött valami kis zugolyban (talán a gyóntató fülkében), ahonnan mindent jól láthatott és hallhatott. A fülke résén át bekukucskált a templomban zajló tanácskozásba és az Ő révén, általa, mintegy az Ő szemén át, mi is bepillanthatunk történelmünk egy olyan titkos eseményébe, amelyet gondosan el akartak rejteni minden fül és minden emberi szem elől\" (I. m. 73.) Grandpierre K. Endre jelen munkája egy titkos rést nyit olvasóinak arra a rejtelmes, szemünk elől tökéletesen elfedett nemzeti tragédia hátborzongató háttértényezőire, amelyben a magyarság a X-XI században átesett.', '9789637707216', 'https://s01.static.libri.hu/cover/3e/5/8379238_4.jpg', 246, 3500, 2022, 37),
(66, 'Talleyrand', 'Charles-Maurice de Talleyrand-Périgord (1754-1838) a világtörténelem egyik lesikeresebb, ugyanakkor legellentmondásosabb politikusa; Franciaország külügyminisztere, miniszterelnöke. Az arisztokrata családból származó ifjú gyermekkora óta rokkantsággal küzdött, így számára csak az egyházi pálya maradt. Ugyanakkor imádta a nőket, és nagy összegekben kártyázott. Hatalomra juttatta, majd elárulta a Bourbonokat, a forradalmat, Napóleont és újra a Bourbonokat. Pénzért fontos információkat adott át Franciaországról a hatalomra törő uralkodóknak, ugyanakkor többször is, például a bécsi kongresszuson, majd tizenöt évvel később londoni követként, megmentette Franciaországot. Kiemelkedő intelligenciájú, hazájáért küzdő politikus, vagy mindenre kapható korrupt vezető? Lehet-e valaki a kettő egyszerre? Ezekre a kérdésekre keres választ a könyv.', '9789635446544', 'https://s06.static.libri.hu/cover/9c/0/8197286_5.jpg', 239, 3800, 2022, 12),
(67, 'Hitler lovai', 'Arthur Brandet, a holland műkincsnyomozót találkára hívja a műkereskedelem világának egyik legveszedelmesebb figurája, hogy a segítségét kérje egy szobor felkutatásához és eredetiségének megállapításához. A válasz egyben a második világháború egyik nagy rejtélyéről is fellebbentené a fátylat: arról, hogy mi is történt valójában Hitler kedvenc szobrával, a \"Lépkedő lovak\"-kal, amely Berlin bombázásakor tűnt el.\r\nBrand a szobor nyomába ered: texasi olajmágnásnak álcázva magát lemerül a máig létező náci alvilágba, ahol újfasiszták és volt KGB-ügynökök hozzák a szabályokat, és eurómilliókért cserélnek gazdát a Harmadik Birodalom relikviái. A nyomozás egyre kockázatosabbá válik, amikor Brand csapdát állít, hogy elkapja a bűnözőket, akik a feketepiacon próbálják eladni a két bronzlovat. De kikre is vadászik valójában? És célt ér-e, mielőtt leleplezik valódi kilétét? A Hitler lovai egy John Le Carré-regényhez méltóan szövevényes kaland, a történelem egyik legkülönlegesebb műkincsrablásának krónikája.', '9789635041688', 'https://s03.static.libri.hu/cover/40/7/6409434_5.jpg', 270, 3599, 2021, 38),
(68, 'Szlovákia királyt választ', '\"Legyen merszünk kimondani, hogy a magyar történelem a mi közös történelmünk. Hogy a magyar királyok a mi közös királyaink voltak\" - mondta a szlovák miniszterelnök a trianoni békeszerződés századik évfordulóján. \"Ne féljünk felvállalni azt, amire joggal lehetünk büszkék. Egy birodalom részei voltunk, amelyet olyan jelentős uralkodók vezettek, mint Szent István, Károly Róbert, Corvin Mátyás vagy Mária Terézia. Ők a mi királyaink is voltak...\" - ez pedig a szlovák házelnöktől hangzott el Szlovákia függetlenné válásának tizedik évfordulóján.\r\nA magyar olvasó számára talán szokatlan hangok ezek, azonban a mai szlovák közéletben nem ritka, hogy a Magyar Királyság történelmére a szlovák múlt részeként hivatkoznak. Nem volt ez mindig így: ezekre az évszázadokra sokáig őseik \"ezeréves rabságaként\" tekintett a szlovákok jelentős része. Mára a múltról alkotott szlovák kép megváltozott, színesebb lett, több hang érvényesül benne, sokfajta gondolat fér el egymás mellett. Ez a könyv arra tesz kísérletet, hogy e hangokat tolmácsolja a magyar olvasók felé. Bizonyára lesz köztük, ami a magyar fül számára idegennek, ellenségesnek hat, de olyan is, ami szimpátiát kelt.\r\nMindeközben a magyar olvasók előtt olyan kultúrtörténeti érdekességek is feltárulnak a Magyar Királyságról, amelyek nem általánosan ismertek: például, hogy középkori hegyi rablók korabeli szlovák nyelven írtak zsarolólevelet Bártfának; hogy Mátyás egyik magyar katonája írta az első összefüggő szlovák nyelvemléket vagy hogy szlovákul is születtek a törökellenes harcokról írt históriás énekek.\r\nE könyvből tehát nemcsak a \"szlovákok titkairól\", de saját történelméről is sok újdonságot tudhat meg a magyar olvasó.', '9789634545996', 'https://s03.static.libri.hu/cover/8e/2/8199374_5.jpg', 256, 4500, 2021, 39),
(69, 'Só, zsír, sav, hő - A jó főzés négy eleme', 'Samin Nosrat másodéves egyetemistaként került kapcsolatba a főzéssel, amikor Kalifornia egyik emblematikus éttermében, a Chez Panisse-ban kezdett dolgozni, ahol a ranglétra összes fokát végigjárva séf lett. Azóta a főzés a szenvedélye, akármerre járt a világban, Japántól Mexikóig, Olaszországtól Amerikáig az ízek titkát kutatta, és azt tapasztalta, hogy az ételt négy elem tesz tökéletessé vagy tesz tönkre: a só, a zsír, a sav vagy a hő.\r\nA só, ami felerősíti az ízeket, a zsír, ami ízt ad és állagot képez, a sav, ami egyensúlyba hozza az ízeket, és a hő, ami végső soron meghatározza az ételek állagát.\r\nSamin Nosrat könyvének első fele olyan, mint egy profi főzőtanfolyam, a második részében található több mint 100 recept elkészítésével pedig kipróbálhatjuk a tanultakat.\r\n\r\nSamin Nosrat amerikai séf és gasztronómiai író - egyesek szerint \"a következő Julia Child\" - 2000 óta foglalkozik hivatásszerűen főzéssel. 2017-ben megjelent Só, zsír, sav, hő című első könyvét, melyen 14 évig dolgozott, számos díjjal jutalmazták, a The Times Az év szakácskönyvének választotta. A belőle készült négyrészes sorozat a Netflixen látható.\r\n\r\n\"Számomra az egyetlen ember, aki megfejtette a gasztronómiai mátrixot, Samin Nosrat. Egy igazi, sallangmentes gasztrozseni. Ha egyetlenegy gasztrosorozatot nézel a Netflixen, legyen ez. Ha egyetlen szakácskönyved van otthon, legyen ez, és ígérem, megtanulsz főzni!\"\r\nWossala Rozina étteremtulajdonos, gasztronómus', '9789633558966', 'https://s05.static.libri.hu/cover/61/1/4922257_5.jpg', 469, 11990, 2022, 40),
(70, 'Limara Péksége - Házi Pékek Alapkönyve', 'Kenyér = liszt, só, élesztő, víz + Limara\r\n\r\nLibor Marcsi és a blogja, a Limara Péksége megkerülhetetlen, ha jól bevált, megsüthető, finom kelttészta-recepteket keresünk. A konyhában ő a legjobb barátnőnk.\r\nNaponta tízezernél többen keressük fel a blogját, így megsaccolni sem lehet, hányan készülődünk úgy a sütéshez a nagyvilágban, hogy az ő oldala van nyitva a laptopunkon, kinyomtatott vagy kézzel lefirkált receptjei hevernek a konyhaasztalon. Aztán büszkén terelünk mindenkit a forró tepsihez, hadd csodálják meg a végeredményt, Marcsinak pedig mosolyogva írunk egy kedves üzenetet, hogy beszámoljunk a sikerről. Ő mutatta meg nekünk a kenyérsütés varázsát. Ő inspirált nőket, férfiakat, amatőröket, sütésben jártasakat, hogy fedezzék fel és leljék örömüket a házi kenyér készítésében. És most végre itt a várva várt szakácskönyve! A kezdőket lépésről lépésre megtanítja kelt tésztát sütni, a gyakorlottaknak összegyűjtötte a legkedveltebb recepteket, míg a kísérletező kedvűeknek új finomságokat talált ki.\r\n\r\nLegyél hát te is házi pék!\r\n\r\nTarts Limarával ezen a kenyérillatú úton!', '9789630899345', 'https://s05.static.libri.hu/cover/d4/7/3298919_5.jpg', 188, 6000, 2022, 41),
(71, 'Együnk több zöldséget!', 'Kihagyhatatlan receptek a fenntarthatóbb bolygóért és a család egészségért!\r\nAz online tér gasztronómiai csatornáin nagy népszerűségnek örvendő Wichmann Anna - Annuskám - 50 bevált receptje\r\n- mindenevőknek, akik az egyhangú köretek vagy nehéz egytálételek szűk köréből kitörve szeretnének változatosabban, tudatosabban, egészségesebben enni;\r\n- azoknak, akik szívesebben fogyasztanának több zöldséget, de az ízekről, a házias kosztról, az ismerős fogásokról nem kívánnak lemondani.\r\n\r\nA könnyen beszerezhető, szezonális és változatos alapanyagokból készülő levesek, egytálételek, tészták, töltött és rakott finomságok a megszokottnál több zöldséggel és hüvelyessel, de 100%-os ízélménnyel a család minden tagját meggyőzik majd.\r\nHúsmentes vega és húsos ételek rengeteg rosttal, színesen és sütemények okosan - több fehérjével, de kevesebb szénhidráttal és mesés ízekkel!', '9789632886862', 'https://s03.static.libri.hu/cover/68/c/8568057_5.jpg', 132, 4990, 2022, 42),
(72, 'Igazi magyar konyha - Szegedi szakácskönyv', 'Rézi néni szakácskönyve a legismertebb szakácskönyvek közé tartozik. A számtalan kiadást megért szakácskönyvből dédszüleink konyhaművészetével ismerkedhetünk meg. A könyv először 1876-ban jelent meg és szerzője Dolecskó Terézia volt, aki igazi művésze volt a konyha tudományának. Rézi néni könyvét Tömörkény István is méltatta.', '9786156385185', 'https://s03.static.libri.hu/cover/d4/3/8526156_5.jpg', 504, 4990, 2022, 43),
(73, 'Főzőiskola Potter-rajongóknak - Egyszerű és bűbájos finomságok', 'Üdvözlünk a mágia világában! A Potter-rajongók kedvenc szakácskönyve! Több mint 60 varázslatos recept, amelyeket minden varázslótanoncnak muszáj kipróbálni. Mindegy, hogy nagyszabású házibuliról, születésnapi ünnepségről vagy egyszerű filmes estéről van szó, ezek a finomságok minden Potter-rajongónak ízleni fognak! Huss és pöcc! Számtalan konyhai tipp és varázsige segítségével könnyedén mozgásba lendíthetjük a főzőkanalat, és sok új konyhai ismeretet szerezhetünk - és garantáltan nem robbanunk fel közben! A Roxfort világa a konyhában! Mrs. Weasley húsgombóca, Petunia néni lazaca, Paddington burger, a Florean Fortescue Fagylaltszalon nyalánkságai, üstben készült édességek, és még sok minden más!', '9789635822980', 'https://s04.static.libri.hu/cover/54/8/8483783_5.jpg', 144, 4990, 2022, 14),
(74, 'Régi magyar szakácskönyvek', 'Radványi és sajókazai báró Radvánszky Béla (Sajókaza, 1849. március 1. - Budapest, 1906. május 2.) művelődés- és irodalomtörténész, politikus, császári és királyi kamarás, valóságos belső titkos tanácsos, koronaőr, a Magyar Tudományos Akadémia tiszteletbeli tagja, a Magyar Heraldikai és Genealógiai Társaság elnöke.\r\nBáró Radvánszky Béla, mint művelődéstörténész sok érdekességet gyűjtött össze és dolgozott fel műveiben. Jelen munkája a \"Régi magyar szakácskönyvek\" címet viseli. A szerző az alábbi szavakkal méltatja művét: \"Nemzetünk benső élete ismeretének egy fontos részét képezi a régi magyar konyha állapota. Méltán érdekelhet bennünket, hogy őseink hogyan étkeztek, mit ettek, miként főzték az ételeket, mennyire volt nálunk kifejlődve az elmúlt századok szakácsművészete, minő múltra támaszkodott az e század első felében még híres magyar konyha.\"', '9786156385116', 'https://s03.static.libri.hu/cover/5d/c/8396193_5.jpg', 414, 3300, 2022, 43),
(75, 'Fine Restaurants 2021 - The Budapest Business Journal\'s Restaurant Review 2021', 'A Fine Restaurants 2021 kiadvány a prémium kategóriájú éttermeket mutatja be, melyek ideálisak egy kellemes reggeli, ebéd, vacsora vagy akár üzleti találkozó lebonyolítására. Letisztult layout, gyönyörű képek, és praktikus kódrendszer segíti az olvasót a tökéletes helyszín kiválasztásában, legyen szó akár budapesti, akár vidéki éttermekről.\r\n\r\nFeltérképeztük a friss gasztronómiai termékek piacát, a Michelin-csillagos helyeket, és az újonnan nyílt éttermeket, amiket feltétlenül érdemes kipróbálni.', '2050000084072', 'https://s03.static.libri.hu/cover/6a/1/8273210_5.jpg', 162, 5990, 2021, 44),
(76, 'Bolygóbarát konyha', 'A könyv elgondolkoztat arról, hogy miként lehet vásárolni és főzni környezetbarát módon. Megtanít felismerni, hogy mely élelmiszereket használjuk és melyeket inkább kerüljük. A könyvben 30 nagyszerű receptet is találhatunk, amelyeket Ön is megszeret, nem csak a bolygónk. A receptek mellett a kiadvány számos tippet és tanácsot is ad, hogy hogyan érhetünk el ezekkel az apró lépésekkel nagy változásokat.\r\n\r\nA könyvben 30 környezetbarát szemléletű receptet talál, amelyeket Ön is és a bolygónk is megszeret. Mindemellett számos tippet és tanácsot ad, hogy milyen apró lépéseket tehetünk a jelentős változások érdekében.\r\n\r\nNagyon jól tudjuk, hogy étkezési és vásárlási stílusunk jelentős megváltoztatása nélkül a természet továbbra is szenvedni fog. De néha nehéz eldönteni, hogy mely élelmiszerek valóban környezetbarátok. Ez a könyv világos és egyértelmű tényekkel segíti a tudatos változtatást. Megtudhatja, hogy mely környezetünket terhelő termékeket kerülje, milyen élelmiszereket vásároljon és hogyan főzhet belőlük otthon ízletes ételeket.\r\n\r\nA könyv bemutatja az élelmiszerek előállításának különböző módszereit is, kiemelve azokat a nyersanyagokat, amelyek termesztése kevesebb természeti erőforrást igényel. Bár nincs egyetlen helyes \"fenntartható élelmiszer\" sem, a célunk az, hogy bemutassuk a bolygóbarát táplálkozás alapelveit, és feltárjuk azokat a folyamatokat, amelyek az élelmiszertermelés során általában rejtetten zajlanak. A könyv emellett foglalkozik a saját élelmiszer termesztés módszereivel is.\r\n\r\nEz a tudás segíthet abban, hogy fogyasztóként jobb döntéseket hozzunk a Földünk érdekében. Bár a legtöbb élelmiszer nem 100%-ban fenntartható, bizonyos élelmiszerek gyártása kímélőbb a bolygónk számára. Ha ezeket az összetevőket beépítjük étrendünkbe és körültekintőbben választjuk meg az élelmiszereket, segíthetünk megőrizni a Földet az utánunk jövő generációk számára.', '9789635050826', 'https://s03.static.libri.hu/cover/3e/8/7996516_5.jpg', 128, 3490, 2021, 45),
(77, 'The Culinary Chronicle - Best of Hungary', 'This 9th publication of the Culinary Chronicle series is built around the unique culinary diversity in Hungary. Besides top-class restaurants in and outside Budapest, the metropolis along the Danube, this publication also provides an insight on selected wine regions, the unique Hungaricum Palinka, and Herend a porcelain manufactory that creates excellent hand painted porcelain.', '2000000009186', 'https://s04.static.libri.hu/cover/15/a/7995041_5.jpg', 363, 34990, 2021, 46),
(78, 'Eszem, tehát vagyok - Étel- és Életreceptek', 'Ebben a rendkívüli könyvben a híres filmsztár és sikerszerző humoros fűszerezéssel ötvözi a gondolkodás művészetét a főzés művészetével. Egyik legnagyobb szenvedélye, az evés, számára a létezés középpontja. Véleményét tizenkét tekintélyes gondolkodó előtt védi meg, akik álmában látogatják meg.\r\nHumorral és iróniával teli káprázatos szellemi párbajt vív olyan neves filozófusokkal, mint Szókratész, Konfuciusz vagy Immanuel Kant. Ha pedig cserben hagyják a szavak, akkor ínycsiklandó olasz ételkülönlegességeket készít vendégeinek, a tészta- és halételektől a jellegzetes nápolyi süteményekig, mire jóllakottan és elégedetten kiegyeznek.\r\nBud Spencer különleges könyve arra ösztönöz, hogy együtt nevessünk és főzzünk vele, miközben folyamatosan elhiteti velünk, hogy teli hassal minden könnyebb.', '9789635720965', 'https://s05.static.libri.hu/cover/6c/e/7935831_5.jpg', 366, 3999, 2021, 47),
(79, 'Bea konyhája 3.', 'Gáspár Bea újabb receptválogatásából egy nagycsalád mindennapjai sejlenek fel: van benne ételleírás és sztori dőzsöléshez, vendéglátásra és hétköznapokra, múltidéző és frissen tanult fogások, persze mindez a konyhából szemlélve, megélve és leírva. Az első nagy fejezetben hagyományos ételek Bea módra megcsavart receptjeit találjuk, például a lekvárral bolondított mákos tésztát, a töltött aranygaluskát, vagy a klasszikus menzás fogások megújított változatait, mint a rántott párizsit krémes krumplifőzelékkel, vagy a krumplis lasagnét. A könyv második részében modern ételek receptjei sorakoznak. A mai konyhatechnológia sztárja, a konfitálás vagy a csirketerrine mellett remekül megférnek a háziasszonyokat segítő tippek is. Bea receptjeinek olvasása és elkészítése mindenkit rádöbbent, hogy az olyan különleges alapanyagok is, mint a kapribogyó, a batáta vagy a ricotta, néhány ügyes trükkel megszelídíthetők, és a család kedvenceivé tehetők. A receptek bevezetőiben gasztrotörténeti csemegékkel is szolgál a szerző, sőt megcsillantja humorát is, amint a hizlaló sportszeletről vagy a repülő madártejről ír. A kötetben kezdő és haladó konyhatündérek egyaránt találnak fakanalukra valót.', '9786155417818', 'https://s05.static.libri.hu/cover/b7/0/7912292_5.jpg', 141, 5990, 2021, 48),
(80, 'Főzni menő - #kisszakácsbiblia', 'Ha valaki azt mondja, hogy nincsenek szuperképességek, nem járt még a konyhában. Vasárnapi ebéd anyuékkal, Xbox maraton a tesókkal, pizsiparty a csajokkal, szülinap vagy filmnézés a haverokkal? A finom ételek a világ minden táján összehozzák az embereket, legyenek kicsik vagy nagyok, ehhez pedig nincs szükséged másra, mint egy kis gyakorlásra. Ebben a könyvben megtalálsz mindent, amire szükséged lehet, ha te akarsz lenni a család vagy a társaság hőse, aki az asztalhoz ülteti a többieket, a dolgod csak annyi, hogy megmutasd:\r\nfőzni menő, legyél akár mesterszakács, haladó, vagy kezdő. Hogy a könyv igazán menő legyen, a benne található fotók mindegyike mobiltelefonnal készült.', '9786155417726', 'https://s03.static.libri.hu/cover/36/c/7911895_5.jpg', 408, 5990, 2021, 48);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `book_author`
--

CREATE TABLE `book_author` (
  `Id` int(11) NOT NULL,
  `BookId` int(11) NOT NULL,
  `AuthorId` int(11) NOT NULL,
  `GenreId` int(11) NOT NULL,
  `LanguageId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `book_author`
--

INSERT INTO `book_author` (`Id`, `BookId`, `AuthorId`, `GenreId`, `LanguageId`) VALUES
(1, 1, 1, 1, 1),
(2, 2, 2, 1, 1),
(3, 3, 2, 1, 1),
(4, 4, 3, 1, 1),
(5, 5, 4, 1, 1),
(6, 6, 5, 1, 1),
(7, 7, 6, 5, 2),
(8, 8, 6, 1, 1),
(9, 9, 7, 1, 1),
(10, 10, 8, 1, 1),
(11, 11, 9, 1, 1),
(12, 12, 10, 1, 1),
(13, 13, 10, 1, 1),
(14, 14, 11, 1, 1),
(15, 15, 12, 1, 1),
(16, 16, 13, 3, 2),
(17, 17, 13, 1, 1),
(18, 18, 14, 1, 1),
(19, 19, 15, 1, 1),
(20, 20, 16, 2, 1),
(21, 21, 17, 2, 1),
(22, 22, 18, 2, 1),
(23, 23, 19, 2, 3),
(24, 24, 19, 2, 1),
(25, 25, 19, 2, 1),
(26, 26, 20, 2, 1),
(27, 27, 21, 2, 1),
(28, 28, 22, 3, 1),
(29, 29, 23, 3, 1),
(30, 30, 24, 3, 1),
(31, 31, 24, 3, 1),
(32, 32, 25, 3, 1),
(33, 33, 26, 3, 1),
(34, 34, 26, 3, 1),
(35, 35, 27, 3, 1),
(36, 36, 28, 3, 1),
(37, 37, 29, 3, 1),
(38, 38, 29, 3, 1),
(39, 39, 30, 3, 1),
(40, 40, 31, 3, 1),
(41, 41, 31, 3, 1),
(42, 42, 32, 6, 1),
(43, 43, 33, 6, 1),
(44, 44, 34, 6, 1),
(45, 45, 35, 6, 1),
(46, 46, 35, 6, 1),
(47, 47, 35, 6, 1),
(48, 48, 35, 6, 1),
(49, 49, 36, 6, 1),
(50, 50, 37, 6, 1),
(51, 51, 38, 6, 1),
(52, 52, 39, 6, 1),
(53, 53, 40, 5, 1),
(54, 54, 41, 5, 1),
(55, 55, 42, 5, 1),
(56, 56, 43, 5, 1),
(57, 57, 44, 5, 1),
(58, 58, 45, 5, 1),
(59, 59, 46, 5, 1),
(60, 60, 47, 5, 1),
(61, 61, 48, 5, 1),
(62, 62, 49, 6, 1),
(63, 63, 50, 5, 1),
(64, 64, 51, 5, 1),
(65, 65, 52, 2, 1),
(66, 66, 53, 2, 1),
(67, 67, 54, 2, 1),
(68, 68, 55, 2, 1),
(69, 69, 56, 4, 1),
(70, 70, 57, 4, 1),
(71, 71, 58, 4, 1),
(72, 72, 59, 4, 1),
(73, 73, 60, 4, 1),
(74, 74, 61, 4, 1),
(75, 75, 62, 4, 3),
(76, 76, 63, 4, 1),
(77, 77, 64, 4, 3),
(78, 78, 65, 4, 1),
(79, 79, 66, 4, 1),
(80, 80, 67, 4, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `genres`
--

CREATE TABLE `genres` (
  `Id` int(11) NOT NULL,
  `Name` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `genres`
--

INSERT INTO `genres` (`Id`, `Name`) VALUES
(1, 'Comics'),
(2, 'History'),
(3, 'Literature'),
(4, 'Gastronomy'),
(5, 'Lifestyle'),
(6, 'Children\'s fiction');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `languages`
--

CREATE TABLE `languages` (
  `Id` int(11) NOT NULL,
  `Name` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `languages`
--

INSERT INTO `languages` (`Id`, `Name`) VALUES
(1, 'Hungarian'),
(2, 'Deutsch'),
(3, 'English');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `publishers`
--

CREATE TABLE `publishers` (
  `Id` int(11) NOT NULL,
  `Name` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `publishers`
--

INSERT INTO `publishers` (`Id`, `Name`) VALUES
(1, 'Szukits Könvykiadó és Könyvker'),
(2, 'Vad Virágok Kiadó Kft.'),
(3, 'Fumax Kft'),
(4, 'Libri Könyvkiadó Kft.'),
(5, 'Penguin Books LTD'),
(6, 'Athenaeum Kiadó Kft.'),
(7, 'Libub Group Kft.'),
(8, 'GOLDMANN'),
(9, 'Peko Kiadó'),
(10, 'Smaragd Kiadó'),
(11, 'Bölcsészettudományi Kutatóközp.'),
(12, 'Kossuth Kiadó Zrt.'),
(13, 'Püski Kiadó Kft.'),
(14, 'Alexandra Könyvesház Kft.'),
(15, 'DELEJ'),
(16, 'Könyvmolyképző Kiadó Kft.'),
(17, 'General Press Kiadó'),
(18, 'Könyv Guru'),
(19, 'Álomgyár Kiadó'),
(20, 'Magánkiadás'),
(21, 'Attraktor Könyvkiadó Kft.'),
(22, 'Csengőkert Kiadó'),
(23, 'Atlantic Press'),
(24, 'Lampion Könyvek'),
(25, 'Citera Kft.'),
(26, 'Menő Könyvek'),
(27, 'Animus Kiadó'),
(28, 'Móra Ferenc Ifjúsági Könyvkiadó Zrt.'),
(29, 'Pozsonyi Pagony Kft'),
(30, 'Manó Könyvek'),
(31, 'Scolar Kiadó Kft.'),
(32, 'Édesvíz Kiadó'),
(33, 'Reménygyógyulás Kft.'),
(34, '21. Század Kiadó'),
(35, 'Magnólia'),
(36, 'Marysol könyvkiadó'),
(37, 'Titokfejtő Könyvkiadó'),
(38, 'Európa Könyvkiadó Kft.'),
(39, 'Akadémiai Kiadó Zrt.'),
(40, 'Park Könyvkiadó Kft.'),
(41, 'Csipet kiadó'),
(42, 'Harmat Kiadói Alapítvány'),
(43, 'Nemzeti Örökség'),
(44, 'Business Publishing Services Kft.'),
(45, 'Lingea Kft.'),
(46, 'Optart AG'),
(47, 'Open Books'),
(48, 'Boook Kiadó Kft.');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20220406060740_NewDayDatabase', '5.0.14');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- A tábla indexei `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- A tábla indexei `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- A tábla indexei `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- A tábla indexei `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- A tábla indexei `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- A tábla indexei `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- A tábla indexei `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Books_PublisherId` (`PublisherId`);

--
-- A tábla indexei `book_author`
--
ALTER TABLE `book_author`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Book_Author_AuthorId` (`AuthorId`),
  ADD KEY `IX_Book_Author_BookId` (`BookId`),
  ADD KEY `IX_Book_Author_GenreId` (`GenreId`),
  ADD KEY `IX_Book_Author_LanguageId` (`LanguageId`);

--
-- A tábla indexei `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `languages`
--
ALTER TABLE `languages`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `authors`
--
ALTER TABLE `authors`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT a táblához `books`
--
ALTER TABLE `books`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT a táblához `book_author`
--
ALTER TABLE `book_author`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT a táblához `genres`
--
ALTER TABLE `genres`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `languages`
--
ALTER TABLE `languages`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `publishers`
--
ALTER TABLE `publishers`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `FK_Books_Publishers_PublisherId` FOREIGN KEY (`PublisherId`) REFERENCES `publishers` (`Id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `book_author`
--
ALTER TABLE `book_author`
  ADD CONSTRAINT `FK_Book_Author_Authors_AuthorId` FOREIGN KEY (`AuthorId`) REFERENCES `authors` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Book_Author_Books_BookId` FOREIGN KEY (`BookId`) REFERENCES `books` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Book_Author_Genres_GenreId` FOREIGN KEY (`GenreId`) REFERENCES `genres` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Book_Author_Languages_LanguageId` FOREIGN KEY (`LanguageId`) REFERENCES `languages` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;