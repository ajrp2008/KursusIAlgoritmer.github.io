# Separat chaining

Hvordan repræsenterer vi den her spand med flere elementer?

- Bruger et array af M > N linked lists ....

Analyse af "separat chaining":

>Påstand: Antallet af nøgler i en list er ca. N/M
>
>Bevis : distribution er normalfordelt...
> Dvs. hver indsættelse er proportionel til N/M  

 Der er selvfølgelig et tradeoff imellem N og M ,,, tomme tabeller eller for lange kæder

 Tommelregel : M ~ N/2

  Dynmaisk ændring af tabel:   
  - Fordobling M når N/M >= 8
  - Halver M  N/M <2
  - løber alle gamle elementer igennem og indsætter i ny tabel...

  | implementation          | søg garanteret  | indsæt /slet garanteret | søg hit gennemsnit  | indsæt/slet '(?)' gennemsnit  |
  |-------------------------|------ ----------|-------------------|---------------------|--------------------------|
  | separat chaining        | N               | N                 | 3 til 5            | 3 til 5                      |


  
*3 til 5 stammer fra vores resize Tommelregel*
