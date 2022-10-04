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

-------------------------------------------------------------------------------------------------------------

## Selection sort : Video 20 min


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

------------------------------------------------------------------------------------------------------------          
## Insertion sort : Video 24:44

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

>For partielle sorterede arrays kører insertion sort lineær tid ??!?
>Er en bygge sten i Javas inbyggede sorterings algoritme....

Forbedringer: Lav ombytningen når vi kender pladsen...     

Forbedring: Binær søgning efter rigit plads.... => medfører Ñ*lg(N) sammenligninger.     
Men stadig kvadratiske antal accesses....

-------------------------------------------------------------------------------------------------------------

## MERGE SORT - Video 43:07

Divide and conquer     
John Von Neumann ....

- opdel array i to dele
- sorter hver halvdel rekursivt
- sammenflet de to halvdele
(bliver faktisk ved indtil der kun er enkeltelementer...)

#### Sammenflet operationen er den sværeste
```
Trin 1
a-array : E E G M R A C E R T
          k
aux-array:E E G M R | A C E R T
          i           j
```
Da vi ved begge arrays er sorterede
Er det enten i eller j der er det mindste element i det samlede

```
Trin 2
a-array:   A E G M R A C E R T
             k
aux-array: E E G M R | A C E R T
           i             j

Trin 3
a-array:   A C G M R A C E R T
               k
aux-array: E E G M R | A C E R T
           i               j           

Trin 4
a-array:   A C E M R A C E R T
                 k
aux-array: E E G M R | A C E R T
             i             j           

Trin 5
a-array:   A C E E R A C E R T
                 k
aux-array: E E G M R | A C E R T
               i           j           

Trin 6
a-array:   A C E E E A C E R T
                     k
aux-array: E E G M R | A C E R T
               i             j           

```

Når den ene del-liste er tom, flyttes de resterende elementer ind i arrayet...

```java

//SORT

void sort(){
  Comparable[] aux = new Comparable[a.length];
  sort(a , aux , 0 , a.length - 1 );
}

//SORT AND DIVIDE______________________________________________________________________

void sort(Comparable[] a, Comparable[] aux, int lo, int hi){
  if(hi <= lo) return;

  int mid = lo + (hi -lo)/2;

  sort  (a, aux, lo   , mid);
  sort  (a, aux, mid+1, hi );

  merge (a, aux, lo   , mid , hi );
}

//MERGE ______________________________________________________________________
void merge( Comparable[] a, Comparable[] aux, int lo, int mid, int hi){

  //kopi
  for(int k = 0 ; k <= hi ; k++ )  aux[k] = a[k];

  //sammenfletningen  
  int i = lo ,  j = mid + 1;   
  for(int k = lo ; k <= hi ; k ++ ){

    if( i > mid )                 a[k] = aux[j++];
    else if( j > hi)              a[k] = aux[i++];
    else if( less(aux[j],aux[i])) a[k] = aux[j++];
    else                          a[k] = aux[i++];

  }


}

```
#### Antal sammenligninger merge-sort

Der bruges lige meget tid om vi sorterer et array der er omvendt sorteret - hvilket jo er et "slemt tilfælde" for insertion sort ...

>>Tidskompleksiteten:
>>N*lg(N)
>>
>>Bevis:
>>Rekursions- eller rekurrenc ligning:
>>
>>C(N) <= C(N/2)          + C(N/2)         + N
>>        venstre halvdel   højre galvdel    sammenflet
>> for N > 1, med C(1) = 0
>>
>>Forenkling af problemet:
>>D(N) = 2*D(N/2) + N

#### TID Video 57:50 ...
#### Antal access merge-sort

T <= 6*N*lg(N)

6N : 2N over i et aux-array og 4N for at få dem flettet rigtigt


```java
//En algoritme med følgende struktur tager N*lg(N) tid

void linearithmic(){
  if(N==0) return;             
  linearithmic(N/2);
  linearithmic(N/2);
  linear(N);                          
}

----------------------------

#### Buttom-up merge down

Arbejder ikke rekursivt men opdeller først arrayet i 1- og 1 mergeses
Derefter 2 og 2
Derefter 4 og 4
Osv.



----------------------------


```

## FORBEDRINGER TIL SORTERINGS IMPLEMENTAIONER

### Javas sorterings implentation

merge sort indtil 32 elementer ,- så anvendes binær insertion-sort

### HURTIGERE MERGE:

Hvis den venstre partitionerings højeste element er mindre en edn højres venstre behøves der faktisk ikke at flettes men bar at sammensætte de to arrays...


---------------------------------------------------------------------------


# COMPLEXITY OF SORTING
#### Video tid 1:06:25

> Computational complexity:
>> Framework to study effciency of algorithms for solving a particular problem X.

> Model of computation
>> Allowable operations

> Cost model
>> Operation count(s)

> Upper bound
>>

> Lower Bound
>>

> Optimal algorithm


---------------------------------------------------------------------------

Decision tree ...

sammenligninger i træets forgreninger repræsenterer sorteringer...

Tre elementer giver 6 blade ...

Træets højde er repræsenterer den værst mulige sammensætning ...

Enhver sammenlignings baseret sorterings algoritme skal nødvendigvis bruge lg(N!) ~ N*lg(N) i værste tilfælde...

Da merge sort koster N*lg(N) tid ... behøver vi ikke bruge mere tid på at lede efter en bedre algoritme...


---------------------------------------------------------------------------


# SORTERING AF SAMME DATA PÅ FORSKELLIGE MÅDER

Man kan bruge en "Comperator" i Java

# BEGREBET : Stabil sortering

Bibeholder relativ orden efter elementer der har samme nøgle !!

Insertion sort er stabil...        


Selection sort er ikke stabil...     
Den bytter kun en plads "i" ud med et minumum , men hvis "i" havde en relativ korrekt plads... ville det ødelægge ordenen

Mergesort er stabil...    
Merge : hvis to nøgler er ens - tages altid venstre - dette garanterer stabil sortering  
