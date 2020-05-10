func @_BusinessService.Services.Program.Main$string$$$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\Program.cs" :6 :8) {
^entry (%_args : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\Program.cs" :6 :25)
cbde.store %_args, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\Program.cs" :6 :25)
br ^0

^0: // SimpleBlock
// Entity from another assembly: Console
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\Program.cs" :8 :30) // "Hello World!" (StringLiteralExpression)
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\Program.cs" :8 :12) // Console.WriteLine("Hello World!") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
