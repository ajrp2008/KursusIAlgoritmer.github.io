# Symbol tables

### Implementationer
- variabler
- DNS lookup ( overordnet set)

### Also known as
- maps
- dictoinaries
- associative arrays

### generalisering af arrays - index kan være andet end 0 til N-1

### Languages
Symbol tabeller forekommer enten : Eksternt, indbyggede-biblioteker eller indbygget i sproget...

### API

```
ST()
put
gentagcontains
delete
isEmpty
size
keys

//## CONVENTIONS
-  values not null
- method get returns null if keys not present
- method put ovewrites old value with new value

```
### Best practice - use immutable types...

### Equals skal opfylde "Ækvivalens relationen ???"
refleksiv
symetrisk
transitive
og desuden
non-null

------------------------------------------------------------------------------------------------------------------------------------

# Frequency counter implementation - example

------------------------------------------------------------------------------------------------------------------------------------

# Elementary implentations -

##IMPLEMENTATION 1 : (uordnet liste) Linked list implementation...

?? Listen er uordnet burde søg være 1 ????     
?? Hvorfor er søg hit avrg N/2 eller hva???

| implementation          | søg garanteret  | indsæt garanteret | søg hit gennemsnit  | indsæt '(?)' gennemsnit  |
|-------------------------|------ ----------|-------------------|---------------------|--------------------------|
| unordered linked - list | N               | N                 | N/2                 | N                        |

------------------------------------------------------------------------------------------------------------------------------------

##IMPLEMENTATION 2 : (ordnet liste) Binær søgnings i et sorteret array....

kræver to arrays keys[] or vals[] der sorteres på samme måde....


?? Burde indsættelse ikke tage længere....     
?? Også længere end før ....

| implementation          | søg garanteret  | indsæt garanteret | søg hit gennemsnit  | indsæt '(?)' gennemsnit  |
|-------------------------|------ ----------|-------------------|---------------------|--------------------------|
| unordered linked - list | logN            | N                 | log(N/2)            | N/2                      |

------------------------------------------------------------------------------------------------------------------------------------

## Ordnede operationer
```
min
max
floor
ceiling
select
deleteMin
deleteMax
...
```
