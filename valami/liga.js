//let elso = document.getElementById("elso");
//let masodik = document.getElementById("masodik");
//elso.addEventListener("click", () =>{
//    let tarto = document.getElementById("tarto");
//    let masiktarto=document.createElement("div");
//    masiktarto.setAttribute("id", "tarto");
//    masiktarto.innerHTML = "<h1>Ez egy másik fejléc</h1>";
//    masiktarto.innerHTML = "<button id='masodik'>masodik gomb</button>";
//    document.body.replaceChild(masiktarto, tarto);
//});



let eGomb = document.getElementById('e');
eGomb.addEventListener("click", () => {
    let content = document.getElementById("content");

    let masikContent = document.createElement("div");
    masikContent.setAttribute("id", "content");
    masikContent.innerHTML = "<h2>E Csoport</h2>";
    masikContent.innerHTML += "<div class='csapatok'><h3>Atlético Madrid</h3> <p>Az Atlético de Madrid, teljes nevén Club Atlético de Madrid S.A.D. spanyol, madridi székhelyű futballklub, otthona sokáig a Manzanares folyó melletti Vicente Calderón stadion volt, de 2017-ben átadták új stadionját, a Wanda Metropolitano Stadiont. Az Atlético 11-szer nyerte meg a spanyol bajnokságot, és ugyanennyiszer a spanyol kupát is. 1962-ben a csapat elhódította Kupagyőztesek Európa-kupáját és 1974-ben megnyerte az Interkontinentális kupát. 2010-ben és 2012-ben is megnyerték az Európa-ligát, majd mindkét évben megnyerték az UEFA-szuperkupát is. Az utóbbi döntőben a kolumbiai Radamel Falcao mesterhármast szerzett. 2013-ban, 17 év után nyerte meg a Spanyol labdarúgókupát. Eddig háromszor jutott be a BEK/BL döntőjébe, ám mindháromszor alulmaradtak, az 1973-74-es szezon végén a FC Bayern München, a 2013-14-es, és a 2015-16-os döntőben pedig a Real Madrid CF ellen.</p> <img class='pic' src='https://cdn.discordapp.com/attachments/1153583327169753139/1173912434612899860/Atletico_Madrid_2017_logo.png?ex=6565ae26&is=65533926&hm=c667508690ba55c8982b758f0d70ede20d184f299bfc5fa4e0aa66ee78146529&' alt='Atlético Madrid'></div>";
    masikContent.innerHTML += "<div class='csapatok'><h3>SS Lazio</h3> <p>Az SS Lazio (teljes nevén Società Sportiva Lazio) egy Olaszországban, Rómában székelő sportegyesület rövidítése. Gyakran egyszerűen Lazio néven emlegetik. Székhelye Róma, Lazio tartományban, innen a neve is. A legnagyobb európai sportegyesületek egyike, 37 sportággal, többek közt krikett, kosárlabda, ejtőernyőzés.[1] A legfontosabb sportága a férfi labdarúgás. Fő riválisa az AS Roma. Jobboldali szellemű csapat, ezért is a kiélezett küzdelem a Romával, mert az inkább „balos”. Sok híres focista fordult itt meg (Nedved, Crespo, Stankovic, Vieri), de őket később gazdagabb klubok elvitték. Két alkalommal, 1974 és 2000 évben volt Serie A bajnok. Hétszer nyert Olasz Kupát. 1937-ben legendás meccset játszott az FTC-vel, ahol 4:2 arányban vereséget szenvedett. Hírhedt szurkoló tábora van, amelyik Irriducibili névre hallgatott. Jelenlegi kapitányuk Ciro Immobile. Legendás csapatkapitánya di Canio volt.</p> <img class='pic' src='https://upload.wikimedia.org/wikipedia/commons/thumb/3/37/S.S._Lazio_logo.svg/1665px-S.S._Lazio_logo.svg.png' alt='SS Lazio'></div>";
    masikContent.innerHTML += "<div class='csapatok'><h3>Feyenoord</h3> <p>A klub játékosai szinte minden egyes évben harcba szállnak és harcban állnak a holland bajnoki címért folytatott küzdelemben. Ennek következtében napjainkig tizenöt alkalommal végeztek a képzeletbeli bajnoki dobogó legtetején, számtalanszor hódították el a holland kupát. Ugyanakkor nemzetközi szinten is szép sikereket könyvelhet el a klub, legutóbbi kimagasló eredményüket a 2002-es UEFA kupáért folytatott küzdelemben mutatták fel, ekkor megnyerték a sorozatot. A csapat a 2021-2022-es szezonban bejutott az UEFA Európa Konferencia Liga döntőjébe, ahol az olasz AS Roma együttesétől 1-0 arányban vereséget szenvedtek.</p> <img class='pic' src='https://upload.wikimedia.org/wikipedia/en/thumb/e/e3/Feyenoord_logo.svg/640px-Feyenoord_logo.svg.png' alt='Feyenoord'></div>";
    masikContent.innerHTML += "<div class='csapatok'><h3>Celtic FC</h3> <p>A Celtic Football Club , közismert nevén Celtic (/ˈs ɛ t ɪ k / SEL - tik ) , egy glasgow - i székhelyű skót profi futballklub , amely a skót élvonalban játszik . A klubot 1887-ben alapították [nb 1] azzal a céllal, hogy enyhítse a bevándorló ír lakosság szegénységét Glasgow East End -ében . Első meccsüket 1888 májusában játszották, a Rangers elleni barátságos mérkőzésen , amelyet a Celtic 5–2-re megnyert. A Celtic meghonosodott a skót futballban, és a 20. század első évtizedében egymás után hat bajnoki címet nyert. A klub legnagyobb sikereit az 1960-as és 70-es években érte el Jock Stein vezetésével, amikor egymás után kilenc bajnoki címet és 1967-es Európa Kupát nyertek . A Celtic történelme során zöld-fehérben játszott, 1903-ban átvette az azóta is használt karikákat.</p> <img class='pic' src='https://upload.wikimedia.org/wikipedia/en/thumb/3/35/Celtic_FC.svg/1200px-Celtic_FC.svg.png' alt='Celtic FC'></div>";
    masikContent.innerHTML += "<div class='table'><table><thead><tr><td>Állás</td><td>Lejátszott</td><td>Nyert</td><td>Döntetlen</td><td>vesztett</td><td>pontok</td></tr><thead><tbody><tr><th>1. Atlético Mardid</th><td>4</td><td>2</td><td>2</td><td>0</td><td>8</td></tr><tr><th>2. SS Lazio</th><td>4</td><td>2</td><td>1</td><td>1</td><td>7</td></tr><tr><th>3. Feyenoord</th><td>4</td><td>2</td><td>0</td><td>2</td><td>6</td></tr><tr><th>4. Celtic FC</th><td>4</td><td>0</td><td>1</td><td>3</td><td>1</td></tr></tbody></table></div>";
    document.body.replaceChild(masikContent, content);
});


