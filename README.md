# MultiEdit - Приложение для одновременной работы с несколькими текстами


Задание 2
Модифицируйте WPF-приложение, разработанное в 3-ей лабораторной работе: используйте стили для
однотипных элементов управления.
https://github.com/ILYAPROKOFEV101/Lab04

Задание 3
Разработайте приложение MultiEdit для одновременной работы с несколькими текстами. Окно должно
быть разделено на две части с одинаковыми градиентами. В каждой части окна должно быть несколько
многострочных текстовых полей: одно из них большого размера с крупным шрифтом, а остальные
маленького размера с мелким шрифтом. То текстовое окно, в котором пользователь набирает текст,
должно быть большим, остальные текстовые поля должны быть маленькими. Внешний вид однотипных
элементов управления должен определяться с помощью стилей.
Изменить стиль элемента управления в коде можно следующим образом:
https://github.com/ILYAPROKOFEV101/LAb11-12/edit/master/README.md

Задание 2
Разработайте WPF-приложение с двумя многострочными текстовыми полями, кнопками «Открыть»,
«Очистить», «Закрыть» и выпадающим списком для задания внешнего вида текстовых полей. Задайте
для текстовых полей одинаковый градиентный фон. Кнопка «Закрыть» должна быть доступна только в
том случае, если в обоих текстовых полях нет текста. Задайте для кнопок различный внешний вид при
наведении курсора и при нажатии на них. Внешний вид текстовых полей (тип шрифта, размер шрифта,
цвет шрифта) должен меняться в зависимости от значения, выбранного в выпадающем списке.
https://github.com/ILYAPROKOFEV101/LABWPF11-12V6

## Описание проекта
MultiEdit — это приложение, разработанное для удобной работы с несколькими текстовыми полями одновременно. Основные особенности приложения:

- Окно разделено на две части с одинаковыми градиентными фонами.
- В каждой части окна расположены несколько многострочных текстовых полей:
  - Одно текстовое поле большого размера с крупным шрифтом.
  - Остальные текстовые поля маленького размера с мелким шрифтом.
- При фокусировке на текстовом поле оно автоматически увеличивается до большого размера, а остальные поля уменьшаются до маленького размера.
- Внешний вид элементов управления определяется с помощью стилей.

---

## Скриншот приложения

![MultiEdit](https://github.com/user-attachments/assets/0e957db0-162d-4874-9019-6ee37b336ab5)

---

## Требования к системе
Для работы приложения необходимы следующие компоненты:
- Операционная система: Windows 7 или выше.
- .NET Framework 4.7.2 или выше.

---


## Особенности реализации

### 1. Разметка (XAML)
- Используется `Grid` для разделения окна на две части.
- Каждая часть содержит несколько текстовых полей, оформленных с помощью стилей:
  - **BigTextBoxStyle**: стиль для большого текстового поля (крупный шрифт, большой размер).
  - **SmallTextBoxStyle**: стиль для маленьких текстовых полей (мелкий шрифт, небольшой размер).

### 2. Логика (C#)
- Обработка события `GotFocus` для текстовых полей:
  - При фокусировке на текстовом поле оно получает стиль `BigTextBoxStyle`, а остальные поля переводятся в стиль `SmallTextBoxStyle`.
- Для поиска всех текстовых полей используется рекурсивный метод `FindVisualChildren<T>`.

### 3. Градиенты
- Фон каждой части окна оформлен с использованием `LinearGradientBrush`. Градиенты создают приятный визуальный эффект.

---

## Структура проекта

### Папки и файлы
- **MainWindow.xaml**: Основной файл интерфейса приложения.
- **MainWindow.xaml.cs**: Файл с логикой приложения.
- **App.xaml**: Конфигурационный файл приложения.
- **Properties**: Папка с настройками проекта.

---

## Лицензия
Этот проект распространяется под лицензией MIT. Подробности см. в файле [LICENSE](LICENSE).


