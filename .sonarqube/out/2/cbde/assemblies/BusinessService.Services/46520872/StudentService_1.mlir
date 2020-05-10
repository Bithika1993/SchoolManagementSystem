func @_BusinessService.Services.StudentService.Add$BusinessService.Domain.Model.Student$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :19 :8) {
^entry (%_entities : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :19 :24)
cbde.store %_entities, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :19 :24)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :21 :16) // Not a variable of known type: sqlStudentRepository
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :21 :41) // Not a variable of known type: entities
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :21 :16) // sqlStudentRepository.Add(entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.StudentService.Delete$int$(i32) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :24 :8) {
^entry (%_Id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :24 :27)
cbde.store %_Id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :24 :27)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :26 :16) // Not a variable of known type: sqlStudentRepository
%2 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :26 :44)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :26 :16) // sqlStudentRepository.Delete(Id) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.StudentService.GetAll$$() -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :29 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :31 :34) // Not a variable of known type: _cache
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :31 :51) // "Student" (StringLiteralExpression)
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :31 :34) // _cache.GetString("Student") (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :32 :20) // string (PredefinedType)
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :32 :41) // Not a variable of known type: Response
%6 = cbde.unknown : i1 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :32 :20) // string.IsNullOrEmpty(Response) (InvocationExpression)
cond_br %6, ^1, ^2 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :32 :20)

^1: // SimpleBlock
%7 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :34 :34) // Not a variable of known type: sqlStudentRepository
%8 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :34 :34) // sqlStudentRepository.GetAll() (InvocationExpression)
// Entity from another assembly: JsonSerializer
%10 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :35 :71) // Not a variable of known type: entitie
%11 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :35 :71) // entitie.ToList() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :35 :31) // JsonSerializer.Serialize<List<Student>>(entitie.ToList()) (InvocationExpression)
%13 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :36 :33) // new DistributedCacheEntryOptions() (ObjectCreationExpression)
%15 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :37 :20) // Not a variable of known type: _cache
%16 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :37 :37) // "Student" (StringLiteralExpression)
%17 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :37 :48) // Not a variable of known type: Response
%18 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :37 :58) // Not a variable of known type: option
%19 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :37 :20) // _cache.SetString("Student", Response, option) (InvocationExpression)
br ^2

^2: // JumpBlock
%20 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :39 :44) // new JsonSerializerOptions() (ObjectCreationExpression)
// Entity from another assembly: JsonSerializer
%22 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :40 :80) // Not a variable of known type: Response
%23 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :40 :90) // Not a variable of known type: opt
%24 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :40 :31) // JsonSerializer.Deserialize<IEnumerable<Student>>(Response, opt) (InvocationExpression)
%26 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :41 :23) // Not a variable of known type: entities
return %26 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :41 :16)

^3: // ExitBlock
cbde.unreachable

}
func @_BusinessService.Services.StudentService.GetAllStudentsDetails$$() -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :44 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :46 :34) // Not a variable of known type: sqlStudentRepository
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :46 :34) // sqlStudentRepository.GetAllStudentsDetails() (InvocationExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :47 :23) // Not a variable of known type: studentlist
return %3 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :47 :16)

^1: // ExitBlock
cbde.unreachable

}
func @_BusinessService.Services.StudentService.GetStudentsBySchoolId$int$(i32) -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :50 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :50 :58)
cbde.store %_id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :50 :58)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :52 :34) // Not a variable of known type: sqlStudentRepository
%2 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :52 :77)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :52 :34) // sqlStudentRepository.GetStudentsBySchoolId(id) (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :53 :23) // Not a variable of known type: studentlist
return %5 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :53 :16)

^1: // ExitBlock
cbde.unreachable

}
func @_BusinessService.Services.StudentService.Get$int$(i32) -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :57 :8) {
^entry (%_Id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :57 :27)
cbde.store %_Id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :57 :27)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :59 :31) // Not a variable of known type: sqlStudentRepository
%2 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :59 :82)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :59 :31) // sqlStudentRepository.GetStudentWithAcademicDetails(Id) (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :60 :23) // Not a variable of known type: Students
return %5 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :60 :16)

^1: // ExitBlock
cbde.unreachable

}
func @_BusinessService.Services.StudentService.Update$int.BusinessService.Domain.Model.Student$(i32, none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :63 :8) {
^entry (%_id : i32, %_entities : none):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :63 :28)
cbde.store %_id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :63 :28)
%1 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :63 :35)
cbde.store %_entities, %1 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :63 :35)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :65 :16) // Not a variable of known type: sqlStudentRepository
%3 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :65 :44)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :65 :48) // Not a variable of known type: entities
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\StudentService.cs" :65 :16) // sqlStudentRepository.update(id, entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
