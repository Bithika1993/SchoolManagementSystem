func @_BusinessService.Services.ClassService.Add$BusinessService.Domain.Model.Class$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :11 :8) {
^entry (%_entities : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :11 :24)
cbde.store %_entities, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :11 :24)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :13 :16) // Not a variable of known type: sqlClassRepository
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :13 :39) // Not a variable of known type: entities
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :13 :16) // sqlClassRepository.Add(entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.ClassService.Delete$int$(i32) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :16 :8) {
^entry (%_Id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :16 :27)
cbde.store %_Id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :16 :27)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :18 :16) // Not a variable of known type: sqlClassRepository
%2 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :18 :42)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :18 :16) // sqlClassRepository.Delete(Id) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.ClassService.GetAll$$() -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :21 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :23 :32) // Not a variable of known type: sqlClassRepository
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :23 :32) // sqlClassRepository.GetAll() (InvocationExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :24 :23) // Not a variable of known type: classlist
return %3 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :24 :16)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function Get(i32), it contains poisonous unsupported syntaxes

func @_BusinessService.Services.ClassService.Update$int.BusinessService.Domain.Model.Class$(i32, none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :40 :8) {
^entry (%_id : i32, %_entities : none):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :40 :27)
cbde.store %_id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :40 :27)
%1 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :40 :35)
cbde.store %_entities, %1 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :40 :35)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :42 :16) // Not a variable of known type: sqlClassRepository
%3 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :42 :42)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :42 :46) // Not a variable of known type: entities
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\ClassService.cs" :42 :16) // sqlClassRepository.update(id, entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
