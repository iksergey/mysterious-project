# Схема базы данных 

![db_scheme](/Images/db_scheme.png)

СУБД - PostgreSQL

[Скрипт](PostgreSQL.sql) для создания и заполнения БД

Выборка данных
```
SELECT 
  tProducts.product_name,
  tCategories.categorу_name
FROM tProducts  
LEFT JOIN tRelationship ON tProducts.product_id = tRelationship.product_id
LEFT JOIN tCategories ON tRelationship.category_id = tCategories.category_id;
```