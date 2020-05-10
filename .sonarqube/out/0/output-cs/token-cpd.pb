§
EC:\Project\SchoolManagementSystem\BusinessService.Domain\Constants.cs
	namespace 	
BusinessService
 
. 
Domain  
{ 
public 

static 
class 
	Constants !
{ 
public 
const 
string 
Success #
=$ %
$str& /
;/ 0
public 
const 
string 
Failure #
=$ %
$str& /
;/ 0
public 
const 
string 
NotFound $
=% &
$str' 1
;1 2
}		 
}

 Ð
IC:\Project\SchoolManagementSystem\BusinessService.Domain\HttpResponses.cs
	namespace 	
BusinessService
 
. 
Domain  
{ 
public 

class 
HttpResponses 
{ 
public 
int 

StatusCode 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
Message 
{ 
get  #
;# $
set% (
;( )
}* +
} 
}		 º
GC:\Project\SchoolManagementSystem\BusinessService.Domain\Model\Class.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Model! &
{ 
public 

class 
Class 
{ 
public 
int 
ClassId 
{ 
get  
;  !
set" %
;% &
}' (
[		 	
Required			 
]		 
public

 
string

 
	ClassName

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} ¿
IC:\Project\SchoolManagementSystem\BusinessService.Domain\Model\Course .cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Model! &
{ 
public 

class 
Course 
{ 
public 
int 
CourseId 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
] 
public		 
string		 

CourseName		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
public

 
string

 
Description

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
} 
} †

HC:\Project\SchoolManagementSystem\BusinessService.Domain\Model\School.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Model! &
{ 
public 

class 
School 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
[ 	
Required	 
] 
public		 
string		 

SchoolName		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
[

 	
Required

	 
]

 
public 
string 

SchoolType  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
Required	 
] 
public 
string 
City 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
public 
string 
Country 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ú
IC:\Project\SchoolManagementSystem\BusinessService.Domain\Model\Student.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Model! &
{ 
public 

class 
Student 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
[ 	
Required	 
] 
public		 
string		 
Name		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
[

 	
Required

	 
]

 
public 
string 
DOB 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Required	 
] 
public 
string 
Gender 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
City 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
public 
int 
CourseId 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
] 
public 
int 
SchoolId 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
] 
public 
int 
ClassId 
{ 
get  
;  !
set" %
;% &
}' (
public 
School 
school 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Course 
course 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Class 
classes 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} ’
OC:\Project\SchoolManagementSystem\BusinessService.Domain\Model\StudentDetail.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Model! &
{ 
public 

class 
StudentDetail 
{ 
public 
Student 
student 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
School 
school 
{ 
get "
;" #
set$ '
;' (
}) *
public		 
Course		 
course		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
}

 
} Ô
CC:\Project\SchoolManagementSystem\BusinessService.Domain\Program.cs
	namespace 	
BusinessService
 
. 
Domain  
{ 
public 

static 
class 
Program 
{ 
static 
void 
Main 
( 
string 
[  
]  !
args" &
)& '
{ 	
Console		 
.		 
	WriteLine		 
(		 
$str		 ,
)		, -
;		- .
}

 	
} 
} «
UC:\Project\SchoolManagementSystem\BusinessService.Domain\Services\IClassRepository.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Services! )
{ 
public 

	interface 
IClassRepository %
:% &
IRepository& 1
<1 2
Class2 7
>7 8
{ 
} 
} ®
VC:\Project\SchoolManagementSystem\BusinessService.Domain\Services\ICourseRepository.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Services! )
{ 
public 

	interface 
ICourseRepository &
:' (
IRepository( 3
<3 4
Course4 :
>: ;
{ 
} 
} ã
PC:\Project\SchoolManagementSystem\BusinessService.Domain\Services\IRepository.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Services! )
{ 
public 

	interface 
IRepository  
<  !
TEntity! (
>( )
where* /
TEntity0 7
:8 9
class: ?
{ 
TEntity 
Get 
( 
int 
Id 
) 
; 
void 
Add 
( 
TEntity 
entities !
)! "
;" #
void		 
Update		 
(		 
int		 
id		 
,		 
TEntity		 #
entities		$ ,
)		, -
;		- .
void

 
Delete

 
(

 
int

 
Id

 
)

 
;

 
IEnumerable 
< 
TEntity 
> 
GetAll #
(# $
)$ %
;% &
} 
} ®
VC:\Project\SchoolManagementSystem\BusinessService.Domain\Services\ISchoolRepository.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Services! )
{ 
public 

	interface 
ISchoolRepository &
:& '
IRepository' 2
<2 3
School3 9
>9 :
{ 
} 
} Š
WC:\Project\SchoolManagementSystem\BusinessService.Domain\Services\IStudentRepository.cs
	namespace 	
BusinessService
 
. 
Domain  
.  !
Services! )
{ 
public 

	interface 
IStudentRepository '
:' (
IRepository( 3
<3 4
Student4 ;
>; <
{ 
IEnumerable 
< 
Student 
> !
GetAllStudentsDetails 2
(2 3
)3 4
;4 5
IEnumerable		 
<		 
Student		 
>		 !
GetStudentsBySchoolId		 2
(		2 3
int		3 6
id		7 9
)		9 :
;		: ;
}

 
} 