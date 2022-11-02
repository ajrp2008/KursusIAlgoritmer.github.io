# Obligatorisk aflevering 2 - deadline onsdag d19/10 eller mandag d.14/11

## Del 1: Valgt løsningsmetode til appen
På en skibake ligger "n-1" nedadgående pister forbundet af "n" steder, der i nogle tilfælde forgrenner sig til nye pister. Ved ende-stationer er der mulighed for at tage en lift tilbage til bjergets top. Rejsetiden for hver pist er 1 minut. Rejsetiden for liften til toppen er 5 minutter.

Løsningen:
1. ***Oprettelse af kortet:*** Da alle pister er nedadgående vælges det at imlementere piste-systemet som en rettet graf. For hver enkelt endestation, dvs. kanter med udgrad 0, tilføjes en yderligere forbindelse af fire nye lift-knuder, der forbinder endestationen med toppen af bjerget. Denne forbindelse gør det ud for liften. Hvis hver kant svarer til en rejsetid på 1 minut, vil forbindelsen fra en endestation til toppen af bjerget dermed udgøre de beskrevne 5 minutter.     
2. ***Udskrivning af hurtigste vej:*** For at finde den hurtigste vej laves en brede-først-søgning fra det ønskede startpunkt. Det er på den måde muligt at udskrive den hurtigste vej til et givent endepunkt, ved at udlade de ekstra fire lift-knuder.      
3. ***Beregning af hurtigste vej:*** For at finde tiden for en bestemt rute laves en brede-først-søgning fra det ønskede startpunkt. Antallet af kanter i ruten udgør dermed rejsetiden.   


## Del 2: Koden

## Del 3: Analyse af udførselstiden som funktion af n
Den del af løsningen, der har størst betydning for tiden det tager at indlæse kortet over pister og lift er oprettelsen af den rettede graf. Den rettede graf er implementeret som en "ajacency list". Både oprettelsestiden er derfor propertionelle med E+V, hvor E er antallet af kanter og V er antallet af knuder. Udskivning af den hurtigste vej og den tiden er imlementeret som brede-først-søgninger og derfor ligeledes en udførselstiden propertionelt med E+V. Derfor bergnes udførselstiden T kun en gang.

Antallet af kanter består af: (1) De n-1 input kanter. (2) De 4 kanter, der oprettes til beskrive liften til toppen af bjerget (3) De kanter, der forbinder endestationer med liften. Kanterne fra enstationen til liften kan højest blive n-1 og minimum 1.
I alt:
>E_max = 2n + 2 eller E_min = n + 4    

Antallet af knuder vil altid bestå af de n input og de ekstra 4 til liften, ialt:
>V = n + 4    

Oprettelsestiden er derfor:  
>Tmax = 3n+6
>Tmin = 2n+8
