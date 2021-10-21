# Entity Details


### Category

| Colum-Name                | Condesed-Type         | Nullable  |
|---------------------------|-----------------------|-----------|
| CategoryID                | int                   | No        |
| Name                      | nvarchar(MAX)         | Yes       |
| CategoryImage1            | nvarchar(MAX)         | Yes       |
| CategoryImage2            | nvarchar(MAX)         | Yes       |

| Products                  | ICollection<Product>  | Yes       |



### Product

| Colum-Name                | Condesed-Type         | Nullable  |
|---------------------------|-----------------------|-----------|
| ProductID                 | int                   | No        |
| ProductName               | nvarchar(MAX)         | Yes       |
| ProductDescription        | nvarchar(MAX)         | Yes       |
| ProductImagePath          | nvarchar(MAX)         | Yes       |
| Price                     | decimal(18, 2)        | No        |
| Amount                    | int                   | No        |
| Gender                    | bit                   | No        |
| FK_CategoryID             | int                   | No        |
|                           |                       |           |
| Category                  | Category              | Yes       |



### OrderItem

| Colum-Name                | Condesed-Type         | Nullable  |
|---------------------------|-----------------------|-----------|
| OrderItmeID               | int                   | No        |
| Amount                    | int                   | No        |
| FK_OrderID                | int                   | No        |
| FK_ProductID              | int                   | No        |
|                           |                       |           |
| Products                  | ICollection<Product>  | Yes       |
| Orders                    | Order                 | Yes       |




### Order

| Colum-Name                | Condesed-Type         | Nullable  |
|---------------------------|-----------------------|-----------|
| OrderID                   | int                   | No        |
| TotalPrice                | decimal(18, 2)        | No        |
| OrderDate                 | datetime2(7)          | No        |
| FK_CustomerID             | int                   | No        |
|                           |                       |           |
| Customer                  | Customer              | Yes       |
| OrderItem                 | ICollection<OrderItem>| Yes       |



### Customer

| Colum-Name                | Condesed-Type         | Nullable  |
|---------------------------|-----------------------|-----------|
| CustomerID                | int                   | No        |
| FirstName                 | nvarchar(MAX)         | Yes       |
| LastName                  | nvarchar(MAX)         | Yes       |
| Email                     | nvarchar(MAX)         | Yes       |
| PhoneNumber               | nvarchar(MAX)         | Yes       |
| City                      | nvarchar(MAX)         | Yes       |
| Adress                    | nvarchar(MAX)         | Yes       |
| ZipCode                   | nvarchar(MAX)         | Yes       |
| FK_UserID                 | int                   | Yes       |
|                           |                       |           |
| Orders                    | ICollection<Order>    | Yes       |
| User                      | User                  | Yes       |



### User

| Colum-Name                | Condesed-Type         | Nullable  |
|---------------------------|-----------------------|-----------|
| UserID                    | int                   | No        |
| FK_CustomerID             | int                   | No        |
|                           |                       |           |
| Customer                  | Customer              | Yes       |