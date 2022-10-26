# Описание сущностей
(имя поля, тип, ограничения, связь с другими сущностями)
## Аккаунт пользователя (User Accounts)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| email | VARCHAR(50) | not null | почта пользователя |
| password | VARCHAR(255) | not null | пароль пользователя |
## Карточка клиента (Client Cards)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| name | VARCHAR(128) | not null | ФИО пользователя |
| address | VARCHAR(50) | not null | адрес пользователя |
| phone | VARCHAR(13) | not null | номер пользователя |
| birthday | DATE | not null | дата рождения |
| storage | fk | not null | внешний ключ на хранилище |
| user | fk | not null | внешний ключ на пользователя |
## Картотека (Cards Storage)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| card | fk | not null | внешний ключ на карту клиента |
| section | VARCHAR(50) | - | отдел картотеки |
## Услуги (Services)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| name | VARCHAR(128) | not null | название услуги |
| cost | DECIMAL | not null | стоимость услуги |
| doctor | fk | not null | внешний ключ на врача |
| user | fk | not null | внешний ключ на клиента |
## Оборудование (Equipment)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| name | VARCHAR(128) | not null | название оборудования |
| cost | DECIMAL | not null | стоимость услуги |
| expiration | DATE | not null | срок возможного использования |
| start date | DATE | not null | начало использования |
## Информация о врачах (Doctors)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| name | VARCHAR(128) | not null | ФИО пользователя |
| post | VARCHAR(50) | not null | занимаемая должность |
| department | fk | not null | отделение клиники |
| experience | int | not null | опыт работы |
## Отделения (Departments)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| name | VARCHAR(128) | not null | название отделения |
address | VARCHAR(128) | not null | адрес отделения |
## Роли (Roles)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| name | VARCHAR(50) | not null | название роли |
## Роли пользователей (Users roles)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| userID | fk | not null | ID пользователя |
| roleID | fk | not null | ID роли |
## Логи (Logs)
|имя поля | тип | ограничения | описание |
|:---:|:---:|:---:|:---:|
| id | pk | auto increment; not null; unique | первичный ключ |
| user | fk | not null | внешний ключ на пользователя |
| type | VARCHAR(50) | not null | тип лога(CREATE/UPDATE/DELETE) |
| representation | VARCHAR(255) | not null | строковое представление изменённого кортежа |