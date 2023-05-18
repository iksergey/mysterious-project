DROP TABLE IF EXISTS tRelationship;
DROP TABLE IF EXISTS tProducts;
DROP TABLE IF EXISTS tCategories;

CREATE TABLE tProducts (
  product_id SERIAL PRIMARY KEY,
  product_name VARCHAR(255)
);

CREATE TABLE tCategories (
    category_id SERIAL PRIMARY KEY,
    categorу_name TEXT
);

CREATE TABLE tRelationship (
    product_id INT REFERENCES tProducts (product_id),
    category_id INT REFERENCES tCategories (category_id),
    PRIMARY KEY (product_id, category_id)
);

INSERT INTO tProducts (product_name)
VALUES ('Продукт 1'),
       ('Продукт 2'),
       ('Продукт 3'),
	   ('Продукт 4'),
	   ('Продукт 5'),
	   ('Продукт 6'),
	   ('Продукт 7'),
	   ('Продукт 8'),
	   ('Продукт 9')
	   ;

INSERT INTO tCategories (categorу_name)
VALUES ('Категория 1'),
       ('Категория 2'),
       ('Категория 3'),
	   ('Категория 4'),
	   ('Категория 5'),
	   ('Категория 6'),
	   ('Категория 7'),
	   ('Категория 8'),
	   ('Категория 9')
	   ;

INSERT INTO tRelationship (product_id, category_id)
VALUES (1, 1), (1, 9),
       (2, 1), (2, 2), (2, 4), (2, 9),
       (3, 2),  (3, 3), (3, 4), (3, 7),
       (4, 1), (4, 5), (4, 7),
       (5, 7), (5, 9)
       ;

SELECT
  * 
FROM tProducts;

SELECT
  * 
FROM tCategories;

SELECT
  * 
FROM tRelationship;


SELECT 
  tProducts.product_name,
  tCategories.categorу_name
FROM tProducts  
LEFT JOIN tRelationship ON tProducts.product_id = tRelationship.product_id
LEFT JOIN tCategories ON tRelationship.category_id = tCategories.category_id;