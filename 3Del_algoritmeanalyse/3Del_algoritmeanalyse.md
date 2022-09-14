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


-------------------------

# Binary search
