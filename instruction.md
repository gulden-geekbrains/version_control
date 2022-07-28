# Инструкция по языку MarkDown

Новая строка - это олна пустая строка

**Полужирный текст**

*Курсив текст*

## Цитирование
> Первый уровень
>> Второй уровень

## Списки
### Ненумерованные списки
* Лист 1
* Лист 2
### Нумерованные списки
1. Лист 1
2. Лист 2
3. Лист 3

## WEB ссылки
Текст [пример ссылки](http.example.com "Всплывающая подсказка")

## Работа с таблицами

Letter | Digit | Character
------ | ------|----------
a      | 4     | $
x      | 365    | (
b      |       | ^  

Letter|Digit|Character
---|---|---
a|4|$
 |365|(
b| |^  

Column | Column
------ | ------
\| Cell \|| \| Cell \|  


Column | Column | Column
:----- | :----: | -----:
Left   | Center | Right
align  | align  | align

## Картинки

### Это море

![sea](sea.png "море")


## Цветной текст
<!--- с добавлением HTML--->	

<span style="color:blue"> Это синий цвет</span>

<span style="color:green"> Это зеленый цвет</span>

<span style="color:red"> Это красный цвет</span>

<!--- на github текст не окрасился--->


## Видео
<figure class="video_container">
  <video controls="true" allowfullscreen="true" poster="path/to/poster_image.png">
    <source src="path/to/video.mp4" type="video/mp4">
    <source src="path/to/video.ogg" type="video/ogg">
    <source src="path/to/video.webm" type="video/webm">
  </video>
</figure>
