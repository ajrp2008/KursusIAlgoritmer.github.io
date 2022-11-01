# Obligatorisk aflevering 2 - deadline onsdag d19/10 eller mandag d.14/11

## Del 1: Valgt løsningsmetode til appen
På en skibake ligger nedadgående pister forbundet af steder, der i nogle tilfælde forgrenner sig til nye pister. Ved ende-stationer er der mulighed for at tage en lift tilbage til bjergets top. Hver pist tager 1 minut. Liften til toppen tager 5 minutter.

Kravene til den ønskede løsning er følgende:
1. Appen skal kunne indlæse hvordan pisterne er forbundet.
2. Appen skal kunne svare på hvad der er den hurtigste vej fra et punkt a til b.
3. Appen skal kunne svare på hvor længe det tager at fra a til b.

Løsningen:
1. Da alle pister er nedadgående vælges det at imlementere piste-systemet som en rettet graf.
For hver enkelt endestation, dvs. kanter med udgrad 0, tilføjes en yderligere forbindelse af fire nye lift-knuder der forbinder endestationen med toppen af bjerget. Denne forbindelse gør det ud for liften. Hvis hver kant svarer til en rejsetid på 1 minut, vil forbindelsen fra en endestation til toppen af bjerget dermed udgøre de beskrevne 5 minutter.     
2. For at finde den hurtigste vej laves en brede-først-søgning fra det ønskede startpunkt. Det er på den måde muligt at udskrive den hurtigste vej til et givent endepunkt, ved at udlade de ekstra fire lift-knuder.      
3. For at finde tiden for en bestemt rute laves en brede-først-søgning fra det ønskede startpunkt. Antallet af kanter i ruten udgør dermed rejsetiden.   


## Del 2: Koden

## Del 3: Analyse af udførselstiden som funktion af n og vej/tids operationer
