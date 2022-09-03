# Del 2 : Poser, køer og stakke

 disse data strukturer har grundlæggende samme formål nemlig at opbevare objekter.  
 den eneste forskel er hvordan man:
 - indsætter
 - fjerner
 - eller itererer hen over strukturen

-------------------------------------

## Stakken - også kaldet stack ...

Vi beskriver den vha. en API:

- push
- pop
- isEmpty

### linked list implementation

Proposition: alle operationer vil tage konstant tid

Proposition: En stak med N elementer koster ca. 40 N bytes 
16 bytes overhead (moderne java 12 bytes), 8 bytes inner class, ... 

### array implementation

Det er vigtigt at udtænke en metode for hvordan man forstørrer sit array
der ikke koster for meget!



