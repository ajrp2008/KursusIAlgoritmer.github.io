#

### Ligesom en kø .
Men man tager altid det
største/mindste element der tages ud....


----------------
### API

maxPQ lav en
insert(Key v)
delMax()
isEmpty()

-----------------

Meget anvendelig byggesten ...

--------------

### Eksempel find de M største transaktioner

En begrænsning:
Der er mere data end det hukommelsen indeholder

Snedig løsning:
Der altid fjerner det mindste element

Hvordan kan det implementeres:
Sortere ...     koster N*log(N)  plads N
Elementary PQ   M*N              M
binary heap     N*log(M)         M

N er meget stort - altså koster det super langt tid....

### Løsning:
1. Usorteret array hvor vi leder efter elementer
fjerner det største og bytter det sidste med det største....
2. Sorteret med insertion sort ...

| implementer | indsæt | del max | max |
| ------------| ------ | ------- | --- |
| uordnet     |1       | N       | N   |
| ordnet      |N       | 1       | 1   |
| MÅL!        |logN    | logN    | logN|

### BYGGER PRIORITETSKØ SOM KOMPLET/FULDSTÆNDIGT BINÆRT TRÆ!

Knude med to træer nedenunder eller ingenting ...

>Påstand : Højden af et komplet binært træ er lg(N)
>Bevis : Højden stiger kun hvis N er en  2-tals potens ...

#### Binary Heap - på dansk Binær hob

Hob ordnet binært træ
- nøgler er knuder
- forældre nøgle er ikke mindre end børns nøgler!

```
          T
      S       R
  P      N   O  A
E  I    H G

ARRAY repræsentation
T S R P N O A E I H G

Man kan regne sig frem til hvem der er forældre ved at sige
index_forældre = index / 2
index_barn1    = index*2
index_barn2    = index
```

-------------------------------

### INDSÆTTELSE I DET BINÆRE TRÆ ...

#### Insert - "svøm" op

- Indsætter som sidste
- sammenligner med forældre - hvis det er størst byttes

#### Fjern max - ombyt med sidste knude og "synk" det ned

- byt om med det barn der er største
- gentag hvis orden ikke er overholdt

```java
//index 0 er tomt ... det gør beregningerne nemmere

public Key delMax(){
  Key max = pq[1];
  exch(1,N--);
  sink(1);
  pq[N+1] = null; //prevent loitering
  return max;
}


public void insert(Key x){
  pq[++N] = x;
  swim(N);
}

private void swim(int k){
  while(k>1 && less(k/2,k)){
    exch(k,k/2);
    k=k/2;
  }

}

private void sink(int k){
  while(2*k <= N){
    int j = 2*k;
    if( j<N && less(j, j+1))  j++;
    if(!less(k,j)) break;
    exch(k,j);
    k = j;
  }
}

```

## Priority queues implementation cost summery

| implementer | indsæt | del max | max |
| ------------| ------ | ------- | --- |
| uordnet     |1       | N       | N   |
| ordnet      |N       | 1       | 1   |
| binary heap |logN    | logN    | 1   |
| d-ary heap  ||||
| Fibonacci   ||||
| Brodal queue||||
| Impossible  |1       | 1       | 1   |

# Sortering med binary-heap

- 
