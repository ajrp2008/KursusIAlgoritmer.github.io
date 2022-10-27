# Video time 44

Ide -> tager nøgle og oversætter til heltal

- Beregning. Gøre det på en konsitsten måde. Samme nøgle skal give samme hash-værdi.
- Skal kunne tjekke om to nøgler er ens...
- Collision - man skal håndtere kollisioner...

-------------------------------------------------------

Klassisk space-time tradeoff :
- ingen pladsbegrænsning = key som index....
- ingen tidsbegrænsning  = collision resolution with squential search
- ELLERS hash

--------------------------------------------------------

key -> Beregning -> table index

- fordele nøgler så meget som det er muligt ...


*Eksempel:  telefonnumrer ... vælg IKKE DE FØRST CIFFRE*

----------------------------------------------------------

*JAVA hash code conventions*

retunerer 32-bit int.

- Krav : x.equals(y) resulterer i "x.hashCode() == y.hashCode()"
- Ønskværdigt : ...omvendte

Lovlig (men hjernedød) implementation : altid returner 17

Integer hash : af integer objekte er selve tallet   

Boolean hash : 1231 eller 1237

Double hash  : bits^(bits>>>32) .. note +0 og -0 har forskellig hash code :-/ ??

Strings hash : Horners metode : h = s[0]*31^(L-1) + ... + s[L-1]*31^0 ... note default 0 og beregnes kun hvis den ikke er 0

----------------------------------------------------------------

*Standard opskrift - hash codes*

- brug 31*x + y for hver betydende felt
- primitive type brug wrapper hash - field null return 0
- reference type anvend hashCode()
- hvis array - anvend på alle elementer

-------------------------------------------------------------------

*Modular hashcode*

- Hash code : imellem -2^31 og 2^31-1
- Hash funktion : mellem 0 og M-1 ...

Math.abs("polygenlubricants".hashCode()) % M  giver negativt     
Det gør    
"polygenlubricants".hashCode()    
også    

Korrekt implentation - fjerner mest betydende bit ( så er det ikke negativt):
(key.hashCode() & 0x7fffffff) % M

-------------------------------------------------------------------

*Uniform hashing - alle hashværdier fra 0 til M-1 er lige sandsynlige*

- Birthday problem : Expect to bolde i samme : efter ~sqrt(PI*M/2)
- Coupon collector : alle har mere end en bold efter ~M ln(M)
- Load balancing : Efter M kast , mest fyldte har THETA(logM/loglogM)
