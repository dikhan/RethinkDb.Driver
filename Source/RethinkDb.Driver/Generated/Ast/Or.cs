













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

    public class Or : ReqlExpr  {

    
    
    
/// <summary>
/// <para>Compute the logical "or" of two or more values.</para>
/// </summary>
/// <example><para>Example: Return whether either <code>a</code> or <code>b</code> evaluate to true.</para>
/// <code>var a = true, b = false;
/// r.expr(a).or(b).run(conn, callback);
/// // result passed to callback
/// true
/// </code></example>
        public Or (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Compute the logical "or" of two or more values.</para>
/// </summary>
/// <example><para>Example: Return whether either <code>a</code> or <code>b</code> evaluate to true.</para>
/// <code>var a = true, b = false;
/// r.expr(a).or(b).run(conn, callback);
/// // result passed to callback
/// true
/// </code></example>
        public Or (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Compute the logical "or" of two or more values.</para>
/// </summary>
/// <example><para>Example: Return whether either <code>a</code> or <code>b</code> evaluate to true.</para>
/// <code>var a = true, b = false;
/// r.expr(a).or(b).run(conn, callback);
/// // result passed to callback
/// true
/// </code></example>
        public Or (Arguments args, OptArgs optargs)
             : this(TermType.OR, args, optargs) {
        }

    protected Or (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
