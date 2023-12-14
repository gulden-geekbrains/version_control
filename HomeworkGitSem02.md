
# Инструкция по работе с Git

Источник инструкции расположен [на habr.com](https://habr.com/ru/companies/ruvds/articles/599929/ "30 команд Git, необходимых для освоения интерфейса командной строки Git") ![ТЫ без инета)))](https://habrastorage.org/r/w1560/webt/uw/-g/bd/uw-gbd0lej3jcbrwjzclezzpxbu.png)

## Что такое Git?

**Git** стал мировым стандартом для управления версиями. Так что именно это?

**Git** — это распределенная система управления версиями, которая означает, что локальный клон проекта — это полный репозиторий управления версиями. Полнофункциональные локальные репозитории упрощают работу как в автономном, так и в удаленном режиме. Разработчики фиксируют свою работу локально, а затем синхронизируют копию репозитория с копией на сервере.

Гибкость и популярность Git делают его отличным выбором для любой команды. Многие разработчики и выпускники колледжа уже знают, как использовать Git. Сообщество пользователей Git создало ресурсы для обучения разработчиков и популярности Git, что упрощает получение помощи при необходимости. Почти каждая среда разработки поддерживает Git и средства командной строки Git, реализованные в каждой основной операционной системе.

* Источник [на Microsoft Learn](https://learn.microsoft.com/ru-ru/devops/develop/git/what-is-git "Что такое Git?")

## Указание пути к файлам репозитория

```sh
cd /<Путь к файлу>
```

## Создание репозитория

Создать пустой *репозиторий** Git или вновь инициализировать существующий можно параметром **init**. При инициализации он создаст скрытую папку. В ней содержатся все объекты и ссылки, которые Git использует и создаёт в истории работы над проектом.

```sh
git init
```

* Репозиторий - место, где хранятся и поддерживаются какие-либо данные. Чаще всего данные в репозитории хранятся в виде файлов, доступных для дальнейшего распространения по сети.

## Добавление отдельных файлов или всех файлов в область подготовленных файлов

Добавить отдельный файл в область подготовленных файлов можно параметром **add** с указанием имени файла. Просто замените '<имя_файла>' на актуальное имя.

```sh
git add <имя_файла>
```

Кроме того, можно добавить все файлы и папки в эту область, поставив " . " вместо имени файла:

```sh
git add .
```

## Внесение изменений однострочным сообщением или через редактор

При создании коммита в репозитории можно добавить однострочное сообщение с помощью параметра **commit** с флагом **-m**. Само сообщение вводится непосредственно после флага, в кавычках.

```sh
git commit -m "Message"
```

Также можно открыть текстовый редактор в терминале для написания полного сообщения коммита. Оно может состоять из нескольких строк текста, в котором подробно характеризуются изменения, внесённые в репозиторий.

```sh
git commit
```

## Просмотр истории коммитов с изменениями

Просматривать изменения, внесённые в репозиторий, можно с помощью параметра **log**. Он отображает список последних коммитов в порядке выполнения. Кроме того, добавив флаг **-p**, вы можете подробно изучить изменения, внесённые в каждый файл.

```sh
git log -p
```

Флаг **--oneline** в связке с **git log** позволяет отображать компактный список последних коммитов в порядке выполнения. \

```sh
git log --oneline
```

## Переключение между коммитами

Команда git checkout позволяет переключаться между последними коммитами (если упрощенно) веток: git checkout <имя ветки из log>. Создаёт ветку, в которую и произойдет переключение: git checkout -b some-other-new-branch. Если в текущей ветке были какие-то изменения по сравнению с последним коммитом в ветке (HEAD), то команда откажется производить переключение, дабы не потерять произведенную работу.

```sh
git checkout <имя ветки из log>
```

Для возврата к актуальной версии документа следует указать параметр **master**

```sh
git checkout master
```

### Добавляем изображение к файлу репозитория

```sh
![текст вывода](ссылка на картинку)
```

![Ты без инета)](https://yandex-images.clstorage.net/9hDrL6436/ba893fuWmfe/miqHu4iDRDAGylB47Szw9SvSxhbjNFwBdqYQojPAZ7bD2CbhKDhgS2tCzS7pwkL5ZfV_rfrIdRygJ2NOaB3nTVo51KtYRJMl1E_CK-zusfL5FZQW8vNIg7Ng0Hd21_I0g1l_e7Rl6VL2joZntd3SrzA16ys8DeXG-fZ1nraAohgea0c_iZEJ-ECfXHzlaPzys9dKWfa4igG6MF6_84G9LVPMO742YOSTNs5PKnaTlWT-vaEgrohkwjAluxg3BOMdlyXLe8GaC7LJnNf-o2i0-PMfTJA0_AAIObWVuLBCvecdRzv3cmXr0fAOxqu2VRas_v7joCGM6Uh1IrcR-Usj31OtQrKJk4_8zxVetqioujL-X8wWM3-IR_H_0z20gf1iWkYxvXzrIFB5A8kle10S436272hqCySENae2Vz_P5pdeJMW_yRCH8gfVnPqn7z8_cpcCWfa2ScK2vxNyOYe7INXIM344buvet8HOLjualWHzdCCrZEjhDHSo_h75yC2RE6oN-gEbBbgAFZOz4OH8Pr5fQ146-oLJ8bhRfz4LeieeBvzxNefil7CBia36H1RkOvWjaGQMo8s9JH2fNI-vHpzugvwOHscyiR9V-eehuDG8koJTtbbLirs1kL75y7Hi30d08bFoLNX1CMSuvFvYaze14C_kSmMAc60xF_4ApteRLML7BdNEtM9SW7Hsrzu2ulBLmbS3CU52ctUxd0h47VWJOv6-pKMetssE7zrb3aYxtyPoLcujzb9ltd_4QKcdX6LCcobUTvhDklKxYqg6sXHdRxX5v0tIPPIWcr5KvyjagDz8uiCvn7YISWD-m56r9bdooGnI6AczJ7uS9QThm5FuyvMB2cq1xJ3aNicke7VykQZZdvAHx7341fn7i_tmlA17v_ToYlf2gkDmP9wYZLI2aCajRGXB9WLy2rlFbxKcLkS7CZGJdMFSEjHu7rg6cl0Mnv61jkj0sxWwuo)

## Создание новой ветки и переход в неё

Создать новую ветку можно с помощью параметра branch, указав имя ветки.

```sh
git branch new_branch_name
```

Но Git не переключится на неё автоматически. Для автоматического перехода нужно добавить флаг -b и параметр checkout.

```sh
git checkout -b new_branch_name
```

## Просмотр списка веток

Создать новую ветку можно с помощью параметра branch, указав имя ветки.

```sh
git branch new_branch_name
```

Но Git не переключится на неё автоматически. Для автоматического перехода нужно добавить флаг -b и параметр checkout.

```sh
git checkout -b new_branch_name
```

## Удаление ветки

Удалить ветку можно параметром ***branch*** с добавлением флага **-d** и указанием имени ветки. Если вы завершили работу над веткой и объединили её с основной, можно её удалить без потери истории. Однако, если выполнить команду удаления до слияния — в результате появится сообщение об ошибке. Этот защитный механизм предотвращает потерю доступа к файлам.

```sh
git branch -d existing_branch_name
```

Для принудительного удаления ветки используется флаг **-D** с заглавной буквой. В этом случае ветка будет удалена независимо от текущего статуса, без предупреждений.

```sh
git branch -D existing_branch_name
```

Вышеуказанные команды удаляют только локальную копию ветки. В удалённом репозитории она может сохраниться. Если хотите стереть удалённую ветку, выполните следующую команду:

```sh
git push origin --delete existing_branch_name
```

## Слияние двух веток

Объединить две ветки можно параметром merge с указанием имени ветки. Команда объединит указанную ветку с основной.

```sh
git merge existing_branch_name
```

Если надо выполнить коммит слияния, выполните команду git merge с флагом ***--no-ff***.

```sh
git merge --no-ff existing_branch_name
```

Указанная команда объединит заданную ветку с основной и произведёт коммит слияния. Это необходимо для фиксации всех слияний в вашем репозитории.

## Отображение журнала фиксации в виде графика для текущей или всех веток

Просмотреть историю коммитов в виде графика для текущей ветки можно с помощью параметра log и флагов **--graph** **--oneline** **--decorate**. Опция **--graph** выведет график в формате ASCII, отражающий структуру ветвления истории коммитов. В связке с флагами **--oneline** и **--decorate**, этот флаг упрощает понимание того, к какой ветке относится каждый коммит.

```sh
git log --graph --oneline --decorate
```

Для просмотра истории коммитов по всем веткам используется флаг --all.

```sh
git log --all --graph --oneline --decorate
```

## Прекращение слияния при конфликте

Прервать слияние в случае конфликта можно параметром merge с флагом --abort. Он позволяет остановить процесс слияния и вернуть состояние, с которого этот процесс был начат.

```sh
git merge --abort
```

Также при конфликте слияния можно использовать параметр reset, чтобы восстановить конфликтующие файлы до стабильного состояния.

```sh
git reset
```
| (: Вставлю картинки в таблицу | для | тренировки и заключения раздела :)| 
|:-----|----|-----:|
|![просто картиночка в конце](https://yandex-images.clstorage.net/9hDrL6436/ba893fuWmfe/miqHu4iDRDAGylB47Szw9SvSxhbjNFwBdqYFYCeBpXXDGDD0PLk3yT0CTW4rgtXvJ6K_bLvcNoggJiHba4gnzo6u1KtYRtOlV4-DK-zusfL5FZQW8vNIg7Ng0Hd21_I0g1l_e7Rl6VL2joZntd3SrzA16ys8DeXG-fZ1nraAohgea0c_iZEJ-ECfXHzlaPzys9dKWfa4igG6MF6_84G9LVPMO742YOSTNs5PKnaTlWT-vaEgrohkwjAluxg3BOMdlyXLe8GaC7LJnNf-o2i0-PMfTJA0_AAIObWVuLBCvecdRzv3cmXr0fAOxqu2VRas_v7joCGM6Uh1IrcR-Usj31OtQrKJk4_8zxVetqioujL-X8wWM3-IR_H_0z20gf1iWkYxvXzrIFB5A8kle10S436272hqCySENae2Vz_P5pdeJMW_yRCH8gfVnPqn7z8_cpcCWfa2ScK2vxNyOYe7INXIM344buvet8HOLjualWHzdCCrZEjhDHSo_h75yC2RE6oN-gEbBbgAFZOz4OH8Pr5fQ146-oLJ8bhRfz4LeieeBvzxNefil7CBia36H1RkOvWjaGQMo8s9JH2fNI-vHpzugvwOHscyiR9V-eehuDG8koJTtbbLirs1kL75y7Hi30d08bFoLNX1CMSuvFvYaze14C_kSmMAc60xF_4ApteRLML7BdNEtM9SW7Hsrzu2ulBLmbS3CU52ctUxd0h47VWJOv6-pKMetssE7zrb3aYxtyPoLcujzb9ltd_4QKcdX6LCcobUTvhDklKxYqg6sXHdRxX5v0tIPPIWcr5KvyjagDz8uiCvn7YISWD-m56r9bdooGnI6AczJ7uS9QThm5FuyvMB2cq1xJ3aNicke7VykQZZdvAHx7341fn7i_tmlA17v_ToYlf2gkDmP9wYZLI2aCajRGXB9WLy2rlFbxKcLkS7CZGJdMFSEjHu7rg6cl0Mnv61jkj0sxWwuo)||![просто картиночка в конце](https://yandex-images.clstorage.net/9hDrL6436/ba893fuWmfe/miqHu4iDRDAGylB47Szw9SvSxhbjNFwBdqYQojPAZ7bD2CbhKDhgS2tCzS7pwkL5ZfV_rfrIdRygJ2NOaB3nTVo51KtYRJMl1E_CK-zusfL5FZQW8vNIg7Ng0Hd21_I0g1l_e7Rl6VL2joZntd3SrzA16ys8DeXG-fZ1nraAohgea0c_iZEJ-ECfXHzlaPzys9dKWfa4igG6MF6_84G9LVPMO742YOSTNs5PKnaTlWT-vaEgrohkwjAluxg3BOMdlyXLe8GaC7LJnNf-o2i0-PMfTJA0_AAIObWVuLBCvecdRzv3cmXr0fAOxqu2VRas_v7joCGM6Uh1IrcR-Usj31OtQrKJk4_8zxVetqioujL-X8wWM3-IR_H_0z20gf1iWkYxvXzrIFB5A8kle10S436272hqCySENae2Vz_P5pdeJMW_yRCH8gfVnPqn7z8_cpcCWfa2ScK2vxNyOYe7INXIM344buvet8HOLjualWHzdCCrZEjhDHSo_h75yC2RE6oN-gEbBbgAFZOz4OH8Pr5fQ146-oLJ8bhRfz4LeieeBvzxNefil7CBia36H1RkOvWjaGQMo8s9JH2fNI-vHpzugvwOHscyiR9V-eehuDG8koJTtbbLirs1kL75y7Hi30d08bFoLNX1CMSuvFvYaze14C_kSmMAc60xF_4ApteRLML7BdNEtM9SW7Hsrzu2ulBLmbS3CU52ctUxd0h47VWJOv6-pKMetssE7zrb3aYxtyPoLcujzb9ltd_4QKcdX6LCcobUTvhDklKxYqg6sXHdRxX5v0tIPPIWcr5KvyjagDz8uiCvn7YISWD-m56r9bdooGnI6AczJ7uS9QThm5FuyvMB2cq1xJ3aNicke7VykQZZdvAHx7341fn7i_tmlA17v_ToYlf2gkDmP9wYZLI2aCajRGXB9WLy2rlFbxKcLkS7CZGJdMFSEjHu7rg6cl0Mnv61jkj0sxWwuo)|

## Про удаленный репозиторий.

### Добавление удалённого репозитория

Добавить удалённый репозиторий можно параметром remote add, указав shortname и url требуемого репозитория.

```sh
git remote add awesomeapp https://github.com/someurl..
```

* Для копирования онлайн репозитория для локального использования используется команда **git clone** плюс ссылка URL из вкладки "Code<>" на Github.

```sh
git clone https://github.com/username/repositiryname.git
```
### Просмотр удалённых URL-адресов

Просматривать удалённые URL-адреса можно параметром remote с флагом -v. Этот параметр отображает удалённые подключения к другим репозиториям.

```sh
git remote -v
```

Такая команда открывает доступ к интерфейсу управления удалёнными записями, которые хранятся в файле .git/config репозитория.

### Получение дополнительных сведений об удалённом репозитории

Получить подробные сведения об удалённом репозитории можно с помощью параметра remote show с указанием имени репозитория — например, origin.

```sh
git remote show origin
```

Эта команда отображает список веток, связанных с удалённым репозиторием, а также рабочих станций, подключённых для получения и отправки файлов.

### Отправка изменений в удалённый репозиторий

Отправлять изменения в удалённый репозиторий можно параметром push с указанием имени репозитория и ветки.

```sh
git push origin main
```

Эта команда передаёт локальные изменения в центральный репозиторий, где с ними могут ознакомиться другие участники проекта.

```sh
git push origin --delete <имя ветки> 

- удаление ветки при заливке локального репозитория в сеть
```

* Простыми словами git push - команда для заливки своего репозитория в интернет

### Получение изменений из удалённого репозитория

Для загрузки изменений из удалённого репозитория используется параметр pull. Он скачивает копию текущей ветки с указанного удалённого репозитория и объединяет её с локальной копией.

```sh
git pull
```

Также можно просмотреть подробные сведения о загруженных файлах с помощью флага --verbose.

```sh
git pull --verbose
```

```sh 
git pull --rebase этот ключ говорит о том, что мы скачиваем репозиторий с сервера, но свои изменения пытаемся в сеть слить. Команда произведет выкачку и слияние с нашей версией репозитория.
```
* Простыми словами git pull нужен для того, чтобы выкачать командой (pull) актуальное состояние из удаленного репозитория


