# Del 3 - Algoritme analyse

## 3-sum problemet 

hvor mange forskellige kombinationer af 3 heltal i en serie kan give nul ...
I denne situation antager vi at at : De tre tal skal være forskellige

## Løsning: Brute force algoritme ....
Vi prøver alle muligheder af

>Vi laver tre nestede loops.    
>>Hvor hvert loop starter på en plads efter den forrige .... 

```java
A: for(int i =0; i<N ; i++)
B:   for(int j=i+1; j<N ; j++)
C:     for(int k=j+1; k<N; k++)

A:      n
A+B:   (n-1)       + (n-2)       + ... + 2   + 1
A+B+C: (n-1)*(n-2) + (n-2)*(n-3) + ... + 2*1 + 1*0
```
