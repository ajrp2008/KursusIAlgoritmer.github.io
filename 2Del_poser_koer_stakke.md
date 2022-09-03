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

>Ved at fordoble længden på vores array, hver gang der er overløb - koster det mindst muligt tid
>Omkostninger ved at indsætte 10-elementer i et størrelse 2 array:
>> 1 (1stk-2size) + 1 (2stk-2size) + 3 (3stk-4size) + 1 (4stk-4size) + 5 +...

Når man fjerner elementer fra sit array vil det være for omkostningsfuldt at halvere ved halvt fuldt... 
istedet bør man først halvere når arrayetr er kvart fuldt.   

