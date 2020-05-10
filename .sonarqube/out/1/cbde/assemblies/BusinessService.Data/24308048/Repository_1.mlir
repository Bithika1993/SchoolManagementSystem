// Skipping function Get(i32), it contains poisonous unsupported syntaxes

func @_BusinessService.Data.Repositories.Repository$TEntity$.GetAll$$() -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :21 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :23 :23) // Not a variable of known type: context
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :23 :23) // context.Set<TEntity>() (InvocationExpression)
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :23 :23) // context.Set<TEntity>().ToList() (InvocationExpression)
return %2 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :23 :16)

^1: // ExitBlock
cbde.unreachable

}
func @_BusinessService.Data.Repositories.Repository$TEntity$.Add$TEntity$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :26 :8) {
^entry (%_entities : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :26 :24)
cbde.store %_entities, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :26 :24)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :28 :16) // Not a variable of known type: context
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :28 :16) // context.Set<TEntity>() (InvocationExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :28 :43) // Not a variable of known type: entities
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :28 :16) // context.Set<TEntity>().Add(entities) (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :29 :16) // Not a variable of known type: context
%6 = cbde.unknown : i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :29 :16) // context.SaveChanges() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Data.Repositories.Repository$TEntity$.Delete$int$(i32) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :32 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :32 :27)
cbde.store %_id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :32 :27)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :34 :29) // Not a variable of known type: context
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :34 :29) // context.Set<TEntity>() (InvocationExpression)
%3 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :34 :57)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :34 :29) // context.Set<TEntity>().Find(id) (InvocationExpression)
%6 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :35 :20) // Not a variable of known type: result
%7 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :35 :30) // null (NullLiteralExpression)
%8 = cbde.unknown : i1  loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :35 :20) // comparison of unknown type: result != null
cond_br %8, ^1, ^2 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :35 :20)

^1: // SimpleBlock
%9 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :37 :20) // Not a variable of known type: context
%10 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :37 :20) // context.Set<TEntity>() (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :37 :50) // Not a variable of known type: result
%12 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :37 :20) // context.Set<TEntity>().Remove(result) (InvocationExpression)
%13 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :38 :20) // Not a variable of known type: context
%14 = cbde.unknown : i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Data\\Repositories\\Repository.cs" :38 :20) // context.SaveChanges() (InvocationExpression)
br ^2

^2: // ExitBlock
return

}
