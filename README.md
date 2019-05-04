# .NetCore Sample WebApi Application

This Sample .Net Core 2.2 Web Api project demonstrating a simple layered application architecture with DB first approach.

## Prerequisites

With below command, connect to Sql Server Northwind DB for create NorthwindContext class and Pocos automatically.

```
Scaffold-DbContext "Server=.\;Database=NORTHWND;User ID=sa; Password=*****;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```


