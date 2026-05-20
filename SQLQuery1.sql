USE FoodOrdering_DB
SELECT
    o.order_id,
    o.order_date,
    o.order_type,
    p.name AS product_name,
    p.price,
    oi.quantity,
    oi.total_price_perItem,
    s.size_name,
    c.category_name -- ALISIN MO YUNG KUWIT (,) DITO SA DULO!
FROM Order_Items oi
INNER JOIN Orders o ON oi.order_id = o.order_id
INNER JOIN Products p ON oi.product_id = p.Product_id
INNER JOIN Sizes s ON oi.size_id = s.size_id
INNER JOIN Category c ON p.category_id = c.category_id