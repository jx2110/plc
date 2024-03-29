(* File MicroC/Absyn.fs
   Abstract syntax of micro-C, an imperative language.
   sestoft@itu.dk 2009-09-25

   Must precede Interp.fs, Comp.fs and Contcomp.fs in Solution Explorer
 *)

module Absyn

// 基本类型
// 注意，数组、指针是递归类型
// 这里没有函数类型，注意与上次课的 MicroML 对比
type typ =
  | TypI                             (* Type int                    *)
  | TypC                             (* Type char                   *)
  | TypF                             (* Type float                  *)
  | TypA of typ * int option         (* Array type                  *)
  | TypP of typ                      (* Pointer type                *)
  | TypB                             (* Type bool                 *)   
                                                                   
and expr =                           // 表达式，右值                                                
  | Access of access                 (* x    or  *p    or  a[e]     *) //访问左值（右值）
  | Assign of access * expr          (* x=e  or  *p=e  or  a[e]=e   *)
  | AddAss of access * expr          (* += 表达式 *)
  | MinusAss of access * expr        (* -= 表达式 *)
  | TimesAss of access * expr        (* *= 表达式 *)
  | DivAss of access * expr          (* /= 表达式 *)
  | ModAss of access * expr          (* %= 表达式 *)
  | Addr of access                   (* &x   or  &*p   or  &a[e]    *)
  | CstI of int                      (* Constant                    *)
  | CstF of float32                  (* Constant float              *)
  | CstB of bool                     (* Constant                    *)
  | CstC of char                     (* Constant                    *)
  | ToInt of expr
  | ToChar of expr
  // | ToFloat of expr
  | PrimPrint of char * expr 
  | Prim1 of string * expr           (* Unary primitive operator    *)
  | Prim2 of string * expr * expr    (* Binary primitive operator   *)
  | Prim3 of expr * expr * expr      (*         三目运算符           *)
  | Andalso of expr * expr           (* Sequential and              *)
  | Orelse of expr * expr            (* Sequential or               *)
  | Call of string * expr list       (* Function call f(...)        *)
  | AddAdd of access                 (* ++ *)   
  | MinusMinus of access             (* -- *)                                            
and access =                         //左值，存储的位置                                            
  | AccVar of string                 (* Variable access        x    *) 
  | AccDeref of expr                 (* Pointer dereferencing  *p   *)
  | AccIndex of access * expr        (* Array indexing         a[e] *)
                                                                   
and stmt =                                                         
  | If of expr * stmt * stmt         (* Conditional                 *)
  | While of expr * stmt             (* While loop                  *)
  | Expr of expr                     (* Expression statement   e;   *)
  | Return of expr option            (* Return from method          *)
  | Block of stmtordec list          (* Block: grouping and scope   *)
  | DoWhile of stmt * expr           (* dowhile loop*)
  | DoUntil of stmt * expr           (* dountil *)
  | For of expr * expr  * expr * stmt  (* For 循环*** *)
  | ForInRange of string * expr * stmt               (* 即 for x in range(x){...} *)
  | ForInRangein of string * expr * expr * stmt        (* 即 for x in range(x,y){...} *)
  | ForInRangebystep of string * expr * expr * expr * stmt (* 即 for x in range(x,y,2){...} *)

  | Switch of expr * stmt list       (* Switch分支，包括case和default*)
  | Case of expr * stmt
  | Default of stmt
  | Break
  | Continue

  // 语句块内部，可以是变量声明 或语句的列表                                                              
 

and stmtordec =                                                    
  | Dec of typ * string              (* Local variable declaration  *)
  | Stmt of stmt                     (* A statement                 *)
  | DecAndAssign of typ * string * expr
// 顶级声明 可以是函数声明或变量声明
and topdec = 
  | Fundec of typ option * string * (typ * string) list * stmt
  | Vardec of typ * string
  | VardecAndAssign of typ * string * expr
// 程序是顶级声明的列表
and program = 
  | Prog of topdec list
