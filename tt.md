# Техническое задание
## Сущности
- Аккаунт пользователя
- Карточка клиента
- Картотека
- Услуги
- Оборудование
- Информация о врачах
- Отделения
- Роли
- Логи
---
<br>

## Роли
---
| ПРАВО/РОЛЬ | Посетитель | Врач | Регистратор | Бухгалтер | Администратор |
|---|:---:|:---:|:---:|:---:|:---:|
| Управление аккаунтами | - | - | - | - | + |
| Управление картами | - | + | - | - | + |
| Управление оборудованием | - | - | - | + | + |
| Обработка услуг | - | - | + | - | + |
| Заказ услуг | + | - | - | - | - |
| Просмотр карты | + | + | + | - | + |
| Журналирование | - | - | - | - | + |


<br>

## Аккаунт пользователя
---
При создании аккаунта пользователь должен указать следующие данные:
- ФИО
- Год рождения
- Адрес проживания
- Мобильный телефон
- Почта
- Пароль

Авторизация происходит при помощи почты и пароля.