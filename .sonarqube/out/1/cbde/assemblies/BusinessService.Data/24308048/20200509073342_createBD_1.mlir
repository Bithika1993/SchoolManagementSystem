// Skipping function Up(none), it contains poisonous unsupported syntaxes

func @_BusinessService.Data.Migrations.createBD.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :105 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :105 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :105 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :107 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :108 :22) // "Students" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :107 :12) // migrationBuilder.DropTable(                  name: "Students") (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :110 :12) // Not a variable of known type: migrationBuilder
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :111 :22) // "classes" (StringLiteralExpression)
%6 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :110 :12) // migrationBuilder.DropTable(                  name: "classes") (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :113 :12) // Not a variable of known type: migrationBuilder
%8 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :114 :22) // "Courses" (StringLiteralExpression)
%9 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :113 :12) // migrationBuilder.DropTable(                  name: "Courses") (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :116 :12) // Not a variable of known type: migrationBuilder
%11 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :117 :22) // "Schools" (StringLiteralExpression)
%12 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Migrations\\20200509073342_createBD.cs" :116 :12) // migrationBuilder.DropTable(                  name: "Schools") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
