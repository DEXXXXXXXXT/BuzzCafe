USE FoodOrdering_DB;

ALTER TABLE Order_Items ADD is_archived BIT DEFAULT 0;