# KursusIAlgoritmer.github.io

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

https://editor.p5js.org/ajrp/collections/nn03rywN0


Her er mit første forsøg på at lave "p5js kode" til union-find:

<iframe src="https://editor.p5js.org/ajrp/full/EliBGtfq7"></iframe>
