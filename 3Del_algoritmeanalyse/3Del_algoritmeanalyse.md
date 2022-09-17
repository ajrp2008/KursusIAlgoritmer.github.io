# Del 3 - Algoritme analyse

## 3-sum problemet

hvor mange forskellige kombinationer af 3 heltal i en serie kan give nul ...
I denne situation antager vi at at : De tre tal skal være forskellige

## Løsning: Brute force algoritme ....
Vi prøver alle muligheder af

>Vi laver tre nestede loops.    
>>Hvor hvert loop starter på en plads efter den forrige ....

```java
//BRUTE FORCE
A: for(int i =0 ; i<N ; i++)
B:   for(int j=i+1 ; j<N ; j++)
C:     for(int k=j+1 ; k<N ; k++)

A:      n
A+B:   (n-1)       + (n-2)       + ... + 2   + 1
A+B+C: (n-1)*(n-2) + (n-2)*(n-3) + ... + 2*1 + 1*0

//HVIS MAN LAVER EKSPERIMENTER
Det ender ca i k*n^3
```
# EKSPERIMENT - KAN INDSKRIVES I DOBBELTLOGARITMISK ARK


# Doubling hypothesis - find b
> Hurtig måde at finde b i når T(N) = a*N^b

```
T(2*N)/T(N) = a(2N)^b/aN^b = 2^b
```
# find a
```
et eksperiment for N = 8000
51 sek = a * 8000^3 <=> a = 0.988*10^-10
```
# TIDSEKSPERIMENTER

System uafhængigt : Algoritmen + inputtet  

System afhængigt : Hardware,  Software compiler osv,  System OS

## 20:23 Hvad tager længst tid af operationer ... ganske interessant ...

# SIMPLIFIKATION 1 (eksempel sum-2)
```java
//BRUTE FORCE
A: for(int i =0 ; i<N ; i++)
B:   for(int j=i+1 ; j<N ; j++)

0 + 1 + ... + (n-1) = binominal(N 2) kan også ses med kvadrattegning

```

# SIMPLIFIKATION 2 (tilde notation)

f(x) ~ g(x) så er f(x)/g(x) -> 1 for x -> infinit

-------------------------
## 44 minutter
# Binary search

Til at beregne "mid" anvendes dette pga. overlow???

>> min = lo + (hi -lo)/2

istedet for

>> min = (hi + lo)/2

ivariant vi holder styr på

>> hvis key eksisterer så er a[lo] <= key <= a[hi]

---
Hastighed :    
1 + lgN sammenligninger

Bevis:    
T(N) <= T(N/2) + 1 for N > 1, og T(1) = 1

assume N er power of 2 dvs. 2^x = N hvor
antag N er en potens af 2 ...

Nr. 1. gang:    T(N) <= T(N/2) + 1
Nr. 2. gang:    T(N) <= T(N/4) + 1 + 1
 ...
(da vi halverer hver gang kan vi gøre dette lg(N) gange)
Nr. lg(N) gang: T(N) <= T(N/N) + lg(N)

Dette er det samme som T(N) <= 1 + lg(N)

----------

# FORBEDRING AF 3-SUM med en N^2*logN algoritme

- sorteret array
- loop over i
- loop fra i over j
- for hvert i og j element binær-søg efter element  -(i + j) men... kun i den del der er efter j

Koster:    
- for dannelse af hvert par i-j koster N^2
- binær søgning koster hver gang log(N)
ialt N^2*log(N)

Gammel implementation koster : 51.1 sek for 8000  
Ny implementation koster : 1 sek for 8000

# ANALYSE TYPER

- Best case:    
- Worst case:    
- Average case:   

Bruteforce 3-sum:

- Best case:    ~ 1/2 N^3
- Worst case:   ~ 1/2 N^3       
- Average case: ~ 1/2 N^3

Binær søgning :   

- Best case:    ~ 1
- Worst case:   ~ lg(N)       
- Average case: ~ lg(N)    ( ved ikke hvordan dette findes.)

# ASYMPTOTISK ANALYSE

- Big Theta : Fanger udførselstid - svarer til tilde


- Big O     : Øvre grænse

T(n) gælder O(f(n)) hvis  T(n) <= c*f(n)  for n>= n0   
man kan tale om "thight bound" eller "loose bound"  

- Big Omega : Nedre grænse

### 1-sum

Upper bound : O(n)
Lower bound : proof: hver indgang kan indeholde et 0 ... derfor er en optimal algoritme OMEGA(n)


### 3-sum

Upper bound : Vi kan sige O(N^2*lg(n))


# ALGORITME DESIGN MODEL

STart:   
- udvikling af ny algoritme
- bevis nedre grænse ??

Gap:   
- find en ny
- bevis højere nedre grænse ...

Golden age: 1970's

Forbehold:
- overpessimistisk worst case ...
- behov for bedre end indenfor konstant at bestemme perf.
