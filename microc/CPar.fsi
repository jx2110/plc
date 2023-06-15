// Signature file for parser generated by fsyacc
module CPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | LBRACE
  | RBRACE
  | LBRACK
  | RBRACK
  | SEMI
  | COMMA
  | ASSIGN
  | AMP
  | NOT
  | SEQOR
  | SEQAND
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | ADDASS
  | MINUSASS
  | TIMESASS
  | DIVASS
  | MODASS
  | ADDADD
  | MINUSMINUS
  | QUESTION
  | COLON
  | BOOL
  | CHAR
  | ELSE
  | IF
  | INT
  | FLOAT
  | NULL
  | PRINT
  | PRINTF
  | PRINTLN
  | RETURN
  | VOID
  | WHILE
  | FOR
  | IN
  | RANGE
  | DO
  | UNTIL
  | CASE
  | SWITCH
  | DEFAULT
  | BREAK
  | CONTINUE
  | CSTCHAR of (char)
  | CSTFLOAT of (float32)
  | CSTSTRING of (string)
  | NAME of (string)
  | CSTBOOL of (bool)
  | CSTINT of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_SEMI
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_AMP
    | TOKEN_NOT
    | TOKEN_SEQOR
    | TOKEN_SEQAND
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_ADDASS
    | TOKEN_MINUSASS
    | TOKEN_TIMESASS
    | TOKEN_DIVASS
    | TOKEN_MODASS
    | TOKEN_ADDADD
    | TOKEN_MINUSMINUS
    | TOKEN_QUESTION
    | TOKEN_COLON
    | TOKEN_BOOL
    | TOKEN_CHAR
    | TOKEN_ELSE
    | TOKEN_IF
    | TOKEN_INT
    | TOKEN_FLOAT
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_PRINTF
    | TOKEN_PRINTLN
    | TOKEN_RETURN
    | TOKEN_VOID
    | TOKEN_WHILE
    | TOKEN_FOR
    | TOKEN_IN
    | TOKEN_RANGE
    | TOKEN_DO
    | TOKEN_UNTIL
    | TOKEN_CASE
    | TOKEN_SWITCH
    | TOKEN_DEFAULT
    | TOKEN_BREAK
    | TOKEN_CONTINUE
    | TOKEN_CSTCHAR
    | TOKEN_CSTFLOAT
    | TOKEN_CSTSTRING
    | TOKEN_NAME
    | TOKEN_CSTBOOL
    | TOKEN_CSTINT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Topdecs
    | NONTERM_Topdec
    | NONTERM_Vardec
    | NONTERM_VardecAndAssign
    | NONTERM_Vardesc
    | NONTERM_Fundec
    | NONTERM_Paramdecs
    | NONTERM_Paramdecs1
    | NONTERM_Block
    | NONTERM_StmtOrDecSeq
    | NONTERM_Stmt
    | NONTERM_StmtM
    | NONTERM_StmtC
    | NONTERM_StmtU
    | NONTERM_Expr
    | NONTERM_ExprNotAccess
    | NONTERM_AtExprNotAccess
    | NONTERM_Access
    | NONTERM_Exprs
    | NONTERM_StmtCase
    | NONTERM_Exprs1
    | NONTERM_Const
    | NONTERM_ConstFloat
    | NONTERM_ConstBool
    | NONTERM_ConstChar
    | NONTERM_Type
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.program) 
