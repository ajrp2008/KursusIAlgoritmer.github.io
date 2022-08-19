# KursusIAlgoritmer.github.io

----
<iframe width="560" height="315" src="https://www.youtube.com/embed/xmbjs-rQf4k" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

----

# Chapter 1.5 - Union-find

## Findes ikke i noget standardbibliotek

- void connect(A,B)     : dette er en dynamisk operation
- boolean isConnected(A,B) : ækvivalensrelation - dvs. isConnected er "refelksiv","symetrisk" og "transitiv"

## Sammenhængskomponenter : Algoritme terminologi ( i matematik kalder man det ...)

- Hvis 1,2 og 3 hænger sammen
- Når man forener elementer fra to forskellige sammenhængskomponenter - forenes sammenhængskomponenterne

## Lav en "foren og find" datastruktur !!

```java

public interface UF{

  public UF(int n);
  
  public void union(int a, int b);
  
  public int find(int a);
  
  public boolean isConnected(int a, int b)

}

```

En default implementation af "isConnected":

```java

  public boolean isConnected(int a, int b){
    return find(a) == find(b);
  }

```
------------------------------------------------------------------------------------------------------------
## Hurtig-find implementation af union-find ...

- Array af heltal id[] med længde N
- fortolkning id[p] er ID'et for komponenten (sammenhængskomponenten) der  


Her er en collection af mit kode arbejde til algoritmer kuset....

[https://editor.p5js.org/ajrp/collections/nn03rywN0](https://editor.p5js.org/ajrp/collections/nn03rywN0)

Her er mit min "p5js kode" til quick-find :

```javascript
function union(a, b) {
  //første ide : Erstate alle indgange der er lig "ids[a]" med "ids[b]"
  
  //indsætter elementer hvis de ikke eksisterer --- nødvendigt fordi jeg starter med ukendt længde modsat bog
  ids[a] = ids[a] == undefined ? a : ids[a];
  ids[b] = ids[b] == undefined ? b : ids[b];

  //Dette retter fejlen fra version2 - vi husker ID'er inden gennemløb
  let idA = ids[a];
  let idB = ids[b];

  for (let i = 0; i < ids.length; i++) {
    if (ids[i] == idB) {
      ids[i] = idA; //alle andre idB ID'er sættes til idA
    }
  }
}
```
------------------------------------------------------------------------------------------------------------
# Kørselstid quick-find

| opret | foren | find | forbundne |
| ------| ----- | ---- | --------- |
| N     | N     | 1    | 1         |

Det vi tæller er antal gange vi tilgår hukommelsen - i vores tilfælde er dette hvornår vi læser eller skriver til vores array