let fGomb = document.getElementById('f');
fGomb.addEventListener("click", () => {
    let content = document.getElementById("content");

    let masikContent2 = document.createElement("div");
    masikContent2.setAttribute("id", "content");
    masikContent2.innerHTML = "<h2>F Csoport</h2>";
    masikContent2.innerHTML += "<div class='csapatok'><h3>Borussia Durtmund</h3> <p>A Borussia Dortmund (rövidítéseiben: BVB vagy BVB 09) német sportegyesület, székhelye Dortmund. A BVB Németország egyik legsikeresebb klubja, egyben az első német csapat, amely nemzetközi trófeát nyert (1966, KEK). Sikereinek csúcsát 1997-ben Ottmar Hitzfeld irányítása alatt érte el, többek között az UEFA Bajnokok Ligáját, majd ezt követően az interkontinentális kupát is elhódította. A Borussia Dortmund jelenleg is a Bundesligában játszik, és a harmadik helyen áll a német örökranglistán. Legutóbbi bajnoki címét a 2011-12-es szezonban, Jürgen Klopp vezetőedző irányításával érte el. A dortmundi futballcsapatot nemcsak a múltja, hanem egyedülálló szurkolótábora miatt is Európa legnagyobb klubjai közé sorolják. A 81 264 néző befogadására alkalmas Signal Iduna Park minden mérkőzésen megtelik, a dortmundi átlagnézőszám egyedülálló Európában. Habár a Borussia Dortmundot eredetileg labdarúgó szakosztályként alapították, van egy kézilabda és asztalitenisz szakosztálya is. A tagok száma az egyesületben kb. 35 000 fő.</p> <img class='pic' src='https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/800px-Borussia_Dortmund_logo.svg.png' alt='Borussia Durtmund'></div>";
    masikContent2.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent2.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent2.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent2.innerHTML += "<div class='table'><table><thead><tr><td>Állás</td><td>Lejátszott</td><td>Nyert</td><td>Döntetlen</td><td>vesztett</td><td>pontok</td></tr><thead><tbody><tr><th>1. Atlético Mardid</th><td>4</td><td>2</td><td>2</td><td>0</td><td>8</td></tr><tr><th>2. SS Lazio</th><td>4</td><td>2</td><td>1</td><td>1</td><td>7</td></tr><tr><th>3. Feyenoord</th><td>4</td><td>2</td><td>0</td><td>2</td><td>6</td></tr><tr><th>4. Celtic FC</th><td>4</td><td>0</td><td>1</td><td>3</td><td>1</td></tr></tbody></table></div>";
    document.body.replaceChild(masikContent2, content);
});


