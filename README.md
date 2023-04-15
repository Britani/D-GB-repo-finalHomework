# Описание этапов решения итоговой домашней работы #
1. Открыть VS Code

   1.1  Создать папку;

   1.2 Открыть терминал и инициализировать репозиторий. Для этого ввести команду в терминале _git init_ ;

   1.3 Создать папку внутри репозитория;

   1.4 Открыть терминал и с помощью команды _dotnet new console_ создать проект;

   1.5 Создать файл _.gitignore_ для этого:
       
       1.5.1 перейти в терминал папки-репозитория;

       1.5.2 выполнить команду _dotnet new gitignore_ ;

   1.6 Выполнить команды _git add ._  -> _git commit -m "Добавить свой комментарий".

2. Создание удаленного репозитория. Для этого войти на GitHab, нажать кнопку _new_, следуя инструкции создать удаленный репозиторий. Все комиты будут сохранены в репозитории.

3. Создать алгоритм решения задачи в .drawio 
4. Написать программу 
  * обратиться к пользоателю за вводом размера массива

  * присвоить переменной size это значение

  * проверить корректность ввода данных с помощью ветвления в случае True

  * задать массив с размером size, заполнить его и вывести в консоль

  * задать новую переменную newSize которая будет содержать данные о размере  результирующего массива, применить метод  NewArraySize(collection)

  * задать новый массив размером newSize

  * заполнить результирующий массив и выведем его на печать с помощью методов FillNewArray(collection, newCollection) и PrintArrey(newCollection) соответственно.

  5. На всех этапах работы с репозиторием пушить актуальную информацию в удаленный репозиторий с помощью команды _git push_

  6. Создать файл README.md
  
  7. Отправить итоговое домашнее задание на проверку с помошью ссылки на удаленный репозиторий.
