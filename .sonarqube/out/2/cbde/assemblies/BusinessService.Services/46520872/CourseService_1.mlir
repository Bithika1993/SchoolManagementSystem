func @_BusinessService.Services.CourseService.Add$BusinessService.Domain.Model.Course$(none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :11 :8) {
^entry (%_entities : none):
%0 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :11 :24)
cbde.store %_entities, %0 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :11 :24)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :13 :15) // Not a variable of known type: sqlCourseRepository
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :13 :39) // Not a variable of known type: entities
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :13 :15) // sqlCourseRepository.Add(entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.CourseService.Delete$int$(i32) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :16 :8) {
^entry (%_Id : i32):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :16 :27)
cbde.store %_Id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :16 :27)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :18 :15) // Not a variable of known type: sqlCourseRepository
%2 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :18 :42)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :18 :15) // sqlCourseRepository.Delete(Id) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_BusinessService.Services.CourseService.GetAll$$() -> none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :22 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :24 :31) // Not a variable of known type: sqlCourseRepository
%1 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :24 :31) // sqlCourseRepository.GetAll() (InvocationExpression)
%3 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :25 :23) // Not a variable of known type: entities
return %3 : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :25 :16)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function Get(i32), it contains poisonous unsupported syntaxes

func @_BusinessService.Services.CourseService.Update$int.BusinessService.Domain.Model.Course$(i32, none) -> () loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :41 :8) {
^entry (%_id : i32, %_entities : none):
%0 = cbde.alloca i32 loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :41 :27)
cbde.store %_id, %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :41 :27)
%1 = cbde.alloca none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :41 :35)
cbde.store %_entities, %1 : memref<none> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :41 :35)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :43 :16) // Not a variable of known type: sqlCourseRepository
%3 = cbde.load %0 : memref<i32> loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :43 :43)
%4 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :43 :47) // Not a variable of known type: entities
%5 = cbde.unknown : none loc("C:\\Project\\SchoolManagementSystem\\BusinessService.Services\\CourseService.cs" :43 :16) // sqlCourseRepository.update(id, entities) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
