# MarkDown instruction

## Selectarea textului

*Text italic* sau _text italic_

**Text semigras** sau __text semigras__


*Intr-un text scris italic pot fi introduse elemente cu scris __semigras__*

## Apostrof si ghelemele

&#8220;ghelemele duble&#8221;

&#8216;ghelemele singulare&#8217;

apostrof&#8217;

## Paragraf si intreruperea rindului

Pentru a face un paragraf trebuie de lasat un rind gol

Primul paragraf

Al doilea paragrag
Continuare paragraful doi

Transferul rindului in cadrul unui paragraf se efectuiaza aplicind 3 metode, la sfirsitul de rind punem:
1. 2 si mai multe spatii;
2. slash invers \
3. aplichind HTML-teg <br> 
## Liste
Liste nenumerotate pot fi formate cu ajutorul markerelor: *, -, +. Spre exemplu:

Liste nenumerotate (unordered):
* list_1
* list_2
* list_3
+ list_4
+ list_5

- list 01
- list 02
- list 03

+ list I
+ list II
+ list III

Atentie, cind folosim unul si acelas marcher pentru mai multe liste lasam doua rinduri

Liste numerotate (ordered)

Varianta I

1. element
2. element
3. element

Varianta II [ (1) numerotoarea lenoasa, chiar daca scrim 1 peste tot MarkDown stie nomarul din lista, (2) incepem lista cu numarul de care avem nevoie]

99. element
1. element
1. element

Atentie, intre doua liste numerotate, care merg consecutiv una dupa alta, trebuie de lasat doua rinduri goale
Liste de control

> Chelist
>* list01
>* list02
>* list03

Liste complexe (nested)
1. Punct
   1. Subpunct
   2. Subpunct
        1. subsubpunct

* Punct
  - Subpunct
    + Subsubpunct

Pentru indentarea aplicam urmatoarea formula: in caz cind marcherul contine un simbol se pun de 2-5 spatii, cind contine 2 simboluri se pun 3-6 spatii, 3 simboluri - 4-7 spatii

Alte elemente in structura listei

In lista se poate de adaugat citat, paragraf etc., se face indentarea, ca si pentru lista complexa

1. Punctul unu
   > un citat in punctul unu
2. Punctul 2

    Paragraf in punctul doi
3. Punctul 3

## Imagini

![Salut aceasta este Levy!](IMG_20170426_181053.jpg) 

![Faceti cunostinta cu Alba](Alba.jpg)

![Cu Alba la plimbare](la_plimbare.jpg)


## lincuri
Cea mai simpla metoda de a crea un link, este de a-l scrie in paranteze treunghiulare "<>":

<http:gb.ru/lessons/393657>

O alta metoda prevede utilizarea sintaxei: [text](link)

[seminarul_II_Git_vscode_geekbrains](http:gb.ru/lessons/393657)

 ## Tabeluri
 Pentru a face un tabel, facem separarea colonitelor cu liniile verticale "|",  rindul cu descrierea este separat de celelalte prin liniuta "-", care sunt scrise atitea de cit este nevoie.

| Colonita 1 | Colonita 2 | Colonita 3 |

| ---------- |----------- |------------|

| Denumirea 1| Denumire 2 | Denumirea 3 |

|------------|------------|-------------|

|Celula 1    | Celula 2   | celula 3    |


## Citat 
> un text care trebuie citat: paranteza treunghulara se pine la inceputul fiecarui rind numerotat - am descris un citat primar;
cu duble paranteze, triple etc. este citat secundar, cum este prezentat ulterior
>> citat secundar
>>>la fel citat secundar
>>>> si asa mai departe

## Concluzii