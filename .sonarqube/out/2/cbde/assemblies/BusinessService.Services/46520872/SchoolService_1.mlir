func @_BusinessService.Services.SchoolService.Add$BusinessService.Domain.Model.School$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :11 :8) {
^entry (%_entities : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :11 :24)
cbde.store %_entities, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :11 :24)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :13 :15) // Not a variable of known type: sqlSchoolRepository
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :13 :39) // Not a variable of known type: entities
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :13 :15) // sqlSchoolRepository.Add(entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.SchoolService.Delete$int$(i32) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :16 :8) {
^entry (%_Id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :16 :27)
cbde.store %_Id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :16 :27)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :18 :16) // Not a variable of known type: sqlSchoolRepository
%2 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :18 :43)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :18 :16) // sqlSchoolRepository.Delete(Id) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.SchoolService.GetAll$$() -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :21 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :23 :33) // Not a variable of known type: sqlSchoolRepository
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :23 :33) // sqlSchoolRepository.GetAll() (InvocationExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :24 :23) // Not a variable of known type: Schoollist
return %3 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :24 :16)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function Get(i32), it contains poisonous unsupported syntaxes

func @_BusinessService.Services.SchoolService.Update$int.BusinessService.Domain.Model.School$(i32, none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :40 :8) {
^entry (%_id : i32, %_entities : none):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :40 :27)
cbde.store %_id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :40 :27)
%1 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :40 :35)
cbde.store %_entities, %1 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :40 :35)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :42 :16) // Not a variable of known type: sqlSchoolRepository
%3 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :42 :43)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :42 :47) // Not a variable of known type: entities
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\SchoolService.cs" :42 :16) // sqlSchoolRepository.update(id, entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