let gGomb = document.getElementById('g');
gGomb.addEventListener("click", () => {
    let content = document.getElementById("content");

    let masikContent3 = document.createElement("div");
    masikContent3.setAttribute("id", "content");
    masikContent3.innerHTML = "<h2>G Csoport</h2>";
    masikContent3.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent3.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent3.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent3.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent3.innerHTML += "<div class='table'><table><thead><tr><td>Állás</td><td>Lejátszott</td><td>Nyert</td><td>Döntetlen</td><td>vesztett</td><td>pontok</td></tr><thead><tbody><tr><th>1. Atlético Mardid</th><td>4</td><td>2</td><td>2</td><td>0</td><td>8</td></tr><tr><th>2. SS Lazio</th><td>4</td><td>2</td><td>1</td><td>1</td><td>7</td></tr><tr><th>3. Feyenoord</th><td>4</td><td>2</td><td>0</td><td>2</td><td>6</td></tr><tr><th>4. Celtic FC</th><td>4</td><td>0</td><td>1</td><td>3</td><td>1</td></tr></tbody></table></div>";
    document.body.replaceChild(masikContent3, content);
});


let hGomb = document.getElementById('h');
hGomb.addEventListener("click", () => {
    let content = document.getElementById("content");

    let masikContent4 = document.createElement("div");
    masikContent4.setAttribute("id", "content");
    masikContent4.innerHTML = "<h2>H Csoport</h2>";
    masikContent4.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent4.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent4.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent4.innerHTML += "<div class='csapatok'><h3></h3> <p></p> <img class='pic' src='' alt=''></div>";
    masikContent4.innerHTML += "<div class='table'><table><thead><tr><td>Állás</td><td>Lejátszott</td><td>Nyert</td><td>Döntetlen</td><td>vesztett</td><td>pontok</td></tr><thead><tbody><tr><th>1. Atlético Mardid</th><td>4</td><td>2</td><td>2</td><td>0</td><td>8</td></tr><tr><th>2. SS Lazio</th><td>4</td><td>2</td><td>1</td><td>1</td><td>7</td></tr><tr><th>3. Feyenoord</th><td>4</td><td>2</td><td>0</td><td>2</td><td>6</td></tr><tr><th>4. Celtic FC</th><td>4</td><td>0</td><td>1</td><td>3</td><td>1</td></tr></tbody></table></div>";
    document.body.replaceChild(masikContent4, content);
});