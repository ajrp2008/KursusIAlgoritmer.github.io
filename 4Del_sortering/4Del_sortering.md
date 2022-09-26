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
                                      
Selection sort demo: 
- I iteration i, find index (min) af mindste element i "ikke sorterede del af arrayet"
- ombyt a[i] og a[min]
                                      
