# 4 Del - Sortering

Man skal kunne sortere efter en såkaldt "nøgle".

Sortering skal være vel-defineret

Total orden er en binær relation <= der tilfredstiller:
- Antisymetrisk : v <= w og w<= v så er v = W
- Transitiv : v <= w og w <= x så er v <= x
- Helhed : Enten gælder v<=w eller w<=v eller begge!

Alt kan ikke sorteres:
F.eks. sten / saks / papir er en cirkulær orden ...  bryder det transitive-kravet  
Eller kursus-hieraki på ... bryder med helheds-kravet

Java : 
Interface:  Comparable<Item> interface
Metoden : int compareTo(Item a) 
v.compareTo(w).    v>w  giver 1 , v<w giver -1 , v==w giver 0
                                      

                                      
### Selection sort
 
### Video 20 min

                                      
```java
//Selection sort demo:
                                      
//- I iteration i, find index (min) af mindste element i "ikke sorterede del af arrayet"
//- ombyt a[i] og a[min]                                                                          
                                      
for( i=0 ; i < N ; i++){
    int min = i;
  for( j= i+1 ; j<N ; j++){
    if( less(a[j],a[min]) ) min = j;                
  }
  exch( a , i , min );                    
}                                                                            
```                                      

Køretiden for selection sort er pga. de to for-loops:     

Hvis vi tæller antal sammenligninger har vi
(N-1) + (N-2) + .... + 2 + 1 + 0 = N^2/2    

Antal ombytninger er det færrest mulige !!!!!!!!                    

                    
                                      
                                      
                                      
                                      
