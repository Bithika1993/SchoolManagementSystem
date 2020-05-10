func @_BusinessService.Data.BusinessServiceDbContext.OnConfiguring$Microsoft.EntityFrameworkCore.DbContextOptionsBuilder$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\BusinessServiceDbContext.cs" :11 :8) {
^entry (%_optionsBuilder : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\BusinessServiceDbContext.cs" :11 :46)
cbde.store %_optionsBuilder, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\BusinessServiceDbContext.cs" :11 :46)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\BusinessServiceDbContext.cs" :14 :12) // Not a variable of known type: optionsBuilder
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\BusinessServiceDbContext.cs" :14 :40) // "Data Source=tcp:schoolmngsystem.database.windows.net,1433;Initial Catalog=SchoolManagement-DB2;Persist Security Info=false;User ID=Bithika.hazra;Password=pass@1234;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=false;Connection Timeout=30" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\BusinessServiceDbContext.cs" :14 :12) // optionsBuilder.UseSqlServer("Data Source=tcp:schoolmngsystem.database.windows.net,1433;Initial Catalog=SchoolManagement-DB2;Persist Security Info=false;User ID=Bithika.hazra;Password=pass@1234;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=false;Connection Timeout=30") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
