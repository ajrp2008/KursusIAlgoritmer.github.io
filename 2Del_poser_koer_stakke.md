# Del 2 : Poser, køer og stakke

 disse data strukturer har grundlæggende samme formål nemlig at opbevare objekter.  
 den eneste forskel er hvordan man:
 - indsætter
 - fjerner
 - eller itererer hen over strukturen

-------------------------------------

# Stakken - også kaldet stack ...

Vi beskriver den vha. en API:

- push
- pop
- isEmpty

### linked list implementation
|              |                                        |
| -------------|----------------------------------------|
| Propersition | Alle operationer vil tage konstant tid |

Proposition: En stak med N elementer koster ca. 40 N bytes 
16 bytes overhead (moderne java 12 bytes), 8 bytes inner class, ... 

### array implementation

[https://www.codiva.io/p/87739aea-4f21-4f61-8d1b-3e91e07cc6ff](https://www.codiva.io/p/87739aea-4f21-4f61-8d1b-3e91e07cc6ff
)

Det er vigtigt at udtænke en metode for hvordan man forstørrer sit array
der ikke koster for meget!

>Ved at fordoble længden på vores array, hver gang der er overløb - koster det mindst muligt tid
>Omkostninger ved at indsætte 10-elementer i et størrelse 2 array:
>> 1 (1stk-2size) + 1 (2stk-2size) + 3 (3stk-4size) + 1 (4stk-4size) + 5 +...

Når man fjerner elementer fra sit array vil det være for omkostningsfuldt at halvere ved halvt fuldt... 
istedet bør man først halvere når arrayetr er kvart fuldt.   

|      | best  |worst |amortized |
| ---- | ----- |------|----------|
|constr| 1.    |1     |1         |
|push  | 1.    |N     |1         |
|pop   | 1.    |N     |1         |
|size  | 1.    |1     |1         |


Vi har denne invariant, at arrayet er et sted imellem 1/4 og helt fyldt (noget der forbliver konstant hele tiden):

|              |                                        |
| -------------|----------------------------------------|
| Propersition | Bruger imellem (8N og 32 N bytes) </br> 8N når den er fuld </br> 32N når den er kvart fuld  |


## array implementation vs. linked list implementation
linked list giver os en garanteret konstant tid.     
array implementationen kan koste længere tid engang imellem hvis arrayet skal forøges, men ikke så ofte! (amortisered konstant).      
Linked list koster en del plads pga. links imellem objekterne.      
Array implentationen koster ikke så meget plads.    

-------------------------------------------------------------------------

# Køen : også kaldet Queue

- dequeue
- enqueue
- isEmpty

## Linked list imlementation
https://www.codiva.io/p/a8c4dc28-1613-4bd3-a111-99a0b7190a92

Vi skal holde øje med på starten og enden på køen ... 

>Troels laver et trick i implentationen - hvor der er en dummy-knude som både last og first peger på
>

## array implementation


