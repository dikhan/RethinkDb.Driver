













//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Javascript : ReqlExpr  , IReqlFunction1Expr
 {

    
    
    
        public Javascript (object arg) : this(new Arguments(arg), null) {
        }
        public Javascript (Arguments args) : this(args, null) {
        }
        public Javascript (Arguments args, OptArgs optargs)
             : this(TermType.JAVASCRIPT, args, optargs) {
        }

    protected Javascript (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "timeout": "T_NUM"
///</summary>
        public Javascript optArg(string optname, object value) {
             var newOptargs = OptArgs.fromMap(this.OptArgs)
                                     .with(optname, value);
             return new Javascript (this.Args, newOptargs);
        }


    

    


    
    }
}
