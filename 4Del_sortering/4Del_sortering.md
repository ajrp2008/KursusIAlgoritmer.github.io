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
                                      

                                      
### Selection sort : Video 20 min

                                      
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

> ****Køretiden for selection sort er uafhængig af inputet****   
>
>SAMMENLIGNINGER:  
> Hvis vi tæller antal sammenligninger har vi
>(N-1) + (N-2) + .... + 2 + 1 + 0 = 1/2*N^2  : Dvs. kvadratisk tid 
> 

***siger asymptotisk 1/2*N^2 ... men det er vel ikke asymptotisk, men faktisk eksakt???***
>
>OMBYTNINGER:
>Antal ombytninger er det færrest mulige !!!!!!!! : Dvs lineær tid                   
>

***siger det er færrest mulige men den bytter vel altid N gange??***
                    
### Insertion sort : Video 24:44
  
```java
//Insertions sort...

//- I iteration i ombyt a[i] med hver størrer element til venstre...

for( int i = 0 ; i < N ; i++ )
  for(int j = i ; j > 0 ; j--)
    if( less(a[j] , a[j-1]) exch( a , j , j-1 );
    else break;  
```  
> ****Kørselstiden for insertion sort er afhængig af inputtet****
>- WORST CASE INPUT : Omvendt sorteret input
>- BEST CASE INPUT : Rigtigt sorteret input
>
> SAMMENLIGNINGER Gennemsnit ~1/4*N^2.  
>  
> OMBYTNINGER Gennemsnit ~1/4*N^2
>
>Forklaring : hver gang man sorterer et element forventes det at det bevæger sig halvvejs ned,
>dvs. halvt så mange som selection sort...
  
****Invertion of pairs???? tid i video 36 min. Det forstår jeg ikke!****
  

  
  
  
                                      
                                      
                                      
