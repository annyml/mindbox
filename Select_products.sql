select products.name, categories.name from products
left join product_categories on products.id = product_categories.product_id
left join categories on product_categories.category_id = categories.id